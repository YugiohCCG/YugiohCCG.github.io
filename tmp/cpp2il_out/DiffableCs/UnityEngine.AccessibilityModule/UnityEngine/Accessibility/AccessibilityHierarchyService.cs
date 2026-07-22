namespace UnityEngine.Accessibility;

internal class AccessibilityHierarchyService : IService
{
	private AccessibilityHierarchy m_Hierarchy; //Field offset: 0x10

	internal AccessibilityHierarchy hierarchy
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public AccessibilityHierarchyService() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal AccessibilityHierarchy get_hierarchy() { }

	[CallerCount(Count = 0)]
	internal List<AccessibilityNode> GetRootNodes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "FreeNative", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveActiveHierarchy(bool notifyScreenChanged) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Start() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "FreeNative", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Stop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal bool TryGetNode(int id, out AccessibilityNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool TryGetNodeAt(float x, float y, out AccessibilityNode node) { }

}

