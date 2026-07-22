namespace System.Collections.Generic;

internal class ByteEqualityComparer : EqualityComparer<Byte>
{

	[CalledBy(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ByteEqualityComparer() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(byte x, byte y) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode(byte b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "IndexOfByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(byte), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	internal virtual int IndexOf(Byte[] array, byte value, int startIndex, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual int LastIndexOf(Byte[] array, byte value, int startIndex, int count) { }

}

