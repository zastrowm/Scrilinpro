using LineProcessorApp.Views;

namespace LineProcessorApp
{
	partial class LineProcessorApplication
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.ctlProcessor = new LineProcessorApp.Controls.ProcessingView();
      this.ctlInput = new LineProcessorApp.Views.Input();
      this.ctlOutput = new LineProcessorApp.Views.Output();
      this.menuStrip1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(983, 25);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // btnQuit
      // 
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(97, 22);
      this.btnQuit.Text = "&Quit";
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.ctlProcessor, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 781);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ctlInput);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(3, 394);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.groupBox1.Size = new System.Drawing.Size(485, 383);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Input";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.ctlOutput);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(494, 394);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.groupBox2.Size = new System.Drawing.Size(486, 383);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Output";
      // 
      // ctlProcessor
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.ctlProcessor, 2);
      this.ctlProcessor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctlProcessor.Location = new System.Drawing.Point(3, 4);
      this.ctlProcessor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ctlProcessor.Name = "ctlProcessor";
      this.ctlProcessor.Size = new System.Drawing.Size(977, 382);
      this.ctlProcessor.TabIndex = 0;
      // 
      // ctlInput
      // 
      this.ctlInput.Contents = "Line 1\r\nLine 2\r\nLine 3\r\n";
      this.ctlInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctlInput.Location = new System.Drawing.Point(3, 20);
      this.ctlInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ctlInput.Name = "ctlInput";
      this.ctlInput.Size = new System.Drawing.Size(479, 359);
      this.ctlInput.TabIndex = 0;
      // 
      // ctlOutput
      // 
      this.ctlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctlOutput.Location = new System.Drawing.Point(3, 20);
      this.ctlOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ctlOutput.Name = "ctlOutput";
      this.ctlOutput.Size = new System.Drawing.Size(480, 359);
      this.ctlOutput.TabIndex = 1;
      // 
      // LineProcessorApplication
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(983, 806);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "LineProcessorApplication";
      this.Text = "Line Processor";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnQuit;
		private Input ctlInput;
		private Controls.ProcessingView ctlProcessor;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Output ctlOutput;
	}
}