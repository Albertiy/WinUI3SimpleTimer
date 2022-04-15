using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;

namespace WinUICSharp
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            //m_window.Activate();

            //Window.Current = m_window;    // 这玩意始终是null，怎么回事啊？而且它是只读的。

            //Frame rootFrame = m_window.Content as Frame;
            //Console.WriteLine("NameOfRootFrame:" + rootFrame.Name);

            //if (rootFrame == null)
            //{
            //    rootFrame = new Frame();
            //    rootFrame.NavigationFailed += OnNavigationFailed;

            //    // 错误：LaunchActivatedEventArgs.PreviousExecutionState 不存在，这个教程中的代码应当是陈旧的。
            //    //if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
            //    //{
            //    //    // TODO: Load state from previously suspended application
            //    //}

            //    //Place the frame in the current Window
            //    m_window.Content = rootFrame;
            //}

            ////if (rootFrame.Content == null)
            ////{
            //    rootFrame.Navigate(typeof(Page1), args.Arguments);
            ////}

            m_window.Activate();
        }

        ///* 响应导航失败事件 */
        //private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private Window m_window;
    }
}
