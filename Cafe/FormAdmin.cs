using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cafe
{
    public partial class FormAdmin : Form
    {
        Menu menu = new Menu();
        List<Dish> temp = new List<Dish>();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddDish_Click(object sender, EventArgs e)
        {
            try
            {
                Dish newDish = new Dish();
                newDish.Edit(textBoxNameDish.Text, Convert.ToDouble(textBoxPriceDish.Text));
                menu.Add(newDish);
                temp.Add(newDish);
                
            }
            catch
            {
                MessageBox.Show("Проверь данные");
            }
        }

        private void buttonShowMenu_Click(object sender, EventArgs e)
        {
            if (menu.Count > 0)
            {
                foreach (var dish in menu)
                {
                    listBoxMenu.Items.Add(dish);
                }
            }
            else
            {
                MessageBox.Show(" в меню нет ни одного блюда");
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // temp[0].Edit("куку", 10000000000);
            // Сериализуем его
            IFormatter formatter = new BinaryFormatter();
            FileStream buffer = File.Create("temp.txt");
            formatter.Serialize(buffer, menu);
            buffer.Close();
        }
    }
}
