namespace Funcery
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model();
            var viewModel = new ViewModel(model.GetUpdateFunction("user"));

            viewModel.FirstName = "Bob";
            viewModel.LastName = "Jones";
        }
    }
}
