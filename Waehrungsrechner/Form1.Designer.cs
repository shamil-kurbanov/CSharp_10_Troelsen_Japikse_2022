namespace Waehrungsrechner
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_Euro = new TextBox();
            textBox_Dollar = new TextBox();
            textBox_Kurs = new TextBox();
            bt_end = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 84);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Kurs 1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 148);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Euro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 148);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Dollar";
            // 
            // textBox_Euro
            // 
            textBox_Euro.Location = new Point(57, 193);
            textBox_Euro.Name = "textBox_Euro";
            textBox_Euro.Size = new Size(125, 27);
            textBox_Euro.TabIndex = 3;
            textBox_Euro.KeyUp += textBox_Euro_KeyUp;
            // 
            // textBox_Dollar
            // 
            textBox_Dollar.Location = new Point(324, 193);
            textBox_Dollar.Name = "textBox_Dollar";
            textBox_Dollar.Size = new Size(125, 27);
            textBox_Dollar.TabIndex = 4;
            textBox_Dollar.KeyUp += textBox_Dollar_KeyUp;
            // 
            // textBox_Kurs
            // 
            textBox_Kurs.Location = new Point(296, 81);
            textBox_Kurs.Name = "textBox_Kurs";
            textBox_Kurs.Size = new Size(125, 27);
            textBox_Kurs.TabIndex = 5;
            textBox_Kurs.KeyUp += textBox_Kurs_KeyUp;
            // 
            // bt_end
            // 
            bt_end.Location = new Point(68, 304);
            bt_end.Name = "bt_end";
            bt_end.Size = new Size(94, 29);
            bt_end.TabIndex = 6;
            bt_end.Text = "Beenden";
            bt_end.UseVisualStyleBackColor = true;
            bt_end.Click += bt_end_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_end);
            Controls.Add(textBox_Kurs);
            Controls.Add(textBox_Dollar);
            Controls.Add(textBox_Euro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Euro;
        private TextBox textBox_Dollar;
        private TextBox textBox_Kurs;
        private Button bt_end;
    }
}