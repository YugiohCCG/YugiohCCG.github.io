namespace Scenes.Battle.DuelLogging;

public class LogRandomSelected : LogEntryContent
{
	[SerializeField]
	private Image PlayerAvatar; //Field offset: 0x20
	[SerializeField]
	private Image Stripe; //Field offset: 0x28
	[SerializeField]
	private LogCardEntry CardArt; //Field offset: 0x30

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogRandomSelected() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Setup(ILogEventData data) { }

}

