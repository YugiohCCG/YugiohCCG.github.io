namespace Discord;

public struct UserAchievement
{
	public long UserId; //Field offset: 0x0
	public long AchievementId; //Field offset: 0x8
	public byte PercentComplete; //Field offset: 0x10
	public string UnlockedAt; //Field offset: 0x18

}

