using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            int laheta = 1;
            taulukonAsetukset(laheta);
        }

        private void save_Click(object sender, EventArgs e)
        {
            int laheta = 2;
            taulukonAsetukset(laheta);
        }
        private void taulukonAsetukset(int lahetys)
        {
            int indeksi;
            int luku;
            int tal = 0;
            int koko = 0;
            luku = lahetys;
            bool tama = true;
            if (tama == true)
            {
                goto lapi;
            }
            goto ohi;
            lapi:
            taulu table = new taulu();
            tama = false;
            ohi:
            switch (luku)
            {
                case 1:
                    int.TryParse(tableKoko.Text, out koko);
                    if (koko > 0)
                    {
                        table.KokoAsetukset(koko);
                    }
                    break;
                case 2:
                    int.TryParse(indeksiNum.Text, out indeksi);
                    if (indeksi > koko)
                    {
                        MessageBox.Show("indeksi on isompi kuin taulukko","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (table.taulukko[indeksi] >= 0)
                        {
                            var result = MessageBox.Show("indeksin kohdalle on jo laitettu luku haluatko silti jatkaa?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                table.taulukko[indeksi] = tal;
                            }
                        }
                        else
                            table.taulukko[indeksi] = tal;
                    }
                    break;
                case 3:
                    haettu.Text = "";
                    int hae = 0;
                    int.TryParse(haku.Text, out hae);
                    haettu.Text += table.taulukko[hae];
                    break;
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            int laheta = 3;
            taulukonAsetukset(laheta);
        }
    }
}