﻿namespace boolean_functions_tasks
{
    partial class task12
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Impact", 11F);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 373);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 17F);
            this.label3.Location = new System.Drawing.Point(160, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "ДНФ :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Impact", 17F);
            this.textBox3.Location = new System.Drawing.Point(237, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(333, 35);
            this.textBox3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 17F);
            this.label2.Location = new System.Drawing.Point(151, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "СДНФ :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Impact", 17F);
            this.textBox2.Location = new System.Drawing.Point(237, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 35);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(311, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Получить ДНФ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(752, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 25);
            this.close.TabIndex = 27;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 101);
            this.panel3.TabIndex = 14;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(176)))), ((int)(((byte)(117)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(0, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 85);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 17F);
            this.label1.Location = new System.Drawing.Point(268, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вектор функции";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Impact", 15F);
            this.textBox1.Location = new System.Drawing.Point(311, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 32);
            this.textBox1.TabIndex = 3;
            // 
            // task12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 373);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "task12";
            this.Text = "task12";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}