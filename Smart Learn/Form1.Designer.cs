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
            btnStudy = new Button();
            lstSets = new ListBox();
            pnlStudy = new Panel();
            btnAnswer = new Button();
            txtAnswer = new TextBox();
            rtxtDef = new RichTextBox();
            pnlCorI = new Panel();
            lblCorI = new Label();
            pnlTest.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlStudy.SuspendLayout();
            pnlCorI.SuspendLayout();
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
            pnlMain.Controls.Add(btnStudy);
            pnlMain.Controls.Add(lstSets);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(799, 449);
            pnlMain.TabIndex = 3;
            // 
            // btnStudy
            // 
            btnStudy.Location = new Point(12, 12);
            btnStudy.Name = "btnStudy";
            btnStudy.Size = new Size(105, 39);
            btnStudy.TabIndex = 1;
            btnStudy.Text = "Study";
            btnStudy.UseVisualStyleBackColor = true;
            btnStudy.Click += btnStudy_Click;
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
            // pnlStudy
            // 
            pnlStudy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlStudy.Controls.Add(btnAnswer);
            pnlStudy.Controls.Add(txtAnswer);
            pnlStudy.Controls.Add(rtxtDef);
            pnlStudy.Location = new Point(0, 0);
            pnlStudy.Name = "pnlStudy";
            pnlStudy.Size = new Size(799, 449);
            pnlStudy.TabIndex = 2;
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(692, 404);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(96, 34);
            btnAnswer.TabIndex = 3;
            btnAnswer.Text = "Answer";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer.Location = new Point(12, 404);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(674, 34);
            txtAnswer.TabIndex = 2;
            // 
            // rtxtDef
            // 
            rtxtDef.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtDef.Location = new Point(12, 12);
            rtxtDef.Name = "rtxtDef";
            rtxtDef.Size = new Size(776, 386);
            rtxtDef.TabIndex = 1;
            rtxtDef.Text = "";
            // 
            // pnlCorI
            // 
            pnlCorI.Controls.Add(lblCorI);
            pnlCorI.Location = new Point(0, 0);
            pnlCorI.Name = "pnlCorI";
            pnlCorI.Size = new Size(799, 449);
            pnlCorI.TabIndex = 4;
            // 
            // lblCorI
            // 
            lblCorI.Dock = DockStyle.Fill;
            lblCorI.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorI.Location = new Point(0, 0);
            lblCorI.Name = "lblCorI";
            lblCorI.Size = new Size(799, 449);
            lblCorI.TabIndex = 0;
            lblCorI.Text = "label1";
            lblCorI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlStudy);
            Controls.Add(pnlCorI);
            Controls.Add(pnlMain);
            Controls.Add(pnlTest);
            Name = "Form1";
            Text = "Form1";
            pnlTest.ResumeLayout(false);
            pnlTest.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlStudy.ResumeLayout(false);
            pnlStudy.PerformLayout();
            pnlCorI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private Button btnRead;
        private TextBox txtTest;
        private Panel pnlTest;
        private Panel pnlMain;
        private ListBox lstSets;
        private Button btnStudy;
        private Panel pnlStudy;
        private Button btnAnswer;
        private TextBox txtAnswer;
        private RichTextBox rtxtDef;
        private Panel pnlCorI;
        private Label lblCorI;
    }
}