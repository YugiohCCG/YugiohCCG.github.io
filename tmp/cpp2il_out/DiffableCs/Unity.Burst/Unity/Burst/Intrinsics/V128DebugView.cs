namespace Unity.Burst.Intrinsics;

internal class V128DebugView
{
	private v128 m_Value; //Field offset: 0x10

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public Byte[] Byte
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 322
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public Double[] Double
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 104
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public Single[] Float
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 130
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public SByte[] SByte
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 322
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public Int32[] SInt
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 130
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public Int64[] SLong
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 104
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public Int16[] SShort
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 194
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public UInt32[] UInt
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 130
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public UInt64[] ULong
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 104
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Collapsed (2))]
	public UInt16[] UShort
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 194
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public V128DebugView(v128 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Byte[] get_Byte() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Double[] get_Double() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Single[] get_Float() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public SByte[] get_SByte() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Int32[] get_SInt() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Int64[] get_SLong() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Int16[] get_SShort() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public UInt32[] get_UInt() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public UInt64[] get_ULong() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public UInt16[] get_UShort() { }

}

