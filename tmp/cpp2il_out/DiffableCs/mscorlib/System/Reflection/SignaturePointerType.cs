namespace System.Reflection;

internal sealed class SignaturePointerType : SignatureHasElementType
{

	public virtual bool IsSZArray
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool IsVariableBoundArray
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	protected virtual string Suffix
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SignaturePointerType(SignatureType elementType) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsSZArray() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsVariableBoundArray() { }

	[CallerCount(Count = 0)]
	protected virtual string get_Suffix() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual int GetArrayRank() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected virtual bool IsArrayImpl() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	protected virtual bool IsByRefImpl() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected virtual bool IsPointerImpl() { }

}

