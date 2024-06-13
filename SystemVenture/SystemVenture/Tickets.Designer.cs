namespace SystemVenture
{
    partial class Tickets
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
            Pamt1 = new TextBox();
            label9 = new Label();
            PnameTB = new TextBox();
            PNatCb = new ComboBox();
            label3 = new Label();
            label8 = new Label();
            label6 = new Label();
            Tid = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            FcodeCb = new ComboBox();
            PidCb = new ComboBox();
            PPassTB = new TextBox();
            TicketDGV = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            RegButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TicketDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 72);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 6;
            label2.Text = "Ticket Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 25);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 5;
            label1.Text = "VENTURE AIRLINES";
            // 
            // Pamt1
            // 
            Pamt1.Location = new Point(330, 297);
            Pamt1.Name = "Pamt1";
            Pamt1.Size = new Size(179, 23);
            Pamt1.TabIndex = 58;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(263, 300);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 57;
            label9.Text = "Amount";
            // 
            // PnameTB
            // 
            PnameTB.Location = new Point(484, 202);
            PnameTB.Name = "PnameTB";
            PnameTB.Size = new Size(179, 23);
            PnameTB.TabIndex = 55;
            // 
            // PNatCb
            // 
            PNatCb.FormattingEnabled = true;
            PNatCb.Items.AddRange(new object[] { "Filipino" });
            PNatCb.Location = new Point(484, 248);
            PNatCb.Name = "PNatCb";
            PNatCb.Size = new Size(179, 23);
            PNatCb.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(413, 251);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 52;
            label3.Text = "Nationality";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(429, 205);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 51;
            label8.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(103, 197);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 49;
            label6.Text = "Passenger ID";
            // 
            // Tid
            // 
            Tid.Location = new Point(187, 146);
            Tid.Name = "Tid";
            Tid.Size = new Size(179, 23);
            Tid.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(102, 251);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 47;
            label5.Text = "Passport";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(410, 149);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 46;
            label4.Text = "Flight Code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(102, 149);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 45;
            label7.Text = "Ticket ID";
            // 
            // FcodeCb
            // 
            FcodeCb.FormattingEnabled = true;
            FcodeCb.Location = new Point(484, 146);
            FcodeCb.Name = "FcodeCb";
            FcodeCb.Size = new Size(179, 23);
            FcodeCb.TabIndex = 59;
            // 
            // PidCb
            // 
            PidCb.FormattingEnabled = true;
            PidCb.Location = new Point(187, 197);
            PidCb.Name = "PidCb";
            PidCb.Size = new Size(179, 23);
            PidCb.TabIndex = 60;
            PidCb.SelectionChangeCommitted += PidCb_SelectionChangeCommitted;
            // 
            // PPassTB
            // 
            PPassTB.Location = new Point(187, 251);
            PPassTB.Name = "PPassTB";
            PPassTB.Size = new Size(179, 23);
            PPassTB.TabIndex = 61;
            // 
            // TicketDGV
            // 
            TicketDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketDGV.Location = new Point(12, 451);
            TicketDGV.Name = "TicketDGV";
            TicketDGV.ReadOnly = true;
            TicketDGV.Size = new Size(883, 143);
            TicketDGV.StandardTab = true;
            TicketDGV.TabIndex = 62;
            // 
            // button2
            // 
            button2.Location = new Point(464, 385);
            button2.Name = "button2";
            button2.Size = new Size(101, 60);
            button2.TabIndex = 65;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(357, 385);
            button1.Name = "button1";
            button1.Size = new Size(101, 60);
            button1.TabIndex = 64;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegButton
            // 
            RegButton.Location = new Point(250, 385);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(101, 60);
            RegButton.TabIndex = 63;
            RegButton.Text = "Book";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // Tickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ventured;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(907, 640);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RegButton);
            Controls.Add(TicketDGV);
            Controls.Add(PPassTB);
            Controls.Add(PidCb);
            Controls.Add(FcodeCb);
            Controls.Add(Pamt1);
            Controls.Add(label9);
            Controls.Add(PnameTB);
            Controls.Add(PNatCb);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(Tid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tickets";
            Text = "Tickets";
            Load += Tickets_Load;
            ((System.ComponentModel.ISupportInitialize)TicketDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox Pamt1;
        private Label label9;
        private TextBox PnameTB;
        private ComboBox PNatCb;
        private Label label3;
        private Label label8;
        private Label label6;
        private TextBox Tid;
        private Label label5;
        private Label label4;
        private Label label7;
        private ComboBox FcodeCb;
        private ComboBox PidCb;
        private TextBox PPassTB;
        private DataGridView TicketDGV;
        private Button button2;
        private Button button1;
        private Button RegButton;
    }
}