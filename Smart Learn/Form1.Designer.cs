namespace SmartLearn
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
            btnTest = new Button();
            btnRead = new Button();
            txtTest = new TextBox();
            pnlTest = new Panel();
            pnlMain = new Panel();
            lstSets = new ListBox();
            pnlTest.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(4, 3);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test Button";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(4, 32);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 1;
            btnRead.Text = "Read Data";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtTest
            // 
            txtTest.Location = new Point(85, 4);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(527, 23);
            txtTest.TabIndex = 2;
            // 
            // pnlTest
            // 
            pnlTest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTest.Controls.Add(txtTest);
            pnlTest.Controls.Add(btnTest);
            pnlTest.Controls.Add(btnRead);
            pnlTest.Location = new Point(0, 0);
            pnlTest.Name = "pnlTest";
            pnlTest.Size = new Size(799, 449);
            pnlTest.TabIndex = 3;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.Controls.Add(lstSets);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(799, 449);
            pnlMain.TabIndex = 3;
            // 
            // lstSets
            // 
            lstSets.FormattingEnabled = true;
            lstSets.ItemHeight = 15;
            lstSets.Location = new Point(12, 57);
            lstSets.Name = "lstSets";
            lstSets.Size = new Size(776, 379);
            lstSets.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(pnlTest);
            Name = "Form1";
            Text = "Form1";
            pnlTest.ResumeLayout(false);
            pnlTest.PerformLayout();
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private Button btnRead;
        private TextBox txtTest;
        private Panel pnlTest;
        private Panel pnlMain;
        private ListBox lstSets;
    }
}