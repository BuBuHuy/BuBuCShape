using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CshapeWinforBasic
{
    public partial class ComboBoxDemo : Form
    {
        public ComboBoxDemo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        List<Food> listItem;

        void AddBinding()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //listItem = new List<string> { "CoCa", "Pepsi", "7Up" };
            listItem = new List<Food>
            {
                new Food(){ name ="Bo bit tet ",price =200000},
            new Food() { name = "Ca hap", price = 56000 }
            };
            cb1.DataSource = listItem;
            cb1.DisplayMember = "name";
            cb2.DataSource = listItem;
            cb2.DisplayMember = "price";
        }
    }
    public class Food
    {
        public string name { set; get; }
        public double price { set; get; }
    }
}
