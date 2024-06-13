namespace SystemVenture
{
    partial class TicketCancellation
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
            CancelTB = new TextBox();
            label4 = new Label();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            ClearButton = new Button();
            CancelDGV = new DataGridView();
            FCancelCodeTB = new TextBox();
            FCancelDate1 = new DateTimePicker();
            TidCb = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)CancelDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(290, 82);
            label2.Name = "label2";
            label2.Size = new Size(199, 30);
            label2.TabIndex = 8;
            label2.Text = "Ticket Cancellation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 35);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 7;
            label1.Text = "VENTURE AIRLINES";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(423, 221);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 65;
            label8.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(76, 213);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 64;
            label6.Text = "Flight Code";
            // 
            // CancelTB
            // 
            CancelTB.Location = new Point(160, 157);
            CancelTB.Name = "CancelTB";
            CancelTB.Size = new Size(179, 23);
            CancelTB.TabIndex = 63;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(413, 157);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 62;
            label4.Text = "Ticket ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(76, 160);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 61;
            label7.Text = "Cancelled";
            // 
            // button2
            // 
            button2.Location = new Point(439, 295);
            button2.Name = "button2";
            button2.Size = new Size(101, 60);
            button2.TabIndex = 75;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(225, 295);
            button1.Name = "button1";
            button1.Size = new Size(101, 60);
            button1.TabIndex = 74;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(332, 295);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(101, 60);
            ClearButton.TabIndex = 73;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // CancelDGV
            // 
            CancelDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CancelDGV.Location = new Point(44, 429);
            CancelDGV.Name = "CancelDGV";
            CancelDGV.Size = new Size(720, 153);
            CancelDGV.TabIndex = 76;
            // 
            // FCancelCodeTB
            // 
            FCancelCodeTB.Location = new Point(160, 210);
            FCancelCodeTB.Name = "FCancelCodeTB";
            FCancelCodeTB.Size = new Size(179, 23);
            FCancelCodeTB.TabIndex = 77;
            // 
            // FCancelDate1
            // 
            FCancelDate1.Location = new Point(483, 213);
            FCancelDate1.Name = "FCancelDate1";
            FCancelDate1.Size = new Size(189, 23);
            FCancelDate1.TabIndex = 78;
            // 
            // TidCb
            // 
            TidCb.FormattingEnabled = true;
            TidCb.Items.AddRange(new object[] { "Antique", "Bohol", "Siargao", "Davao", "Cebu", "Palawan", "Batanes" });
            TidCb.Location = new Point(483, 154);
            TidCb.Name = "TidCb";
            TidCb.Size = new Size(189, 23);
            TidCb.TabIndex = 79;
            TidCb.SelectionChangeCommitted += TidCb_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(290, 378);
            label3.Name = "label3";
            label3.Size = new Size(174, 30);
            label3.TabIndex = 80;
            label3.Text = "Cancellation List";
            // 
            // TicketCancellation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ventured;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 633);
            Controls.Add(label3);
            Controls.Add(TidCb);
            Controls.Add(FCancelDate1);
            Controls.Add(FCancelCodeTB);
            Controls.Add(CancelDGV);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ClearButton);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(CancelTB);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TicketCancellation";
            Text = "TicketCancellation";
            Load += TicketCancellation_Load;
            ((System.ComponentModel.ISupportInitialize)CancelDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label8;
        private Label label6;
        private TextBox CancelTB;
        private Label label4;
        private Label label7;
        private Button button2;
        private Button button1;
        private Button ClearButton;
        private DataGridView CancelDGV;
        private TextBox FCancelCodeTB;
        private DateTimePicker FCancelDate1;
        private ComboBox TidCb;
        private Label label3;
    }
}