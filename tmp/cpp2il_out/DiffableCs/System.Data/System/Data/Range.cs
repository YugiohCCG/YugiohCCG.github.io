namespace System.Data;

internal struct Range
{
	private int _min; //Field offset: 0x0
	private int _max; //Field offset: 0x4
	private bool _isNotNull; //Field offset: 0x8

	public int Count
	{
		[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
		[CallerCount(Count = 2)]
		 get { } //Length: 17
	}

	public bool IsNull
	{
		[CalledBy(Type = typeof(DataTable), Member = "FindByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index), typeof(Object[])}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 8
	}

	public int Min
	{
		[CalledBy(Type = typeof(DataTable), Member = "FindByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index), typeof(Object[])}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
		[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "NullRange", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RangeArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public Range(int min, int max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NullRange", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal void CheckNull() { }

	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 2)]
	public int get_Count() { }

	[CalledBy(Type = typeof(DataTable), Member = "FindByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index), typeof(Object[])}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool get_IsNull() { }

	[CalledBy(Type = typeof(DataTable), Member = "FindByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index), typeof(Object[])}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataView), Member = "System.ComponentModel.IBindingList.Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "NullRange", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public int get_Min() { }

}

