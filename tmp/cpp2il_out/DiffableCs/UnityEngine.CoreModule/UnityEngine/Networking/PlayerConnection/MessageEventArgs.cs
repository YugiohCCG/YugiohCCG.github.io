namespace UnityEngine.Networking.PlayerConnection;

public class MessageEventArgs
{
	public int playerId; //Field offset: 0x10
	public Byte[] data; //Field offset: 0x18

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MessageEventArgs() { }

}

