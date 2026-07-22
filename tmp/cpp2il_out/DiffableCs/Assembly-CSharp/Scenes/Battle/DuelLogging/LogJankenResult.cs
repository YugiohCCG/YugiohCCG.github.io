namespace Scenes.Battle.DuelLogging;

public class LogJankenResult : LogEntryContent
{
	[SerializeField]
	private Image P1Avatar; //Field offset: 0x20
	[SerializeField]
	private Image P2Avatar; //Field offset: 0x28
	[SerializeField]
	private Image P1Sel; //Field offset: 0x30
	[SerializeField]
	private Image P2Sel; //Field offset: 0x38
	[SerializeField]
	private Image Stripe; //Field offset: 0x40

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogJankenResult() { }

	[CallerCount(Count = 0)]
	private string GetHandSpriteName(byte hand) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Setup(ILogEventData data) { }

}

