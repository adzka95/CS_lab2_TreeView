namespace lab2
{
    partial class menu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadOnly = new System.Windows.Forms.CheckBox();
            this.Archive = new System.Windows.Forms.CheckBox();
            this.Hidden = new System.Windows.Forms.CheckBox();
            this.System = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Plik = new System.Windows.Forms.RadioButton();
            this.Katalog = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Nowa nazwa";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nowa nazwa:";
            // 
            // ReadOnly
            // 
            this.ReadOnly.AutoSize = true;
            this.ReadOnly.Location = new System.Drawing.Point(50, 126);
            this.ReadOnly.Name = "ReadOnly";
            this.ReadOnly.Size = new System.Drawing.Size(73, 17);
            this.ReadOnly.TabIndex = 2;
            this.ReadOnly.Text = "ReadOnly";
            this.ReadOnly.UseVisualStyleBackColor = true;
            // 
            // Archive
            // 
            this.Archive.AutoSize = true;
            this.Archive.Location = new System.Drawing.Point(50, 149);
            this.Archive.Name = "Archive";
            this.Archive.Size = new System.Drawing.Size(62, 17);
            this.Archive.TabIndex = 3;
            this.Archive.Text = "Archive";
            this.Archive.UseVisualStyleBackColor = true;
            // 
            // Hidden
            // 
            this.Hidden.AutoSize = true;
            this.Hidden.Location = new System.Drawing.Point(50, 172);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(60, 17);
            this.Hidden.TabIndex = 4;
            this.Hidden.Text = "Hidden";
            this.Hidden.UseVisualStyleBackColor = true;
            this.Hidden.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // System
            // 
            this.System.AutoSize = true;
            this.System.Location = new System.Drawing.Point(50, 195);
            this.System.Name = "System";
            this.System.Size = new System.Drawing.Size(60, 17);
            this.System.TabIndex = 5;
            this.System.Text = "System";
            this.System.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ok);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.zamknijMenu);
            // 
            // Plik
            // 
            this.Plik.AutoSize = true;
            this.Plik.Checked = true;
            this.Plik.Location = new System.Drawing.Point(50, 48);
            this.Plik.Name = "Plik";
            this.Plik.Size = new System.Drawing.Size(42, 17);
            this.Plik.TabIndex = 8;
            this.Plik.TabStop = true;
            this.Plik.Text = "Plik";
            this.Plik.UseVisualStyleBackColor = true;
            this.Plik.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Katalog
            // 
            this.Katalog.AutoSize = true;
            this.Katalog.Location = new System.Drawing.Point(49, 71);
            this.Katalog.Name = "Katalog";
            this.Katalog.Size = new System.Drawing.Size(61, 17);
            this.Katalog.TabIndex = 9;
            this.Katalog.Text = "Katalog";
            this.Katalog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Atrybuty:";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 263);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Katalog);
            this.Controls.Add(this.Plik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.System);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.Archive);
            this.Controls.Add(this.ReadOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "menu";
            this.Text = "Nowy plik";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ReadOnly;
        private System.Windows.Forms.CheckBox Archive;
        private System.Windows.Forms.CheckBox Hidden;
        private System.Windows.Forms.CheckBox System;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton Plik;
        private System.Windows.Forms.RadioButton Katalog;
        private System.Windows.Forms.Label label3;
    }
}