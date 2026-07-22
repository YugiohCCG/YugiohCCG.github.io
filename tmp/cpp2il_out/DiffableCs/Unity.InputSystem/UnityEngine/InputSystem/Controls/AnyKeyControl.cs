namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = True)]
public class AnyKeyControl : ButtonControl
{

	[CalledBy(Type = typeof(FastKeyboard), Member = "Initialize_ctrlKeyboardanyKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(AnyKeyControl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonControl), Member = ".ctor", ReturnType = typeof(void))]
	public AnyKeyControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(Void*)}, ReturnType = typeof(bool))]
	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

}

