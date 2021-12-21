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
using System.Text.RegularExpressions;
using Lib;

namespace Training
{
    /// <summary>
    /// Логика взаимодействия для Chart.xaml
    /// </summary>
    public partial class Chart : Window
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Back_Ground2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Calendar1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textt.Text = " ";
                string fileName = @"ВерхТела1.txt";
                string[] lines = File.ReadAllLines(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                {   
                    foreach (string line in lines)
                        if (!string.IsNullOrWhiteSpace(line))
                            writer.WriteLine(line);
                }
                
                string[] mass = File.ReadAllLines(@"ВерхТела1.txt");
                int[] num = new int[mass.Length];
                Lib.CustomControl1.puz(num, mass);
                Random rnd = new Random(num.Length);
                StreamReader openFile = new StreamReader(@"ФИО1.txt", Encoding.GetEncoding(866));
                string[] FIO = File.ReadAllLines(@"ФИО1.txt");
                for (int n = 0; n < num.Length; n++)
                {

                    int value = rnd.Next(1, num.Length + 1);
                    textt.Text += (FIO[value] + " с результатом: " + num[n]) + Environment.NewLine;
                }

            }
            catch
            {
                textt.Text = ("Проверьте файл на наличие текстовых символов !");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                textt.Text = " ";
                string fileName = @"НизТела1.txt";
                string[] lines = File.ReadAllLines(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string line in lines)
                        if (!string.IsNullOrWhiteSpace(line))
                            writer.WriteLine(line);
                }
                string[] mass = File.ReadAllLines(@"НизТела1.txt");
                int[] num = new int[mass.Length];
                Lib.CustomControl1.puz(num, mass);
                Random rnd = new Random(num.Length);
                StreamReader openFile = new StreamReader(@"ФИО1.txt", Encoding.GetEncoding(866));
                string[] FIO = File.ReadAllLines(@"ФИО1.txt");
                for (int n = 0; n < num.Length; n++)
                {

                    int value = rnd.Next(1, num.Length + 1);
                    textt.Text += (FIO[value] + " с результатом: " + num[n]) + Environment.NewLine;
                }

            }
            catch
            {
                textt.Text = ("Проверьте файл на наличие текстовых символов !");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                textt.Text = " ";
                string fileName = @"Руки1.txt";
                string[] lines = File.ReadAllLines(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string line in lines)
                        if (!string.IsNullOrWhiteSpace(line))
                            writer.WriteLine(line);
                }
                string[] mass = File.ReadAllLines(@"Руки1.txt");
                int[] num = new int[mass.Length];
                Lib.CustomControl1.puz(num, mass);
                Random rnd = new Random(num.Length);
                StreamReader openFile = new StreamReader(@"ФИО1.txt", Encoding.GetEncoding(866));
                string[] FIO = File.ReadAllLines(@"ФИО1.txt");
                for (int n = 0; n < num.Length; n++)
                {

                    int value = rnd.Next(1, num.Length + 1);
                    textt.Text += (FIO[value] + "с результатом: " + num[n]) + Environment.NewLine;
                }

            }
            catch
            {
                textt.Text = ("Проверьте файл на наличие текстовых символов !");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                textt.Text = " ";
                string fileName = @"ВерхТела1.txt";
                string[] lines = File.ReadAllLines(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string line in lines)
                        if (!string.IsNullOrWhiteSpace(line))
                            writer.WriteLine(line);
                }
                string[] mass = File.ReadAllLines(@"ВерхТела1.txt");
                int[] num = new int[mass.Length];
                Lib.CustomControl1.puz(num, mass);
                Random rnd = new Random(num.Length);
                StreamReader openFile = new StreamReader(@"ФИО1.txt", Encoding.GetEncoding(866));
                string[] FIO = File.ReadAllLines(@"ФИО1.txt");
                int[] number = new int[mass.Length];
                for (int i = 0; i < num.Length; i++)
                {
                    int value = rnd.Next(1, num.Length + 1);
                    number[i] = value;
                }
                Array.Reverse(number);
                for (int n = 0; n < num.Length; n++)
                {
                    int value = number[n];
                    textt.Text += (FIO[value] + " с результатом: " + num[n]) + Environment.NewLine;
                }

            }
            catch
            {
                textt.Text = ("Проверьте файл на наличие текстовых символов !");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                textt.Text = " ";
                string fileName = @"НизТела1.txt";
                string[] lines = File.ReadAllLines(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string line in lines)
                        if (!string.IsNullOrWhiteSpace(line))
                            writer.WriteLine(line);
                }
                string[] mass = File.ReadAllLines(@"НизТела1.txt");
                int[] num = new int[mass.Length];
                Lib.CustomControl1.puz(num, mass);
                Random rnd = new Random(num.Length);
                StreamReader openFile = new StreamReader(@"ФИО1.txt", Encoding.GetEncoding(866));
                string[] FIO = File.ReadAllLines(@"ФИО1.txt");
                int[] number = new int[mass.Length];
                for (int i = 0; i < num.Length; i++)
                {
                    int value = rnd.Next(1, num.Length + 1);
                    number[i] = value;
                }
                Array.Reverse(number);
                for (int n = 0; n < num.Length; n++)
                {
                    int value = number[n];
                    textt.Text += (FIO[value] + " с результатом: " + num[n]) + Environment.NewLine;
                }

            }
            catch
            {
                textt.Text = ("Проверьте файл на наличие текстовых символов !");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                textt.Text = " ";
                string fileName = @"Руки1.txt";
                string[] lines = File.ReadAllLines(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string line in lines)
                        if (!string.IsNullOrWhiteSpace(line))
                            writer.WriteLine(line);
                }
                string[] mass = File.ReadAllLines(@"Руки1.txt");
                int[] num = new int[mass.Length];
                Lib.CustomControl1.puz(num, mass);
                Random rnd = new Random(num.Length);
                StreamReader openFile = new StreamReader(@"ФИО1.txt", Encoding.GetEncoding(866));
                string[] FIO = File.ReadAllLines(@"ФИО1.txt");
                int[] number = new int[mass.Length];
                for (int i = 0; i < num.Length; i++)
                {
                    int value = rnd.Next(1, num.Length + 1);
                    number[i] = value;
                }
                Array.Reverse(number);
                for (int n = 0; n < num.Length; n++)
                {
                    int value = number[n];
                    textt.Text += (FIO[value] + " с результатом: " + num[n]) + Environment.NewLine;
                }

            }
            catch
            {
                textt.Text = ("Проверьте файл на наличие текстовых символов !");
            }
        }

        public int NULL { get; set; }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(@"ВерхТела1.txt"))
            {
                StreamWriter writer = new StreamWriter(@"ВерхТела1.txt", false, Encoding.GetEncoding(866));
                writer.Write(textt.Text);
                writer.Close();
            }
            else
            {
                using (var writer = new StreamWriter(@"ВерхТела1.txt", true, Encoding.GetEncoding(866)))
                {
                    //Добавляем к старому содержимому файла
                    writer.WriteLine(textt.Text);
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

            textt.Text = "";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(@"НизТела1.txt"))
            {
                StreamWriter writer = new StreamWriter(@"НизТела1.txt", false, Encoding.GetEncoding(866));
                writer.Write(textt.Text);
                writer.Close();
            }
            else
            {
                using (var writer = new StreamWriter(@"НизТела1.txt", true, Encoding.GetEncoding(866)))
                {
                    //Добавляем к старому содержимому файла
                    writer.WriteLine(textt.Text);
                }
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(@"Руки1.txt"))
            {
                StreamWriter writer = new StreamWriter(@"Руки1.txt", false, Encoding.GetEncoding(866));
                writer.Write(textt.Text);
                writer.Close();
            }
            else
            {
                using (var writer = new StreamWriter(@"Руки1.txt", true, Encoding.GetEncoding(866)))
                {
                    writer.WriteLine(textt.Text);
                }
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(@"ФИО1.txt"))
            {
                StreamWriter writer = new StreamWriter(@"ФИО1.txt", false, Encoding.GetEncoding(866));
                writer.Write(textt.Text);
                writer.Close();
            }
            else
            {
                using (var writer = new StreamWriter(@"ФИО1.txt", true, Encoding.GetEncoding(866)))
                {
                    writer.WriteLine(textt.Text);
                }
            }
        }

    }
}
