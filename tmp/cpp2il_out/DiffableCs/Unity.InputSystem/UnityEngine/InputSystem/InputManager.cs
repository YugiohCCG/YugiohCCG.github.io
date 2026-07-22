namespace UnityEngine.InputSystem;

internal class InputManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<InputDevice, String> <>9__192_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
		internal string <MakeDeviceNameUnique>b__192_0(InputDevice x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__85
	{
		public static readonly <>c__85<TDevice> <>9; //Field offset: 0x0
		public static Func<InputDevice> <>9__85_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c__85`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__85`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[DeduplicatedMethod]
		internal InputDevice <RegisterPrecompiledLayout>b__85_0() { }

	}

	[CompilerGenerated]
	private sealed class <ListControlLayouts>d__100 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private string basedOn; //Field offset: 0x28
		public string <>3__basedOn; //Field offset: 0x30
		public InputManager <>4__this; //Field offset: 0x38
		private InternedString <internedBasedOn>5__2; //Field offset: 0x40
		private Enumerator<InternedString, Type> <>7__wrap2; //Field offset: 0x50
		private Enumerator<InternedString, String> <>7__wrap3; //Field offset: 0x80
		private Enumerator<InternedString, Func<InputControlLayout>> <>7__wrap4; //Field offset: 0xB0

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <ListControlLayouts>d__100(int <>1__state) { }

		[CalledBy(Type = typeof(<ListControlLayouts>d__100), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void <>m__Finally1() { }

		[CalledBy(Type = typeof(<ListControlLayouts>d__100), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void <>m__Finally2() { }

		[CalledBy(Type = typeof(<ListControlLayouts>d__100), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void <>m__Finally3() { }

		[CalledBy(Type = typeof(<ListControlLayouts>d__100), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void <>m__Finally4() { }

		[CalledBy(Type = typeof(<ListControlLayouts>d__100), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void <>m__Finally5() { }

		[CalledBy(Type = typeof(<ListControlLayouts>d__100), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void <>m__Finally6() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Collection), Member = "IsBasedOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(<ListControlLayouts>d__100), Member = "<>m__Finally1", ReturnType = typeof(void))]
		[Calls(Type = typeof(<ListControlLayouts>d__100), Member = "<>m__Finally2", ReturnType = typeof(void))]
		[Calls(Type = typeof(<ListControlLayouts>d__100), Member = "<>m__Finally3", ReturnType = typeof(void))]
		[Calls(Type = typeof(<ListControlLayouts>d__100), Member = "<>m__Finally4", ReturnType = typeof(void))]
		[Calls(Type = typeof(<ListControlLayouts>d__100), Member = "<>m__Finally5", ReturnType = typeof(void))]
		[Calls(Type = typeof(<ListControlLayouts>d__100), Member = "<>m__Finally6", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 31)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg+<>c", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 13)]
		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public struct AvailableDevice
	{
		public InputDeviceDescription description; //Field offset: 0x0
		public int deviceId; //Field offset: 0x38
		public bool isNative; //Field offset: 0x3C
		public bool isRemoved; //Field offset: 0x3D

	}

	public enum DeviceDisableScope
	{
		Everywhere = 0,
		InFrontendOnly = 1,
		TemporaryWhilePlayerIsInBackground = 2,
	}

	public struct StateChangeMonitorListener
	{
		public InputControl control; //Field offset: 0x0
		public IInputStateChangeMonitor monitor; //Field offset: 0x8
		public long monitorIndex; //Field offset: 0x10
		public uint groupIndex; //Field offset: 0x18

	}

	public struct StateChangeMonitorsForDevice
	{
		public BitRegion[] memoryRegions; //Field offset: 0x0
		public StateChangeMonitorListener[] listeners; //Field offset: 0x8
		public DynamicBitfield signalled; //Field offset: 0x10
		public bool needToUpdateOrderingOfMonitors; //Field offset: 0x30
		public bool needToCompactArrays; //Field offset: 0x31

		public int count
		{
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CalledBy(Type = typeof(InputManager), Member = "AddStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorListener)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorListener[]&), typeof(Int32&), typeof(StateChangeMonitorListener), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BitRegion), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(Int32&), "TValue", typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InlinedArray`1), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) { }

		[CalledBy(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "RemoveStateChangeMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayHelpers), Member = "Clear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlinedArray`1), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		public void Clear() { }

		[CalledBy(Type = typeof(InputManager), Member = "AddStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public void CompactArrays() { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public int get_count() { }

		[CalledBy(Type = typeof(InputManager), Member = "RemoveStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DynamicBitfield), Member = "ClearBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public void Remove(IInputStateChangeMonitor monitor, long monitorIndex, bool deferRemoval) { }

		[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputStateChangeMonitor), typeof(long), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "CompactArrays", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorListener)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorListener[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlinedArray`1), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		private void RemoveAt(int i) { }

		[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputManager), Member = "SortStateChangeMonitorsIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "SignalStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(InputActionState), Member = "GetComplexityFromMonitorIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArrayHelpers), Member = "SwapElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorListener)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorListener[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "SwapElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitRegion)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitRegion[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public void SortMonitorsByIndex() { }

	}

	private struct StateChangeMonitorTimeout
	{
		public InputControl control; //Field offset: 0x0
		public double time; //Field offset: 0x8
		public IInputStateChangeMonitor monitor; //Field offset: 0x10
		public long monitorIndex; //Field offset: 0x18
		public int timerIndex; //Field offset: 0x20

	}

	private static readonly ProfilerMarker k_InputUpdateProfilerMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputTryFindMatchingControllerMarker; //Field offset: 0x8
	private static readonly ProfilerMarker k_InputAddDeviceMarker; //Field offset: 0x10
	private static readonly ProfilerMarker k_InputRestoreDevicesAfterReloadMarker; //Field offset: 0x18
	private static readonly ProfilerMarker k_InputRegisterCustomTypesMarker; //Field offset: 0x20
	private static readonly ProfilerMarker k_InputOnBeforeUpdateMarker; //Field offset: 0x28
	private static readonly ProfilerMarker k_InputOnAfterUpdateMarker; //Field offset: 0x30
	private static readonly ProfilerMarker k_InputOnSettingsChangeMarker; //Field offset: 0x38
	private static readonly ProfilerMarker k_InputOnDeviceSettingsChangeMarker; //Field offset: 0x40
	private static readonly ProfilerMarker k_InputOnEventMarker; //Field offset: 0x48
	private static readonly ProfilerMarker k_InputOnLayoutChangeMarker; //Field offset: 0x50
	private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; //Field offset: 0x58
	private static readonly ProfilerMarker k_InputOnActionsChangeMarker; //Field offset: 0x60
	private bool m_CustomTypesRegistered; //Field offset: 0x10
	internal int m_LayoutRegistrationVersion; //Field offset: 0x14
	private float m_PollingFrequency; //Field offset: 0x18
	private InputEventHandledPolicy m_InputEventHandledPolicy; //Field offset: 0x1C
	internal Collection m_Layouts; //Field offset: 0x20
	private TypeTable m_Processors; //Field offset: 0x60
	private TypeTable m_Interactions; //Field offset: 0x70
	private TypeTable m_Composites; //Field offset: 0x80
	private int m_DevicesCount; //Field offset: 0x90
	private InputDevice[] m_Devices; //Field offset: 0x98
	private Dictionary<Int32, InputDevice> m_DevicesById; //Field offset: 0xA0
	internal int m_AvailableDeviceCount; //Field offset: 0xA8
	internal AvailableDevice[] m_AvailableDevices; //Field offset: 0xB0
	internal int m_DisconnectedDevicesCount; //Field offset: 0xB8
	internal InputDevice[] m_DisconnectedDevices; //Field offset: 0xC0
	internal InputUpdateType m_UpdateMask; //Field offset: 0xC8
	private InputUpdateType m_CurrentUpdate; //Field offset: 0xCC
	internal InputStateBuffers m_StateBuffers; //Field offset: 0xD0
	private ScrollDeltaBehavior m_ScrollDeltaBehavior; //Field offset: 0x108
	private CallbackArray<Action`2<InputDevice, InputDeviceChange>> m_DeviceChangeListeners; //Field offset: 0x110
	private CallbackArray<Action`2<InputDevice, InputEventPtr>> m_DeviceStateChangeListeners; //Field offset: 0x160
	private CallbackArray<InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks; //Field offset: 0x1B0
	internal CallbackArray<InputDeviceCommandDelegate> m_DeviceCommandCallbacks; //Field offset: 0x200
	private CallbackArray<Action`2<String, InputControlLayoutChange>> m_LayoutChangeListeners; //Field offset: 0x250
	private CallbackArray<Action`2<InputEventPtr, InputDevice>> m_EventListeners; //Field offset: 0x2A0
	private CallbackArray<Action> m_BeforeUpdateListeners; //Field offset: 0x2F0
	private CallbackArray<Action> m_AfterUpdateListeners; //Field offset: 0x340
	private CallbackArray<Action> m_SettingsChangedListeners; //Field offset: 0x390
	private CallbackArray<Action> m_ActionsChangedListeners; //Field offset: 0x3E0
	private bool m_NativeBeforeUpdateHooked; //Field offset: 0x430
	private bool m_HaveDevicesWithStateCallbackReceivers; //Field offset: 0x431
	private bool m_HasFocus; //Field offset: 0x432
	private bool m_DiscardOutOfFocusEvents; //Field offset: 0x433
	private double m_FocusRegainedTime; //Field offset: 0x438
	private InputEventStream m_InputEventStream; //Field offset: 0x440
	private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate; //Field offset: 0x4B8
	private int m_DeviceFindExecuteCommandDeviceId; //Field offset: 0x4C0
	internal IInputRuntime m_Runtime; //Field offset: 0x4C8
	internal InputMetrics m_Metrics; //Field offset: 0x4D0
	internal InputSettings m_Settings; //Field offset: 0x508
	private bool m_OptimizedControlsFeatureEnabled; //Field offset: 0x510
	private bool m_ReadValueCachingFeatureEnabled; //Field offset: 0x511
	private bool m_ParanoidReadValueCachingChecksEnabled; //Field offset: 0x512
	private InputActionAsset m_Actions; //Field offset: 0x518
	private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent; //Field offset: 0x520
	internal StateChangeMonitorsForDevice[] m_StateChangeMonitors; //Field offset: 0x528
	private InlinedArray<StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts; //Field offset: 0x530

	public event Action onActionsChange
	{
		[CalledBy(Type = typeof(InputSystem), Member = "add_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(InputSystem), Member = "remove_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action onAfterUpdate
	{
		[CalledBy(Type = typeof(InputSystem), Member = "add_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(InputSystem), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action onBeforeUpdate
	{
		[CalledBy(Type = typeof(InputActionState), Member = "HookOnBeforeUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystem), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputManager), Member = "InstallBeforeUpdateHookIfNecessary", ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 86
		[CalledBy(Type = typeof(InputActionState), Member = "UnhookOnBeforeUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystem), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action<InputDevice, InputDeviceChange> onDeviceChange
	{
		[CalledBy(Type = typeof(InputSystem), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(InputSystem), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event InputDeviceCommandDelegate onDeviceCommand
	{
		[CalledBy(Type = typeof(InputSystem), Member = "add_onDeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommandDelegate)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(InputSystem), Member = "remove_onDeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommandDelegate)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action<InputDevice, InputEventPtr> onDeviceStateChange
	{
		[CalledBy(Type = typeof(InputState), Member = "add_onChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(InputState), Member = "remove_onChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action<InputEventPtr, InputDevice> onEvent
	{
		[CalledBy(Type = typeof(InputEventListener), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
		[CalledBy(Type = typeof(InputEventListener), Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.IObserver`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(IDisposable))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventListener+DisposableObserver", Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventListener), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice
	{
		[CalledBy(Type = typeof(InputSystem), Member = "add_onFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
		 add { } //Length: 86
		[CalledBy(Type = typeof(InputSystem), Member = "remove_onFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action<String, InputControlLayoutChange> onLayoutChange
	{
		[CalledBy(Type = typeof(InputSystem), Member = "add_onLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(InputSystem), Member = "remove_onLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action onSettingsChange
	{
		[CalledBy(Type = typeof(InputSystem), Member = "add_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 add { } //Length: 76
		[CalledBy(Type = typeof(InputSystem), Member = "remove_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public InputActionAsset actions
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CalledBy(Type = typeof(InputSystem), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputManager), Member = "ApplyActions", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	public TypeTable composites
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
	}

	public InputUpdateType defaultUpdateType
	{
		[CalledBy(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState&", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputUpdate), Member = "GetUpdateTypeForPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(InputUpdateType))]
		 get { } //Length: 29
	}

	public ReadOnlyArray<InputDevice> devices
	{
		[CalledBy(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
		[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputDevice))]
		[CalledBy(Type = typeof(InputSystem), Member = "PauseHaptics", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystem), Member = "ResumeHaptics", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystem), Member = "ResetHaptics", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystem), Member = "FindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDevice), Member = "get_all", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 101
	}

	private bool gameHasFocus
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 49
	}

	private bool gameIsPlaying
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private bool gameShouldGetInputRegardlessOfFocus
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 33
	}

	internal InputEventHandledPolicy inputEventHandledPolicy
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CalledBy(Type = typeof(RebindingOperation), Member = "Start", ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		internal set { } //Length: 158
	}

	public TypeTable interactions
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public bool isProcessingEvents
	{
		[CalledBy(Type = typeof(InputSystem), Member = "get_isProcessingEvents", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		 get { } //Length: 8
	}

	public InputMetrics metrics
	{
		[CalledBy(Type = typeof(InputSystem), Member = "get_metrics", ReturnType = typeof(InputMetrics))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InputDevice), Member = "get_allControls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 423
	}

	internal bool optimizedControlsFeatureEnabled
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	internal bool paranoidReadValueCachingChecksEnabled
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public float pollingFrequency
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CalledBy(Type = typeof(InputSystem), Member = "set_pollingFrequency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 206
	}

	public TypeTable processors
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	internal bool readValueCachingFeatureEnabled
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	public ScrollDeltaBehavior scrollDeltaBehavior
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 227
	}

	public InputSettings settings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CalledBy(Type = typeof(InputSystem), Member = "set_settings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSettings)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 253
	}

	public InputUpdateType updateMask
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
		 set { } //Length: 31
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static InputManager() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InputManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputRuntimeExtensions), Member = "DeviceCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(int), typeof(InputDeviceCommand&)}, ReturnType = typeof(long))]
	[CompilerGenerated]
	private long <TryFindMatchingControlLayout>b__97_0(ref InputDeviceCommand commandRef) { }

	[CalledBy(Type = typeof(InputSystem), Member = "add_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onActionsChange(Action value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "add_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onAfterUpdate(Action value) { }

	[CalledBy(Type = typeof(InputActionState), Member = "HookOnBeforeUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "InstallBeforeUpdateHookIfNecessary", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onBeforeUpdate(Action value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "add_onDeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommandDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	[CalledBy(Type = typeof(InputState), Member = "add_onChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onDeviceStateChange(Action<InputDevice, InputEventPtr> value) { }

	[CalledBy(Type = typeof(InputEventListener), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
	[CalledBy(Type = typeof(InputEventListener), Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.IObserver`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(IDisposable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onEvent(Action<InputEventPtr, InputDevice> value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "add_onFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
	public void add_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "add_onLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "add_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void add_onSettingsChange(Action value) { }

	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "TryGetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "MatchPercentage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(int), typeof(string), typeof(InputDeviceDescription), typeof(DeviceFlags), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(EnableDeviceCommand), Member = "Create", ReturnType = typeof(EnableDeviceCommand))]
	[Calls(Type = typeof(InputRuntimeExtensions), Member = "DeviceCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EnableDeviceCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(int), typeof(EnableDeviceCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) { }

	[CalledBy(Type = typeof(InputManager), Member = "add_onFindControlLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HIDSupport), Member = "set_supportedHIDUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "TryGetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InputManager), Member = "IsDeviceLayoutMarkedAsSupportedInSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription), typeof(InternedString), typeof(string), typeof(int), typeof(DeviceFlags)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(DisableDeviceCommand), Member = "Create", ReturnType = typeof(DisableDeviceCommand))]
	[Calls(Type = typeof(InputRuntimeExtensions), Member = "DeviceCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(int), "TCommand&"}, ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal void AddAvailableDevicesThatAreNowRecognized() { }

	[CalledBy(Type = typeof(InputSystem), Member = "AddDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TDevice")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collection), Member = "TryFindLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public InputDevice AddDevice(Type type, string name = null) { }

	[CalledBy(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(InputDevice))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public InputDevice AddDevice(string layout, string name = null, InternedString variants = null) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddAvailableDevicesMatchingDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription), typeof(bool), typeof(string), typeof(int), typeof(DeviceFlags)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription), typeof(InternedString), typeof(string), typeof(int), typeof(DeviceFlags)}, ReturnType = typeof(InputDevice))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private InputDevice AddDevice(InternedString layout, int deviceId, string deviceName = null, InputDeviceDescription deviceDescription = null, DeviceFlags deviceFlags = 0, InternedString variants = null) { }

	[CalledBy(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(int), typeof(string), typeof(InputDeviceDescription), typeof(DeviceFlags), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "OnNativeDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteDisableCommand", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "set_disabledInRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "InstallBeforeUpdateHookIfNecessary", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_updateBeforeRender", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "set_hasEventPreProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "RequestSync", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "set_hasEventMerger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "set_disabledWhileInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "QueryEnabledStateFromRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_disabledInFrontend", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_layout", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringHelpers), Member = "MakeUniqueName", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TExisting"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.IEnumerable`1<TExisting>", "System.Func`2<TExisting, String>"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_disabledWhileInBackground", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "ResetControlPathsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "AssignUniqueDeviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "InitializeDeviceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	public void AddDevice(InputDevice device) { }

	[CalledBy(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InputDevice))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription), typeof(bool), typeof(string), typeof(int), typeof(DeviceFlags)}, ReturnType = typeof(InputDevice))]
	public InputDevice AddDevice(InputDeviceDescription description) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "OnNativeDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(int), typeof(string), typeof(InputDeviceDescription), typeof(DeviceFlags), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(DisableDeviceCommand), Member = "Create", ReturnType = typeof(DisableDeviceCommand))]
	[Calls(Type = typeof(InputRuntimeExtensions), Member = "DeviceCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(int), "TCommand&"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0, DeviceFlags deviceFlags = 0) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(int), typeof(string), typeof(InputDeviceDescription), typeof(DeviceFlags), typeof(InternedString)}, ReturnType = typeof(InputDevice))]
	[CallsUnknownMethods(Count = 3)]
	public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName = null, int deviceId = 0, DeviceFlags deviceFlags = 0) { }

	[CalledBy(Type = typeof(InputSystem), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewDeviceMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "NotifyUsageChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void AddDeviceUsage(InputDevice device, InternedString usage) { }

	[CalledBy(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputState), Member = "AddChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "StartRecording", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "CompactArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) { }

	[CalledBy(Type = typeof(InputActionState), Member = "StartTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TriggerState&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputState), Member = "AddChangeMonitorTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(double), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputManager+StateChangeMonitorTimeout>), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorTimeout)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex) { }

	[CalledBy(Type = typeof(InputManager), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action>&), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	internal void ApplyActions() { }

	[CalledBy(Type = typeof(InputManager), Member = "set_settings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSettings), Member = "OnChange", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action>&), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "MarkAsStaleRecursively", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(InputManager), Member = "IsDeviceLayoutMarkedAsSupportedInSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputSettings), Member = "get_supportedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<System.String>))]
	[Calls(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSettings), Member = "set_updateMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSettings), Member = "IsFeatureEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	internal void ApplySettings() { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "get_isDebugBuild", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "TryGetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputDevice), Member = "get_deviceId", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void AssignUniqueDeviceId(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("UNITY_EDITOR")]
	private void CheckAllDevicesOptimizedControlsHaveValidState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBuffers), Member = "FreeAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "UninstallGlobals", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_hideFlags", ReturnType = typeof(HideFlags))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Destroy() { }

	[CalledBy(Type = typeof(SwitchProControllerHID), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualSenseGamepadHID), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualShock4GamepadHID), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal void DontMakeCurrentlyUpdatingDeviceCurrent() { }

	[CalledBy(Type = typeof(InputSystem), Member = "EnableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "DisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "set_disabledInFrontend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "RequestSync", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteEnableCommand", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_disabledInRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "set_disabledInRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteDisableCommand", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "set_disabledWhileInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_disabledWhileInBackground", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_disabledInFrontend", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void EnableOrDisableDevice(InputDevice device, bool enable, DeviceDisableScope scope = 0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal long ExecuteGlobalCommand(ref TCommand command) { }

	[CalledBy(Type = typeof(InputManager), Member = "RegisterPrecompiledLayout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collection), Member = "TryFindLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private InternedString FindOrRegisterDeviceLayoutForType(Type type) { }

	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "FireStateChangeNotifications", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicBitfield), Member = "AnyBitIsSet", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicBitfield), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicBitfield), Member = "ClearBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = "set_handled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr) { }

	[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputManager), Member = "FireStateChangeNotifications", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void FireStateChangeNotifications() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBuffers), Member = "SwapBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType) { }

	[CalledBy(Type = typeof(InputSystem), Member = "FlushDisconnectedDevices", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Clear", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
	public void FlushDisconnectedDevices() { }

	[CallerCount(Count = 0)]
	public InputActionAsset get_actions() { }

	[CallerCount(Count = 0)]
	public TypeTable get_composites() { }

	[CalledBy(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState&", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUpdate), Member = "GetUpdateTypeForPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(InputUpdateType))]
	public InputUpdateType get_defaultUpdateType() { }

	[CalledBy(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputSystem), Member = "PauseHaptics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "ResumeHaptics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "ResetHaptics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "FindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDevice), Member = "get_all", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ReadOnlyArray<InputDevice> get_devices() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_gameHasFocus() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool get_gameIsPlaying() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_gameShouldGetInputRegardlessOfFocus() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal InputEventHandledPolicy get_inputEventHandledPolicy() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TypeTable get_interactions() { }

	[CalledBy(Type = typeof(InputSystem), Member = "get_isProcessingEvents", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	public bool get_isProcessingEvents() { }

	[CalledBy(Type = typeof(InputSystem), Member = "get_metrics", ReturnType = typeof(InputMetrics))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDevice), Member = "get_allControls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public InputMetrics get_metrics() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_optimizedControlsFeatureEnabled() { }

	[CallerCount(Count = 0)]
	internal bool get_paranoidReadValueCachingChecksEnabled() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_pollingFrequency() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TypeTable get_processors() { }

	[CallerCount(Count = 0)]
	internal bool get_readValueCachingFeatureEnabled() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ScrollDeltaBehavior get_scrollDeltaBehavior() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputSettings get_settings() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputUpdateType get_updateMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControls", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int), "UnityEngine.InputSystem.InputControlList`1<TControl>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public int GetControls(string path, ref InputControlList<TControl>& controls) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "TryGetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public InputDevice GetDevice(string nameOrLayout) { }

	[CalledBy(Type = typeof(InputSystem), Member = "GetUnsupportedDevices", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputDeviceDescription>))]
	[CalledBy(Type = typeof(InputSystem), Member = "GetUnsupportedDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputDeviceDescription>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool HasDevice(InputDevice device) { }

	[CalledBy(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(InputManager), Member = "InitializeData", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "InstallRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUpdate), Member = "Restore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializedState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "SwitchTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputStateBuffers), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action>&), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	internal void Initialize(IInputRuntime runtime, InputSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeActions() { }

	[CalledBy(Type = typeof(InputManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collection), Member = "Allocate", ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeTable), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "RegisterPrecompiledLayout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeTable), Member = "AddTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void InitializeData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_hasControlsWithDefaultState", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_allControls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_hasDefaultState", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputStateBlock), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(PrimitiveValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffers), Member = "GetFrontBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputStateBlock), Member = "CopyToFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffers), Member = "GetBackBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void InitializeDefaultState(InputDevice device) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "get_noisy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_allControls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(InputDevice), Member = "get_hasControlsWithDefaultState", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryHelpers), Member = "SetBitsInBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_usesStateFromOtherControl", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_dontReset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_hasDefaultState", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputStateBlock), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(PrimitiveValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffers), Member = "GetFrontBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputStateBlock), Member = "CopyToFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffers), Member = "GetBackBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void InitializeDeviceState(InputDevice device) { }

	[CalledBy(Type = typeof(InputManager), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void InstallBeforeUpdateHookIfNecessary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputUpdate), Member = "Restore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializedState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "SwitchTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputStateBuffers), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal void InstallGlobals() { }

	[CalledBy(Type = typeof(InputManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	internal void InstallRuntime(IInputRuntime runtime) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action>&), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	private void InvokeAfterUpdateCallback(InputUpdateType updateType) { }

	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "IsControlOrChildUsingLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "IsControlUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_children", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputManager), Member = "IsControlOrChildUsingLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) { }

	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "IsControlOrChildUsingLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControl), Member = "get_layout", ReturnType = typeof(string))]
	[Calls(Type = typeof(InternedString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsControlUsingLayout(InputControl control, InternedString layout) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnNativeDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSettings), Member = "get_supportedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<System.String>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection), Member = "IsBasedOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) { }

	[CalledBy(Type = typeof(InputSystem), Member = "ListLayouts", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(InputSystem), Member = "ListLayoutsBasedOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[IteratorStateMachine(typeof(<ListControlLayouts>d__100))]
	public IEnumerable<String> ListControlLayouts(string basedOn = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringHelpers), Member = "MakeUniqueName", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TExisting"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.IEnumerable`1<TExisting>", "System.Func`2<TExisting, String>"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "ResetControlPathsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MakeDeviceNameUnique(InputDevice device) { }

	[CalledBy(Type = typeof(InputManager), Member = "TryMatchDisconnectedDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Substring), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Substring))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private JsonString MakeEscapedJsonString(string theString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private string MakeStringWithEventsProcessedByDevice() { }

	[CalledBy(Type = typeof(InputManager), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void NotifyUsageChanged(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputStateBuffers), Member = "SwitchTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputStateBuffers), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUpdate), Member = "OnBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_hasStateCallbacks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action>&), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void OnBeforeUpdate(InputUpdateType updateType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_disabledWhileInBackground", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "RequestSync", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_disabledInRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteEnableCommand", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "set_disabledInRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "set_disabledWhileInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_disabledInFrontend", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteDisableCommand", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal void OnFocusChanged(bool focus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "TryMatchDisconnectedDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputDeviceDescription), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDeviceDescription))]
	[Calls(Type = typeof(InputSettings), Member = "get_supportedDevices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<System.String>))]
	[Calls(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InputManager), Member = "IsDeviceLayoutMarkedAsSupportedInSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription), typeof(bool), typeof(string), typeof(int), typeof(DeviceFlags)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue1", "TValue2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Action`2<TValue1, TValue2>>&", "TValue1", "TValue2", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "NotifyConfigurationChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_hasStateCallbacks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_stateFormat", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_sizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_internalTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_native", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDeviceDescription), Member = "get_empty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(Int32&), typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputManager), Member = "AreMaximumEventBytesPerUpdateExceeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "get_isDebugBuild", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventStream), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_hasEventPreProcessor", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventBuffer&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "SwitchTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputStateBuffers), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUpdate), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUpdate), Member = "IsPlayerUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(InputManager), Member = "ProcessStateChangeMonitorTimeouts", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "InvokeAfterUpdateCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventBuffer), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventStream), Member = "Peek", ReturnType = typeof(InputEvent*))]
	[Calls(Type = typeof(InputEventStream), Member = "CleanUpAfterException", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventStream), Member = "get_currentEventPtr", ReturnType = typeof(InputEvent*))]
	[Calls(Type = typeof(InputEvent), Member = "get_deviceId", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputManager), Member = "TryGetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputDevice), Member = "get_updateBeforeRender", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventStream), Member = "Advance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(InputEvent*))]
	[Calls(Type = typeof(InputDevice), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_hasEventMerger", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEventStream), Member = "get_remainingEventCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 40)]
	[ContainsUnimplementedInstructions]
	private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayoutBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringHelpers), Member = "CharacterSeparatedListsHaveAtLeastOneCommonElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Utilities.InternedString>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(InternedString[]))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false, bool isOverride = false) { }

	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitRegion), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitRegion), Member = "Overlap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitRegion)}, ReturnType = typeof(BitRegion))]
	[Calls(Type = typeof(MemoryHelpers), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(BitRegion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicBitfield), Member = "SetBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorListener)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorListener[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicBitfield), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool ProcessStateChangeMonitors(int deviceIndex, Void* newStateFromEvent, Void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputManager+StateChangeMonitorTimeout>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StateChangeMonitorTimeout)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputManager+StateChangeMonitorTimeout>), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void ProcessStateChangeMonitorTimeouts() { }

	[CalledBy(Type = typeof(InputSystem), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewEventsMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputEventStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void QueueEvent(InputEventPtr ptr) { }

	[CalledBy(Type = typeof(InputSystem), Member = "QueueConfigChangeEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "QueueTextEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(char), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void QueueEvent(ref TEvent inputEvent) { }

	[CalledBy(Type = typeof(InputSystem), Member = "QueueStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), "TState", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "QueueDeltaStateEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelta"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TDelta", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "QueueEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TEvent&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputEventStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEvent*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void QueueEvent(InputEvent* eventPtr) { }

	[CalledBy(Type = typeof(InputManager), Member = "set_updateMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InputStateBuffers), Member = "AllocateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "MigrateAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice[]), typeof(int), typeof(InputStateBuffers)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "FreeAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUpdate), Member = "GetUpdateTypeForPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(InputUpdateType))]
	[Calls(Type = typeof(InputStateBuffers), Member = "SwitchTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputStateBuffers), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void ReallocateStateBuffers() { }

	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
	[Calls(Type = typeof(InputDevice), Member = "get_native", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_remote", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void RecreateDevice(InputDevice oldDevice, InternedString newLayout) { }

	[CalledBy(Type = typeof(InputManager), Member = "PerformLayoutPostRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsControlOrChildUsingLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "IsControlUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "Ref", ReturnType = typeof(RefInstance))]
	[Calls(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RefInstance), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false) { }

	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputDeviceBuilder), Member = "Ref", ReturnType = typeof(RefInstance))]
	[Calls(Type = typeof(InputDeviceDescription), Member = "get_empty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "MatchPercentage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RefInstance), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "FindOrRegisterDeviceLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeData", ReturnType = typeof(void))]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "PerformLayoutPostRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection), Member = "HasLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 34)]
	public void RegisterControlLayout(string name, Type type) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayoutOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewLayoutMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "PerformLayoutPostRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<UnityEngine.InputSystem.Utilities.InternedString>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collection), Member = "HasLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlLayout), Member = "ParseHeaderFieldsFromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InternedString&), typeof(InlinedArray`1<InternedString>&), typeof(InputDeviceMatcher&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	public void RegisterControlLayout(string json, string name = null, bool isOverride = false) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayoutBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>), typeof(string), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection), Member = "HasLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "PerformLayoutPostRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString>), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout = null) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayoutBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>), typeof(string), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection), Member = "AddMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "AddAvailableDevicesMatchingDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher), typeof(InternedString)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterLayoutMatcher", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collection), Member = "TryFindLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher) { }

	[CalledBy(Type = typeof(InputManager), Member = "RegisterCustomTypes", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputSystem), Member = "RegisterBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "RegisterInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "RegisterProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static void RegisterCustomTypes(Type[] types) { }

	[CalledBy(Type = typeof(TypeTable), Member = "TryLookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "RegisterCustomTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	internal bool RegisterCustomTypes() { }

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterPrecompiledLayout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeData", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InputManager), Member = "FindOrRegisterDeviceLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout+Collection+PrecompiledLayout>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(PrecompiledLayout)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public void RegisterPrecompiledLayout(string metadata) { }

	[CalledBy(Type = typeof(InputSystem), Member = "remove_onActionsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onActionsChange(Action value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onAfterUpdate(Action value) { }

	[CalledBy(Type = typeof(InputActionState), Member = "UnhookOnBeforeUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onBeforeUpdate(Action value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "remove_onDeviceCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceCommandDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	[CalledBy(Type = typeof(InputState), Member = "remove_onChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onDeviceStateChange(Action<InputDevice, InputEventPtr> value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventListener+DisposableObserver", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputEventListener), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventListener), typeof(System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr, UnityEngine.InputSystem.InputDevice>)}, ReturnType = typeof(InputEventListener))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onEvent(Action<InputEventPtr, InputDevice> value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "remove_onFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "remove_onLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.String, UnityEngine.InputSystem.InputControlLayoutChange>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "remove_onSettingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	public void remove_onSettingsChange(Action value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RemoveLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "IsControlUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_children", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputManager), Member = "IsControlOrChildUsingLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void RemoveControlLayout(string name) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+DisconnectMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+RemoveDeviceMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputRemoting), Member = "RemoveRemoteDevices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "GetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_updateBeforeRender", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "BakeOffsetIntoStateBlockRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AvailableDevice)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AvailableDevice[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorsForDevice)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StateChangeMonitorsForDevice[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "FreeAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputManager+StateChangeMonitorTimeout>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StateChangeMonitorTimeout)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices = false) { }

	[CalledBy(Type = typeof(InputSystem), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
	[Calls(Type = typeof(ReadOnlyArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "NotifyUsageChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	[CalledBy(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputState), Member = "RemoveChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputStateHistory), Member = "StopRecording", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputStateChangeMonitor), typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputManager+StateChangeMonitorTimeout>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StateChangeMonitorTimeout)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputManager+StateChangeMonitorTimeout>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StateChangeMonitorTimeout)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void RemoveStateChangeMonitors(InputDevice device) { }

	[CalledBy(Type = typeof(InputActionState), Member = "StopTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputState), Member = "RemoveChangeMonitorTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputStateChangeMonitor), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputManager+StateChangeMonitorTimeout>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StateChangeMonitorTimeout)}, ReturnType = typeof(void))]
	public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex) { }

	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "MakeDeviceNameUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ResetControlPathsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControl), Member = "get_children", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputManager), Member = "ResetControlPathsRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void ResetControlPathsRecursive(InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "get_isDebugBuild", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void ResetCurrentProcessedEventBytesForDevices() { }

	[CalledBy(Type = typeof(InputSystem), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "EnableOrDisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(DeviceDisableScope)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(MemoryHelpers), Member = "MemCpyMasked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputUpdate), Member = "GetUpdateTypeForPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(InputUpdateType))]
	[Calls(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "RequestReset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputEvent), Member = "set_time", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = "set_deviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEvent), Member = "set_sizeInBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBlock), Member = "get_alignedSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_hasDontResetControls", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEvent), Member = "set_eventId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false, Nullable<Boolean> issueResetCommand = null) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void RestoreDevicesAfterDomainReloadIfNecessary() { }

	[CalledBy(Type = typeof(InputSystem), Member = "set_actions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "ApplyActions", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_actions(InputActionAsset value) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "Start", ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "ResetAfterMatchCompleted", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void set_inputEventHandledPolicy(InputEventHandledPolicy value) { }

	[CallerCount(Count = 0)]
	internal void set_optimizedControlsFeatureEnabled(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_paranoidReadValueCachingChecksEnabled(bool value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "set_pollingFrequency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_pollingFrequency(float value) { }

	[CallerCount(Count = 0)]
	internal void set_readValueCachingFeatureEnabled(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_scrollDeltaBehavior(ScrollDeltaBehavior value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "set_settings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "ApplySettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_settings(InputSettings value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ReallocateStateBuffers", ReturnType = typeof(void))]
	public void set_updateMask(InputUpdateType value) { }

	[CalledBy(Type = typeof(InputSystem), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControl), Member = "get_usages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.InternedString>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputDevice), Member = "ClearDeviceUsages", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "NotifyUsageChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void SetDeviceUsage(InputDevice device, InternedString usage) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private bool ShouldExitEarlyFromEventProcessing(InputUpdateType updateType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool ShouldFlushEventBuffer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldRunDeviceInBackground(InputDevice device) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool ShouldRunUpdate(InputUpdateType updateType) { }

	[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "SortMonitorsByIndex", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicBitfield), Member = "SetBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "SortMonitorsByIndex", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SortStateChangeMonitorsIfNecessary(int deviceIndex) { }

	[CalledBy(Type = typeof(InputSystem), Member = "TryFindMatchingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription), typeof(bool), typeof(string), typeof(int), typeof(DeviceFlags)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "OnNativeDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CallbackArray`1), Member = "UnlockForChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CallbackArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TDelegate")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collection), Member = "GetControlTypeForLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collection), Member = "TryFindMatchingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection), Member = "TryFindLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "TryGetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[CallsDeduplicatedMethods(Count = 1)]
	public InputDevice TryGetDevice(Type layoutType) { }

	[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "GetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "TryGetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputDevice))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public InputDevice TryGetDevice(string nameOrLayout) { }

	[CalledBy(Type = typeof(InputSystem), Member = "GetDeviceById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "EnumerateControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(Enumerate), typeof(InputDevice), typeof(float)}, ReturnType = typeof(InputEventControlCollection))]
	[CalledBy(Type = typeof(InputRemoting), Member = "TryGetDeviceByRemoteId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "AddAvailableDevicesMatchingDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AssignUniqueDeviceId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public InputDevice TryGetDeviceById(int id) { }

	[CalledBy(Type = typeof(InputSystem), Member = "LoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControlLayout))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
	public InputControlLayout TryLoadControlLayout(InternedString name) { }

	[CalledBy(Type = typeof(InputSystem), Member = "LoadLayout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, ReturnType = typeof(InputControlLayout))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Collection), Member = "TryFindLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public InputControlLayout TryLoadControlLayout(Type type) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnNativeDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonString), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonString))]
	[Calls(Type = typeof(InputDeviceDescription), Member = "ComparePropertyToDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JsonString), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "MakeEscapedJsonString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JsonString))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAtWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) { }

	[CalledBy(Type = typeof(InputManager), Member = "Destroy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal void UninstallGlobals() { }

	[CalledBy(Type = typeof(InputSystem), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputUpdate), Member = "GetUpdateTypeForPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(InputUpdateType))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Update() { }

	[CalledBy(Type = typeof(InputSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RunInitialUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Update(InputUpdateType updateType) { }

	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEvent*), typeof(InputUpdateType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), "TState&", typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "FireStateChangeNotifications", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(InputEvent*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputEventPtr)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, InputEventPtr>>&), typeof(object), typeof(InputEventPtr), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(ButtonControl), Member = "UpdateWasPressed", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputDevice), Member = "get_allControls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "WriteStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DoubleBuffers), typeof(int), typeof(InputStateBlock&), typeof(uint), typeof(Void*), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffers), Member = "SwapBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryHelpers), Member = "MemCmpBitRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(uint), typeof(uint), typeof(Void*)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_noisy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "ProcessStateChangeMonitors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StateChangeMonitorsForDevice), Member = "SortMonitorsByIndex", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputStateBuffers), Member = "GetFrontBufferForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(HashSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.HashSet`1<T>+Enumerator<T>")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	internal bool UpdateState(InputDevice device, InputUpdateType updateType, Void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr = null) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DeltaStateEvent), Member = "get_deltaStateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(DeltaStateEvent), Member = "get_deltaState", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(StateEvent), Member = "get_stateSizeInBytes", ReturnType = typeof(uint))]
	[Calls(Type = typeof(StateEvent), Member = "get_state", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }

	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DoubleBuffers), Member = "GetFrontBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(DoubleBuffers), Member = "GetBackBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "WriteChangedControlStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Void*), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void WriteStateChange(DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, Void* statePtr, uint stateSizeInBytes, bool flippedBuffers) { }

}

