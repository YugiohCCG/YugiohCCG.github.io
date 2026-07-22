namespace System.Data;

internal sealed class OperatorInfo
{
	internal Nodes _type; //Field offset: 0x10
	internal int _op; //Field offset: 0x14
	internal int _priority; //Field offset: 0x18

	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal OperatorInfo(Nodes type, int op, int pri) { }

}

