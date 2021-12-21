using System;
using System.IO;
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
using System.Windows.Shapes;

namespace Training
{
    /// <summary>
    /// Логика взаимодействия для Calendar.xaml
    /// </summary>
    public partial class Calendar : Window
    {

        string data_calendar = @"C:\Users\Dell\Documents\GIT\Training_Git\TrainingDiary\TrainingDiary\bin\Debug\Календарь.txt";

        public Calendar()
        {
            InitializeComponent();
        }

        private void Back_Ground3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(data_calendar, true, Encoding.GetEncoding(866)))
                stream.WriteLine(TextBox_Calendar.Text);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Calendar.Text = "";
        }

        private void Output_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader stream = new StreamReader(data_calendar, Encoding.GetEncoding(866)))
                TextBox_Calendar.Text += stream.ReadToEnd();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(data_calendar, "");
            TextBox_Calendar.Text = "";
        }
    }
}
