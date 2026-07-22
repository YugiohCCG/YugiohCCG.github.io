namespace UnityEngine.InputSystem.LowLevel;

public struct InputEventListener : IObservable<InputEventPtr>
{
	private class DisposableObserver : IDisposable
	{
		public IObserver<InputEventPtr> observer; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DisposableObserver() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputArrayExtensions), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "remove_onEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

	}

	public class ObserverState
	{
		public InlinedArray<IObserver`1<InputEventPtr>> observers; //Field offset: 0x10
		public Action<InputEventPtr, InputDevice> onEventDelegate; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public ObserverState() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		private void <.ctor>b__2_0(InputEventPtr eventPtr, InputDevice device) { }

	}

	internal static ObserverState s_ObserverState; //Field offset: 0x0

	[CalledBy(Type = typeof(RebindingOperation), Member = "Start", ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "HookOnEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "HookIntoEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "Enable", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "add_onEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static InputEventListener op_Addition(InputEventListener _, Action<InputEventPtr, InputDevice> callback) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "UnhookOnEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnhookFromDeviceStateChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchSimulation), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "Disable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "remove_onEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static InputEventListener op_Subtraction(InputEventListener _, Action<InputEventPtr, InputDevice> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "add_onEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override IDisposable Subscribe(IObserver<InputEventPtr> observer) { }

}

