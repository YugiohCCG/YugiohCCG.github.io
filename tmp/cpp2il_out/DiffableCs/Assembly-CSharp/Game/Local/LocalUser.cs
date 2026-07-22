namespace Game.Local;

public class LocalUser
{
	public long ID; //Field offset: 0x10
	public string Username; //Field offset: 0x18
	public string Avatar; //Field offset: 0x20

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LocalUser() { }

}

