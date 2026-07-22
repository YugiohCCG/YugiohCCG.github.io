namespace System.Net.Sockets;

public struct IPPacketInformation
{
	private IPAddress address; //Field offset: 0x0
	private int networkInterface; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(object comparand) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

}

