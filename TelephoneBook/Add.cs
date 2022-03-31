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
    public partial class Add : Form
    {
        List<Persone> people;
        Persone persone = new Persone();
        public Add()
        {
            InitializeComponent();
        }
        public Add(List<Persone> people)
        {
            InitializeComponent();
            this.people = people;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                persone.Photo = openFileDialog.FileName;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            persone.Name = textBox1.Text;
            persone.Telephone = textBox2.Text;
            persone.Bday = dateTimePicker1.Value;
            people.Add(persone);
            Close();
        }
    }
}
