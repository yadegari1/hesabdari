using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000072 RID: 114
	[DesignerGenerated]
	public partial class Frm_RegHelp : Form
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x0018374C File Offset: 0x00181B4C
		[DebuggerNonUserCode]
		public Frm_RegHelp()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_RegHelp_KeyDown);
			Frm_RegHelp.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00183778 File Offset: 0x00181B78
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_RegHelp.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_RegHelp.__ENCList.Count == Frm_RegHelp.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_RegHelp.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_RegHelp.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_RegHelp.__ENCList[num] = Frm_RegHelp.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_RegHelp.__ENCList.RemoveRange(num, Frm_RegHelp.__ENCList.Count - num);
						Frm_RegHelp.__ENCList.Capacity = Frm_RegHelp.__ENCList.Count;
					}
					Frm_RegHelp.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00183E1C File Offset: 0x0018221C
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00183E34 File Offset: 0x00182234
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00183E40 File Offset: 0x00182240
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00183E58 File Offset: 0x00182258
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00183E64 File Offset: 0x00182264
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00183E7C File Offset: 0x0018227C
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00183E88 File Offset: 0x00182288
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00183EA0 File Offset: 0x001822A0
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

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00183EAC File Offset: 0x001822AC
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00183EC4 File Offset: 0x001822C4
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

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00183F24 File Offset: 0x00182324
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00183F3C File Offset: 0x0018233C
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

		// Token: 0x060008E1 RID: 2273 RVA: 0x00183F48 File Offset: 0x00182348
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton1_Click(object sender, EventArgs e)
		{
			try
			{
				Application.Exit();
				ProjectData.EndApp();
			}
			catch (Exception expr_10)
			{
				ProjectData.SetProjectError(expr_10);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00183F8C File Offset: 0x0018238C
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Frm_RegHelp_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				try
				{
					Application.Exit();
					ProjectData.EndApp();
				}
				catch (Exception expr_1E)
				{
					ProjectData.SetProjectError(expr_1E);
					ProjectData.EndApp();
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x04000375 RID: 885
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000377 RID: 887
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000378 RID: 888
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000379 RID: 889
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400037A RID: 890
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400037B RID: 891
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400037C RID: 892
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;
	}
}
