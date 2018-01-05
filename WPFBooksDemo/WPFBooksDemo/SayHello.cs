using System;
using System;
using System.Windows;
using System.Windows.Input;

namespace WPFBooksDemo
{
    class SayHello
    {
        //[STAThread]
        //public static void Main()
        //{
        //    Window win = new Window();
        //    win.Title = "Say Hello";
        //    win.MouseDown += Win_MouseDown;
        //   // win.Show();

        //    Application app = new Application();
        //    //app.Run();

        //    app.Run(win);
        //}

        private static void Win_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window win = sender as Window;
            string strMessage =
                string.Format("Window clickd with {0} button at point ({1}) )",
                e.ChangedButton, e.GetPosition(win));
            //MessageBox.Show(strMessage, win.Title);

            MessageBox.Show(strMessage, Application.Current.MainWindow.Title);
        }
    }
}
