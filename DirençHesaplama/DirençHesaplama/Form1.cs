using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirençHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string[,] direnc = new string[13, 7] { 
            //     NAME     SIGNFICANT FIGURES      MULTIPLY         TOLERANCE  TEMPRETURE
                { "Black",    "0", "0", "0",          "1",              "",       "250" }, 
                { "Brown",    "1", "1", "1",          "10",             "1",      "100" }, 
                { "Red",      "2", "2", "2",          "100",            "2",      "50" }, 
                { "Orange",   "3", "3", "3",          "1000",           "0.05",   "15" }, 
                { "Yellow",   "4", "4", "4",          "10000",          "0.02",   "25" }, 
                { "Green",    "5", "5", "5",          "100000",         "0.5",    "20" }, 
                { "Blue",     "6", "6", "6",          "1000000",        "0.25",   "10" }, 
                { "Purple",   "7", "7", "7",          "10000000",       "0.1",    "5" }, 
                { "Grey",     "8", "8", "8",          "100000000",      "0.01",   "1" }, 
                { "White",    "9", "9", "9",          "1000000000",     "",       "" }, 
                { "Gold",     "",  "",  "",           "0.1",            "5",      "" }, 
                { "Silver",   "",  "",  "",           "0.01",           "10",     "" }, 
                { "No Color", "",  "",  "",           "1",              "20",     "" } };

            int renk1=0, renk2=0, renk3=0, renk4=0, renk5=0, renk6 = 0;

            string sonuc1 = "";
            decimal sonuc2 = 0;
            string sonuc3 = "";

            int tane = Convert.ToInt32(Convert.ToInt32(cmb_DirencAdet.SelectedItem));

            if (tane > 3 && tane < 7)
            {

                renk1 = Convert.ToInt32(cmb_secim1.SelectedIndex);
                renk2 = Convert.ToInt32(cmb_secim2.SelectedIndex);
                renk3 = Convert.ToInt32(cmb_secim3.SelectedIndex);
                renk4 = Convert.ToInt32(cmb_secim4.SelectedIndex);

                if (Convert.ToInt32(cmb_DirencAdet.Text) == 5)
                {
                    renk5 = Convert.ToInt32(cmb_secim5.SelectedIndex);
                }
                if (Convert.ToInt32(cmb_DirencAdet.Text) == 6)
                {
                    renk5 = Convert.ToInt32(cmb_secim5.SelectedIndex);
                    renk6 = Convert.ToInt32(cmb_secim6.SelectedIndex);
                }

                if (tane == 4)
                {
                    sonuc1 = direnc[renk1, 1];
                    sonuc1 += direnc[renk2, 2];
                    sonuc2 = Convert.ToInt32(sonuc1) * Convert.ToDecimal(direnc[renk3, 4]);
                    //
                    if (sonuc2 < 1000)
                    {
                        sonuc3 = Convert.ToString(sonuc2) + " Ω ± % " + direnc[renk4, 5];
                    }
                    else if (sonuc2 >= 1000 && sonuc2<1000000)
                    {
                        sonuc2 = sonuc2 / 1000;
                        sonuc3 = Convert.ToString(sonuc2) + " kΩ ± % " + direnc[renk4, 5];
                    }
                    else if (sonuc2 >= 1000000 && sonuc2 < 1000000000)
                    {
                        sonuc2 = sonuc2 / 1000000;
                        sonuc3 = Convert.ToString(sonuc2) + " MΩ ± % " + direnc[renk4, 5];
                    }
                    else if (sonuc2 >= 1000000000)
                    {
                        sonuc2 = sonuc2 / 1000000000;
                        sonuc3 = Convert.ToString(sonuc2) + " GΩ ± % " + direnc[renk4, 5];
                    }

                }

                if (tane == 5)
                {
                    sonuc1 = direnc[renk1, 1];
                    sonuc1 += direnc[renk2, 2];
                    sonuc1 += direnc[renk3, 3];
                    sonuc2 = Convert.ToInt32(sonuc1) * Convert.ToDecimal(direnc[renk4, 4]);
                    //
                    if (sonuc2 < 1000)
                    {
                        sonuc3 = Convert.ToString(sonuc2) + " Ω ± % " + direnc[renk5, 5];
                    }
                    else if (sonuc2 >= 1000 && sonuc2 < 1000000)
                    {
                        sonuc2 = sonuc2 / 1000;
                        sonuc3 = Convert.ToString(sonuc2) + " kΩ ± % " + direnc[renk5, 5];
                    }
                    else if (sonuc2 >= 1000000 && sonuc2 < 1000000000)
                    {
                        sonuc2 = sonuc2 / 1000000;
                        sonuc3 = Convert.ToString(sonuc2) + " MΩ ± % " + direnc[renk5, 5];
                    }
                    else if (sonuc2 >= 1000000000)
                    {
                        sonuc2 = sonuc2 / 1000000000;
                        sonuc3 = Convert.ToString(sonuc2) + " GΩ ± % " + direnc[renk5, 5];
                    }

                }

                if (tane == 6)
                {
                    sonuc1 = direnc[renk1, 1];
                    sonuc1 += direnc[renk2, 2];
                    sonuc1 += direnc[renk3, 3];
                    sonuc2 = Convert.ToInt32(sonuc1) * Convert.ToDecimal(direnc[renk4, 4]);
                    //
                    if (sonuc2 < 1000)
                    {
                        sonuc3 = Convert.ToString(sonuc2) + " Ω ± % " + direnc[renk5, 5] + " " + direnc[renk6, 6] + "ppm";
                    }
                    else if (sonuc2 >= 1000 && sonuc2 < 1000000)
                    {
                        sonuc2 = sonuc2 / 1000;
                        sonuc3 = Convert.ToString(sonuc2) + " kΩ ± % " + direnc[renk5, 5] + " " + direnc[renk6, 6] + "ppm";
                    }
                    else if (sonuc2 >= 1000000 && sonuc2 < 1000000000)
                    {
                        sonuc2 = sonuc2 / 1000000;
                        sonuc3 = Convert.ToString(sonuc2) + " MΩ ± % " + direnc[renk5, 5] + " " + direnc[renk6, 6] + "ppm";
                    }
                    else if (sonuc2 >= 1000000000)
                    {
                        sonuc2 = sonuc2 / 1000000000;
                        sonuc3 = Convert.ToString(sonuc2) + " GΩ ± % " + direnc[renk5, 5] + " " + direnc[renk6, 6] + "ppm";
                    }

                }

                //Sonucu label a yazdırır.
                lbl_Sonuc.Text = sonuc3;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Program açıldığında ComboBox ları kapatır.
            cmb_secim1.Enabled = false;
            cmb_secim2.Enabled = false;
            cmb_secim3.Enabled = false;
            cmb_secim4.Enabled = false;
            cmb_secim5.Enabled = false;
            cmb_secim6.Enabled = false;
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            //ComboBoxları kilitleyip açma işlemi
            int tane = Convert.ToInt32(Convert.ToInt32(cmb_DirencAdet.SelectedItem));
            if (tane > 3 && tane < 7)
            {
                cmb_secim1.Enabled = true;
                cmb_secim2.Enabled = true;
                cmb_secim3.Enabled = true;
                cmb_secim4.Enabled = true;
                if (Convert.ToInt32(cmb_DirencAdet.Text) == 5)
                {
                    cmb_secim5.Enabled = true;
                    cmb_secim6.Enabled = false;
                }
                if (Convert.ToInt32(cmb_DirencAdet.Text) == 6)
                {
                    cmb_secim5.Enabled = true;
                    cmb_secim6.Enabled = true;
                }
                else if(Convert.ToInt32(cmb_DirencAdet.Text) == 4)
                {
                    cmb_secim5.Enabled = false;
                    cmb_secim6.Enabled = false;
                }
            }
        }

        private void cmb_secim1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_secim1.SelectedIndex==0)
            {
                cmb_secim1.BackColor = Color.Black;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 1)
            {
                cmb_secim1.BackColor = Color.Brown;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 2)
            {
                cmb_secim1.BackColor = Color.Red;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 3)
            {
                cmb_secim1.BackColor = Color.Orange;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 4)
            {
                cmb_secim1.BackColor = Color.Yellow;
                cmb_secim1.ForeColor = Color.Black;
            }
            else if (cmb_secim1.SelectedIndex == 5)
            {
                cmb_secim1.BackColor = Color.Green;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 6)
            {
                cmb_secim1.BackColor = Color.Blue;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 7)
            {
                cmb_secim1.BackColor = Color.Purple;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 8)
            {
                cmb_secim1.BackColor = Color.Gray;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 9)
            {
                cmb_secim1.BackColor = Color.White;
                cmb_secim1.ForeColor = Color.Black;
            }
            else if (cmb_secim1.SelectedIndex == 10)
            {
                cmb_secim1.BackColor = Color.Gold;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 11)
            {
                cmb_secim1.BackColor = Color.Silver;
                cmb_secim1.ForeColor = Color.White;
            }
            else if (cmb_secim1.SelectedIndex == 12)
            {
                cmb_secim1.BackColor = Color.White;
                cmb_secim1.ForeColor = Color.Black;
            }

        }

        private void cmb_secim2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_secim2.SelectedIndex == 0)
            {
                cmb_secim2.BackColor = Color.Black;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 1)
            {
                cmb_secim2.BackColor = Color.Brown;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 2)
            {
                cmb_secim2.BackColor = Color.Red;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 3)
            {
                cmb_secim2.BackColor = Color.Orange;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 4)
            {
                cmb_secim2.BackColor = Color.Yellow;
                cmb_secim2.ForeColor = Color.Black;
            }
            else if (cmb_secim2.SelectedIndex == 5)
            {
                cmb_secim2.BackColor = Color.Green;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 6)
            {
                cmb_secim2.BackColor = Color.Blue;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 7)
            {
                cmb_secim2.BackColor = Color.Purple;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 8)
            {
                cmb_secim2.BackColor = Color.Gray;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 9)
            {
                cmb_secim2.BackColor = Color.White;
                cmb_secim2.ForeColor = Color.Black;
            }
            else if (cmb_secim2.SelectedIndex == 10)
            {
                cmb_secim2.BackColor = Color.Gold;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 11)
            {
                cmb_secim2.BackColor = Color.Silver;
                cmb_secim2.ForeColor = Color.White;
            }
            else if (cmb_secim2.SelectedIndex == 12)
            {
                cmb_secim2.BackColor = Color.White;
                cmb_secim2.ForeColor = Color.Black;
            }
        }

        private void cmb_secim3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_secim3.SelectedIndex == 0)
            {
                cmb_secim3.BackColor = Color.Black;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 1)
            {
                cmb_secim3.BackColor = Color.Brown;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 2)
            {
                cmb_secim3.BackColor = Color.Red;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 3)
            {
                cmb_secim3.BackColor = Color.Orange;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 4)
            {
                cmb_secim3.BackColor = Color.Yellow;
                cmb_secim3.ForeColor = Color.Black;
            }
            else if (cmb_secim3.SelectedIndex == 5)
            {
                cmb_secim3.BackColor = Color.Green;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 6)
            {
                cmb_secim3.BackColor = Color.Blue;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 7)
            {
                cmb_secim3.BackColor = Color.Purple;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 8)
            {
                cmb_secim3.BackColor = Color.Gray;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 9)
            {
                cmb_secim3.BackColor = Color.White;
                cmb_secim3.ForeColor = Color.Black;
            }
            else if (cmb_secim3.SelectedIndex == 10)
            {
                cmb_secim3.BackColor = Color.Gold;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 11)
            {
                cmb_secim3.BackColor = Color.Silver;
                cmb_secim3.ForeColor = Color.White;
            }
            else if (cmb_secim3.SelectedIndex == 12)
            {
                cmb_secim3.BackColor = Color.White;
                cmb_secim3.ForeColor = Color.Black;
            }
        }

        private void cmb_secim4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_secim4.SelectedIndex == 0)
            {
                cmb_secim4.BackColor = Color.Black;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 1)
            {
                cmb_secim4.BackColor = Color.Brown;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 2)
            {
                cmb_secim4.BackColor = Color.Red;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 3)
            {
                cmb_secim4.BackColor = Color.Orange;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 4)
            {
                cmb_secim4.BackColor = Color.Yellow;
                cmb_secim4.ForeColor = Color.Black;
            }
            else if (cmb_secim4.SelectedIndex == 5)
            {
                cmb_secim4.BackColor = Color.Green;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 6)
            {
                cmb_secim4.BackColor = Color.Blue;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 7)
            {
                cmb_secim4.BackColor = Color.Purple;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 8)
            {
                cmb_secim4.BackColor = Color.Gray;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 9)
            {
                cmb_secim4.BackColor = Color.White;
                cmb_secim4.ForeColor = Color.Black;
            }
            else if (cmb_secim4.SelectedIndex == 10)
            {
                cmb_secim4.BackColor = Color.Gold;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 11)
            {
                cmb_secim4.BackColor = Color.Silver;
                cmb_secim4.ForeColor = Color.White;
            }
            else if (cmb_secim4.SelectedIndex == 12)
            {
                cmb_secim4.BackColor = Color.White;
                cmb_secim4.ForeColor = Color.Black;
            }
        }

        private void cmb_secim5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_secim5.SelectedIndex == 0)
            {
                cmb_secim5.BackColor = Color.Black;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 1)
            {
                cmb_secim5.BackColor = Color.Brown;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 2)
            {
                cmb_secim5.BackColor = Color.Red;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 3)
            {
                cmb_secim5.BackColor = Color.Orange;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 4)
            {
                cmb_secim5.BackColor = Color.Yellow;
                cmb_secim5.ForeColor = Color.Black;
            }
            else if (cmb_secim5.SelectedIndex == 5)
            {
                cmb_secim5.BackColor = Color.Green;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 6)
            {
                cmb_secim5.BackColor = Color.Blue;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 7)
            {
                cmb_secim5.BackColor = Color.Purple;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 8)
            {
                cmb_secim5.BackColor = Color.Gray;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 9)
            {
                cmb_secim5.BackColor = Color.White;
                cmb_secim5.ForeColor = Color.Black;
            }
            else if (cmb_secim5.SelectedIndex == 10)
            {
                cmb_secim5.BackColor = Color.Gold;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 11)
            {
                cmb_secim5.BackColor = Color.Silver;
                cmb_secim5.ForeColor = Color.White;
            }
            else if (cmb_secim5.SelectedIndex == 12)
            {
                cmb_secim5.BackColor = Color.White;
                cmb_secim5.ForeColor = Color.Black;
            }
        }

        private void cmb_secim6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_secim6.SelectedIndex == 0)
            {
                cmb_secim6.BackColor = Color.Black;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 1)
            {
                cmb_secim6.BackColor = Color.Brown;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 2)
            {
                cmb_secim6.BackColor = Color.Red;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 3)
            {
                cmb_secim6.BackColor = Color.Orange;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 4)
            {
                cmb_secim6.BackColor = Color.Yellow;
                cmb_secim6.ForeColor = Color.Black;
            }
            else if (cmb_secim6.SelectedIndex == 5)
            {
                cmb_secim6.BackColor = Color.Green;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 6)
            {
                cmb_secim6.BackColor = Color.Blue;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 7)
            {
                cmb_secim6.BackColor = Color.Purple;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 8)
            {
                cmb_secim6.BackColor = Color.Gray;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 9)
            {
                cmb_secim6.BackColor = Color.White;
                cmb_secim6.ForeColor = Color.Black;
            }
            else if (cmb_secim6.SelectedIndex == 10)
            {
                cmb_secim6.BackColor = Color.Gold;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 11)
            {
                cmb_secim6.BackColor = Color.Silver;
                cmb_secim6.ForeColor = Color.White;
            }
            else if (cmb_secim6.SelectedIndex == 12)
            {
                cmb_secim6.BackColor = Color.White;
                cmb_secim6.ForeColor = Color.Black;
            }
        }

        private void pcb_Direnc_Click(object sender, EventArgs e)
        {

        }
    }
}
