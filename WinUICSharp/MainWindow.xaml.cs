using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUICSharp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Content = naviFrame;
            // 无需手动设置此 Frame 为 Content，当 Window 中只有一个元素且为Frame时，它就是Content。
            // 当Window中没有 Frame 标签，Window.Content 就是 null。
            // 因为 Window 只能有一个直接子元素，所以要么是 Frame 要么不是。
            // 嵌套在内部的Frame无效。
            // Frame中可以有内容，但是Frame也只能有一个直接子元素，作为Content。
        }

        //private void myButton_Click(object sender, RoutedEventArgs e)
        //{
        //    myButton.Content = "Clicked";
        //}
    }
}
