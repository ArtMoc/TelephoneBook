using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneBook
{
    public partial class Form1 : Form
    {
        List<Persone> people;

        void RefreshList()
        {
            listBox1.Items.Clear();
            foreach (Persone persone in people)
            {
                listBox1.Items.Add(persone.Name);
            }
        }
        public Form1()
        {
            InitializeComponent();
            people = new List<Persone>();

            Persone Artem = new Persone();
            Artem.Name = "Артем";
            Artem.Photo = "d:\\1.png";
            Artem.Telephone = "89301237606";
            Artem.Bday = new DateTime(1994, 1, 23);

            people.Add(Artem);

            people.Add(new Persone()
            {
                Bday = new DateTime(1995, 9, 24),
                Name = "Лиана",
                Photo = "d:\\2.png",
                Telephone = "89301012001"
            });
            RefreshList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if(listBox1.SelectedIndex>=0)
            {
                int index = listBox1.SelectedIndex;
                pictureBox1.Image = Image.FromFile(people[index].Photo);
                label1.Text = people[index].Name;
                label2.Text = "Телефон: "+people[index].Telephone;
                label3.Text = $"Возраст: { people[index].Age}";
                label4.Text = people[index].Bday.ToString("dd.MM.yyyy");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add(people);
            add.ShowDialog();
            RefreshList();
        }
    }
}
