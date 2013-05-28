namespace LineProcessorApp.Controls
{
	partial class Processing
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
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pnlRows = new System.Windows.Forms.TableLayoutPanel();
			this.txtInputName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtExpression = new System.Windows.Forms.TextBox();
			this.txtExample = new System.Windows.Forms.TextBox();
			this.txt1Name = new System.Windows.Forms.TextBox();
			this.txt1Expression = new System.Windows.Forms.TextBox();
			this.txt1Example = new System.Windows.Forms.TextBox();
			this.cboExampleInput = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEvaluate = new System.Windows.Forms.Button();
			this.errExample = new System.Windows.Forms.ErrorProvider(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.pnlRows.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errExample)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.pnlRows, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.cboExampleInput, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnEvaluate, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 247);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pnlRows
			// 
			this.pnlRows.AutoSize = true;
			this.pnlRows.ColumnCount = 4;
			this.tableLayoutPanel1.SetColumnSpan(this.pnlRows, 3);
			this.pnlRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
			this.pnlRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.pnlRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.pnlRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlRows.Controls.Add(this.txtInputName, 0, 1);
			this.pnlRows.Controls.Add(this.label2, 0, 0);
			this.pnlRows.Controls.Add(this.label3, 1, 0);
			this.pnlRows.Controls.Add(this.label4, 2, 0);
			this.pnlRows.Controls.Add(this.txtExpression, 1, 1);
			this.pnlRows.Controls.Add(this.txtExample, 2, 1);
			this.pnlRows.Controls.Add(this.txt1Name, 0, 2);
			this.pnlRows.Controls.Add(this.txt1Expression, 1, 2);
			this.pnlRows.Controls.Add(this.txt1Example, 2, 2);
			this.pnlRows.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRows.Location = new System.Drawing.Point(3, 30);
			this.pnlRows.Name = "pnlRows";
			this.pnlRows.RowCount = 3;
			this.pnlRows.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.pnlRows.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.pnlRows.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.pnlRows.Size = new System.Drawing.Size(619, 65);
			this.pnlRows.TabIndex = 2;
			// 
			// txtInputName
			// 
			this.txtInputName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtInputName.Location = new System.Drawing.Point(3, 16);
			this.txtInputName.Name = "txtInputName";
			this.txtInputName.ReadOnly = true;
			this.txtInputName.Size = new System.Drawing.Size(193, 20);
			this.txtInputName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(202, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Expression";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(401, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Example";
			// 
			// txtExpression
			// 
			this.txtExpression.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtExpression.Location = new System.Drawing.Point(202, 16);
			this.txtExpression.Name = "txtExpression";
			this.txtExpression.ReadOnly = true;
			this.txtExpression.Size = new System.Drawing.Size(193, 20);
			this.txtExpression.TabIndex = 4;
			// 
			// txtExample
			// 
			this.txtExample.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtExample.Location = new System.Drawing.Point(401, 16);
			this.txtExample.Name = "txtExample";
			this.txtExample.ReadOnly = true;
			this.txtExample.Size = new System.Drawing.Size(193, 20);
			this.txtExample.TabIndex = 7;
			// 
			// txt1Name
			// 
			this.txt1Name.Dock = System.Windows.Forms.DockStyle.Top;
			this.txt1Name.Location = new System.Drawing.Point(3, 42);
			this.txt1Name.Name = "txt1Name";
			this.txt1Name.Size = new System.Drawing.Size(193, 20);
			this.txt1Name.TabIndex = 8;
			// 
			// txt1Expression
			// 
			this.txt1Expression.Dock = System.Windows.Forms.DockStyle.Top;
			this.txt1Expression.Location = new System.Drawing.Point(202, 42);
			this.txt1Expression.Name = "txt1Expression";
			this.txt1Expression.Size = new System.Drawing.Size(193, 20);
			this.txt1Expression.TabIndex = 9;
			// 
			// txt1Example
			// 
			this.txt1Example.Dock = System.Windows.Forms.DockStyle.Top;
			this.txt1Example.Location = new System.Drawing.Point(401, 42);
			this.txt1Example.Name = "txt1Example";
			this.txt1Example.ReadOnly = true;
			this.txt1Example.Size = new System.Drawing.Size(193, 20);
			this.txt1Example.TabIndex = 10;
			// 
			// cboExampleInput
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.cboExampleInput, 2);
			this.cboExampleInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboExampleInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboExampleInput.FormattingEnabled = true;
			this.cboExampleInput.Location = new System.Drawing.Point(86, 3);
			this.cboExampleInput.Name = "cboExampleInput";
			this.cboExampleInput.Size = new System.Drawing.Size(536, 21);
			this.cboExampleInput.TabIndex = 0;
			this.cboExampleInput.SelectedIndexChanged += new System.EventHandler(this.cboExampleInput_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Example Input:";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.AutoSize = true;
			this.btnAdd.Location = new System.Drawing.Point(547, 221);
			this.btnAdd.MinimumSize = new System.Drawing.Size(75, 0);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add Row";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEvaluate
			// 
			this.btnEvaluate.Location = new System.Drawing.Point(3, 221);
			this.btnEvaluate.Name = "btnEvaluate";
			this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
			this.btnEvaluate.TabIndex = 3;
			this.btnEvaluate.Text = "Evaluate";
			this.btnEvaluate.UseVisualStyleBackColor = true;
			this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
			// 
			// errExample
			// 
			this.errExample.ContainerControl = this;
			// 
			// Processing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Processing";
			this.Size = new System.Drawing.Size(625, 247);
			this.Load += new System.EventHandler(this.Processing_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.pnlRows.ResumeLayout(false);
			this.pnlRows.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errExample)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox cboExampleInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel pnlRows;
		private System.Windows.Forms.TextBox txtInputName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtExpression;
		private System.Windows.Forms.TextBox txtExample;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txt1Name;
		private System.Windows.Forms.TextBox txt1Expression;
		private System.Windows.Forms.TextBox txt1Example;
		private System.Windows.Forms.Button btnEvaluate;
		private System.Windows.Forms.ErrorProvider errExample;
	}
}
