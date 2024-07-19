using CalculatorView = basicCalculator.Form1;

namespace basicCalculator
{

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new CalculatorModel();
            var view = new CalculatorView();
            var controller = new CalculatorController(model, view);

            Application.Run(view);
        }
    }

}