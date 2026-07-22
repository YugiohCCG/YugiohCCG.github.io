namespace Extensions;

public class CyclicDropdown : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private TMP_Dropdown Base; //Field offset: 0x20

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CyclicDropdown() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkey), Member = "get_IsDoubleTouching", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "Hide", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "get_options", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Dropdown+OptionData>))]
	[Calls(Type = typeof(TMP_Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerClick(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void Start() { }

}

