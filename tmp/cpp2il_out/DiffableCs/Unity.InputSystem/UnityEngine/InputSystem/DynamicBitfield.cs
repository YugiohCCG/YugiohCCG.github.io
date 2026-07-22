namespace UnityEngine.InputSystem;

internal struct DynamicBitfield
{
	public InlinedArray<UInt64> array; //Field offset: 0x0
	public int length; //Field offset: 0x18

	[CalledBy(Type = typeof(InputManager), Member = "FireStateChangeNotifications", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	public bool AnyBitIsSet() { }

	[CallerCount(Count = 0)]
	private static int BitCountToULongCount(int bitCount) { }

	[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputStateChangeMonitor), typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "FireStateChangeNotifications", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InlinedArray`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TValue"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void ClearBit(int bitIndex) { }

	[CalledBy(Type = typeof(InputManager), Member = "SignalStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessStateChangeMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InlinedArray`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TValue"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void SetBit(int bitIndex) { }

	[CalledBy(Type = typeof(InputManager), Member = "ProcessStateChangeMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlinedArray`1), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void SetLength(int newLength) { }

	[CalledBy(Type = typeof(InputManager), Member = "FireStateChangeNotifications", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[ContainsUnimplementedInstructions]
	public bool TestBit(int bitIndex) { }

}

