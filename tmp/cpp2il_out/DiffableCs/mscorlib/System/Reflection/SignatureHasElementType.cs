namespace System.Reflection;

internal abstract class SignatureHasElementType : SignatureType
{
	private readonly SignatureType _elementType; //Field offset: 0x18

	public virtual bool ContainsGenericParameters
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	internal virtual SignatureType ElementType
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual int GenericParameterPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
	}

	public virtual Type[] GenericTypeArguments
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 48
	}

	public virtual bool IsConstructedGenericType
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool IsGenericMethodParameter
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool IsGenericParameter
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool IsGenericTypeDefinition
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public abstract bool IsSZArray
	{
		 get { } //Length: 0
	}

	public abstract bool IsVariableBoundArray
	{
		 get { } //Length: 0
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 91
	}

	public virtual string Namespace
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	protected abstract string Suffix
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected SignatureHasElementType(SignatureType elementType) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool get_ContainsGenericParameters() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal virtual SignatureType get_ElementType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual int get_GenericParameterPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Type[] get_GenericTypeArguments() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsConstructedGenericType() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsGenericMethodParameter() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsGenericParameter() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_IsGenericTypeDefinition() { }

	public abstract bool get_IsSZArray() { }

	public abstract bool get_IsVariableBoundArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_Namespace() { }

	protected abstract string get_Suffix() { }

	public abstract int GetArrayRank() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Type[] GetGenericArguments() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual Type GetGenericTypeDefinition() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	protected virtual bool HasElementTypeImpl() { }

	protected abstract bool IsArrayImpl() { }

	protected abstract bool IsByRefImpl() { }

	protected abstract bool IsPointerImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

