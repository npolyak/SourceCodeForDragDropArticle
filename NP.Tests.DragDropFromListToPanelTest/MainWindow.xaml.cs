using System.Windows;

namespace NP.Tests.DragDropFromListToPanelTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new TestVm();
        }
    }
}
