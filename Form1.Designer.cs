namespace ООП_ПР4_приклад
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
            textBoxProfession = new TextBox();
            textBoxAge = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            listBoxResult = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxProfession);
            groupBox1.Controls.Add(textBoxAge);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            // 
            // textBoxProfession
            // 
            textBoxProfession.Location = new Point(100, 115);
            textBoxProfession.Name = "textBoxProfession";
            textBoxProfession.Size = new Size(189, 27);
            textBoxProfession.TabIndex = 3;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(100, 73);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(189, 27);
            textBoxAge.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(189, 27);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 100);
            label1.TabIndex = 0;
            label1.Text = "Ім'я:\r\n\r\nВік:\r\n\r\nПрофесія:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.Location = new Point(12, 179);
            button1.Name = "button1";
            button1.Size = new Size(310, 30);
            button1.TabIndex = 1;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.Location = new Point(342, 23);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(368, 184);
            listBoxResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 227);
            Controls.Add(listBoxResult);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Перелік";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxProfession;
        private TextBox textBoxAge;
        private Button button1;
        private ListBox listBoxResult;
    }
}
