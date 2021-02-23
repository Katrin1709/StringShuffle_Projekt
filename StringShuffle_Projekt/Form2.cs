using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringShuffle_Projekt
{
    public partial class Form2 : Form
    {
        internal static Form2 f2;

        public Form2()
        {
            f2 = this;
            InitializeComponent();
        }

        internal int inde;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Eintrag Bearbeiten")) // Berarbeiten
            {
                Form1.f1.projekte[inde] = txtEintrag.Text;
                this.Close();
            }
            else // Hinzufügen
            {
                Form1.f1.projekte.Add(txtEintrag.Text);
                Form1.f1.listView1.Items.Add(txtEintrag.Text);
            }
            txtEintrag.Clear();
            Form1.f1.TextdateiSpeichern();
            Form1.f1.projekte.Clear();
            Form1.f1.listView1.Items.Clear();
            Form1.f1.datenEinlesen();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
