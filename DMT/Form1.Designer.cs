namespace DMT
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCharName = new System.Windows.Forms.TextBox();
            this.txtSpielerName = new System.Windows.Forms.TextBox();
            this.lblModStärke = new System.Windows.Forms.Label();
            this.cmbRasse = new System.Windows.Forms.ComboBox();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.cmbKlasse = new System.Windows.Forms.ComboBox();
            this.cmbGesinnung = new System.Windows.Forms.ComboBox();
            this.numStärke = new System.Windows.Forms.NumericUpDown();
            this.numCharisma = new System.Windows.Forms.NumericUpDown();
            this.numWeisheit = new System.Windows.Forms.NumericUpDown();
            this.numIntelligenz = new System.Windows.Forms.NumericUpDown();
            this.numKonstitution = new System.Windows.Forms.NumericUpDown();
            this.numGeschick = new System.Windows.Forms.NumericUpDown();
            this.lblStärke = new System.Windows.Forms.Label();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.lblWeisheit = new System.Windows.Forms.Label();
            this.lblIntelligenz = new System.Windows.Forms.Label();
            this.lblKonstitution = new System.Windows.Forms.Label();
            this.lblGeschick = new System.Windows.Forms.Label();
            this.lblModCharisma = new System.Windows.Forms.Label();
            this.lblModKonstitution = new System.Windows.Forms.Label();
            this.lblModWeisheit = new System.Windows.Forms.Label();
            this.lblModIntelligenz = new System.Windows.Forms.Label();
            this.lblModGeschick = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prorammiererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStärke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeisheit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligenz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKonstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGeschick)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCharName
            // 
            this.txtCharName.Location = new System.Drawing.Point(12, 48);
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(132, 20);
            this.txtCharName.TabIndex = 0;
            // 
            // txtSpielerName
            // 
            this.txtSpielerName.Location = new System.Drawing.Point(12, 74);
            this.txtSpielerName.Name = "txtSpielerName";
            this.txtSpielerName.Size = new System.Drawing.Size(132, 20);
            this.txtSpielerName.TabIndex = 11;
            // 
            // lblModStärke
            // 
            this.lblModStärke.AutoSize = true;
            this.lblModStärke.Location = new System.Drawing.Point(128, 187);
            this.lblModStärke.Name = "lblModStärke";
            this.lblModStärke.Size = new System.Drawing.Size(16, 13);
            this.lblModStärke.TabIndex = 32;
            this.lblModStärke.Text = "+ ";
            // 
            // cmbRasse
            // 
            this.cmbRasse.FormattingEnabled = true;
            this.cmbRasse.Location = new System.Drawing.Point(12, 127);
            this.cmbRasse.Name = "cmbRasse";
            this.cmbRasse.Size = new System.Drawing.Size(132, 21);
            this.cmbRasse.TabIndex = 35;
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(150, 100);
            this.numLevel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(38, 20);
            this.numLevel.TabIndex = 36;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbKlasse
            // 
            this.cmbKlasse.FormattingEnabled = true;
            this.cmbKlasse.Location = new System.Drawing.Point(12, 100);
            this.cmbKlasse.Name = "cmbKlasse";
            this.cmbKlasse.Size = new System.Drawing.Size(132, 21);
            this.cmbKlasse.TabIndex = 37;
            // 
            // cmbGesinnung
            // 
            this.cmbGesinnung.FormattingEnabled = true;
            this.cmbGesinnung.Location = new System.Drawing.Point(12, 154);
            this.cmbGesinnung.Name = "cmbGesinnung";
            this.cmbGesinnung.Size = new System.Drawing.Size(132, 21);
            this.cmbGesinnung.TabIndex = 38;
            // 
            // numStärke
            // 
            this.numStärke.Location = new System.Drawing.Point(81, 185);
            this.numStärke.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numStärke.Name = "numStärke";
            this.numStärke.Size = new System.Drawing.Size(38, 20);
            this.numStärke.TabIndex = 39;
            this.numStärke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCharisma
            // 
            this.numCharisma.Location = new System.Drawing.Point(81, 315);
            this.numCharisma.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numCharisma.Name = "numCharisma";
            this.numCharisma.Size = new System.Drawing.Size(38, 20);
            this.numCharisma.TabIndex = 40;
            this.numCharisma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numWeisheit
            // 
            this.numWeisheit.Location = new System.Drawing.Point(81, 289);
            this.numWeisheit.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numWeisheit.Name = "numWeisheit";
            this.numWeisheit.Size = new System.Drawing.Size(38, 20);
            this.numWeisheit.TabIndex = 41;
            this.numWeisheit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numIntelligenz
            // 
            this.numIntelligenz.Location = new System.Drawing.Point(81, 263);
            this.numIntelligenz.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numIntelligenz.Name = "numIntelligenz";
            this.numIntelligenz.Size = new System.Drawing.Size(38, 20);
            this.numIntelligenz.TabIndex = 42;
            this.numIntelligenz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numKonstitution
            // 
            this.numKonstitution.Location = new System.Drawing.Point(81, 237);
            this.numKonstitution.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numKonstitution.Name = "numKonstitution";
            this.numKonstitution.Size = new System.Drawing.Size(38, 20);
            this.numKonstitution.TabIndex = 43;
            this.numKonstitution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numGeschick
            // 
            this.numGeschick.Location = new System.Drawing.Point(81, 211);
            this.numGeschick.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numGeschick.Name = "numGeschick";
            this.numGeschick.Size = new System.Drawing.Size(38, 20);
            this.numGeschick.TabIndex = 44;
            this.numGeschick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStärke
            // 
            this.lblStärke.AutoSize = true;
            this.lblStärke.Location = new System.Drawing.Point(12, 187);
            this.lblStärke.Name = "lblStärke";
            this.lblStärke.Size = new System.Drawing.Size(41, 13);
            this.lblStärke.TabIndex = 45;
            this.lblStärke.Text = "Stärke:";
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Location = new System.Drawing.Point(12, 317);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(53, 13);
            this.lblCharisma.TabIndex = 46;
            this.lblCharisma.Text = "Charisma:";
            // 
            // lblWeisheit
            // 
            this.lblWeisheit.AutoSize = true;
            this.lblWeisheit.Location = new System.Drawing.Point(12, 291);
            this.lblWeisheit.Name = "lblWeisheit";
            this.lblWeisheit.Size = new System.Drawing.Size(51, 13);
            this.lblWeisheit.TabIndex = 47;
            this.lblWeisheit.Text = "Weisheit:";
            // 
            // lblIntelligenz
            // 
            this.lblIntelligenz.AutoSize = true;
            this.lblIntelligenz.Location = new System.Drawing.Point(12, 265);
            this.lblIntelligenz.Name = "lblIntelligenz";
            this.lblIntelligenz.Size = new System.Drawing.Size(57, 13);
            this.lblIntelligenz.TabIndex = 48;
            this.lblIntelligenz.Text = "Intelligenz:";
            // 
            // lblKonstitution
            // 
            this.lblKonstitution.AutoSize = true;
            this.lblKonstitution.Location = new System.Drawing.Point(12, 239);
            this.lblKonstitution.Name = "lblKonstitution";
            this.lblKonstitution.Size = new System.Drawing.Size(65, 13);
            this.lblKonstitution.TabIndex = 49;
            this.lblKonstitution.Text = "Konstitution:";
            // 
            // lblGeschick
            // 
            this.lblGeschick.AutoSize = true;
            this.lblGeschick.Location = new System.Drawing.Point(12, 213);
            this.lblGeschick.Name = "lblGeschick";
            this.lblGeschick.Size = new System.Drawing.Size(55, 13);
            this.lblGeschick.TabIndex = 50;
            this.lblGeschick.Text = "Geschick:";
            // 
            // lblModCharisma
            // 
            this.lblModCharisma.AutoSize = true;
            this.lblModCharisma.Location = new System.Drawing.Point(128, 317);
            this.lblModCharisma.Name = "lblModCharisma";
            this.lblModCharisma.Size = new System.Drawing.Size(16, 13);
            this.lblModCharisma.TabIndex = 51;
            this.lblModCharisma.Text = "+ ";
            // 
            // lblModKonstitution
            // 
            this.lblModKonstitution.AutoSize = true;
            this.lblModKonstitution.Location = new System.Drawing.Point(128, 239);
            this.lblModKonstitution.Name = "lblModKonstitution";
            this.lblModKonstitution.Size = new System.Drawing.Size(16, 13);
            this.lblModKonstitution.TabIndex = 52;
            this.lblModKonstitution.Text = "+ ";
            // 
            // lblModWeisheit
            // 
            this.lblModWeisheit.AutoSize = true;
            this.lblModWeisheit.Location = new System.Drawing.Point(128, 291);
            this.lblModWeisheit.Name = "lblModWeisheit";
            this.lblModWeisheit.Size = new System.Drawing.Size(16, 13);
            this.lblModWeisheit.TabIndex = 53;
            this.lblModWeisheit.Text = "+ ";
            // 
            // lblModIntelligenz
            // 
            this.lblModIntelligenz.AutoSize = true;
            this.lblModIntelligenz.Location = new System.Drawing.Point(128, 265);
            this.lblModIntelligenz.Name = "lblModIntelligenz";
            this.lblModIntelligenz.Size = new System.Drawing.Size(16, 13);
            this.lblModIntelligenz.TabIndex = 54;
            this.lblModIntelligenz.Text = "+ ";
            // 
            // lblModGeschick
            // 
            this.lblModGeschick.AutoSize = true;
            this.lblModGeschick.Location = new System.Drawing.Point(128, 213);
            this.lblModGeschick.Name = "lblModGeschick";
            this.lblModGeschick.Size = new System.Drawing.Size(16, 13);
            this.lblModGeschick.TabIndex = 55;
            this.lblModGeschick.Text = "+ ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.prorammiererToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // prorammiererToolStripMenuItem
            // 
            this.prorammiererToolStripMenuItem.Name = "prorammiererToolStripMenuItem";
            this.prorammiererToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prorammiererToolStripMenuItem.Text = "Prorammierer";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 578);
            this.Controls.Add(this.lblModGeschick);
            this.Controls.Add(this.lblModIntelligenz);
            this.Controls.Add(this.lblModWeisheit);
            this.Controls.Add(this.lblModKonstitution);
            this.Controls.Add(this.lblModCharisma);
            this.Controls.Add(this.lblGeschick);
            this.Controls.Add(this.lblKonstitution);
            this.Controls.Add(this.lblIntelligenz);
            this.Controls.Add(this.lblWeisheit);
            this.Controls.Add(this.lblCharisma);
            this.Controls.Add(this.lblStärke);
            this.Controls.Add(this.numGeschick);
            this.Controls.Add(this.numKonstitution);
            this.Controls.Add(this.numIntelligenz);
            this.Controls.Add(this.numWeisheit);
            this.Controls.Add(this.numCharisma);
            this.Controls.Add(this.numStärke);
            this.Controls.Add(this.cmbGesinnung);
            this.Controls.Add(this.cmbKlasse);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.cmbRasse);
            this.Controls.Add(this.lblModStärke);
            this.Controls.Add(this.txtSpielerName);
            this.Controls.Add(this.txtCharName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStärke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeisheit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligenz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKonstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGeschick)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCharName;
        private System.Windows.Forms.TextBox txtSpielerName;
        private System.Windows.Forms.Label lblModStärke;
        private System.Windows.Forms.ComboBox cmbRasse;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.ComboBox cmbKlasse;
        private System.Windows.Forms.ComboBox cmbGesinnung;
        private System.Windows.Forms.NumericUpDown numStärke;
        private System.Windows.Forms.NumericUpDown numCharisma;
        private System.Windows.Forms.NumericUpDown numWeisheit;
        private System.Windows.Forms.NumericUpDown numIntelligenz;
        private System.Windows.Forms.NumericUpDown numKonstitution;
        private System.Windows.Forms.NumericUpDown numGeschick;
        private System.Windows.Forms.Label lblStärke;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.Label lblWeisheit;
        private System.Windows.Forms.Label lblIntelligenz;
        private System.Windows.Forms.Label lblKonstitution;
        private System.Windows.Forms.Label lblGeschick;
        private System.Windows.Forms.Label lblModCharisma;
        private System.Windows.Forms.Label lblModKonstitution;
        private System.Windows.Forms.Label lblModWeisheit;
        private System.Windows.Forms.Label lblModIntelligenz;
        private System.Windows.Forms.Label lblModGeschick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prorammiererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

