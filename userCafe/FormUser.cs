using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe;

namespace userCafe
{
    public partial class FormUser : Form
    {
        Cafe.Menu menu;
        public FormUser()
        {
            InitializeComponent();
        }

        void ShowMenu()
        {
            if (menu.Count > 0)
            {
                foreach (var dish in menu)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells[0].Value = ((Cafe.Dish)dish).Name;
                    row.Cells[1].Value = ((Cafe.Dish)dish).Price.ToString();
                    dataGridView1.Rows.Add(row);

                    var rowItem = new ListViewItem(new string[] { ((Dish)dish).Name, ((Dish)dish).Price.ToString() });
                    listView1.Items.Add(rowItem);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream buffer = File.OpenRead("temp.txt");
                menu = (Cafe.Menu)formatter.Deserialize(buffer);
                buffer.Close();
                ShowMenu();
            }
            catch
            {
                MessageBox.Show("Нет файла с меню");
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //MessageBox.Show(e.Column.ToString());
            menu.Sort();
            ShowMenu();
        }
    }
}
