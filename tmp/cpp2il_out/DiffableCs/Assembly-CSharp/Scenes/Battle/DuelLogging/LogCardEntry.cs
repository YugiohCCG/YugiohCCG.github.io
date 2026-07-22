namespace Scenes.Battle.DuelLogging;

public class LogCardEntry : MonoBehaviour
{
	[SerializeField]
	private Image Race; //Field offset: 0x20
	[SerializeField]
	private Image Attribute; //Field offset: 0x28
	[SerializeField]
	private Image Frame; //Field offset: 0x30
	[SerializeField]
	private Image Art; //Field offset: 0x38
	private CardDataLog EntryData; //Field offset: 0x40

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LogCardEntry() { }

	[CalledBy(Type = typeof(LogCardEntry), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardDataLog)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetTypeFrameName(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DisplayCard), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnScroll(PointerEventData eventData) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(LogCardEntry), Member = "GetTypeFrameName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetRaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Template), Member = "AttributeDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(string), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "LoadAsset", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssetType), typeof(int), "System.Action`2<T, Object>", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(General), Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "AddTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour), typeof(EventTriggerType), typeof(System.Action`1<UnityEngine.EventSystems.PointerEventData>)}, ReturnType = typeof(EventTrigger))]
	[Calls(Type = typeof(General), Member = "ClearTriggers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public void SetData(CardDataLog log) { }

}

