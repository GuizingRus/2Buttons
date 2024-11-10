using System.Text;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<int> _numbers = new ObservableCollection<int>();
        public ObservableCollection<int> Numbers => _numbers;

        //public ObservableCollection<int> SelectedIndex = Numbers;

        public MainWindow()
        {
            InitializeComponent();
            lvEntries.ItemsSource = _numbers;
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            int count = Numbers.Count;
            Numbers.Add(count);
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            int index = lvEntries.SelectedIndex;
            Numbers.RemoveAt(index);
        }

        private void BtnClr_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Clear();
        }
    }
}