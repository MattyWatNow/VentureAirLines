namespace SystemVenture
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            UserBox = new TextBox();
            UserPassBox = new TextBox();
            pictureBox1 = new PictureBox();
            ClearBot1 = new Button();
            LogBot1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 253);
            label1.Name = "label1";
            label1.Size = new Size(93, 18);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 337);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD";
            // 
            // UserBox
            // 
            UserBox.Location = new Point(170, 284);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(179, 23);
            UserBox.TabIndex = 3;
            // 
            // UserPassBox
            // 
            UserPassBox.Location = new Point(170, 370);
            UserPassBox.Name = "UserPassBox";
            UserPassBox.Size = new Size(179, 23);
            UserPassBox.TabIndex = 4;
            UserPassBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.centurytuna;
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ClearBot1
            // 
            ClearBot1.Location = new Point(286, 447);
            ClearBot1.Name = "ClearBot1";
            ClearBot1.Size = new Size(136, 31);
            ClearBot1.TabIndex = 7;
            ClearBot1.Text = "Clear";
            ClearBot1.UseVisualStyleBackColor = true;
            ClearBot1.Click += ClearBot1_Click;
            // 
            // LogBot1
            // 
            LogBot1.Location = new Point(110, 447);
            LogBot1.Name = "LogBot1";
            LogBot1.Size = new Size(136, 31);
            LogBot1.TabIndex = 8;
            LogBot1.Text = "Login";
            LogBot1.UseVisualStyleBackColor = true;
            LogBot1.Click += LogBot1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ventured;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(531, 560);
            Controls.Add(LogBot1);
            Controls.Add(ClearBot1);
            Controls.Add(pictureBox1);
            Controls.Add(UserPassBox);
            Controls.Add(UserBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UserBox;
        private TextBox UserPassBox;
        private PictureBox pictureBox1;
        private Button ClearBot1;
        private Button LogBot1;
    }
}