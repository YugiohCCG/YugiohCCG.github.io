namespace Scenes.Battle.DuelLogging;

public struct PlayerDataLog
{
	public Texture2D Avatar; //Field offset: 0x0
	public string Username; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_Avatar", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	public PlayerDataLog(Player p) { }

	[CallerCount(Count = 50)]
	[Calls(Type = typeof(Player), Member = "get_Avatar", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Player), Member = "get_Username", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public PlayerDataLog(byte p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerDataLog), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	public PlayerDataLog(int p) { }

}

