namespace UnityEngine.UIElements;

internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private uint m_Version; //Field offset: 0x28
	private uint m_LastVersion; //Field offset: 0x2C

	public virtual ProfilerMarker profilerMarker
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 1)]
	private static VisualTreeHierarchyFlagsUpdater() { }

	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public VisualTreeHierarchyFlagsUpdater() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	protected static void DirtyParentHierarchy(VisualElement ve, VisualElementFlags flags) { }

	[CallerCount(Count = 0)]
	public virtual ProfilerMarker get_profilerMarker() { }

	[CallerCount(Count = 0)]
	protected static VisualElementFlags GetChildrenMustDirtyFlags(VisualElement ve, VersionChangeType versionChangeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "DirtyHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElementFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "UpdateElementUnderPointers", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "UpdateBoundingBox", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Update() { }

}

