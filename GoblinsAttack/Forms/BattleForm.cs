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
    public partial class BattleForm : Form
    {
        public BattleForm()
        {
            InitializeComponent();
            Shown += OnShown;
            attackDescription.Text = UIData.getNarration();
            opponentSprite.Image = enemySpriteList.Images[Game.getEncounterNumber()];
            FormClosed += OnFormClosed;


        }
        private void OnFormClosed(object? sender, EventArgs e)
        {
            Application.Exit();
        }
        private void attacked(int attackNumber)
        {
            if (Game.playerAttemptedAttack(attackNumber - 1))
            {
                //Game.Wait(250);
                updateToolTips();
                //Game.Wait(250);
                playTimer.Interval = 1000;
                playTimer.Start();
                //Game.opponentAttack();
            }
            updateToolTips();
        }

        private void attack1_Click(object sender, EventArgs e)
        {
            attacked(1);

        }

        private void attack2_Click(object sender, EventArgs e)
        {
            attacked(2);
        }

        private void attack3_Click(object sender, EventArgs e)
        {
            attacked(3);
        }

        private void attack4_Click(object sender, EventArgs e)
        {
            attacked(4);
        }
        private void OnShown(object? sender, EventArgs e)
        {
            attack1.Text = Game.getPlayer().getAttacks()[0].GetName();
            attack2.Text = Game.getPlayer().getAttacks()[1].GetName();
            attack3.Text = Game.getPlayer().getAttacks()[2].GetName();
            attack4.Text = Game.getPlayer().getAttacks()[3].GetName();


            updateToolTips();

        }
        private void updateToolTips()
        {
            toolTip1.SetToolTip(attack1, Game.getPlayer().getAttacks()[0].GetDescription());
            toolTip2.SetToolTip(attack2, Game.getPlayer().getAttacks()[1].GetDescription());
            toolTip3.SetToolTip(attack3, Game.getPlayer().getAttacks()[2].GetDescription());
            toolTip4.SetToolTip(attack4, Game.getPlayer().getAttacks()[3].GetDescription());

            attackDescription.Text = UIData.getNarration();

            HealthData healthBox = UIData.GetHealthValues();
            playerHealth.Maximum = healthBox.playerMaxHealth;
            opponentHealth.Maximum = healthBox.enemyMaxHealth;
            playerHealth.Value = healthBox.playerHealth;
            opponentHealth.Value = healthBox.enemyHealth;

            playerHealthNumber.SetToolTip(playerHealth, healthBox.playerHealth + "/" + healthBox.playerMaxHealth);
            opponentHealthNumber.SetToolTip(opponentHealth, healthBox.enemyHealth + "/" + healthBox.enemyMaxHealth);
        }

        private void playTimer_Tick(object sender, EventArgs e)
        {
            Game.opponentAttack();
            playTimer.Stop();
            updateToolTips();
        }

    }

}
