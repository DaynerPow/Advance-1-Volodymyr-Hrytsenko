using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Advance_1_DaynerPow
{
    internal class Program
    {
        static void SummaryText(string text, double summary)
        {
            Console.WriteLine(summary + "% " + text);
        }

        static void ShowSeparator()
        {
            Console.WriteLine("=============================");
        }

        static void ShowResult(double result)
        {
            Console.WriteLine("До оплати: " + result + "грн");
        }

        static void Output(double normal, int num1, double tarifCost, int other)
        {
            double result = ((normal - num1) * tarifCost) + other;
            ShowSeparator();
            ShowResult(result);
            return;
        }

        static void Write(string text)
        {
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //1

            /*try
            {
                Write("Вкажіть вашу ціль по крокам (Тільки цифри бро): ");
                double sumSteps = Convert.ToDouble(Console.ReadLine());

                if (sumSteps == 0 || sumSteps < 0)
                {
                    ShowSeparator();
                    Write("Серйозно? А в принципі, чого я дивуюся?");
                    return;
                }


                Write("Вкажіть скільки кроків ви вже пройшли: ");
                double completeSteps = Convert.ToDouble(Console.ReadLine());

                if (completeSteps < 0)
                {
                    ShowSeparator();
                    Write("Ага, ага... А в принципі, що тут дивного?");
                    return;
                }


                double summary = (completeSteps / sumSteps) * 100;


                if (summary < 70)
                {
                    ShowSeparator();
                    SummaryText("Давай рухайся", summary);
                }

                    else if (summary < 90)
                    {
                        ShowSeparator();
                        SummaryText("Мета вже не за горами!", summary);
                    }

                        else if (summary >= 90 && summary <= 99)
                        {
                            ShowSeparator();
                            SummaryText("Давай! Ще трохи!", summary);
                        }

                            else if (summary >= 100 && summary <= 199)
                            {
                                ShowSeparator();
                                SummaryText("Ціль досягнута, молодчина! Тепер і поспати можна", summary);
                            }

                                else if (summary >= 200)
                                {
                                    ShowSeparator();
                                    SummaryText("Та тобі на олімпійські ігри треба", summary);
                                }
            }
            catch(Exception ex)
            {
                ShowSeparator();
                Write("ПОМИЛКА! Введено некоректне значення");
                return;
            }
            */




            //2.

            /*double discount = 0;

            ShowSeparator();
            Write("Сума вашої покупки у грн:");
            double purchase = Convert.ToDouble(Console.ReadLine());

            if (purchase <= 0)
            {
                Write("Помилка, Ви нічого не купили!");
                return;
            }
            ShowSeparator();

            Write("Ви маєте карту лояльності? 1 - так, 0 - ні");
            string card = Console.ReadLine();
            bool hasCard = card == "1";

            if (hasCard)
            {
                discount += 3;
                
                if (purchase >= 20000)
                {
                    discount += 2;
                }

                ShowSeparator();
                Write("Знижку за картою нараховано!");
            }
            
            if(purchase >= 2000 && purchase < 10000)
            {
                discount += 1;
            }
                else if(purchase >= 10000)
                {
                    discount += 5;
                }

            Write("Загальна знижка:" + discount + "%");
            ShowSeparator();

            double cashBack = ((purchase * discount) / 100);

            Write("Сума кешбеку " + cashBack + "грн");
            ShowSeparator();

            Write(purchase + " - " + cashBack);
            Write("Загальна вартість: " + (purchase - cashBack) + "грн");
            */




            //3

            /*try
            {
                Write("Введіть кількість спожитої електроенергії (кВ/год):");
                double normal = Convert.ToDouble(Console.ReadLine());

                if (normal < 0)
                {
                    Write("ПОМИЛКА! Електроенергія неможе бути від'ємною >:(");
                    return;
                }

                if (normal <= 100)
                {
                    double result = normal * 1.44;
                    ShowSeparator();
                    ShowResult(result);
                    return;
                }
                    else if (normal <= 600)
                    {
                        Output(normal, 100, 1.68, 144);
                    }
                        else if (normal > 600)
                        {
                            Output(normal, 600, 1.92, 1152);
                        }
            }
            catch (Exception ex)
            {
                ShowSeparator();
                Write("ПОМИЛКА! Введено некоректне значення");
                return;
            }
        */
        }
    }
}
