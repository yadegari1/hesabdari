using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using Janus.Windows.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D9 RID: 217
	[DesignerGenerated]
	public partial class Frm_Startup : Form
	{
		// Token: 0x06001344 RID: 4932 RVA: 0x001CCE0C File Offset: 0x001CB20C
		[DebuggerNonUserCode]
		public Frm_Startup()
		{
			base.Load += new EventHandler(this.Frm_Startup_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Startup_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_Startup_KeyDown);
			Frm_Startup.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x001CCE6C File Offset: 0x001CB26C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Startup.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Startup.__ENCList.Count == Frm_Startup.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Startup.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Startup.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Startup.__ENCList[num] = Frm_Startup.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Startup.__ENCList.RemoveRange(num, Frm_Startup.__ENCList.Count - num);
						Frm_Startup.__ENCList.Capacity = Frm_Startup.__ENCList.Count;
					}
					Frm_Startup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x001CDC58 File Offset: 0x001CC058
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x001CDC70 File Offset: 0x001CC070
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

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x001CDC7C File Offset: 0x001CC07C
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x001CDC94 File Offset: 0x001CC094
		internal virtual PanelEx PanelEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx2 = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x001CDCA0 File Offset: 0x001CC0A0
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x001CDCB8 File Offset: 0x001CC0B8
		internal virtual UICheckBox UiCheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox1 = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x001CDCC4 File Offset: 0x001CC0C4
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x001CDCDC File Offset: 0x001CC0DC
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x001CDD3C File Offset: 0x001CC13C
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x001CDD54 File Offset: 0x001CC154
		internal virtual UIButton UiButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton6_Click);
				bool flag = this._UiButton6 != null;
				if (flag)
				{
					this._UiButton6.Click -= value2;
				}
				this._UiButton6 = value;
				flag = (this._UiButton6 != null);
				if (flag)
				{
					this._UiButton6.Click += value2;
				}
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x001CDDB4 File Offset: 0x001CC1B4
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x001CDDCC File Offset: 0x001CC1CC
		internal virtual UIButton UiButton5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton5_Click);
				bool flag = this._UiButton5 != null;
				if (flag)
				{
					this._UiButton5.Click -= value2;
				}
				this._UiButton5 = value;
				flag = (this._UiButton5 != null);
				if (flag)
				{
					this._UiButton5.Click += value2;
				}
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x001CDE2C File Offset: 0x001CC22C
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x001CDE44 File Offset: 0x001CC244
		internal virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click);
				bool flag = this._UiButton4 != null;
				if (flag)
				{
					this._UiButton4.Click -= value2;
				}
				this._UiButton4 = value;
				flag = (this._UiButton4 != null);
				if (flag)
				{
					this._UiButton4.Click += value2;
				}
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x001CDEA4 File Offset: 0x001CC2A4
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x001CDEBC File Offset: 0x001CC2BC
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x001CDF1C File Offset: 0x001CC31C
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x001CDF34 File Offset: 0x001CC334
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x001CDF94 File Offset: 0x001CC394
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x001CDFAC File Offset: 0x001CC3AC
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

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x001CDFB8 File Offset: 0x001CC3B8
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x001CDFD0 File Offset: 0x001CC3D0
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

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x001CDFDC File Offset: 0x001CC3DC
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x001CDFF4 File Offset: 0x001CC3F4
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

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x001CE000 File Offset: 0x001CC400
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x001CE018 File Offset: 0x001CC418
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

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x001CE024 File Offset: 0x001CC424
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x001CE03C File Offset: 0x001CC43C
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x001CE048 File Offset: 0x001CC448
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x001CE060 File Offset: 0x001CC460
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x001CE06C File Offset: 0x001CC46C
		private void UiButton1_Click(object sender, EventArgs e)
		{
			Frm_Moshtari showFrm = new Frm_Moshtari();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x001CE094 File Offset: 0x001CC494
		private void UiButton2_Click(object sender, EventArgs e)
		{
			Frm_Bank_Hesab showFrm = new Frm_Bank_Hesab();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x001CE0BC File Offset: 0x001CC4BC
		private void UiButton3_Click(object sender, EventArgs e)
		{
			Frm_SahebSaham showFrm = new Frm_SahebSaham();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x001CE0E4 File Offset: 0x001CC4E4
		private void UiButton4_Click(object sender, EventArgs e)
		{
			Frm_DasteCheck showFrm = new Frm_DasteCheck();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x001CE10C File Offset: 0x001CC50C
		private void UiButton5_Click(object sender, EventArgs e)
		{
			Frm_Moshtarian showFrm = new Frm_Moshtarian();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x001CE134 File Offset: 0x001CC534
		private void UiButton6_Click(object sender, EventArgs e)
		{
			Frm_PardakhtCheck_Avaldore showFrm = new Frm_PardakhtCheck_Avaldore();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x001CE15C File Offset: 0x001CC55C
		private void Frm_Startup_FormClosing(object sender, FormClosingEventArgs e)
		{
			setting setting = new setting();
			setting.Update("startup", Conversions.ToString(!this.UiCheckBox1.get_Checked()));
			Public_Function.dict["startup"] = Conversions.ToString(!this.UiCheckBox1.get_Checked());
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x001CE1B4 File Offset: 0x001CC5B4
		private void Frm_Startup_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x001CE1DC File Offset: 0x001CC5DC
		private void Frm_Startup_Load(object sender, EventArgs e)
		{
			this.UiCheckBox1.set_Checked(!Conversions.ToBoolean(Public_Function.dict["startup"]));
		}

		// Token: 0x04000776 RID: 1910
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000778 RID: 1912
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000779 RID: 1913
		[AccessedThroughProperty("PanelEx2")]
		private PanelEx _PanelEx2;

		// Token: 0x0400077A RID: 1914
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x0400077B RID: 1915
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400077C RID: 1916
		[AccessedThroughProperty("UiButton6")]
		private UIButton _UiButton6;

		// Token: 0x0400077D RID: 1917
		[AccessedThroughProperty("UiButton5")]
		private UIButton _UiButton5;

		// Token: 0x0400077E RID: 1918
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x0400077F RID: 1919
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x04000780 RID: 1920
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000781 RID: 1921
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000782 RID: 1922
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000783 RID: 1923
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000784 RID: 1924
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000785 RID: 1925
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000786 RID: 1926
		[AccessedThroughProperty("Label5")]
		private Label _Label5;
	}
}
