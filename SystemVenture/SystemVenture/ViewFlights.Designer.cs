namespace SystemVenture
{
    partial class ViewFlights
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
            FDate2 = new DateTimePicker();
            label6 = new Label();
            SourceOut = new ComboBox();
            SourceIn = new ComboBox();
            PassengerTB = new TextBox();
            FlightTB = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            FlightViewDGV = new DataGridView();
            ClearButton = new Button();
            RegButton = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)FlightViewDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 24);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 1;
            label1.Text = "VENTURE AIRLINES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(316, 68);
            label2.Name = "label2";
            label2.Size = new Size(237, 30);
            label2.TabIndex = 2;
            label2.Text = "View Schedules Flights";
            // 
            // FDate2
            // 
            FDate2.Location = new Point(188, 180);
            FDate2.Name = "FDate2";
            FDate2.Size = new Size(189, 23);
            FDate2.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(104, 180);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 25;
            label6.Text = "Date of Flight";
            // 
            // SourceOut
            // 
            SourceOut.FormattingEnabled = true;
            SourceOut.Items.AddRange(new object[] { "Antique", "Bohol", "Siargao", "Davao", "Cebu", "Palawan", "Batanes" });
            SourceOut.Location = new Point(479, 185);
            SourceOut.Name = "SourceOut";
            SourceOut.Size = new Size(179, 23);
            SourceOut.TabIndex = 24;
            // 
            // SourceIn
            // 
            SourceIn.FormattingEnabled = true;
            SourceIn.Items.AddRange(new object[] { "Antique", "Bohol", "Siargao", "Davao", "Cebu", "Palawan", "Batanes" });
            SourceIn.Location = new Point(479, 132);
            SourceIn.Name = "SourceIn";
            SourceIn.Size = new Size(179, 23);
            SourceIn.TabIndex = 23;
            // 
            // PassengerTB
            // 
            PassengerTB.Location = new Point(188, 226);
            PassengerTB.Name = "PassengerTB";
            PassengerTB.Size = new Size(179, 23);
            PassengerTB.TabIndex = 22;
            // 
            // FlightTB
            // 
            FlightTB.Location = new Point(188, 129);
            FlightTB.Name = "FlightTB";
            FlightTB.Size = new Size(179, 23);
            FlightTB.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(103, 229);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 19;
            label5.Text = "No. Seats";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(423, 132);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 18;
            label4.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(103, 132);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 17;
            label7.Text = "FLIGHT CODE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(406, 188);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 27;
            label8.Text = "Destination";
            // 
            // FlightViewDGV
            // 
            FlightViewDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightViewDGV.Location = new Point(71, 297);
            FlightViewDGV.Name = "FlightViewDGV";
            FlightViewDGV.Size = new Size(699, 174);
            FlightViewDGV.TabIndex = 28;
            FlightViewDGV.CellContentClick += FlightViewDGV_CellContentClick;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(530, 477);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(101, 60);
            ClearButton.TabIndex = 30;
            ClearButton.Text = "Back";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RegButton
            // 
            RegButton.Location = new Point(209, 477);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(101, 60);
            RegButton.TabIndex = 29;
            RegButton.Text = "Update";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(316, 477);
            button1.Name = "button1";
            button1.Size = new Size(101, 60);
            button1.TabIndex = 31;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(423, 477);
            button2.Name = "button2";
            button2.Size = new Size(101, 60);
            button2.TabIndex = 32;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ViewFlights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ventured;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 563);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ClearButton);
            Controls.Add(RegButton);
            Controls.Add(FlightViewDGV);
            Controls.Add(label8);
            Controls.Add(FDate2);
            Controls.Add(label6);
            Controls.Add(SourceOut);
            Controls.Add(SourceIn);
            Controls.Add(PassengerTB);
            Controls.Add(FlightTB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewFlights";
            Text = "ViewFlights";
            Load += ViewFlights_Load;
            ((System.ComponentModel.ISupportInitialize)FlightViewDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker FDate2;
        private Label label6;
        private ComboBox SourceOut;
        private ComboBox SourceIn;
        private TextBox PassengerTB;
        private TextBox FlightTB;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private DataGridView FlightViewDGV;
        private Button ClearButton;
        private Button RegButton;
        private Button button1;
        private Button button2;
    }
}