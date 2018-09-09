using System.Windows;

namespace NP.Tests.DragDropFromListToList
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
