namespace CodeChum
{
    partial class Label1
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
            HelloWorldLabel = new Label();
            SuspendLayout();
            // 
            // HelloWorldLabel
            // 
            HelloWorldLabel.AutoSize = true;
            HelloWorldLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            HelloWorldLabel.Location = new Point(114, 42);
            HelloWorldLabel.Name = "HelloWorldLabel";
            HelloWorldLabel.Size = new Size(199, 45);
            HelloWorldLabel.TabIndex = 0;
            HelloWorldLabel.Text = "Hello World!";
            // 
            // HelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 137);
            Controls.Add(HelloWorldLabel);
            Name = "HelloWorld";
            Text = "HelloWorld";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloWorldLabel;
    }
}
