namespace DallE3AutomationProgramP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DallE3AutomationProgram());
        }
    }
}