namespace UnityEngine.UIElements;

internal class VisualTreeWorldSpaceHierarchyFlagsUpdater : VisualTreeHierarchyFlagsUpdater
{

	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public VisualTreeWorldSpaceHierarchyFlagsUpdater() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private VisualElementFlags GetParentMustDirtyFlags(VisualElement ve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_has3DTransform", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Update() { }

}

