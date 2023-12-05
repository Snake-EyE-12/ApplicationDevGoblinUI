namespace GoblinsAttack
{
    partial class OverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverForm));
            resetButton = new Button();
            imageList1 = new ImageList(components);
            coinCount = new Label();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Location = new Point(332, 387);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(112, 34);
            resetButton.TabIndex = 1;
            resetButton.Text = "Start Over";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "gameWon.png");
            imageList1.Images.SetKeyName(1, "youDiedSmall.png");
            // 
            // coinCount
            // 
            coinCount.AutoSize = true;
            coinCount.ForeColor = Color.Olive;
            coinCount.Location = new Point(357, 350);
            coinCount.Name = "coinCount";
            coinCount.Size = new Size(59, 25);
            coinCount.TabIndex = 2;
            coinCount.Text = "label1";
            // 
            // OverForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coinCount);
            Controls.Add(resetButton);
            Name = "OverForm";
            Text = "The End";
            Load += Over_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button resetButton;
        private ImageList imageList1;
        private Label coinCount;
    }
}