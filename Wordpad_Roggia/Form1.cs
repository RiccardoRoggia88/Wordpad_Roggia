using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordpad_Roggia
{
    public partial class frmWordPad : Form
    {
        public frmWordPad()
        {
            InitializeComponent();
        }
        //1MenuTOolStrip
        private void sALVAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            salva();
        }

        private void uNDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void rIPETIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        //2MenuTooStrip
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fnt.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;
        }
        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = fnt.Color;
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apri();
        }
        
        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salva();
        }

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salva();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esci();
        }

        private void annullaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void ripristinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void tagliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void incollaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selezionatuttoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        //ChiusuraForm
        private void frmWordPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            esci();
        }
        //Metodi vari
        public void apri()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Open";
            of.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
        }
        public void esci()
        {
            if (richTextBox1.Text != "")
            {
                DialogResult ris;
                ris = MessageBox.Show("VUOI SALVARE?", "SALVATAGGIO DATI",
                                        MessageBoxButtons.YesNo);
                if (ris == DialogResult.Yes)
                    salva();
            }
        }
        public void salva()
        {
            SaveFileDialog of = new SaveFileDialog();
            of.Title = "Save";
            of.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
        }

        //PANNELLO
        private void btnIncolla_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btnTaglia_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void btnAlignLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnAlignCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnAlineRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnElencoPuntato_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void btnElencoNumerato_Click(object sender, EventArgs e)
        {
            
        }
    }
}
