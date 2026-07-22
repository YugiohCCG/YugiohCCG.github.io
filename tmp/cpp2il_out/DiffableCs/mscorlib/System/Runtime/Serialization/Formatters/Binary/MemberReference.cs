namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class MemberReference
{
	internal int idRef; //Field offset: 0x10

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MemberReference() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Read(__BinaryParser input) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal void Set(int idRef) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Write(__BinaryWriter sout) { }

}

