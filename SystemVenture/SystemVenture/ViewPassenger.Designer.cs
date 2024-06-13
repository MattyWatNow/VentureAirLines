namespace SystemVenture
{
    partial class ViewPassenger
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
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label6 = new Label();
            PassengerVBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            GND2 = new ComboBox();
            PnameTB = new TextBox();
            PaddTB = new TextBox();
            NatBox2 = new ComboBox();
            PPhone2 = new TextBox();
            label9 = new Label();
            PassengerDGV = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            ClearButton = new Button();
            RegButton = new Button();
            PportTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(313, 56);
            label2.Name = "label2";
            label2.Size = new Size(242, 30);
            label2.TabIndex = 4;
            label2.Text = "View Passenger Flights ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 12);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 3;
            label1.Text = "VENTURE AIRLINES";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(429, 185);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 37;
            label8.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(107, 185);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 35;
            label6.Text = "Passport";
            // 
            // PassengerVBox
            // 
            PassengerVBox.Location = new Point(191, 134);
            PassengerVBox.Name = "PassengerVBox";
            PassengerVBox.Size = new Size(179, 23);
            PassengerVBox.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(106, 239);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 30;
            label5.Text = "Nationality";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(433, 137);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 29;
            label4.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(106, 137);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 28;
            label7.Text = "Passenger ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(429, 239);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 38;
            label3.Text = "Gender";
            // 
            // GND2
            // 
            GND2.FormattingEnabled = true;
            GND2.Items.AddRange(new object[] { "MALE", "FEMALE", "NON-BINARY" });
            GND2.Location = new Point(488, 231);
            GND2.Name = "GND2";
            GND2.Size = new Size(179, 23);
            GND2.TabIndex = 39;
            // 
            // PnameTB
            // 
            PnameTB.Location = new Point(488, 134);
            PnameTB.Name = "PnameTB";
            PnameTB.Size = new Size(179, 23);
            PnameTB.TabIndex = 40;
            // 
            // PaddTB
            // 
            PaddTB.Location = new Point(488, 182);
            PaddTB.Name = "PaddTB";
            PaddTB.Size = new Size(179, 23);
            PaddTB.TabIndex = 41;
            // 
            // NatBox2
            // 
            NatBox2.FormattingEnabled = true;
            NatBox2.Items.AddRange(new object[] { "Filipino" });
            NatBox2.Location = new Point(191, 236);
            NatBox2.Name = "NatBox2";
            NatBox2.Size = new Size(179, 23);
            NatBox2.TabIndex = 42;
            // 
            // PPhone2
            // 
            PPhone2.Location = new Point(376, 286);
            PPhone2.Name = "PPhone2";
            PPhone2.Size = new Size(179, 23);
            PPhone2.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(286, 286);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 43;
            label9.Text = "Phone No.";
            // 
            // PassengerDGV
            // 
            PassengerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PassengerDGV.Location = new Point(19, 401);
            PassengerDGV.Name = "PassengerDGV";
            PassengerDGV.Size = new Size(803, 160);
            PassengerDGV.TabIndex = 45;
            PassengerDGV.CellContentClick += PassengerDGV_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(430, 335);
            button2.Name = "button2";
            button2.Size = new Size(101, 60);
            button2.TabIndex = 49;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(323, 335);
            button1.Name = "button1";
            button1.Size = new Size(101, 60);
            button1.TabIndex = 48;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(537, 335);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(101, 60);
            ClearButton.TabIndex = 47;
            ClearButton.Text = "Back";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RegButton
            // 
            RegButton.Location = new Point(216, 335);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(101, 60);
            RegButton.TabIndex = 46;
            RegButton.Text = "Update";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // PportTb
            // 
            PportTb.Location = new Point(191, 182);
            PportTb.Name = "PportTb";
            PportTb.Size = new Size(179, 23);
            PportTb.TabIndex = 50;
            // 
            // ViewPassenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ventured;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 628);
            Controls.Add(PassengerDGV);
            Controls.Add(PportTb);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ClearButton);
            Controls.Add(RegButton);
            Controls.Add(PPhone2);
            Controls.Add(label9);
            Controls.Add(NatBox2);
            Controls.Add(PaddTB);
            Controls.Add(PnameTB);
            Controls.Add(GND2);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(PassengerVBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewPassenger";
            Text = "ViewPassenger";
            Load += ViewPassenger_Load;
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label8;
        private Label label6;
        private TextBox PassengerVBox;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label3;
        private ComboBox GND2;
        private TextBox PnameTB;
        private TextBox PaddTB;
        private ComboBox NatBox2;
        private TextBox PPhone2;
        private Label label9;
        private DataGridView PassengerDGV;
        private Button button2;
        private Button button1;
        private Button ClearButton;
        private Button RegButton;
        private TextBox PportTb;
    }
}