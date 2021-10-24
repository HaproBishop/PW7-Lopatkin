using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPair
{
    public class Rectangle:Pair
    {
        public Rectangle() { }
        public Rectangle(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        /// <summary>
        /// Находит площадь и периметр
        /// </summary>
        /// <returns>Новый объект с результатами</returns>
        public Rectangle FindSquareAndPerimeter()
        {
            return new Rectangle() { Value1 = _value1 * _value2, Value2 = _value1 * 2 + _value2 * 2 };
        }
    }
}
