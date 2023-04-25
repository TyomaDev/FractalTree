namespace FractalTree
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            panel1 = new Panel();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 61);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(50, 26);
            label8.Margin = new Padding(1);
            label8.Name = "label8";
            label8.Size = new Size(91, 24);
            label8.TabIndex = 3;
            label8.Text = "Закрыть";
            label8.Click += label8_Click;
            label8.MouseEnter += label8_MouseEnter;
            label8.MouseLeave += label8_MouseLeave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1016, 26);
            label2.Margin = new Padding(1);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 2;
            label2.Text = "Войти";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(438, 20);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(290, 31);
            label1.TabIndex = 1;
            label1.Text = "Древовидные фракталы";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 50);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumOrchid;
            label3.Location = new Point(328, 12);
            label3.Margin = new Padding(1);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 13;
            label3.Text = "Главная";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click_1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(739, 12);
            label7.Margin = new Padding(1);
            label7.Name = "label7";
            label7.Size = new Size(90, 24);
            label7.TabIndex = 12;
            label7.Text = "Справка";
            label7.TextAlign = ContentAlignment.MiddleRight;
            label7.Click += label7_Click_1;
            label7.MouseEnter += label7_MouseEnter;
            label7.MouseLeave += label7_MouseLeave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(603, 12);
            label6.Margin = new Padding(1);
            label6.Name = "label6";
            label6.Size = new Size(134, 24);
            label6.TabIndex = 11;
            label6.Text = "О программе";
            label6.TextAlign = ContentAlignment.MiddleRight;
            label6.Click += label6_Click_1;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(509, 12);
            label5.Margin = new Padding(1);
            label5.Name = "label5";
            label5.Size = new Size(92, 24);
            label5.TabIndex = 10;
            label5.Text = "Создать";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(418, 12);
            label4.Margin = new Padding(1);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 9;
            label4.Text = "Галерея";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(473, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(719, 209);
            label9.Name = "label9";
            label9.Size = new Size(301, 42);
            label9.TabIndex = 3;
            label9.Text = "Добро пожаловать!";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(641, 280);
            label10.Name = "label10";
            label10.Size = new Size(380, 162);
            label10.TabIndex = 4;
            label10.Text = resources.GetString("label10.Text");
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(874, 463);
            button1.Name = "button1";
            button1.Size = new Size(138, 34);
            button1.TabIndex = 5;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 642);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
        private Button button1;
    }
}