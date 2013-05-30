using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessorApp.Views
{
	partial class Input
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
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnClipboard = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnLoad, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnClipboard, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 248);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// txtInput
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.txtInput, 3);
			this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInput.Location = new System.Drawing.Point(3, 32);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(305, 213);
			this.txtInput.TabIndex = 0;
			this.txtInput.Text = "Line 1\r\nLine 2\r\nLine 3\r\n";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(140, 3);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load...";
			this.btnLoad.UseVisualStyleBackColor = true;
			// 
			// btnClipboard
			// 
			this.btnClipboard.AutoSize = true;
			this.btnClipboard.Location = new System.Drawing.Point(221, 3);
			this.btnClipboard.Name = "btnClipboard";
			this.btnClipboard.Size = new System.Drawing.Size(87, 23);
			this.btnClipboard.TabIndex = 2;
			this.btnClipboard.Text = "From Clipboard";
			this.btnClipboard.UseVisualStyleBackColor = true;
			// 
			// Input
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Input";
			this.Size = new System.Drawing.Size(311, 248);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnClipboard;
	}
}
