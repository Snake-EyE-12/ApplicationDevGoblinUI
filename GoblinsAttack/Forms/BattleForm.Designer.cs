namespace GoblinsAttack
{
    partial class BattleForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            attack2 = new Button();
            attack3 = new Button();
            attack4 = new Button();
            opponentSprite = new PictureBox();
            playerSprite = new PictureBox();
            attackDescription = new Label();
            attack1 = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            opponentHealth = new ProgressBar();
            playerHealth = new ProgressBar();
            playerHealthNumber = new ToolTip(components);
            opponentHealthNumber = new ToolTip(components);
            playTimer = new System.Windows.Forms.Timer(components);
            enemySpriteList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)opponentSprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerSprite).BeginInit();
            SuspendLayout();
            // 
            // attack2
            // 
            attack2.Location = new Point(499, 236);
            attack2.Name = "attack2";
            attack2.Size = new Size(190, 74);
            attack2.TabIndex = 1;
            attack2.Text = "button1";
            attack2.UseVisualStyleBackColor = true;
            attack2.Click += attack2_Click;
            // 
            // attack3
            // 
            attack3.Location = new Point(262, 334);
            attack3.Name = "attack3";
            attack3.Size = new Size(207, 74);
            attack3.TabIndex = 2;
            attack3.Text = "button1";
            attack3.UseVisualStyleBackColor = true;
            attack3.Click += attack3_Click;
            // 
            // attack4
            // 
            attack4.Location = new Point(499, 334);
            attack4.Name = "attack4";
            attack4.Size = new Size(190, 74);
            attack4.TabIndex = 3;
            attack4.Text = "button1";
            attack4.UseVisualStyleBackColor = true;
            attack4.Click += attack4_Click;
            // 
            // opponentSprite
            // 
            opponentSprite.Location = new Point(499, 31);
            opponentSprite.Name = "opponentSprite";
            opponentSprite.Size = new Size(247, 101);
            opponentSprite.TabIndex = 4;
            opponentSprite.TabStop = false;
            // 
            // playerSprite
            // 
            playerSprite.Image = Properties.Resources.CharacterImage;
            playerSprite.Location = new Point(18, 138);
            playerSprite.Name = "playerSprite";
            playerSprite.Size = new Size(193, 250);
            playerSprite.TabIndex = 5;
            playerSprite.TabStop = false;
            // 
            // attackDescription
            // 
            attackDescription.AutoSize = true;
            attackDescription.Location = new Point(77, 59);
            attackDescription.Name = "attackDescription";
            attackDescription.Size = new Size(59, 25);
            attackDescription.TabIndex = 6;
            attackDescription.Text = "label1";
            // 
            // attack1
            // 
            attack1.Location = new Point(262, 236);
            attack1.Name = "attack1";
            attack1.Size = new Size(207, 74);
            attack1.TabIndex = 0;
            attack1.Text = "button1";
            attack1.UseVisualStyleBackColor = true;
            attack1.Click += attack1_Click;
            // 
            // opponentHealth
            // 
            opponentHealth.Location = new Point(499, 138);
            opponentHealth.Name = "opponentHealth";
            opponentHealth.Size = new Size(247, 34);
            opponentHealth.TabIndex = 7;
            // 
            // playerHealth
            // 
            playerHealth.Location = new Point(18, 394);
            playerHealth.Name = "playerHealth";
            playerHealth.Size = new Size(193, 34);
            playerHealth.TabIndex = 8;
            // 
            // playTimer
            // 
            playTimer.Tick += playTimer_Tick;
            // 
            // enemySpriteList
            // 
            enemySpriteList.ColorDepth = ColorDepth.Depth32Bit;
            enemySpriteList.ImageStream = (ImageListStreamer)resources.GetObject("enemySpriteList.ImageStream");
            enemySpriteList.TransparentColor = Color.Transparent;
            enemySpriteList.Images.SetKeyName(0, "CharacterImage.png");
            enemySpriteList.Images.SetKeyName(1, "friendEnemy.png");
            enemySpriteList.Images.SetKeyName(2, "goblinEnemy.png");
            enemySpriteList.Images.SetKeyName(3, "trollEnemy.png");
            enemySpriteList.Images.SetKeyName(4, "shrekEnemy.png");
            // 
            // BattleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playerHealth);
            Controls.Add(opponentHealth);
            Controls.Add(attackDescription);
            Controls.Add(playerSprite);
            Controls.Add(opponentSprite);
            Controls.Add(attack4);
            Controls.Add(attack3);
            Controls.Add(attack2);
            Controls.Add(attack1);
            Name = "BattleForm";
            Text = "The Clash";
            ((System.ComponentModel.ISupportInitialize)opponentSprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerSprite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button attack2;
        private Button attack3;
        private Button attack4;
        private PictureBox opponentSprite;
        private PictureBox playerSprite;
        private Label attackDescription;
        private Button attack1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ProgressBar opponentHealth;
        private ProgressBar playerHealth;
        private ToolTip playerHealthNumber;
        private ToolTip opponentHealthNumber;
        private System.Windows.Forms.Timer playTimer;
        private ImageList enemySpriteList;
    }
}