using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Training
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void But_TrD_Click(object sender, RoutedEventArgs e)
        {
            new TrainingDiary().ShowDialog();
        }

        private void But_Chr_Click(object sender, RoutedEventArgs e)
        {
            new Chart().ShowDialog();
        }

        private void But_Cal_Click(object sender, RoutedEventArgs e)
        {
            new Calendar().ShowDialog();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (cmd.SelectedIndex == 0)
                Properties.Settings.Default.languageCode = "ru-RU";
            else
                Properties.Settings.Default.languageCode = "en-US";
            Properties.Settings.Default.Save();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

    }
}
