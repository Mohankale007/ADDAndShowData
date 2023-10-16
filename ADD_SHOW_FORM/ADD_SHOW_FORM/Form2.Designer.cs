namespace ADD_SHOW_FORM
{
    partial class Form2
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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 55);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "ADD INFORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 104);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "NAME :-";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 148);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 1;
            label3.Text = "ADDRESS:-";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 140);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 23);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 193);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 1;
            label4.Text = "GENDER :-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 235);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 1;
            label5.Text = "CONTACT NUMBER :-";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 227);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 23);
            textBox4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 280);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 1;
            label6.Text = "CITY:-";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(177, 277);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(277, 23);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(177, 329);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 5;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MALE", "FEMALE", "OTHER" });
            comboBox1.Location = new Point(177, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(275, 23);
            comboBox1.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 456);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Button button1;
        private ComboBox comboBox1;
    }
}