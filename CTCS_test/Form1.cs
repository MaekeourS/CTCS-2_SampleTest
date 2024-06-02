using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CTCS_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Codes { HU, HB, UU, UUS, U, U2, U2S, LU, L, L2, L3, L4, L5 }
        enum Types { ZX, CX, YDZX, YDCX }
        Codes[] CodeNum = new Codes[23];
        Types[] Type = new Types[23];
        int[] Occupy = new int[23];
        int[] LightCodes = { 2, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 20 };
        double V = 0;
        int Xp = 200;
        int Yp = 343;
        bool side1 = false, side2 = false;
        int TrainLocation = 3;
        Codes[] ZXFM = { Codes.HU, Codes.U, Codes.LU, Codes.L, Codes.L2, Codes.L3, Codes.L4, Codes.L5, Codes.L5 };
        Codes[] CXFM = { Codes.HU, Codes.UU, Codes.U2, Codes.LU, Codes.L, Codes.L2, Codes.L3, Codes.L4, Codes.L5 };
        private void timer1_Tick(object sender, EventArgs e)
        {
            int j = 0, Temp = 19;
            for (int i = 18; i >= 0; i--)
            {
                if (Occupy[i] == 0)
                {
                    if (j < 8 && i != 3) j++;
                    //if (i == 3) j--;
                }
                else
                {
                    j = 0;
                    Temp = i;
                }
                if (i == 18 && (ZXJ.Enabled && CXJ.Enabled || Xp >= 1487)) j = 0;
                if (Type[i] == Types.ZX || Occupy[Temp] == -1 || TrainLocation > i)
                    CodeNum[i] = ZXFM[j];
                else CodeNum[i] = CXFM[j];
            }
            if (Type[2] == Types.CX)
            {
                for (int i = 2; i >= 0; i--)
                {
                    CodeNum[i] = Codes.UU;
                }
            }
            Train1Moving();
            for (int i = 1; i < 24; i++)
            {
                CodeSwitch(i);
            }
            for (int i = 1; i <= 19; i++)
            {
                LightSwitch(i, LightCodes[i - 1]);
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
            label1.Text = "Speed:" + V.ToString() + "km/h";
        }


        private void CodeSwitch(int i)
        {
            switch (CodeNum[i - 1])
            {
                case Codes.HU:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.HUcode;
                    break;
                case Codes.UU:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.UUcode;
                    break;
                case Codes.U:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.Ucode;
                    break;
                case Codes.U2:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.U2code;
                    break;
                case Codes.LU:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.LUcode;
                    break;
                case Codes.L:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.Lcode;
                    break;
                case Codes.L2:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.L2code;
                    break;
                case Codes.L3:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.L3code;
                    break;
                case Codes.L4:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.L4code;
                    break;
                case Codes.L5:
                    Controls["Code" + i].BackgroundImage = Properties.Resources.L5code;
                    break;
                default:
                    break;
            }
        }
        private void LightSwitch(int Light, int Code)
        {
            if (CodeNum[Code] == Codes.HU) Controls["Light" + Light].BackgroundImage = Properties.Resources.H;
            else if (CodeNum[Code] == Codes.UU) Controls["Light" + Light].BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[Code] == Codes.U) Controls["Light" + Light].BackgroundImage = Properties.Resources.U;
            else if (CodeNum[Code] == Codes.U2) Controls["Light" + Light].BackgroundImage = Properties.Resources.U;
            else if (CodeNum[Code] == Codes.LU) Controls["Light" + Light].BackgroundImage = Properties.Resources.LU;
            else Controls["Light" + Light].BackgroundImage = Properties.Resources.L;
        }

        private void Train1Moving()
        {
            double Brake = 0;
            int i;
            if (Xp > 47 && Xp < 177) { CodeNum[0] = Codes.HU; Occupy[0] = 1; } else if (Occupy[0] == 1) Occupy[0] = 0;
            if (Xp > 127 && Xp < 257) { CodeNum[1] = Codes.HU; Occupy[1] = 1; } else if (Occupy[1] == 1) Occupy[1] = 0;
            if (Xp > 207 && Xp < 337) { CodeNum[2] = Codes.HU; Occupy[2] = 1; } else if (Occupy[2] == 1) Occupy[2] = 0;
            if (Xp > 287 && Xp < 417) { CodeNum[3] = Codes.HU; Occupy[3] = 1; } else if (Occupy[3] == 1) Occupy[3] = 0;
            if (Xp > 367 && Xp < 497) { CodeNum[4] = Codes.HU; Occupy[4] = 1; } else if (Occupy[4] == 1) Occupy[4] = 0;
            if (Xp > 447 && Xp < 577) { CodeNum[5] = Codes.HU; Occupy[5] = 1; } else if (Occupy[5] == 1) Occupy[5] = 0;
            if (Xp > 527 && Xp < 657) { CodeNum[6] = Codes.HU; Occupy[6] = 1; } else if (Occupy[6] == 1) Occupy[6] = 0;
            if (Xp > 607 && Xp < 737) { CodeNum[7] = Codes.HU; Occupy[7] = 1; } else if (Occupy[7] == 1) Occupy[7] = 0;
            if (Xp > 687 && Xp < 817) { CodeNum[8] = Codes.HU; Occupy[8] = 1; } else if (Occupy[8] == 1) Occupy[8] = 0;
            if (Xp > 767 && Xp < 897) { CodeNum[9] = Codes.HU; Occupy[9] = 1; } else if (Occupy[9] == 1) Occupy[9] = 0;
            if (Xp > 847 && Xp < 977) { CodeNum[10] = Codes.HU; Occupy[10] = 1; } else if (Occupy[10] == 1) Occupy[10] = 0;
            if (Xp > 927 && Xp < 1057) { CodeNum[11] = Codes.HU; Occupy[11] = 1; } else if (Occupy[11] == 1) Occupy[11] = 0;
            if (Xp > 1007 && Xp < 1137) { CodeNum[12] = Codes.HU; Occupy[12] = 1; } else if (Occupy[12] == 1) Occupy[12] = 0;
            if (Xp > 1087 && Xp < 1217) { CodeNum[13] = Codes.HU; Occupy[13] = 1; } else if (Occupy[13] == 1) Occupy[13] = 0;
            if (Xp > 1167 && Xp < 1297) { CodeNum[14] = Codes.HU; Occupy[14] = 1; } else if (Occupy[14] == 1) Occupy[14] = 0;
            if (Xp > 1247 && Xp < 1377) { CodeNum[15] = Codes.HU; Occupy[15] = 1; } else if (Occupy[15] == 1) Occupy[15] = 0;
            if (Xp > 1327 && Xp < 1457) { CodeNum[16] = Codes.HU; Occupy[16] = 1; } else if (Occupy[16] == 1) Occupy[16] = 0;
            if (Xp > 1407 && Xp < 1537) { CodeNum[17] = Codes.HU; Occupy[17] = 1; } else if (Occupy[17] == 1) Occupy[17] = 0;
            if (Xp > 1487 && Xp < 1617) { CodeNum[18] = Codes.HU; Occupy[18] = 1; } else if (Occupy[18] == 1) Occupy[18] = 0;
            if (Xp > 1567 && Xp < 1697) { CodeNum[19] = Codes.HU; Occupy[19] = 1; } else if (Occupy[19] == 1) Occupy[19] = 0;
            if (Xp > 1647 && Xp < 1777) { CodeNum[20] = Codes.HU; Occupy[20] = 1; } else if (Occupy[20] == 1) Occupy[20] = 0;
            if (Xp > 1727 && Xp < 1857) { CodeNum[20] = Codes.HU; Occupy[20] = 1; } else if (Occupy[20] == 1) Occupy[20] = 0;
            if (Xp > 1487)
            {
                ZXJ.Enabled = false;
                CXJ.Enabled = false;
                NotJC.Enabled = false;
            }
            for (i = 22; i > 0; i--)
            {
                if (Occupy[i] == 1)
                {
                    TrainLocation = i;
                    if (CodeNum[i + 1] == Codes.LU)
                    {
                        if (V > 160)
                        {
                            Brake = 1;
                            V -= Brake;
                        }
                    }
                    else if ((CodeNum[i + 1] == Codes.U) || (CodeNum[i + 1] == Codes.U2) || (CodeNum[i + 1] == Codes.UU && Xp > 299))
                    {
                        if( V > 100)
                        {
                            Brake = 1;
                            V -= Brake;
                        }
                        if (V > 200) V = 200;
                    }
                    else if (CodeNum[i + 1] == Codes.HU)
                    {
                        Brake = 1;
                        V -= Brake;
                        if (V > 135) V = 135;
                        if ((Xp >= 1487 && Xp <= 1645 || Occupy[i - 1] == 1) && V <= 20)
                        {
                            Brake = 0;
                            V = 20;
                        }
                        if (Xp >= 1617 && CodeNum[22] != Codes.HU)
                        {
                            V += 1;
                        }
                    }
                    break;
                }
            }
            if (Xp >= 1768)
            {
                Application.Restart();
            }
            if ((CodeNum[i + 1] >= Codes.L || (Xp < 299 && CodeNum[i + 1] == Codes.UU)) && V < 250) V += 1;
            if (Type[3] == Types.ZX) side1 = false; else side1 = true;
            if (Type[19] == Types.ZX) side2 = false; else side2 = true;
            if (V > 250) V = 250;
            if (V <= 0)
            {
                V = 0;
                timer2.Enabled = false;
            }
            else timer2.Enabled = true;
            //if (CodeNum[i + 1] == Codes.HU && V < 20) V = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Speed:" + V.ToString() + "km/h";
            CodeNum[19] = Codes.HU;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = (int)(24500 / (V + 1));
            if (timer2.Interval > 1000) timer2.Interval = 1000;
            Xp++;
            if (Xp >= 250 && Xp <= 295 && side1) Yp += 2;
            if (Xp >= 1540 && Xp <= 1585 && side2) Yp -= 2;
            if (Yp > 343) Yp = 343;
            if (Yp < 262) Yp = 262;
            Train1.Location = new Point(Xp, Yp);
        }

        private void ZXF_Click(object sender, EventArgs e)
        {
            for (int i = 3; i >= 0; i--) Type[i] = Types.ZX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CXF.Enabled = true;
            ZXF.Enabled = false;
            Suspend.Enabled = false;
        }

        private void CXF_Click(object sender, EventArgs e)
        {
            for (int i = 3; i >= 0; i--) Type[i] = Types.CX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CodeNum[2] = Codes.UU;
            CodeNum[1] = Codes.UU;
            CodeNum[0] = Codes.UU;
            ZXF.Enabled = true;
            CXF.Enabled = false;
            Suspend.Enabled = false;
        }

        private void ZXJ_Click(object sender, EventArgs e)
        {
            CXJ.Enabled = true;
            ZXJ.Enabled = false;
            NotJC.Enabled = true;
            side2 = false;
            JC();
        }

        private void CXJ_Click(object sender, EventArgs e)
        {
            ZXJ.Enabled = true;
            CXJ.Enabled = false;
            NotJC.Enabled = true;
            side2 = true;
            JC();
        }

        private void Code_Click(object sender, EventArgs e)
        {
            PictureBox PictureBox = (PictureBox)sender;
            int i = int.Parse(PictureBox.Name.Substring(4)) - 1;
            if (Occupy[i] == -1)
            {
                CodeNum[i] = Codes.L;
                Occupy[i] = 0;
                listBox1.Items.Add("轨道区段" + (i + 1).ToString() + "故障占用解除");
            }
            else
            {
                CodeNum[i] = Codes.HU;
                Occupy[i] = -1;
                listBox1.Items.Add("轨道区段" + (i + 1).ToString() + "故障占用");
            }
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            Pass.Enabled = false;
            Stop.Enabled = true;
            JC();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Stop.Enabled = false;
            Pass.Enabled = true;
            JC();
        }

        private void NotJC_Click(object sender, EventArgs e)
        {
            NotJC.Enabled = false;
            ZXJ.Enabled = true;
            CXJ.Enabled = true;
            Stop.Enabled = false;
            Pass.Enabled = true;
            side2 = false;
            JC();
        }

        private void Depart_Click(object sender, EventArgs e)
        {
            if (!ZXF.Enabled || !CXF.Enabled)
            {
                ZXF.Enabled = false;
                CXF.Enabled = false;
                if (Depart.Text == "发车")
                {
                    Depart.Text = "重新发车";
                }
                Sweep.PerformClick();
                V = 0;
                Xp = 200;
                if (Type[3] == Types.ZX) Yp = 343;
                else Yp = 262;
                Train1.Location = new Point(Xp, Yp);
                Suspend.Text = "暂停";
                timer1.Enabled = true;
                timer2.Enabled = true;
                Suspend.Enabled = true;
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("未选择发车股道", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Suspend_Click(object sender, EventArgs e)
        {

            timer1.Enabled = !timer1.Enabled;
            if (V > 0.1) timer2.Enabled = !timer2.Enabled;
            if (timer1.Enabled)
            {
                ZXF.Enabled = false;
                CXF.Enabled = false;
                Suspend.Text = "暂停";
            }
            else
            {
                if (side1) ZXF.Enabled = true;
                else CXF.Enabled = true;
                Suspend.Text = "继续";
                label1.Text = "暂停中";
            }
        }

        private void Sweep_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 22; i >= 0; i--)
            {
                if (Occupy[i] == -1) listBox1.Items.Add("轨道区段" + (i + 1).ToString() + "故障占用");
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void JC()
        {
            if (side2)
            {
                for (int i = 22; i >= 4; i--) Type[i] = Types.CX;
                if (!Stop.Enabled)
                {
                    CodeNum[22] = Codes.HU;
                    CodeNum[21] = Codes.HU;
                    CodeNum[20] = Codes.HU;
                    CodeNum[19] = Codes.HU;
                    CodeNum[2] = Codes.UU;
                    CodeNum[1] = Codes.UU;
                    CodeNum[0] = Codes.UU;
                }
                else if (!Pass.Enabled)
                {
                    CodeNum[22] = Codes.UU;
                    CodeNum[21] = Codes.UU;
                    CodeNum[20] = Codes.UU;
                    CodeNum[19] = Codes.UU;
                    CodeNum[2] = Codes.UU;
                    CodeNum[1] = Codes.UU;
                    CodeNum[0] = Codes.UU;
                }
            }
            else
            {
                for (int i = 22; i >= 4; i--) Type[i] = Types.ZX;
                if (!Stop.Enabled)
                {
                    CodeNum[22] = Codes.HU;
                    CodeNum[21] = Codes.HU;
                    CodeNum[20] = Codes.HU;
                    CodeNum[19] = Codes.HU;
                }
                else if (!Pass.Enabled)
                {
                    CodeNum[22] = Codes.U;
                    CodeNum[21] = Codes.U;
                    CodeNum[20] = Codes.U;
                    CodeNum[19] = Codes.U;
                }
            }
        }
    }
}
