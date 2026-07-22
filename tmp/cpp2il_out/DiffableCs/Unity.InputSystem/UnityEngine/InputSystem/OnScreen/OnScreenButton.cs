namespace UnityEngine.InputSystem.OnScreen;

[AddComponentMenu("Input/On-Screen Button")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/OnScreen.html#on-screen-buttons")]
public class OnScreenButton : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[InputControl(layout = "Button")]
	[SerializeField]
	private string m_ControlPath; //Field offset: 0x38

	protected virtual string controlPathInternal
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public OnScreenButton() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	protected virtual string get_controlPathInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OnScreenControl), Member = "SendValueToControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	public override void OnPointerDown(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OnScreenControl), Member = "SendValueToControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	public override void OnPointerUp(PointerEventData eventData) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void set_controlPathInternal(string value) { }

}

