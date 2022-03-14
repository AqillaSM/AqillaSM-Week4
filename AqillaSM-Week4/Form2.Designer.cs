namespace AqillaSM_Week4
{
    partial class Form2
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
            this.TextBoxAlamat2 = new System.Windows.Forms.TextBox();
            this.TextBoxTelp2 = new System.Windows.Forms.TextBox();
            this.TextBoxNama2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonKembali = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxAlamat2
            // 
            this.TextBoxAlamat2.Location = new System.Drawing.Point(141, 131);
            this.TextBoxAlamat2.Name = "TextBoxAlamat2";
            this.TextBoxAlamat2.Size = new System.Drawing.Size(457, 22);
            this.TextBoxAlamat2.TabIndex = 13;
            // 
            // TextBoxTelp2
            // 
            this.TextBoxTelp2.Location = new System.Drawing.Point(141, 178);
            this.TextBoxTelp2.Name = "TextBoxTelp2";
            this.TextBoxTelp2.Size = new System.Drawing.Size(457, 22);
            this.TextBoxTelp2.TabIndex = 12;
            // 
            // TextBoxNama2
            // 
            this.TextBoxNama2.Location = new System.Drawing.Point(141, 82);
            this.TextBoxNama2.Name = "TextBoxNama2";
            this.TextBoxNama2.Size = new System.Drawing.Size(457, 22);
            this.TextBoxNama2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telp : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alamat : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama : ";
            // 
            // ButtonKembali
            // 
            this.ButtonKembali.Location = new System.Drawing.Point(141, 238);
            this.ButtonKembali.Name = "ButtonKembali";
            this.ButtonKembali.Size = new System.Drawing.Size(85, 30);
            this.ButtonKembali.TabIndex = 14;
            this.ButtonKembali.Text = "KEMBALI";
            this.ButtonKembali.UseVisualStyleBackColor = true;
            this.ButtonKembali.Click += new System.EventHandler(this.ButtonKembali_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(254, 238);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(99, 30);
            this.ButtonPrev.TabIndex = 15;
            this.ButtonPrev.Text = "PREV DATA";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(385, 238);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(96, 30);
            this.ButtonNext.TabIndex = 16;
            this.ButtonNext.Text = "NEXT DATA";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonKembali);
            this.Controls.Add(this.TextBoxAlamat2);
            this.Controls.Add(this.TextBoxTelp2);
            this.Controls.Add(this.TextBoxNama2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxAlamat2;
        private System.Windows.Forms.TextBox TextBoxTelp2;
        private System.Windows.Forms.TextBox TextBoxNama2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonKembali;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Button ButtonNext;
    }
}