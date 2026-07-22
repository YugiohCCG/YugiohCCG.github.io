namespace Scenes.Battle.DuelLogging;

public class DuelLogger : DraggableFrame
{
	private PooledScrollRectController LogArea; //Field offset: 0x98
	private ScrollRect LogScroll; //Field offset: 0xA0
	private bool EnabledThisFrame; //Field offset: 0xA8

	public bool IsDisplaying
	{
		[CalledBy(Type = typeof(DuelZone), Member = "ToggleVisualLog", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 35
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DraggableFrame), Member = ".ctor", ReturnType = typeof(void))]
	public DuelLogger() { }

	[CallerCount(Count = 47)]
	[Calls(Type = typeof(PooledScrollRectBase), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPooledData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AddLog(ILogEventData log) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake() { }

	[CalledBy(Type = typeof(DuelZone), Member = "ToggleVisualLog", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_IsDisplaying() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(General), Member = "ScrollToBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollRect)}, ReturnType = typeof(void))]
	private void LateUpdate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnScroll(PointerEventData eventData) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleLog(bool state) { }

	[CalledBy(Type = typeof(DuelZone), Member = "ToggleVisualLog", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ToggleLog() { }

}

