namespace System.Data;

internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	private readonly DataColumn <Column>k__BackingField; //Field offset: 0x88

	public virtual AttributeCollection Attributes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(MemberDescriptor), Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
		[Calls(Type = typeof(AttributeCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ListBindableAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 452
	}

	internal DataColumn Column
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public virtual Type ComponentType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public virtual Type PropertyType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	[CalledBy(Type = typeof(DataTable), Member = "GetPropertyDescriptorCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.get_SortProperty", ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = typeof(DataView), Member = "GetSortProperty", ReturnType = typeof(PropertyDescriptor))]
	[CalledBy(Type = typeof(DataView), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "ColumnCollectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CollectionChangeEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal DataColumnPropertyDescriptor(DataColumn dataColumn) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRowView), Member = "GetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool CanResetValue(object component) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemberDescriptor), Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
	[Calls(Type = typeof(AttributeCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListBindableAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public virtual AttributeCollection get_Attributes() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal DataColumn get_Column() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public virtual Type get_ComponentType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_PropertyType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRowView), Member = "GetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public virtual object GetValue(object component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRowView), Member = "SetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void ResetValue(object component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRowView), Member = "SetColumnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetValue(object component, object value) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool ShouldSerializeValue(object component) { }

}

