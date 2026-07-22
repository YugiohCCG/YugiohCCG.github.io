namespace UnityEngine.Rendering;

internal class DebugUpdater : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DoAfterInputModuleUpdated>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action action; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <DoAfterInputModuleUpdated>d__9(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <RefreshRuntimeUINextFrame>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <RefreshRuntimeUINextFrame>d__15(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
		[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	private static DebugUpdater s_Instance; //Field offset: 0x0
	private ScreenOrientation m_Orientation; //Field offset: 0x20
	private bool m_RuntimeUiWasVisibleLastFrame; //Field offset: 0x24

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUpdater() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AssignDefaultActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void CheckInputModuleExists() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CreateDebugEventSystem() { }

	[CalledBy(Type = typeof(DebugUpdater), Member = "HandleInternalEventSystemComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUpdater), Member = "EnsureExactlyOneEventSystem", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void DestroyDebugEventSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "set_displayRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 4)]
	private static void DisableRuntime() { }

	[CalledBy(Type = typeof(DebugUpdater), Member = "EnsureExactlyOneEventSystem", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoAfterInputModuleUpdated>d__9))]
	private IEnumerator DoAfterInputModuleUpdated(Action action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "EnableInputActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableRuntime() { }

	[CalledBy(Type = typeof(DebugUpdater), Member = "HandleInternalEventSystemComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugUpdater), Member = "DestroyDebugEventSystem", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugUpdater), Member = "DoAfterInputModuleUpdated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void EnsureExactlyOneEventSystem() { }

	[CalledBy(Type = typeof(DebugManager), Member = "set_displayRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugUpdater), Member = "DestroyDebugEventSystem", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugUpdater), Member = "EnsureExactlyOneEventSystem", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void HandleInternalEventSystemComponents(bool uiEnabled) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<RefreshRuntimeUINextFrame>d__15))]
	private static IEnumerator RefreshRuntimeUINextFrame() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterSceneLoad (0))]
	private static void RuntimeInit() { }

	[CalledBy(Type = typeof(DebugManager), Member = "set_enableRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "set_displayRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugManager), Member = "EnableInputActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(EnhancedTouchSupport), Member = "Enable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static void SetEnabled(bool enabled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugUpdater), Member = "HandleInternalEventSystemComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugManager), Member = "UpdateActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugManager), Member = "GetActionToggleDebugMenuWithTouch", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugManager), Member = "set_displayRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "ReadValue", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugUIHandlerCanvas), Member = "SetScrollTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugUIHandlerWidget)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void Update() { }

}

