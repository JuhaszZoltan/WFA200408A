namespace WFA200408A
{
    partial class FrmVevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbNev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIgen = new System.Windows.Forms.RadioButton();
            this.rtbFoglalok = new System.Windows.Forms.RichTextBox();
            this.rbNem = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNev
            // 
            this.cbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNev.FormattingEnabled = true;
            this.cbNev.Location = new System.Drawing.Point(12, 12);
            this.cbNev.Name = "cbNev";
            this.cbNev.Size = new System.Drawing.Size(417, 39);
            this.cbNev.TabIndex = 0;
            this.cbNev.SelectedIndexChanged += new System.EventHandler(this.cbNev_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cím:";
            // 
            // tbCim
            // 
            this.tbCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCim.Location = new System.Drawing.Point(88, 72);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(341, 38);
            this.tbCim.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNem);
            this.groupBox1.Controls.Add(this.rbIgen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Megbízható?";
            // 
            // rbIgen
            // 
            this.rbIgen.AutoSize = true;
            this.rbIgen.Location = new System.Drawing.Point(54, 57);
            this.rbIgen.Name = "rbIgen";
            this.rbIgen.Size = new System.Drawing.Size(86, 35);
            this.rbIgen.TabIndex = 0;
            this.rbIgen.TabStop = true;
            this.rbIgen.Text = "igen";
            this.rbIgen.UseVisualStyleBackColor = true;
            // 
            // rtbFoglalok
            // 
            this.rtbFoglalok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbFoglalok.Location = new System.Drawing.Point(12, 287);
            this.rtbFoglalok.Name = "rtbFoglalok";
            this.rtbFoglalok.Size = new System.Drawing.Size(417, 284);
            this.rtbFoglalok.TabIndex = 4;
            this.rtbFoglalok.Text = "";
            // 
            // rbNem
            // 
            this.rbNem.AutoSize = true;
            this.rbNem.Location = new System.Drawing.Point(268, 57);
            this.rbNem.Name = "rbNem";
            this.rbNem.Size = new System.Drawing.Size(87, 35);
            this.rbNem.TabIndex = 0;
            this.rbNem.TabStop = true;
            this.rbNem.Text = "nem";
            this.rbNem.UseVisualStyleBackColor = true;
            // 
            // FrmVevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 583);
            this.Controls.Add(this.rtbFoglalok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNev);
            this.Name = "FrmVevo";
            this.Text = "FrmVevo";
            this.Load += new System.EventHandler(this.FrmVevo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNem;
        private System.Windows.Forms.RadioButton rbIgen;
        private System.Windows.Forms.RichTextBox rtbFoglalok;
    }
}