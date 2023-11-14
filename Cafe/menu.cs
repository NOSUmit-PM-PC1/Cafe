using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Menu
    {
        List<Dish> listDish;
        public void AddDish(Dish d)
        {
            listDish.Add(d);
        }
        public bool RemoveDish(Dish d)
        {
            if (listDish.Contains(d))
            {
                listDish.Remove(d);
                return true;
            }
            return false;
        }
        //итератор для обращения к пунктам меню!
        public ShowMenu()
        {
            return listDish;
        }
    }

    class Dish
    {
        string name;
        double price;
        public string Name { get; }
        public string Price { get; }
        public void Edit(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
