using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000068 RID: 104
	[DesignerGenerated]
	public partial class Frm_Error : Form
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x00178F18 File Offset: 0x00177318
		[DebuggerNonUserCode]
		public Frm_Error()
		{
			Frm_Error.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00178F30 File Offset: 0x00177330
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Error.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Error.__ENCList.Count == Frm_Error.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Error.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Error.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Error.__ENCList[num] = Frm_Error.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Error.__ENCList.RemoveRange(num, Frm_Error.__ENCList.Count - num);
						Frm_Error.__ENCList.Capacity = Frm_Error.__ENCList.Count;
					}
					Frm_Error.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x001792B8 File Offset: 0x001776B8
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x001792D0 File Offset: 0x001776D0
		internal virtual GridEX Gridex1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Gridex1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Gridex1 = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x001792DC File Offset: 0x001776DC
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x001792F4 File Offset: 0x001776F4
		internal virtual GridSize GridSize1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridSize1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridSize1 = value;
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00179300 File Offset: 0x00177700
		public DialogResult ShowDialog(ErrorListManager errorList)
		{
			try
			{
				List<string>.Enumerator enumerator = errorList.List.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					this.Gridex1.AddItem(new object[]
					{
						current
					});
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return base.ShowDialog();
		}

		// Token: 0x040002E1 RID: 737
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002E3 RID: 739
		[AccessedThroughProperty("Gridex1")]
		private GridEX _Gridex1;

		// Token: 0x040002E4 RID: 740
		[AccessedThroughProperty("GridSize1")]
		private GridSize _GridSize1;
	}
}
