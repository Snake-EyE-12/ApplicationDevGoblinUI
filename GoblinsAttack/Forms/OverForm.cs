using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinsAttack
{
    public partial class OverForm : Form
    {
        public OverForm()
        {
            InitializeComponent();
            if (Game.gameWon)
            {
                BackgroundImage = imageList1.Images[0];
                coinCount.Text = "Coins: " + Game.getPlayerCoins();
                BackColor = Color.Yellow;
            }
            else
            {
                BackgroundImage = imageList1.Images[1];
                coinCount.Hide();

            }
            FormClosed += OnFormClosed;


        }
        private void OnFormClosed(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Over_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Game.Reset();
        }
    }
}
