namespace FruitBox
{
	// Token: 0x02000068 RID: 104
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_Error : global::System.Windows.Forms.Form
	{
		// Token: 0x06000780 RID: 1920 RVA: 0x00179034 File Offset: 0x00177434
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00179084 File Offset: 0x00177484
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_Error));
			global::FruitBox.GridColumn gridColumn = new global::FruitBox.GridColumn();
			this.Gridex1 = new global::Janus.Windows.GridEX.GridEX();
			this.GridSize1 = new global::FruitBox.GridSize(this.components);
			this.Gridex1.BeginInit();
			this.SuspendLayout();
			this.Gridex1.set_AllowEdit(2);
			this.Gridex1.set_BoundMode(1);
			gridEXLayout.set_LayoutString(componentResourceManager.GetString("Gridex1_DesignTimeLayout.LayoutString"));
			this.Gridex1.set_DesignTimeLayout(gridEXLayout);
			this.Gridex1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Gridex1.set_GroupByBoxVisible(false);
			global::System.Windows.Forms.Control arg_BE_0 = this.Gridex1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			arg_BE_0.Location = location;
			this.Gridex1.Name = "Gridex1";
			this.Gridex1.set_RowHeaders(1);
			global::System.Windows.Forms.Control arg_FC_0 = this.Gridex1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(522, 365);
			arg_FC_0.Size = size;
			this.Gridex1.TabIndex = 11;
			this.Gridex1.set_VisualStyle(6);
			this.GridSize1.Grid = this.Gridex1;
			gridColumn.Name = "Name";
			gridColumn.Size = 100;
			this.GridSize1.GridColumns.AddRange(new global::FruitBox.GridColumn[]
			{
				gridColumn
			});
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(522, 365);
			this.ClientSize = size;
			this.Controls.Add(this.Gridex1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_Error";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "مشاهده خطا";
			this.Gridex1.EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040002E2 RID: 738
		private global::System.ComponentModel.IContainer components;
	}
}
