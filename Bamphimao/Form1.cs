using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bamphimao
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
                
            }
        }
        public Form1()
        { InitializeComponent(); }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("Q");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("q");
            }



        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("W");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("E");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("R");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("T");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("Y");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("U");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("I");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("O");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("P");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("{{}");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("[");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("{}}");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("]");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("A");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("a");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("S");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("D");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("F");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("f");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("G");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("H");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("h");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("J");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("K");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("L");
                checkBox2.Checked = false;
            }
            {
                SendKeys.Send("l");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send(":");
                checkBox2.Checked = false;
            }
            {
                SendKeys.Send(";");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("Z");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("X");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("C");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("V");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("B");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("N");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("M");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("m");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("<");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send(",");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send(">");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send(".");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("?");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("/");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("|");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("\"");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("~");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("`");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("!");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("\"");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("£");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("3");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("$");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("4");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("%");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("5");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("^");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("6");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("&");
                checkBox2.Checked = false;
            }
            {
                SendKeys.Send("7");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("*");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("8");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("(");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("9");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send(")");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("0");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                SendKeys.Send("_");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("-");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked||checkBox2.Checked)
            {
                SendKeys.Send("+");
                checkBox2.Checked = false;
            }
            else
            {
                SendKeys.Send("=");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

       

        private void button53_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{^}");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{APPSKEY}");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{%}");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }
    }

      
    }

