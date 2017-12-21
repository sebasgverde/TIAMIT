using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    ///////////////////////////////////////////////////////////
    //  Original author: sebastian
    ///////////////////////////////////////////////////////////
    public partial class TiamitMainForm : Form
    {
        public int marcadorCancionElegida;
        //public int instrumentSelectedMark;
        public string ruta;
        public string instrument;
        public TiamitMainForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Content/Background2.PNG");
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;

            listBox1.Items.Add("Scale Exercise");
            listBox1.Items.Add("Scale Exercise 2");
            listBox1.Items.Add("Esperanza");
            comboBox2.Items.Add("Guitar");
            comboBox2.Items.Add("diatonicHarmonicaE");
            comboBox2.Items.Add("OcarinaAltoC");

            comboBox2.SelectedIndex = comboBox2.FindStringExact("Guitar"); // default
            marcadorCancionElegida = 4;
        }

        CargarCancionControlador controlCargar;

        private void btnCargCanc_Click(object sender, EventArgs e)
        {
            OpenFileDialog oe = new OpenFileDialog();
            oe.ShowDialog();
            //GestionarInterpretacionControlador g = new GestionarInterpretacionControlador();
            ruta = oe.FileName;
            //ruta = @"C:\Users\sebastian\Desktop\notas1.xml";
            this.DialogResult = DialogResult.OK;
           // controlCargar = new CargarCancionControlador(@"C:\Users\sebastian\Desktop\notas1.xml");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ruta = "Content/musicXmlSamples/" + listBox1.SelectedItem.ToString() + ".xml";
            marcadorCancionElegida = listBox1.SelectedIndex + 1;
            this.DialogResult = DialogResult.OK;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruta = "Content/musicXmlSamples/" + listBox2.SelectedItem.ToString() + ".xml";
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TiamitRankingForm rank = new TiamitRankingForm();
            rank.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            instrument = comboBox2.SelectedItem.ToString();
        }
    }
}
