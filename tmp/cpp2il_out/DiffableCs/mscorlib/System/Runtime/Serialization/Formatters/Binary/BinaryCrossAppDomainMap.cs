namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryCrossAppDomainMap
{
	internal int crossAppDomainArrayIndex; //Field offset: 0x10

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BinaryCrossAppDomainMap() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Read(__BinaryParser input) { }

}

