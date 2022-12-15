using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        // Д/З №1 - 5 занятие
        static void Main(string[] args)
        {
            //Переменные
            int tableSize = 0;
            string textUser = string.Empty;
            int countCharText = 0;

            //Запрос данных у пользователя
            while (true)
            {
                Console.WriteLine("Введите размерность таблицы:");
                var resultBool = int.TryParse(Console.ReadLine(), out tableSize);
                //Проверка
                if (resultBool && tableSize >= 1 && tableSize <= 6)
                {
                    Console.WriteLine("Введите произвольный текст:");
                    textUser = Console.ReadLine();
                    //Проверка
                    if (textUser != string.Empty && (tableSize * 2) + textUser.Length <= 40)
                    {
                        countCharText = textUser.Length;
                        break;
                    }
                    else Console.WriteLine("Ширина таблицы превышает 40 символов");
                }
                else if (tableSize > 40)
                {
                    Console.WriteLine("Ширина таблицы превышает 40 символов");
                }
            }
            //Расчёт шриныы и высоты
            var tableWidthSize = (tableSize * 2) + (countCharText + 2);
            var tableHeightSize = (tableSize * 2) + 1;

            //Вывод первой ячейки
            for (int i = 0; i < tableHeightSize; i++)
            {
                for (int a = 0; a < tableWidthSize; a++)
                {
                    if (i == 0 || i == tableHeightSize - 1)
                    {
                        Console.Write("+");
                    }
                    else if (a == 0 || a == tableWidthSize - 1)
                    {
                         Console.Write("+");
                    }
                    else if (i == tableSize  && a == tableSize +1)
                    {
                        Console.Write(textUser);
                        a += countCharText - 1;
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            var strNomber = 0;
            //Вывод второй ячейки
            for (int i = 0; i < tableHeightSize - 1; i++)
            {
                for (int a = 0; a < tableWidthSize; a++)
                {
                    if (a == 0 || a == tableWidthSize - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == strNomber)
                    {
                        Console.Write(" +");
                        a += 1;
                    }
                    else if (i == tableHeightSize - 2)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("+ ");
                        a += 1;
                    } 
                }
                
                strNomber = i == strNomber ? strNomber += 2 : strNomber;

                Console.WriteLine();
            }

            strNomber = 0;
            //Вывод третьей ячейки
            for (int i = 0; i < tableWidthSize - 1; i++)
            {
                strNomber += 1;
                for (int a = 0; a < tableWidthSize; a++)
                {
                    if (a == 0 || a == tableWidthSize - 1)
                    {
                        Console.Write("+");
                        //a += 1;
                    }
                    else if (a == strNomber || a == tableWidthSize - strNomber -1)
                    {
                        Console.Write("+");
                        
                        //a += 1;
                    }
                    else if (i == tableWidthSize - 2)
                    {
                        Console.Write("+");
                    }
                    else  Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }


    }
}
