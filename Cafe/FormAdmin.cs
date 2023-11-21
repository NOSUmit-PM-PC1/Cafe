using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class FormAdmin : Form
    {
        Menu menu = new Menu();
        List<Dish> temp;
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
            }
            catch
            {
                MessageBox.Show("Проверь данные");
            }
        }

        private void buttonShowMenu_Click(object sender, EventArgs e)
        {
            foreach (var dish in menu)
            {
                listBoxMenu.Items.Add(dish);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp[0].Edit("куку", 10000000000);
        }
    }
}
