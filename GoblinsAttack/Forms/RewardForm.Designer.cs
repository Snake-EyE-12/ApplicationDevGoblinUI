namespace GoblinsAttack
{
    partial class RewardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RewardForm));
            continueButton = new Button();
            reward1 = new PictureBox();
            reward2 = new PictureBox();
            reward1Name = new Label();
            reward2Name = new Label();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)reward1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reward2).BeginInit();
            SuspendLayout();
            // 
            // continueButton
            // 
            continueButton.Location = new Point(329, 366);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(112, 34);
            continueButton.TabIndex = 0;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // reward1
            // 
            reward1.Location = new Point(34, 42);
            reward1.Name = "reward1";
            reward1.Size = new Size(300, 230);
            reward1.TabIndex = 1;
            reward1.TabStop = false;
            reward1.Click += reward1_Click;
            // 
            // reward2
            // 
            reward2.Location = new Point(463, 41);
            reward2.Name = "reward2";
            reward2.Size = new Size(300, 230);
            reward2.TabIndex = 2;
            reward2.TabStop = false;
            reward2.Click += reward2_Click;
            // 
            // reward1Name
            // 
            reward1Name.AutoSize = true;
            reward1Name.Location = new Point(132, 298);
            reward1Name.Name = "reward1Name";
            reward1Name.Size = new Size(59, 25);
            reward1Name.TabIndex = 3;
            reward1Name.Text = "label1";
            // 
            // reward2Name
            // 
            reward2Name.AutoSize = true;
            reward2Name.Location = new Point(594, 298);
            reward2Name.Name = "reward2Name";
            reward2Name.Size = new Size(59, 25);
            reward2Name.TabIndex = 4;
            reward2Name.Text = "label1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "healMax.png");
            imageList1.Images.SetKeyName(1, "heal.png");
            imageList1.Images.SetKeyName(2, "coinPile.png");
            imageList1.Images.SetKeyName(3, "coin.png");
            // 
            // RewardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reward2Name);
            Controls.Add(reward1Name);
            Controls.Add(reward2);
            Controls.Add(reward1);
            Controls.Add(continueButton);
            Name = "RewardForm";
            Text = "The Gathering";
            ((System.ComponentModel.ISupportInitialize)reward1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reward2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button continueButton;
        private PictureBox reward1;
        private PictureBox reward2;
        private Label reward1Name;
        private Label reward2Name;
        private ImageList imageList1;
    }
}