namespace LineProcessorApp.Controls
{
	partial class ProcessingView
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
			this.pnlHeader = new System.Windows.Forms.TableLayoutPanel();
			this.lblName = new System.Windows.Forms.Label();
			this.lblExpression = new System.Windows.Forms.Label();
			this.lblExample = new System.Windows.Forms.Label();
			this.cboExampleInput = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEvaluate = new System.Windows.Forms.Button();
			this.pnlLines = new System.Windows.Forms.FlowLayoutPanel();
			this.ctlValueLine = new LineProcessorApp.Controls.ProcessingLine();
			this.errExample = new System.Windows.Forms.ErrorProvider(this.components);
			this.timChangeTimer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.pnlLines.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errExample)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.pnlHeader, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.cboExampleInput, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnEvaluate, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.pnlLines, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 247);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pnlHeader
			// 
			this.pnlHeader.AutoSize = true;
			this.pnlHeader.ColumnCount = 4;
			this.tableLayoutPanel1.SetColumnSpan(this.pnlHeader, 3);
			this.pnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
			this.pnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.pnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.pnlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			this.pnlHeader.Controls.Add(this.lblName, 0, 0);
			this.pnlHeader.Controls.Add(this.lblExpression, 1, 0);
			this.pnlHeader.Controls.Add(this.lblExample, 2, 0);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(3, 30);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.RowCount = 1;
			this.pnlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.pnlHeader.Size = new System.Drawing.Size(619, 13);
			this.pnlHeader.TabIndex = 2;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(3, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(186, 13);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name";
			// 
			// lblExpression
			// 
			this.lblExpression.AutoSize = true;
			this.lblExpression.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExpression.Location = new System.Drawing.Point(195, 0);
			this.lblExpression.Name = "lblExpression";
			this.lblExpression.Size = new System.Drawing.Size(186, 13);
			this.lblExpression.TabIndex = 2;
			this.lblExpression.Text = "Expression";
			// 
			// lblExample
			// 
			this.lblExample.AutoSize = true;
			this.lblExample.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExample.Location = new System.Drawing.Point(387, 0);
			this.lblExample.Name = "lblExample";
			this.lblExample.Size = new System.Drawing.Size(186, 13);
			this.lblExample.TabIndex = 3;
			this.lblExample.Text = "Example";
			// 
			// cboExampleInput
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.cboExampleInput, 2);
			this.cboExampleInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboExampleInput.FormattingEnabled = true;
			this.cboExampleInput.Location = new System.Drawing.Point(86, 3);
			this.cboExampleInput.Name = "cboExampleInput";
			this.cboExampleInput.Size = new System.Drawing.Size(536, 21);
			this.cboExampleInput.TabIndex = 0;
			this.cboExampleInput.Text = "Example Text <44>";
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
			// pnlLines
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.pnlLines, 3);
			this.pnlLines.Controls.Add(this.ctlValueLine);
			this.pnlLines.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLines.Location = new System.Drawing.Point(3, 49);
			this.pnlLines.Name = "pnlLines";
			this.pnlLines.Size = new System.Drawing.Size(619, 166);
			this.pnlLines.TabIndex = 4;
			// 
			// ctlValueLine
			// 
			this.ctlValueLine.AutoSize = true;
			this.ctlValueLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ctlValueLine.Error = "";
			this.ctlValueLine.Location = new System.Drawing.Point(0, 0);
			this.ctlValueLine.Margin = new System.Windows.Forms.Padding(0);
			this.ctlValueLine.Name = "ctlValueLine";
			this.ctlValueLine.Size = new System.Drawing.Size(20, 26);
			this.ctlValueLine.TabIndex = 0;
			// 
			// errExample
			// 
			this.errExample.ContainerControl = this;
			// 
			// timChangeTimer
			// 
			this.timChangeTimer.Interval = 500;
			this.timChangeTimer.Tick += new System.EventHandler(this.HandleTextChangedTick);
			// 
			// ProcessingView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ProcessingView";
			this.Size = new System.Drawing.Size(625, 247);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.pnlLines.ResumeLayout(false);
			this.pnlLines.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errExample)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox cboExampleInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel pnlHeader;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblExpression;
		private System.Windows.Forms.Label lblExample;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEvaluate;
		private System.Windows.Forms.ErrorProvider errExample;
		private System.Windows.Forms.FlowLayoutPanel pnlLines;
		private ProcessingLine ctlValueLine;
		private System.Windows.Forms.Timer timChangeTimer;
	}
}
