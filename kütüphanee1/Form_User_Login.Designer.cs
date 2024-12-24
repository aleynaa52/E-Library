namespace kütüphanee1
{
    partial class Form_User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.masked_tel = new System.Windows.Forms.MaskedTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_starting_update = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADINIZ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYADINIZ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFON NUMARASI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-MAİL :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(90, 253);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(245, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(122, 289);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(213, 20);
            this.txt_surname.TabIndex = 5;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(90, 367);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(245, 20);
            this.txt_mail.TabIndex = 6;
            // 
            // masked_tel
            // 
            this.masked_tel.Location = new System.Drawing.Point(196, 329);
            this.masked_tel.Mask = "(999) 999 99 99";
            this.masked_tel.Name = "masked_tel";
            this.masked_tel.Size = new System.Drawing.Size(139, 20);
            this.masked_tel.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(141, 405);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 33);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "KAYDOL";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 202);
            this.dataGridView1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(618, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(401, 254);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(99, 23);
            this.btn_select.TabIndex = 11;
            this.btn_select.Text = "LİSTELE";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(401, 305);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_starting_update
            // 
            this.btn_starting_update.Font = new System.Drawing.Font("Perpetua Titling MT", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_starting_update.Location = new System.Drawing.Point(401, 353);
            this.btn_starting_update.Name = "btn_starting_update";
            this.btn_starting_update.Size = new System.Drawing.Size(99, 32);
            this.btn_starting_update.TabIndex = 13;
            this.btn_starting_update.Text = "GÜNCELLEME BAŞLAT";
            this.btn_starting_update.UseVisualStyleBackColor = true;
            this.btn_starting_update.Click += new System.EventHandler(this.btn_starting_update_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(401, 405);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(99, 33);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form_User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_starting_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.masked_tel);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_User_Login";
            this.Text = "Form_User_Login";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.MaskedTextBox masked_tel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_starting_update;
        private System.Windows.Forms.Button btn_update;
    }
}