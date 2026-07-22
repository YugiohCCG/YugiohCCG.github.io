namespace UnityEngine.UIElements;

public class DropdownMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Status status; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass10_0() { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		internal Status <AppendAction>b__0(DropdownMenuAction e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string subMenuPath; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass13_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <AppendSeparator>b__0(DropdownMenuItem item) { }

	}

	private List<DropdownMenuItem> m_MenuItems; //Field offset: 0x10
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; //Field offset: 0x18

	internal int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 60
	}

	[CalledBy(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public DropdownMenu() { }

	[CalledBy(Type = typeof(DropdownMenu), Member = "AppendAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<UnityEngine.UIElements.DropdownMenuAction>), typeof(Status)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "BuildContextualMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DropdownMenu), Member = "AppendAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<UnityEngine.UIElements.DropdownMenuAction>), typeof(System.Func`2<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction+Status>), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Status status = 1) { }

	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void AppendSeparator(string subMenuPath = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal int get_Count() { }

	[CalledBy(Type = typeof(TextElement), Member = "EditionHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void InsertSeparator(string subMenuPath, int atIndex) { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public List<DropdownMenuItem> MenuItems() { }

	[CalledBy(Type = typeof(ContextualMenuPopulateEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DropdownMenuEventInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DropdownMenuAction), Member = "UpdateActionStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuEventInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void PrepareForDisplay(EventBase e) { }

}

