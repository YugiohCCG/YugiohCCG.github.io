namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem
{
	private struct AnimationDataSet
	{
		public VisualElement[] elements; //Field offset: 0x0
		public StylePropertyId[] properties; //Field offset: 0x0
		public TTimingData[] timing; //Field offset: 0x0
		public TStyleData[] style; //Field offset: 0x0
		public int count; //Field offset: 0x0
		private Dictionary<ElementPropertyPair, Int32> indices; //Field offset: 0x0

		private int capacity
		{
			[CallerCount(Count = 24)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private get { } //Length: 25
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private set { } //Length: 199
		}

		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "UpdateProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }

		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AnimationDataSet`2), Member = "LocalInit", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static AnimationDataSet<TTimingData, TStyleData> Create() { }

		[CallerCount(Count = 24)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private int get_capacity() { }

		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "GetAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyId>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties) { }

		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index) { }

		[CalledBy(Type = typeof(AnimationDataSet`2), Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TTimingData, TStyleData>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		private void LocalInit() { }

		[CalledBy(Type = typeof(AnimationDataSet`2), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		[DeduplicatedMethod]
		public void Remove(int cancelledIndex) { }

		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AnimationDataSet`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void RemoveAll(VisualElement ve) { }

		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAllAnimations", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public void RemoveAll() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public void Replace(int index, TTimingData timingData, TStyleData styleData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private void set_capacity(int value) { }

	}

	private struct ElementPropertyPair
	{
		private class EqualityComparer : IEqualityComparer<ElementPropertyPair>
		{

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public EqualityComparer() { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			public override bool Equals(ElementPropertyPair x, ElementPropertyPair y) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public override int GetHashCode(ElementPropertyPair obj) { }

		}

		public static readonly IEqualityComparer<ElementPropertyPair> Comparer; //Field offset: 0x0
		public readonly VisualElement element; //Field offset: 0x0
		public readonly StylePropertyId property; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static ElementPropertyPair() { }

		[CallerCount(Count = 19)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ElementPropertyPair(VisualElement element, StylePropertyId property) { }

	}

	[Flags]
	private enum TransitionState
	{
		None = 0,
		Running = 1,
		Started = 2,
		Ended = 4,
		Canceled = 8,
	}

	private abstract class Values
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected Values() { }

		public abstract void CancelAllAnimations() { }

		public abstract void CancelAllAnimations(VisualElement ve) { }

		public abstract void CancelAnimation(VisualElement ve, StylePropertyId id) { }

		public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) { }

		public abstract void Update(long currentTimeMs) { }

		public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

		protected abstract void UpdateComputedStyle() { }

		protected abstract void UpdateComputedStyle(int i) { }

		protected abstract void UpdateValues() { }

	}

	private abstract class Values : Values
	{
		internal struct EmptyData
		{
			public static EmptyData<T> Default; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private static EmptyData() { }

		}

		internal struct StyleData
		{
			public T startValue; //Field offset: 0x0
			public T endValue; //Field offset: 0x0
			public T reversingAdjustedStartValue; //Field offset: 0x0
			public T currentValue; //Field offset: 0x0

		}

		internal struct TimingData
		{
			public long startTimeMs; //Field offset: 0x0
			public int durationMs; //Field offset: 0x0
			public Func<Single, Single> easingCurve; //Field offset: 0x0
			public float easedProgress; //Field offset: 0x0
			public float reversingShorteningFactor; //Field offset: 0x0
			public bool isStarted; //Field offset: 0x0
			public int delayMs; //Field offset: 0x0

		}

		private class TransitionEventsFrameState
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c<T> <>9; //Field offset: 0x0

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 8)]
				[DeduplicatedMethod]
				private static <>c() { }

				[CallerCount(Count = 2180)]
				[CallsDeduplicatedMethods(Count = 1)]
				[DeduplicatedMethod]
				public <>c() { }

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[DeduplicatedMethod]
				internal Queue<EventBase> <.cctor>b__11_0() { }

			}

			private static readonly ObjectPool<Queue`1<EventBase>> k_EventQueuePool; //Field offset: 0x0
			public readonly Dictionary<ElementPropertyPair, TransitionState> elementPropertyStateDelta; //Field offset: 0x0
			public readonly Dictionary<ElementPropertyPair, Queue`1<EventBase>> elementPropertyQueuedEvents; //Field offset: 0x0
			public IPanel panel; //Field offset: 0x0
			private int m_ChangesCount; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 10)]
			[DeduplicatedMethod]
			private static TransitionEventsFrameState() { }

			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = ".ctor", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1", Member = ".ctor", ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public TransitionEventsFrameState() { }

			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "ProcessEventQueue", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
			[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
			[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 12)]
			[DeduplicatedMethod]
			public void Clear() { }

			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 6)]
			[DeduplicatedMethod]
			public static Queue<EventBase> GetPooledQueue() { }

			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			public void RegisterChange() { }

			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			public bool StateChanged() { }

			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			public void UnregisterChange() { }

		}

		private long m_CurrentTimeMs; //Field offset: 0x0
		private TransitionEventsFrameState<T> m_CurrentFrameEventsState; //Field offset: 0x0
		private TransitionEventsFrameState<T> m_NextFrameEventsState; //Field offset: 0x0
		public AnimationDataSet<TimingData<T>, StyleData<T>> running; //Field offset: 0x0
		public AnimationDataSet<EmptyData<T>, T> completed; //Field offset: 0x0

		public bool isEmpty
		{
			[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "UpdateTracking", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 10
		}

		public abstract Func<T, T, Boolean> SameFunc
		{
			 get { } //Length: 0
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TTimingData, TStyleData>")]
		[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		protected Values`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Values`1), Member = "SendTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "RemoveAll", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "RemoveAll", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 15)]
		[DeduplicatedMethod]
		public virtual void CancelAllAnimations() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Values`1), Member = "SendTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 15)]
		[DeduplicatedMethod]
		public virtual void CancelAllAnimations(VisualElement ve) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public virtual void CancelAnimation(VisualElement ve, StylePropertyId id) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void ClearEventQueue(ElementPropertyPair epp) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private float ComputeReversingShorteningFactor(int oldIndex) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		protected override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private void ForceComputedStyleEndValue(int runningIndex) { }

		[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "UpdateTracking", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_isEmpty() { }

		public abstract Func<T, T, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "GetActivePropertiesForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyId>)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "GetActivePropertiesForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyId>)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public virtual void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) { }

		[CalledBy(Type = typeof(Values`1), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		private void ProcessEventQueue() { }

		[CalledBy(Type = typeof(Values`1), Member = "QueueTransitionRunEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "QueueTransitionStartEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "QueueTransitionEndEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "GetPooledQueue", ReturnType = typeof(System.Collections.Generic.Queue`1<UnityEngine.UIElements.EventBase>))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private void QueueEvent(EventBase evt, ElementPropertyPair epp) { }

		[CalledBy(Type = typeof(Values`1), Member = "CancelAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[Calls(Type = typeof(Values`1), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) { }

		[CalledBy(Type = typeof(Values`1), Member = "UpdateProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[Calls(Type = typeof(Values`1), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) { }

		[CalledBy(Type = typeof(Values`1), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[Calls(Type = typeof(Values`1), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) { }

		[CalledBy(Type = typeof(Values`1), Member = "UpdateProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[Calls(Type = typeof(Values`1), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) { }

		[CalledBy(Type = typeof(Values`1), Member = "CancelAllAnimations", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "CancelAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) { }

		[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Background>+TimingData<Background>", "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Background>+StyleData<Background>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionRunEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Background>+TimingData<Background>", "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Background>+StyleData<Background>"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 14)]
		[CallsUnknownMethods(Count = 19)]
		[DeduplicatedMethod]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve, long currentTimeMs) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private void SwapFrameStates() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Values`1), Member = "UpdateProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "StateChanged", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Values`1), Member = "ProcessEventQueue", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual void Update(long currentTimeMs) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

		[CalledBy(Type = typeof(Values`1), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionStartEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "TTimingData", "TStyleData"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionEndEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private void UpdateProgress(long currentTimeMs) { }

	}

	private class ValuesBackground : ValuesDiscrete<Background>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1", Member = ".ctor", ReturnType = typeof(void))]
		public ValuesBackground() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesBackgroundPosition : ValuesDiscrete<BackgroundPosition>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<BackgroundPosition>", Member = ".ctor", ReturnType = typeof(void))]
		public ValuesBackgroundPosition() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesBackgroundRepeat : ValuesDiscrete<BackgroundRepeat>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<BackgroundRepeat>", Member = ".ctor", ReturnType = typeof(void))]
		public ValuesBackgroundRepeat() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesBackgroundSize : Values<BackgroundSize>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<BackgroundSize, BackgroundSize, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<BackgroundSize, BackgroundSize, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<BackgroundSize>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesBackgroundSize() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<BackgroundSize, BackgroundSize, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
		private static bool IsSame(BackgroundSize a, BackgroundSize b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
		[Calls(Type = typeof(BackgroundSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
		[Calls(Type = typeof(BackgroundSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private class ValuesColor : Values<Color>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<Color, Color, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<Color, Color, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Color>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesColor() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<Color, Color, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		private static bool IsSame(Color c, Color d) { }

		[CallerCount(Count = 0)]
		private static Color Lerp(Color a, Color b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Color)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Color)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private abstract class ValuesDiscrete : Values<T>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<T, T, Boolean> <SameFunc>k__BackingField; //Field offset: 0x0

		public virtual Func<T, T, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackground", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TTimingData, TStyleData>")]
		[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		protected ValuesDiscrete`1() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<T, T, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.Background>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.Background>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		private static bool IsSame(T a, T b) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private static T Lerp(T a, T b, float t) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		protected virtual void UpdateValues() { }

	}

	private class ValuesEnum : ValuesDiscrete<Int32>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<Int32>", Member = ".ctor", ReturnType = typeof(void))]
		public ValuesEnum() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesFloat : Values<Single>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<Single, Single, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<Single, Single, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Func`3<System.Single, System.Single, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Single>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesFloat() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<Single, Single, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private static bool IsSame(float a, float b) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private static float Lerp(float a, float b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private class ValuesFont : ValuesDiscrete<Font>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<Object>", Member = ".ctor", ReturnType = typeof(void))]
		public ValuesFont() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Font)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Font)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesFontDefinition : ValuesDiscrete<FontDefinition>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<FontDefinition>", Member = ".ctor", ReturnType = typeof(void))]
		public ValuesFontDefinition() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

	}

	private class ValuesInt : Values<Int32>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<Int32, Int32, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<Int32, Int32, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Func`3<System.Int32, System.Int32, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesInt() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<Int32, Int32, Boolean> get_SameFunc() { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private static bool IsSame(int a, int b) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		private static int Lerp(int a, int b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		protected virtual void UpdateValues() { }

	}

	private class ValuesLength : Values<Length>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<Length, Length, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<Length, Length, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Length>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesLength() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<Length, Length, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private static bool IsSame(Length a, Length b) { }

		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate), typeof(float)}, ReturnType = typeof(Translate))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "UpdateValues", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin), typeof(float)}, ReturnType = typeof(TransformOrigin))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "UpdateValues", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize), typeof(float)}, ReturnType = typeof(BackgroundSize))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateValues", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		internal static Length Lerp(Length a, Length b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private class ValuesRotate : Values<Rotate>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<Rotate, Rotate, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<Rotate, Rotate, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Rotate>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesRotate() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<Rotate, Rotate, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
		private static bool IsSame(Rotate a, Rotate b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Angle), Member = "ToDegrees", ReturnType = typeof(float))]
		[Calls(Type = typeof(Rotate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Angle)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		private static Rotate Lerp(Rotate a, Rotate b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Rotate)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Rotate)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Angle), Member = "ToDegrees", ReturnType = typeof(float))]
		[Calls(Type = typeof(Rotate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Angle)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private class ValuesScale : Values<Scale>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<Scale, Scale, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<Scale, Scale, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Scale>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesScale() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<Scale, Scale, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private static bool IsSame(Scale a, Scale b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private static Scale Lerp(Scale a, Scale b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Scale)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Scale)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private class ValuesTextShadow : Values<TextShadow>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<TextShadow, TextShadow, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<TextShadow, TextShadow, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Func`3<UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<TextShadow>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesTextShadow() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<TextShadow, TextShadow, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
		private static bool IsSame(TextShadow a, TextShadow b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextShadow), Member = "LerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow), typeof(float)}, ReturnType = typeof(TextShadow))]
		private static TextShadow Lerp(TextShadow a, TextShadow b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextShadow), Member = "LerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow), typeof(float)}, ReturnType = typeof(TextShadow))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private class ValuesTransformOrigin : Values<TransformOrigin>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<TransformOrigin, TransformOrigin, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<TransformOrigin, TransformOrigin, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<TransformOrigin>", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public ValuesTransformOrigin() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "TryConvertTransformOriginUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin&), typeof(TransformOrigin&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<TransformOrigin, TransformOrigin, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransformOrigin), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
		private static bool IsSame(TransformOrigin a, TransformOrigin b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(TransformOrigin), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(TransformOrigin), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private class ValuesTranslate : Values<Translate>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Func<Translate, Translate, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		public virtual Func<Translate, Translate, Boolean> SameFunc
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Translate>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public ValuesTranslate() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "TryConvertTranslateUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate&), typeof(Translate&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public virtual Func<Translate, Translate, Boolean> get_SameFunc() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
		private static bool IsSame(Translate a, Translate b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(Translate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		private static Translate Lerp(Translate a, Translate b, float t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateComputedStyle(int i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(Translate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void UpdateValues() { }

	}

	private long m_CurrentTimeMs; //Field offset: 0x10
	private ValuesFloat m_Floats; //Field offset: 0x18
	private ValuesInt m_Ints; //Field offset: 0x20
	private ValuesLength m_Lengths; //Field offset: 0x28
	private ValuesColor m_Colors; //Field offset: 0x30
	private ValuesEnum m_Enums; //Field offset: 0x38
	private ValuesBackground m_Backgrounds; //Field offset: 0x40
	private ValuesFontDefinition m_FontDefinitions; //Field offset: 0x48
	private ValuesFont m_Fonts; //Field offset: 0x50
	private ValuesTextShadow m_TextShadows; //Field offset: 0x58
	private ValuesScale m_Scale; //Field offset: 0x60
	private ValuesRotate m_Rotate; //Field offset: 0x68
	private ValuesTranslate m_Translate; //Field offset: 0x70
	private ValuesTransformOrigin m_TransformOrigin; //Field offset: 0x78
	private ValuesBackgroundPosition m_BackgroundPosition; //Field offset: 0x80
	private ValuesBackgroundRepeat m_BackgroundRepeat; //Field offset: 0x88
	private ValuesBackgroundSize m_BackgroundSize; //Field offset: 0x90
	private readonly List<Values> m_AllValues; //Field offset: 0x98
	private readonly Dictionary<StylePropertyId, Values> m_PropertyToValues; //Field offset: 0xA0

	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public StylePropertyAnimationSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public override void CancelAllAnimations(VisualElement owner) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void CancelAllAnimations() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	private long CurrentTimeMs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) { }

	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow), typeof(TextShadow), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat), typeof(BackgroundRepeat), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin), typeof(TransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate), typeof(Translate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Rotate), typeof(Rotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Scale), typeof(Scale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize), typeof(BackgroundSize), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Font), typeof(Font), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background), typeof(Background), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransitionEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Color), typeof(Color), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length), typeof(Length), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float), typeof(float), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition), typeof(FontDefinition), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private T GetOrCreate(ref T values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize), typeof(BackgroundSize), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.BackgroundSize>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat), typeof(BackgroundRepeat), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.BackgroundRepeat>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.BackgroundPosition>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin), typeof(TransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.TransformOrigin>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate), typeof(Translate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.Translate>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Rotate), typeof(Rotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.Rotate>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow), typeof(TextShadow), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.TextShadow>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(object), typeof(object), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<System.Object>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition), typeof(FontDefinition), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.FontDefinition>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Color), typeof(Color), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.Color>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length), typeof(Length), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.Length>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<System.Int32>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float), typeof(float), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<System.Single>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background), typeof(Background), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Values`1), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Values`1), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve, Values<T> values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Scale), typeof(Scale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.Scale>)}, ReturnType = typeof(bool))]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<System.Int32>)}, ReturnType = typeof(bool))]
	public override bool StartTransitionEnum(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Update() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Values`1), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void UpdateTracking(Values<T> values) { }

}

