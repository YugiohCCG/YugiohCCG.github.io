namespace Scenes.Battle.DuelLogging;

public class LogNewTurn : LogEntryContent
{
	[SerializeField]
	private TextMeshProUGUI TurnLabel; //Field offset: 0x20
	[SerializeField]
	private Image P1Avatar; //Field offset: 0x28
	[SerializeField]
	private Image P2Avatar; //Field offset: 0x30
	[SerializeField]
	private TextMeshProUGUI P1LP; //Field offset: 0x38
	[SerializeField]
	private TextMeshProUGUI P2LP; //Field offset: 0x40
	[SerializeField]
	private Image Stripe; //Field offset: 0x48

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogNewTurn() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Setup(ILogEventData data) { }

}

