namespace Funcery
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model();
            var viewModel = new ViewModel(model.GetUpdateFunction());

            viewModel.FirstName = "Bob";
            viewModel.LastName = "Jones";

        }
    }
}
