using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFBooksDemo
{
    class InheritTheApp: Application
    {
        [STAThread]
        public static void Main()
        {
            InheritTheApp app = new InheritTheApp();
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window win = new Window();
            win.Title = "Inherit the App";
            win.Show();
        }
    }
}
