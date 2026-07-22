namespace UnityEngine.UIElements;

public class KeyboardNavigationManipulator : Manipulator
{
	[CompilerGenerated]
	private struct <>c__DisplayClass4_0
	{
		public KeyDownEvent evt; //Field offset: 0x0

	}

	private readonly Action<KeyboardNavigationOperation, EventBase> m_Action; //Field offset: 0x18

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyboardEventBase`1), Member = "get_actionKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static KeyboardNavigationOperation <OnKeyDown>g__GetOperation|4_0(ref <>c__DisplayClass4_0 unnamed_param_0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void Invoke(KeyboardNavigationOperation operation, EventBase evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyboardEventBase`1), Member = "get_actionKey", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal void OnKeyDown(KeyDownEvent evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnNavigationCancel(NavigationCancelEvent evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void RegisterCallbacksOnTarget() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UnregisterCallbacksFromTarget() { }

}

