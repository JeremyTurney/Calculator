namespace Assignment_2_Super_Calculator_
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
            this.SuperCalculator = new System.Windows.Forms.Label();
            this.OutputScreen = new System.Windows.Forms.TextBox();
            this.Background = new System.Windows.Forms.GroupBox();
            this.Equals = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Quotient = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.Difference = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuperCalculator
            // 
            this.SuperCalculator.AutoSize = true;
            this.SuperCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperCalculator.Location = new System.Drawing.Point(160, 59);
            this.SuperCalculator.Name = "SuperCalculator";
            this.SuperCalculator.Size = new System.Drawing.Size(227, 32);
            this.SuperCalculator.TabIndex = 0;
            this.SuperCalculator.Text = "Super Calculator";
            this.SuperCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputScreen
            // 
            this.OutputScreen.Location = new System.Drawing.Point(85, 108);
            this.OutputScreen.Name = "OutputScreen";
            this.OutputScreen.Size = new System.Drawing.Size(419, 26);
            this.OutputScreen.TabIndex = 1;
            this.OutputScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Background.Controls.Add(this.Equals);
            this.Background.Controls.Add(this.Decimal);
            this.Background.Controls.Add(this.Quotient);
            this.Background.Controls.Add(this.Product);
            this.Background.Controls.Add(this.Difference);
            this.Background.Controls.Add(this.Sum);
            this.Background.Controls.Add(this.Nine);
            this.Background.Controls.Add(this.Eight);
            this.Background.Controls.Add(this.Seven);
            this.Background.Controls.Add(this.Six);
            this.Background.Controls.Add(this.Five);
            this.Background.Controls.Add(this.Four);
            this.Background.Controls.Add(this.Three);
            this.Background.Controls.Add(this.Two);
            this.Background.Controls.Add(this.One);
            this.Background.Controls.Add(this.Zero);
            this.Background.Location = new System.Drawing.Point(107, 171);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(379, 327);
            this.Background.TabIndex = 2;
            this.Background.TabStop = false;
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(260, 218);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(61, 56);
            this.Equals.TabIndex = 15;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Decimal
            // 
            this.Decimal.Location = new System.Drawing.Point(193, 218);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(61, 56);
            this.Decimal.TabIndex = 14;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Quotient
            // 
            this.Quotient.Location = new System.Drawing.Point(126, 218);
            this.Quotient.Name = "Quotient";
            this.Quotient.Size = new System.Drawing.Size(61, 56);
            this.Quotient.TabIndex = 13;
            this.Quotient.Text = "/";
            this.Quotient.UseVisualStyleBackColor = true;
            this.Quotient.Click += new System.EventHandler(this.Quotient_Click);
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(59, 218);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(61, 56);
            this.Product.TabIndex = 12;
            this.Product.Text = "X";
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Difference
            // 
            this.Difference.Location = new System.Drawing.Point(260, 156);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(61, 56);
            this.Difference.TabIndex = 11;
            this.Difference.Text = "-";
            this.Difference.UseVisualStyleBackColor = true;
            this.Difference.Click += new System.EventHandler(this.Difference_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(193, 156);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(61, 56);
            this.Sum.TabIndex = 10;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(126, 156);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(61, 56);
            this.Nine.TabIndex = 9;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(59, 156);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(61, 56);
            this.Eight.TabIndex = 8;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(260, 94);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(61, 56);
            this.Seven.TabIndex = 7;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(193, 94);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(61, 56);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Button_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(126, 94);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(61, 56);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Button_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(59, 94);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(61, 56);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Button_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(260, 32);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(61, 56);
            this.Three.TabIndex = 3;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Button_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(193, 32);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(61, 56);
            this.Two.TabIndex = 2;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Button_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(126, 32);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(61, 56);
            this.One.TabIndex = 1;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Button_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(59, 32);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(61, 56);
            this.Zero.TabIndex = 0;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Button_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(107, 537);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(82, 32);
            this.Print.TabIndex = 3;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(258, 537);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(82, 32);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(404, 537);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(82, 32);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 597);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.OutputScreen);
            this.Controls.Add(this.SuperCalculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Background.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuperCalculator;
        private System.Windows.Forms.TextBox OutputScreen;
        private System.Windows.Forms.GroupBox Background;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Quotient;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button Difference;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

