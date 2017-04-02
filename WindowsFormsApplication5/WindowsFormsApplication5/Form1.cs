using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public List<Country> countries;
        private int selected_country;
        private int selected_city;
        public Form1()
        {
            InitializeComponent();
            my_init();
        }
        private void my_init()
        {
            countries = new List<Country>();
            countries.Add(new Country("Ukraine"));
            countries.Add(new Country("Germany"));
            countries.Add(new Country("United Kingdom"));
            countries[0].cities.Add(new City("Kyiv", "V.Klitchko", 3500000, 800));
            countries[0].cities.Add(new City("Lviv", "A.Sadovyi", 900000, 980));
            countries[1].cities.Add(new City("Berlin", "M.Schumacher", 4500000, 778));
            countries[1].cities.Add(new City("Munchen", "M.Ballack", 2500000, 784));
            countries[2].cities.Add(new City("London", "J.Bond", 6500000, 990));
            countries[2].cities.Add(new City("Liverpool", "L.Hamilton", 6500000, 989));
            country_combobox.DisplayMember = "name";
            cities_listbox.DisplayMember = "name";
            country_combobox.Items.AddRange(countries.ToArray());
            country_combobox.SelectedIndex = 0;
            cities_listbox.SelectedIndex = 0;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int[] pos = new int[cities_listbox.SelectedIndices.Count];
            int it = 0;
            ListBox.SelectedIndexCollection l = new ListBox.SelectedIndexCollection(cities_listbox);
            foreach (var x in l)
            {
                pos[it++] = Convert.ToInt32(x.ToString());
            }
            for (int i = pos.Length - 1; i >= 0; i--)
            {
                countries[selected_country].cities.RemoveAt(pos[i]);
            }
            population.Value = 0;
            area.Value = 0;
            major_textbox.Text = "";
            country_combobox_SelectedIndexChanged(this, e);
        }
        private void country_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (country_combobox.SelectedIndex < 0) country_combobox.SelectedIndex = 0;
            selected();
            cities_listbox.Items.Clear();
            cities_listbox.Items.AddRange(countries[selected_country].cities.ToArray());
            if (countries[selected_country].cities.Count > 0)
            {
                cities_listbox.SelectedIndex = 0;
                cities_listbox.Enabled = true;
                Delete.Enabled = true;
                cities_listbox_SelectedIndexChanged(this, e);
            }
            else
            {
                Delete.Enabled = false;
                cities_listbox.Enabled = false;
            }
        }
        private void cities_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cities_listbox.SelectedIndex < 0) cities_listbox.SelectedIndex = 0;
            selected();
            population.Value = countries[selected_country].cities[selected_city].population;
            area.Value = countries[selected_country].cities[selected_city].area;
            major_textbox.Text = countries[selected_country].cities[selected_city].major;
            major_textbox.Enabled = false;
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            selected();
            if (add_city_butt.Text.Length > 0 && add_city_butt.Text != "Enter city name here...")
            {
                countries[selected_country].cities.Add(
                    new City(add_city_butt.Text,
                    major_textbox.Text,
                    (int)population.Value,
                    (int)area.Value));
                country_combobox_SelectedIndexChanged(this, e);
                add_city_butt.Text = "Enter city name here...";
            }
            else
            {
                MessageBox.Show("Please, enter city name");
                add_city_butt.Focus();
            }
        }
        private void selected()
        {
            selected_country = country_combobox.SelectedIndex;
            selected_city = cities_listbox.SelectedIndex;
        }
        private void add_city_butt_MouseClick(object sender, MouseEventArgs e)
        {
            add_city_butt.Clear();
            save.Enabled = false;
            add_button.Enabled = true;
            Delete.Enabled = false;
            major_textbox.Enabled = true;
            cities_listbox.Enabled = false;
            population.Value = 0;
            major_textbox.Text = "";
            area.Value = 0;
        }
        private void save_Click(object sender, EventArgs e)
        {
            selected();
            countries[selected_country].cities[selected_city].population=Convert.ToInt32(population.Value);
            countries[selected_country].cities[selected_city].area= Convert.ToInt32(area.Value);
            countries[selected_country].cities[selected_city].major = major_textbox.Text;
            cities_listbox_SelectedIndexChanged(this, e);
        }

        private void population_ValueChanged(object sender, EventArgs e)
        {
            //save.Enabled = true;
        }
        private void area_ValueChanged(object sender, EventArgs e)
        {
           // save.Enabled = true;
        }
    }
}
