namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObject
{
	internal int objectId; //Field offset: 0x10
	internal int mapId; //Field offset: 0x14

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BinaryObject() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Read(__BinaryParser input) { }

	[CallerCount(Count = 0)]
	internal void Set(int objectId, int mapId) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void Write(__BinaryWriter sout) { }

}

