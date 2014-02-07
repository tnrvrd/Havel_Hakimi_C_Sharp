namespace Havel_Hakimi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumberOfVertices = new System.Windows.Forms.TextBox();
            this.btnCreateVertices = new System.Windows.Forms.Button();
            this.dgvVertices = new System.Windows.Forms.DataGridView();
            this.btnCalculateResult = new System.Windows.Forms.Button();
            this.lbStepByStep = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havelHakimiAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVertices)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Vertices";
            // 
            // tbNumberOfVertices
            // 
            this.tbNumberOfVertices.Location = new System.Drawing.Point(117, 35);
            this.tbNumberOfVertices.MaxLength = 2;
            this.tbNumberOfVertices.Name = "tbNumberOfVertices";
            this.tbNumberOfVertices.Size = new System.Drawing.Size(47, 20);
            this.tbNumberOfVertices.TabIndex = 1;
            this.tbNumberOfVertices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumberOfVertices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberOfVertices_KeyPress);
            // 
            // btnCreateVertices
            // 
            this.btnCreateVertices.Location = new System.Drawing.Point(171, 31);
            this.btnCreateVertices.Name = "btnCreateVertices";
            this.btnCreateVertices.Size = new System.Drawing.Size(107, 23);
            this.btnCreateVertices.TabIndex = 2;
            this.btnCreateVertices.Text = "Create Vertices";
            this.btnCreateVertices.UseVisualStyleBackColor = true;
            this.btnCreateVertices.Click += new System.EventHandler(this.btnCreateVertices_Click);
            // 
            // dgvVertices
            // 
            this.dgvVertices.AllowUserToAddRows = false;
            this.dgvVertices.AllowUserToDeleteRows = false;
            this.dgvVertices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVertices.Location = new System.Drawing.Point(15, 58);
            this.dgvVertices.Name = "dgvVertices";
            this.dgvVertices.Size = new System.Drawing.Size(263, 262);
            this.dgvVertices.TabIndex = 3;
            // 
            // btnCalculateResult
            // 
            this.btnCalculateResult.Enabled = false;
            this.btnCalculateResult.Location = new System.Drawing.Point(171, 326);
            this.btnCalculateResult.Name = "btnCalculateResult";
            this.btnCalculateResult.Size = new System.Drawing.Size(107, 23);
            this.btnCalculateResult.TabIndex = 5;
            this.btnCalculateResult.Text = "Calculate Result";
            this.btnCalculateResult.UseVisualStyleBackColor = true;
            this.btnCalculateResult.Click += new System.EventHandler(this.btnCalculateResult_Click);
            // 
            // lbStepByStep
            // 
            this.lbStepByStep.FormattingEnabled = true;
            this.lbStepByStep.Location = new System.Drawing.Point(284, 58);
            this.lbStepByStep.Name = "lbStepByStep";
            this.lbStepByStep.Size = new System.Drawing.Size(494, 264);
            this.lbStepByStep.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.havelHakimiAlgorithmToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // havelHakimiAlgorithmToolStripMenuItem
            // 
            this.havelHakimiAlgorithmToolStripMenuItem.Name = "havelHakimiAlgorithmToolStripMenuItem";
            this.havelHakimiAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.havelHakimiAlgorithmToolStripMenuItem.Text = "Havel Hakimi Algorithm";
            this.havelHakimiAlgorithmToolStripMenuItem.Click += new System.EventHandler(this.havelHakimiAlgorithmToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 359);
            this.Controls.Add(this.lbStepByStep);
            this.Controls.Add(this.btnCalculateResult);
            this.Controls.Add(this.dgvVertices);
            this.Controls.Add(this.btnCreateVertices);
            this.Controls.Add(this.tbNumberOfVertices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Havel Hakimi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVertices)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumberOfVertices;
        private System.Windows.Forms.Button btnCreateVertices;
        private System.Windows.Forms.DataGridView dgvVertices;
        private System.Windows.Forms.Button btnCalculateResult;
        private System.Windows.Forms.ListBox lbStepByStep;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havelHakimiAlgorithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

