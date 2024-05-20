using Course_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Form1 : Form
    {
        private Form2 Form2 { get; set; }
        private List<int> ID;
        public Form1(Form2 form2)
        {

            InitializeComponent();
            Form2 = form2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ID = new List<int>();
            DataGridShops.DataSource = Form2.Shops;
            changeColor();
            if (Form2.backColor != "#EEEEF2")
            {
                checkBox1.Checked = true;
            }
            else checkBox1.Checked = false;
        }

        private void GoForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.StartForm2();
            Form2.Show();
        }
        private void changeColor()
        {
            BackColor = ColorTranslator.FromHtml(Form2.backColor);
            GoForm2.FlatStyle = FlatStyle.Flat;
            GoForm2.FlatAppearance.BorderSize = 0;
            GoForm2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            GoForm2.BackColor = ColorTranslator.FromHtml(Form2.checkBoxesColor);
            AddShop.FlatStyle = FlatStyle.Flat;
            AddShop.FlatAppearance.BorderSize = 0;
            AddShop.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            AddShop.BackColor = ColorTranslator.FromHtml(Form2.checkBoxesColor);AddShop.FlatStyle = FlatStyle.Flat;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Delete.BackColor = ColorTranslator.FromHtml(Form2.checkBoxesColor);
            ForeColor = ColorTranslator.FromHtml(Form2.textColor);
            DataGridShops.BackgroundColor = ColorTranslator.FromHtml(Form2.backColor);
            DataGridShops.ForeColor = Color.Black;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form2.backColor = "#1E1E1E";
                Form2.textColor = "#FFFFFF";
                Form2.checkBoxesColor = "#383838";
            }
            else
            {
                Form2.backColor = "#EEEEF2";
                Form2.textColor = "#000000";
                Form2.checkBoxesColor = "#0xFFD3D3D3";

            }
            changeColor();
        }
        private void AddShop_Click(object sender, EventArgs e)
        {
            if (ID.Count > 0)
            {
                Form2.AddShop(new Shop(ID[0], "", "", "", "", "", ""));
                ID.Remove(ID[0]);
            }
            else Form2.AddShop(new Shop(Form2.Shops.Count + 1, "", "", "", "", "", ""));
            DataGridShops.DataSource = null;
            DataGridShops.DataSource = Form2.Shops;
        }
        private int IsThereID(int ID)
        {
            int value = -1;
            for (int i = 0; i < Form2.Shops.Count; i++)
            {
                if (Form2.Shops[i].ID == ID)
                {
                    value = i;
                    break;
                }
            }
            return value;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Number.Text, out _))
            {
                if (IsThereID(int.Parse(Number.Text)) != -1)
                {
                    ID.Add(int.Parse(Number.Text));
                    Form2.Shops.RemoveAt(IsThereID(int.Parse(Number.Text)));
                    DataGridShops.DataSource = null;
                    DataGridShops.DataSource = Form2.Shops;
                    Number.Text = "";
                }
                else
                {
                    MessageBox.Show("індексу не знайдено", "Помилка");
                }
            }
            else
            {
                MessageBox.Show("Не є числом!", "Помилка");
            }
        }
    }

}
