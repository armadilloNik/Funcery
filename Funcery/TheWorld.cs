using System;
using System.Collections.Generic;

namespace Funcery
{
    public class ViewModel
    {
        private readonly Action<string, string> _updateAction;

        private string _first;
        private string _last;

        private void UpdateFirstName(string value)
        {
            _updateAction("FirstName", value);
        }

        private void UpdateLastName(string value)
        {
            _updateAction("LastName", value);
        }

        public ViewModel(Action<string, string> updateAction)
        {
            _updateAction = updateAction;
        }

        public string FirstName
        {
            get { return _first; }
            set
            {
                _first = value;
                UpdateFirstName(_first);
            } 
        }
        public string LastName
        {
            get { return _last; }
            set
            {
                _last = value;
                UpdateLastName(_last);
            }
        }
    }

    public class Model
    {
        public Dictionary<string, string> Db = new Dictionary<string, string>();

        private bool Validate(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        private void UpdateDb(string prop, string value)
        {
            Db[prop] = value;
            Console.WriteLine($"property: {prop} value changed to: {value}");
        }
        
        public Action<string, string> GetUpdateFunction()
        {
            Action<string, string> updateThingy = (prop, value) =>
            {
                if (Validate(value))
                {
                    UpdateDb(prop, value);
                }
            };

            return updateThingy;
        }
    }
}
