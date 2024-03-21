namespace RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 33);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.SlateBlue;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 351);
            button1.Name = "button1";
            button1.Size = new Size(92, 80);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonPaper_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.SlateBlue;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(170, 351);
            button2.Name = "button2";
            button2.Size = new Size(92, 80);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonRock_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.SlateBlue;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            button3.Location = new Point(333, 351);
            button3.Name = "button3";
            button3.Size = new Size(92, 80);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonScissor_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Bottom;
            pictureBox.BackColor = Color.SlateBlue;
            pictureBox.Image = Properties.Resources.paper;
            pictureBox.ImageLocation = "";
            pictureBox.Location = new Point(93, 71);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(241, 228);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(437, 443);
            Controls.Add(pictureBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "RockPaperScissor";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox;
    }
}
