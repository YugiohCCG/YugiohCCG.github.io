namespace Newtonsoft.Json.Bson;

internal class BsonString : BsonValue
{
	[CompilerGenerated]
	private int <ByteCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly bool <IncludeLength>k__BackingField; //Field offset: 0x34

	public int ByteCount
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool IncludeLength
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public BsonString(object value, bool includeLength) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_ByteCount() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IncludeLength() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ByteCount(int value) { }

}

