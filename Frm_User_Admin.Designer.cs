namespace FruitBox
{
	// Token: 0x02000083 RID: 131
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Frm_User_Admin : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B41 RID: 2881 RVA: 0x00199BD8 File Offset: 0x00197FD8
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

		// Token: 0x06000B42 RID: 2882 RVA: 0x00199C28 File Offset: 0x00198028
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Janus.Windows.GridEX.GridEXLayout gridEXLayout = new global::Janus.Windows.GridEX.GridEXLayout();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FruitBox.Frm_User_Admin));
			global::Janus.Windows.ButtonBar.ButtonBarGroup buttonBarGroup = new global::Janus.Windows.ButtonBar.ButtonBarGroup();
			this.UiGroupBox1 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.UiGroupBox2 = new global::Janus.Windows.EditControls.UIGroupBox();
			this.GridEX1 = new global::Janus.Windows.GridEX.GridEX();
			this.EditBox2 = new global::FruitBox.EditBox(this.components);
			this.EditBox1 = new global::FruitBox.EditBox(this.components);
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ButtonBar1 = new global::Janus.Windows.ButtonBar.ButtonBar();
			this.Bar1 = new global::DevComponents.DotNetBar.Bar();
			this.ButtonItem1 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3 = new global::DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem4 = new global::DevComponents.DotNetBar.ButtonItem();
			this.UiGroupBox1.BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.UiGroupBox2.BeginInit();
			this.UiGroupBox2.SuspendLayout();
			this.GridEX1.BeginInit();
			this.ButtonBar1.BeginInit();
			this.Bar1.BeginInit();
			this.SuspendLayout();
			this.UiGroupBox1.set_BackgroundStyle(3);
			this.UiGroupBox1.Controls.Add(this.UiGroupBox2);
			this.UiGroupBox1.Controls.Add(this.ButtonBar1);
			this.UiGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UiGroupBox1.set_FrameStyle(0);
			global::System.Windows.Forms.Control arg_193_0 = this.UiGroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 41);
			arg_193_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			global::System.Windows.Forms.Control arg_1C4_0 = this.UiGroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(961, 454);
			arg_1C4_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.set_VisualStyle(6);
			this.UiGroupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.UiGroupBox2.set_BackgroundStyle(3);
			this.UiGroupBox2.Controls.Add(this.GridEX1);
			this.UiGroupBox2.Controls.Add(this.EditBox2);
			this.UiGroupBox2.Controls.Add(this.EditBox1);
			this.UiGroupBox2.Controls.Add(this.Label2);
			this.UiGroupBox2.Controls.Add(this.Label1);
			global::System.Windows.Forms.Control arg_284_0 = this.UiGroupBox2;
			location = new global::System.Drawing.Point(3, 3);
			arg_284_0.Location = location;
			this.UiGroupBox2.Name = "UiGroupBox2";
			global::System.Windows.Forms.Control arg_2B5_0 = this.UiGroupBox2;
			size = new global::System.Drawing.Size(834, 448);
			arg_2B5_0.Size = size;
			this.UiGroupBox2.TabIndex = 0;
			this.UiGroupBox2.set_VisualStyle(6);
			this.GridEX1.set_AllowEdit(2);
			this.GridEX1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GridEX1.set_ColumnHeaders(2);
			gridEXLayout.set_LayoutString(componentResourceManager.GetString("GridEX1_DesignTimeLayout.LayoutString"));
			this.GridEX1.set_DesignTimeLayout(gridEXLayout);
			this.GridEX1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.GridEX1.set_GridLineStyle(2);
			this.GridEX1.set_GroupByBoxVisible(false);
			this.GridEX1.set_GroupExpandBoxStyle(1);
			this.GridEX1.set_HierarchicalExpandBoxStyle(1);
			global::System.Windows.Forms.Control arg_385_0 = this.GridEX1;
			location = new global::System.Drawing.Point(6, 96);
			arg_385_0.Location = location;
			this.GridEX1.Name = "GridEX1";
			this.GridEX1.set_OfficeColorScheme(1);
			this.GridEX1.set_RowHeaders(1);
			global::System.Windows.Forms.Control arg_3D0_0 = this.GridEX1;
			size = new global::System.Drawing.Size(822, 346);
			arg_3D0_0.Size = size;
			this.GridEX1.TabIndex = 2;
			this.GridEX1.set_VisualStyle(6);
			this.EditBox2.AcceptEnter = true;
			this.EditBox2.AllowEdit = true;
			this.EditBox2.AllowNew = true;
			this.EditBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox2.set_ButtonFont(new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178));
			this.EditBox2.FocusColor = true;
			this.EditBox2.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_48D_0 = this.EditBox2;
			location = new global::System.Drawing.Point(487, 54);
			arg_48D_0.Location = location;
			this.EditBox2.Name = "EditBox2";
			this.EditBox2.Nullable = false;
			this.EditBox2.NullToolTipText = "لطفا گذرواژه را وارد نمائید";
			this.EditBox2.set_ShortcutsEnabled(false);
			global::System.Windows.Forms.Control arg_4E6_0 = this.EditBox2;
			size = new global::System.Drawing.Size(283, 36);
			arg_4E6_0.Size = size;
			this.EditBox2.TabIndex = 1;
			this.EditBox2.set_TextAlignment(3);
			this.EditBox2.set_VisualStyle(6);
			this.EditBox1.AcceptEnter = true;
			this.EditBox1.AllowEdit = true;
			this.EditBox1.AllowNew = true;
			this.EditBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.EditBox1.set_ButtonFont(new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178));
			this.EditBox1.FocusColor = true;
			this.EditBox1.Font = new global::System.Drawing.Font("Mitra", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_5B0_0 = this.EditBox1;
			location = new global::System.Drawing.Point(487, 12);
			arg_5B0_0.Location = location;
			this.EditBox1.Name = "EditBox1";
			this.EditBox1.Nullable = false;
			this.EditBox1.NullToolTipText = "لطفا نام کاربری را وارد نمائید";
			this.EditBox1.set_ShortcutsEnabled(false);
			global::System.Windows.Forms.Control arg_609_0 = this.EditBox1;
			size = new global::System.Drawing.Size(283, 36);
			arg_609_0.Size = size;
			this.EditBox1.TabIndex = 0;
			this.EditBox1.set_TextAlignment(3);
			this.EditBox1.set_VisualStyle(6);
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_69B_0 = this.Label2;
			location = new global::System.Drawing.Point(772, 63);
			arg_69B_0.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control arg_6C6_0 = this.Label2;
			size = new global::System.Drawing.Size(57, 19);
			arg_6C6_0.Size = size;
			this.Label2.TabIndex = 3;
			this.Label2.Text = "گذرواژه";
			this.Label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			global::System.Windows.Forms.Control arg_74F_0 = this.Label1;
			location = new global::System.Drawing.Point(772, 21);
			arg_74F_0.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control arg_77A_0 = this.Label1;
			size = new global::System.Drawing.Size(39, 19);
			arg_77A_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "کاربر";
			this.ButtonBar1.Dock = global::System.Windows.Forms.DockStyle.Right;
			buttonBarGroup.set_Key("Group1");
			buttonBarGroup.set_Text("کاربران");
			buttonBarGroup.set_View(0);
			this.ButtonBar1.get_Groups().AddRange(new global::Janus.Windows.ButtonBar.ButtonBarGroup[]
			{
				buttonBarGroup
			});
			this.ButtonBar1.set_HeaderGroupVisible(false);
			global::System.Windows.Forms.Control arg_80F_0 = this.ButtonBar1;
			location = new global::System.Drawing.Point(843, 0);
			arg_80F_0.Location = location;
			this.ButtonBar1.Name = "ButtonBar1";
			this.ButtonBar1.set_SelectionArea(1);
			global::System.Windows.Forms.Control arg_84A_0 = this.ButtonBar1;
			size = new global::System.Drawing.Size(118, 454);
			arg_84A_0.Size = size;
			this.ButtonBar1.TabIndex = 0;
			this.ButtonBar1.Text = "ButtonBar1";
			this.ButtonBar1.set_VisualStyle(6);
			this.Bar1.set_AntiAlias(true);
			this.Bar1.set_Dock(global::System.Windows.Forms.DockStyle.Top);
			this.Bar1.set_Font(new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0));
			this.Bar1.get_Items().AddRange(new global::DevComponents.DotNetBar.BaseItem[]
			{
				this.ButtonItem1,
				this.ButtonItem2,
				this.ButtonItem3,
				this.ButtonItem4
			});
			global::DevComponents.DotNetBar.Bar arg_90C_0 = this.Bar1;
			location = new global::System.Drawing.Point(0, 0);
			arg_90C_0.set_Location(location);
			this.Bar1.set_Name("Bar1");
			global::DevComponents.DotNetBar.Bar arg_93A_0 = this.Bar1;
			size = new global::System.Drawing.Size(961, 41);
			arg_93A_0.set_Size(size);
			this.Bar1.set_Stretch(true);
			this.Bar1.set_Style(7);
			this.Bar1.set_TabIndex(2);
			this.Bar1.set_TabStop(false);
			this.Bar1.set_Text("Bar1");
			this.ButtonItem1.set_ButtonStyle(2);
			this.ButtonItem1.set_Image(global::FruitBox.My.Resources.Resources.page);
			this.ButtonItem1.set_Name("ButtonItem1");
			this.ButtonItem1.set_Text("جدید (Ins)");
			this.ButtonItem2.set_ButtonStyle(2);
			this.ButtonItem2.set_Image(global::FruitBox.My.Resources.Resources.disk);
			this.ButtonItem2.set_Name("ButtonItem2");
			this.ButtonItem2.set_Text("ثبت (F2)");
			this.ButtonItem3.set_ButtonStyle(2);
			this.ButtonItem3.set_Image(global::FruitBox.My.Resources.Resources.bin_closed);
			this.ButtonItem3.set_Name("ButtonItem3");
			this.ButtonItem3.set_Text("حذف (F5)");
			this.ButtonItem4.set_ButtonStyle(2);
			this.ButtonItem4.set_Image(global::FruitBox.My.Resources.Resources.reload_rotate);
			this.ButtonItem4.set_Name("ButtonItem4");
			this.ButtonItem4.set_Text("بارگذاری مجدد");
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(961, 495);
			this.ClientSize = size;
			this.Controls.Add(this.UiGroupBox1);
			this.Controls.Add(this.Bar1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 178);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_User_Admin";
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.Text = "مدیریت کاربران";
			this.UiGroupBox1.EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox2.EndInit();
			this.UiGroupBox2.ResumeLayout(false);
			this.UiGroupBox2.PerformLayout();
			this.GridEX1.EndInit();
			this.ButtonBar1.EndInit();
			this.Bar1.EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000470 RID: 1136
		private global::System.ComponentModel.IContainer components;
	}
}
