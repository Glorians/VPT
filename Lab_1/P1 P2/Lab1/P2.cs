using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class P2
    {

        public static void start()
        {
            while (true)
            {
                Console.Write("Trariff: ");
                String input_tariff = Console.ReadLine();
                Console.Write("MB: ");
                String input_mb = Console.ReadLine();
                Tariff tariff1 = new Tariff(input_tariff, input_mb);
                Console.WriteLine();
            }

        }

    }

    public class Tariff
    {
        private String t_num; //Номер тарифного плана
        private String mb_num; // Количество МБ

        // Конструктор по умолчанию
        public Tariff(String t_num, String mb_num)
        {
            this.t_num = t_num;
            this.mb_num = mb_num;
            check(t_num, mb_num); // Вызов проверки конвертации типов
        }

        //Проверка данных
        public static Boolean checkType;
        public static void check(String str_t_num, String str_mb_num)
        {
         
            int tNum;
            float mbNum;
            try
            {
                tNum = Convert.ToInt16(str_t_num);
                mbNum = Convert.ToSingle(str_mb_num);
                checkType = true;
            }

            catch
            {
                Console.WriteLine("Неверный тип!");
                checkType = false;
            }

            if (checkType == true)
            {
                tNum = Convert.ToInt16(str_t_num);
                mbNum = Convert.ToSingle(str_mb_num);
                int result = processing(tNum, mbNum);
                if (result > 0)
                {
                    Console.Write($"Стоимость тарифа: {result} грн");
                }


            }
        }

        public static int processing(int tNum, double mbNum)
        {
            int result;
            switch (tNum)
            {
                case 1000:
                    if (mbNum > 1000)
                    {
                        result = (int)Math.Round((mbNum - 1000) * 0.05) + 20;
                        return result;
                    }
                    return 20;

                case 2000:
                    if (mbNum > 2000)
                    {
                        result = (int)Math.Round((mbNum - 2000) * 0.04) + 35;
                        return result;
                    }
                    return 35;

                case 5000:
                    if (mbNum > 5000)
                    {
                        result = (int)Math.Round((mbNum - 5000) * 0.02) + 85;
                        return result;
                    }
                    return 85;

                default:
                    Console.WriteLine("Данный тариф не найден");
                    return 0;
            }
        }
    }
}
