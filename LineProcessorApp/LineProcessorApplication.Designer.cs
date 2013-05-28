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
			this.ctlTabs = new System.Windows.Forms.TabControl();
			this.tabInput = new System.Windows.Forms.TabPage();
			this.ctlInput = new LineProcessorApp.Controls.Input();
			this.tabProcessing = new System.Windows.Forms.TabPage();
			this.ctlProcessor = new LineProcessorApp.Controls.Processing();
			this.tabOutput = new System.Windows.Forms.TabPage();
			this.menuStrip1.SuspendLayout();
			this.ctlTabs.SuspendLayout();
			this.tabInput.SuspendLayout();
			this.tabProcessing.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(997, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// btnQuit
			// 
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(97, 22);
			this.btnQuit.Text = "&Quit";
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// ctlTabs
			// 
			this.ctlTabs.Controls.Add(this.tabInput);
			this.ctlTabs.Controls.Add(this.tabProcessing);
			this.ctlTabs.Controls.Add(this.tabOutput);
			this.ctlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctlTabs.Location = new System.Drawing.Point(0, 24);
			this.ctlTabs.Name = "ctlTabs";
			this.ctlTabs.SelectedIndex = 0;
			this.ctlTabs.Size = new System.Drawing.Size(997, 632);
			this.ctlTabs.TabIndex = 1;
			this.ctlTabs.SelectedIndexChanged += new System.EventHandler(this.ctlTabs_SelectedIndexChanged);
			// 
			// tabInput
			// 
			this.tabInput.Controls.Add(this.ctlInput);
			this.tabInput.Location = new System.Drawing.Point(4, 22);
			this.tabInput.Name = "tabInput";
			this.tabInput.Padding = new System.Windows.Forms.Padding(3);
			this.tabInput.Size = new System.Drawing.Size(989, 606);
			this.tabInput.TabIndex = 0;
			this.tabInput.Text = "Input";
			this.tabInput.UseVisualStyleBackColor = true;
			// 
			// ctlInput
			// 
			this.ctlInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctlInput.Location = new System.Drawing.Point(3, 3);
			this.ctlInput.Name = "ctlInput";
			this.ctlInput.Size = new System.Drawing.Size(983, 600);
			this.ctlInput.TabIndex = 0;
			// 
			// tabProcessing
			// 
			this.tabProcessing.Controls.Add(this.ctlProcessor);
			this.tabProcessing.Location = new System.Drawing.Point(4, 22);
			this.tabProcessing.Name = "tabProcessing";
			this.tabProcessing.Padding = new System.Windows.Forms.Padding(3);
			this.tabProcessing.Size = new System.Drawing.Size(989, 606);
			this.tabProcessing.TabIndex = 1;
			this.tabProcessing.Text = "Processing";
			this.tabProcessing.UseVisualStyleBackColor = true;
			// 
			// ctlProcessor
			// 
			this.ctlProcessor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctlProcessor.Lines = null;
			this.ctlProcessor.Location = new System.Drawing.Point(3, 3);
			this.ctlProcessor.Name = "ctlProcessor";
			this.ctlProcessor.Size = new System.Drawing.Size(983, 600);
			this.ctlProcessor.TabIndex = 0;
			// 
			// tabOutput
			// 
			this.tabOutput.Location = new System.Drawing.Point(4, 22);
			this.tabOutput.Name = "tabOutput";
			this.tabOutput.Padding = new System.Windows.Forms.Padding(3);
			this.tabOutput.Size = new System.Drawing.Size(989, 606);
			this.tabOutput.TabIndex = 2;
			this.tabOutput.Text = "tabOutput";
			this.tabOutput.UseVisualStyleBackColor = true;
			// 
			// LineProcessorApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 656);
			this.Controls.Add(this.ctlTabs);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "LineProcessorApplication";
			this.Text = "Line Processor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ctlTabs.ResumeLayout(false);
			this.tabInput.ResumeLayout(false);
			this.tabProcessing.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnQuit;
		private System.Windows.Forms.TabControl ctlTabs;
		private System.Windows.Forms.TabPage tabInput;
		private System.Windows.Forms.TabPage tabProcessing;
		private System.Windows.Forms.TabPage tabOutput;
		private Controls.Input ctlInput;
		private Controls.Processing ctlProcessor;
	}
}