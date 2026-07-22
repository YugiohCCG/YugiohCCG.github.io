namespace Scenes.Battle.DuelLogging;

public class LogNewPhase : LogEntryContent
{
	[SerializeField]
	private TextMeshProUGUI PhaseLabel; //Field offset: 0x20
	[SerializeField]
	private Image Stripe; //Field offset: 0x28
	[SerializeField]
	private Image PhaseIcon; //Field offset: 0x30

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogNewPhase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetPhaseIconName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetPhaseName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Setup(ILogEventData data) { }

}

