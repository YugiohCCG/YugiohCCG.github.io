namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeManager.h")]
internal static class AccessibilityNodeManager
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void DestroyNativeNode(int id, int parentId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	internal static void Internal_InvokeDecremented(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal static bool Internal_InvokeDismissed(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AccessibilityManager), Member = "QueueNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	internal static void Internal_InvokeFocusChanged(int id, bool isNodeFocused) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	internal static void Internal_InvokeIncremented(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal static bool Internal_InvokeSelected(int id) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void SetActions(int id, AccessibilityAction[] actions) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static void SetChildren(int id, Int32[] childIds) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetChildren_Injected(int id, ref ManagedSpanWrapper childIds) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void SetFrame(int id, Rect frame) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetFrame_Injected(int id, in Rect frame) { }

}

