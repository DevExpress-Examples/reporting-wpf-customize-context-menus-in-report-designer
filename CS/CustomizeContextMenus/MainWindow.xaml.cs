using System.Windows;

namespace CustomizeContextMenus {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void bAbout_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("About Window", "About");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            reportDesigner.OpenDocument(new XtraReport1());
        }
    }
}
