using System;
using System.Text;

namespace Advance_1_DaynerPow
{
    internal class Program
    {
        static void Task1()
        {
            try
            {
                SeparateAndWrite("Вкажіть вашу ціль по крокам: ");
                double sumSteps = Convert.ToDouble(Console.ReadLine());

                    if (sumSteps <= 0)
                    {
                        SeparateAndWrite("Або ви не хочете ходити, або ви помилилися.");
                        return;
                    }


                Console.WriteLine("Вкажіть скільки кроків ви вже пройшли: ");
                double completeSteps = Convert.ToDouble(Console.ReadLine());

                    if (completeSteps < 0)
                    {
                        SeparateAndWrite("Ви не могли ходити від'ємно.");
                        return;
                    }


                double summary = (completeSteps / sumSteps) * 100;


                    if (summary < 70)
                    {
                        SummaryText("Давай рухайся", summary);
                    }

                        else if (summary < 90)
                        {
                            SummaryText("Мета вже не за горами!", summary);
                        }

                            else if (summary < 100)
                            {
                                SummaryText("Давай! Ще трохи!", summary);
                            }

                                else if (summary < 200)
                                {
                                    SummaryText("Ціль досягнута, молодчина! Тепер і поспати можна", summary);
                                }

                                    else
                                    {
                                        SummaryText("Та тобі на олімпійські ігри треба", summary);
                                    }
            }
            catch(Exception ex)
            {
                ErrorMessage(ex);
            }
        }

        static void Task2()
        {
            try
            {
                double discount = 0;

                SeparateAndWrite("Сума вашої покупки у грн:");
                double purchase = Convert.ToDouble(Console.ReadLine());

                    if (purchase <= 0)
                    {
                        SeparateAndWrite("Помилка, Ви нічого не купили!");
                        return;
                    }

                SeparateAndWrite("Ви маєте карту лояльності? 1 - так,  інше - ні");
                string card = Console.ReadLine();
                bool hasCard = card == "1";

                    if (hasCard)
                    {
                        discount += 3;

                            if (purchase >= 20000)
                            {
                                discount += 2;
                            }

                        SeparateAndWrite("Знижку за картою нараховано!");
                    }

                    if (purchase >= 2000 && purchase < 10000)
                    {
                        discount += 1;
                    }
                        else if (purchase >= 10000)
                        {
                            discount += 5;
                        }

                Console.WriteLine("Загальна знижка:" + discount + "%");


                double cashBack = ((purchase * discount) / 100);

                SeparateAndWrite("Сума кешбеку " + cashBack + "грн");

                SeparateAndWrite(purchase + " - " + cashBack);
                Console.WriteLine("Загальна вартість: " + (purchase - cashBack) + "грн");

            }
            catch (Exception ex) 
            {
                ErrorMessage(ex);
            }
        }

        static void Task3()
        {
            try
            {
                const double tariffUpTo100 = 1.44;
                const double tariffUpTo600 = 1.68;
                const double tariffAbove600 = 1.92;

                const int limit1 = 100;
                const int limit2 = 600;

                SeparateAndWrite("Введіть кількість спожитої електроенергії (кВт/год):");
                double consumed = Convert.ToDouble(Console.ReadLine());

                    if (consumed < 0)
                    {
                        Console.WriteLine("ПОМИЛКА! Електроенергія не може бути від'ємною >:(");
                        return;
                    }

                double result;

                    if (consumed <= limit1)
                    {
                        result = consumed * tariffUpTo100;
                    }
                        else if (consumed <= limit2)
                        {
                            result = CalculateCost(consumed, limit1, tariffUpTo600, limit1 * tariffUpTo100);
                        }
                            else
                            {
                                result = CalculateCost(consumed, limit2, tariffAbove600,(limit1 * tariffUpTo100) + ((limit2 - limit1) * tariffUpTo600));
                            }

                SeparateAndWrite("До оплати: " + result + "грн");
            }
            catch (Exception ex)
            {
                ErrorMessage(ex);
            }
        }

        static void ErrorMessage(Exception ex)
        {
            ShowSeparator();
            Console.WriteLine("!ПОМИЛКА! Введено некоректне значення. | " + "Причина: " + ex.Message);
            return;
        }

        static void SeparateAndWrite(string text)
        {
            ShowSeparator();
            Console.WriteLine(text);
        }

        static void SummaryText(string text, double summary)
        {
            ShowSeparator();
            Console.WriteLine(summary.ToString("F2") + "% " + text);
        }

        static void ShowSeparator()
        {
            Console.WriteLine("=============================");
        }

        static double CalculateCost(double consumed, int limit, double tariff, double baseCost)
        {
            return ((consumed - limit) * tariff) + baseCost;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Виберіть задачу (1 або 2 або 3):");
            string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Task1();
                        break;

                    case "2":
                        Task2();
                        break;

                    case "3":
                        Task3();
                        break;

                    default:
                        SeparateAndWrite("!Невірний набір!");
                        break;
                }

        }
    }
}
