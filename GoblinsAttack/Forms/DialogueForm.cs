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
    public partial class DialogueForm : Form
    {
        public DialogueForm()
        {
            InitializeComponent();

            Shown += OnShown;
            opponentSprite.Image = enemySpriteList.Images[Game.getEncounterNumber()];
            FormClosed += OnFormClosed;


        }
        private void OnFormClosed(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmSpeak_Click(object sender, EventArgs e)
        {
            if (Game.respondToDialogue(responseBox.SelectedIndex)) showNewText();
        }
        private void OnShown(object? sender, EventArgs e)
        {
            showNewText();
        }
        private void showNewText()
        {
            if (Game.getCurrentDialogue() != null)
            {
                messageBox.Text = Game.getCurrentDialogue().getMessage();
                responseBox.DataSource = Game.getCurrentDialogue().getResponsesAsStrings();
            }
        }

        private void DialogueForm_Load(object sender, EventArgs e)
        {
            showNewText();
        }
    }
}
