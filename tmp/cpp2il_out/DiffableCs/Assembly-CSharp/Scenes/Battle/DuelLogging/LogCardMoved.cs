namespace Scenes.Battle.DuelLogging;

public class LogCardMoved : LogEntryContent
{
	[SerializeField]
	private Image PlayerAvatar; //Field offset: 0x20
	[SerializeField]
	private Image Stripe; //Field offset: 0x28
	[SerializeField]
	private LogCardEntry CardArt; //Field offset: 0x30
	[SerializeField]
	private Image PrevLoc; //Field offset: 0x38
	[SerializeField]
	private Image CurLoc; //Field offset: 0x40
	[SerializeField]
	private Image ReasonIcon; //Field offset: 0x48

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogCardMoved() { }

	[CalledBy(Type = typeof(LogCardMoved), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ILogEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	private string GetReasonIconName(Reason r) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LogManager), Member = "GetLocationIconName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LogCardMoved), Member = "GetReasonIconName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Reason)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Setup(ILogEventData data) { }

}

