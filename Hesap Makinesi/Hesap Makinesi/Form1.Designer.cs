namespace Hesap_Makinesi
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
            txtInput = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(88, 77);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(108, 41);
            txtInput.TabIndex = 0;
            txtInput.TextAlign = HorizontalAlignment.Center;
            txtInput.KeyDown += Form1_KeyDown;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(88, 305);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 41);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.ButtonHighlight;
            lblResult.Location = new Point(392, 77);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 2;
            lblResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(392, 305);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 41);
            btnExit.TabIndex = 3;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(667, 450);
            Controls.Add(btnExit);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            KeyPreview = true;
            Name = "Form1";
            Text = "Hesap Makinesi";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCalculate;
        private Label lblResult;
        private Button btnExit;
    }
}
