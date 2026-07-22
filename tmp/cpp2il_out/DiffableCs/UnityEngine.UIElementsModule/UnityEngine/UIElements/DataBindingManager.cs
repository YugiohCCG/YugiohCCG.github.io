namespace UnityEngine.UIElements;

internal sealed class DataBindingManager : IDisposable
{
	public class BindingData
	{
		public long version; //Field offset: 0x10
		public BindingTarget target; //Field offset: 0x18
		public Binding binding; //Field offset: 0xB8
		private DataSourceContext m_LastContext; //Field offset: 0xC0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private object <localDataSource>k__BackingField; //Field offset: 0x158
		public Nullable<BindingResult> m_SourceToUILastUpdate; //Field offset: 0x160
		public Nullable<BindingResult> m_UIToSourceLastUpdate; //Field offset: 0x178

		public DataSourceContext context
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 874
		}

		public object localDataSource
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			 set { } //Length: 19
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public BindingData() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public object get_localDataSource() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public void set_context(DataSourceContext value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		public void set_localDataSource(object value) { }

	}

	private struct BindingDataCollection : IDisposable
	{
		private Dictionary<BindingId, BindingData> m_BindingPerId; //Field offset: 0x0
		private List<BindingData> m_Bindings; //Field offset: 0x8

		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "StartTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public void AddBindingData(BindingData bindingData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[CallsUnknownMethods(Count = 2)]
		public static BindingDataCollection Create() { }

		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "StopTrackingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public int GetBindingCount() { }

		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		public List<BindingData> GetBindings() { }

		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "StopTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool RemoveBindingData(BindingData bindingData) { }

