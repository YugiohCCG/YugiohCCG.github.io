namespace System.Data;

[IsReadOnly]
internal struct IndexField
{
	public readonly DataColumn Column; //Field offset: 0x0
	public readonly bool IsDescending; //Field offset: 0x8

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal IndexField(DataColumn column, bool isDescending) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(IndexField if1, IndexField if2) { }

}

