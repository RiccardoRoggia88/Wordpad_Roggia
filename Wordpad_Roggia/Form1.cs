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
        private void frmWordPad_Load(object sender, EventArgs e)
        {

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
            of.Filter = "Rtf Document(*.rtf)|*.rtf|All files(*.*)|*.*";
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
            of.Filter = "Rtf Document(*.rtf)|*.rtf|All files(*.*)|*.*";
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
        int valore;
        bool elenco = true;
        private void btnElencoNumerato_Click(object sender, EventArgs e)
        {
            
            //if (elenco)
            //    elenco = false;
            //else
            //{
            //    valore = 0;
            //    elenco = true;
            //}
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (elenco)
            //{
            //    richTextBox1.BulletIndent = 20;
            //    richTextBox1.SelectionBullet = false;
            //    if (e.KeyChar == (char)Keys.Return)
            //        richTextBox1.SelectedText = valore++ + ".";
            //}
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colorDialog.Color;
                    button1.FlatAppearance.BorderColor = colorDialog.Color;
                }
            }
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked && chkItalic.Checked)
            {
                chkItalic.Checked = false;
            }
            else
            {
                if (chkItalic.Checked)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if(chkItalic.Checked && chkBold.Checked)
            {
                chkBold.Checked = false;
            }
            else
            {
                if (chkBold.Checked)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                }
                else
                {
                    //if (chkItalic.Checked)
                    //{
                    //    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
                    //}
                    //else
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
                }
            }
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked && chkStriked.Checked)
            {
                chkUnderline.Checked = false;
            }
            else
            {
                if (chkBold.Checked)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                }
                else if(chkUnderline.Checked)
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                else 
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void chkStriked_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
