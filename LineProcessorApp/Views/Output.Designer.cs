namespace LineProcessorApp.Views
{
	partial class Output
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnCopyToClipboard = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.txtOutput, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCopyToClipboard, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 256);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// txtOutput
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.txtOutput, 3);
			this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutput.Location = new System.Drawing.Point(3, 32);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(338, 221);
			this.txtOutput.TabIndex = 0;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(3, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnCopyToClipboard
			// 
			this.btnCopyToClipboard.AutoSize = true;
			this.btnCopyToClipboard.Location = new System.Drawing.Point(241, 3);
			this.btnCopyToClipboard.MinimumSize = new System.Drawing.Size(75, 23);
			this.btnCopyToClipboard.Name = "btnCopyToClipboard";
			this.btnCopyToClipboard.Size = new System.Drawing.Size(100, 23);
			this.btnCopyToClipboard.TabIndex = 2;
			this.btnCopyToClipboard.Text = "Copy to Clipboard";
			this.btnCopyToClipboard.UseVisualStyleBackColor = true;
			this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
			// 
			// Output
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Output";
			this.Size = new System.Drawing.Size(344, 256);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnCopyToClipboard;
	}
}
