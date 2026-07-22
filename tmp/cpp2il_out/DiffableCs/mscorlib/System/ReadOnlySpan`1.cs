namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView`1))]
[DefaultMember("Item")]
[IsByRefLike]
[IsReadOnly]
[NonVersionable]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct ReadOnlySpan
{
	internal readonly ByReference<T> _pointer; //Field offset: 0x0
	private readonly int _length; //Field offset: 0x0

	public static ReadOnlySpan<T> Empty
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 10
	}

	public bool IsEmpty
	{
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[NonVersionable]
		 get { } //Length: 8
	}

	[IsReadOnly]
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
	public ReadOnlySpan`1(T[] array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ReadOnlySpan`1(T[] array, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidTypeWithPointersNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public ReadOnlySpan`1(Void* pointer, int length) { }

	[CallerCount(Count = 371)]
	[DeduplicatedMethod]
	internal ReadOnlySpan`1(ref T ptr, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_DestinationTooShort", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void CopyTo(Span<T> destination) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static ReadOnlySpan<T> get_Empty() { }

	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public bool get_IsEmpty() { }

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
	[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 370)]
	[DeduplicatedMethod]
	public T GetPinnableReference() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = "GetRawRenderer", ReturnType = "UnityEngine.Rendering.Universal.ScriptableRenderer")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(ReadOnlySpan<T> left, ReadOnlySpan<T> right) { }

	[CallerCount(Count = 108)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static ReadOnlySpan<T> op_Implicit(T[] array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnlySpan<T> Slice(int start) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnlySpan<T> Slice(int start, int length) { }

	[CalledBy(Type = "System.Text.RegularExpressions.RegexWriter", Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.RegularExpressions.RegexTree"}, ReturnType = "System.Text.RegularExpressions.RegexCode")]
	[CalledBy(Type = "System.IO.Compression.GZipStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.NoAllocHelpers", Member = "ResetListContents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "System.ReadOnlySpan`1<T>"}, ReturnType = typeof(void))]
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

	[CalledBy(Type = typeof(Number), Member = "TryFormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryFormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Numerics.BigInteger", typeof(string), "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo), "System.Span`1<Char>", typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memmove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool TryCopyTo(Span<T> destination) { }

}

