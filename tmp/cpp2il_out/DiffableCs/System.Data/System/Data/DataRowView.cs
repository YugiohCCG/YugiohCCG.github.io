namespace System.Data;

[DefaultMember("Item")]
public class DataRowView : ICustomTypeDescriptor, INotifyPropertyChanged
{
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; //Field offset: 0x0
	private readonly DataView _dataView; //Field offset: 0x10
	private readonly DataRow _row; //Field offset: 0x18
	private bool _delayBeginEdit; //Field offset: 0x20
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x28

	public DataView DataView
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsNew
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 34
	}

	public DataRow Row
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private DataRowVersion RowVersionDefault
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 88
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static DataRowView() { }

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal DataRowView(DataView dataView, DataRow row) { }

	[CalledBy(Type = typeof(DataRelationPropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataRowView), Member = "CreateChildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(DataView))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRelation), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(RelatedView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView), typeof(DataKey), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(RelatedView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "SetDataViewManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CreateChildView", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRowView), Member = "CreateChildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(bool)}, ReturnType = typeof(DataView))]
	public DataView CreateChildView(DataRelation relation) { }

	[CalledBy(Type = typeof(DataView), Member = "AddNew", ReturnType = typeof(DataRowView))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "EndEdit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "FinishAddNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void EndEdit() { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public DataView get_DataView() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsNew() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public DataRow get_Row() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private DataRowVersion get_RowVersionDefault() { }

	[CalledBy(Type = typeof(DataColumnPropertyDescriptor), Member = "CanResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataColumnPropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInTheTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	internal object GetColumnValue(DataColumn column) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(RelatedView), Member = "GetParentValues", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal int GetRecord() { }

	[CalledBy(Type = typeof(RelatedView), Member = "GetParentValues", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool HasRecord() { }

	[CalledBy(Type = typeof(DataView), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void RaisePropertyChangedEvent(string propName) { }

	[CalledBy(Type = typeof(DataColumnPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRow), Member = "BeginEditInternal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "SetFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void SetColumnValue(DataColumn column, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor[])}, ReturnType = typeof(void))]
	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDescriptor[])}, ReturnType = typeof(void))]
	private override EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "GetPropertyDescriptorCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CallsUnknownMethods(Count = 1)]
	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

