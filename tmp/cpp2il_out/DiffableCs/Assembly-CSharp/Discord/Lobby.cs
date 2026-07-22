namespace Discord;

public struct Lobby
{
	public long Id; //Field offset: 0x0
	public LobbyType Type; //Field offset: 0x8
	public long OwnerId; //Field offset: 0x10
	public string Secret; //Field offset: 0x18
	public uint Capacity; //Field offset: 0x20
	public bool Locked; //Field offset: 0x24

}

