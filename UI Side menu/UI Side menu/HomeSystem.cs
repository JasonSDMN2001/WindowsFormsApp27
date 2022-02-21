using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Side_menu
{
    public partial class HomeSystem : Form
    {
        private Form currentUtility;
        public HomeSystem()
        {
            InitializeComponent();
        }

        private void ViewUtility(Form utility) 
        { 
            if(currentUtility!= null) 
            {
                currentUtility.Close();
            }
            currentUtility = utility;
            utility.TopLevel = false;
            utility.FormBorderStyle = FormBorderStyle.None;
            utility.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(utility);
            panelDesktop.Tag = utility;
            utility.BringToFront();
            utility.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ViewUtility(new HomeSystem());
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.Font = new Font(iconButton1.Font,FontStyle.Bold);
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton1.Font = new Font(iconButton1.Font, FontStyle.Regular);
        }

        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ThermometerFull;
            iconButton2.Font = new Font(iconButton2.Font, FontStyle.Bold);
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ThermometerHalf;
            iconButton2.Font = new Font(iconButton2.Font, FontStyle.Regular);

        }

        private void iconButton3_MouseHover(object sender, EventArgs e)
        {
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton3.Font = new Font(iconButton3.Font, FontStyle.Bold);
        }

        private void iconButton3_MouseLeave(object sender, EventArgs e)
        {
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton3.Font = new Font(iconButton3.Font, FontStyle.Regular);
        }

        private void iconButton4_MouseHover(object sender, EventArgs e)
        {
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.Font = new Font(iconButton4.Font, FontStyle.Bold);
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton4.Font = new Font(iconButton4.Font, FontStyle.Regular);
        }

        private void iconButton5_MouseHover(object sender, EventArgs e)
        {
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton5.Font = new Font(iconButton5.Font, FontStyle.Bold);
        }

        private void iconButton5_MouseLeave(object sender, EventArgs e)
        {
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconButton5.Font = new Font(iconButton5.Font, FontStyle.Regular);
        }
    }
}
