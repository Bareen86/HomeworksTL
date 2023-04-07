using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopConsole.Interfaces;

namespace ShopConsole.Classes
{
    public class Shop : IShop
    {
        private List<string> items = new List<string>(); 

        public List<string> SortBy(string name)
        {
            LoadGoods(name);
            return items;
        }


        private void LoadGoods()
        {
            items = File.ReadAllLines("Goods.txt").ToList();
        }

        private void LoadGoods(string name)
        {
            LoadGoods();
            var linqResult = from item in items
                                  where item.Contains(name)
                                  orderby item
                                  select item;
            if (linqResult.Any())
            {
                foreach (var item in linqResult)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Такого типа товара нет!");
            }
            
        }

        public void AddGood()
        {
            LoadGoods();
            string typeString = Console.ReadLine();
            switch (typeString)
            {
                case "Техника":
                    Technique technique = new Technique();
                    technique.GoodType = "Техника";

                    Console.WriteLine("Введите название товара: ");
                    technique.Name = Console.ReadLine();

                    Console.WriteLine($"Введите вес {technique.Name} в кг: ");
                    
                    try
                    {
                        technique.Weight = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }

                    Console.WriteLine($"Введите стоимость {technique.Name} в рублях: ");
                    try
                    {
                        technique.Price = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }

                    Console.WriteLine($"Введите количество {technique.Name}, которое будет на складе");
                    try
                    {
                        technique.QuantityInStock = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }

                    Console.WriteLine($"Введите основную функцию {technique.Name}: ");
                    technique.MainFunction = Console.ReadLine();

                    Console.WriteLine($"Введите энергопотребление {technique.Name}: ");
                    technique.PowerConsumption = Console.ReadLine();
                    string techniquestrToAdd = $"Название : {technique.Name},  типТовара : {technique.GoodType}, вес = {technique.Weight}кг" +
                        $"Цена : {technique.Price}руб, энергопотребление: {technique.PowerConsumption}, основная функция: {technique.MainFunction}, Кол-во на складе : {technique.QuantityInStock}\n";
                    TextWriter techniqueTW = new StreamWriter("Goods.txt", true);
                    techniqueTW.WriteLine(techniquestrToAdd);
                    techniqueTW.Close();
                    Console.WriteLine($"{technique.Name} был успешно добавлен!");
                    break;

                case "Мебель":

                    Furniture furniture = new Furniture();
                    furniture.GoodType = "Мебель";

                    Console.WriteLine("Введите название товара: ");
                    furniture.Name = Console.ReadLine();

                    Console.WriteLine($"Введите вес {furniture.Name} в кг: ");
                    try
                    {
                        furniture.Weight = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }

                    Console.WriteLine($"Введите стоимость {furniture.Name} в рублях: ");
                    try
                    {
                        furniture.Price = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }

                    Console.WriteLine($"Введите количество {furniture.Name}, которое будет на складе:");
                    try
                    {
                        furniture.QuantityInStock = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }
                    Console.WriteLine($"Введите материалы {furniture.Name}: ");
                    furniture.Material = Console.ReadLine();
                    Console.WriteLine($"Введите размер {furniture.Name}: ");
                    furniture.Size = Console.ReadLine();
                    string furnitureStrToAdd = $"Название : {furniture.Name},  типТовара : {furniture.GoodType}, вес = {furniture.Weight}кг " +
                        $"Цена : {furniture.Price}руб, размеры: {furniture.Size}, материалы: {furniture.Material}, Кол-во на складе : {furniture.QuantityInStock} ";
                    TextWriter furnitureTW = new StreamWriter("Goods.txt", true);
                    furnitureTW.WriteLine(furnitureStrToAdd);
                    furnitureTW.Close();
                    Console.WriteLine($"{furniture.Name} был успешно добавлен!");
                    break;


                case "Посуда":

                    Dishes dishes = new Dishes();
                    dishes.GoodType = "Мебель";

                    Console.WriteLine("Введите название товара: ");
                    dishes.Name = Console.ReadLine();

                    Console.WriteLine($"Введите вес {dishes.Name} в кг: ");
                    try
                    {
                        dishes.Weight = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }

                    Console.WriteLine($"Введите стоимость {dishes.Name} в рублях: ");
                    try
                    {
                        dishes.Price = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }

                    Console.WriteLine($"Введите количество {dishes.Name}, которое будет на складе");
                    try
                    {
                        dishes.QuantityInStock = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Должно вводиться число");
                        break;
                    }
                    Console.WriteLine($"Введите материал {dishes.Name}: ");
                    dishes.Material = Console.ReadLine();
                    string dishesStrToAdd = $"Название : {dishes.Name},  типТовара : {dishes.GoodType}, вес = {dishes.Weight}кг " +
                        $"Цена : {dishes.Price}руб, материалы: {dishes.Material}, Кол-во на складе : {dishes.QuantityInStock}\n";
                    TextWriter dishesTW = new StreamWriter("Goods.txt", true);
                    dishesTW.WriteLine(dishesStrToAdd);
                    dishesTW.Close();
                    Console.WriteLine($"{dishes.Name} был успешно добавлен!");
                    break;
                default:
                    Console.WriteLine("Такого типа товара нет! Введите один из трех типов товаров!");
                    break;
            }
        }

        public void ShowGoods()
        {
            throw new NotImplementedException();
        }
    }
}
