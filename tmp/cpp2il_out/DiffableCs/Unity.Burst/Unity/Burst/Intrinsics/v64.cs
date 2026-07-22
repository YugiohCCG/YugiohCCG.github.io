namespace Unity.Burst.Intrinsics;

[DebuggerTypeProxy(typeof(V64DebugView))]
public struct v64
{
	public byte Byte0; //Field offset: 0x0
	public float Float0; //Field offset: 0x0
	public long SLong0; //Field offset: 0x0
	public ulong ULong0; //Field offset: 0x0
	public int SInt0; //Field offset: 0x0
	public uint UInt0; //Field offset: 0x0
	public short SShort0; //Field offset: 0x0
	public sbyte SByte0; //Field offset: 0x0
	public ushort UShort0; //Field offset: 0x0
	public double Double0; //Field offset: 0x0
	public byte Byte1; //Field offset: 0x1
	public sbyte SByte1; //Field offset: 0x1
	public sbyte SByte2; //Field offset: 0x2
	public byte Byte2; //Field offset: 0x2
	public ushort UShort1; //Field offset: 0x2
	public short SShort1; //Field offset: 0x2
	public byte Byte3; //Field offset: 0x3
	public sbyte SByte3; //Field offset: 0x3
	public sbyte SByte4; //Field offset: 0x4
	public int SInt1; //Field offset: 0x4
	public byte Byte4; //Field offset: 0x4
	public uint UInt1; //Field offset: 0x4
	public short SShort2; //Field offset: 0x4
	public ushort UShort2; //Field offset: 0x4
	public float Float1; //Field offset: 0x4
	public byte Byte5; //Field offset: 0x5
	public sbyte SByte5; //Field offset: 0x5
	public short SShort3; //Field offset: 0x6
	public ushort UShort3; //Field offset: 0x6
	public sbyte SByte6; //Field offset: 0x6
	public byte Byte6; //Field offset: 0x6
	public sbyte SByte7; //Field offset: 0x7
	public byte Byte7; //Field offset: 0x7

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public v64(byte b) { }

	[CalledBy(Type = typeof(Neon), Member = "vfmad_lane_f64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(v64), typeof(int)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Neon), Member = "vfmsd_lane_f64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(v64), typeof(int)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Neon), Member = "vset_lane_f64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(v64), typeof(int)}, ReturnType = typeof(v64))]
	[CalledBy(Type = typeof(Neon), Member = "vdup_n_f64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(v64))]
	[CalledBy(Type = typeof(Neon), Member = "vmov_n_f64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(v64))]
	[CallerCount(Count = 7)]
	public v64(double a) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public v64(float a, float b) { }

	[CalledBy(Type = typeof(Neon), Member = "vdup_n_f32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(v64))]
	[CalledBy(Type = typeof(Neon), Member = "vmov_n_f32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(v64))]
	[CallerCount(Count = 2)]
	public v64(float f) { }

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public v64(uint a, uint b) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public v64(uint v) { }

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public v64(int a, int b) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public v64(long a) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public v64(int v) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public v64(ushort v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public v64(short a, short b, short c, short d) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public v64(short v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public v64(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public v64(sbyte b) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public v64(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public v64(ushort a, ushort b, ushort c, ushort d) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public v64(ulong a) { }

}

