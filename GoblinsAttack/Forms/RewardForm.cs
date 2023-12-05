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
    public partial class RewardForm : Form
    {
        bool reward1Click = false;
        bool reward2Click = false;
        public RewardForm()
        {
            InitializeComponent();
            Shown += OnShown;
            FormClosed += OnFormClosed;


        }
        private void OnFormClosed(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Game.changeEncounter();
        }
        private void OnShown(object? sender, EventArgs e)
        {
            reward1Click = false;
            reward2Click = false;
            updateData();
        }

        private void reward1_Click(object sender, EventArgs e)
        {
            if (reward1Click) return;
            reward1Click = true;
            Game.pickReward(1);
            reward1.Hide();
            reward1Name.Hide();
            updateData();
        }
        private void updateData()
        {
            reward1Name.Text = UIData.currentRewards[0].getName();
            reward2Name.Text = UIData.currentRewards[1].getName();
            reward1.Image = imageList1.Images[UIData.currentRewards[0].index];
            reward2.Image = imageList1.Images[UIData.currentRewards[1].index];
        }

        private void reward2_Click(object sender, EventArgs e)
        {
            if (reward2Click) return;
            reward2Click = true;
            Game.pickReward(2);
            reward2.Hide();
            reward2Name.Hide();
            updateData();
        }
    }
}
