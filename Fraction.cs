using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace LibraryFraction
{
    public static class Fraction
    {
        /// <summary>
        /// Пусть имеется строка вида "N/M", где N - первое число, M - второе число. Так получилось, что в некоторых ситуациях значение N превышает значение M. Реализуйте метод, который бы в случае, когда N > M поменял бы первое число на второе(см. примеры)
        /// </summary>
        /// <param name="text">В качестве параметра передается строка. Гарантируется (не нужно это проверять, значение “заложено” условием задачи), что строка имеет вид "ЧИСЛО1/ЧИСЛО2". Гарантируется, что оба числовых значения корректны, положительны и умещаются в стандартный тип int.</param>
        /// <returns>Метод возвращает строку, представляющую “исправленный результат”.</returns>
        public static string FixWrongResult(string text)
        {
            string regex = @"[0-9]";
            string[] num = text.Split('/');
            if (!(num.Length == 2))
            {
                throw new Exception("Получилось более двух входящих выражений");
            }
            foreach (var item in num)
            {
                if (!(Regex.IsMatch(item,regex, RegexOptions.IgnoreCase)))
                {
                    throw new Exception("Введёно не число");
                }
            }
            if (text == null)
            {
                throw new Exception("Строка пустая");
            }
            if ( Convert.ToInt32(num[0]) > Convert.ToInt32(num[1]))
            {
                num[0] = num[1];
            }
            return text;
        }
    }
}
