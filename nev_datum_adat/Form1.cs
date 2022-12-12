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

namespace nev_datum_adat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("nincs név ");
                return;
            }
            if(string.IsNullOrEmpty(dateTimePicker_datum.Text))
            {
                MessageBox.Show("nincs dátum ");
                return;
            }
            if (string.IsNullOrEmpty(richTextBox_szoveg.Text))
            {
                MessageBox.Show("nincs szöveg ");
                return;
            }

            saveFileDialog1.Filter = "Szöveges dokumentum | *.txt| Vesszővel tagolt fájl| *.csv |Minden file| *.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string szoveg = string.Join(";", textBox_nev.Text,dateTimePicker_datum.Text, richTextBox_szoveg.Text);
                string kivFile = saveFileDialog1.FileName;
                File.WriteAllText(kivFile, szoveg);
                textBox_nev.Text = "";
                richTextBox_szoveg.Text = "";
                dateTimePicker_datum.Text = "";
            }
            else
            {
                MessageBox.Show("Megszakadt a folyamat");
            }

        }

        private void button_nyitas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string beolvasottSzoveg = File.ReadAllText(filename);
                string[] adat = beolvasottSzoveg.Split(';');
                textBox_nev.Text = adat[0];
                dateTimePicker_datum.Text = adat[1];
                richTextBox_szoveg.Text = adat[2];
            }

        }
    }
}
