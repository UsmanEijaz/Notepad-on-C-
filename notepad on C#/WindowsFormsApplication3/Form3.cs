using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.button60.Enabled = false;
            this.button61.Enabled = false;
            this.button63.Enabled = false;
            this.button64.Enabled = false;
            this.button65.Enabled = false;
            this.button66.Enabled = false;
            this.button67.Enabled = false;
            this.button68.Enabled = false;
            this.button69.Enabled = false;
            this.button70.Enabled = false;
            this.button71.Enabled = false;
           
            this.checkBox2.Text = "";
            this.checkBox1.Text = "";
            this.BackColor = Color.Black;
            this.Text = "APPLICATION KEYBOARD";
            this.label1.Text = " MADE BY:USMAN EIJAZ";
            this.label1.ForeColor = Color.White;
            this.button1.Text = "`" + Environment.NewLine + "~";
            this.button2.Text = "!" + Environment.NewLine + "1";
            this.button3.Text = "@" + Environment.NewLine + "2";
            this.button4.Text = "#" + Environment.NewLine + "3";
            this.button5.Text = "$" + Environment.NewLine + "4";
            this.button6.Text = "%"+Environment.NewLine+"5";

            this.button7.Text = "^" + Environment.NewLine + "6";
            this.button8.Text = "  &&  " + Environment.NewLine + "7";

            this.button9.Text = "*" + Environment.NewLine + "8";
            this.button10.Text = "(" + Environment.NewLine + "9";
            this.button11.Text = ")" + Environment.NewLine + "0";
            this.button12.Text = "_" + Environment.NewLine + "-";
            this.button13.Text = "+" + Environment.NewLine + "=";
            this.button14.Text = "BACKSPACE";
            this.button15.Text = "TAB";
            this.button16.Text = "Q";
            this.button17.Text = "W";
            this.button18.Text = "E";
            this.button19.Text = "R";
            this.button20.Text = "T";
            this.button21.Text = "Y";
            this.button22.Text = "U";
            this.button23.Text = "I";
            this.button24.Text = "O";
            this.button25.Text = "P";
            this.button26.Text = "{" + Environment.NewLine + "[";
            this.button27.Text = "}" + Environment.NewLine + "]";
            this.button28.Text = "|" + Environment.NewLine + "/";
            this.button29.Text = "CAPSLOCK";
            this.button30.Text = "A";
            this.button31.Text = "S";
            this.button32.Text = "D";
            this.button33.Text = "F";
            this.button34.Text = "G";
            this.button35.Text = "H";
            this.button36.Text = "J";
            this.button37.Text = "K";
            this.button38.Text = "L";
            this.button39.Text = ":" + Environment.NewLine + ";";
            this.button40.Text = "''" + Environment.NewLine + "'";

            this.button42.Text = "ENTER";
            this.button43.Text = "SHIFT";
            this.button44.Text = "Z";
            this.button45.Text = "X";
            this.button46.Text = "C";
            this.button47.Text = "V";
            this.button48.Text = "B";
            this.button49.Text = "N";
            this.button50.Text = "M";
            this.button51.Text = "<" + Environment.NewLine + ",";
            this.button52.Text = ">" + Environment.NewLine + ".";
            this.button53.Text = "?" + Environment.NewLine + "/";
            this.button54.Text = "SHIFT";
            this.button55.Text = "Ctrl";
            this.button56.Text = "Alt";
            this.button57.Text = "";
            this.button58.Text = "Alt";
            this.button59.Text = "Ctrl";
            this.button60.Text = "0";
            this.button61.Text = ".";
            this.button62.Text = "ENTER";
            this.button63.Text = "1";
            this.button64.Text = "2";
            this.button65.Text = "3";
            this.button66.Text = "4";
            this.button67.Text = "5";
            this.button68.Text = "6";
            this.button69.Text = "7";
            this.button70.Text = "8";
            this.button71.Text = "9";
            this.button72.Text = "+";
            this.button73.Text = "NUMLOCK";
            this.button74.Text = "/";
            this.button75.Text = "*";
            this.button76.Text = "-";
            this.button1.BackColor = Color.Black;
            this.button1.ForeColor = Color.White;
            this.button2.BackColor = Color.Black;
            this.button2.ForeColor = Color.White;
            this.button3.BackColor = Color.Black;
            this.button3.ForeColor = Color.White;
            this.button4.BackColor = Color.Black;
            this.button4.ForeColor = Color.White;
            this.button5.BackColor = Color.Black;
            this.button5.ForeColor = Color.White;
            this.button6.BackColor = Color.Black;
            this.button6.ForeColor = Color.White;
            this.button7.BackColor = Color.Black;
            this.button7.ForeColor = Color.White;
            this.button8.BackColor = Color.Black;
            this.button8.ForeColor = Color.White;
            this.button9.BackColor = Color.Black;
            this.button9.ForeColor = Color.White;
            this.button10.BackColor = Color.Black;
            this.button10.ForeColor = Color.White;
            this.button11.BackColor = Color.Black;
            this.button11.ForeColor = Color.White;
            this.button12.BackColor = Color.Black;
            this.button12.ForeColor = Color.White;
            this.button13.BackColor = Color.Black;
            this.button13.ForeColor = Color.White;
            this.button14.BackColor = Color.Black;
            this.button14.ForeColor = Color.White;
            this.button15.BackColor = Color.Black;
            this.button15.ForeColor = Color.White;
            this.button16.BackColor = Color.Black;
            this.button16.ForeColor = Color.White;
            this.button17.BackColor = Color.Black;
            this.button17.ForeColor = Color.White;
            this.button18.BackColor = Color.Black;
            this.button18.ForeColor = Color.White;
            this.button19.BackColor = Color.Black;
            this.button19.ForeColor = Color.White;
            this.button20.BackColor = Color.Black;
            this.button20.ForeColor = Color.White;
            this.button21.BackColor = Color.Black;
            this.button21.ForeColor = Color.White;
            this.button22.BackColor = Color.Black;
            this.button22.ForeColor = Color.White;
            this.button23.BackColor = Color.Black;
            this.button23.ForeColor = Color.White;
            this.button24.BackColor = Color.Black;
            this.button24.ForeColor = Color.White;
            this.button25.BackColor = Color.Black;
            this.button25.ForeColor = Color.White;
            this.button26.BackColor = Color.Black;
            this.button26.ForeColor = Color.White;
            this.button27.BackColor = Color.Black;
            this.button27.ForeColor = Color.White;
            this.button28.BackColor = Color.Black;
            this.button28.ForeColor = Color.White;
            this.button29.BackColor = Color.Black;
            this.button29.ForeColor = Color.White;
            this.button30.BackColor = Color.Black;
            this.button30.ForeColor = Color.White;
            this.button31.BackColor = Color.Black;
            this.button31.ForeColor = Color.White;
            this.button32.BackColor = Color.Black;
            this.button32.ForeColor = Color.White;
            this.button33.BackColor = Color.Black;
            this.button33.ForeColor = Color.White;
            this.button34.BackColor = Color.Black;
            this.button34.ForeColor = Color.White;
            this.button35.BackColor = Color.Black;
            this.button35.ForeColor = Color.White;
            this.button36.BackColor = Color.Black;
            this.button36.ForeColor = Color.White;
            this.button37.BackColor = Color.Black;
            this.button37.ForeColor = Color.White;
            this.button38.BackColor = Color.Black;
            this.button38.ForeColor = Color.White;
            this.button39.BackColor = Color.Black;
            this.button39.ForeColor = Color.White;
            this.button40.BackColor = Color.Black;
            this.button40.ForeColor = Color.White;
            this.button42.BackColor = Color.Black;
            this.button42.ForeColor = Color.White;
            this.button43.BackColor = Color.Black;
            this.button43.ForeColor = Color.White;
            this.button44.BackColor = Color.Black;
            this.button44.ForeColor = Color.White;
            this.button45.BackColor = Color.Black;
            this.button45.ForeColor = Color.White;
            this.button46.BackColor = Color.Black;
            this.button46.ForeColor = Color.White;
            this.button47.BackColor = Color.Black;
            this.button47.ForeColor = Color.White;
            this.button48.BackColor = Color.Black;
            this.button48.ForeColor = Color.White;
            this.button49.BackColor = Color.Black;
            this.button49.ForeColor = Color.White;
            this.button50.BackColor = Color.Black;
            this.button50.ForeColor = Color.White;
            this.button51.BackColor = Color.Black;
            this.button51.ForeColor = Color.White;
            this.button52.BackColor = Color.Black;
            this.button52.ForeColor = Color.White;
            this.button53.BackColor = Color.Black;
            this.button53.ForeColor = Color.White;
            this.button54.BackColor = Color.Black;
            this.button54.ForeColor = Color.White;
            this.button55.BackColor = Color.Black;
            this.button55.ForeColor = Color.White;
            this.button56.BackColor = Color.Black;
            this.button56.ForeColor = Color.White;
            this.button57.BackColor = Color.Black;
            this.button57.ForeColor = Color.White;
            this.button58.BackColor = Color.Black;
            this.button58.ForeColor = Color.White;
            this.button59.BackColor = Color.Black;
            this.button59.ForeColor = Color.White;
            this.button60.BackColor = Color.Black;
            this.button60.ForeColor = Color.White;
            this.button61.BackColor = Color.Black;
            this.button61.ForeColor = Color.White;
            this.button62.BackColor = Color.Black;
            this.button62.ForeColor = Color.White;
            this.button63.BackColor = Color.Black;
            this.button63.ForeColor = Color.White;
            this.button64.BackColor = Color.Black;
            this.button64.ForeColor = Color.White;
            this.button65.BackColor = Color.Black;
            this.button65.ForeColor = Color.White;
            this.button66.BackColor = Color.Black;
            this.button66.ForeColor = Color.White;
            this.button67.BackColor = Color.Black;
            this.button67.ForeColor = Color.White;
            this.button68.BackColor = Color.Black;
            this.button68.ForeColor = Color.White;
            this.button69.BackColor = Color.Black;
            this.button69.ForeColor = Color.White;
            this.button70.BackColor = Color.Black;
            this.button70.ForeColor = Color.White;
            this.button71.BackColor = Color.Black;
            this.button71.ForeColor = Color.White;
            this.button72.BackColor = Color.Black;
            this.button72.ForeColor = Color.White;
            this.button73.BackColor = Color.Black;
            this.button73.ForeColor = Color.White;
            this.button74.BackColor = Color.Black;
            this.button74.ForeColor = Color.White;
            this.button75.BackColor = Color.Black;
            this.button75.ForeColor = Color.White;
            this.button76.BackColor = Color.Black;
            this.button76.ForeColor = Color.White;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                
                this.textBox1.Text = "~" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "`" + this.textBox1.Text; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "!" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "1" + this.textBox1.Text; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "@" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "2" + this.textBox1.Text; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "#" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "3" + this.textBox1.Text; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "$" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "4" + this.textBox1.Text; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "%" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "5" + this.textBox1.Text; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "^" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "6" + this.textBox1.Text; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "&" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "7" + this.textBox1.Text; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "*" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "8" + this.textBox1.Text; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "(" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "9" + this.textBox1.Text; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = ")" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "0" + this.textBox1.Text; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "_" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "-" + this.textBox1.Text; }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "+" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "=" + this.textBox1.Text; }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "\t" + this.textBox1.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String a;
            a = textBox1.Text;


            this.textBox1.Text = a.Remove(a.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "Q" + this.textBox1.Text; }


            else if (this.checkBox2.Checked) { this.textBox1.Text = "Q" + this.textBox1.Text; }
            else { this.textBox1.Text = "q" + this.textBox1.Text; }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "W" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "W" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "w" + this.textBox1.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "E" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "E" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "e" + this.textBox1.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "R" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "R" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "r" + this.textBox1.Text;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "T" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "T" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "t" + this.textBox1.Text;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "Y" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "Y" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "y" + this.textBox1.Text;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "U" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "U" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "u" + this.textBox1.Text;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "I" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "I" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "i" + this.textBox1.Text;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "O" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "O" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "o" + this.textBox1.Text;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "P" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "P" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "P" + this.textBox1.Text;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "{" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "[" + this.textBox1.Text; }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "}" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "]" + this.textBox1.Text; }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "|" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "'\'" + this.textBox1.Text; }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.checkBox1.Checked = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "A" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "A" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "a" + this.textBox1.Text;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "S" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "S" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "s" + this.textBox1.Text;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "D" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "D" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "d" + this.textBox1.Text;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "F" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "F" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "f" + this.textBox1.Text;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "G" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "G" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "g" + this.textBox1.Text;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "H" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "H" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "h" + this.textBox1.Text;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "J" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "J" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "j" + this.textBox1.Text;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "K" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "K" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "k" + this.textBox1.Text;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "L" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "L" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "l" + this.textBox1.Text;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = ":" + this.textBox1.Text;
            }
            else { this.textBox1.Text = ";" + this.textBox1.Text; }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "''" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "'" + this.textBox1.Text; }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Environment.NewLine + this.textBox1.Text;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.checkBox2.Checked = true;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "Z" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "Z" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "z" + this.textBox1.Text;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "X" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "X" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "x" + this.textBox1.Text;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "C" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "C" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "c" + this.textBox1.Text;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "V" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "V" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "v" + this.textBox1.Text;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "B" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "B" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "b" + this.textBox1.Text;
            }

        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "N" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "N" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "n" + this.textBox1.Text;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked) { this.textBox1.Text = "M" + this.textBox1.Text; }
            else if (this.checkBox2.Checked) { this.textBox1.Text = "M" + this.textBox1.Text; }
            else
            {
                this.textBox1.Text = "m" + this.textBox1.Text;
            }

        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "<" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "," + this.textBox1.Text; }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = ">" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "." + this.textBox1.Text; }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "?" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "/" + this.textBox1.Text; }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            this.checkBox2.Checked = true;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " " + this.textBox1.Text;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            this.checkBox3.Checked = true;
            this.button60.Enabled = true;
            this.button61.Enabled = true;
            this.button63.Enabled = true;
            this.button64.Enabled = true;
            this.button65.Enabled = true;
            this.button66.Enabled = true;
            this.button67.Enabled = true;
            this.button68.Enabled = true;
            this.button69.Enabled = true;
            this.button70.Enabled = true;
            this.button71.Enabled = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.textBox1.Text = "%" + this.textBox1.Text;
            }
            else { this.textBox1.Text = "5" + this.textBox1.Text; }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "0" + this.textBox1.Text;
            }
            
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "." + this.textBox1.Text;
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "1" + this.textBox1.Text;
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "2" + this.textBox1.Text;
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "3" + this.textBox1.Text;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "4" + this.textBox1.Text;
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "5" + this.textBox1.Text;
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "6" + this.textBox1.Text;
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "7" + this.textBox1.Text;
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "8" + this.textBox1.Text;
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.textBox1.Text = "9" + this.textBox1.Text;
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Environment.NewLine+this.textBox1.Text;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "+"  + this.textBox1.Text;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "-"  + this.textBox1.Text;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "*"  + this.textBox1.Text;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "/" + this.textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}