namespace System.Data;

internal sealed class DataTablePropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; //Field offset: 0x88

	public virtual Type ComponentType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Type PropertyType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	public DataTable Table
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool CanResetValue(object component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public virtual Type get_ComponentType() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public virtual Type get_PropertyType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DataTable get_Table() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "SetIndex2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "SetDataViewManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewManager)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual object GetValue(object component) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void ResetValue(object component) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetValue(object component, object value) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool ShouldSerializeValue(object component) { }

}

