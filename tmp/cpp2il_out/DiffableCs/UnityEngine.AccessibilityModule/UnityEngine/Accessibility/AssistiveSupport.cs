namespace UnityEngine.Accessibility;

public static class AssistiveSupport
{
	public class NotificationDispatcher : IAccessibilityNotificationDispatcher
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotificationDispatcher() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void Send(in AccessibilityNotificationContext context) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override void SendScreenChanged(AccessibilityNode nodeToFocus = null) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<AccessibilityNode> nodeFocusChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Boolean> screenReaderStatusChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <isScreenReaderEnabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly IAccessibilityNotificationDispatcher <notificationDispatcher>k__BackingField; //Field offset: 0x18
	private static ServiceManager s_ServiceManager; //Field offset: 0x20

	public static AccessibilityHierarchy activeHierarchy
	{
		[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "get_frame", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "CalculateFrame", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "ChildrenChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "ActionsChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AccessibilityNode), Member = "IsInActiveHierarchy", ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		 get { } //Length: 96
	}

	public private static bool isScreenReaderEnabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public static IAccessibilityNotificationDispatcher notificationDispatcher
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static AssistiveSupport() { }

	[CalledBy(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "get_frame", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "CalculateFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "ChildrenChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "ActionsChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "IsInActiveHierarchy", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	public static AccessibilityHierarchy get_activeHierarchy() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_isScreenReaderEnabled() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static IAccessibilityNotificationDispatcher get_notificationDispatcher() { }

	[CalledBy(Type = typeof(NotificationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNotificationContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetRootNodeIds", ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNodeData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNodeIdAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeIncremented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeDecremented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeDismissed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AssistiveSupport), Member = "get_activeHierarchy", ReturnType = typeof(AccessibilityHierarchy))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ServiceManager), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static T GetService() { }

	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AccessibilityManager), Member = "add_screenReaderStatusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ServiceManager), Member = "UpdateServices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	internal static void Initialize() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void NodeFocusChanged(AccessibilityNode currentNode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void ScreenReaderStatusChanged(bool screenReaderEnabled) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_isScreenReaderEnabled(bool value) { }

}

