using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using Janus.Windows.EditControls;
using Janus.Windows.Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000067 RID: 103
	[DesignerGenerated]
	public partial class Frm_EditUser : Form
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x00177D74 File Offset: 0x00176174
		public Frm_EditUser()
		{
			base.Load += new EventHandler(this.Frm_EditUser_Load);
			Frm_EditUser.__ENCAddToList(this);
			this.user = new base_user();
			this.InitializeComponent();
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00177DAC File Offset: 0x001761AC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_EditUser.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_EditUser.__ENCList.Count == Frm_EditUser.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_EditUser.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_EditUser.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_EditUser.__ENCList[num] = Frm_EditUser.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_EditUser.__ENCList.RemoveRange(num, Frm_EditUser.__ENCList.Count - num);
						Frm_EditUser.__ENCList.Capacity = Frm_EditUser.__ENCList.Count;
					}
					Frm_EditUser.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00178AEC File Offset: 0x00176EEC
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00178B04 File Offset: 0x00176F04
		internal virtual UIGroupBox UiGroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox1 = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00178B10 File Offset: 0x00176F10
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00178B28 File Offset: 0x00176F28
		internal virtual UIGroupBox UiGroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox2 = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00178B34 File Offset: 0x00176F34
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00178B4C File Offset: 0x00176F4C
		internal virtual OfficeFormAdorner OfficeFormAdorner1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OfficeFormAdorner1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OfficeFormAdorner1 = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00178B58 File Offset: 0x00176F58
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00178B70 File Offset: 0x00176F70
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00178BD0 File Offset: 0x00176FD0
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00178BE8 File Offset: 0x00176FE8
		internal virtual UIRadioButton UiRadioButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton2 = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00178BF4 File Offset: 0x00176FF4
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00178C0C File Offset: 0x0017700C
		internal virtual UIRadioButton UiRadioButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton1 = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00178C18 File Offset: 0x00177018
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00178C30 File Offset: 0x00177030
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00178C3C File Offset: 0x0017703C
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00178C54 File Offset: 0x00177054
		internal virtual SwitchButton SwitchButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SwitchButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SwitchButton2 = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00178C60 File Offset: 0x00177060
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00178C78 File Offset: 0x00177078
		internal virtual SwitchButton SwitchButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SwitchButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SwitchButton1 = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00178C84 File Offset: 0x00177084
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00178C9C File Offset: 0x0017709C
		internal virtual UIRadioButton UiRadioButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton4 = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00178CA8 File Offset: 0x001770A8
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00178CC0 File Offset: 0x001770C0
		internal virtual UIRadioButton UiRadioButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton3 = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00178CCC File Offset: 0x001770CC
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00178CE4 File Offset: 0x001770E4
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00178CF0 File Offset: 0x001770F0
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00178D08 File Offset: 0x00177108
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00178D14 File Offset: 0x00177114
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x00178D2C File Offset: 0x0017712C
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00178D38 File Offset: 0x00177138
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x00178D50 File Offset: 0x00177150
		internal virtual UIGroupBox UiGroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox4 = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00178D5C File Offset: 0x0017715C
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00178D74 File Offset: 0x00177174
		internal virtual UIGroupBox UiGroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox3 = value;
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00178D80 File Offset: 0x00177180
		private void UiButton1_Click(object sender, EventArgs e)
		{
			string gui = string.Empty;
			string tabbed = string.Empty;
			string autoclose = string.Empty;
			string autobackup = string.Empty;
			bool flag = this.UiRadioButton1.get_Checked();
			if (flag)
			{
				gui = "1";
			}
			else
			{
				gui = "0";
			}
			flag = this.UiRadioButton3.get_Checked();
			if (flag)
			{
				tabbed = "0";
			}
			else
			{
				tabbed = "1";
			}
			flag = this.SwitchButton1.get_Value();
			if (flag)
			{
				autoclose = "0";
			}
			else
			{
				autoclose = "1";
			}
			flag = this.SwitchButton2.get_Value();
			if (flag)
			{
				autobackup = "1";
			}
			else
			{
				autobackup = "0";
			}
			this.user.Update(gui, tabbed, autoclose, autobackup);
			this.Close();
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00178E44 File Offset: 0x00177244
		private void Frm_EditUser_Load(object sender, EventArgs e)
		{
			bool flag = Public_Function.CurrentData.Gui == 1;
			if (flag)
			{
				this.UiRadioButton1.set_Checked(true);
			}
			else
			{
				this.UiRadioButton2.set_Checked(true);
			}
			flag = Public_Function.CurrentData.Tabbed;
			if (flag)
			{
				this.UiRadioButton4.set_Checked(true);
			}
			else
			{
				this.UiRadioButton3.set_Checked(true);
			}
			flag = Public_Function.CurrentData.AutoClose;
			if (flag)
			{
				this.SwitchButton1.set_Value(false);
			}
			else
			{
				this.SwitchButton1.set_Value(true);
			}
			flag = Public_Function.CurrentData.AutoBackup;
			if (flag)
			{
				this.SwitchButton2.set_Value(true);
			}
			else
			{
				this.SwitchButton2.set_Value(false);
			}
		}

		// Token: 0x040002CE RID: 718
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002D0 RID: 720
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040002D1 RID: 721
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040002D2 RID: 722
		[AccessedThroughProperty("OfficeFormAdorner1")]
		private OfficeFormAdorner _OfficeFormAdorner1;

		// Token: 0x040002D3 RID: 723
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040002D4 RID: 724
		[AccessedThroughProperty("UiRadioButton2")]
		private UIRadioButton _UiRadioButton2;

		// Token: 0x040002D5 RID: 725
		[AccessedThroughProperty("UiRadioButton1")]
		private UIRadioButton _UiRadioButton1;

		// Token: 0x040002D6 RID: 726
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040002D7 RID: 727
		[AccessedThroughProperty("SwitchButton2")]
		private SwitchButton _SwitchButton2;

		// Token: 0x040002D8 RID: 728
		[AccessedThroughProperty("SwitchButton1")]
		private SwitchButton _SwitchButton1;

		// Token: 0x040002D9 RID: 729
		[AccessedThroughProperty("UiRadioButton4")]
		private UIRadioButton _UiRadioButton4;

		// Token: 0x040002DA RID: 730
		[AccessedThroughProperty("UiRadioButton3")]
		private UIRadioButton _UiRadioButton3;

		// Token: 0x040002DB RID: 731
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040002DC RID: 732
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040002DD RID: 733
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040002DE RID: 734
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x040002DF RID: 735
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x040002E0 RID: 736
		private base_user user;
	}
}
