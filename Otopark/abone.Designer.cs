namespace Otopark
{
    partial class abone
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btngeri = new System.Windows.Forms.Button();
            this.txtsurucuadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsurucusoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(570, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.SlateBlue;
            this.btngeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.ForeColor = System.Drawing.Color.White;
            this.btngeri.Location = new System.Drawing.Point(12, 253);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(128, 38);
            this.btngeri.TabIndex = 9;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // txtsurucuadi
            // 
            this.txtsurucuadi.Location = new System.Drawing.Point(165, 62);
            this.txtsurucuadi.Name = "txtsurucuadi";
            this.txtsurucuadi.Size = new System.Drawing.Size(100, 20);
            this.txtsurucuadi.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sürücü Adı :";
            // 
            // txtsurucusoyadi
            // 
            this.txtsurucusoyadi.Location = new System.Drawing.Point(435, 62);
            this.txtsurucusoyadi.Name = "txtsurucusoyadi";
            this.txtsurucusoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtsurucusoyadi.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(271, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sürücü Soyadı :";
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(301, 21);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(100, 20);
            this.txtplaka.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Araç Plakası :";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.SlateBlue;
            this.btnekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.Location = new System.Drawing.Point(454, 253);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(128, 38);
            this.btnekle.TabIndex = 35;
            this.btnekle.Text = "Abone Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SlateBlue;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(320, 253);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(128, 38);
            this.btnsil.TabIndex = 36;
            this.btnsil.Text = "Abone Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(186, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // abone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(594, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtsurucuadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsurucusoyadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "abone";
            this.Text = "Otopark";
            this.Load += new System.EventHandler(this.abone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.TextBox txtsurucuadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsurucusoyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button button1;
    }
}