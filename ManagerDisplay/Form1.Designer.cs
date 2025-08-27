namespace ManagerDisplay
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
            dataGridView1 = new DataGridView();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            pictureBox1 = new PictureBox();
            btnPay = new Button();
            TotalAmountlabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 169);
            dataGridView1.Margin = new Padding(7, 8, 7, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(1140, 1197);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1313, 169);
            textBox1.Margin = new Padding(7, 8, 7, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(599, 78);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1227, 306);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(197, 120);
            button1.TabIndex = 3;
            button1.Text = "Croissant";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1431, 306);
            button2.Margin = new Padding(7, 8, 7, 8);
            button2.Name = "button2";
            button2.Size = new Size(187, 120);
            button2.TabIndex = 4;
            button2.Text = "Eclair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1625, 306);
            button3.Margin = new Padding(7, 8, 7, 8);
            button3.Name = "button3";
            button3.Size = new Size(191, 120);
            button3.TabIndex = 5;
            button3.Text = "choco mousse";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1826, 306);
            button4.Margin = new Padding(7, 8, 7, 8);
            button4.Name = "button4";
            button4.Size = new Size(180, 120);
            button4.TabIndex = 6;
            button4.Text = "Wheat bread";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.ForeColor = Color.White;
            button5.Location = new Point(1227, 443);
            button5.Margin = new Padding(7, 8, 7, 8);
            button5.Name = "button5";
            button5.Size = new Size(197, 120);
            button5.TabIndex = 7;
            button5.Text = "white bread";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.ForeColor = Color.White;
            button6.Location = new Point(1431, 443);
            button6.Margin = new Padding(7, 8, 7, 8);
            button6.Name = "button6";
            button6.Size = new Size(187, 120);
            button6.TabIndex = 8;
            button6.Text = "Cheese cake";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.ForeColor = Color.White;
            button7.Location = new Point(1625, 443);
            button7.Margin = new Padding(7, 8, 7, 8);
            button7.Name = "button7";
            button7.Size = new Size(191, 120);
            button7.TabIndex = 9;
            button7.Text = "breat";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.ForeColor = Color.White;
            button8.Location = new Point(1826, 443);
            button8.Margin = new Padding(7, 8, 7, 8);
            button8.Name = "button8";
            button8.Size = new Size(180, 120);
            button8.TabIndex = 10;
            button8.Text = "Red velvet";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.ForeColor = Color.White;
            button9.Location = new Point(1227, 579);
            button9.Margin = new Padding(7, 8, 7, 8);
            button9.Name = "button9";
            button9.Size = new Size(197, 120);
            button9.TabIndex = 11;
            button9.Text = "Americano";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.ForeColor = Color.White;
            button10.Location = new Point(1431, 579);
            button10.Margin = new Padding(7, 8, 7, 8);
            button10.Name = "button10";
            button10.Size = new Size(187, 120);
            button10.TabIndex = 12;
            button10.Text = "Espresso";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            button11.ForeColor = Color.White;
            button11.Location = new Point(1625, 579);
            button11.Margin = new Padding(7, 8, 7, 8);
            button11.Name = "button11";
            button11.Size = new Size(191, 120);
            button11.TabIndex = 13;
            button11.Text = "Capuccino";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button12.ForeColor = Color.White;
            button12.Location = new Point(1826, 579);
            button12.Margin = new Padding(7, 8, 7, 8);
            button12.Name = "button12";
            button12.Size = new Size(180, 120);
            button12.TabIndex = 14;
            button12.Text = "matcha";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.BackgroundImage = (Image)resources.GetObject("button13.BackgroundImage");
            button13.BackgroundImageLayout = ImageLayout.Stretch;
            button13.ForeColor = Color.White;
            button13.Location = new Point(1227, 716);
            button13.Margin = new Padding(7, 8, 7, 8);
            button13.Name = "button13";
            button13.Size = new Size(197, 120);
            button13.TabIndex = 15;
            button13.Text = "Green tea";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.BackgroundImage = (Image)resources.GetObject("button14.BackgroundImage");
            button14.BackgroundImageLayout = ImageLayout.Stretch;
            button14.ForeColor = Color.White;
            button14.Location = new Point(1431, 716);
            button14.Margin = new Padding(7, 8, 7, 8);
            button14.Name = "button14";
            button14.Size = new Size(187, 120);
            button14.TabIndex = 16;
            button14.Text = "Sparkling water";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.BackgroundImage = (Image)resources.GetObject("button15.BackgroundImage");
            button15.BackgroundImageLayout = ImageLayout.Stretch;
            button15.ForeColor = Color.White;
            button15.Location = new Point(1625, 716);
            button15.Margin = new Padding(7, 8, 7, 8);
            button15.Name = "button15";
            button15.Size = new Size(191, 120);
            button15.TabIndex = 17;
            button15.Text = "Soda";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.BackgroundImage = (Image)resources.GetObject("button16.BackgroundImage");
            button16.BackgroundImageLayout = ImageLayout.Stretch;
            button16.ForeColor = Color.White;
            button16.Location = new Point(1826, 716);
            button16.Margin = new Padding(7, 8, 7, 8);
            button16.Name = "button16";
            button16.Size = new Size(180, 120);
            button16.TabIndex = 18;
            button16.Text = "IceCream";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button17.Location = new Point(1224, 169);
            button17.Margin = new Padding(7, 8, 7, 8);
            button17.Name = "button17";
            button17.Size = new Size(75, 87);
            button17.TabIndex = 19;
            button17.Text = "<";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button18.Location = new Point(1931, 169);
            button18.Margin = new Padding(7, 8, 7, 8);
            button18.Name = "button18";
            button18.Size = new Size(75, 87);
            button18.TabIndex = 20;
            button18.Text = ">";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(37, 50, 167);
            button19.ForeColor = Color.White;
            button19.Location = new Point(1221, 979);
            button19.Margin = new Padding(7, 8, 7, 8);
            button19.Name = "button19";
            button19.Size = new Size(200, 134);
            button19.TabIndex = 21;
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(37, 50, 167);
            button20.ForeColor = Color.White;
            button20.Location = new Point(1425, 979);
            button20.Margin = new Padding(7, 8, 7, 8);
            button20.Name = "button20";
            button20.Size = new Size(200, 134);
            button20.TabIndex = 22;
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(37, 50, 167);
            button21.ForeColor = Color.White;
            button21.Location = new Point(1619, 979);
            button21.Margin = new Padding(7, 8, 7, 8);
            button21.Name = "button21";
            button21.Size = new Size(200, 134);
            button21.TabIndex = 23;
            button21.Text = "button21";
            button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(37, 50, 167);
            button22.ForeColor = Color.White;
            button22.Location = new Point(1822, 979);
            button22.Margin = new Padding(7, 8, 7, 8);
            button22.Name = "button22";
            button22.Size = new Size(200, 134);
            button22.TabIndex = 24;
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(37, 50, 167);
            button23.ForeColor = Color.White;
            button23.Location = new Point(1822, 1110);
            button23.Margin = new Padding(7, 8, 7, 8);
            button23.Name = "button23";
            button23.Size = new Size(200, 134);
            button23.TabIndex = 28;
            button23.Text = "button23";
            button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = Color.FromArgb(37, 50, 167);
            button24.ForeColor = Color.White;
            button24.Location = new Point(1619, 1110);
            button24.Margin = new Padding(7, 8, 7, 8);
            button24.Name = "button24";
            button24.Size = new Size(200, 134);
            button24.TabIndex = 27;
            button24.Text = "button24";
            button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            button25.BackColor = Color.FromArgb(37, 50, 167);
            button25.ForeColor = Color.White;
            button25.Location = new Point(1425, 1110);
            button25.Margin = new Padding(7, 8, 7, 8);
            button25.Name = "button25";
            button25.Size = new Size(200, 134);
            button25.TabIndex = 26;
            button25.Text = "button25";
            button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            button26.BackColor = Color.FromArgb(37, 50, 167);
            button26.ForeColor = Color.White;
            button26.Location = new Point(1221, 1110);
            button26.Margin = new Padding(7, 8, 7, 8);
            button26.Name = "button26";
            button26.Size = new Size(200, 134);
            button26.TabIndex = 25;
            button26.Text = "button26";
            button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            button27.BackColor = Color.FromArgb(37, 50, 167);
            button27.ForeColor = Color.White;
            button27.Location = new Point(1822, 1241);
            button27.Margin = new Padding(7, 8, 7, 8);
            button27.Name = "button27";
            button27.Size = new Size(200, 134);
            button27.TabIndex = 32;
            button27.Text = "button27";
            button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            button28.BackColor = Color.FromArgb(37, 50, 167);
            button28.ForeColor = Color.White;
            button28.Location = new Point(1619, 1241);
            button28.Margin = new Padding(7, 8, 7, 8);
            button28.Name = "button28";
            button28.Size = new Size(200, 134);
            button28.TabIndex = 31;
            button28.Text = "button28";
            button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = Color.FromArgb(37, 50, 167);
            button29.ForeColor = Color.White;
            button29.Location = new Point(1425, 1241);
            button29.Margin = new Padding(7, 8, 7, 8);
            button29.Name = "button29";
            button29.Size = new Size(200, 134);
            button29.TabIndex = 30;
            button29.Text = "button29";
            button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            button30.BackColor = Color.FromArgb(37, 50, 167);
            button30.ForeColor = Color.White;
            button30.Location = new Point(1221, 1241);
            button30.Margin = new Padding(7, 8, 7, 8);
            button30.Name = "button30";
            button30.Size = new Size(200, 134);
            button30.TabIndex = 29;
            button30.Text = "button30";
            button30.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            button31.BackColor = Color.FromArgb(37, 50, 167);
            button31.ForeColor = Color.White;
            button31.Location = new Point(857, 85);
            button31.Margin = new Padding(4);
            button31.Name = "button31";
            button31.Size = new Size(230, 67);
            button31.TabIndex = 33;
            button31.Text = "StockEdit";
            button31.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2066, 41);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Lime;
            btnPay.Font = new Font("Segoe UI", 16F);
            btnPay.Location = new Point(17, 1466);
            btnPay.Margin = new Padding(4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(1077, 116);
            btnPay.TabIndex = 39;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // TotalAmountlabel
            // 
            TotalAmountlabel.AutoSize = true;
            TotalAmountlabel.Font = new Font("Segoe UI", 16F);
            TotalAmountlabel.Location = new Point(409, 1393);
            TotalAmountlabel.Margin = new Padding(4, 0, 4, 0);
            TotalAmountlabel.Name = "TotalAmountlabel";
            TotalAmountlabel.Size = new Size(0, 72);
            TotalAmountlabel.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(18, 1389);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(364, 72);
            label1.TabIndex = 37;
            label1.Text = "Total Amount:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2254, 1635);
            Controls.Add(btnPay);
            Controls.Add(TotalAmountlabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button31);
            Controls.Add(button27);
            Controls.Add(button28);
            Controls.Add(button29);
            Controls.Add(button30);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button25);
            Controls.Add(button26);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private PictureBox pictureBox1;
        private Button btnPay;
        private Label TotalAmountlabel;
        private Label label1;
    }
}
