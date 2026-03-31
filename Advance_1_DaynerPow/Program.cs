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
                Write("Вкажіть вашу ціль по крокам: ");
                double sumSteps = Convert.ToDouble(Console.ReadLine());
                ShowSeparator();

                    if (sumSteps == 0 || sumSteps < 0)
                    {
                        ShowSeparator();
                        Write("Або ви не хочете ходити, або ви помилилися.");
                        return;
                    }


                Write("Вкажіть скільки кроків ви вже пройшли: ");
                double completeSteps = Convert.ToDouble(Console.ReadLine());

                    if (completeSteps < 0)
                    {
                        ShowSeparator();
                        Write("Ви не могли ходити від'ємно.");
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

                            else if (summary < 100)
                            {
                                ShowSeparator();
                                SummaryText("Давай! Ще трохи!", summary);
                            }

                                else if (summary < 200)
                                {
                                    ShowSeparator();
                                    SummaryText("Ціль досягнута, молодчина! Тепер і поспати можна", summary);
                                }

                                    else
                                    {
                                        ShowSeparator();
                                        SummaryText("Та тобі на олімпійські ігри треба", summary);
                                    }
            }
            catch(Exception ex)
            {
                ShowSeparator();
                Write("!ПОМИЛКА! Введено некоректне значення. | " + "Причина: " + ex.Message);
                return;
            }
        }

        static void Task2()
        {
            try
            {
                double discount = 0;

                Write("Сума вашої покупки у грн:");
                double purchase = Convert.ToDouble(Console.ReadLine());

                    if (purchase <= 0)
                    {
                        Write("Помилка, Ви нічого не купили!");
                        return;
                    }
                    ShowSeparator();

                Write("Ви маєте карту лояльності? 1 - так,  інше - ні");
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

                    if (purchase >= 2000 && purchase < 10000)
                    {
                        discount += 1;
                    }
                        else if (purchase >= 10000)
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

            }
            catch (Exception ex) 
            {
                ShowSeparator();
                Write("!ПОМИЛКА! Введено некоректне значення. | " + "Причина: " + ex.Message);
                return;
            }
        }

        static void Task3()
        {
            try
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
                                Output(normal, 600, 1.92, 984);
                            }
            }
            catch (Exception ex)
            {
                ShowSeparator();
                Write("!ПОМИЛКА! Введено некоректне значення. | " + "Причина: " + ex.Message);
                return;
            }
        }


        static void SummaryText(string text, double summary)
        {
            Console.WriteLine(summary.ToString("F2") + "% " + text);
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

            Write("Виберіть задачу (1 або 2 або 3):");
            string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ShowSeparator();
                        Task1();
                        break;

                    case "2":
                        ShowSeparator();
                        Task2();
                        break;

                    case "3":
                        ShowSeparator();
                        Task3();
                        break;

                    default:
                        ShowSeparator();
                        Write("!Невірний набір!");
                        break;
                }

        }
    }
}
