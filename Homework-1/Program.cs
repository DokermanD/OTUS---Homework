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
            var tableWidthSize = 0;
            var tableHeightSize = 0;

            GetUserData();

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                { 
                    case 0 :
                        //1 - Строка
                        OutputFirstCell();
                        break;

                    case 1:
                        //2 - Строка
                        OutputSecondCell();
                        break;

                    case 2:
                        //3 - Строка
                        OutputThirdCell();
                        break;

                    default:
                        break;
                }
            }

            Console.ReadKey();

            //Получаем данные от пользователя
            void GetUserData()
            {
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
                tableWidthSize = (tableSize * 2) + (countCharText + 2);
                tableHeightSize = (tableSize * 2) + 1;
            }

            //Вывод первой ячейки
            void OutputFirstCell()
            {
                //Горизонтальная граница
                horizontalBorder(tableWidthSize);

                for (int i = 0; i < tableHeightSize-2; i++)
                {
                    for (int a = 0; a < tableWidthSize; a++)
                    {
                        if (a == 0 || a == tableWidthSize - 1)
                        {
                            Console.Write("+");
                        }
                        else if (i == tableSize-1 && a == tableSize + 1)
                        {
                            Console.Write(textUser);
                            a += countCharText - 1;
                        }
                        else Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
               
            //Вывод второй ячейки
            void OutputSecondCell()
            {
                //Горизонтальная граница
                horizontalBorder(tableWidthSize);
                //Счётчик
                var strNomber = 0;

                for (int i = 0; i < tableHeightSize - 2; i++)
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
                        else
                        {
                            Console.Write("+ ");
                            a += 1;
                        }
                    }

                    strNomber = i == strNomber ? strNomber += 2 : strNomber;

                    Console.WriteLine();
                }
            }
               
            //Вывод третьей ячейки
            void OutputThirdCell()
            {
                //Горизонтальная граница
                horizontalBorder(tableWidthSize);
                var strNomber = 0;
                
                for (int i = 0; i < tableWidthSize - 2; i++)
                {
                    
                    strNomber += 1;
                    for (int a = 0; a < tableWidthSize; a++)
                    {
                        if (a == 0 || a == tableWidthSize - 1)
                        {
                            Console.Write("+");
                        }
                        else if (a == strNomber || a == tableWidthSize - strNomber - 1)
                        {
                            Console.Write("+");
                        }
                        //else if (i == tableWidthSize - 2)
                        //{
                        //    Console.Write("+");
                        //}
                        else Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                //Нижняя горизонтальная граница
                horizontalBorder(tableWidthSize);
            }

            //Горизонтальная граница
            void horizontalBorder(int widthSize)
            {
                for (int i = 0; i < widthSize; i++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
        }
    }
}
