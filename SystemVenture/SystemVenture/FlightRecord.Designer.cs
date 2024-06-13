namespace SystemVenture
{
    partial class FlightRecord
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
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            RegButton = new Button();
            FLCodeTB = new TextBox();
            PassengerSeatsTB = new TextBox();
            SourceIn = new ComboBox();
            SourceOut = new ComboBox();
            ClearButton = new Button();
            label6 = new Label();
            FDate = new DateTimePicker();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 24);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "VENTURE AIRLINES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(84, 173);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "FLIGHT CODE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(84, 222);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "From";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(84, 372);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "No. Seats";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(84, 285);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Destination";
            // 
            // RegButton
            // 
            RegButton.Location = new Point(110, 439);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(101, 39);
            RegButton.TabIndex = 8;
            RegButton.Text = "Record";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // FLCodeTB
            // 
            FLCodeTB.Location = new Point(183, 170);
            FLCodeTB.Name = "FLCodeTB";
            FLCodeTB.Size = new Size(179, 23);
            FLCodeTB.TabIndex = 10;
            // 
            // PassengerSeatsTB
            // 
            PassengerSeatsTB.Location = new Point(183, 369);
            PassengerSeatsTB.Name = "PassengerSeatsTB";
            PassengerSeatsTB.Size = new Size(179, 23);
            PassengerSeatsTB.TabIndex = 11;
            // 
            // SourceIn
            // 
            SourceIn.FormattingEnabled = true;
            SourceIn.Items.AddRange(new object[] { "Antique", "Bohol", "Siargao", "Davao", "Cebu", "Palawan", "Batanes" });
            SourceIn.Location = new Point(183, 219);
            SourceIn.Name = "SourceIn";
            SourceIn.Size = new Size(179, 23);
            SourceIn.TabIndex = 12;
            // 
            // SourceOut
            // 
            SourceOut.FormattingEnabled = true;
            SourceOut.Items.AddRange(new object[] { "Antique", "Bohol", "Siargao", "Davao", "Cebu", "Palawan", "Batanes" });
            SourceOut.Location = new Point(183, 277);
            SourceOut.Name = "SourceOut";
            SourceOut.Size = new Size(179, 23);
            SourceOut.TabIndex = 13;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(219, 439);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(101, 39);
            ClearButton.TabIndex = 14;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(84, 333);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 15;
            label6.Text = "Date of Flight";
            // 
            // FDate
            // 
            FDate.Location = new Point(183, 327);
            FDate.Name = "FDate";
            FDate.Size = new Size(179, 23);
            FDate.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(202, 68);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 17;
            label7.Text = "Reserve Flight";
            // 
            // button1
            // 
            button1.Location = new Point(219, 484);
            button1.Name = "button1";
            button1.Size = new Size(101, 39);
            button1.TabIndex = 18;
            button1.Text = "View Flights";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(326, 439);
            button2.Name = "button2";
            button2.Size = new Size(101, 39);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FlightRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ventured;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(547, 572);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(FDate);
            Controls.Add(label6);
            Controls.Add(ClearButton);
            Controls.Add(SourceOut);
            Controls.Add(SourceIn);
            Controls.Add(PassengerSeatsTB);
            Controls.Add(FLCodeTB);
            Controls.Add(RegButton);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FlightRecord";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Button RegButton;
        private TextBox FLCodeTB;
        private TextBox PassengerSeatsTB;
        private ComboBox SourceIn;
        private ComboBox SourceOut;
        private Button ClearButton;
        private Label label6;
        private DateTimePicker FDate;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}