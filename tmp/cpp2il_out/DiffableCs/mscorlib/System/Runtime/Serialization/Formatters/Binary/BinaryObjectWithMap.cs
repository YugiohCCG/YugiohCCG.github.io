namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObjectWithMap
{
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	internal int objectId; //Field offset: 0x14
	internal string name; //Field offset: 0x18
	internal int numMembers; //Field offset: 0x20
	internal String[] memberNames; //Field offset: 0x28
	internal int assemId; //Field offset: 0x30

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BinaryObjectWithMap() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	public override void Read(__BinaryParser input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void Set(int objectId, string name, int numMembers, String[] memberNames, int assemId) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public override void Write(__BinaryWriter sout) { }

}

