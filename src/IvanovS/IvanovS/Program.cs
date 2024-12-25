using System;

namespace IvanovS
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            while (true)
            {
                Console.Write("Введите количество смартфонов: ");
                if (int.TryParse(Console.ReadLine(), out size) && size > 0)
                {
                    break;
                }
                Console.WriteLine("Введите положительное число");
            }

            DeviceShop deviceShop = new DeviceShop();
            for (int i = 0; i < size; i++)
            {
                string mark;
                string model;
                double cost;

                while (true)
                {
                    Console.Write("Введите марку: ");
                    mark = Console.ReadLine();
                    if (!string.IsNullOrEmpty(mark))
                    {
                        break;
                    }
                    Console.WriteLine("Поле Марка обязятельно должно быть заполнено");

                }
                while (true)
                {
                    Console.Write("Введите модель: ");
                    model = Console.ReadLine();
                    if (!string.IsNullOrEmpty(model))
                    {
                        break;
                    }
                    Console.WriteLine("Поле Модель должно быть обязательно заполнено");
                }
                while (true)
                {
                    Console.Write("Введите цену: ");
                    cost = double.Parse(Console.ReadLine());
                    if (!string.IsNullOrEmpty(Convert.ToString(cost)) && cost > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Поле Цена должно быть заполнено и иметь положительное значение");
                }

                Smartphone smartphone = new Smartphone(mark, model, cost);
                deviceShop.AddSmartphone(smartphone);
            }
            deviceShop.SortSmartphone();
            string filename = "smartphone.txt";
            deviceShop.SaveToFile(filename);

        }
    }
}