		[CalledBy(Type = typeof(DataBindingManager), Member = "TryGetBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingData&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool TryGetBindingData(in BindingId bindingId, out BindingData data) { }

	}

	[IsReadOnly]
	private struct BindingRequest
	{
		public readonly BindingId bindingId; //Field offset: 0x0
		public readonly Binding binding; //Field offset: 0x98
		public readonly bool shouldProcess; //Field offset: 0xA0

		[CalledBy(Type = typeof(BindingRequest), Member = "CancelRequest", ReturnType = typeof(BindingRequest))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public BindingRequest(in BindingId bindingId, Binding binding, bool shouldProcess = true) { }

		[CalledBy(Type = typeof(DataBindingManager), Member = "CreateBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BindingRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public BindingRequest CancelRequest() { }

	}

	[IsReadOnly]
	public struct ChangesFromUI
	{
		public readonly long version; //Field offset: 0x0
		public readonly Binding binding; //Field offset: 0x8
		public readonly BindingData bindingData; //Field offset: 0x10

		public bool IsValid
		{
			[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 60
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public ChangesFromUI(BindingData bindingData) { }

		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool get_IsValid() { }

	}

	private class HierarchyBindingTracker : IDisposable
	{
		private class HierarchicalBindingsSorter : HierarchyTraversal
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private HashSet<VisualElement> <boundElements>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private List<VisualElement> <results>k__BackingField; //Field offset: 0x18

			public HashSet<VisualElement> boundElements
			{
				[CallerCount(Count = 106)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
				[CallerCount(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 set { } //Length: 13
			}

			public List<VisualElement> results
			{
				[CallerCount(Count = 31)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
				[CallerCount(Count = 9)]
				[CallsUnknownMethods(Count = 1)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 set { } //Length: 13
			}

			[CallerCount(Count = 162)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public HierarchicalBindingsSorter() { }

			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public HashSet<VisualElement> get_boundElements() { }

			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public List<VisualElement> get_results() { }

			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public void set_boundElements(HashSet<VisualElement> value) { }

			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public void set_results(List<VisualElement> value) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(HierarchyTraversal), Member = "Recurse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			public virtual void TraverseRecursive(VisualElement element, int depth) { }

		}

		private readonly BaseVisualElementPanel m_Panel; //Field offset: 0x10
		private readonly HierarchicalBindingsSorter m_BindingSorter; //Field offset: 0x18
		private readonly Dictionary<VisualElement, BindingDataCollection> m_BindingDataPerElement; //Field offset: 0x20
		private readonly HashSet<VisualElement> m_BoundElements; //Field offset: 0x28
		private readonly List<VisualElement> m_OrderedBindings; //Field offset: 0x30
		private bool m_IsDirty; //Field offset: 0x38
		private EventCallback<PropertyChangedEvent, Dictionary`2<VisualElement, BindingDataCollection>> m_OnPropertyChanged; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		public HierarchyBindingTracker(BaseVisualElementPanel panel) { }

		[CalledBy(Type = typeof(DataBindingManager), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public List<VisualElement> GetBoundElements() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public int GetTrackedElementsCount() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool IsTrackingElement(VisualElement element) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Binding&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BindingId), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 14)]
		private void OnPropertyChanged(PropertyChangedEvent evt, Dictionary<VisualElement, BindingDataCollection> bindingCollection) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private void OrderBindings(VisualElement root) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void SetDirty() { }

		[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.UIElements.DataBindingManager+BindingDataCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "AddBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.UIElements.DataBindingManager+BindingDataCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public void StartTrackingBinding(VisualElement element, BindingData binding) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "RemoveBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.UIElements.DataBindingManager+BindingDataCollection"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyBindingTracker), Member = "StopTrackingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public void StopTrackingBinding(VisualElement element, BindingData binding) { }

		[CalledBy(Type = typeof(HierarchyBindingTracker), Member = "StopTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+BindingDataCollection", Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public void StopTrackingElement(VisualElement element) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool TryGetBindingCollection(VisualElement element, out BindingDataCollection collection) { }

	}

	private class HierarchyDataSourceTracker : IDisposable
	{
		private class InvalidateDataSourcesTraversal : HierarchyTraversal
		{
			private readonly HierarchyDataSourceTracker m_DataSourceTracker; //Field offset: 0x10
			private readonly HashSet<VisualElement> m_VisitedElements; //Field offset: 0x18

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public InvalidateDataSourcesTraversal(HierarchyDataSourceTracker dataSourceTracker) { }

			[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "InvalidateCachedDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 5)]
			[CallsUnknownMethods(Count = 3)]
			public void Invalidate(List<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataSourceContext>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(HierarchyTraversal), Member = "Recurse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual void TraverseRecursive(VisualElement element, int depth) { }

		}

		private class ObjectComparer : IEqualityComparer<Object>
		{

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public ObjectComparer() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 11)]
			[ContainsUnimplementedInstructions]
			private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

		}

		private class SourceInfo
		{
			private HashSet<PropertyPath> m_DetectedChanges; //Field offset: 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private long <lastVersion>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private int <refCount>k__BackingField; //Field offset: 0x20

			public HashSet<PropertyPath> detectedChanges
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>), Member = ".ctor", ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 1)]
				 get { } //Length: 123
			}

			public HashSet<PropertyPath> detectedChangesNoAlloc
			{
				[CallerCount(Count = 106)]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			public long lastVersion
			{
				[CallerCount(Count = 31)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 set { } //Length: 5
			}

			public int refCount
			{
				[CallerCount(Count = 2)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 4
				[CallerCount(Count = 2)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 set { } //Length: 4
			}

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public SourceInfo() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			public HashSet<PropertyPath> get_detectedChanges() { }

			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			public HashSet<PropertyPath> get_detectedChangesNoAlloc() { }

			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public long get_lastVersion() { }

			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public int get_refCount() { }

			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public void set_lastVersion(long value) { }

			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public void set_refCount(int value) { }

		}

		private readonly List<SourceInfo> m_SourceInfosPool; //Field offset: 0x10
		private readonly DataBindingManager m_DataBindingManager; //Field offset: 0x18
		private readonly Dictionary<VisualElement, DataSourceContext> m_ResolvedHierarchicalDataSourceContext; //Field offset: 0x20
		private readonly Dictionary<Binding, Int32> m_BindingRefCount; //Field offset: 0x28
		private readonly Dictionary<Object, SourceInfo> m_SourceInfos; //Field offset: 0x30
		private readonly HashSet<Object> m_SourcesToRemove; //Field offset: 0x38
		private readonly InvalidateDataSourcesTraversal m_InvalidateResolvedDataSources; //Field offset: 0x40
		private readonly EventHandler<BindablePropertyChangedEventArgs> m_Handler; //Field offset: 0x48
		private readonly EventCallback<PropertyChangedEvent, VisualElement> m_VisualElementHandler; //Field offset: 0x50

		[CalledBy(Type = typeof(DataBindingManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(EventHandler`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 11)]
		public HierarchyDataSourceTracker(DataBindingManager manager) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void ClearChangesFromSource(object dataSource) { }

		[CalledBy(Type = typeof(DataBindingManager), Member = "ClearSourceCache", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 16)]
		public void ClearSourceCache() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		internal void DecreaseBindingRefCount(ref BindingData bindingData) { }

		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseBindingRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "TrackDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		internal void DecreaseRefCount(object dataSource) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public HashSet<PropertyPath> GetChangesFromSource(object dataSource) { }

		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataSourceContext>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DataSourceContext&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataSourceContext>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DataSourceContext)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal DataSourceContext GetHierarchicalDataSourceContext(VisualElement element) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		private SourceInfo GetPooledSourceInfo() { }

		[CalledBy(Type = typeof(DataBindingManager), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(DataSourceContext))]
		[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
		[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public int GetTrackedDataSourcesCount() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		internal void IncreaseBindingRefCount(ref BindingData bindingData) { }

		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseBindingRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataBindingManager), Member = "TrackDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType", "TUserArgsType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`2<TEventType, TUserArgsType>", "TUserArgsType", typeof(TrickleDown)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal void IncreaseRefCount(object dataSource) { }

		[CalledBy(Type = typeof(DataBindingManager), Member = "InvalidateCachedDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker+InvalidateDataSourcesTraversal", Member = "Invalidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		public void InvalidateCachedDataSource(HashSet<VisualElement> elements, HashSet<VisualElement> removedElements) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "TrackPropertyChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void OnVisualElementPropertyChanged(PropertyChangedEvent evt, VisualElement element) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		private void ReleasePooledSourceInfo(SourceInfo info) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataSourceContext>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal void RemoveHierarchyDataSourceContextFromElement(VisualElement element) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "TrackPropertyChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		private void TrackPropertyChanges(object sender, BindablePropertyChangedEventArgs args) { }

		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "OnVisualElementPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyChangedEvent), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HierarchyDataSourceTracker), Member = "TrackPropertyChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindablePropertyChangedEventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<Unity.Properties.PropertyPath>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void TrackPropertyChanges(object sender, PropertyPath propertyPath) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool TryGetLastVersion(object source, out long version) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void UpdateVersion(object source, long version) { }

	}

	private struct IgnoreUIChangesData
	{
		public VisualElement element; //Field offset: 0x0
		public Binding binding; //Field offset: 0x8
		public BindingId bindingId; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BindingId), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
		public bool ShouldIgnoreChange(VisualElement ve, Binding b, BindingId id) { }

	}

	internal struct IgnoreUIChangesScope : IDisposable
	{
		private IgnoreUIChangesData m_ScopeData; //Field offset: 0x0
		private DataBindingManager manager; //Field offset: 0xA8

		[CalledBy(Type = typeof(DataBindingManager), Member = "IgnoreChangesScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId), typeof(Binding)}, ReturnType = typeof(IgnoreUIChangesScope))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		internal IgnoreUIChangesScope(DataBindingManager manager, VisualElement target, BindingId bindingId, Binding binding) { }

		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public override void Dispose() { }

	}

	private static readonly PropertyName k_RequestBindingPropertyName; //Field offset: 0x0
	private static readonly BindingId k_ClearBindingsToken; //Field offset: 0x8
	internal static BindingLogLevel globalLogLevel; //Field offset: 0xA0
	private static readonly List<BindingData> s_Empty; //Field offset: 0xA8
	private readonly List<BindingData> m_BindingDataLocalPool; //Field offset: 0x10
	private Nullable<BindingLogLevel> m_LogLevel; //Field offset: 0x18
	private readonly BaseVisualElementPanel m_Panel; //Field offset: 0x20
	private readonly HierarchyDataSourceTracker m_DataSourceTracker; //Field offset: 0x28
	private readonly HierarchyBindingTracker m_BindingsTracker; //Field offset: 0x30
	private readonly List<ChangesFromUI> m_DetectedChangesFromUI; //Field offset: 0x38
	private IgnoreUIChangesData m_IgnoreUIChangesData; //Field offset: 0x40

	internal BindingLogLevel logLevel
	{
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 129
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal set { } //Length: 91
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static DataBindingManager() { }

	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBindingManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	internal DataBindingManager(BaseVisualElementPanel panel) { }

	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "ProcessBindingRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool AnyPendingBindingRequests(VisualElement element) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void CacheSourceBindingResult(BindingData bindingData, BindingResult result) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void CacheUIBindingResult(BindingData bindingData, BindingResult result) { }

	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void ClearAllBindings(VisualElement element) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void ClearChangesFromSource(object dataSource) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "ClearSourceCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearSourceCache() { }

	[CalledBy(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(VisualElement), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingRequest))]
	[Calls(Type = typeof(BindingId), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingRequest), Member = "CancelRequest", ReturnType = typeof(BindingRequest))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingRequest)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private static void CreateBindingRequest(VisualElement target, in BindingId bindingId, Binding binding, bool isTransferring) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DirtyBindingOrder() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyBindingTracker), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal BindingLogLevel get_logLevel() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal List<BindingData> GetBindingData(VisualElement element) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal IEnumerable<VisualElement> GetBoundElements() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetBoundElementsCount() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal HashSet<PropertyPath> GetChangedDetectedFromSource(object dataSource) { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	internal List<ChangesFromUI> GetChangedDetectedFromUI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public BindingData GetPooledBindingData(BindingTarget target, Binding binding) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[CallsUnknownMethods(Count = 1)]
	internal DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnHierarchyChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	internal int GetTrackedDataSourcesCount() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IgnoreUIChangesScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBindingManager), typeof(VisualElement), typeof(BindingId), typeof(Binding)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public IgnoreUIChangesScope IgnoreChangesScope(VisualElement target, BindingId bindingId, Binding binding) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessDataSourceChangedRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "InvalidateCachedDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void InvalidateCachedDataSource(HashSet<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "ClearAllBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Panel), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BindingId), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingRequest))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public void ProcessBindingRequests(VisualElement element) { }

	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyBindingTracker), Member = "StartTrackingBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 27)]
	[ContainsUnimplementedInstructions]
	internal void RegisterBinding(VisualElement element, in BindingId bindingId, Binding binding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void ReleasePoolBindingData(BindingData data) { }

	[CallerCount(Count = 0)]
	internal void ResetLogLevel() { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void set_logLevel(BindingLogLevel value) { }

	[CalledBy(Type = typeof(VisualElement), Member = "TrackSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "IncreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void TrackDataSource(object previous, object current) { }

	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "CreateBindingRequests", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBindingManager), Member = "CreateBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyBindingTracker), Member = "StopTrackingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void TransferBindingRequests(VisualElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingDataCollection), Member = "TryGetBindingData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingData&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	internal bool TryGetBindingData(VisualElement element, in BindingId bindingId, out BindingData bindingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.DataBindingManager+BindingRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingRequest))]
	[Calls(Type = typeof(BindingId), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&), typeof(BindingId&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	internal static bool TryGetBindingRequest(VisualElement element, in BindingId bindingId, out Binding binding) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	internal bool TryGetLastSourceBindingResult(BindingData bindingData, out BindingResult result) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "CacheAndLogBindingResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BindingData&), typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	internal bool TryGetLastUIBindingResult(BindingData bindingData, out BindingResult result) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "GetDataSourceVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Int64>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal bool TryGetLastVersion(object source, out long version) { }

	[CalledBy(Type = typeof(DataBindingManager), Member = "TransferBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ClearAllBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HierarchyBindingTracker), Member = "StopTrackingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingDataCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "DecreaseRefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSourceContextChanged), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(DataSourceContext&), typeof(DataSourceContext&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSourceContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HierarchyDataSourceTracker), Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.BindingId, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 28)]
	internal void UnregisterBinding(VisualElement element, in BindingId bindingId) { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateVersion(object source, long version) { }

}

