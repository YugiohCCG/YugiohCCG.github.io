namespace Discord;

public struct Activity
{
	public ActivityType Type; //Field offset: 0x0
	public long ApplicationId; //Field offset: 0x8
	public string Name; //Field offset: 0x10
	public string State; //Field offset: 0x18
	public string Details; //Field offset: 0x20
	public ActivityTimestamps Timestamps; //Field offset: 0x28
	public ActivityAssets Assets; //Field offset: 0x38
	public ActivityParty Party; //Field offset: 0x58
	public ActivitySecrets Secrets; //Field offset: 0x70
	public bool Instance; //Field offset: 0x88
	public uint SupportedPlatforms; //Field offset: 0x8C

}

