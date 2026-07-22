namespace UI.Dates;

public class DatePicker_HoldButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public MonoBehaviour[] target; //Field offset: 0x10
		public String[] method; //Field offset: 0x18
		public int eventCount; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBehaviour), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <Start>b__0() { }

	}

	public Button Button; //Field offset: 0x20
	public float Delay; //Field offset: 0x28
	private bool pointerDown; //Field offset: 0x2C
	private Action action; //Field offset: 0x30
	private float lastInvokeTime; //Field offset: 0x38
	private int executionCount; //Field offset: 0x3C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DatePicker_HoldButton() { }

	[CalledBy(Type = typeof(DatePicker_HoldButton), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Execute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	public override void OnPointerUp(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEventBase), Member = "GetPersistentEventCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEventBase), Member = "GetPersistentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(UnityEventBase), Member = "GetPersistentMethodName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ButtonClickedEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(DatePicker_HoldButton), Member = "Execute", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

}

