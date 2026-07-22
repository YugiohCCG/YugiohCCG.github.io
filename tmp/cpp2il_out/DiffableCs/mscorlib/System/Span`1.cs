namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct Span
{
	internal readonly ByReference<T> _pointer; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public T Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Intrinsic]
		[NonVersionable]
		 get { } //Length: 49
	}

	public int Length
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[NonVersionable]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Span`1(T[] array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Span`1(T[] array, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidTypeWithPointersNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public Span`1(Void* pointer, int length) { }

	[CallerCount(Count = 371)]
	[DeduplicatedMethod]
	internal Span`1(ref T ptr, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpanHelpers), Member = "ClearWithReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(ulong)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = "System.IO.Path+<>c", Member = "<JoinInternal>b__59_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(System.ValueTuple`5<System.IntPtr, System.Int32, System.IntPtr, System.Int32, System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Byte>"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileSystemName), Member = "MatchPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IO.Path+<>c", Member = "<JoinInternal>b__60_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(System.ValueTuple`8<System.IntPtr, System.Int32, System.IntPtr, System.Int32, System.IntPtr, System.Int32, System.Boolean, System.ValueTuple`1<System.Boolean>>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(File), Member = "ReadAllBytesUnknownLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileStream)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(TextReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.StreamReader+<ReadAsyncInternal>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemoryStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "K4os.Compression.LZ4.LZ4Pickler", Member = "PickleWithBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>", "K4os.Compression.LZ4.LZ4Level", "System.Span`1<Byte>"}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_DestinationTooShort", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void CopyTo(Span<T> destination) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public void Fill(T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Intrinsic]
	[NonVersionable]
	public T get_Item(int index) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[NonVersionable]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 370)]
	[DeduplicatedMethod]
	public T GetPinnableReference() { }

	[CallerCount(Count = 108)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static Span<T> op_Implicit(T[] array) { }

	[CallerCount(Count = 39)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Span<T> Slice(int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Span<T> Slice(int start) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public T[] ToArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(ValueStringBuilder), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ValueListBuilder`1), Member = "Grow", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Generic.ValueListBuilder`1", Member = "Grow", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigIntegerToHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Numerics.BigInteger", typeof(char), typeof(int), typeof(NumberFormatInfo), "System.Span`1<Char>", typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Text.ValueStringBuilder", Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<Char>", typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool TryCopyTo(Span<T> destination) { }

}

