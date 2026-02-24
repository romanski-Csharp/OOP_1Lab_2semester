namespace OOP_1Lab_5Task
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
            chkHello = new CheckBox();
            chkColor = new CheckBox();
            chkOpacity = new CheckBox();
            btnSuperMega = new Button();
            btnOpacity = new Button();
            btnColor = new Button();
            btnHello = new Button();
            SuspendLayout();
            // 
            // chkHello
            // 
            chkHello.AutoSize = true;
            chkHello.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkHello.Location = new Point(29, 174);
            chkHello.Name = "chkHello";
            chkHello.Size = new Size(363, 27);
            chkHello.TabIndex = 0;
            chkHello.Text = "\"Супермегкнопка\" поглинає \"Hello World\"";
            chkHello.UseVisualStyleBackColor = true;
            chkHello.CheckedChanged += chkHello_CheckedChanged;
            // 
            // chkColor
            // 
            chkColor.AutoSize = true;
            chkColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkColor.Location = new Point(29, 236);
            chkColor.Name = "chkColor";
            chkColor.Size = new Size(317, 27);
            chkColor.TabIndex = 1;
            chkColor.Text = "\"Супермегкнопка\" поглинає \"Колір\"";
            chkColor.UseVisualStyleBackColor = true;
            chkColor.CheckedChanged += chkColor_CheckedChanged;
            // 
            // chkOpacity
            // 
            chkOpacity.AutoSize = true;
            chkOpacity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkOpacity.Location = new Point(29, 303);
            chkOpacity.Name = "chkOpacity";
            chkOpacity.Size = new Size(362, 27);
            chkOpacity.TabIndex = 2;
            chkOpacity.Text = "\"Супермегкнопка\" поглинає \"Прозорість\"";
            chkOpacity.UseVisualStyleBackColor = true;
            chkOpacity.CheckedChanged += chkOpacity_CheckedChanged;
            // 
            // btnSuperMega
            // 
            btnSuperMega.Location = new Point(24, 80);
            btnSuperMega.Name = "btnSuperMega";
            btnSuperMega.Size = new Size(378, 46);
            btnSuperMega.TabIndex = 3;
            btnSuperMega.Text = "Супермегакнопка";
            btnSuperMega.UseVisualStyleBackColor = true;
            btnSuperMega.Click += btnSuperMega_Click;
            // 
            // btnOpacity
            // 
            btnOpacity.Location = new Point(292, 26);
            btnOpacity.Name = "btnOpacity";
            btnOpacity.Size = new Size(110, 29);
            btnOpacity.TabIndex = 4;
            btnOpacity.Text = "Прозорість";
            btnOpacity.UseVisualStyleBackColor = true;
            btnOpacity.Click += btnOpacity_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(159, 26);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(107, 29);
            btnColor.TabIndex = 4;
            btnColor.Text = "Колір";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(24, 26);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(105, 29);
            btnHello.TabIndex = 4;
            btnHello.Text = "Hello World!";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 423);
            Controls.Add(btnHello);
            Controls.Add(btnColor);
            Controls.Add(btnOpacity);
            Controls.Add(chkOpacity);
            Controls.Add(chkColor);
            Controls.Add(chkHello);
            Controls.Add(btnSuperMega);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkHello;
        private CheckBox chkColor;
        private CheckBox chkOpacity;
        private Button btnSuperMega;
        private Button btnOpacity;
        private Button btnColor;
        private Button btnHello;
    }
}
