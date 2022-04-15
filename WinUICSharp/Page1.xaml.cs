using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace WinUICSharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            NavigationCacheMode = Microsoft.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            _ = Frame.Navigate(typeof(Page2), name.Text);
        }
    }
}
