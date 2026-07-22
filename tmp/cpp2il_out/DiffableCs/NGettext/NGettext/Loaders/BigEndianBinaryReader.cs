namespace NGettext.Loaders;

public class BigEndianBinaryReader : BinaryReader
{
	private Byte[] _Buffer; //Field offset: 0x48

	[CalledBy(Type = typeof(BigEndianBinaryReader), Member = "ReadInt16", ReturnType = typeof(short))]
	[CalledBy(Type = typeof(BigEndianBinaryReader), Member = "ReadUInt16", ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(BigEndianBinaryReader), Member = "ReadInt32", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BigEndianBinaryReader), Member = "ReadUInt32", ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(BigEndianBinaryReader), Member = "ReadInt64", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(BigEndianBinaryReader), Member = "ReadUInt64", ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(BigEndianBinaryReader), Member = "ReadSingle", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(BigEndianBinaryReader), Member = "ReadDouble", ReturnType = typeof(double))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private void _FillBuffer(int numBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public BigEndianBinaryReader(Stream input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public BigEndianBinaryReader(Stream input, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigEndianBinaryReader), Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverter), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(double))]
	public virtual double ReadDouble() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigEndianBinaryReader), Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual short ReadInt16() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigEndianBinaryReader), Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual int ReadInt32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigEndianBinaryReader), Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual long ReadInt64() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigEndianBinaryReader), Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(float))]
	public virtual float ReadSingle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigEndianBinaryReader), Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public virtual ushort ReadUInt16() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigEndianBinaryReader), Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public virtual uint ReadUInt32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigEndianBinaryReader), Member = "_FillBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public virtual ulong ReadUInt64() { }

}

