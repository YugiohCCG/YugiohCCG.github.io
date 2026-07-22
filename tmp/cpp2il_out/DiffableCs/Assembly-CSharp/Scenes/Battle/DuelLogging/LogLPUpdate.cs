namespace Scenes.Battle.DuelLogging;

public class LogLPUpdate : LogEntryContent
{
	[SerializeField]
	private Image PlayerAvatar; //Field offset: 0x20
	[SerializeField]
	private Image Stripe; //Field offset: 0x28
	[SerializeField]
	private TextMeshProUGUI OldLP; //Field offset: 0x30
	[SerializeField]
	private TextMeshProUGUI Change; //Field offset: 0x38
	[SerializeField]
	private TextMeshProUGUI NewLP; //Field offset: 0x40

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogLPUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Setup(ILogEventData data) { }

}

