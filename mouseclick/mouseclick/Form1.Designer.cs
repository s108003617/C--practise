namespace mouseclick
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
            timeslabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // timeslabel
            // 
            timeslabel.AutoSize = true;
            timeslabel.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            timeslabel.Location = new Point(79, 61);
            timeslabel.Name = "timeslabel";
            timeslabel.Size = new Size(218, 35);
            timeslabel.TabIndex = 0;
            timeslabel.Text = "你已經按了... 0下";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(121, 143);
            button1.Name = "button1";
            button1.Size = new Size(118, 62);
            button1.TabIndex = 1;
            button1.Text = "按我";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(123, 242);
            button2.Name = "button2";
            button2.Size = new Size(116, 71);
            button2.TabIndex = 2;
            button2.Text = "重設";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 364);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(timeslabel);
            Name = "Form1";
            Text = "按鈕點擊次數記錄";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeslabel;
        private Button button1;
        private Button button2;
    }
}