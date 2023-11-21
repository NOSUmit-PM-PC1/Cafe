using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Menu: IEnumerable, IEnumerator
    {
        List<Dish> listDish = new List<Dish>();
        int index = -1;
        public void Add(Dish d)
        {
            listDish.Add(d);
        }
        public bool Remove(Dish d)
        {
            if (listDish.Contains(d))
            {
                listDish.Remove(d);
                return true;
            }
            return false;
        }
        //итератор для обращения к пунктам меню!
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current => listDish[index];

        public bool MoveNext()
        {
            index++;
            return index < listDish.Count;
        }

        public void Reset()
        {
            index = -1;
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

        public override string ToString()
        {
            return name + " " + price + "р.";
        }
    }
}
