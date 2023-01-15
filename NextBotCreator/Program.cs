using System;
using System.Windows.Forms;

namespace NextBotCreator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static ApplicationContext Context { get; set; }

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Context = new ApplicationContext(new MainForm());

            Application.Run(Context);
        }
    }
}
