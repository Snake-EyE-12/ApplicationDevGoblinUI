namespace GoblinsAttack
{
    partial class DialogueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogueForm));
            messageBox = new Label();
            playerSprite = new PictureBox();
            opponentSprite = new PictureBox();
            responseBox = new ComboBox();
            confirmSpeak = new Button();
            enemySpriteList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)playerSprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opponentSprite).BeginInit();
            SuspendLayout();
            // 
            // messageBox
            // 
            messageBox.AutoSize = true;
            messageBox.Location = new Point(154, 31);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(42, 25);
            messageBox.TabIndex = 0;
            messageBox.Text = "Text";
            // 
            // playerSprite
            // 
            playerSprite.Image = Properties.Resources.CharacterImage;
            playerSprite.Location = new Point(39, 220);
            playerSprite.Name = "playerSprite";
            playerSprite.Size = new Size(211, 200);
            playerSprite.TabIndex = 1;
            playerSprite.TabStop = false;
            // 
            // opponentSprite
            // 
            opponentSprite.Location = new Point(539, 220);
            opponentSprite.Name = "opponentSprite";
            opponentSprite.Size = new Size(218, 200);
            opponentSprite.TabIndex = 2;
            opponentSprite.TabStop = false;
            // 
            // responseBox
            // 
            responseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            responseBox.FormattingEnabled = true;
            responseBox.Location = new Point(154, 108);
            responseBox.Name = "responseBox";
            responseBox.Size = new Size(514, 33);
            responseBox.TabIndex = 3;
            // 
            // confirmSpeak
            // 
            confirmSpeak.Location = new Point(343, 220);
            confirmSpeak.Name = "confirmSpeak";
            confirmSpeak.Size = new Size(112, 34);
            confirmSpeak.TabIndex = 4;
            confirmSpeak.Text = "Respond";
            confirmSpeak.UseVisualStyleBackColor = true;
            confirmSpeak.Click += confirmSpeak_Click;
            // 
            // enemySpriteList
            // 
            enemySpriteList.ColorDepth = ColorDepth.Depth32Bit;
            enemySpriteList.ImageStream = (ImageListStreamer)resources.GetObject("enemySpriteList.ImageStream");
            enemySpriteList.TransparentColor = Color.Transparent;
            enemySpriteList.Images.SetKeyName(0, "friendEnemy.png");
            enemySpriteList.Images.SetKeyName(1, "goblinEnemy.png");
            enemySpriteList.Images.SetKeyName(2, "trollEnemy.png");
            enemySpriteList.Images.SetKeyName(3, "shrekEnemy.png");
            // 
            // DialogueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confirmSpeak);
            Controls.Add(responseBox);
            Controls.Add(opponentSprite);
            Controls.Add(playerSprite);
            Controls.Add(messageBox);
            Name = "DialogueForm";
            Text = "An Encounter";
            Load += DialogueForm_Load;
            ((System.ComponentModel.ISupportInitialize)playerSprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)opponentSprite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageBox;
        private PictureBox playerSprite;
        private PictureBox opponentSprite;
        private ComboBox responseBox;
        private Button confirmSpeak;
        private ImageList enemySpriteList;
    }
}