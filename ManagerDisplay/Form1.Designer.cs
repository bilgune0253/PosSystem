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
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductName, Quantity, UnitPrice, Total });
            dataGridView1.Location = new Point(10, 124);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(758, 876);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 9;
            ProductName.Name = "ProductName";
            ProductName.Width = 175;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 9;
            Quantity.Name = "Quantity";
            Quantity.Width = 175;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 9;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 175;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 9;
            Total.Name = "Total";
            Total.Width = 175;
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
            textBox1.Location = new Point(927, 124);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 58);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = Color.White;
            button1.Location = new Point(866, 224);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(139, 88);
            button1.TabIndex = 3;
            button1.Text = "Croissant";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1010, 224);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(132, 88);
            button2.TabIndex = 4;
            button2.Text = "Eclair";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1147, 224);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(135, 88);
            button3.TabIndex = 5;
            button3.Text = "choco mousse";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1289, 224);
            button4.Margin = new Padding(5, 6, 5, 6);
            button4.Name = "button4";
            button4.Size = new Size(127, 88);
            button4.TabIndex = 6;
            button4.Text = "Wheat bread";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.ForeColor = Color.White;
            button5.Location = new Point(866, 324);
            button5.Margin = new Padding(5, 6, 5, 6);
            button5.Name = "button5";
            button5.Size = new Size(139, 88);
            button5.TabIndex = 7;
            button5.Text = "white bread";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.ForeColor = Color.White;
            button6.Location = new Point(1010, 324);
            button6.Margin = new Padding(5, 6, 5, 6);
            button6.Name = "button6";
            button6.Size = new Size(132, 88);
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
            button7.Location = new Point(1147, 324);
            button7.Margin = new Padding(5, 6, 5, 6);
            button7.Name = "button7";
            button7.Size = new Size(135, 88);
            button7.TabIndex = 9;
            button7.Text = "breat";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.ForeColor = Color.White;
            button8.Location = new Point(1289, 324);
            button8.Margin = new Padding(5, 6, 5, 6);
            button8.Name = "button8";
            button8.Size = new Size(127, 88);
            button8.TabIndex = 10;
            button8.Text = "Red velvet";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.ForeColor = Color.White;
            button9.Location = new Point(866, 424);
            button9.Margin = new Padding(5, 6, 5, 6);
            button9.Name = "button9";
            button9.Size = new Size(139, 88);
            button9.TabIndex = 11;
            button9.Text = "Americano";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.ForeColor = Color.White;
            button10.Location = new Point(1010, 424);
            button10.Margin = new Padding(5, 6, 5, 6);
            button10.Name = "button10";
            button10.Size = new Size(132, 88);
            button10.TabIndex = 12;
            button10.Text = "Espresso";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            button11.ForeColor = Color.White;
            button11.Location = new Point(1147, 424);
            button11.Margin = new Padding(5, 6, 5, 6);
            button11.Name = "button11";
            button11.Size = new Size(135, 88);
            button11.TabIndex = 13;
            button11.Text = "Capuccino";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button12.ForeColor = Color.White;
            button12.Location = new Point(1289, 424);
            button12.Margin = new Padding(5, 6, 5, 6);
            button12.Name = "button12";
            button12.Size = new Size(127, 88);
            button12.TabIndex = 14;
            button12.Text = "matcha";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.BackgroundImage = (Image)resources.GetObject("button13.BackgroundImage");
            button13.BackgroundImageLayout = ImageLayout.Stretch;
            button13.ForeColor = Color.White;
            button13.Location = new Point(866, 524);
            button13.Margin = new Padding(5, 6, 5, 6);
            button13.Name = "button13";
            button13.Size = new Size(139, 88);
            button13.TabIndex = 15;
            button13.Text = "Green tea";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.BackgroundImage = (Image)resources.GetObject("button14.BackgroundImage");
            button14.BackgroundImageLayout = ImageLayout.Stretch;
            button14.ForeColor = Color.White;
            button14.Location = new Point(1010, 524);
            button14.Margin = new Padding(5, 6, 5, 6);
            button14.Name = "button14";
            button14.Size = new Size(132, 88);
            button14.TabIndex = 16;
            button14.Text = "Sparkling water";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.BackgroundImage = (Image)resources.GetObject("button15.BackgroundImage");
            button15.BackgroundImageLayout = ImageLayout.Stretch;
            button15.ForeColor = Color.White;
            button15.Location = new Point(1147, 524);
            button15.Margin = new Padding(5, 6, 5, 6);
            button15.Name = "button15";
            button15.Size = new Size(135, 88);
            button15.TabIndex = 17;
            button15.Text = "Soda";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.BackgroundImage = (Image)resources.GetObject("button16.BackgroundImage");
            button16.BackgroundImageLayout = ImageLayout.Stretch;
            button16.ForeColor = Color.White;
            button16.Location = new Point(1289, 524);
            button16.Margin = new Padding(5, 6, 5, 6);
            button16.Name = "button16";
            button16.Size = new Size(127, 88);
            button16.TabIndex = 18;
            button16.Text = "IceCream";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button17.Location = new Point(864, 124);
            button17.Margin = new Padding(5, 6, 5, 6);
            button17.Name = "button17";
            button17.Size = new Size(53, 64);
            button17.TabIndex = 19;
            button17.Text = "<";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button18.Location = new Point(1363, 124);
            button18.Margin = new Padding(5, 6, 5, 6);
            button18.Name = "button18";
            button18.Size = new Size(53, 64);
            button18.TabIndex = 20;
            button18.Text = ">";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(37, 50, 167);
            button19.ForeColor = Color.White;
            button19.Location = new Point(862, 716);
            button19.Margin = new Padding(5, 6, 5, 6);
            button19.Name = "button19";
            button19.Size = new Size(141, 98);
            button19.TabIndex = 21;
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(37, 50, 167);
            button20.ForeColor = Color.White;
            button20.Location = new Point(1006, 716);
            button20.Margin = new Padding(5, 6, 5, 6);
            button20.Name = "button20";
            button20.Size = new Size(141, 98);
            button20.TabIndex = 22;
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(37, 50, 167);
            button21.ForeColor = Color.White;
            button21.Location = new Point(1143, 716);
            button21.Margin = new Padding(5, 6, 5, 6);
            button21.Name = "button21";
            button21.Size = new Size(141, 98);
            button21.TabIndex = 23;
            button21.Text = "button21";
            button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(37, 50, 167);
            button22.ForeColor = Color.White;
            button22.Location = new Point(1286, 716);
            button22.Margin = new Padding(5, 6, 5, 6);
            button22.Name = "button22";
            button22.Size = new Size(141, 98);
            button22.TabIndex = 24;
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(37, 50, 167);
            button23.ForeColor = Color.White;
            button23.Location = new Point(1286, 812);
            button23.Margin = new Padding(5, 6, 5, 6);
            button23.Name = "button23";
            button23.Size = new Size(141, 98);
            button23.TabIndex = 28;
            button23.Text = "button23";
            button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = Color.FromArgb(37, 50, 167);
            button24.ForeColor = Color.White;
            button24.Location = new Point(1143, 812);
            button24.Margin = new Padding(5, 6, 5, 6);
            button24.Name = "button24";
            button24.Size = new Size(141, 98);
            button24.TabIndex = 27;
            button24.Text = "button24";
            button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            button25.BackColor = Color.FromArgb(37, 50, 167);
            button25.ForeColor = Color.White;
            button25.Location = new Point(1006, 812);
            button25.Margin = new Padding(5, 6, 5, 6);
            button25.Name = "button25";
            button25.Size = new Size(141, 98);
            button25.TabIndex = 26;
            button25.Text = "button25";
            button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            button26.BackColor = Color.FromArgb(37, 50, 167);
            button26.ForeColor = Color.White;
            button26.Location = new Point(862, 812);
            button26.Margin = new Padding(5, 6, 5, 6);
            button26.Name = "button26";
            button26.Size = new Size(141, 98);
            button26.TabIndex = 25;
            button26.Text = "button26";
            button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            button27.BackColor = Color.FromArgb(37, 50, 167);
            button27.ForeColor = Color.White;
            button27.Location = new Point(1286, 908);
            button27.Margin = new Padding(5, 6, 5, 6);
            button27.Name = "button27";
            button27.Size = new Size(141, 98);
            button27.TabIndex = 32;
            button27.Text = "button27";
            button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            button28.BackColor = Color.FromArgb(37, 50, 167);
            button28.ForeColor = Color.White;
            button28.Location = new Point(1143, 908);
            button28.Margin = new Padding(5, 6, 5, 6);
            button28.Name = "button28";
            button28.Size = new Size(141, 98);
            button28.TabIndex = 31;
            button28.Text = "button28";
            button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = Color.FromArgb(37, 50, 167);
            button29.ForeColor = Color.White;
            button29.Location = new Point(1006, 908);
            button29.Margin = new Padding(5, 6, 5, 6);
            button29.Name = "button29";
            button29.Size = new Size(141, 98);
            button29.TabIndex = 30;
            button29.Text = "button29";
            button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            button30.BackColor = Color.FromArgb(37, 50, 167);
            button30.ForeColor = Color.White;
            button30.Location = new Point(862, 908);
            button30.Margin = new Padding(5, 6, 5, 6);
            button30.Name = "button30";
            button30.Size = new Size(141, 98);
            button30.TabIndex = 29;
            button30.Text = "button30";
            button30.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            button31.BackColor = Color.FromArgb(37, 50, 167);
            button31.ForeColor = Color.White;
            button31.Location = new Point(605, 62);
            button31.Name = "button31";
            button31.Size = new Size(162, 49);
            button31.TabIndex = 33;
            button31.Text = "StockEdit";
            button31.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1458, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Lime;
            btnPay.Font = new Font("Segoe UI", 16F);
            btnPay.Location = new Point(12, 1073);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(760, 85);
            btnPay.TabIndex = 39;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // TotalAmountlabel
            // 
            TotalAmountlabel.AutoSize = true;
            TotalAmountlabel.Font = new Font("Segoe UI", 16F);
            TotalAmountlabel.Location = new Point(289, 1019);
            TotalAmountlabel.Name = "TotalAmountlabel";
            TotalAmountlabel.Size = new Size(0, 51);
            TotalAmountlabel.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(13, 1016);
            label1.Name = "label1";
            label1.Size = new Size(256, 51);
            label1.TabIndex = 37;
            label1.Text = "Total Amount:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 1196);
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
            Margin = new Padding(5, 6, 5, 6);
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
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Total;
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
