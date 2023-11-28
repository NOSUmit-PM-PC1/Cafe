using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    [Serializable]
    class Menu: IEnumerable, IEnumerator, ISerializable
    {
        List<Dish> listDish = new List<Dish>();
        int index = -1;
        public Menu(){ }
        public int Count { get { return listDish.Count; } }

        //public int Count()
        //{ return listDish.Count;}

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

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("listDish", this.listDish);
        }
        public Menu(SerializationInfo info, StreamingContext context)
        {
            this.listDish = (List<Dish>)info.GetValue("listDish", typeof(List<Dish>));
        }
    }

    [Serializable]
    class Dish
    {
        string name;
        double price;
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public void Edit(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return Name + " " + Price + "р.";
        }
    }
}
