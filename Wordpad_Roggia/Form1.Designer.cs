namespace Wordpad_Roggia
{
    partial class frmWordPad
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWordPad));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRoggia = new System.Windows.Forms.Panel();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnMarkedText = new System.Windows.Forms.Button();
            this.btnDataOra = new System.Windows.Forms.Button();
            this.btnSelezionaTutto = new System.Windows.Forms.Button();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkStriked = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.btnColorText = new System.Windows.Forms.Button();
            this.btnElencoNumerato = new System.Windows.Forms.Button();
            this.btnElencoPuntato = new System.Windows.Forms.Button();
            this.btnAlignLeft = new System.Windows.Forms.Button();
            this.btnAlignCenter = new System.Windows.Forms.Button();
            this.btnAlineRight = new System.Windows.Forms.Button();
            this.btnCopia = new System.Windows.Forms.Button();
            this.btnTaglia = new System.Windows.Forms.Button();
            this.btnIncolla = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaconnomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteprimadistampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annullaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ripristinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tagliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incollaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selezionatuttoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sALVAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.uNDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.rIPETIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.pnlRoggia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 134);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(860, 363);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.modificaToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMGToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(860, 28);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // pnlRoggia
            // 
            this.pnlRoggia.Controls.Add(this.btnZoomOut);
            this.pnlRoggia.Controls.Add(this.btnZoomIn);
            this.pnlRoggia.Controls.Add(this.btnMarkedText);
            this.pnlRoggia.Controls.Add(this.btnDataOra);
            this.pnlRoggia.Controls.Add(this.btnSelezionaTutto);
            this.pnlRoggia.Controls.Add(this.chkBold);
            this.pnlRoggia.Controls.Add(this.chkStriked);
            this.pnlRoggia.Controls.Add(this.chkUnderline);
            this.pnlRoggia.Controls.Add(this.chkItalic);
            this.pnlRoggia.Controls.Add(this.btnColorText);
            this.pnlRoggia.Controls.Add(this.btnElencoNumerato);
            this.pnlRoggia.Controls.Add(this.btnElencoPuntato);
            this.pnlRoggia.Controls.Add(this.btnAlignLeft);
            this.pnlRoggia.Controls.Add(this.btnAlignCenter);
            this.pnlRoggia.Controls.Add(this.btnAlineRight);
            this.pnlRoggia.Controls.Add(this.btnCopia);
            this.pnlRoggia.Controls.Add(this.btnTaglia);
            this.pnlRoggia.Controls.Add(this.btnIncolla);
            this.pnlRoggia.Location = new System.Drawing.Point(0, 55);
            this.pnlRoggia.Name = "pnlRoggia";
            this.pnlRoggia.Size = new System.Drawing.Size(860, 79);
            this.pnlRoggia.TabIndex = 5;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = global::Wordpad_Roggia.Properties.Resources.zoomOut16x;
            this.btnZoomOut.Location = new System.Drawing.Point(351, 12);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(27, 24);
            this.btnZoomOut.TabIndex = 17;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = global::Wordpad_Roggia.Properties.Resources.zoomIn16px;
            this.btnZoomIn.Location = new System.Drawing.Point(325, 11);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(25, 24);
            this.btnZoomIn.TabIndex = 16;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnMarkedText
            // 
            this.btnMarkedText.Image = global::Wordpad_Roggia.Properties.Resources.marker16x;
            this.btnMarkedText.Location = new System.Drawing.Point(302, 10);
            this.btnMarkedText.Name = "btnMarkedText";
            this.btnMarkedText.Size = new System.Drawing.Size(22, 24);
            this.btnMarkedText.TabIndex = 15;
            this.btnMarkedText.UseVisualStyleBackColor = true;
            this.btnMarkedText.Click += new System.EventHandler(this.btnMarkedText_Click);
            // 
            // btnDataOra
            // 
            this.btnDataOra.Image = global::Wordpad_Roggia.Properties.Resources.DateTimePicker_16x;
            this.btnDataOra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataOra.Location = new System.Drawing.Point(580, 23);
            this.btnDataOra.Name = "btnDataOra";
            this.btnDataOra.Size = new System.Drawing.Size(97, 36);
            this.btnDataOra.TabIndex = 14;
            this.btnDataOra.Text = "DATA E ORA";
            this.btnDataOra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDataOra.UseVisualStyleBackColor = true;
            this.btnDataOra.Click += new System.EventHandler(this.btnDataOra_Click);
            // 
            // btnSelezionaTutto
            // 
            this.btnSelezionaTutto.Image = global::Wordpad_Roggia.Properties.Resources.SelectAll_16x;
            this.btnSelezionaTutto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelezionaTutto.Location = new System.Drawing.Point(450, 23);
            this.btnSelezionaTutto.Name = "btnSelezionaTutto";
            this.btnSelezionaTutto.Size = new System.Drawing.Size(124, 35);
            this.btnSelezionaTutto.TabIndex = 6;
            this.btnSelezionaTutto.Text = "SELEZIONA TUTTO";
            this.btnSelezionaTutto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelezionaTutto.UseVisualStyleBackColor = true;
            this.btnSelezionaTutto.Click += new System.EventHandler(this.btnSelezionaTutto_Click);
            // 
            // chkBold
            // 
            this.chkBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBold.AutoSize = true;
            this.chkBold.Image = global::Wordpad_Roggia.Properties.Resources.Bold_16x;
            this.chkBold.Location = new System.Drawing.Point(281, 40);
            this.chkBold.Margin = new System.Windows.Forms.Padding(2);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(22, 22);
            this.chkBold.TabIndex = 13;
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkStriked
            // 
            this.chkStriked.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStriked.AutoSize = true;
            this.chkStriked.Image = global::Wordpad_Roggia.Properties.Resources.StrikeThrough_16x;
            this.chkStriked.Location = new System.Drawing.Point(328, 40);
            this.chkStriked.Margin = new System.Windows.Forms.Padding(2);
            this.chkStriked.Name = "chkStriked";
            this.chkStriked.Size = new System.Drawing.Size(22, 22);
            this.chkStriked.TabIndex = 12;
            this.chkStriked.UseVisualStyleBackColor = true;
            this.chkStriked.CheckedChanged += new System.EventHandler(this.chkStriked_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Image = global::Wordpad_Roggia.Properties.Resources.Underline_16x1;
            this.chkUnderline.Location = new System.Drawing.Point(351, 40);
            this.chkUnderline.Margin = new System.Windows.Forms.Padding(2);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(22, 22);
            this.chkUnderline.TabIndex = 11;
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkItalic.AutoSize = true;
            this.chkItalic.Image = global::Wordpad_Roggia.Properties.Resources.Italic_16x;
            this.chkItalic.Location = new System.Drawing.Point(302, 40);
            this.chkItalic.Margin = new System.Windows.Forms.Padding(2);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(22, 22);
            this.chkItalic.TabIndex = 10;
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // btnColorText
            // 
            this.btnColorText.Image = global::Wordpad_Roggia.Properties.Resources.ColorPicker_16x;
            this.btnColorText.Location = new System.Drawing.Point(281, 10);
            this.btnColorText.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorText.Name = "btnColorText";
            this.btnColorText.Size = new System.Drawing.Size(22, 24);
            this.btnColorText.TabIndex = 9;
            this.btnColorText.UseVisualStyleBackColor = true;
            this.btnColorText.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElencoNumerato
            // 
            this.btnElencoNumerato.Image = global::Wordpad_Roggia.Properties.Resources.ElencoNumerato16x;
            this.btnElencoNumerato.Location = new System.Drawing.Point(191, 11);
            this.btnElencoNumerato.Name = "btnElencoNumerato";
            this.btnElencoNumerato.Size = new System.Drawing.Size(25, 23);
            this.btnElencoNumerato.TabIndex = 7;
            this.btnElencoNumerato.UseVisualStyleBackColor = true;
            this.btnElencoNumerato.Click += new System.EventHandler(this.btnElencoNumerato_Click);
            // 
            // btnElencoPuntato
            // 
            this.btnElencoPuntato.Image = global::Wordpad_Roggia.Properties.Resources.ElencoPuntato16x;
            this.btnElencoPuntato.Location = new System.Drawing.Point(161, 11);
            this.btnElencoPuntato.Name = "btnElencoPuntato";
            this.btnElencoPuntato.Size = new System.Drawing.Size(24, 23);
            this.btnElencoPuntato.TabIndex = 6;
            this.btnElencoPuntato.UseVisualStyleBackColor = true;
            this.btnElencoPuntato.Click += new System.EventHandler(this.btnElencoPuntato_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.Image = global::Wordpad_Roggia.Properties.Resources.TextLeftJustify_16x;
            this.btnAlignLeft.Location = new System.Drawing.Point(160, 40);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(23, 23);
            this.btnAlignLeft.TabIndex = 5;
            this.btnAlignLeft.UseVisualStyleBackColor = true;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.Image = global::Wordpad_Roggia.Properties.Resources.TextCenter_16x;
            this.btnAlignCenter.Location = new System.Drawing.Point(191, 40);
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(27, 23);
            this.btnAlignCenter.TabIndex = 4;
            this.btnAlignCenter.UseVisualStyleBackColor = true;
            this.btnAlignCenter.Click += new System.EventHandler(this.btnAlignCenter_Click);
            // 
            // btnAlineRight
            // 
            this.btnAlineRight.Image = global::Wordpad_Roggia.Properties.Resources.TextRightJustify_16x;
            this.btnAlineRight.Location = new System.Drawing.Point(224, 40);
            this.btnAlineRight.Name = "btnAlineRight";
            this.btnAlineRight.Size = new System.Drawing.Size(25, 23);
            this.btnAlineRight.TabIndex = 3;
            this.btnAlineRight.UseVisualStyleBackColor = true;
            this.btnAlineRight.Click += new System.EventHandler(this.btnAlineRight_Click);
            // 
            // btnCopia
            // 
            this.btnCopia.Image = global::Wordpad_Roggia.Properties.Resources.Copy_16x;
            this.btnCopia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopia.Location = new System.Drawing.Point(76, 40);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(60, 23);
            this.btnCopia.TabIndex = 2;
            this.btnCopia.Text = "Copia";
            this.btnCopia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // btnTaglia
            // 
            this.btnTaglia.Image = global::Wordpad_Roggia.Properties.Resources.Cut_16x;
            this.btnTaglia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaglia.Location = new System.Drawing.Point(76, 11);
            this.btnTaglia.Name = "btnTaglia";
            this.btnTaglia.Size = new System.Drawing.Size(60, 23);
            this.btnTaglia.TabIndex = 1;
            this.btnTaglia.Text = "Taglia";
            this.btnTaglia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaglia.UseVisualStyleBackColor = true;
            this.btnTaglia.Click += new System.EventHandler(this.btnTaglia_Click);
            // 
            // btnIncolla
            // 
            this.btnIncolla.Image = global::Wordpad_Roggia.Properties.Resources.ASX_Paste_blue_32x;
            this.btnIncolla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncolla.Location = new System.Drawing.Point(15, 11);
            this.btnIncolla.Name = "btnIncolla";
            this.btnIncolla.Size = new System.Drawing.Size(55, 62);
            this.btnIncolla.TabIndex = 0;
            this.btnIncolla.Tag = "Incolla";
            this.btnIncolla.Text = "Incolla";
            this.btnIncolla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncolla.UseVisualStyleBackColor = true;
            this.btnIncolla.Click += new System.EventHandler(this.btnIncolla_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.AccessibleDescription = "";
            this.fileToolStripMenuItem1.AccessibleName = "FILE";
            this.fileToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.toolStripSeparator,
            this.salvaToolStripMenuItem,
            this.salvaconnomeToolStripMenuItem,
            this.toolStripSeparator1,
            this.stampaToolStripMenuItem,
            this.anteprimadistampaToolStripMenuItem,
            this.toolStripSeparator2,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem1.Image = global::Wordpad_Roggia.Properties.Resources.FileHead_16x;
            this.fileToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripMenuItem.Image")));
            this.nuovoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nuovoToolStripMenuItem.Text = "&Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripMenuItem.Image")));
            this.apriToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.apriToolStripMenuItem.Text = "&Apri";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(182, 6);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripMenuItem.Image")));
            this.salvaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.salvaToolStripMenuItem.Text = "&Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // salvaconnomeToolStripMenuItem
            // 
            this.salvaconnomeToolStripMenuItem.Name = "salvaconnomeToolStripMenuItem";
            this.salvaconnomeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.salvaconnomeToolStripMenuItem.Text = "Salva &con nome";
            this.salvaconnomeToolStripMenuItem.Click += new System.EventHandler(this.salvaconnomeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stampaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stampaToolStripMenuItem.Image")));
            this.stampaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.stampaToolStripMenuItem.Text = "&Stampa";
            // 
            // anteprimadistampaToolStripMenuItem
            // 
            this.anteprimadistampaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anteprimadistampaToolStripMenuItem.Image")));
            this.anteprimadistampaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anteprimadistampaToolStripMenuItem.Name = "anteprimadistampaToolStripMenuItem";
            this.anteprimadistampaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.anteprimadistampaToolStripMenuItem.Text = "&Anteprima di stampa";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annullaToolStripMenuItem,
            this.ripristinaToolStripMenuItem,
            this.toolStripSeparator3,
            this.tagliaToolStripMenuItem,
            this.copiaToolStripMenuItem,
            this.incollaToolStripMenuItem,
            this.toolStripSeparator4,
            this.selezionatuttoToolStripMenuItem});
            this.modificaToolStripMenuItem.Image = global::Wordpad_Roggia.Properties.Resources.Edit_grey_16x;
            this.modificaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.modificaToolStripMenuItem.Text = "&Edit";
            // 
            // annullaToolStripMenuItem
            // 
            this.annullaToolStripMenuItem.Name = "annullaToolStripMenuItem";
            this.annullaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annullaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.annullaToolStripMenuItem.Text = "&Annulla";
            this.annullaToolStripMenuItem.Click += new System.EventHandler(this.annullaToolStripMenuItem_Click);
            // 
            // ripristinaToolStripMenuItem
            // 
            this.ripristinaToolStripMenuItem.Name = "ripristinaToolStripMenuItem";
            this.ripristinaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ripristinaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ripristinaToolStripMenuItem.Text = "&Ripristina";
            this.ripristinaToolStripMenuItem.Click += new System.EventHandler(this.ripristinaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // tagliaToolStripMenuItem
            // 
            this.tagliaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tagliaToolStripMenuItem.Image")));
            this.tagliaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagliaToolStripMenuItem.Name = "tagliaToolStripMenuItem";
            this.tagliaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tagliaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tagliaToolStripMenuItem.Text = "&Taglia";
            this.tagliaToolStripMenuItem.Click += new System.EventHandler(this.tagliaToolStripMenuItem_Click);
            // 
            // copiaToolStripMenuItem
            // 
            this.copiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiaToolStripMenuItem.Image")));
            this.copiaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiaToolStripMenuItem.Name = "copiaToolStripMenuItem";
            this.copiaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.copiaToolStripMenuItem.Text = "&Copia";
            this.copiaToolStripMenuItem.Click += new System.EventHandler(this.copiaToolStripMenuItem_Click);
            // 
            // incollaToolStripMenuItem
            // 
            this.incollaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incollaToolStripMenuItem.Image")));
            this.incollaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incollaToolStripMenuItem.Name = "incollaToolStripMenuItem";
            this.incollaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.incollaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.incollaToolStripMenuItem.Text = "&Incolla";
            this.incollaToolStripMenuItem.Click += new System.EventHandler(this.incollaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // selezionatuttoToolStripMenuItem
            // 
            this.selezionatuttoToolStripMenuItem.Name = "selezionatuttoToolStripMenuItem";
            this.selezionatuttoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.selezionatuttoToolStripMenuItem.Text = "Seleziona &tutto";
            this.selezionatuttoToolStripMenuItem.Click += new System.EventHandler(this.selezionatuttoToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.formatToolStripMenuItem.Image = global::Wordpad_Roggia.Properties.Resources.FormatSelection_16x;
            this.formatToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.formatToolStripMenuItem.Text = "&Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.colorToolStripMenuItem.Text = "Color Font";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // iMGToolStripMenuItem
            // 
            this.iMGToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iMGToolStripMenuItem.Image = global::Wordpad_Roggia.Properties.Resources._96px_WordPad_icon;
            this.iMGToolStripMenuItem.Name = "iMGToolStripMenuItem";
            this.iMGToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALVAToolStripMenuItem1});
            this.toolStripMenuItem2.Image = global::Wordpad_Roggia.Properties.Resources.Save_16x;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 24);
            // 
            // sALVAToolStripMenuItem1
            // 
            this.sALVAToolStripMenuItem1.Name = "sALVAToolStripMenuItem1";
            this.sALVAToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.sALVAToolStripMenuItem1.Text = "SALVA";
            this.sALVAToolStripMenuItem1.Click += new System.EventHandler(this.sALVAToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNDOToolStripMenuItem});
            this.toolStripMenuItem3.Image = global::Wordpad_Roggia.Properties.Resources.Undo_grey_16x;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(32, 24);
            // 
            // uNDOToolStripMenuItem
            // 
            this.uNDOToolStripMenuItem.Name = "uNDOToolStripMenuItem";
            this.uNDOToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.uNDOToolStripMenuItem.Text = "UNDO";
            this.uNDOToolStripMenuItem.Click += new System.EventHandler(this.uNDOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rIPETIToolStripMenuItem});
            this.toolStripMenuItem4.Image = global::Wordpad_Roggia.Properties.Resources.Redo_grey_16x;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(32, 24);
            // 
            // rIPETIToolStripMenuItem
            // 
            this.rIPETIToolStripMenuItem.Name = "rIPETIToolStripMenuItem";
            this.rIPETIToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rIPETIToolStripMenuItem.Text = "RIPRISTINA";
            this.rIPETIToolStripMenuItem.Click += new System.EventHandler(this.rIPETIToolStripMenuItem_Click);
            // 
            // frmWordPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(860, 496);
            this.Controls.Add(this.pnlRoggia);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmWordPad";
            this.Text = "WordPad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWordPad_FormClosing);
            this.Load += new System.EventHandler(this.frmWordPad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlRoggia.ResumeLayout(false);
            this.pnlRoggia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaconnomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteprimadistampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annullaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ripristinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tagliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incollaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selezionatuttoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem iMGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sALVAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem uNDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem rIPETIToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRoggia;
        private System.Windows.Forms.Button btnIncolla;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.Button btnTaglia;
        private System.Windows.Forms.Button btnAlignLeft;
        private System.Windows.Forms.Button btnAlignCenter;
        private System.Windows.Forms.Button btnAlineRight;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnElencoNumerato;
        private System.Windows.Forms.Button btnElencoPuntato;
        private System.Windows.Forms.Button btnColorText;
        private System.Windows.Forms.CheckBox chkStriked;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Button btnSelezionaTutto;
        private System.Windows.Forms.Button btnDataOra;
        private System.Windows.Forms.Button btnMarkedText;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
    }
}

