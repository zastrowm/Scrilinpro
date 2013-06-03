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
      this.components = new System.ComponentModel.Container();
      this.pnlLayout = new System.Windows.Forms.TableLayoutPanel();
      this.txtValue = new System.Windows.Forms.TextBox();
      this.txtExpression = new System.Windows.Forms.TextBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.errExpression = new System.Windows.Forms.ErrorProvider(this.components);
      this.pnlLayout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errExpression)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlLayout
      // 
      this.pnlLayout.AutoSize = true;
      this.pnlLayout.ColumnCount = 4;
      this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.pnlLayout.Controls.Add(this.txtValue, 2, 0);
      this.pnlLayout.Controls.Add(this.txtExpression, 1, 0);
      this.pnlLayout.Controls.Add(this.txtName, 0, 0);
      this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlLayout.Location = new System.Drawing.Point(0, 0);
      this.pnlLayout.Margin = new System.Windows.Forms.Padding(0);
      this.pnlLayout.Name = "pnlLayout";
      this.pnlLayout.RowCount = 1;
      this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.pnlLayout.Size = new System.Drawing.Size(326, 25);
      this.pnlLayout.TabIndex = 0;
      // 
      // txtValue
      // 
      this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValue.Location = new System.Drawing.Point(205, 1);
      this.txtValue.Margin = new System.Windows.Forms.Padding(1);
      this.txtValue.Name = "txtValue";
      this.txtValue.ReadOnly = true;
      this.txtValue.Size = new System.Drawing.Size(100, 23);
      this.txtValue.TabIndex = 3;
      // 
      // txtExpression
      // 
      this.txtExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtExpression.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtExpression.Location = new System.Drawing.Point(103, 1);
      this.txtExpression.Margin = new System.Windows.Forms.Padding(1);
      this.txtExpression.Name = "txtExpression";
      this.txtExpression.Size = new System.Drawing.Size(100, 23);
      this.txtExpression.TabIndex = 2;
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtName.Location = new System.Drawing.Point(1, 1);
      this.txtName.Margin = new System.Windows.Forms.Padding(1);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(100, 23);
      this.txtName.TabIndex = 1;
      // 
      // errExpression
      // 
      this.errExpression.ContainerControl = this;
      // 
      // ProcessingLine
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.Controls.Add(this.pnlLayout);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "ProcessingLine";
      this.Size = new System.Drawing.Size(326, 25);
      this.pnlLayout.ResumeLayout(false);
      this.pnlLayout.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errExpression)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel pnlLayout;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.TextBox txtExpression;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ErrorProvider errExpression;

	}
}
