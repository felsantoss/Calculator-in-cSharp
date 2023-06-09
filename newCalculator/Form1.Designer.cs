﻿namespace newCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_clearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Black;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(26, 46);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(277, 31);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(36, 55);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 25);
            this.result.TabIndex = 1;
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_equal.FlatAppearance.BorderSize = 0;
            this.button_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.ForeColor = System.Drawing.Color.White;
            this.button_equal.Location = new System.Drawing.Point(253, 253);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(50, 112);
            this.button_equal.TabIndex = 2;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.Silver;
            this.button_divide.FlatAppearance.BorderSize = 0;
            this.button_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_divide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.ForeColor = System.Drawing.Color.Black;
            this.button_divide.Location = new System.Drawing.Point(197, 312);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(50, 53);
            this.button_divide.TabIndex = 3;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_mult
            // 
            this.button_mult.BackColor = System.Drawing.Color.Silver;
            this.button_mult.FlatAppearance.BorderSize = 0;
            this.button_mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mult.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mult.ForeColor = System.Drawing.Color.Black;
            this.button_mult.Location = new System.Drawing.Point(197, 253);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(50, 53);
            this.button_mult.TabIndex = 4;
            this.button_mult.Text = "x";
            this.button_mult.UseVisualStyleBackColor = false;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.Silver;
            this.button_plus.FlatAppearance.BorderSize = 0;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.ForeColor = System.Drawing.Color.Black;
            this.button_plus.Location = new System.Drawing.Point(197, 135);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(50, 53);
            this.button_plus.TabIndex = 5;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.Silver;
            this.button_minus.FlatAppearance.BorderSize = 0;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.ForeColor = System.Drawing.Color.Black;
            this.button_minus.Location = new System.Drawing.Point(197, 194);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(50, 53);
            this.button_minus.TabIndex = 6;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.Gray;
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.ForeColor = System.Drawing.Color.White;
            this.button_5.Location = new System.Drawing.Point(85, 194);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(50, 53);
            this.button_5.TabIndex = 10;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.Gray;
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.ForeColor = System.Drawing.Color.White;
            this.button_8.Location = new System.Drawing.Point(85, 135);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(50, 53);
            this.button_8.TabIndex = 9;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.Gray;
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.ForeColor = System.Drawing.Color.White;
            this.button_2.Location = new System.Drawing.Point(85, 253);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(50, 53);
            this.button_2.TabIndex = 8;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.Gray;
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.ForeColor = System.Drawing.Color.White;
            this.button_6.Location = new System.Drawing.Point(141, 194);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(50, 53);
            this.button_6.TabIndex = 14;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.Gray;
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.ForeColor = System.Drawing.Color.White;
            this.button_9.Location = new System.Drawing.Point(141, 135);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(50, 53);
            this.button_9.TabIndex = 13;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.Gray;
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.ForeColor = System.Drawing.Color.White;
            this.button_3.Location = new System.Drawing.Point(141, 253);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(50, 53);
            this.button_3.TabIndex = 12;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.Color.Gray;
            this.button_dot.FlatAppearance.BorderSize = 0;
            this.button_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dot.ForeColor = System.Drawing.Color.White;
            this.button_dot.Location = new System.Drawing.Point(141, 312);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(50, 53);
            this.button_dot.TabIndex = 11;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = false;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.Gray;
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.ForeColor = System.Drawing.Color.White;
            this.button_4.Location = new System.Drawing.Point(26, 194);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(50, 53);
            this.button_4.TabIndex = 18;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.Gray;
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.ForeColor = System.Drawing.Color.White;
            this.button_7.Location = new System.Drawing.Point(26, 135);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(50, 53);
            this.button_7.TabIndex = 17;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.Gray;
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.ForeColor = System.Drawing.Color.White;
            this.button_1.Location = new System.Drawing.Point(26, 253);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(50, 53);
            this.button_1.TabIndex = 16;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.Gray;
            this.button_0.FlatAppearance.BorderSize = 0;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.ForeColor = System.Drawing.Color.White;
            this.button_0.Location = new System.Drawing.Point(26, 312);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(109, 53);
            this.button_0.TabIndex = 15;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(253, 135);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(50, 53);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "CE";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_clearAll
            // 
            this.button_clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_clearAll.FlatAppearance.BorderSize = 0;
            this.button_clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearAll.ForeColor = System.Drawing.Color.White;
            this.button_clearAll.Location = new System.Drawing.Point(253, 194);
            this.button_clearAll.Name = "button_clearAll";
            this.button_clearAll.Size = new System.Drawing.Size(50, 53);
            this.button_clearAll.TabIndex = 20;
            this.button_clearAll.Text = "C";
            this.button_clearAll.UseVisualStyleBackColor = false;
            this.button_clearAll.Click += new System.EventHandler(this.button_clearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(315, 383);
            this.Controls.Add(this.button_clearAll);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.result);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_clearAll;
    }
}

