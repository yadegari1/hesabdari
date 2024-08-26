using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000081 RID: 129
	[DesignerGenerated]
	public partial class Frm_Splash2 : Form
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x00199008 File Offset: 0x00197408
		[DebuggerNonUserCode]
		public Frm_Splash2()
		{
			base.Load += new EventHandler(this.Frm_Splash_Load);
			Frm_Splash2.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00199034 File Offset: 0x00197434
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Splash2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Splash2.__ENCList.Count == Frm_Splash2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Splash2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Splash2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Splash2.__ENCList[num] = Frm_Splash2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Splash2.__ENCList.RemoveRange(num, Frm_Splash2.__ENCList.Count - num);
						Frm_Splash2.__ENCList.Capacity = Frm_Splash2.__ENCList.Count;
					}
					Frm_Splash2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x00199598 File Offset: 0x00197998
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x001995B0 File Offset: 0x001979B0
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Timer1 = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x001995BC File Offset: 0x001979BC
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x001995D4 File Offset: 0x001979D4
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

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x001995E0 File Offset: 0x001979E0
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x001995F8 File Offset: 0x001979F8
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

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00199604 File Offset: 0x00197A04
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x0019961C File Offset: 0x00197A1C
		internal virtual Label lbl_ver
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_ver;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_ver = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00199628 File Offset: 0x00197A28
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00199640 File Offset: 0x00197A40
		internal virtual Label lbl_owner
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_owner;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_owner = value;
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0019964C File Offset: 0x00197A4C
		private void Frm_Splash_Load(object sender, EventArgs e)
		{
			string text = Assembly.GetEntryAssembly().GetName().Version.ToString();
			bool flag = text.EndsWith(".0.0");
			if (flag)
			{
				this.lbl_ver.Text = text.Replace(".0.0", "");
			}
			flag = text.EndsWith(".0");
			if (flag)
			{
				this.lbl_ver.Text = text.Remove(checked(text.Length - 2), 2);
			}
		}

		// Token: 0x04000464 RID: 1124
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000466 RID: 1126
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000467 RID: 1127
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000468 RID: 1128
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000469 RID: 1129
		[AccessedThroughProperty("lbl_ver")]
		private Label _lbl_ver;

		// Token: 0x0400046A RID: 1130
		[AccessedThroughProperty("lbl_owner")]
		private Label _lbl_owner;
	}
}
