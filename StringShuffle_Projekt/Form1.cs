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

namespace StringShuffle_Projekt
{
    public partial class Form1 : Form
    {
        internal static Form1 f1;

        public Form1()
        {
            f1 = this;
            InitializeComponent();
        }

        internal List<String> projekte;
        internal ListViewItem lvItem;
        internal Form2 f2 = new Form2();
        internal int startnum = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            projekte = new List<String>();
            listView1.FullRowSelect = true;

     
            datenEinlesen();
        }

        public void datenEinlesen()
        {
            int counter = 0;
            string line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("StringShuffle.txt");
                while ((line = file.ReadLine()) != null)
                {
                    listView1.Items.Add(line);
                    projekte.Add(line);

                    counter++;
                }
                file.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Eintrag hinzufügen";
            f2.ShowDialog();
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            f2.Text = "Eintrag Bearbeiten";

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Eintrag zum Bearbeiten aus!", "Achtung: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lvItem = listView1.SelectedItems[0];

            f2.txtEintrag.Text = lvItem.SubItems[0].Text;

            //f2.inde = lvItem.Index;
            f2.ShowDialog();
        }

        private void btnEntfernen_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Eintrag zum Löschen aus!", "Achtung: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Wollen Sie diesen Eintrag wirklich löschen?", "ACHTUNG:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int inde = listView1.SelectedItems[0].Index;
                listView1.Items.RemoveAt(inde);
                projekte.RemoveAt(inde);
            }
        }

        private void btnAlleEntfernen_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnSortieren_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
        }

        internal void TextdateiSpeichern()
        {
                StreamWriter sw = new System.IO.StreamWriter("StringShuffle.txt");
                projekte.ForEach(sw.WriteLine);
                sw.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextdateiSpeichern();
        }
    }
}
