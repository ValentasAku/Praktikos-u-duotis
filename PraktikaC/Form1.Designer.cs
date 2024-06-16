namespace PraktikaC
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
            send = new Button();
            data = new DateTimePicker();
            saltinis = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            komentaras = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            srautas = new ComboBox();
            label7 = new Label();
            suma = new TextBox();
            dataGridView1 = new DataGridView();
            update = new Button();
            combox = new CheckBox();
            listBox1 = new ListBox();
            delete = new Button();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            lost = new Label();
            gain = new Label();
            sum = new Label();
            ataskaitos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // send
            // 
            send.Location = new Point(14, 415);
            send.Name = "send";
            send.Size = new Size(203, 23);
            send.TabIndex = 2;
            send.Text = "Pateikti";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // data
            // 
            data.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            data.Location = new Point(90, 116);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 9;
            // 
            // saltinis
            // 
            saltinis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            saltinis.FormattingEnabled = true;
            saltinis.Location = new Point(90, 144);
            saltinis.Name = "saltinis";
            saltinis.Size = new Size(200, 23);
            saltinis.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(705, 285);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Atnaujinti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(587, 287);
            label1.Name = "label1";
            label1.Size = new Size(112, 17);
            label1.TabIndex = 13;
            label1.Text = "Atnaujnti lentele";
            // 
            // komentaras
            // 
            komentaras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            komentaras.Location = new Point(14, 200);
            komentaras.Multiline = true;
            komentaras.Name = "komentaras";
            komentaras.Size = new Size(205, 102);
            komentaras.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(14, 181);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 15;
            label2.Text = "Komentaras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(14, 123);
            label4.Name = "label4";
            label4.Size = new Size(36, 16);
            label4.TabIndex = 16;
            label4.Text = "Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(14, 151);
            label5.Name = "label5";
            label5.Size = new Size(59, 16);
            label5.TabIndex = 17;
            label5.Text = "Šaltinias";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(14, 95);
            label6.Name = "label6";
            label6.Size = new Size(52, 16);
            label6.TabIndex = 18;
            label6.Text = "Srautas";
            // 
            // srautas
            // 
            srautas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            srautas.FormattingEnabled = true;
            srautas.Items.AddRange(new object[] { "Pramogos", "Atlyginimas", "Kuras", "Maistas", "Sveikata" });
            srautas.Location = new Point(90, 88);
            srautas.Name = "srautas";
            srautas.Size = new Size(200, 23);
            srautas.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(14, 27);
            label7.Name = "label7";
            label7.Size = new Size(41, 16);
            label7.TabIndex = 20;
            label7.Text = "Suma";
            // 
            // suma
            // 
            suma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            suma.Location = new Point(90, 20);
            suma.Name = "suma";
            suma.Size = new Size(200, 23);
            suma.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(399, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(766, 265);
            dataGridView1.TabIndex = 22;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // update
            // 
            update.Location = new Point(14, 444);
            update.Name = "update";
            update.Size = new Size(203, 23);
            update.TabIndex = 23;
            update.Text = "Atnaujinti";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // combox
            // 
            combox.AutoSize = true;
            combox.BackColor = Color.Transparent;
            combox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            combox.ForeColor = Color.Yellow;
            combox.Location = new Point(225, 281);
            combox.Name = "combox";
            combox.Size = new Size(87, 21);
            combox.TabIndex = 24;
            combox.Text = "Prisiminti";
            combox.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(90, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(68, 34);
            listBox1.TabIndex = 25;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // delete
            // 
            delete.Location = new Point(399, 283);
            delete.Name = "delete";
            delete.Size = new Size(149, 23);
            delete.TabIndex = 26;
            delete.Text = "Trinti pasirinkta irasa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(399, 328);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 27;
            label3.Text = "Išlaidos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Yellow;
            label8.Location = new Point(399, 354);
            label8.Name = "label8";
            label8.Size = new Size(60, 17);
            label8.TabIndex = 28;
            label8.Text = "Pajamos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.Yellow;
            label9.Location = new Point(399, 381);
            label9.Name = "label9";
            label9.Size = new Size(49, 17);
            label9.TabIndex = 29;
            label9.Text = "Likutis";
            // 
            // lost
            // 
            lost.AutoSize = true;
            lost.BackColor = Color.Transparent;
            lost.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lost.ForeColor = Color.Yellow;
            lost.Location = new Point(497, 328);
            lost.Name = "lost";
            lost.Size = new Size(33, 17);
            lost.TabIndex = 30;
            lost.Text = "-----";
            // 
            // gain
            // 
            gain.AutoSize = true;
            gain.BackColor = Color.Transparent;
            gain.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            gain.ForeColor = Color.Yellow;
            gain.Location = new Point(497, 354);
            gain.Name = "gain";
            gain.Size = new Size(53, 17);
            gain.TabIndex = 31;
            gain.Text = "+++++";
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.BackColor = Color.Transparent;
            sum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            sum.ForeColor = Color.Yellow;
            sum.Location = new Point(497, 381);
            sum.Name = "sum";
            sum.Size = new Size(53, 17);
            sum.TabIndex = 32;
            sum.Text = "=====";
            // 
            // ataskaitos
            // 
            ataskaitos.Location = new Point(399, 444);
            ataskaitos.Name = "ataskaitos";
            ataskaitos.Size = new Size(75, 23);
            ataskaitos.TabIndex = 33;
            ataskaitos.Text = "PDF";
            ataskaitos.UseVisualStyleBackColor = true;
            ataskaitos.Click += ataskaitos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.classic_main;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1179, 603);
            Controls.Add(ataskaitos);
            Controls.Add(sum);
            Controls.Add(gain);
            Controls.Add(lost);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(delete);
            Controls.Add(listBox1);
            Controls.Add(combox);
            Controls.Add(update);
            Controls.Add(dataGridView1);
            Controls.Add(suma);
            Controls.Add(label7);
            Controls.Add(srautas);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(komentaras);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(saltinis);
            Controls.Add(data);
            Controls.Add(send);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button send;
        private DateTimePicker data;
        private ComboBox saltinis;
        private Button button1;
        private Label label1;
        private TextBox komentaras;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox srautas;
        private Label label7;
        private TextBox suma;
        private DataGridView dataGridView1;
        private Button update;
        private CheckBox combox;
        private ListBox listBox1;
        private Button delete;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label lost;
        private Label gain;
        private Label sum;
        private Button ataskaitos;
        private PictureBox pictureBox1;
    }
}
