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
    /// Логика взаимодействия для TrainingDiary.xaml
    /// </summary>
    public partial class TrainingDiary : Window
    {
        
        public TrainingDiary()
        {
            InitializeComponent();
        }

        private void Back_Ground1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Verx_Click(object sender, RoutedEventArgs e)
        {

        int index = Vib.SelectedIndex;
        switch(index)
        {
            case 0:
                if (!File.Exists(@"ВерхТела.txt"))
                {
                    StreamWriter writer = new StreamWriter(@"ВерхТела.txt", false, Encoding.UTF8);
                    writer.Write(RecordigText.Text);
                    writer.Close();
                }
                else
                {
                    using (var writer = new StreamWriter(@"ВерхТела.txt", true, Encoding.UTF8))
                    {
                        //Добавляем к старому содержимому файла
                        writer.WriteLine(RecordigText.Text);
                    }
                }
            break;

            case 1:
            StreamReader openFile = new StreamReader(@"ВерхТела.txt", Encoding.UTF8);//вывод
            RecordigText.Text += openFile.ReadToEnd();
            openFile.Close();
            break;

            case 2:
            File.Create(@"ВерхТела.txt").Close();  
            break;
         }

        }

        private void Niz_Click(object sender, RoutedEventArgs e)
        {
            int index = Vib.SelectedIndex;
            switch (index)
            {
                case 0:
                    if (!File.Exists(@"НизТела.txt"))
                    {
                        StreamWriter writer = new StreamWriter(@"НизТела.txt", false, Encoding.UTF8);
                        writer.Write(RecordigText.Text);
                        writer.Close();
                    }
                    else
                    {
                        using (var writer = new StreamWriter(@"НизТела.txt", true, Encoding.UTF8))
                        {
                            //Добавляем к старому содержимому файла
                            writer.WriteLine(RecordigText.Text);
                        }
                    }
                    break;

                case 1:
                    StreamReader openFile = new StreamReader(@"НизТела.txt", Encoding.UTF8);//вывод
                    RecordigText.Text += openFile.ReadToEnd();
                    openFile.Close();
                    break;

                case 2:
                    File.Create(@"НизТела.txt").Close();  
                    break;
            }
        }

        private void Ryki_Click(object sender, RoutedEventArgs e)
        {

            int index = Vib.SelectedIndex;
            switch (index)
            {
                case 0:
                    if (!File.Exists(@"Руки.txt"))
                    {
                        StreamWriter writer = new StreamWriter(@"Руки.txt", false, Encoding.UTF8);
                        writer.Write(RecordigText.Text);
                        writer.Close();
                    }
                    else
                    {
                        using (var writer = new StreamWriter(@"Руки.txt", true, Encoding.UTF8))
                        {
                            //Добавляем к старому содержимому файла
                            writer.WriteLine(RecordigText.Text);
                        }
                    }
                    break;

                case 1:
                    StreamReader openFile = new StreamReader(@"Руки.txt", Encoding.UTF8);//вывод
                    RecordigText.Text += openFile.ReadToEnd();
                    openFile.Close();
                    break;

                case 2:
                    File.Create(@"Руки.txt").Close();  
                    break;
            }
        }

        private void Clean_SelectionChanged(object sender, RoutedEventArgs e)
        {
            RecordigText.Text = " ";
        }

    }
}
