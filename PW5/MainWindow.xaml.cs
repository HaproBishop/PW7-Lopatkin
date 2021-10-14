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
/// Практическая работа №6. Задание 8. 
/// Использовать класс Pair (пара четных чисел). 
/// Разработать операцию инкремента - (a, b) = (a + b, b). 
/// Разработать операцию для вычисления произведения 2-х пар чисел - (a, b) * (c, d) = (a * c, b * d)"
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

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа имеет следующие особенности:\n1) Необходимо вводить только четные числа для вычисления.\n2) Максимальное число для ввода в полях - пятизначное.", "Справка", MessageBoxButton.OK, MessageBoxImage.Information);            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №7. Задание 8. Использовать класс Pair (пара четных чисел). Определить производный класс Rectangle(прямоугольник) с характеристиками стороны прямоугольника. Определить методы вычисления периметра и площади прямоугольника.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);

        }

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
                LibPair.Rectangle myrect = new LibPair.Rectangle(value1, value2);
                myrect.FindSquareAndPerimeter();
                if (myrect.Result != null)
                {
                    FirstResult.Text = myrect.Result[0].ToString();
                    SecondResult.Text = myrect.Result[1].ToString();
                }
                else MessageForUser(false);
            }
            else MessageForUser(true);
        }/// <summary>
        /// Используется для уведомления пользователя о конкретных ошибках, 
        /// вызванных неправильным общением с программой
        /// </summary>
        /// <param name="isemptystring">isemptystring - значение пустой строки, true - пустая строка, false - не пустая строка</param>
        public static void MessageForUser(bool isemptystring)
        {
            if(isemptystring == true)
                MessageBox.Show("У вас некорректно введены значения для проведения произведения! Подробности об особенностях работы программы написаны в справке!", "ОШИБКА!", MessageBoxButton.OK, MessageBoxImage.Error);
            else 
                MessageBox.Show("У вас введены нечетные(ое) числа(о)! Пожалуйства, введите значения в соответствии с требованиями!", "ОШИБКА!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
