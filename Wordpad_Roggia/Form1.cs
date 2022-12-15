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

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Open";
            of.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog of = new SaveFileDialog();
            of.Title = "Save";
            of.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
        }

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog of = new SaveFileDialog();
            of.Title = "Save";
            of.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
