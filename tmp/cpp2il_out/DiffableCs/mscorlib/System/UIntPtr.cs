namespace System;

[CLSCompliant(False)]
[ComVisible(True)]
[IsReadOnly]
public struct UIntPtr : ISerializable, IEquatable<UIntPtr>
{
	public static readonly UIntPtr Zero; //Field offset: 0x0
	private readonly Void* _pointer; //Field offset: 0x0

	public static int Size
	{
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	private static UIntPtr() { }

	[CallerCount(Count = 26)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public UIntPtr(Void* value) { }

	[CallerCount(Count = 0)]
	public UIntPtr(ulong value) { }

	[CallerCount(Count = 0)]
	public UIntPtr(uint value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static int get_Size() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	public static UIntPtr op_Explicit(ulong value) { }

	[CallerCount(Count = 2063)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static UIntPtr op_Explicit(Void* value) { }

	[CallerCount(Count = 2063)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static Void* op_Explicit(UIntPtr value) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static UIntPtr op_Explicit(uint value) { }

	[CallerCount(Count = 544)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	[CallerCount(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override bool System.IEquatable<System.UIntPtr>.Equals(UIntPtr other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 138)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public Void* ToPointer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

