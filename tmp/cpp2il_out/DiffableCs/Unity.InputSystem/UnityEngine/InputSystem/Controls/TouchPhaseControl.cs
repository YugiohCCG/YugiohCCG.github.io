namespace UnityEngine.InputSystem.Controls;

[InputControlLayout(hideInUI = True)]
public class TouchPhaseControl : InputControl<TouchPhase>
{

	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreenprimaryTouchphase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch0phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch1phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch2phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch3phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch4phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch5phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch6phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch7phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch8phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch9phase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(TouchPhaseControl))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(InputControl`1), Member = ".ctor", ReturnType = typeof(void))]
	public TouchPhaseControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(int))]
	public virtual TouchPhase ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	public virtual void WriteValueIntoState(TouchPhase value, Void* statePtr) { }

}

