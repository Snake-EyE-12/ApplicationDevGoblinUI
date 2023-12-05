namespace GoblinsAttack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            characterImageBox = new PictureBox();
            confirmButton = new Button();
            skillPointsLabel = new Label();
            healthSkill = new ProgressBar();
            healthLabel = new Label();
            damageSkill = new ProgressBar();
            magicSkill = new ProgressBar();
            stealthSkill = new ProgressBar();
            damageLabel = new Label();
            magicLabel = new Label();
            stealthLabel = new Label();
            classSelection = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)characterImageBox).BeginInit();
            SuspendLayout();
            // 
            // characterImageBox
            // 
            characterImageBox.Image = Properties.Resources.CharacterImage;
            characterImageBox.Location = new Point(40, 31);
            characterImageBox.Name = "characterImageBox";
            characterImageBox.Size = new Size(285, 335);
            characterImageBox.TabIndex = 0;
            characterImageBox.TabStop = false;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(110, 389);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(112, 34);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // skillPointsLabel
            // 
            skillPointsLabel.AutoSize = true;
            skillPointsLabel.Location = new Point(484, 20);
            skillPointsLabel.Name = "skillPointsLabel";
            skillPointsLabel.Size = new Size(188, 25);
            skillPointsLabel.TabIndex = 2;
            skillPointsLabel.Text = "Skill Points Remaining:";
            // 
            // healthSkill
            // 
            healthSkill.BackColor = Color.Black;
            healthSkill.ForeColor = Color.FromArgb(192, 0, 0);
            healthSkill.Location = new Point(458, 89);
            healthSkill.Maximum = 10;
            healthSkill.Name = "healthSkill";
            healthSkill.RightToLeft = RightToLeft.No;
            healthSkill.Size = new Size(288, 58);
            healthSkill.Step = 1;
            healthSkill.TabIndex = 3;
            healthSkill.Click += healthSkill_Click;
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.BackColor = Color.Gray;
            healthLabel.ForeColor = Color.FromArgb(192, 0, 0);
            healthLabel.Location = new Point(389, 109);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(63, 25);
            healthLabel.TabIndex = 4;
            healthLabel.Text = "Health";
            // 
            // damageSkill
            // 
            damageSkill.BackColor = Color.Black;
            damageSkill.ForeColor = Color.FromArgb(128, 64, 0);
            damageSkill.Location = new Point(458, 153);
            damageSkill.Maximum = 10;
            damageSkill.Name = "damageSkill";
            damageSkill.Size = new Size(288, 58);
            damageSkill.Step = 1;
            damageSkill.TabIndex = 5;
            damageSkill.Click += damageSkill_Click;
            // 
            // magicSkill
            // 
            magicSkill.BackColor = Color.Black;
            magicSkill.ForeColor = Color.FromArgb(192, 0, 192);
            magicSkill.Location = new Point(458, 217);
            magicSkill.Maximum = 10;
            magicSkill.Name = "magicSkill";
            magicSkill.Size = new Size(288, 58);
            magicSkill.Step = 1;
            magicSkill.TabIndex = 6;
            magicSkill.Click += magicSkill_Click;
            // 
            // stealthSkill
            // 
            stealthSkill.BackColor = Color.Black;
            stealthSkill.ForeColor = Color.FromArgb(64, 64, 64);
            stealthSkill.Location = new Point(458, 281);
            stealthSkill.Maximum = 10;
            stealthSkill.Name = "stealthSkill";
            stealthSkill.Size = new Size(288, 58);
            stealthSkill.Step = 1;
            stealthSkill.TabIndex = 7;
            stealthSkill.Click += stealthSkill_Click;
            // 
            // damageLabel
            // 
            damageLabel.AutoSize = true;
            damageLabel.BackColor = Color.Gray;
            damageLabel.ForeColor = Color.FromArgb(128, 64, 0);
            damageLabel.Location = new Point(373, 173);
            damageLabel.Name = "damageLabel";
            damageLabel.Size = new Size(79, 25);
            damageLabel.TabIndex = 8;
            damageLabel.Text = "Damage";
            // 
            // magicLabel
            // 
            magicLabel.AutoSize = true;
            magicLabel.BackColor = Color.Gray;
            magicLabel.ForeColor = Color.FromArgb(192, 0, 192);
            magicLabel.Location = new Point(392, 234);
            magicLabel.Name = "magicLabel";
            magicLabel.Size = new Size(60, 25);
            magicLabel.TabIndex = 9;
            magicLabel.Text = "Magic";
            // 
            // stealthLabel
            // 
            stealthLabel.AutoSize = true;
            stealthLabel.BackColor = Color.Gray;
            stealthLabel.ForeColor = Color.FromArgb(64, 64, 64);
            stealthLabel.Location = new Point(387, 299);
            stealthLabel.Name = "stealthLabel";
            stealthLabel.Size = new Size(65, 25);
            stealthLabel.TabIndex = 10;
            stealthLabel.Text = "Stealth";
            // 
            // classSelection
            // 
            classSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            classSelection.FormattingEnabled = true;
            classSelection.Location = new Point(508, 389);
            classSelection.Name = "classSelection";
            classSelection.Size = new Size(182, 33);
            classSelection.TabIndex = 11;
            classSelection.SelectedIndexChanged += classSelection_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(classSelection);
            Controls.Add(stealthLabel);
            Controls.Add(magicLabel);
            Controls.Add(damageLabel);
            Controls.Add(stealthSkill);
            Controls.Add(magicSkill);
            Controls.Add(damageSkill);
            Controls.Add(healthLabel);
            Controls.Add(healthSkill);
            Controls.Add(skillPointsLabel);
            Controls.Add(confirmButton);
            Controls.Add(characterImageBox);
            Name = "Form1";
            Text = "The Origin";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)characterImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox characterImageBox;
        private Button confirmButton;
        private Label skillPointsLabel;
        private ProgressBar healthSkill;
        private Label healthLabel;
        private ProgressBar damageSkill;
        private ProgressBar magicSkill;
        private ProgressBar stealthSkill;
        private Label damageLabel;
        private Label magicLabel;
        private Label stealthLabel;
        private ComboBox classSelection;
    }
}