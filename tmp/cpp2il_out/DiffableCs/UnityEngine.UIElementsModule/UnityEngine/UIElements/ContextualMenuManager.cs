namespace UnityEngine.UIElements;

public abstract class ContextualMenuManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <displayMenuHandledOSX>k__BackingField; //Field offset: 0x10

	internal bool displayMenuHandledOSX
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 370
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ContextualMenuManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler), typeof(DropdownMenu)}, ReturnType = typeof(void))]
	public void DisplayMenu(EventBase triggerEvent, IEventHandler target) { }

	[CalledBy(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContextualMenuPopulateEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DropdownMenu), typeof(IEventHandler), typeof(ContextualMenuManager)}, ReturnType = typeof(ContextualMenuPopulateEvent))]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "ReleaseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal void DisplayMenu(EventBase triggerEvent, IEventHandler target, DropdownMenu menu) { }

	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler) { }

	protected private abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_displayMenuHandledOSX() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_displayMenuHandledOSX(bool value) { }

}

