using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using UI_Side_menu;

namespace WindowsFormsApp27
{
    public partial class Menu : Form
    {
        Random random = new Random();
        Random rand = new Random();
        List<string> list = new List<string> { "cat", "goldfish" };
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int ind = rand.Next(1, 4);
            if (ind == 1)
            {
                int index = random.Next(list.Count);
                MessageBox.Show("Your " + list[index] + " has made a mess!");
            }
        }
        
        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.LaptopHouse;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
        }

        private void iconButton3_MouseEnter(object sender, EventArgs e)
        {
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Cat;
        }

        private void iconButton3_MouseLeave(object sender, EventArgs e)
        {
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Paw;
        }

        private void iconButton4_MouseEnter(object sender, EventArgs e)
        {
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //HomeSystem home = new HomeSystem();
            //home.Show();
        }
    }
}
