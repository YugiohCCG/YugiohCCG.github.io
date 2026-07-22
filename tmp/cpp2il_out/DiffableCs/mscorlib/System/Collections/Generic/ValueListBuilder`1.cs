namespace System.Collections.Generic;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ValueListBuilder
{
	private Span<T> _span; //Field offset: 0x0
	private T[] _arrayFromPool; //Field offset: 0x0
	private int _pos; //Field offset: 0x0

	public int Length
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ValueListBuilder`1(Span<T> initialSpan) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Append(T item) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ReadOnlySpan<T> AsSpan() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void Dispose() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Span`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	private void Grow() { }

}

