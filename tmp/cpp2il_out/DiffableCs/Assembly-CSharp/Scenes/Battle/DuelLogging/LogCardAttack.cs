namespace Scenes.Battle.DuelLogging;

public class LogCardAttack : LogEntryContent
{
	[SerializeField]
	private Image PlayerAvatar; //Field offset: 0x20
	[SerializeField]
	private LogCardEntry Attacker; //Field offset: 0x28
	[SerializeField]
	private LogCardEntry Defender; //Field offset: 0x30
	[SerializeField]
	private Image Stripe; //Field offset: 0x38

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogCardAttack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Setup(ILogEventData data) { }

}

