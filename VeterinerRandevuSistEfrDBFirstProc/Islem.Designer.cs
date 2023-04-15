namespace VeterinerRandevuSistEfrDBFirstProc
{
    partial class Islem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Islem));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucrettxt = new System.Windows.Forms.TextBox();
            this.aditxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitb = new System.Windows.Forms.Button();
            this.deleteb = new System.Windows.Forms.Button();
            this.updateb = new System.Windows.Forms.Button();
            this.addb = new System.Windows.Forms.Button();
            this.listb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 228);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ucrettxt
            // 
            this.ucrettxt.Location = new System.Drawing.Point(548, 118);
            this.ucrettxt.Name = "ucrettxt";
            this.ucrettxt.Size = new System.Drawing.Size(103, 20);
            this.ucrettxt.TabIndex = 43;
            // 
            // aditxt
            // 
            this.aditxt.Location = new System.Drawing.Point(249, 118);
            this.aditxt.Name = "aditxt";
            this.aditxt.Size = new System.Drawing.Size(113, 20);
            this.aditxt.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(476, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ücreti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(164, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "İşlem Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 87);
            this.label1.TabIndex = 39;
            this.label1.Text = "İşlem Ekranı";
            // 
            // exitb
            // 
            this.exitb.BackColor = System.Drawing.Color.Transparent;
            this.exitb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitb.Location = new System.Drawing.Point(688, 25);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(65, 34);
            this.exitb.TabIndex = 38;
            this.exitb.UseVisualStyleBackColor = false;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // deleteb
            // 
            this.deleteb.BackColor = System.Drawing.Color.Transparent;
            this.deleteb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteb.Location = new System.Drawing.Point(29, 286);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(57, 57);
            this.deleteb.TabIndex = 37;
            this.deleteb.UseVisualStyleBackColor = false;
            this.deleteb.Click += new System.EventHandler(this.deleteb_Click);
            // 
            // updateb
            // 
            this.updateb.BackColor = System.Drawing.Color.Transparent;
            this.updateb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateb.Location = new System.Drawing.Point(29, 226);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(57, 54);
            this.updateb.TabIndex = 36;
            this.updateb.UseVisualStyleBackColor = false;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            // 
            // addb
            // 
            this.addb.BackColor = System.Drawing.Color.Transparent;
            this.addb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addb.Location = new System.Drawing.Point(29, 168);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(57, 50);
            this.addb.TabIndex = 35;
            this.addb.UseVisualStyleBackColor = false;
            this.addb.Click += new System.EventHandler(this.addb_Click);
            // 
            // listb
            // 
            this.listb.BackColor = System.Drawing.Color.Transparent;
            this.listb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listb.Location = new System.Drawing.Point(29, 102);
            this.listb.Name = "listb";
            this.listb.Size = new System.Drawing.Size(57, 57);
            this.listb.TabIndex = 34;
            this.listb.UseVisualStyleBackColor = false;
            this.listb.Click += new System.EventHandler(this.listb_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(368, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ucrettxt);
            this.Controls.Add(this.aditxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.deleteb);
            this.Controls.Add(this.updateb);
            this.Controls.Add(this.addb);
            this.Controls.Add(this.listb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Islem";
            this.Text = "Islem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ucrettxt;
        private System.Windows.Forms.TextBox aditxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.Button updateb;
        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Button listb;
        private System.Windows.Forms.Button button1;
    }
}