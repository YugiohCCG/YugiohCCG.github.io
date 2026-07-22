namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafeBitArrayDebugView
{
	private UnsafeBitArray Data; //Field offset: 0x10

	public Boolean[] Bits
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Bitwise), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 148
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnsafeBitArrayDebugView(UnsafeBitArray data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public Boolean[] get_Bits() { }

}

