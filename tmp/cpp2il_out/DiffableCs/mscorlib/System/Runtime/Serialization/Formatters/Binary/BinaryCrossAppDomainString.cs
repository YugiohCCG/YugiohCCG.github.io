namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryCrossAppDomainString
{
	internal int objectId; //Field offset: 0x10
	internal int value; //Field offset: 0x14

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BinaryCrossAppDomainString() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Read(__BinaryParser input) { }

}

