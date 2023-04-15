namespace VeterinerRandevuSistEfrDBFirstProc
{
    partial class Randevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitb = new System.Windows.Forms.Button();
            this.deleteb = new System.Windows.Forms.Button();
            this.updateb = new System.Windows.Forms.Button();
            this.addb = new System.Windows.Forms.Button();
            this.listb = new System.Windows.Forms.Button();
            this.hastacbx = new System.Windows.Forms.ComboBox();
            this.islemcbx = new System.Windows.Forms.ComboBox();
            this.calisancbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 186);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(611, 139);
            this.maskedTextBox1.Mask = "00/00/0000 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(131, 20);
            this.maskedTextBox1.TabIndex = 32;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(460, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Randevu Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(460, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "İşlem Seçiniz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(135, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Çalışan Seçiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(135, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hasta Seçiniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 87);
            this.label1.TabIndex = 22;
            this.label1.Text = "Randevu Ekranı";
            // 
            // exitb
            // 
            this.exitb.BackColor = System.Drawing.Color.Transparent;
            this.exitb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitb.Location = new System.Drawing.Point(688, 25);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(66, 35);
            this.exitb.TabIndex = 21;
            this.exitb.UseVisualStyleBackColor = false;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // deleteb
            // 
            this.deleteb.BackColor = System.Drawing.Color.Transparent;
            this.deleteb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteb.Location = new System.Drawing.Point(30, 287);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(57, 55);
            this.deleteb.TabIndex = 20;
            this.deleteb.UseVisualStyleBackColor = false;
            this.deleteb.Click += new System.EventHandler(this.deleteb_Click);
            // 
            // updateb
            // 
            this.updateb.BackColor = System.Drawing.Color.Transparent;
            this.updateb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateb.Location = new System.Drawing.Point(30, 225);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(57, 56);
            this.updateb.TabIndex = 19;
            this.updateb.UseVisualStyleBackColor = false;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            // 
            // addb
            // 
            this.addb.BackColor = System.Drawing.Color.Transparent;
            this.addb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addb.Location = new System.Drawing.Point(30, 165);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(57, 54);
            this.addb.TabIndex = 18;
            this.addb.UseVisualStyleBackColor = false;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // listb
            // 
            this.listb.BackColor = System.Drawing.Color.Transparent;
            this.listb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listb.Location = new System.Drawing.Point(30, 108);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(57, 47);
            this.listb.TabIndex = 17;
            this.listb.UseVisualStyleBackColor = false;
            this.listb.Click += new System.EventHandler(this.listb_Click);
            // 
            // hastacbx
            // 
            this.hastacbx.FormattingEnabled = true;
            this.hastacbx.Location = new System.Drawing.Point(262, 109);
            this.hastacbx.Name = "hastacbx";
            this.hastacbx.Size = new System.Drawing.Size(139, 21);
            this.hastacbx.TabIndex = 34;
            // 
            // islemcbx
            // 
            this.islemcbx.FormattingEnabled = true;
            this.islemcbx.Location = new System.Drawing.Point(611, 108);
            this.islemcbx.Name = "islemcbx";
            this.islemcbx.Size = new System.Drawing.Size(131, 21);
            this.islemcbx.TabIndex = 35;
            // 
            // calisancbx
            // 
            this.calisancbx.FormattingEnabled = true;
            this.calisancbx.Location = new System.Drawing.Point(262, 142);
            this.calisancbx.Name = "calisancbx";
            this.calisancbx.Size = new System.Drawing.Size(139, 21);
            this.calisancbx.TabIndex = 35;
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 391);
            this.Controls.Add(this.calisancbx);
            this.Controls.Add(this.islemcbx);
            this.Controls.Add(this.hastacbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.deleteb);
            this.Controls.Add(this.updateb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.listb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randevu";
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.Button updateb;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button listb;
        private System.Windows.Forms.ComboBox hastacbx;
        private System.Windows.Forms.ComboBox islemcbx;
        private System.Windows.Forms.ComboBox calisancbx;
    }
}