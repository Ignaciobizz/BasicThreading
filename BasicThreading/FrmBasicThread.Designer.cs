namespace BasicThreading
{
    partial class FrmBasicThread
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
            lblMessage = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(59, 56);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(231, 30);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "-Before starting thread-";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(129, 131);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 203);
            Controls.Add(btnRun);
            Controls.Add(lblMessage);
            Name = "FrmBasicThread";
            Text = "BasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button btnRun;
    }
}
