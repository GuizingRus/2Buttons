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
    public partial class MainWindow : Window
    {
        private int Count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(Count.ToString());
            Count++;
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {

            var items = lvEntries.SelectedItems.Cast<string>().ToList();

            if (items != null)
            {
                foreach (var item in items)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }

        private void BtnClr_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
            Count = 0;
        }
    }
}
