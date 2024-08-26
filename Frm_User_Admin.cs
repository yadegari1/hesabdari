using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.ButtonBar;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000083 RID: 131
	[DesignerGenerated]
	public partial class Frm_User_Admin : Form
	{
		// Token: 0x06000B3F RID: 2879 RVA: 0x00199A54 File Offset: 0x00197E54
		public Frm_User_Admin()
		{
			base.Activated += new EventHandler(this.Frm_User_Admin_Activated);
			base.KeyDown += new KeyEventHandler(this.Frm_User_Admin_KeyDown);
			base.Load += new EventHandler(this.Frm_User_Admin_Load);
			Frm_User_Admin.__ENCAddToList(this);
			this.users = new base_user();
			this._controls = new Base_Controls();
			this.user_control = new Base_User_Control();
			this.InitializeComponent();
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00199AD4 File Offset: 0x00197ED4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_User_Admin.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_User_Admin.__ENCList.Count == Frm_User_Admin.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_User_Admin.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_User_Admin.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_User_Admin.__ENCList[num] = Frm_User_Admin.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_User_Admin.__ENCList.RemoveRange(num, Frm_User_Admin.__ENCList.Count - num);
						Frm_User_Admin.__ENCList.Capacity = Frm_User_Admin.__ENCList.Count;
					}
					Frm_User_Admin.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0019A7DC File Offset: 0x00198BDC
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x0019A7F4 File Offset: 0x00198BF4
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0019A800 File Offset: 0x00198C00
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x0019A818 File Offset: 0x00198C18
		public virtual Bar Bar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar1 = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0019A824 File Offset: 0x00198C24
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x0019A83C File Offset: 0x00198C3C
		internal virtual ButtonItem ButtonItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ButtonItem1_Click);
				bool flag = this._ButtonItem1 != null;
				if (flag)
				{
					this._ButtonItem1.remove_Click(eventHandler);
				}
				this._ButtonItem1 = value;
				flag = (this._ButtonItem1 != null);
				if (flag)
				{
					this._ButtonItem1.add_Click(eventHandler);
				}
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0019A89C File Offset: 0x00198C9C
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x0019A8B4 File Offset: 0x00198CB4
		internal virtual ButtonItem ButtonItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ButtonItem2_Click);
				bool flag = this._ButtonItem2 != null;
				if (flag)
				{
					this._ButtonItem2.remove_Click(eventHandler);
				}
				this._ButtonItem2 = value;
				flag = (this._ButtonItem2 != null);
				if (flag)
				{
					this._ButtonItem2.add_Click(eventHandler);
				}
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0019A914 File Offset: 0x00198D14
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x0019A92C File Offset: 0x00198D2C
		internal virtual ButtonItem ButtonItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ButtonItem3_Click);
				bool flag = this._ButtonItem3 != null;
				if (flag)
				{
					this._ButtonItem3.remove_Click(eventHandler);
				}
				this._ButtonItem3 = value;
				flag = (this._ButtonItem3 != null);
				if (flag)
				{
					this._ButtonItem3.add_Click(eventHandler);
				}
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0019A98C File Offset: 0x00198D8C
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x0019A9A4 File Offset: 0x00198DA4
		internal virtual ButtonBar ButtonBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ItemEventHandler itemEventHandler = new ItemEventHandler(this.ButtonBar1_ItemClick);
				bool flag = this._ButtonBar1 != null;
				if (flag)
				{
					this._ButtonBar1.remove_ItemClick(itemEventHandler);
				}
				this._ButtonBar1 = value;
				flag = (this._ButtonBar1 != null);
				if (flag)
				{
					this._ButtonBar1.add_ItemClick(itemEventHandler);
				}
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0019AA04 File Offset: 0x00198E04
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0019AA1C File Offset: 0x00198E1C
		internal virtual GridEX GridEX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RowCheckStateChangeEventHandler rowCheckStateChangeEventHandler = new RowCheckStateChangeEventHandler(this.GridEX1_RowCheckStateChanged);
				RowLoadEventHandler rowLoadEventHandler = new RowLoadEventHandler(this.GridEX1_FormattingRow);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.remove_RowCheckStateChanged(rowCheckStateChangeEventHandler);
					this._GridEX1.remove_FormattingRow(rowLoadEventHandler);
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.add_RowCheckStateChanged(rowCheckStateChangeEventHandler);
					this._GridEX1.add_FormattingRow(rowLoadEventHandler);
				}
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0019AAA4 File Offset: 0x00198EA4
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0019AABC File Offset: 0x00198EBC
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0019AAC8 File Offset: 0x00198EC8
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x0019AAE0 File Offset: 0x00198EE0
		internal virtual EditBox EditBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox2 = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0019AAEC File Offset: 0x00198EEC
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0019AB04 File Offset: 0x00198F04
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox1 = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0019AB10 File Offset: 0x00198F10
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0019AB28 File Offset: 0x00198F28
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0019AB34 File Offset: 0x00198F34
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x0019AB4C File Offset: 0x00198F4C
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0019AB58 File Offset: 0x00198F58
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x0019AB70 File Offset: 0x00198F70
		internal virtual ButtonItem ButtonItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ButtonItem4_Click);
				bool flag = this._ButtonItem4 != null;
				if (flag)
				{
					this._ButtonItem4.remove_Click(eventHandler);
				}
				this._ButtonItem4 = value;
				flag = (this._ButtonItem4 != null);
				if (flag)
				{
					this._ButtonItem4.add_Click(eventHandler);
				}
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0019ABD0 File Offset: 0x00198FD0
		private void GetChillds(Control ctl, long ID)
		{
			try
			{
				IEnumerator enumerator = ctl.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					bool flag = control is Bar;
					if (flag)
					{
						try
						{
							IEnumerator enumerator2 = ((Bar)control).get_Items().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								ButtonItem buttonItem = (ButtonItem)enumerator2.Current;
								this.dr = this._controls.GetID(buttonItem.get_Text(), Conversions.ToString(ID));
								flag = (this.dr == null);
								if (flag)
								{
									this._controls.Insert(buttonItem.get_Text(), Conversions.ToString(ID), "");
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							flag = (enumerator2 is IDisposable);
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					this.GetChillds(control, ID);
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0019AD04 File Offset: 0x00199104
		private long InsertUpdateItem(string name, long? Parent_ID, string ids = "")
		{
			DataRow iD = this._controls.GetID(name, Parent_ID.ToString());
			bool flag = iD == null;
			long result;
			if (flag)
			{
				result = (long)this._controls.Insert(name, Parent_ID.ToString(), ids);
			}
			else
			{
				result = Conversions.ToLong(iD["ID"]);
			}
			return result;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0019AD6C File Offset: 0x0019916C
		private void GetMenuChilds(ButtonItem ctl, long Parent_ID)
		{
			bool flag = ctl.get_SubItems().Count > 0;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = ctl.get_SubItems().GetEnumerator();
					while (enumerator.MoveNext())
					{
						BaseItem baseItem = (BaseItem)enumerator.Current;
						bool flag2 = baseItem is ButtonItem;
						if (flag2)
						{
							long num = this.InsertUpdateItem(baseItem.get_Text(), Parent_ID, "");
							this.GetMenuChilds((ButtonItem)baseItem, Parent_ID);
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag2 = enumerator is IDisposable;
					if (flag2)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0019AE24 File Offset: 0x00199224
		private void Sync2()
		{
			long? parent_ID2;
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.Bar1.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					BaseItem baseItem = (BaseItem)enumerator.Current;
					bool flag = baseItem is LabelItem;
					if (!flag)
					{
						long parent_ID = this.InsertUpdateItem(baseItem.get_Text(), parent_ID2, "");
						this.GetMenuChilds((ButtonItem)baseItem, parent_ID);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			PropertyInfo[] properties = MyProject.Forms.GetType().GetProperties();
			int i = 0;
			checked
			{
				while (i < properties.Length)
				{
					PropertyInfo propertyInfo = properties[i];
					bool flag = propertyInfo.PropertyType.IsSubclassOf(typeof(Form));
					if (flag)
					{
						Form form = (Form)Activator.CreateInstance(propertyInfo.PropertyType);
						this.dr = this._controls.GetID(form.Text, "is not null");
						flag = (this.dr == null);
						if (flag)
						{
							form.Dispose();
						}
						else
						{
							this.GetChillds(form, Conversions.ToLong(this.dr["ID"]));
							form.Dispose();
						}
					}
					IL_138:
					i++;
					continue;
					goto IL_138;
				}
				long parent_ID = this.InsertUpdateItem("سربرگ ها", parent_ID2, "-1");
				try
				{
					IEnumerator enumerator2 = MyProject.Forms.Form_Main.UiPanelManager1.get_Panels().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						UIPanel uIPanel = (UIPanel)enumerator2.Current;
						this.InsertUpdateItem(uIPanel.Text, -1L, "");
					}
				}
				finally
				{
					IEnumerator enumerator2;
					bool flag = enumerator2 is IDisposable;
					if (flag)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0019B02C File Offset: 0x0019942C
		private void Sync()
		{
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.ButtonBar1.get_Groups().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ButtonBarGroup buttonBarGroup = (ButtonBarGroup)enumerator.Current;
					DataRow iD = this._controls.GetID(buttonBarGroup.get_Text(), "");
					bool flag = iD == null;
					int value;
					if (flag)
					{
						value = this._controls.Insert(buttonBarGroup.get_Text(), "", "");
					}
					else
					{
						value = Conversions.ToInteger(iD["ID"]);
					}
					try
					{
						IEnumerator enumerator2 = MyProject.Forms.Form_Main.ButtonBar1.get_Groups().get_Item(buttonBarGroup.get_Key()).get_Items().GetEnumerator();
						while (enumerator2.MoveNext())
						{
							ButtonBarItem buttonBarItem = (ButtonBarItem)enumerator2.Current;
							iD = this._controls.GetID(buttonBarItem.get_Text(), Conversions.ToString(value));
							flag = (iD == null);
							if (flag)
							{
								this._controls.Insert(buttonBarItem.get_Text(), Conversions.ToString(value), "");
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						flag = (enumerator2 is IDisposable);
						if (flag)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			PropertyInfo[] properties = MyProject.Forms.GetType().GetProperties();
			int i = 0;
			checked
			{
				while (i < properties.Length)
				{
					PropertyInfo propertyInfo = properties[i];
					bool flag = propertyInfo.PropertyType.IsSubclassOf(typeof(Form));
					if (flag)
					{
						Form form = (Form)Activator.CreateInstance(propertyInfo.PropertyType);
						DataRow iD = this._controls.GetID(form.Text, "is not null");
						flag = (iD == null);
						if (flag)
						{
							form.Dispose();
						}
						else
						{
							this.GetChillds(form, Conversions.ToLong(iD["ID"]));
						}
					}
					IL_1FB:
					i++;
					continue;
					goto IL_1FB;
				}
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0019B284 File Offset: 0x00199684
		private void Frm_User_Admin_Activated(object sender, EventArgs e)
		{
			this.GridEX1.get_RootTable().get_Columns().get_Item("name").set_Width(500);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0019B2B0 File Offset: 0x001996B0
		private void Frm_User_Admin_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.F1 && true;
			if (flag)
			{
				this.Sync2();
				Public_Function.ShowMessage("اطلاعات مدیریت کاربران بروز رسانی گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
			flag = (e.KeyCode == Keys.Escape);
			if (flag)
			{
				this.Close();
			}
			Keys keyCode = e.KeyCode;
			flag = (keyCode == Keys.Insert);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
			else
			{
				flag = (keyCode == Keys.F2);
				if (flag)
				{
					this.ButtonItem2_Click(null, null);
				}
				else
				{
					flag = (keyCode == Keys.F5);
					if (flag)
					{
						this.ButtonItem3_Click(null, null);
					}
				}
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0019B348 File Offset: 0x00199748
		private void Frm_User_Admin_Load(object sender, EventArgs e)
		{
			this.is_new = true;
			this.dt = this.users.GetAll();
			try
			{
				IEnumerator enumerator = this.dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					ButtonBarItem buttonBarItem = new ButtonBarItem(Conversions.ToString(dataRow["UserName"]));
					buttonBarItem.set_Image(Resources.user);
					buttonBarItem.set_ImageAlignment(2);
					buttonBarItem.set_TextAlignment(1);
					this.ButtonBar1.get_Groups().get_Item(0).get_Items().Add(buttonBarItem);
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			DataTable all = this._controls.GetAll();
			this.GridEX1.set_DataSource(all);
			this.GridEX1.CheckAllRecords();
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0019B444 File Offset: 0x00199844
		private void GridEX1_FormattingRow(object sender, RowLoadEventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = ((DataRowView)gridEXRow.get_DataRow())["Parent_ID"] == DBNull.Value;
					if (flag)
					{
						bool flag2 = gridEXRow.get_Cells().get_Item("Name").get_Image() == null;
						if (flag2)
						{
							gridEXRow.get_Cells().get_Item("Name").set_Image(Resources.folder);
						}
						GridEXRow[] childRows = gridEXRow.GetChildRows();
						for (int j = 0; j < childRows.Length; j++)
						{
							GridEXRow gridEXRow2 = childRows[j];
							flag2 = (gridEXRow2.get_Cells().get_Item("Name").get_Image() == null);
							if (flag2)
							{
								gridEXRow2.get_Cells().get_Item("Name").set_Image(Resources.application);
							}
							GridEXRow[] childRows2 = gridEXRow2.GetChildRows();
							for (int k = 0; k < childRows2.Length; k++)
							{
								GridEXRow gridEXRow3 = childRows2[k];
								flag2 = (gridEXRow3.get_Cells().get_Item("Name").get_Image() == null);
								if (flag2)
								{
									gridEXRow3.get_Cells().get_Item("Name").set_Image(Resources.shape_move_forwards);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0019B5AC File Offset: 0x001999AC
		private void GridEX1_RowCheckStateChanged(object sender, RowCheckStateChangeEventArgs e)
		{
			GridEXRow[] childRows = e.get_Row().GetChildRows();
			checked
			{
				for (int i = 0; i < childRows.Length; i++)
				{
					GridEXRow gridEXRow = childRows[i];
					gridEXRow.set_CheckState(e.get_Row().get_CheckState());
					GridEXRow[] childRows2 = gridEXRow.GetChildRows();
					for (int j = 0; j < childRows2.Length; j++)
					{
						GridEXRow gridEXRow2 = childRows2[j];
						gridEXRow2.set_CheckState(gridEXRow.get_CheckState());
					}
				}
			}
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0019B628 File Offset: 0x00199A28
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			Public_Function.SetNew(this.UiGroupBox2);
			this.GridEX1.CheckAllRecords();
			this.EditBox1.Enabled = true;
			this.EditBox1.Focus();
			this.is_new = true;
			this.userdr = null;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0019B678 File Offset: 0x00199A78
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox2);
			checked
			{
				if (!flag)
				{
					flag = this.is_new;
					if (flag)
					{
						bool flag2 = Public_Function.ExistValue("Users", "UserName", this.EditBox1.Text);
						if (flag2)
						{
							this.EditBox1.ShowTip("نام کاربری انتخاب شده تکراری میباشد");
							return;
						}
						int value = this.users.Insert(this.EditBox1.Text, this.EditBox2.Text);
						GridEXRow[] uncheckedRows = this.GridEX1.GetUncheckedRows();
						for (int i = 0; i < uncheckedRows.Length; i++)
						{
							GridEXRow gridEXRow = uncheckedRows[i];
							this.user_control.Insert(Conversions.ToString(value), Conversions.ToString(((DataRowView)gridEXRow.get_DataRow())["ID"]));
						}
						this.AddButtonBarItem(this.EditBox1.Text);
						this.is_new = false;
						this.EditBox1.Enabled = false;
					}
					else
					{
						int value = Conversions.ToInteger(this.userdr["ID"]);
						this.users.UpdateUser(this.EditBox2.Text, Conversions.ToString(value));
						this.user_control.DeleteUserPermission(Conversions.ToString(value));
						GridEXRow[] uncheckedRows2 = this.GridEX1.GetUncheckedRows();
						for (int j = 0; j < uncheckedRows2.Length; j++)
						{
							GridEXRow gridEXRow2 = uncheckedRows2[j];
							this.user_control.Insert(Conversions.ToString(value), Conversions.ToString(((DataRowView)gridEXRow2.get_DataRow())["ID"]));
						}
					}
					Public_Function.ConfirmInsert();
				}
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0019B830 File Offset: 0x00199C30
		private void UncheckRow(GridEXRow Row, int id)
		{
			GridEXRow[] childRows = Row.GetChildRows();
			checked
			{
				for (int i = 0; i < childRows.Length; i++)
				{
					GridEXRow gridEXRow = childRows[i];
					bool flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.get_DataRow())["ID"], id, false);
					if (flag)
					{
						gridEXRow.set_CheckState(1);
					}
					else
					{
						this.UncheckRow(gridEXRow, id);
					}
				}
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0019B898 File Offset: 0x00199C98
		private void UncheckRow(int id)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.get_DataRow())["ID"], id, false);
					if (flag)
					{
						gridEXRow.set_CheckState(1);
						break;
					}
					this.UncheckRow(gridEXRow, id);
				}
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0019B908 File Offset: 0x00199D08
		private void ButtonBar1_ItemClick(object sender, ItemEventArgs e)
		{
			this.is_new = false;
			this.EditBox1.Enabled = false;
			this.GridEX1.CheckAllRecords();
			this.userdr = this.users.GetByName(e.get_Item().get_Text());
			this.EditBox1.Text = e.get_Item().get_Text();
			this.EditBox2.Text = Conversions.ToString(this.userdr["Password"]);
			DataTable userPermission = this.user_control.GetUserPermission(e.get_Item().get_Text());
			try
			{
				IEnumerator enumerator = userPermission.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					this.UncheckRow(Conversions.ToInteger(dataRow["Control_ID"]));
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0019BA18 File Offset: 0x00199E18
		private void AddButtonBarItem(string Name)
		{
			ButtonBarItem buttonBarItem = new ButtonBarItem(Name);
			buttonBarItem.set_Image(Resources.user);
			buttonBarItem.set_ImageAlignment(2);
			buttonBarItem.set_TextAlignment(1);
			this.ButtonBar1.get_Groups().get_Item(0).get_Items().Add(buttonBarItem);
			buttonBarItem.InvokeOnClick();
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0019BA70 File Offset: 0x00199E70
		private void DeleteButtonBarItem(string Name)
		{
			try
			{
				IEnumerator enumerator = this.ButtonBar1.get_Groups().get_Item(0).get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ButtonBarItem buttonBarItem = (ButtonBarItem)enumerator.Current;
					bool flag = Operators.CompareString(buttonBarItem.get_Text(), Name, false) == 0;
					if (flag)
					{
						this.ButtonBar1.get_Groups().get_Item(0).get_Items().Remove(buttonBarItem);
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0019BB1C File Offset: 0x00199F1C
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.userdr == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.users.DeleteUser(Conversions.ToString(this.userdr["ID"]));
					this.DeleteButtonBarItem(Conversions.ToString(this.userdr["UserName"]));
				}
				Public_Function.ConfirmInsert();
				this.ButtonItem1_Click(null, null);
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0019BB98 File Offset: 0x00199F98
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			this.Sync2();
			Public_Function.ShowMessage("اطلاعات مدیریت کاربران بروز رسانی گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x0400046F RID: 1135
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000471 RID: 1137
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000472 RID: 1138
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000473 RID: 1139
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000474 RID: 1140
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000475 RID: 1141
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000476 RID: 1142
		[AccessedThroughProperty("ButtonBar1")]
		private ButtonBar _ButtonBar1;

		// Token: 0x04000477 RID: 1143
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000478 RID: 1144
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000479 RID: 1145
		[AccessedThroughProperty("EditBox2")]
		private EditBox _EditBox2;

		// Token: 0x0400047A RID: 1146
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400047B RID: 1147
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400047C RID: 1148
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400047D RID: 1149
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x0400047E RID: 1150
		private base_user users;

		// Token: 0x0400047F RID: 1151
		private Base_Controls _controls;

		// Token: 0x04000480 RID: 1152
		private Base_User_Control user_control;

		// Token: 0x04000481 RID: 1153
		private DataTable dt;

		// Token: 0x04000482 RID: 1154
		private DataRow dr;

		// Token: 0x04000483 RID: 1155
		private bool is_new;

		// Token: 0x04000484 RID: 1156
		private DataRow userdr;
	}
}
