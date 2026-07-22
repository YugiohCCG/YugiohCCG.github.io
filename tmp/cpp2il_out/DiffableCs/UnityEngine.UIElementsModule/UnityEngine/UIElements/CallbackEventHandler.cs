namespace UnityEngine.UIElements;

public abstract class CallbackEventHandler : IEventHandler
{
	internal const string HandleEventBubbleUpName = "HandleEventBubbleUp"; //Field offset: 0x0
	internal const string HandleEventTrickleDownName = "HandleEventTrickleDown"; //Field offset: 0x0
	internal const string ExecuteDefaultActionName = "ExecuteDefaultAction"; //Field offset: 0x0
	internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget"; //Field offset: 0x0
	internal bool isIMGUIContainer; //Field offset: 0x10
	internal EventCallbackRegistry m_CallbackRegistry; //Field offset: 0x18

	[CalledBy(Type = typeof(Focusable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected CallbackEventHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "AddEventCallbackCategories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void AddEventCategories(TrickleDown useTrickleDown) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
	protected override void ExecuteDefaultAction(EventBase evt) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void ExecuteDefaultActionAtTargetInternal(EventBase evt) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUpDisabled.")]
	internal override void ExecuteDefaultActionDisabled(EventBase evt) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUpDisabled.")]
	internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void ExecuteDefaultActionDisabledAtTargetInternal(EventBase evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void ExecuteDefaultActionDisabledInternal(EventBase evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void ExecuteDefaultActionInternal(EventBase evt) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	protected override void HandleEventBubbleUp(EventBase evt) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	internal override void HandleEventBubbleUpDisabled(EventBase evt) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void HandleEventBubbleUpInternal(EventBase evt) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	protected override void HandleEventTrickleDown(EventBase evt) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[EventInterest(EventInterestOptions::Inherit (0))]
	internal override void HandleEventTrickleDownDisabled(EventBase evt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void HandleEventTrickleDownInternal(EventBase evt) { }

	[CallerCount(Count = 206)]
	[Calls(Type = typeof(PropertyChangedEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(PropertyChangedEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected void NotifyPropertyChanged(in BindingId property) { }

	[CalledBy(Type = typeof(Clickable), Member = "RegisterCallbacksOnTarget", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "OnAttachToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachToPanelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(EventCallbackRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal void RegisterCallback(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = 0) { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "StartTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EventCallbackRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TCallbackArgs"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void RegisterCallback(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = 0) { }

	[CallerCount(Count = 187)]
	[Calls(Type = typeof(EventCallbackRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventCallbackRegistry), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown), typeof(InvokePolicy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void RegisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	public abstract void SendEvent(EventBase e) { }

	[CallerCount(Count = 140)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void UnregisterCallback(EventCallback<TEventType, TUserArgsType> callback, TrickleDown useTrickleDown = 0) { }

	[CallerCount(Count = 140)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void UnregisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

}

