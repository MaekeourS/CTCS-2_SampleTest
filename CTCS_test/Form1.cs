using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
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
        int[] lightCodes = { 2, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 21, 21 };
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
                    if (j < 8) j++;
                }
                else
                {
                    j = 0;
                    Temp = i;
                }
                if (i == 18 && ZXJ.Enabled && CXJ.Enabled) j = 0;
                if (Type[i] == Types.ZX || Occupy[Temp] == -1 || TrainLocation > i) 
                    CodeNum[i] = ZXFM[j];
                else CodeNum[i] = CXFM[j]; 
            }
            if (Type[2] == Types.CX)
            {
                for (int i = 2;i>= 0; i--)
                {
                    CodeNum[i] = Codes.UU;
                }
            }
            Train1Moving();
            for (int i = 0; i < 23; i++)
            {
                CodeSwitch(i);
            }
            for (int i = 1; i <= 19; i++)
            {
                LightSwitch(i, lightCodes[i - 1]);
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
            label1.Text = "Speed:"+V.ToString()+"km/h";
        }


        private void CodeSwitch(int index)
        {
            PictureBox pictureBox = Controls.Find("Code" + (index + 1), true).FirstOrDefault() as PictureBox;
            if (pictureBox != null)
            {
                switch (CodeNum[index])
                {
                    case Codes.HU:
                        pictureBox.BackgroundImage = Properties.Resources.HUcode;
                        break;
                    case Codes.UU:
                        pictureBox.BackgroundImage = Properties.Resources.UUcode;
                        break;
                    case Codes.U:
                        pictureBox.BackgroundImage = Properties.Resources.Ucode;
                        break;
                    case Codes.U2:
                        pictureBox.BackgroundImage = Properties.Resources.U2code;
                        break;
                    case Codes.LU:
                        pictureBox.BackgroundImage = Properties.Resources.LUcode;
                        break;
                    case Codes.L:
                        pictureBox.BackgroundImage = Properties.Resources.Lcode;
                        break;
                    case Codes.L2:
                        pictureBox.BackgroundImage = Properties.Resources.L2code;
                        break;
                    case Codes.L3:
                        pictureBox.BackgroundImage = Properties.Resources.L3code;
                        break;
                    case Codes.L4:
                        pictureBox.BackgroundImage = Properties.Resources.L4code;
                        break;
                    case Codes.L5:
                        pictureBox.BackgroundImage = Properties.Resources.L5code;
                        break;
                    default:
                        break;
                }
            }
        }
        private void LightSwitch(int lightIndex, int codeIndex)
        {
            if (CodeNum[codeIndex] == Codes.HU) Controls["Light" + lightIndex].BackgroundImage = Properties.Resources.H;
            else if (CodeNum[codeIndex] == Codes.UU) Controls["Light" + lightIndex].BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[codeIndex] == Codes.U) Controls["Light" + lightIndex].BackgroundImage = Properties.Resources.U;
            else if (CodeNum[codeIndex] == Codes.U2) Controls["Light" + lightIndex].BackgroundImage = Properties.Resources.U;
            else if (CodeNum[codeIndex] == Codes.LU) Controls["Light" + lightIndex].BackgroundImage = Properties.Resources.LU;
            else Controls["Light" + lightIndex].BackgroundImage = Properties.Resources.L;
        }

        private void Train1Moving()
        {
            double Brake = 0;
            int i;
            if (Xp > 47 && Xp < 177) { CodeNum[0] = Codes.HU; Occupy[0] = 1; } else if(Occupy[0] == 1) Occupy[0] = 0;
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

            for (i = 22; i > 0; i--)
            {
                if (Occupy[i] == 1)
                {
                    TrainLocation = i;
                    if (CodeNum[i + 1] == Codes.LU)
                    {
                        Brake = 1;
                        V -= Brake;
                        if (V < 20) V = 20;
                    }
                    if ((CodeNum[i + 1] == Codes.U )||( CodeNum[i + 1] == Codes.U2 )||( CodeNum[i + 1] == Codes.UU && Xp>299))
                    {
                        Brake = 1;
                        V -= Brake;
                        if (V > 200) V = 200;
                        if (V < 20) V = 20;
                    }
                    if (CodeNum[i + 1] == Codes.HU)
                    {
                        Brake = 1;
                        V -= Brake;
                        if (V > 135) V = 135;
                        if ((Xp >= 1487 || CodeNum[i + 1] != Codes.HU) && Xp <= 1645 && V<=20)
                        {
                            Brake = 0;
                            V = 20;
                        }
                        
                    }
                    break;
                }
            }
            
            if((CodeNum[i + 1] >= Codes.L || (Xp<299 && CodeNum[i + 1] == Codes.UU)) && V<250) V +=1;
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
            timer2.Interval = (int)(24500/(V+1));
            if (timer2.Interval>1000)timer2.Interval = 1000;
            Xp++;
            if (Xp >= 250 && Xp <= 295 && side1) Yp += 2;
            if (Xp >= 1540 && Xp <= 1585 && side2) Yp -= 2;
            if (Yp>343)Yp = 343;
            if (Yp<262) Yp = 262;
            Train1.Location = new Point(Xp, Yp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ZXF.Enabled || !CXF.Enabled)
            {
                if (button1.Text == "发车")
                {
                    button2.Enabled = true;
                    button1.Text = "重新发车";
                }
                button4.PerformClick();
                V = 0;
                Xp = 200;
                if (Type[3] == Types.ZX) Yp = 343;
                else Yp = 262;
                Train1.Location = new Point(Xp, Yp);
                timer1.Enabled = true;
                timer2.Enabled = true;
                button2.Text = "暂停";
            }
            else
            {
                MessageBox.Show("未选择发车股道", "错误！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

                timer1.Enabled = !timer1.Enabled;
                if (V > 0.1) timer2.Enabled = !timer2.Enabled;
                if (timer1.Enabled) button2.Text = "暂停";
                else
                {
                    button2.Text = "继续";
                    label1.Text = "暂停中";
                }
        }



        private void radioButton1_Click(object sender, EventArgs e)
        {
            for (int i = 3; i >= 0; i--) Type[i] = Types.ZX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            for (int i = 3; i >= 0; i--) Type[i] = Types.CX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CodeNum[2] = Codes.UU;
            CodeNum[1] = Codes.UU;
            CodeNum[0] = Codes.UU;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            for (int i = 22; i >= 4; i--) Type[i] = Types.ZX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            for (int i = 22; i >= 4; i--) Type[i] = Types.CX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CodeNum[2] = Codes.UU;
            CodeNum[1] = Codes.UU;
            CodeNum[0] = Codes.UU;
        }



        private void Code5_Click(object sender, EventArgs e)
        {
            if (Occupy[4] == -1)
            {
                CodeNum[4] = Codes.L;
                Occupy[4] = 0;
                listBox1.Items.Add("轨道区段5故障占用解除");
            }
            else
            {
                CodeNum[4] = Codes.HU;
                Occupy[4] = -1;
                listBox1.Items.Add("轨道区段5故障占用");
            }
        }

        private void Code6_Click(object sender, EventArgs e)
        {
            if (Occupy[5] == -1)
            {
                CodeNum[5] = Codes.L;
                Occupy[5] = 0;
                listBox1.Items.Add("轨道区段6故障占用解除");
            }
            else
            {
                CodeNum[5] = Codes.HU;
                Occupy[5] = -1;
                listBox1.Items.Add("轨道区段6故障占用");
            }
        }

        private void Code7_Click(object sender, EventArgs e)
        {
            if (Occupy[6] == -1)
            {
                CodeNum[6] = Codes.L;
                Occupy[6] = 0;
                listBox1.Items.Add("轨道区段7故障占用解除");
            }
            else
            {
                CodeNum[6] = Codes.HU;
                Occupy[6] = -1;
                listBox1.Items.Add("轨道区段7故障占用");
            }
        }
        private void Code8_Click(object sender, EventArgs e)
        {
            if (Occupy[7] == -1)
            {
                CodeNum[7] = Codes.L;
                Occupy[7] = 0;
                listBox1.Items.Add("轨道区段8故障占用解除");
            }
            else
            {
                CodeNum[7] = Codes.HU;
                Occupy[7] = -1;
                listBox1.Items.Add("轨道区段8故障占用");
            }
        }

        private void Code9_Click(object sender, EventArgs e)
        {
            if (Occupy[8] == -1)
            {
                CodeNum[8] = Codes.L;
                Occupy[8] = 0;
                listBox1.Items.Add("轨道区段9故障占用解除");
            }
            else
            {
                CodeNum[8] = Codes.HU;
                Occupy[8] = -1;
                listBox1.Items.Add("轨道区段9故障占用");
            }
        }

        private void Code10_Click(object sender, EventArgs e)
        {
            if (Occupy[9] == -1)
            {
                CodeNum[9] = Codes.L;
                Occupy[9] = 0;
                listBox1.Items.Add("轨道区段10故障占用解除");
            }
            else
            {
                CodeNum[9] = Codes.HU;
                Occupy[9] = -1;
                listBox1.Items.Add("轨道区段10故障占用");
            }
        }

        private void Code11_Click(object sender, EventArgs e)
        {
            if (Occupy[10] == -1)
            {
                CodeNum[10] = Codes.L;
                Occupy[10] = 0;
                listBox1.Items.Add("轨道区段11故障占用解除");
            }
            else
            {
                CodeNum[10] = Codes.HU;
                Occupy[10] = -1;
                listBox1.Items.Add("轨道区段11故障占用");
            }
        }

        private void Code12_Click(object sender, EventArgs e)
        {
            if (Occupy[11] == -1)
            {
                CodeNum[11] = Codes.L;
                Occupy[11] = 0;
                listBox1.Items.Add("轨道区段12故障占用解除");
            }
            else
            {
                CodeNum[11] = Codes.HU;
                Occupy[11] = -1;
                listBox1.Items.Add("轨道区段12故障占用");
            }
        }

        private void Code13_Click(object sender, EventArgs e)
        {
            if (Occupy[12] == -1)
            {
                CodeNum[12] = Codes.L;
                Occupy[12] = 0;
                listBox1.Items.Add("轨道区段13故障占用解除");
            }
            else
            {
                CodeNum[12] = Codes.HU;
                Occupy[12] = -1;
                listBox1.Items.Add("轨道区段13故障占用");
            }
        }

        private void Code14_Click(object sender, EventArgs e)
        {
            if (Occupy[13] == -1)
            {
                CodeNum[13] = Codes.L;
                Occupy[13] = 0;
                listBox1.Items.Add("轨道区段14故障占用解除");
            }
            else
            {
                CodeNum[13] = Codes.HU;
                Occupy[13] = -1;
                listBox1.Items.Add("轨道区段14故障占用");
            }
        }

        private void Code15_Click(object sender, EventArgs e)
        {
            if (Occupy[14] == -1)
            {
                CodeNum[14] = Codes.L;
                Occupy[14] = 0;
                listBox1.Items.Add("轨道区段15故障占用解除");
            }
            else
            {
                CodeNum[14] = Codes.HU;
                Occupy[14] = -1;
                listBox1.Items.Add("轨道区段15故障占用");
            }
        }

        private void Code16_Click(object sender, EventArgs e)
        {
            if (Occupy[15] == -1)
            {
                CodeNum[15] = Codes.L;
                Occupy[15] = 0;
                listBox1.Items.Add("轨道区段16故障占用解除");
            }
            else
            {
                CodeNum[15] = Codes.HU;
                Occupy[15] = -1;
                listBox1.Items.Add("轨道区段16故障占用");
            }
        }

        private void Code17_Click(object sender, EventArgs e)
        {
            if (Occupy[16] == -1)
            {
                CodeNum[16] = Codes.L;
                Occupy[16] = 0;
                listBox1.Items.Add("轨道区段17故障占用解除");
            }
            else
            {
                CodeNum[16] = Codes.HU;
                Occupy[16] = -1;
                listBox1.Items.Add("轨道区段17故障占用");
            }
        }

        private void Code18_Click(object sender, EventArgs e)
        {
            if (Occupy[17] == -1)
            {
                CodeNum[17] = Codes.L;
                Occupy[17] = 0;
                listBox1.Items.Add("轨道区段18故障占用解除");
            }
            else
            {
                CodeNum[17] = Codes.HU;
                Occupy[17] = -1;
                listBox1.Items.Add("轨道区段18故障占用");
            }
        }

        private void Code19_Click(object sender, EventArgs e)
        {
            if (Occupy[18] == -1)
            {
                CodeNum[18] = Codes.L;
                Occupy[18] = 0;
                listBox1.Items.Add("轨道区段19故障占用解除");
            }
            else
            {
                CodeNum[18] = Codes.HU;
                Occupy[18] = -1;
                listBox1.Items.Add("轨道区段19故障占用");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 22; i >= 0; i--)
            {
                if (Occupy[i] == -1) listBox1.Items.Add("轨道区段" + (i + 1).ToString() + "故障占用");
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
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
        }

        private void ZXJ_Click(object sender, EventArgs e)
        {
            for (int i = 22; i >= 4; i--) Type[i] = Types.ZX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CXJ.Enabled = true;
            ZXJ.Enabled = false;
        }

        private void CXJ_Click(object sender, EventArgs e)
        {
            for (int i = 22; i >= 4; i--) Type[i] = Types.CX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CodeNum[2] = Codes.UU;
            CodeNum[1] = Codes.UU;
            CodeNum[0] = Codes.UU;
            ZXJ.Enabled = true;
            CXJ.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZXJ.Enabled = true;
            CXJ.Enabled = true;
        }
    }
}
