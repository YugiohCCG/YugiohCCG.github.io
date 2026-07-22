namespace UnityEngine.InputSystem.Controls;

public class DoubleControl : InputControl<Double>
{

	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreenprimaryTouchstartTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch0startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch1startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch2startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch3startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch4startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch5startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch6startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch7startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch8startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CalledBy(Type = typeof(FastTouchscreen), Member = "Initialize_ctrlTouchscreentouch9startTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(DoubleControl))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(InputControl`1), Member = ".ctor", ReturnType = typeof(void))]
	public DoubleControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "ReadDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(double))]
	public virtual double ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBlock), Member = "WriteDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(double)}, ReturnType = typeof(void))]
	public virtual void WriteValueIntoState(double value, Void* statePtr) { }

}

