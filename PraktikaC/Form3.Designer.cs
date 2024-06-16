namespace PraktikaC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 80, 61);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(398, 173);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 0;
            button1.Text = "Prisijungti";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(69, 80, 61);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 186);
            label3.Location = new Point(32, 79);
            label3.Name = "label3";
            label3.Size = new Size(352, 25);
            label3.TabIndex = 5;
            label3.Text = "                                                                    ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(69, 80, 61);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 186);
            label4.Location = new Point(32, 178);
            label4.Name = "label4";
            label4.Size = new Size(352, 25);
            label4.TabIndex = 6;
            label4.Text = "                                                                    ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(69, 80, 61);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(216, 222, 211);
            label7.Location = new Point(32, 179);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 18;
            label7.Text = "Slaptažodis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(69, 80, 61);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(216, 222, 211);
            label2.Location = new Point(32, 81);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 19;
            label2.Text = "Vartotojo vardas";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(523, 232);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label2;
    }
}