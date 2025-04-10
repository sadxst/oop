namespace ООП_ПР4_завдання
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
            groupBox1 = new GroupBox();
            textBoxAthletesCount = new TextBox();
            textBoxMedalsCount = new TextBox();
            textBoxCountry = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxAthletesCount);
            groupBox1.Controls.Add(textBoxMedalsCount);
            groupBox1.Controls.Add(textBoxCountry);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            // 
            // textBoxAthletesCount
            // 
            textBoxAthletesCount.Location = new Point(144, 113);
            textBoxAthletesCount.Name = "textBoxAthletesCount";
            textBoxAthletesCount.Size = new Size(193, 27);
            textBoxAthletesCount.TabIndex = 3;
            // 
            // textBoxMedalsCount
            // 
            textBoxMedalsCount.Location = new Point(144, 71);
            textBoxMedalsCount.Name = "textBoxMedalsCount";
            textBoxMedalsCount.Size = new Size(193, 27);
            textBoxMedalsCount.TabIndex = 2;
            textBoxMedalsCount.TextChanged += textBoxMedalsCount_TextChanged;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(144, 29);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(193, 27);
            textBoxCountry.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(132, 120);
            label1.TabIndex = 0;
            label1.Text = "Країна:\r\n\r\nК-ть медалей:\r\n\r\nК-ть спортсменів:\r\n\r\n";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(392, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(365, 104);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(392, 135);
            button1.Name = "button1";
            button1.Size = new Size(365, 39);
            button1.TabIndex = 2;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 186);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Олімпіадний залік";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxAthletesCount;
        private TextBox textBoxMedalsCount;
        private TextBox textBoxCountry;
        private Label label1;
        private ListBox listBox1;
        private Button button1;
    }
}
