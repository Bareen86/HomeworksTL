using ShopConsole.Classes;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        bool state = true;
        while (state)
        {
            Shop shop = new Shop();
            Console.WriteLine("Меню магазина: ");
            Console.WriteLine("1. Вывести список товаров по типу товара(Техника, Мебель, Посуда).");
            Console.WriteLine("2. Добавить товар в список.");
            Console.WriteLine("9. Выйти из приложения.");
            Console.WriteLine();
            try
            {
                int stateNum = int.Parse(Console.ReadLine());
                switch (stateNum)
                {
                    case 1:
                        Console.WriteLine("Введите товар, который хотите увидеть, из следующего списка: ('Техника','Мебель','Посуда')");
                        string name = Console.ReadLine();
                        shop.SortBy(name);
                        break;
                    case 2:
                        Console.WriteLine("Введите товар, который хотите добавить из следующего списка: ('Техника','Мебель','Посуда')");
                        shop.AddGood();
                        break;
                    case 9:
                        state = false;
                        break;
                };
            }
            catch
            {
                Console.WriteLine("Должны быть выбраны 1, 2 или 9 вырианты");
            }
            
        }
    }
}