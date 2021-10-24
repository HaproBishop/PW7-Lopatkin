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
using LibPair;
/// <summary>
/// Практическая работа №7. Задание 8. 
/// Использовать класс Pair (пара четных чисел). 
/// Определить производный класс Rectangle(прямоугольник) с характеристиками стороны прямоугольника. 
/// Определить методы вычисления периметра и площади прямоугольника.
/// </summary>
namespace PW5
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
        LibPair.Rectangle myrect = new LibPair.Rectangle();
        private void Support_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа имеет следующие особенности:\n1) Необходимо вводить только четные числа для вычисления.\n2) Максимальное число для ввода в полях - пятизначное.", "Справка", MessageBoxButton.OK, MessageBoxImage.Information);            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №7. Задание 8. Использовать класс Pair (пара четных чисел). Определить производный класс Rectangle(прямоугольник) с характеристиками стороны прямоугольника. Определить методы вычисления периметра и площади прямоугольника.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        /// <summary>
        /// Используется для очистки строк с результатами при изменении начальных значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            FirstResult.Clear();
            SecondResult.Clear();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {            
            bool ProveValue1 = int.TryParse(FirstValue.Text, out int value1);
            bool ProveValue2 = int.TryParse(SecondValue.Text, out int value2);
            if (ProveValue1 == true && ProveValue2 == true)
            {
                myrect.AddValue(value1, value2);
                myrect = myrect.FindSquareAndPerimeter();
                FirstResult.Text = myrect.Value1.ToString();
                SecondResult.Text = myrect.Value2.ToString();                                
            }
            else MessageBox.Show(Pair.InfoUser, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
