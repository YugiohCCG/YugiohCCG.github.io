namespace UnityEngine.UIElements;

internal class VisualTreeDataBindingsUpdater : BaseVisualTreeUpdater
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<VisualElement> <>9__29_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <ProcessDataSourceChangedRequests>b__29_0(VisualElement e) { }

	}

	[IsReadOnly]
	private struct VersionInfo
	{
		public readonly object source; //Field offset: 0x0
		public readonly long version; //Field offset: 0x8

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public VersionInfo(object source, long version) { }

	}

	private static readonly ProfilerMarker s_UpdateProfilerMarker; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProcessBindingRequestsProfilerMarker; //Field offset: 0x8
	private static readonly ProfilerMarker s_ProcessDataSourcesProfilerMarker; //Field offset: 0x10
	private static readonly ProfilerMarker s_ShouldUpdateBindingProfilerMarker; //Field offset: 0x18
	private static readonly ProfilerMarker s_UpdateBindingProfilerMarker; //Field offset: 0x20
	private readonly BindingUpdater m_Updater; //Field offset: 0x28
	private readonly List<VisualElement> m_BindingRegistrationRequests; //Field offset: 0x30
	private readonly HashSet<VisualElement> m_DataSourceChangedRequests; //Field offset: 0x38
	private readonly HashSet<VisualElement> m_RemovedElements; //Field offset: 0x40
	private readonly List<VisualElement> m_BoundsElement; //Field offset: 0x48
	private readonly List<VersionInfo> m_VersionChanges; //Field offset: 0x50
	private readonly HashSet<Object> m_TrackedObjects; //Field offset: 0x58
	private readonly HashSet<Binding> m_RanUpdate; //Field offset: 0x60
	private readonly HashSet<Object> m_KnownSources; //Field offset: 0x68
	private readonly HashSet<Binding> m_DirtyBindings; //Field offset: 0x70
	private BaseVisualElementPanel m_AttachedPanel; //Field offset: 0x78

	private DataBindingManager bindingManager
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 45
	}

	public virtual ProfilerMarker profilerMarker
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
		[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
		 get { } //Length: 954
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static VisualTreeDataBindingsUpdater() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualTreeUpdater), Member = "add_panelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public VisualTreeDataBindingsUpdater() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataBindingManager), Member = "get_logLevel", ReturnType = typeof(BindingLogLevel))]
	[Calls(Type = typeof(DataBindingManager), Member = "TryGetLastSourceBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData), typeof(BindingResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "TryGetLastUIBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData), typeof(BindingResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "LogResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingResult&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "CacheSourceBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData), typeof(BindingResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "CacheUIBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData), typeof(BindingResult)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void CacheAndLogBindingResult(bool appliedOnUiCache, in BindingData bindingData, in BindingResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessAllBindingRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessDataSourceChangedRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private DataBindingManager get_bindingManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	public virtual ProfilerMarker get_profilerMarker() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataBindingManager), Member = "TryGetLastVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`2<System.Boolean, System.Int64>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private ValueTuple<Boolean, Int64> GetDataSourceVersion(object source) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Key", ReturnType = typeof(object))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Index", ReturnType = typeof(int))]
	[Calls(Type = typeof(PropertyPathPart), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private bool IsPrefix(in PropertyPath prefix, in PropertyPath path) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Panel), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void LogResult(in BindingResult result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataBindingManager), Member = "GetBoundElementsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetTrackedDataSourcesCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "DirtyBindingOrder", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	protected void OnHierarchyChange(VisualElement ve, HierarchyChangeType type, IReadOnlyList<VisualElement> additionalContext = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "remove_hierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "add_hierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyEvent)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPanelChanged(BaseVisualElementPanel p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessAllBindingRequests() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessAllBindingRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessBindingRequests(VisualElement element) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "RemoveWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataBindingManager), Member = "InvalidateCachedDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void ProcessDataSourceChangedRequests() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BindingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(PropertyPath&), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ChangesFromUI), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingUpdater), Member = "ShouldProcessBindingAtStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binding), typeof(BindingUpdateStage), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "IgnoreChangesScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId), typeof(Binding)}, ReturnType = typeof(IgnoreUIChangesScope))]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(IgnoreUIChangesScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private void ProcessPropertyChangedEvents(HashSet<Binding> ranUpdate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<Unity.Properties.PropertyPath>))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "ClearChangesFromSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(DataBindingManager), Member = "UpdateVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(BindingContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(PropertyPath&), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<Unity.Properties.PropertyPath>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetChangedDetectedFromSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "GetDataSourceVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Int64>))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingData>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "GetBoundElements", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualElement>))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessDataSourceChangedRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessAllBindingRequests", ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingUpdater), Member = "ShouldProcessBindingAtStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binding), typeof(BindingUpdateStage), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "ClearSourceCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallsUnknownMethods(Count = 49)]
	[ContainsUnimplementedInstructions]
	public virtual void Update() { }

}

