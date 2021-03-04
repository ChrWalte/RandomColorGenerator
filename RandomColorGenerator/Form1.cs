using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomColorGenerator
{
    public partial class MainWindow : Form
    {

        int R = 255;
        int G = 255;
        int B = 255;
        string randomColorRGB = "";
        Random random = new Random();
        //randomColorRGB = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RandomColorButton_Click(object sender, EventArgs e)
        {
            R = random.Next(0, 256);
            G = random.Next(0, 256);
            B = random.Next(0, 256);
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
            RTextBox.Text = R.ToString();
            GTextBox.Text = G.ToString();
            BTextBox.Text = B.ToString();
        }

        private void RandomRed_Click(object sender, EventArgs e)
        {
            R = random.Next(0, 256);
            RTextBox.Text = R.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void RandomGreen_Click(object sender, EventArgs e)
        {
            G = random.Next(0, 256);
            GTextBox.Text = G.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void RandomBlue_Click(object sender, EventArgs e)
        {
            B = random.Next(0, 256);
            BTextBox.Text = B.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void RedUp_Click(object sender, EventArgs e)
        {
            if (R < 255)
            {
                R++;
            }
            RTextBox.Text = R.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void RedDown_Click(object sender, EventArgs e)
        {
            if (R > 0)
            {
                R--;
            }
            RTextBox.Text = R.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void GreenUp_Click(object sender, EventArgs e)
        {
            if (G < 255)
            {
                G++;
            }
            GTextBox.Text = G.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void GreenDown_Click(object sender, EventArgs e)
        {
            if (G > 0)
            {
                G--;
            }
            GTextBox.Text = G.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void BlueUp_Click(object sender, EventArgs e)
        {
            if (B < 255)
            {
                B++;
            }
            BTextBox.Text = B.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void BlueDown_Click(object sender, EventArgs e)
        {
            if (B > 0)
            {
                B--;
            }
            BTextBox.Text = B.ToString();
            RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            RGBTextBox.BackColor = Color.FromArgb(R, G, B);
            HexTextBox.BackColor = Color.FromArgb(R, G, B);
            Color myColor = Color.FromArgb(R, G, B);
            string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            HexTextBox.Text = "Hex #" + Hex;
            RandomColorButton.BackColor = Color.FromArgb(R, G, B);
        }

        private void RTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RTextBox.Text.Length > 0)
            {
                R = Int32.Parse(RTextBox.Text);
                if (R > 255)
                {
                    R = 255;
                    RTextBox.Text = R.ToString();
                }
                RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                HexTextBox.BackColor = Color.FromArgb(R, G, B);
                Color myColor = Color.FromArgb(R, G, B);
                string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                HexTextBox.Text = "Hex #" + Hex;
                RandomColorButton.BackColor = Color.FromArgb(R, G, B);
            }
            else
            {
                R = 0;
                RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                HexTextBox.BackColor = Color.FromArgb(R, G, B);
                Color myColor = Color.FromArgb(R, G, B);
                string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                HexTextBox.Text = "Hex #" + Hex;
                RandomColorButton.BackColor = Color.FromArgb(R, G, B);
            }
        }

        private void RTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void GTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void GTextBox_TextChanged(object sender, EventArgs e)
        {
            if (GTextBox.Text.Length > 0)
            {
                G = Int32.Parse(GTextBox.Text);
                if (G > 255)
                {
                    G = 255;
                    GTextBox.Text = G.ToString();
                }
                RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                HexTextBox.BackColor = Color.FromArgb(R, G, B);
                Color myColor = Color.FromArgb(R, G, B);
                string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                HexTextBox.Text = "Hex #" + Hex;
                RandomColorButton.BackColor = Color.FromArgb(R, G, B);
            }
            else
            {
                G = 0;
                RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                HexTextBox.BackColor = Color.FromArgb(R, G, B);
                Color myColor = Color.FromArgb(R, G, B);
                string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                HexTextBox.Text = "Hex #" + Hex;
                RandomColorButton.BackColor = Color.FromArgb(R, G, B);
            }
        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BTextBox.Text.Length > 0)
            {
                B = Int32.Parse(BTextBox.Text);
                if (B > 255)
                {
                    B = 255;
                    BTextBox.Text = B.ToString();
                }
                RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                HexTextBox.BackColor = Color.FromArgb(R, G, B);
                Color myColor = Color.FromArgb(R, G, B);
                string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                HexTextBox.Text = "Hex #" + Hex;
                RandomColorButton.BackColor = Color.FromArgb(R, G, B);
            }
            else
            {
                B = 0;
                RGBTextBox.Text = "RGB( " + R.ToString() + ", " + G.ToString() + ", " + B.ToString() + ")";
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                RGBTextBox.BackColor = Color.FromArgb(R, G, B);
                HexTextBox.BackColor = Color.FromArgb(R, G, B);
                Color myColor = Color.FromArgb(R, G, B);
                string Hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                HexTextBox.Text = "Hex #" + Hex;
                RandomColorButton.BackColor = Color.FromArgb(R, G, B);
            }
        }

        private void RGBTextBox_TextChanged(object sender, EventArgs e)
        {
            if (R <= 50
                && G <= 50
                && B <=50)
            {
                RGBTextBox.ForeColor = Color.White;
                HexTextBox.ForeColor = Color.White;
                RandomColorButton.ForeColor = Color.White;
            }
            else
            {
                RGBTextBox.ForeColor = Color.Black;
                HexTextBox.ForeColor = Color.Black;
                RandomColorButton.ForeColor = Color.Black;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            RGBTextBox.TabStop = false;
            HexTextBox.TabStop = false;
            RTextBox.TabStop = false;
            GTextBox.TabStop = false;
            BTextBox.TabStop = false;
            RandomRed.TabStop = false;
            RandomGreen.TabStop = false;
            RandomBlue.TabStop = false;
            RedUp.TabStop = false;
            RedDown.TabStop = false;
            GreenUp.TabStop = false;
            GreenDown.TabStop = false;
            BlueUp.TabStop = false;
            BlueDown.TabStop = false;
            RandomColorButton.TabStop = false;
        }
    }
}
