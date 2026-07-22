namespace Scenes.Battle.DuelLogging;

public class LogOpSelection : LogEntryContent
{
	[SerializeField]
	private Image PlayerAvatar; //Field offset: 0x20
	[SerializeField]
	private Image Stripe; //Field offset: 0x28
	[SerializeField]
	private TextMeshProUGUI Description; //Field offset: 0x30

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogOpSelection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Setup(ILogEventData data) { }

}

