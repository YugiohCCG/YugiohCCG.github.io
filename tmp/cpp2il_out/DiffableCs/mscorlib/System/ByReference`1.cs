namespace System;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ByReference
{
	private IntPtr _value; //Field offset: 0x0

	public T Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Intrinsic]
		 get { } //Length: 57
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Intrinsic]
	public ByReference`1(ref T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Intrinsic]
	public T get_Value() { }

}

