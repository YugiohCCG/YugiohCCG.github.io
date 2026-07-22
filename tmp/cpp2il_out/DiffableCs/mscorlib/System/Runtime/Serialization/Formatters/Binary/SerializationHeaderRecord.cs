namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerializationHeaderRecord
{
	internal int binaryFormatterMajorVersion; //Field offset: 0x10
	internal int binaryFormatterMinorVersion; //Field offset: 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x18
	internal int topId; //Field offset: 0x1C
	internal int headerId; //Field offset: 0x20
	internal int majorVersion; //Field offset: 0x24
	internal int minorVersion; //Field offset: 0x28

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SerializationHeaderRecord() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static int GetInt32(Byte[] buffer, int index) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(__Error), Member = "EndOfFile", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public override void Read(__BinaryParser input) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public override void Write(__BinaryWriter sout) { }

}

