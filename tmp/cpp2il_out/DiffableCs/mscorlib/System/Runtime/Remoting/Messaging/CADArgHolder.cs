namespace System.Runtime.Remoting.Messaging;

internal class CADArgHolder
{
	public int index; //Field offset: 0x10

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CADArgHolder(int i) { }

}

