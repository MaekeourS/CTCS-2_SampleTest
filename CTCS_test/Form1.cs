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
        double V = 0;
        int Xp = 200;
        int Yp = 343;
        bool side1 = false, side2 = false;
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
           
                if (Type[i] == Types.ZXZX || Type[i] == Types.CXZX || Occupy[Temp] == -1) 
                    CodeNum[i] = ZXFM[j];
                else CodeNum[i] = CXFM[j]; 
            }
            if (Type[2] == Types.CXZX || Type[2] == Types.CXCX)
            {
                for (int i = 2;i>= 0; i--)
                {
                    CodeNum[i] = Codes.UU;
                }
            }
            Train1Moving();
            Code1Switch();
            Code2Switch();
            Code3Switch();
            Code4Switch();
            Code5Switch();
            Code6Switch();
            Code7Switch();
            Code8Switch();
            Code9Switch();
            Code10Switch();
            Code11Switch();
            Code12Switch();
            Code13Switch();
            Code14Switch();
            Code15Switch();
            Code16Switch();
            Code17Switch();
            Code18Switch();
            Code19Switch();
            Code20Switch();
            Code21Switch();
            Code22Switch();
            Code23Switch();
            Light1Switch();
            Light2Switch();
            Light3Switch();
            Light4Switch();
            Light5Switch();
            Light6Switch();
            Light7Switch();
            Light8Switch();
            Light9Switch();
            Light10Switch();
            Light11Switch();
            Light12Switch();
            Light13Switch();
            Light14Switch();
            Light15Switch();
            Light16Switch();
            Light17Switch();
            Light18Switch();
            Light19Switch();
            listBox1.TopIndex = listBox1.Items.Count - 1;
            label1.Text = "Speed:"+V.ToString()+"km/h";
        }

        private void Code1Switch()
        {
            if (CodeNum[0] == Codes.HU) Code1.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[0] == Codes.UU) Code1.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[0] == Codes.U) Code1.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[0] == Codes.U2) Code1.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[0] == Codes.LU) Code1.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[0] == Codes.L) Code1.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[0] == Codes.L2) Code1.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[0] == Codes.L3) Code1.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[0] == Codes.L4) Code1.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[0] == Codes.L5) Code1.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code2Switch()
        {
            if (CodeNum[1] == Codes.HU) Code2.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[1] == Codes.UU) Code2.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[1] == Codes.U) Code2.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[1] == Codes.U2) Code2.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[1] == Codes.LU) Code2.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[1] == Codes.L) Code2.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[1] == Codes.L2) Code2.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[1] == Codes.L3) Code2.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[1] == Codes.L4) Code2.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[1] == Codes.L5) Code2.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code3Switch()
        {
            if (CodeNum[2] == Codes.HU) Code3.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[2] == Codes.UU) Code3.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[2] == Codes.U) Code3.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[2] == Codes.U2) Code3.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[2] == Codes.LU) Code3.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[2] == Codes.L) Code3.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[2] == Codes.L2) Code3.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[2] == Codes.L3) Code3.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[2] == Codes.L4) Code3.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[2] == Codes.L5) Code3.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code4Switch()
        {
            if (CodeNum[3] == Codes.HU) Code4.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[3] == Codes.UU) Code4.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[3] == Codes.U) Code4.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[3] == Codes.U2) Code4.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[3] == Codes.LU) Code4.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[3] == Codes.L) Code4.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[3] == Codes.L2) Code4.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[3] == Codes.L3) Code4.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[3] == Codes.L4) Code4.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[3] == Codes.L5) Code4.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code5Switch()
        {
            if (CodeNum[4] == Codes.HU) Code5.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[4] == Codes.UU) Code5.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[4] == Codes.U) Code5.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[4] == Codes.U2) Code5.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[4] == Codes.LU) Code5.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[4] == Codes.L) Code5.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[4] == Codes.L2) Code5.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[4] == Codes.L3) Code5.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[4] == Codes.L4) Code5.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[4] == Codes.L5) Code5.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code6Switch()
        {
            if (CodeNum[5] == Codes.HU) Code6.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[5] == Codes.UU) Code6.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[5] == Codes.U) Code6.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[5] == Codes.U2) Code6.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[5] == Codes.LU) Code6.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[5] == Codes.L) Code6.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[5] == Codes.L2) Code6.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[5] == Codes.L3) Code6.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[5] == Codes.L4) Code6.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[5] == Codes.L5) Code6.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code7Switch()
        {
            if (CodeNum[6] == Codes.HU) Code7.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[6] == Codes.UU) Code7.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[6] == Codes.U) Code7.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[6] == Codes.U2) Code7.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[6] == Codes.LU) Code7.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[6] == Codes.L) Code7.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[6] == Codes.L2) Code7.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[6] == Codes.L3) Code7.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[6] == Codes.L4) Code7.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[6] == Codes.L5) Code7.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code8Switch()
        {
            if (CodeNum[7] == Codes.HU) Code8.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[7] == Codes.UU) Code8.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[7] == Codes.U) Code8.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[7] == Codes.U2) Code8.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[7] == Codes.LU) Code8.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[7] == Codes.L) Code8.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[7] == Codes.L2) Code8.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[7] == Codes.L3) Code8.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[7] == Codes.L4) Code8.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[7] == Codes.L5) Code8.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code9Switch()
        {
            if (CodeNum[8] == Codes.HU) Code9.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[8] == Codes.UU) Code9.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[8] == Codes.U) Code9.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[8] == Codes.U2) Code9.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[8] == Codes.LU) Code9.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[8] == Codes.L) Code9.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[8] == Codes.L2) Code9.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[8] == Codes.L3) Code9.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[8] == Codes.L4) Code9.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[8] == Codes.L5) Code9.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code10Switch()
        {
            if (CodeNum[9] == Codes.HU) Code10.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[9] == Codes.UU) Code10.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[9] == Codes.U) Code10.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[9] == Codes.U2) Code10.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[9] == Codes.LU) Code10.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[9] == Codes.L) Code10.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[9] == Codes.L2) Code10.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[9] == Codes.L3) Code10.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[9] == Codes.L4) Code10.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[9] == Codes.L5) Code10.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code11Switch()
        {
            if (CodeNum[10] == Codes.HU) Code11.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[10] == Codes.UU) Code11.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[10] == Codes.U) Code11.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[10] == Codes.U2) Code11.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[10] == Codes.LU) Code11.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[10] == Codes.L) Code11.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[10] == Codes.L2) Code11.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[10] == Codes.L3) Code11.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[10] == Codes.L4) Code11.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[10] == Codes.L5) Code11.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code12Switch()
        {
            if (CodeNum[11] == Codes.HU) Code12.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[11] == Codes.UU) Code12.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[11] == Codes.U) Code12.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[11] == Codes.U2) Code12.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[11] == Codes.LU) Code12.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[11] == Codes.L) Code12.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[11] == Codes.L2) Code12.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[11] == Codes.L3) Code12.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[11] == Codes.L4) Code12.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[11] == Codes.L5) Code12.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code13Switch()
        {
            if (CodeNum[12] == Codes.HU) Code13.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[12] == Codes.UU) Code13.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[12] == Codes.U) Code13.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[12] == Codes.U2) Code13.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[12] == Codes.LU) Code13.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[12] == Codes.L) Code13.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[12] == Codes.L2) Code13.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[12] == Codes.L3) Code13.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[12] == Codes.L4) Code13.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[12] == Codes.L5) Code13.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code14Switch()
        {
            if (CodeNum[13] == Codes.HU) Code14.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[13] == Codes.UU) Code14.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[13] == Codes.U) Code14.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[13] == Codes.U2) Code14.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[13] == Codes.LU) Code14.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[13] == Codes.L) Code14.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[13] == Codes.L2) Code14.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[13] == Codes.L3) Code14.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[13] == Codes.L4) Code14.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[13] == Codes.L5) Code14.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code15Switch()
        {
            if (CodeNum[14] == Codes.HU) Code15.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[14] == Codes.UU) Code15.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[14] == Codes.U) Code15.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[14] == Codes.U2) Code15.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[14] == Codes.LU) Code15.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[14] == Codes.L) Code15.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[14] == Codes.L2) Code15.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[14] == Codes.L3) Code15.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[14] == Codes.L4) Code15.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[14] == Codes.L5) Code15.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code16Switch()
        {
            if (CodeNum[15] == Codes.HU) Code16.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[15] == Codes.UU) Code16.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[15] == Codes.U) Code16.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[15] == Codes.U2) Code16.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[15] == Codes.LU) Code16.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[15] == Codes.L) Code16.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[15] == Codes.L2) Code16.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[15] == Codes.L3) Code16.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[15] == Codes.L4) Code16.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[15] == Codes.L5) Code16.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code17Switch()
        {
            if (CodeNum[16] == Codes.HU) Code17.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[16] == Codes.UU) Code17.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[16] == Codes.U) Code17.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[16] == Codes.U2) Code17.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[16] == Codes.LU) Code17.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[16] == Codes.L) Code17.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[16] == Codes.L2) Code17.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[16] == Codes.L3) Code17.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[16] == Codes.L4) Code17.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[16] == Codes.L5) Code17.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code18Switch()
        {
            if (CodeNum[17] == Codes.HU) Code18.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[17] == Codes.UU) Code18.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[17] == Codes.U) Code18.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[17] == Codes.U2) Code18.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[17] == Codes.LU) Code18.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[17] == Codes.L) Code18.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[17] == Codes.L2) Code18.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[17] == Codes.L3) Code18.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[17] == Codes.L4) Code18.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[17] == Codes.L5) Code18.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code19Switch()
        {
            if (CodeNum[18] == Codes.HU) Code19.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[18] == Codes.UU) Code19.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[18] == Codes.U) Code19.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[18] == Codes.U2) Code19.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[18] == Codes.LU) Code19.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[18] == Codes.L) Code19.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[18] == Codes.L2) Code19.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[18] == Codes.L3) Code19.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[18] == Codes.L4) Code19.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[18] == Codes.L5) Code19.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code20Switch()
        {
            if (CodeNum[19] == Codes.HU) Code20.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[19] == Codes.UU) Code20.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[19] == Codes.U) Code20.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[19] == Codes.U2) Code20.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[19] == Codes.LU) Code20.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[19] == Codes.L) Code20.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[19] == Codes.L2) Code20.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[19] == Codes.L3) Code20.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[19] == Codes.L4) Code20.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[19] == Codes.L5) Code20.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code21Switch()
        {
            if (CodeNum[20] == Codes.HU) Code21.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[20] == Codes.UU) Code21.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[20] == Codes.U) Code21.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[20] == Codes.U2) Code21.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[20] == Codes.LU) Code21.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[20] == Codes.L) Code21.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[20] == Codes.L2) Code21.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[20] == Codes.L3) Code21.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[20] == Codes.L4) Code21.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[20] == Codes.L5) Code21.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code22Switch()
        {
            if (CodeNum[21] == Codes.HU) Code22.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[21] == Codes.UU) Code22.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[21] == Codes.U) Code22.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[21] == Codes.U2) Code22.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[21] == Codes.LU) Code22.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[21] == Codes.L) Code22.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[21] == Codes.L2) Code22.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[21] == Codes.L3) Code22.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[21] == Codes.L4) Code22.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[21] == Codes.L5) Code22.BackgroundImage = Properties.Resources.L5code;
        }

        private void Code23Switch()
        {
            if (CodeNum[22] == Codes.HU) Code23.BackgroundImage = Properties.Resources.HUcode;
            if (CodeNum[22] == Codes.UU) Code23.BackgroundImage = Properties.Resources.UUcode;
            if (CodeNum[22] == Codes.U) Code23.BackgroundImage = Properties.Resources.Ucode;
            if (CodeNum[22] == Codes.U2) Code23.BackgroundImage = Properties.Resources.U2code;
            if (CodeNum[22] == Codes.LU) Code23.BackgroundImage = Properties.Resources.LUcode;
            if (CodeNum[22] == Codes.L) Code23.BackgroundImage = Properties.Resources.Lcode;
            if (CodeNum[22] == Codes.L2) Code23.BackgroundImage = Properties.Resources.L2code;
            if (CodeNum[22] == Codes.L3) Code23.BackgroundImage = Properties.Resources.L3code;
            if (CodeNum[22] == Codes.L4) Code23.BackgroundImage = Properties.Resources.L4code;
            if (CodeNum[22] == Codes.L5) Code23.BackgroundImage = Properties.Resources.L5code;
        }

        private void Light1Switch()
        {
            if (CodeNum[2] == Codes.HU) Light1.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[2] == Codes.UU) Light1.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[2] == Codes.U) Light1.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[2] == Codes.U2) Light1.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[2] == Codes.LU) Light1.BackgroundImage = Properties.Resources.LU;
            else Light1.BackgroundImage = Properties.Resources.L;
        }

        private void Light2Switch()
        {
            if (CodeNum[2] == Codes.HU) Light2.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[2] == Codes.UU) Light2.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[2] == Codes.U) Light2.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[2] == Codes.U2) Light2.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[2] == Codes.LU) Light2.BackgroundImage = Properties.Resources.LU;
            else Light2.BackgroundImage = Properties.Resources.L;
        }

        private void Light3Switch()
        {
            if (CodeNum[4] == Codes.HU) Light3.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[4] == Codes.UU) Light3.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[4] == Codes.U) Light3.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[4] == Codes.U2) Light3.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[4] == Codes.LU) Light3.BackgroundImage = Properties.Resources.LU;
            else Light3.BackgroundImage = Properties.Resources.L;

        }

        private void Light4Switch()
        {
            if (CodeNum[5] == Codes.HU) Light4.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[5] == Codes.UU) Light4.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[5] == Codes.U) Light4.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[5] == Codes.U2) Light4.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[5] == Codes.LU) Light4.BackgroundImage = Properties.Resources.LU;
            else Light4.BackgroundImage = Properties.Resources.L;
        }

        private void Light5Switch()
        {
            if (CodeNum[6] == Codes.HU) Light5.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[6] == Codes.UU) Light5.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[6] == Codes.U) Light5.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[6] == Codes.U2) Light5.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[6] == Codes.LU) Light5.BackgroundImage = Properties.Resources.LU;
            else Light5.BackgroundImage = Properties.Resources.L;
        }

        private void Light6Switch()
        {
            if (CodeNum[7] == Codes.HU) Light6.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[7] == Codes.UU) Light6.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[7] == Codes.U) Light6.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[7] == Codes.U2) Light6.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[7] == Codes.LU) Light6.BackgroundImage = Properties.Resources.LU;
            else Light6.BackgroundImage = Properties.Resources.L;
        }

        private void Light7Switch()
        {
            if (CodeNum[8] == Codes.HU) Light7.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[8] == Codes.UU) Light7.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[8] == Codes.U) Light7.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[8] == Codes.U2) Light7.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[8] == Codes.LU) Light7.BackgroundImage = Properties.Resources.LU;
            else Light7.BackgroundImage = Properties.Resources.L;
        }

        private void Light8Switch()
        {
            if (CodeNum[9] == Codes.HU) Light8.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[9] == Codes.UU) Light8.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[9] == Codes.U) Light8.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[9] == Codes.U2) Light8.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[9] == Codes.LU) Light8.BackgroundImage = Properties.Resources.LU;
            else Light8.BackgroundImage = Properties.Resources.L;
        }

        private void Light9Switch()
        {
            if (CodeNum[10] == Codes.HU) Light9.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[10] == Codes.UU) Light9.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[10] == Codes.U) Light9.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[10] == Codes.U2) Light9.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[10] == Codes.LU) Light9.BackgroundImage = Properties.Resources.LU;
            else Light9.BackgroundImage = Properties.Resources.L;
        }

        private void Light10Switch()
        {
            if (CodeNum[11] == Codes.HU) Light10.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[11] == Codes.UU) Light10.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[11] == Codes.U) Light10.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[11] == Codes.U2) Light10.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[11] == Codes.LU) Light10.BackgroundImage = Properties.Resources.LU;
            else Light10.BackgroundImage = Properties.Resources.L;
        }

        private void Light11Switch()
        {
            if (CodeNum[12] == Codes.HU) Light11.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[12] == Codes.UU) Light11.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[12] == Codes.U) Light11.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[12] == Codes.U2) Light11.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[12] == Codes.LU) Light11.BackgroundImage = Properties.Resources.LU;
            else Light11.BackgroundImage = Properties.Resources.L;
        }

        private void Light12Switch()
        {
            if (CodeNum[13] == Codes.HU) Light12.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[13] == Codes.UU) Light12.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[13] == Codes.U) Light12.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[13] == Codes.U2) Light12.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[13] == Codes.LU) Light12.BackgroundImage = Properties.Resources.LU;
            else Light12.BackgroundImage = Properties.Resources.L;
        }

        private void Light13Switch()
        {
            if (CodeNum[14] == Codes.HU) Light13.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[14] == Codes.UU) Light13.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[14] == Codes.U) Light13.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[14] == Codes.U2) Light13.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[14] == Codes.LU) Light13.BackgroundImage = Properties.Resources.LU;
            else Light13.BackgroundImage = Properties.Resources.L;
        }

        private void Light14Switch()
        {
            if (CodeNum[15] == Codes.HU) Light14.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[15] == Codes.UU) Light14.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[15] == Codes.U) Light14.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[15] == Codes.U2) Light14.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[15] == Codes.LU) Light14.BackgroundImage = Properties.Resources.LU;
            else Light14.BackgroundImage = Properties.Resources.L;
        }

        private void Light15Switch()
        {
            if (CodeNum[16] == Codes.HU) Light15.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[16] == Codes.UU) Light15.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[16] == Codes.U) Light15.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[16] == Codes.U2) Light15.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[16] == Codes.LU) Light15.BackgroundImage = Properties.Resources.LU;
            else Light15.BackgroundImage = Properties.Resources.L;
        }

        private void Light16Switch()
        {
            if (CodeNum[17] == Codes.HU) Light16.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[17] == Codes.UU) Light16.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[17] == Codes.U) Light16.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[17] == Codes.U2) Light16.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[17] == Codes.LU) Light16.BackgroundImage = Properties.Resources.LU;
            else Light16.BackgroundImage = Properties.Resources.L;
        }

        private void Light17Switch()
        {
            if (CodeNum[18] == Codes.HU) Light17.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[18] == Codes.UU) Light17.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[18] == Codes.U) Light17.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[18] == Codes.U2) Light17.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[18] == Codes.LU) Light17.BackgroundImage = Properties.Resources.LU;
            else Light17.BackgroundImage = Properties.Resources.L;
        }

        private void Light18Switch()
        {
            if (CodeNum[21] == Codes.HU) Light18.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[21] == Codes.UU) Light18.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[21] == Codes.U) Light18.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[21] == Codes.U2) Light18.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[21] == Codes.LU) Light18.BackgroundImage = Properties.Resources.LU;
            else Light18.BackgroundImage = Properties.Resources.L;
        }

        private void Light19Switch()
        {
            if (CodeNum[21] == Codes.HU) Light19.BackgroundImage = Properties.Resources.H;
            else if (CodeNum[21] == Codes.UU) Light19.BackgroundImage = Properties.Resources.UU;
            else if (CodeNum[21] == Codes.U) Light19.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[21] == Codes.U2) Light19.BackgroundImage = Properties.Resources.U;
            else if (CodeNum[21] == Codes.LU) Light19.BackgroundImage = Properties.Resources.LU;
            else Light19.BackgroundImage = Properties.Resources.L;
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
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("未选择接发车模式", "错误！");
            }
            else
            {
                if(button1.Text == "发车")
                {
                    button2.Enabled = true;
                    button1.Text = "重新发车";
                }
                button3.PerformClick();
                button4.PerformClick();
                for (int i = 22; i >= 0; i--)
                {
                    if (radioButton1.Checked) Type[i] = Types.ZXZX;
                    else if (radioButton2.Checked) Type[i] = Types.CXZX;
                    else if (radioButton3.Checked) Type[i] = Types.ZXCX;
                    else Type[i] = Types.CXCX;
                }
                V = 0;
                Xp = 200;
                if (Type[2] == Types.ZXZX || Type[2] == Types.ZXCX) Yp = 343;
                else Yp = 262;
                Train1.Location = new Point(Xp, Yp);
                timer1.Enabled = true;
                timer2.Enabled = true;
                button2.Text = "暂停";
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
            for (int i = 22; i >= 0; i--) Type[i] = Types.ZXZX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CodeNum[18] = Codes.U;
            CodeNum[17] = Codes.LU;
            //CodeNum[16] = Codes.LU;
            for (int i = 16; i >= 0; i--)
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

        private void radioButton2_Click(object sender, EventArgs e)
        {
            for (int i = 22; i >= 0; i--) Type[i] = Types.CXZX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CodeNum[18] = Codes.U;
            CodeNum[17] = Codes.LU;
            //CodeNum[16] = Codes.LU;
            for (int i = 16; i >= 3; i--)
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
            CodeNum[2] = Codes.UU;
            CodeNum[1] = Codes.UU;
            CodeNum[0] = Codes.UU;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            for (int i = 22; i >= 0; i--) Type[i] = Types.ZXCX;
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

        private void radioButton4_Click(object sender, EventArgs e)
        {
            for (int i = 22; i >= 0; i--) Type[i] = Types.CXCX;
            CodeNum[22] = Codes.HU;
            CodeNum[21] = Codes.HU;
            CodeNum[20] = Codes.HU;
            CodeNum[19] = Codes.HU;
            CodeNum[18] = Codes.UU;
            CodeNum[17] = Codes.U2;
            CodeNum[16] = Codes.LU;
            for (int i = 15; i >= 3; i--)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) radioButton1.PerformClick();
            if (radioButton2.Checked) radioButton2.PerformClick();
            if (radioButton3.Checked) radioButton3.PerformClick();
            if (radioButton4.Checked) radioButton4.PerformClick();
        }
    }
}
