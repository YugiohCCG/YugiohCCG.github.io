namespace System.Data;

internal sealed class RelatedView : DataView, IFilter
{
	private readonly Nullable<DataKey> _parentKey; //Field offset: 0xB8
	private readonly DataKey _childKey; //Field offset: 0xC8
	private readonly DataRowView _parentRowView; //Field offset: 0xD0
	private readonly Object[] _filterValues; //Field offset: 0xD8

	[CalledBy(Type = typeof(DataRowView), Member = "CreateChildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(bool)}, ReturnType = typeof(DataView))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "ResetRowViewCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	public RelatedView(DataColumn[] columns, Object[] values) { }

	[CalledBy(Type = typeof(DataRowView), Member = "CreateChildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(bool)}, ReturnType = typeof(DataView))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "ResetRowViewCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public RelatedView(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "AddNew", ReturnType = typeof(DataRowView))]
	[Calls(Type = typeof(RelatedView), Member = "GetParentValues", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual DataRowView AddNew() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal virtual IFilter GetFilter() { }

	[CalledBy(Type = typeof(RelatedView), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RelatedView), Member = "AddNew", ReturnType = typeof(DataRowView))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataRowView), Member = "HasRecord", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(DataRowView), Member = "GetRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object[]))]
	[CallsUnknownMethods(Count = 1)]
	private Object[] GetParentValues() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RelatedView), Member = "GetParentValues", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override bool Invoke(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataView), Member = "SetIndex2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataViewRowState), typeof(IFilter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataView), Member = "Reset", ReturnType = typeof(void))]
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

