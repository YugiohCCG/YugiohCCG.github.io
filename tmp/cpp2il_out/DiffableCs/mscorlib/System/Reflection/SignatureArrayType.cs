namespace System.Reflection;

internal sealed class SignatureArrayType : SignatureHasElementType
{
	private readonly int _rank; //Field offset: 0x20
	private readonly bool _isMultiDim; //Field offset: 0x24

	public virtual bool IsSZArray
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual bool IsVariableBoundArray
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected virtual string Suffix
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 163
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim) { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool get_IsSZArray() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool get_IsVariableBoundArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	protected virtual string get_Suffix() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetArrayRank() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected virtual bool IsArrayImpl() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected virtual bool IsByRefImpl() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected virtual bool IsPointerImpl() { }

}

