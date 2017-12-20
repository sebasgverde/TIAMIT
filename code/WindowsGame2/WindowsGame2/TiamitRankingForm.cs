using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TiamitDAO;

namespace Vista
{
    ///////////////////////////////////////////////////////////
    //  Original author: sebastian
    ///////////////////////////////////////////////////////////
    public partial class TiamitRankingForm : Form
    {
        InterpretacionDao interDao = new InterpretacionDao();
        public TiamitRankingForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Content/Background4.PNG");

            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;

            List<String> lis = interDao.listarPais();
            for(int i = 0; i < lis.Count; i++)
                comboBox1.Items.Add(lis[i]);

            lis = interDao.listSongs();
            for (int i = 0; i < lis.Count; i++)
                comboBox2.Items.Add(lis[i]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<String> lis = interDao.getPerformanceByCountry(comboBox1.SelectedIndex + 1);
            for (int i = 0; i < lis.Count; i++)
                listBox1.Items.Add((i + 1)+ " " + lis[i]);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<String> lis = interDao.getPerformanceBySong(comboBox2.SelectedIndex + 1);
            for (int i = 0; i < lis.Count; i++)
                listBox1.Items.Add((i + 1) + " " + lis[i]);
            
        }
    }
}
