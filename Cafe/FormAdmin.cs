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

  

        private void buttonAddDish_Click(object sender, EventArgs e)
        {
            try
            {
                Dish newDish = new Dish();
                newDish.Edit(textBoxNameDish.Text, Convert.ToDouble(textBoxPriceDish.Text));
                menu.Add(newDish);
                IFormatter formatter = new BinaryFormatter();
                FileStream buffer = File.Create("temp.txt");
                formatter.Serialize(buffer, menu);
                buffer.Close();
                ShowMenu();
            }
            catch
            {
                MessageBox.Show("Проверь данные");
            }
        }

        void ShowMenu()
        {
            if (menu.Count > 0)
            {
                listBoxMenu.Items.Clear();
                menu.Reset();
                foreach (var dish in menu)
                {
                    listBoxMenu.Items.Add(dish.ToString());
                }
            }
            else
            {
                MessageBox.Show(" в меню нет ни одного блюда");

            }
        }
 
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream buffer = File.OpenRead("temp.txt");
                menu = (Menu)formatter.Deserialize(buffer);
                buffer.Close();
                ShowMenu();
            }
            catch
            {
                MessageBox.Show("Нет файла с меню");
            }
        }
    }
}
