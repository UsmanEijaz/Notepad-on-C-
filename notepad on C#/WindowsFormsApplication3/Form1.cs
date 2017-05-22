using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.WordWrap = false;
            this.upperToolStripMenuItem.Checked = true;
            this.lowerToolStripMenuItem.Checked = true;
            //this.WindowState = FormWindowState.Maximized;
            
            this.Text = "Notepad";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordwrapToolStripMenuItem.Checked)
            {

               this.textBox1.WordWrap = true;
            }
            else { textBox1.WordWrap = false; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fn = openFileDialog1.FileName;
            string txt = File.ReadAllText(fn);
            textBox1.Text = Text;
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string us = saveFileDialog1.FileName;
            File.WriteAllText(us,textBox1.Text);
            
           
        }

        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void upperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (upperToolStripMenuItem.Checked) {

                this.textBox1.CharacterCasing = CharacterCasing.Upper;
            }

        }

        private void lowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lowerToolStripMenuItem.Checked) {

                this.textBox1.CharacterCasing = CharacterCasing.Lower;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK) {
                this.textBox1.Font = fontDialog1.Font;
                this.textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            this.textBox1.ForeColor = colorDialog1.Color;
                 }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                DialogResult dr = MessageBox.Show("Do you want to save changes to untitled", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); 
            
                saveFileDialog1.ShowDialog();
                string us = saveFileDialog1.FileName;
                File.WriteAllText( us,textBox1.Text);
            
            }
            
            
           else if (textBox1.Text == "") {

               
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fi = new Form2();
            fi.Show();
        }

        private void keyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ui = new Form3();
            ui.Show();

        }
    }
}
