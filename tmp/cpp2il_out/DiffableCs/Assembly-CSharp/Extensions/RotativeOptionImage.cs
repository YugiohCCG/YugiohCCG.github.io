namespace Extensions;

public class RotativeOptionImage : MonoBehaviour
{
	private Image OptionDisplay; //Field offset: 0x20
	private String[] Options; //Field offset: 0x28
	private int Index; //Field offset: 0x30
	private Action<Int32> Callback; //Field offset: 0x38
	private AssetType ImageKind; //Field offset: 0x40

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RotativeOptionImage() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void IncreaseIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RotativeOptionImage), Member = "UpdateImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnTap(PointerEventData e) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	public void Setup(int index, AssetType type, Action<Int32> cb, String[] args) { }

	[CalledBy(Type = typeof(RotativeOptionImage), Member = "OnTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateImage(int index) { }

}

