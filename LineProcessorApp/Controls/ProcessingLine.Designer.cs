namespace LineProcessorApp.Controls
{
	partial class ProcessingLine
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
			this.pnlLayout = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.splNameExpression = new System.Windows.Forms.Splitter();
			this.splExpressionButtons = new System.Windows.Forms.Splitter();
			this.pnlLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlLayout
			// 
			this.pnlLayout.ColumnCount = 7;
			this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlLayout.Controls.Add(this.textBox1, 0, 1);
			this.pnlLayout.Controls.Add(this.label1, 0, 0);
			this.pnlLayout.Controls.Add(this.label2, 2, 0);
			this.pnlLayout.Controls.Add(this.label3, 6, 0);
			this.pnlLayout.Controls.Add(this.textBox2, 2, 1);
			this.pnlLayout.Controls.Add(this.button1, 4, 1);
			this.pnlLayout.Controls.Add(this.button2, 5, 1);
			this.pnlLayout.Controls.Add(this.textBox3, 6, 1);
			this.pnlLayout.Controls.Add(this.splNameExpression, 1, 0);
			this.pnlLayout.Controls.Add(this.splExpressionButtons, 3, 0);
			this.pnlLayout.Location = new System.Drawing.Point(0, 0);
			this.pnlLayout.Name = "pnlLayout";
			this.pnlLayout.RowCount = 3;
			this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.pnlLayout.Size = new System.Drawing.Size(604, 179);
			this.pnlLayout.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(246, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(275, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Expression";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(587, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Example";
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(275, 23);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(246, 20);
			this.textBox2.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(547, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(14, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "O";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(567, 23);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(14, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(587, 23);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(14, 20);
			this.textBox3.TabIndex = 7;
			// 
			// splNameExpression
			// 
			this.splNameExpression.Location = new System.Drawing.Point(255, 3);
			this.splNameExpression.Name = "splNameExpression";
			this.pnlLayout.SetRowSpan(this.splNameExpression, 3);
			this.splNameExpression.Size = new System.Drawing.Size(3, 173);
			this.splNameExpression.TabIndex = 8;
			this.splNameExpression.TabStop = false;
			// 
			// splExpressionButtons
			// 
			this.splExpressionButtons.Location = new System.Drawing.Point(527, 3);
			this.splExpressionButtons.Name = "splExpressionButtons";
			this.pnlLayout.SetRowSpan(this.splExpressionButtons, 3);
			this.splExpressionButtons.Size = new System.Drawing.Size(3, 173);
			this.splExpressionButtons.TabIndex = 9;
			this.splExpressionButtons.TabStop = false;
			// 
			// ProcessingLine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlLayout);
			this.Name = "ProcessingLine";
			this.Size = new System.Drawing.Size(638, 251);
			this.pnlLayout.ResumeLayout(false);
			this.pnlLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel pnlLayout;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Splitter splNameExpression;
		private System.Windows.Forms.Splitter splExpressionButtons;
	}
}
