namespace Scenes.Battle.DuelLogging;

public class LogRemoveCounter : LogEntryContent
{
	[SerializeField]
	private Image PlayerAvatar; //Field offset: 0x20
	[SerializeField]
	private Image Stripe; //Field offset: 0x28
	[SerializeField]
	private Image PrevCounter; //Field offset: 0x30
	[SerializeField]
	private TextMeshProUGUI PrevAmount; //Field offset: 0x38
	[SerializeField]
	private TextMeshProUGUI Change; //Field offset: 0x40
	[SerializeField]
	private Image CurCounter; //Field offset: 0x48
	[SerializeField]
	private TextMeshProUGUI CurAmount; //Field offset: 0x50
	[SerializeField]
	private LogCardEntry Card; //Field offset: 0x58

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogRemoveCounter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "SetImageSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	private void CounterLoaded(Sprite spr, object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Setup(ILogEventData data) { }

}

