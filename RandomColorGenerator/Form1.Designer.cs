namespace RandomColorGenerator
{
    partial class MainWindow
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
            this.RGBTextBox = new System.Windows.Forms.TextBox();
            this.HexTextBox = new System.Windows.Forms.TextBox();
            this.RandomRed = new System.Windows.Forms.Button();
            this.RandomGreen = new System.Windows.Forms.Button();
            this.RandomBlue = new System.Windows.Forms.Button();
            this.RedUp = new System.Windows.Forms.Button();
            this.RedDown = new System.Windows.Forms.Button();
            this.GreenUp = new System.Windows.Forms.Button();
            this.GreenDown = new System.Windows.Forms.Button();
            this.BlueUp = new System.Windows.Forms.Button();
            this.BlueDown = new System.Windows.Forms.Button();
            this.RandomColorButton = new System.Windows.Forms.Button();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RGBTextBox
            // 
            this.RGBTextBox.AccessibleName = "RGBTextBox";
            this.RGBTextBox.BackColor = System.Drawing.Color.White;
            this.RGBTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.RGBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGBTextBox.ForeColor = System.Drawing.Color.Black;
            this.RGBTextBox.Location = new System.Drawing.Point(12, 12);
            this.RGBTextBox.Name = "RGBTextBox";
            this.RGBTextBox.ReadOnly = true;
            this.RGBTextBox.Size = new System.Drawing.Size(135, 20);
            this.RGBTextBox.TabIndex = 0;
            this.RGBTextBox.Tag = "RGBTextBox";
            this.RGBTextBox.Text = "RGB( 255, 255, 255)";
            this.RGBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RGBTextBox.TextChanged += new System.EventHandler(this.RGBTextBox_TextChanged);
            // 
            // HexTextBox
            // 
            this.HexTextBox.AccessibleName = "HexTextBox";
            this.HexTextBox.BackColor = System.Drawing.Color.White;
            this.HexTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.HexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexTextBox.Location = new System.Drawing.Point(153, 12);
            this.HexTextBox.Name = "HexTextBox";
            this.HexTextBox.ReadOnly = true;
            this.HexTextBox.Size = new System.Drawing.Size(135, 20);
            this.HexTextBox.TabIndex = 1;
            this.HexTextBox.Tag = "HexTextBox";
            this.HexTextBox.Text = "Hex #FFFFFF";
            this.HexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RandomRed
            // 
            this.RandomRed.AccessibleName = "RandomRed";
            this.RandomRed.BackColor = System.Drawing.Color.Red;
            this.RandomRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomRed.Location = new System.Drawing.Point(12, 64);
            this.RandomRed.Name = "RandomRed";
            this.RandomRed.Size = new System.Drawing.Size(88, 23);
            this.RandomRed.TabIndex = 2;
            this.RandomRed.Tag = "RandomRed";
            this.RandomRed.Text = "Random Red";
            this.RandomRed.UseVisualStyleBackColor = false;
            this.RandomRed.Click += new System.EventHandler(this.RandomRed_Click);
            // 
            // RandomGreen
            // 
            this.RandomGreen.AccessibleName = "RandomGreen";
            this.RandomGreen.BackColor = System.Drawing.Color.Green;
            this.RandomGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomGreen.Location = new System.Drawing.Point(106, 64);
            this.RandomGreen.Name = "RandomGreen";
            this.RandomGreen.Size = new System.Drawing.Size(88, 23);
            this.RandomGreen.TabIndex = 3;
            this.RandomGreen.Tag = "RandomGreen";
            this.RandomGreen.Text = "Random Green";
            this.RandomGreen.UseVisualStyleBackColor = false;
            this.RandomGreen.Click += new System.EventHandler(this.RandomGreen_Click);
            // 
            // RandomBlue
            // 
            this.RandomBlue.AccessibleName = "RandomBlue";
            this.RandomBlue.BackColor = System.Drawing.Color.Blue;
            this.RandomBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomBlue.Location = new System.Drawing.Point(200, 64);
            this.RandomBlue.Name = "RandomBlue";
            this.RandomBlue.Size = new System.Drawing.Size(88, 23);
            this.RandomBlue.TabIndex = 4;
            this.RandomBlue.Tag = "RandomBlue";
            this.RandomBlue.Text = "Random Blue";
            this.RandomBlue.UseVisualStyleBackColor = false;
            this.RandomBlue.Click += new System.EventHandler(this.RandomBlue_Click);
            // 
            // RedUp
            // 
            this.RedUp.AccessibleName = "RedUp";
            this.RedUp.BackColor = System.Drawing.Color.Red;
            this.RedUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedUp.Location = new System.Drawing.Point(12, 93);
            this.RedUp.Name = "RedUp";
            this.RedUp.Size = new System.Drawing.Size(40, 23);
            this.RedUp.TabIndex = 5;
            this.RedUp.Tag = "RedUp";
            this.RedUp.Text = "+";
            this.RedUp.UseVisualStyleBackColor = false;
            this.RedUp.Click += new System.EventHandler(this.RedUp_Click);
            // 
            // RedDown
            // 
            this.RedDown.AccessibleName = "RedDown";
            this.RedDown.BackColor = System.Drawing.Color.Red;
            this.RedDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedDown.Location = new System.Drawing.Point(60, 93);
            this.RedDown.Name = "RedDown";
            this.RedDown.Size = new System.Drawing.Size(40, 23);
            this.RedDown.TabIndex = 6;
            this.RedDown.Tag = "RedDown";
            this.RedDown.Text = "-";
            this.RedDown.UseVisualStyleBackColor = false;
            this.RedDown.Click += new System.EventHandler(this.RedDown_Click);
            // 
            // GreenUp
            // 
            this.GreenUp.AccessibleName = "GreenUp";
            this.GreenUp.BackColor = System.Drawing.Color.Green;
            this.GreenUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenUp.Location = new System.Drawing.Point(106, 93);
            this.GreenUp.Name = "GreenUp";
            this.GreenUp.Size = new System.Drawing.Size(40, 23);
            this.GreenUp.TabIndex = 7;
            this.GreenUp.Tag = "GreenUp";
            this.GreenUp.Text = "+";
            this.GreenUp.UseVisualStyleBackColor = false;
            this.GreenUp.Click += new System.EventHandler(this.GreenUp_Click);
            // 
            // GreenDown
            // 
            this.GreenDown.AccessibleName = "GreenDown";
            this.GreenDown.BackColor = System.Drawing.Color.Green;
            this.GreenDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenDown.Location = new System.Drawing.Point(154, 93);
            this.GreenDown.Name = "GreenDown";
            this.GreenDown.Size = new System.Drawing.Size(40, 23);
            this.GreenDown.TabIndex = 8;
            this.GreenDown.Tag = "GreenDown";
            this.GreenDown.Text = "-";
            this.GreenDown.UseVisualStyleBackColor = false;
            this.GreenDown.Click += new System.EventHandler(this.GreenDown_Click);
            // 
            // BlueUp
            // 
            this.BlueUp.AccessibleName = "BlueUp";
            this.BlueUp.BackColor = System.Drawing.Color.Blue;
            this.BlueUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueUp.Location = new System.Drawing.Point(200, 93);
            this.BlueUp.Name = "BlueUp";
            this.BlueUp.Size = new System.Drawing.Size(40, 23);
            this.BlueUp.TabIndex = 9;
            this.BlueUp.Tag = "BlueUp";
            this.BlueUp.Text = "+";
            this.BlueUp.UseVisualStyleBackColor = false;
            this.BlueUp.Click += new System.EventHandler(this.BlueUp_Click);
            // 
            // BlueDown
            // 
            this.BlueDown.AccessibleName = "BlueDown";
            this.BlueDown.BackColor = System.Drawing.Color.Blue;
            this.BlueDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueDown.Location = new System.Drawing.Point(248, 93);
            this.BlueDown.Name = "BlueDown";
            this.BlueDown.Size = new System.Drawing.Size(40, 23);
            this.BlueDown.TabIndex = 10;
            this.BlueDown.Tag = "BlueDown";
            this.BlueDown.Text = "-";
            this.BlueDown.UseVisualStyleBackColor = false;
            this.BlueDown.Click += new System.EventHandler(this.BlueDown_Click);
            // 
            // RandomColorButton
            // 
            this.RandomColorButton.AccessibleName = "RandomColorButton";
            this.RandomColorButton.BackColor = System.Drawing.Color.White;
            this.RandomColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomColorButton.Location = new System.Drawing.Point(12, 122);
            this.RandomColorButton.Name = "RandomColorButton";
            this.RandomColorButton.Size = new System.Drawing.Size(276, 23);
            this.RandomColorButton.TabIndex = 11;
            this.RandomColorButton.Tag = "RandomColorButton";
            this.RandomColorButton.Text = "Random Color";
            this.RandomColorButton.UseVisualStyleBackColor = false;
            this.RandomColorButton.Click += new System.EventHandler(this.RandomColorButton_Click);
            // 
            // RTextBox
            // 
            this.RTextBox.AccessibleName = "RTextBox";
            this.RTextBox.BackColor = System.Drawing.Color.Red;
            this.RTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTextBox.ForeColor = System.Drawing.Color.Black;
            this.RTextBox.Location = new System.Drawing.Point(12, 38);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(88, 20);
            this.RTextBox.TabIndex = 12;
            this.RTextBox.Tag = "RTextBox";
            this.RTextBox.Text = "255";
            this.RTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            this.RTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTextBox_KeyPress);
            // 
            // GTextBox
            // 
            this.GTextBox.AccessibleName = "GTextBox";
            this.GTextBox.BackColor = System.Drawing.Color.Green;
            this.GTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTextBox.ForeColor = System.Drawing.Color.Black;
            this.GTextBox.Location = new System.Drawing.Point(106, 38);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(88, 20);
            this.GTextBox.TabIndex = 13;
            this.GTextBox.Tag = "GTextBox";
            this.GTextBox.Text = "255";
            this.GTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            this.GTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GTextBox_KeyPress);
            // 
            // BTextBox
            // 
            this.BTextBox.AccessibleName = "BTextBox";
            this.BTextBox.BackColor = System.Drawing.Color.Blue;
            this.BTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTextBox.ForeColor = System.Drawing.Color.Black;
            this.BTextBox.Location = new System.Drawing.Point(200, 38);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(88, 20);
            this.BTextBox.TabIndex = 14;
            this.BTextBox.Tag = "BTextBox";
            this.BTextBox.Text = "255";
            this.BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            this.BTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BTextBox_KeyPress);
            // 
            // MainWindow
            // 
            this.AccessibleName = "MainWindow";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 155);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.GTextBox);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.RandomColorButton);
            this.Controls.Add(this.BlueDown);
            this.Controls.Add(this.BlueUp);
            this.Controls.Add(this.GreenDown);
            this.Controls.Add(this.GreenUp);
            this.Controls.Add(this.RedDown);
            this.Controls.Add(this.RedUp);
            this.Controls.Add(this.RandomBlue);
            this.Controls.Add(this.RandomGreen);
            this.Controls.Add(this.RandomRed);
            this.Controls.Add(this.HexTextBox);
            this.Controls.Add(this.RGBTextBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Tag = "MainWindow";
            this.Text = "RandomColorGenerator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RGBTextBox;
        private System.Windows.Forms.TextBox HexTextBox;
        private System.Windows.Forms.Button RandomRed;
        private System.Windows.Forms.Button RandomGreen;
        private System.Windows.Forms.Button RandomBlue;
        private System.Windows.Forms.Button RedUp;
        private System.Windows.Forms.Button RedDown;
        private System.Windows.Forms.Button GreenUp;
        private System.Windows.Forms.Button GreenDown;
        private System.Windows.Forms.Button BlueUp;
        private System.Windows.Forms.Button BlueDown;
        private System.Windows.Forms.Button RandomColorButton;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.TextBox BTextBox;
    }
}

