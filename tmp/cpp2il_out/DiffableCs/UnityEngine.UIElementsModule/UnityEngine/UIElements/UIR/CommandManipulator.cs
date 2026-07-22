namespace UnityEngine.UIElements.UIR;

[Extension]
internal static class CommandManipulator
{

	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnDisableRenderingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "OnRenderCommandsRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "AllocCommand", ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(RenderChain), Member = "OnRenderCommandAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandManipulator), Member = "FindHeadCommandInsertionPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChainCommand&), typeof(RenderChainCommand&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(RenderChainVEData), Member = "get_lastTailOrHeadCommand", ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(CommandManipulator), Member = "IsParentOrAncestorOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 50)]
	[ContainsUnimplementedInstructions]
	public static void DisableElementRendering(RenderChain renderChain, VisualElement ve, bool renderingDisabled) { }

	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(RenderChainVEData), Member = "get_lastTailOrHeadCommand", ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(CommandManipulator), Member = "IsParentOrAncestorOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static void FindHeadCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(RenderChainVEData), Member = "get_lastTailOrHeadCommand", ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(CommandManipulator), Member = "IsParentOrAncestorOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	private static void FindTailCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderChain), Member = "OnRenderCommandAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, RenderChainCommand prev, RenderChainCommand next) { }

	[CalledBy(Type = typeof(CommandManipulator), Member = "FindHeadCommandInsertionPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChainCommand&), typeof(RenderChainCommand&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "FindTailCommandInsertionPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChainCommand&), typeof(RenderChainCommand&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "OnRenderCommandsRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void RemoveChain(RenderChain renderChain, RenderChainCommand first, RenderChainCommand last) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "OnRenderCommandsRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static void RemoveSingleCommand(RenderChain renderChain, VisualElement ve, RenderChainCommand cmd) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandManipulator), Member = "ResetCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "OnRenderCommandsRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandManipulator), Member = "FindHeadCommandInsertionPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChainCommand&), typeof(RenderChainCommand&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "OnRenderCommandAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandManipulator), Member = "FindTailCommandInsertionPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChainCommand&), typeof(RenderChainCommand&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	public static void ReplaceCommands(RenderChain renderChain, VisualElement ve, EntryProcessor processor) { }

	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderChain), Member = "OnRenderCommandsRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public static void ResetCommands(RenderChain renderChain, VisualElement ve) { }

}

