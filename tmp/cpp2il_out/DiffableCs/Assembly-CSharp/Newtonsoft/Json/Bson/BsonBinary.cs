namespace Newtonsoft.Json.Bson;

internal class BsonBinary : BsonValue
{
	[CompilerGenerated]
	private BsonBinaryType <BinaryType>k__BackingField; //Field offset: 0x30

	public BsonBinaryType BinaryType
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public BsonBinary(Byte[] value, BsonBinaryType binaryType) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BsonBinaryType get_BinaryType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_BinaryType(BsonBinaryType value) { }

}

