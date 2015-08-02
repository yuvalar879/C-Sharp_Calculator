namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.Button = new System.Windows.Forms.Button();
            this.butt0 = new System.Windows.Forms.Button();
            this.butt9 = new System.Windows.Forms.Button();
            this.butt3 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.butt6 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.butt2 = new System.Windows.Forms.Button();
            this.butt5 = new System.Windows.Forms.Button();
            this.butt8 = new System.Windows.Forms.Button();
            this.butt4 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Op_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(12, 92);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(59, 35);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(84, 247);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(59, 32);
            this.dot.TabIndex = 4;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button
            // 
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.Location = new System.Drawing.Point(12, 209);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(59, 32);
            this.Button.TabIndex = 5;
            this.Button.Text = "1";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // butt0
            // 
            this.butt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt0.Location = new System.Drawing.Point(12, 247);
            this.butt0.Name = "butt0";
            this.butt0.Size = new System.Drawing.Size(59, 32);
            this.butt0.TabIndex = 6;
            this.butt0.Text = "0";
            this.butt0.UseVisualStyleBackColor = true;
            this.butt0.Click += new System.EventHandler(this.Button_Click);
            // 
            // butt9
            // 
            this.butt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt9.Location = new System.Drawing.Point(154, 133);
            this.butt9.Name = "butt9";
            this.butt9.Size = new System.Drawing.Size(59, 32);
            this.butt9.TabIndex = 7;
            this.butt9.Text = "9";
            this.butt9.UseVisualStyleBackColor = true;
            this.butt9.Click += new System.EventHandler(this.Button_Click);
            // 
            // butt3
            // 
            this.butt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt3.Location = new System.Drawing.Point(154, 209);
            this.butt3.Name = "butt3";
            this.butt3.Size = new System.Drawing.Size(59, 32);
            this.butt3.TabIndex = 8;
            this.butt3.Text = "3";
            this.butt3.UseVisualStyleBackColor = true;
            this.butt3.Click += new System.EventHandler(this.Button_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(219, 247);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(59, 32);
            this.div.TabIndex = 9;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.Operator_click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(219, 133);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(59, 32);
            this.plus.TabIndex = 10;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Operator_click);
            // 
            // butt6
            // 
            this.butt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt6.Location = new System.Drawing.Point(154, 171);
            this.butt6.Name = "butt6";
            this.butt6.Size = new System.Drawing.Size(59, 32);
            this.butt6.TabIndex = 11;
            this.butt6.Text = "6";
            this.butt6.UseVisualStyleBackColor = true;
            this.butt6.Click += new System.EventHandler(this.Button_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(154, 247);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(59, 32);
            this.equal.TabIndex = 12;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // butt2
            // 
            this.butt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt2.Location = new System.Drawing.Point(84, 209);
            this.butt2.Name = "butt2";
            this.butt2.Size = new System.Drawing.Size(59, 32);
            this.butt2.TabIndex = 13;
            this.butt2.Text = "2";
            this.butt2.UseVisualStyleBackColor = true;
            this.butt2.Click += new System.EventHandler(this.Button_Click);
            // 
            // butt5
            // 
            this.butt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt5.Location = new System.Drawing.Point(84, 171);
            this.butt5.Name = "butt5";
            this.butt5.Size = new System.Drawing.Size(59, 32);
            this.butt5.TabIndex = 14;
            this.butt5.Text = "5";
            this.butt5.UseVisualStyleBackColor = true;
            this.butt5.Click += new System.EventHandler(this.Button_Click);
            // 
            // butt8
            // 
            this.butt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt8.Location = new System.Drawing.Point(84, 133);
            this.butt8.Name = "butt8";
            this.butt8.Size = new System.Drawing.Size(59, 32);
            this.butt8.TabIndex = 15;
            this.butt8.Text = "8";
            this.butt8.UseVisualStyleBackColor = true;
            this.butt8.Click += new System.EventHandler(this.Button_Click);
            // 
            // butt4
            // 
            this.butt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt4.Location = new System.Drawing.Point(12, 171);
            this.butt4.Name = "butt4";
            this.butt4.Size = new System.Drawing.Size(59, 32);
            this.butt4.TabIndex = 16;
            this.butt4.Text = "4";
            this.butt4.UseVisualStyleBackColor = true;
            this.butt4.Click += new System.EventHandler(this.Button_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(219, 171);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(59, 32);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Operator_click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(219, 209);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(59, 32);
            this.mult.TabIndex = 18;
            this.mult.Text = "×";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.Operator_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Op_label
            // 
            this.Op_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op_label.Location = new System.Drawing.Point(9, 12);
            this.Op_label.Name = "Op_label";
            this.Op_label.Size = new System.Drawing.Size(62, 30);
            this.Op_label.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 307);
            this.Controls.Add(this.Op_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.butt4);
            this.Controls.Add(this.butt8);
            this.Controls.Add(this.butt5);
            this.Controls.Add(this.butt2);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.butt6);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.div);
            this.Controls.Add(this.butt3);
            this.Controls.Add(this.butt9);
            this.Controls.Add(this.butt0);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Button butt0;
        private System.Windows.Forms.Button butt9;
        private System.Windows.Forms.Button butt3;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button butt6;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button butt2;
        private System.Windows.Forms.Button butt5;
        private System.Windows.Forms.Button butt8;
        private System.Windows.Forms.Button butt4;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Op_label;
    }
}

