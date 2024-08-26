using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200006D RID: 109
	[DesignerGenerated]
	public partial class Frm_Menu : Form
	{
		// Token: 0x06000833 RID: 2099 RVA: 0x0017F450 File Offset: 0x0017D850
		public Frm_Menu()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Menu_KeyDown);
			base.Load += new EventHandler(this.Frm_Menu_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Menu_FormClosing);
			Frm_Menu.__ENCAddToList(this);
			int group_Index = 0;
			this.Group_Index = group_Index;
			this.InitializeComponent();
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0017F4BC File Offset: 0x0017D8BC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Menu.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Menu.__ENCList.Count == Frm_Menu.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Menu.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Menu.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Menu.__ENCList[num] = Frm_Menu.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Menu.__ENCList.RemoveRange(num, Frm_Menu.__ENCList.Count - num);
						Frm_Menu.__ENCList.Capacity = Frm_Menu.__ENCList.Count;
					}
					Frm_Menu.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0017FAC8 File Offset: 0x0017DEC8
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x0017FAE0 File Offset: 0x0017DEE0
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0017FAEC File Offset: 0x0017DEEC
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x0017FB04 File Offset: 0x0017DF04
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

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0017FB10 File Offset: 0x0017DF10
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x0017FB28 File Offset: 0x0017DF28
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0017FB34 File Offset: 0x0017DF34
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0017FB4C File Offset: 0x0017DF4C
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0017FB58 File Offset: 0x0017DF58
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0017FB70 File Offset: 0x0017DF70
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0017FB7C File Offset: 0x0017DF7C
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x0017FB94 File Offset: 0x0017DF94
		public int Main_Menu_Index
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Main_Menu_Index;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Main_Menu_Index = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0017FBA0 File Offset: 0x0017DFA0
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x0017FBB8 File Offset: 0x0017DFB8
		public int sub_menu_index
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sub_menu_index;
			}
			[DebuggerNonUserCode]
			set
			{
				this._sub_menu_index = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0017FBC4 File Offset: 0x0017DFC4
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x0017FBDC File Offset: 0x0017DFDC
		public int Group_Index
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Group_Index;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Group_Index = value;
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0017FBE8 File Offset: 0x0017DFE8
		private void Frm_Menu_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Hide();
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0017FC10 File Offset: 0x0017E010
		private void Frm_Menu_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0017FC14 File Offset: 0x0017E014
		private void Frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		// Token: 0x04000330 RID: 816
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000332 RID: 818
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000333 RID: 819
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x04000334 RID: 820
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000335 RID: 821
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x04000336 RID: 822
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000337 RID: 823
		[CompilerGenerated]
		private int _Main_Menu_Index;

		// Token: 0x04000338 RID: 824
		[CompilerGenerated]
		private int _sub_menu_index;

		// Token: 0x04000339 RID: 825
		[CompilerGenerated]
		private int _Group_Index;
	}
}
