namespace AqillaSM_Week4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSimpan = new System.Windows.Forms.Button();
            this.ButtonLihatData = new System.Windows.Forms.Button();
            this.TextBoxNama = new System.Windows.Forms.TextBox();
            this.TextBoxTelp = new System.Windows.Forms.TextBox();
            this.TextBoxAlamat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telp : ";
            // 
            // ButtonSimpan
            // 
            this.ButtonSimpan.Location = new System.Drawing.Point(128, 231);
            this.ButtonSimpan.Name = "ButtonSimpan";
            this.ButtonSimpan.Size = new System.Drawing.Size(87, 30);
            this.ButtonSimpan.TabIndex = 3;
            this.ButtonSimpan.Text = "SIMPAN";
            this.ButtonSimpan.UseVisualStyleBackColor = true;
            this.ButtonSimpan.Click += new System.EventHandler(this.ButtonSimpan_Click);
            // 
            // ButtonLihatData
            // 
            this.ButtonLihatData.Location = new System.Drawing.Point(234, 231);
            this.ButtonLihatData.Name = "ButtonLihatData";
            this.ButtonLihatData.Size = new System.Drawing.Size(116, 30);
            this.ButtonLihatData.TabIndex = 4;
            this.ButtonLihatData.Text = "LIHAT DATA";
            this.ButtonLihatData.UseVisualStyleBackColor = true;
            this.ButtonLihatData.Click += new System.EventHandler(this.ButtonLihatData_Click);
            // 
            // TextBoxNama
            // 
            this.TextBoxNama.Location = new System.Drawing.Point(128, 53);
            this.TextBoxNama.Name = "TextBoxNama";
            this.TextBoxNama.Size = new System.Drawing.Size(457, 22);
            this.TextBoxNama.TabIndex = 5;
            this.TextBoxNama.TextChanged += new System.EventHandler(this.TextBoxNama_TextChanged);
            // 
            // TextBoxTelp
            // 
            this.TextBoxTelp.Location = new System.Drawing.Point(128, 149);
            this.TextBoxTelp.Name = "TextBoxTelp";
            this.TextBoxTelp.Size = new System.Drawing.Size(457, 22);
            this.TextBoxTelp.TabIndex = 6;
            this.TextBoxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTelp_KeyPress_1);
            // 
            // TextBoxAlamat
            // 
            this.TextBoxAlamat.Location = new System.Drawing.Point(128, 102);
            this.TextBoxAlamat.Name = "TextBoxAlamat";
            this.TextBoxAlamat.Size = new System.Drawing.Size(457, 22);
            this.TextBoxAlamat.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxAlamat);
            this.Controls.Add(this.TextBoxTelp);
            this.Controls.Add(this.TextBoxNama);
            this.Controls.Add(this.ButtonLihatData);
            this.Controls.Add(this.ButtonSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonSimpan;
        private System.Windows.Forms.Button ButtonLihatData;
        private System.Windows.Forms.TextBox TextBoxNama;
        private System.Windows.Forms.TextBox TextBoxTelp;
        private System.Windows.Forms.TextBox TextBoxAlamat;
    }
}

