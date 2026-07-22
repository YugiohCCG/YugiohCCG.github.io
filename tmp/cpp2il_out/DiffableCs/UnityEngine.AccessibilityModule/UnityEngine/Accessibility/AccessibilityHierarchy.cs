namespace UnityEngine.Accessibility;

public class AccessibilityHierarchy
{
	internal static readonly HashSet<Int32> usedNodeIds; //Field offset: 0x0
	internal readonly Dictionary<Int32, AccessibilityNode> nodes; //Field offset: 0x10
	internal List<AccessibilityNode> m_RootNodes; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static AccessibilityHierarchy() { }

	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_GetNodeIdAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "TryGetNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[CalledBy(Type = typeof(AccessibilityHierarchyService), Member = "TryGetNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[Calls(Type = typeof(AccessibilityNode), Member = "get_frame", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static AccessibilityNode <TryGetNodeAt>g__FindNodeContainingPoint|28_0(IList<AccessibilityNode> nodes, Vector2 pos) { }

	[CalledBy(Type = typeof(AccessibilityHierarchyService), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityHierarchyService), Member = "RemoveActiveHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AccessibilityNode), Member = "FreeNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void FreeNative() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool TryGetNode(int id, out AccessibilityNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool TryGetNodeAt(float horizontalPosition, float verticalPosition, out AccessibilityNode node) { }

}

