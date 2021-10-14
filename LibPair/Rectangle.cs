using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPair
{
    public class Rectangle:Pair
    {
        public Rectangle(int value1, int value2)
        {
            _value1 = value1;
            _value2 = value2;
        }
        /// <summary>
        /// Находит площадь и периметр 
        /// </summary>
        /// <returns>Данные объекта или null, в случае ошибки на проверку четности</returns>
        public void FindSquareAndPerimeter()
        {
            if (ProveSquareAndPerimetr() == true)
            {
                _result = new int[2];
                _result[0] = _value1 * _value2;
                _result[1] = _value1 * 2 + _value2 * 2;
            }
        }/// <summary>
        /// Заприваченный метод проверки на четность числе, введенных пользователем
        /// </summary>
        /// <returns>false - при непрохождении чисел на четность, true - при прохождении</returns>
        private bool ProveSquareAndPerimetr()
        {
            if (_value1 % 2 == 0 && _value2 % 2 == 0) return true;            
            else return false;
        }
    }
}
