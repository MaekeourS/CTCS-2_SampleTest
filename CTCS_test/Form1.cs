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

namespace CTCS_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Codes { HU, HB, UU, UUS, U, U2, U2S, LU, L, L2, L3, L4, L5 }
        enum Types { ZXZX, ZXCX, CXZX, CXCX }
        Codes[] CodeNum = new Codes[23];
        Types[] Type = new Types[23];
        int[] Occupy = new int[23];
        double V = 250;
        int Xp = 1200;
        int Yp = 342;
        bool side1 = false, side2 = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 21; i >= 0; i--)
            {
                if (CodeNum[i + 1] == Codes.HU && Occupy[i + 1] != 0 && Occupy[i] == 0)
                {
                    CodeNum[i] = Codes.U;
                    if(i>=1)CodeNum[i - 1] = Codes.LU;
                    for (int j = i - 2; j >= 0; j--)
                    {
                        if (CodeNum[j + 1] < Codes.L5)
                        {
                            CodeNum[j] = CodeNum[j + 1] + 1;
                        }
                        else
                        {
                            CodeNum[j] = Codes.L5;
                        }
                    }

                }
            }

            Train1.Enabled = !Train1.Enabled;
            Code1.Enabled = !Code1.Enabled;
            Code2.Enabled = !Code2.Enabled;
            Code3.Enabled = !Code3.Enabled;
            Code4.Enabled = !Code4.Enabled;
            Code5.Enabled = !Code5.Enabled;
            Code6.Enabled = !Code6.Enabled;
            Code7.Enabled = !Code7.Enabled;
            Code8.Enabled = !Code8.Enabled;
            Code9.Enabled = !Code9.Enabled;
            Code10.Enabled = !Code10.Enabled;
            Code11.Enabled = !Code11.Enabled;
            Code12.Enabled = !Code12.Enabled;
            Code13.Enabled = !Code13.Enabled;
            Code14.Enabled = !Code14.Enabled;
            Code15.Enabled = !Code15.Enabled;
            Code16.Enabled = !Code16.Enabled;
            Code17.Enabled = !Code17.Enabled;
            Code18.Enabled = !Code18.Enabled;
            Code19.Enabled = !Code19.Enabled;
            Code20.Enabled = !Code20.Enabled;
            Code21.Enabled = !Code21.Enabled;
            Code22.Enabled = !Code22.Enabled;
            Code23.Enabled = !Code23.Enabled;
            Light1.Enabled = !Light1.Enabled;
            Light2.Enabled = !Light2.Enabled;
            Light3.Enabled = !Light3.Enabled;
            Light4.Enabled = !Light4.Enabled;
            Light5.Enabled = !Light5.Enabled;
            Light6.Enabled = !Light6.Enabled;
            Light7.Enabled = !Light7.Enabled;
            Light8.Enabled = !Light8.Enabled;
            Light9.Enabled = !Light9.Enabled;
            Light10.Enabled = !Light10.Enabled;
            Light11.Enabled = !Light11.Enabled;
            Light12.Enabled = !Light12.Enabled;
            Light13.Enabled = !Light13.Enabled;
            Light14.Enabled = !Light14.Enabled;
            Light15.Enabled = !Light15.Enabled;
            Light16.Enabled = !Light16.Enabled;
            Light17.Enabled = !Light17.Enabled;
            Light18.Enabled = !Light18.Enabled;
            Light19.Enabled = !Light19.Enabled;
            label1.Text = "Speed:"+V.ToString()+"km/h";
        }
        private void Code1_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[0] == Codes.HU) Code1.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[0] == Codes.UU) Code1.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[0] == Codes.U) Code1.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[0] == Codes.U2) Code1.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[0] == Codes.LU) Code1.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[0] == Codes.L) Code1.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[0] == Codes.L2) Code1.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[0] == Codes.L3) Code1.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[0] == Codes.L4) Code1.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[0] == Codes.L5) Code1.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code2_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[1] == Codes.HU) Code2.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[1] == Codes.UU) Code2.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[1] == Codes.U) Code2.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[1] == Codes.U2) Code2.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[1] == Codes.LU) Code2.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[1] == Codes.L) Code2.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[1] == Codes.L2) Code2.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[1] == Codes.L3) Code2.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[1] == Codes.L4) Code2.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[1] == Codes.L5) Code2.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code3_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[2] == Codes.HU) Code3.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[2] == Codes.UU) Code3.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[2] == Codes.U) Code3.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[2] == Codes.U2) Code3.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[2] == Codes.LU) Code3.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[2] == Codes.L) Code3.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[2] == Codes.L2) Code3.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[2] == Codes.L3) Code3.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[2] == Codes.L4) Code3.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[2] == Codes.L5) Code3.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code4_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[3] == Codes.HU) Code4.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[3] == Codes.UU) Code4.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[3] == Codes.U) Code4.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[3] == Codes.U2) Code4.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[3] == Codes.LU) Code4.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[3] == Codes.L) Code4.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[3] == Codes.L2) Code4.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[3] == Codes.L3) Code4.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[3] == Codes.L4) Code4.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[3] == Codes.L5) Code4.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code5_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[4] == Codes.HU) Code5.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[4] == Codes.UU) Code5.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[4] == Codes.U) Code5.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[4] == Codes.U2) Code5.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[4] == Codes.LU) Code5.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[4] == Codes.L) Code5.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[4] == Codes.L2) Code5.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[4] == Codes.L3) Code5.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[4] == Codes.L4) Code5.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[4] == Codes.L5) Code5.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code6_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[5] == Codes.HU) Code6.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[5] == Codes.UU) Code6.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[5] == Codes.U) Code6.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[5] == Codes.U2) Code6.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[5] == Codes.LU) Code6.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[5] == Codes.L) Code6.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[5] == Codes.L2) Code6.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[5] == Codes.L3) Code6.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[5] == Codes.L4) Code6.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[5] == Codes.L5) Code6.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code7_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[6] == Codes.HU) Code7.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[6] == Codes.UU) Code7.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[6] == Codes.U) Code7.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[6] == Codes.U2) Code7.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[6] == Codes.LU) Code7.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[6] == Codes.L) Code7.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[6] == Codes.L2) Code7.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[6] == Codes.L3) Code7.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[6] == Codes.L4) Code7.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[6] == Codes.L5) Code7.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code8_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[7] == Codes.HU) Code8.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[7] == Codes.UU) Code8.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[7] == Codes.U) Code8.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[7] == Codes.U2) Code8.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[7] == Codes.LU) Code8.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[7] == Codes.L) Code8.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[7] == Codes.L2) Code8.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[7] == Codes.L3) Code8.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[7] == Codes.L4) Code8.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[7] == Codes.L5) Code8.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code9_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[8] == Codes.HU) Code9.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[8] == Codes.UU) Code9.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[8] == Codes.U) Code9.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[8] == Codes.U2) Code9.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[8] == Codes.LU) Code9.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[8] == Codes.L) Code9.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[8] == Codes.L2) Code9.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[8] == Codes.L3) Code9.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[8] == Codes.L4) Code9.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[8] == Codes.L5) Code9.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code10_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[9] == Codes.HU) Code10.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[9] == Codes.UU) Code10.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[9] == Codes.U) Code10.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[9] == Codes.U2) Code10.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[9] == Codes.LU) Code10.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[9] == Codes.L) Code10.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[9] == Codes.L2) Code10.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[9] == Codes.L3) Code10.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[9] == Codes.L4) Code10.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[9] == Codes.L5) Code10.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code11_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[10] == Codes.HU) Code11.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[10] == Codes.UU) Code11.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[10] == Codes.U) Code11.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[10] == Codes.U2) Code11.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[10] == Codes.LU) Code11.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[10] == Codes.L) Code11.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[10] == Codes.L2) Code11.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[10] == Codes.L3) Code11.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[10] == Codes.L4) Code11.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[10] == Codes.L5) Code11.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code12_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[11] == Codes.HU) Code12.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[11] == Codes.UU) Code12.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[11] == Codes.U) Code12.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[11] == Codes.U2) Code12.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[11] == Codes.LU) Code12.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[11] == Codes.L) Code12.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[11] == Codes.L2) Code12.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[11] == Codes.L3) Code12.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[11] == Codes.L4) Code12.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[11] == Codes.L5) Code12.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code13_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[12] == Codes.HU) Code13.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[12] == Codes.UU) Code13.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[12] == Codes.U) Code13.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[12] == Codes.U2) Code13.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[12] == Codes.LU) Code13.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[12] == Codes.L) Code13.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[12] == Codes.L2) Code13.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[12] == Codes.L3) Code13.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[12] == Codes.L4) Code13.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[12] == Codes.L5) Code13.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code14_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[13] == Codes.HU) Code14.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[13] == Codes.UU) Code14.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[13] == Codes.U) Code14.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[13] == Codes.U2) Code14.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[13] == Codes.LU) Code14.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[13] == Codes.L) Code14.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[13] == Codes.L2) Code14.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[13] == Codes.L3) Code14.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[13] == Codes.L4) Code14.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[13] == Codes.L5) Code14.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code15_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[14] == Codes.HU) Code15.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[14] == Codes.UU) Code15.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[14] == Codes.U) Code15.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[14] == Codes.U2) Code15.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[14] == Codes.LU) Code15.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[14] == Codes.L) Code15.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[14] == Codes.L2) Code15.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[14] == Codes.L3) Code15.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[14] == Codes.L4) Code15.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[14] == Codes.L5) Code15.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code16_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[15] == Codes.HU) Code16.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[15] == Codes.UU) Code16.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[15] == Codes.U) Code16.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[15] == Codes.U2) Code16.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[15] == Codes.LU) Code16.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[15] == Codes.L) Code16.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[15] == Codes.L2) Code16.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[15] == Codes.L3) Code16.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[15] == Codes.L4) Code16.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[15] == Codes.L5) Code16.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code17_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[16] == Codes.HU) Code17.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[16] == Codes.UU) Code17.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[16] == Codes.U) Code17.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[16] == Codes.U2) Code17.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[16] == Codes.LU) Code17.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[16] == Codes.L) Code17.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[16] == Codes.L2) Code17.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[16] == Codes.L3) Code17.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[16] == Codes.L4) Code17.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[16] == Codes.L5) Code17.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code18_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[17] == Codes.HU) Code18.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[17] == Codes.UU) Code18.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[17] == Codes.U) Code18.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[17] == Codes.U2) Code18.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[17] == Codes.LU) Code18.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[17] == Codes.L) Code18.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[17] == Codes.L2) Code18.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[17] == Codes.L3) Code18.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[17] == Codes.L4) Code18.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[17] == Codes.L5) Code18.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code19_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[18] == Codes.HU) Code19.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[18] == Codes.UU) Code19.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[18] == Codes.U) Code19.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[18] == Codes.U2) Code19.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[18] == Codes.LU) Code19.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[18] == Codes.L) Code19.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[18] == Codes.L2) Code19.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[18] == Codes.L3) Code19.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[18] == Codes.L4) Code19.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[18] == Codes.L5) Code19.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code20_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[19] == Codes.HU) Code20.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[19] == Codes.UU) Code20.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[19] == Codes.U) Code20.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[19] == Codes.U2) Code20.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[19] == Codes.LU) Code20.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[19] == Codes.L) Code20.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[19] == Codes.L2) Code20.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[19] == Codes.L3) Code20.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[19] == Codes.L4) Code20.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[19] == Codes.L5) Code20.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code21_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[20] == Codes.HU) Code21.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[20] == Codes.UU) Code21.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[20] == Codes.U) Code21.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[20] == Codes.U2) Code21.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[20] == Codes.LU) Code21.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[20] == Codes.L) Code21.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[20] == Codes.L2) Code21.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[20] == Codes.L3) Code21.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[20] == Codes.L4) Code21.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[20] == Codes.L5) Code21.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code22_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[21] == Codes.HU) Code22.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[21] == Codes.UU) Code22.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[21] == Codes.U) Code22.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[21] == Codes.U2) Code22.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[21] == Codes.LU) Code22.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[21] == Codes.L) Code22.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[21] == Codes.L2) Code22.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[21] == Codes.L3) Code22.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[21] == Codes.L4) Code22.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[21] == Codes.L5) Code22.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Code23_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[22] == Codes.HU) Code23.BackgroundImage = CTCS_test.Properties.Resources.HUcode;
            if (CodeNum[22] == Codes.UU) Code23.BackgroundImage = CTCS_test.Properties.Resources.UUcode;
            if (CodeNum[22] == Codes.U) Code23.BackgroundImage = CTCS_test.Properties.Resources.Ucode;
            if (CodeNum[22] == Codes.U2) Code23.BackgroundImage = CTCS_test.Properties.Resources.U2code;
            if (CodeNum[22] == Codes.LU) Code23.BackgroundImage = CTCS_test.Properties.Resources.LUcode;
            if (CodeNum[22] == Codes.L) Code23.BackgroundImage = CTCS_test.Properties.Resources.Lcode;
            if (CodeNum[22] == Codes.L2) Code23.BackgroundImage = CTCS_test.Properties.Resources.L2code;
            if (CodeNum[22] == Codes.L3) Code23.BackgroundImage = CTCS_test.Properties.Resources.L3code;
            if (CodeNum[22] == Codes.L4) Code23.BackgroundImage = CTCS_test.Properties.Resources.L4code;
            if (CodeNum[22] == Codes.L5) Code23.BackgroundImage = CTCS_test.Properties.Resources.L5code;
        }

        private void Light1_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[2] == Codes.HU) Light1.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[2] == Codes.UU) Light1.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[2] == Codes.U) Light1.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[2] == Codes.U2) Light1.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[2] == Codes.LU) Light1.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light1.BackgroundImage = CTCS_test.Properties.Resources.L;
        }
        private void Light2_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[2] == Codes.HU) Light2.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[2] == Codes.UU) Light2.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[2] == Codes.U) Light2.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[2] == Codes.U2) Light2.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[2] == Codes.LU) Light2.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light2.BackgroundImage = CTCS_test.Properties.Resources.L;
        }
        private void Light3_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[4] == Codes.HU) Light3.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[4] == Codes.UU) Light3.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[4] == Codes.U) Light3.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[4] == Codes.U2) Light3.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[4] == Codes.LU) Light3.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light3.BackgroundImage = CTCS_test.Properties.Resources.L;

        }

        private void Light4_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[5] == Codes.HU) Light4.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[5] == Codes.UU) Light4.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[5] == Codes.U) Light4.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[5] == Codes.U2) Light4.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[5] == Codes.LU) Light4.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light4.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light5_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[6] == Codes.HU) Light5.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[6] == Codes.UU) Light5.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[6] == Codes.U) Light5.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[6] == Codes.U2) Light5.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[6] == Codes.LU) Light5.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light5.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light6_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[7] == Codes.HU) Light6.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[7] == Codes.UU) Light6.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[7] == Codes.U) Light6.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[7] == Codes.U2) Light6.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[7] == Codes.LU) Light6.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light6.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light7_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[8] == Codes.HU) Light7.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[8] == Codes.UU) Light7.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[8] == Codes.U) Light7.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[8] == Codes.U2) Light7.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[8] == Codes.LU) Light7.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light7.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light8_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[9] == Codes.HU) Light8.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[9] == Codes.UU) Light8.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[9] == Codes.U) Light8.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[9] == Codes.U2) Light8.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[9] == Codes.LU) Light8.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light8.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light9_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[10] == Codes.HU) Light9.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[10] == Codes.UU) Light9.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[10] == Codes.U) Light9.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[10] == Codes.U2) Light9.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[10] == Codes.LU) Light9.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light9.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light10_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[11] == Codes.HU) Light10.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[11] == Codes.UU) Light10.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[11] == Codes.U) Light10.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[11] == Codes.U2) Light10.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[11] == Codes.LU) Light10.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light10.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light11_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[12] == Codes.HU) Light11.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[12] == Codes.UU) Light11.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[12] == Codes.U) Light11.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[12] == Codes.U2) Light11.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[12] == Codes.LU) Light11.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light11.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light12_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[13] == Codes.HU) Light12.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[13] == Codes.UU) Light12.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[13] == Codes.U) Light12.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[13] == Codes.U2) Light12.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[13] == Codes.LU) Light12.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light12.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light13_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[14] == Codes.HU) Light13.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[14] == Codes.UU) Light13.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[14] == Codes.U) Light13.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[14] == Codes.U2) Light13.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[14] == Codes.LU) Light13.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light13.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light14_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[15] == Codes.HU) Light14.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[15] == Codes.UU) Light14.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[15] == Codes.U) Light14.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[15] == Codes.U2) Light14.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[15] == Codes.LU) Light14.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light14.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light15_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[16] == Codes.HU) Light15.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[16] == Codes.UU) Light15.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[16] == Codes.U) Light15.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[16] == Codes.U2) Light15.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[16] == Codes.LU) Light15.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light15.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light16_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[17] == Codes.HU) Light16.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[17] == Codes.UU) Light16.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[17] == Codes.U) Light16.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[17] == Codes.U2) Light16.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[17] == Codes.LU) Light16.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light16.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Light17_EnabledChanged(object sender, EventArgs e)
        {
            if (CodeNum[18] == Codes.HU) Light17.BackgroundImage = CTCS_test.Properties.Resources.H;
            else if (CodeNum[18] == Codes.UU) Light17.BackgroundImage = CTCS_test.Properties.Resources.UU;
            else if (CodeNum[18] == Codes.U) Light17.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[18] == Codes.U2) Light17.BackgroundImage = CTCS_test.Properties.Resources.U;
            else if (CodeNum[18] == Codes.LU) Light17.BackgroundImage = CTCS_test.Properties.Resources.LU;
            else Light17.BackgroundImage = CTCS_test.Properties.Resources.L;
        }

        private void Train1_EnabledChanged(object sender, EventArgs e)
        {
            double Brake = 0;
            int i;
            if (Xp > 47 && Xp < 177) { CodeNum[0] = Codes.HU; Occupy[0] = 1; } else Occupy[0] = 0;
            if (Xp > 127 && Xp < 257) { CodeNum[1] = Codes.HU; Occupy[1] = 1; } else Occupy[1] = 0;
            if (Xp > 207 && Xp < 337) { CodeNum[2] = Codes.HU; Occupy[2] = 1; } else Occupy[2] = 0;
            if (Xp > 287 && Xp < 417) { CodeNum[3] = Codes.HU; Occupy[3] = 1; } else Occupy[3] = 0;
            if (Xp > 367 && Xp < 497) { CodeNum[4] = Codes.HU; Occupy[4] = 1; } else Occupy[4] = 0;
            if (Xp > 447 && Xp < 577) { CodeNum[5] = Codes.HU; Occupy[5] = 1; } else Occupy[5] = 0;
            if (Xp > 527 && Xp < 657) { CodeNum[6] = Codes.HU; Occupy[6] = 1; } else Occupy[6] = 0;
            if (Xp > 607 && Xp < 737) { CodeNum[7] = Codes.HU; Occupy[7] = 1; } else Occupy[7] = 0;
            if (Xp > 687 && Xp < 817) { CodeNum[8] = Codes.HU; Occupy[8] = 1; } else Occupy[8] = 0;
            if (Xp > 767 && Xp < 897) { CodeNum[9] = Codes.HU; Occupy[9] = 1; } else Occupy[9] = 0;
            if (Xp > 847 && Xp < 977) { CodeNum[10] = Codes.HU; Occupy[10] = 1; } else Occupy[10] = 0;
            if (Xp > 927 && Xp < 1057) { CodeNum[11] = Codes.HU; Occupy[11] = 1; } else Occupy[11] = 0;
            if (Xp > 1007 && Xp < 1137) { CodeNum[12] = Codes.HU; Occupy[12] = 1; } else Occupy[12] = 0;
            if (Xp > 1087 && Xp < 1217) { CodeNum[13] = Codes.HU; Occupy[13] = 1; } else Occupy[13] = 0;
            if (Xp > 1167 && Xp < 1297) { CodeNum[14] = Codes.HU; Occupy[14] = 1; } else Occupy[14] = 0;
            if (Xp > 1247 && Xp < 1377) { CodeNum[15] = Codes.HU; Occupy[15] = 1; } else Occupy[15] = 0;
            if (Xp > 1327 && Xp < 1457) { CodeNum[16] = Codes.HU; Occupy[16] = 1; } else Occupy[16] = 0;
            if (Xp > 1407 && Xp < 1537) { CodeNum[17] = Codes.HU; Occupy[17] = 1; } else Occupy[17] = 0;
            if (Xp > 1487 && Xp < 1617) { CodeNum[18] = Codes.HU; Occupy[18] = 1; } else Occupy[18] = 0;
            if (Xp > 1567 && Xp < 1697) { CodeNum[19] = Codes.HU; Occupy[19] = 1; } else Occupy[19] = 0;

            for (i = 22; i > 0; i--)
            {
                if (Occupy[i] == 1)
                {
                    if (CodeNum[i + 1] == Codes.LU) Brake = 1;
                    if ((CodeNum[i + 1] == Codes.U )||( CodeNum[i + 1] == Codes.U2 )||( CodeNum[i + 1] == Codes.UU))
                    {
                        Brake = 1;
                        if (V > 200) V = 200;
                    }
                    if (CodeNum[i + 1] == Codes.HU)
                    {
                        Brake = 1;
                        if (V > 130) V = 130;
                        if ((Xp >= 1487 || CodeNum[i + 1] != Codes.HU) && Xp <= 1645 && V<=20)
                        {
                            Brake = 0;
                            V = 20;
                        }
                    }
                    break;
                }
            }
            V -= Brake;
            if(CodeNum[i + 1] >= Codes.L && V<250) V +=1;
            if (Type[i] == Types.ZXZX || Type[i] == Types.ZXCX) side1 = false; else side1 = true;
            if (Type[i] == Types.ZXZX || Type[i] == Types.CXZX) side2 = false; else side2 = true;
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
            button3.PerformClick();
            //CodeNum[5] = Codes.LU;
            for(int i = 22; i >= 0; i--)
            {
                Type[i] = Types.ZXCX;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = (int)(20000/(V+1));
            if (timer2.Interval>1000)timer2.Interval = 1000;
            Xp++;
            if (Xp >= 1540 && Xp <= 1579 && side2) Yp-=2;
            Train1.Location = new Point(Xp, Yp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            V = 0;
            Xp = 200;
            Yp = 342;
            Train1.Location = new Point(Xp, Yp);
            button3.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if(V>0.1)timer2.Enabled = !timer2.Enabled;
            if (timer1.Enabled) button2.Text = "暂停";
            else
            {
                button2.Text = "继续";
                label1.Text = "暂停中";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CodeNum[18] = Codes.UU;
            CodeNum[17] = Codes.U2;
            CodeNum[16] = Codes.LU;
            for (int i = 15; i >= 0; i--)
            {
                if (CodeNum[i + 1] < Codes.L5)
                {
                    CodeNum[i] = CodeNum[i + 1] + 1;
                }
                else
                {
                    CodeNum[i] = Codes.L5;
                }
            }
        }
    }
}
