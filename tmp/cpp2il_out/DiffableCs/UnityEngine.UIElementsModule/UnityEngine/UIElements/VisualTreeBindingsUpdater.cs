namespace UnityEngine.UIElements;

internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
{
	private static readonly PropertyName s_BindingRequestObjectVEPropertyName; //Field offset: 0x0
	private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; //Field offset: 0x4
	private static readonly string s_Description; //Field offset: 0x8
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x10
	private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; //Field offset: 0x18
	private static ProfilerMarker s_MarkerUpdate; //Field offset: 0x20
	private static ProfilerMarker s_MarkerPoll; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <disableBindingsThrottling>k__BackingField; //Field offset: 0x30
	private readonly HashSet<VisualElement> m_ElementsWithBindings; //Field offset: 0x40
	private readonly HashSet<VisualElement> m_ElementsToAdd; //Field offset: 0x48
	private readonly HashSet<VisualElement> m_ElementsToRemove; //Field offset: 0x50
	private long m_LastUpdateTime; //Field offset: 0x58
	private HashSet<VisualElement> m_ElementsToBind; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Dictionary<Object, Object> <temporaryObjectCache>k__BackingField; //Field offset: 0x68
	private List<IBinding> updatedBindings; //Field offset: 0x70

	public static bool disableBindingsThrottling
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public virtual ProfilerMarker profilerMarker
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public Dictionary<Object, Object> temporaryObjectCache
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 1)]
	private static VisualTreeBindingsUpdater() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualTreeHierarchyTrackerUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public VisualTreeBindingsUpdater() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	private static long CurrentTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "PerformTrackingOperations", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_disableBindingsThrottling() { }

	[CallerCount(Count = 0)]
	public virtual ProfilerMarker get_profilerMarker() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Dictionary<Object, Object> get_temporaryObjectCache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public static IBinding GetAdditionalBinding(VisualElement ve) { }

	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "PerformTrackingOperations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "UpdateBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	private IBinding GetBindingObjectFromElement(VisualElement ve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	protected virtual void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualTreeHierarchyTrackerUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "GetBindingObjectFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(IBinding))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "GetBindingObjectFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(IBinding))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public void PerformTrackingOperations() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public static bool ShouldProcessBindings(long startTime) { }

	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void StartTracking(VisualElement ve) { }

	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "GetBindingObjectFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(IBinding))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StartTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void StartTrackingRecursive(VisualElement ve) { }

	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "UpdateBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void StopTracking(VisualElement ve) { }

	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTrackingRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void StopTrackingRecursive(VisualElement ve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualTreeHierarchyTrackerUpdater), Member = "Update", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "PerformTrackingOperations", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "UpdateBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public virtual void Update() { }

	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "GetBindingObjectFromElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(IBinding))]
	[Calls(Type = typeof(VisualTreeBindingsUpdater), Member = "StopTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private void UpdateBindings() { }

}

