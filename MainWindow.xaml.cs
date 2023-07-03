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

namespace Шемарулин_задание_15
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            string input = kolichestvo.Text; // получаем значение из textBox
            int length = int.Parse(input); // конвертируем значение в int
            int[] numbers = new int[length]; // создаем массив
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            { // заполняем элементы массива случайными числами
                numbers[i] = rand.Next(-10, 11 + 1);
            }
            massiv.Text = string.Join(", ", numbers); // выводим заполненный массив на textBox2

            double[] arr = massiv.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            double product = 1;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    product *= arr[i];
                    count++;
                }
            }


            MessageBox.Show($"Сумма положительных элементов массива равна {product}.");
        }
    }
}
