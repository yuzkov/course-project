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
using System.IO;
using ClosedXML;
using ClosedXML.Excel;

namespace Project
{
    public partial class Form2 : Form
    {
        public List<Shop> Shops { get; set; }
        private List<CheckBox> checkBoxes;
        public string backColor = "#EEEEF2";
        public string textColor = "#000000";
        public string checkBoxesColor = "#0xFFD3D3D3";
        public enum Parameter
        {
            Specialization,
            Address,
            Name,
            SortBy
        }
        public Form2()
        {
            InitializeComponent();

        }
        public void StartForm2()
        {
            InPut(Parameter.Name);
            NameBox.Text = "";
            InPut(Parameter.Address);
            AddressBox.Text = "";
            InPut(Parameter.Specialization);
            SpecializationBox.Text = "";
            
            if (backColor != "#EEEEF2")
            {
                checkBox1.Checked = true;
            }
            else checkBox1.Checked = false;
            flowLayoutPanel1.Controls.Clear();
            CreateCheckBoxTable();
        }
        public void AddShop(Shop shop)
        {
            Shops.Add(shop);
        }
        private DateTime setTime(int i)
        {
            return new DateTime(i);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Shops = new List<Shop>();
            Shops.Add(new Shop(1, "Свіжий Продукт", "вул. Сумська, 5", "+380 57 123 45 67", "Продукти харчування", "Приватна", "Пн-Сб 8:00-20:00, Нд 9:00-18:00"));
            Shops.Add(new Shop(2, "Економ Продукт", "просп. Гагаріна, 22", "+380 57 234 56 78", "Продукти харчування", "Приватна", "Пн-Сб 7:00-21:00, Нд 8:00-19:00"));
            Shops.Add(new Shop(3, "Модний Дім", "просп. Науки, 12", "+380 57 765 43 21", "Одяг та аксесуари", "Приватна", "Пн-Нд 10:00-22:00"));
            Shops.Add(new Shop(4, "Стильний Шик", "вул. Академіка Павлова, 30", "+380 57 876 54 32", "Одяг та аксесуари", "Приватна", "Пн-Сб 9:00-21:00, Нд 10:00-20:00"));
            Shops.Add(new Shop(5, "ЕлектроСвіт", "бульв. Шевченка, 45", "+380 57 234 56 78", "Електроніка та побутова техніка", "Приватна", "Пн-Сб 9:00-19:00, Нд 10:00-16:00"));
            Shops.Add(new Shop(6, "ТехноМаркет", "просп. Тракторобудівників, 50", "+380 57 987 65 43", "Електроніка та побутова техніка", "Приватна", "Пн-Пт 8:00-20:00, Сб 9:00-18:00, Нд вихідний"));
            Shops.Add(new Shop(7, "Аптека 24/7", "вул. Лермонтовська, 7", "+380 57 345 67 89", "Ліки та медичні товари", "Приватна", "Цілодобово"));
            Shops.Add(new Shop(8, "Здорова Родина", "просп. Московський, 90", "+380 57 456 78 90", "Ліки та медичні товари", "Приватна", "Пн-Сб 8:00-22:00, Нд 9:00-20:00"));
            Shops.Add(new Shop(9, "Золотий Ріг", "пл. Конституції, 3", "+380 57 567 89 01", "Ювелірні вироби", "Приватна", "Пн-Сб 10:00-19:00, Нд вихідний"));
            Shops.Add(new Shop(10, "Ювелірна Лавка", "вул. Мироносицька, 12", "+380 57 678 90 12", "Ювелірні вироби", "Приватна", "Пн-Пт 9:00-18:00, Сб 10:00-17:00, Нд вихідний"));
            StartForm2();
            InPut(Parameter.SortBy);
            SortBy.Text = "";
        }
        public void InPut(Parameter parameter)
        {
            List<string> sortBy = new List<string> { "Назва", "Адреса", "Спеціалізація", "Форма власності", "Час роботи" };

            if (parameter == Parameter.SortBy)
            {
                foreach (var list in sortBy)
                {
                    SortBy.Items.Add(list);
                }
            }
            foreach (var shop in Shops)
            {
                if (parameter == Parameter.Specialization)
                {
                    if (!SpecializationBox.Items.Contains(shop.Specialization))
                    {
                        SpecializationBox.Items.Add(shop.Specialization);
                    }
                }
                else if (parameter == Parameter.Address)
                {
                    if (!AddressBox.Items.Contains(shop.Address))
                    {
                        AddressBox.Items.Add(shop.Address);
                    }
                }
                else if (parameter == Parameter.Name)
                {
                    if (!NameBox.Items.Contains(shop.Name))
                    {
                        NameBox.Items.Add(shop.Name);
                    }
                }
            }
        }
        private void CreateCheckBoxTable()
        {
            flowLayoutPanel1.Controls.Clear();
            checkBoxes = new List<CheckBox>();

            foreach (var shop in Shops)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Text = $"ID: {shop.ID} \nНазва: {shop.Name} \nАдреса: {shop.Address} \nТелефон: {shop.Phone} \n" +
                                $"Спеціалізація: {shop.Specialization} \nФорма власності: {shop.Ownership} \nЧас роботи: {shop.WorkTime}";
                checkBox.Margin = new Padding(5);
                checkBox.BackColor = ColorTranslator.FromHtml(checkBoxesColor);
                flowLayoutPanel1.Controls.Add(checkBox);
                checkBoxes.Add(checkBox);
            }
        }
        public List<Shop> MySort()
        {
            List<Shop> filteredShops = Shops;
            if (!String.IsNullOrEmpty(NameBox.Text))
            {
                string searchText = NameBox.Text.ToLower();
                filteredShops = filteredShops.Where(shop => shop.Name.ToLower().Contains(searchText)).ToList();
            }
            if (!String.IsNullOrEmpty(AddressBox.Text))
            {
                string searchText = AddressBox.Text.ToLower();
                filteredShops = filteredShops.Where(shop => shop.Address.ToLower().Contains(searchText)).ToList();
            }
            if (!String.IsNullOrEmpty(SpecializationBox.Text))
            {
                string searchText = SpecializationBox.Text.ToLower();
                filteredShops = filteredShops.Where(shop => shop.Specialization.ToLower().Contains(searchText)).ToList();
            }
            if (!String.IsNullOrEmpty(SortBy.Text))
            {
                if (SortBy.Text == "Назва")
                {
                    filteredShops = filteredShops.OrderBy(x => x.Name).ToList();
                }
                else if (SortBy.Text == "Адреса")
                {
                    filteredShops = filteredShops.OrderBy(x => x.Address).ToList();
                }
                else if (SortBy.Text == "Спеціалізація")
                {
                    filteredShops = filteredShops.OrderBy(x => x.Specialization).ToList();
                }
                else if (SortBy.Text == "Форма власності")
                {
                    filteredShops = filteredShops.OrderBy(x => x.Ownership).ToList();
                }
                else if (SortBy.Text == "Час роботи")
                {
                    filteredShops = filteredShops.OrderBy(x => x.WorkTime).ToList();
                }
            }
            return filteredShops;
        }
        private void SaveSelectedShopsToFile()
        {
            List<Shop> selectedShops = new List<Shop>();

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    int shopId = int.Parse(checkBox.Text.Split('\n')[0].Split(':')[1].Trim());
                    Shop selectedShop = Shops.Find(shop => shop.ID == shopId);
                    selectedShops.Add(selectedShop);
                }
            }
            using (FileStream fs = new FileStream("File.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var shop in selectedShops)
                    {
                        sw.WriteLine($"Назва: { shop.Name} \nАдреса: { shop.Address} \nТелефон: { shop.Phone}\n");
                    }
                }
            }

        }
        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            RewriteCheckBoxTable(MySort());
        }
        private void RewriteCheckBoxTable(List<Shop> SortedShops)
        {

            flowLayoutPanel1.Controls.Clear();
            checkBoxes = new List<CheckBox>();

            foreach (var shop in SortedShops)
            {
                CheckBox checkBox = new CheckBox
                {
                    AutoSize = true,
                    Text = $"ID: {shop.ID} \nНазва: {shop.Name} \nАдреса: {shop.Address} \nТелефон: {shop.Phone} \n" +
                           $"Спеціалізація: {shop.Specialization} \nФорма власності: {shop.Ownership} \nЧас роботи: {shop.WorkTime}",
                    Margin = new Padding(5),
                    BackColor = ColorTranslator.FromHtml(checkBoxesColor)
                };
                flowLayoutPanel1.Controls.Add(checkBox);
                checkBoxes.Add(checkBox);
            }
        }
        private void changeColor()
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.BackColor = ColorTranslator.FromHtml(checkBoxesColor);
            }
            BackColor = ColorTranslator.FromHtml(backColor);
            GoForm1.FlatStyle = FlatStyle.Flat;
            GoForm1.FlatAppearance.BorderSize = 0;
            GoForm1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            GoForm1.BackColor = ColorTranslator.FromHtml(checkBoxesColor);
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            SaveButton.BackColor = ColorTranslator.FromHtml(checkBoxesColor);
            ForeColor = ColorTranslator.FromHtml(textColor);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                backColor = "#1E1E1E";
                textColor = "#FFFFFF";
                checkBoxesColor = "#383838";
            }
            else
            {
                backColor = "#EEEEF2";
                textColor = "#000000";
                checkBoxesColor = "#0xFFD3D3D3";

            }
            changeColor();
        }

        private void GoForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSelectedShopsToFile();
        }
    }
}