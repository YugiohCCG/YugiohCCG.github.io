namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryCrossAppDomainAssembly
{
	internal int assemId; //Field offset: 0x10
	internal int assemblyIndex; //Field offset: 0x14

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BinaryCrossAppDomainAssembly() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Read(__BinaryParser input) { }

}

