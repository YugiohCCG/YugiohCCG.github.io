namespace UnityEngine.UIElements.Experimental;

public sealed class ValueAnimation : IValueAnimationUpdate
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
		[Calls(Type = typeof(ValueAnimation`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ValueAnimation<T> <.cctor>b__67_0() { }

	}

	private static ObjectPool<ValueAnimation`1<T>> sObjectPool; //Field offset: 0x0
	private long m_StartTimeMs; //Field offset: 0x0
	private int m_DurationMs; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Single, Single> <easingCurve>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isRunning>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <onAnimationCompleted>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <autoRecycle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <recycled>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <owner>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<VisualElement, T> <valueUpdated>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<VisualElement, T> <initialValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<T, T, Single, T> <interpolator>k__BackingField; //Field offset: 0x0
	private T _from; //Field offset: 0x0
	private bool fromValueSet; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private T <to>k__BackingField; //Field offset: 0x0

	public bool autoRecycle
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override int durationMs
	{
		[CallerCount(Count = 42)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CalledBy(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	public Func<Single, Single> easingCurve
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public T from
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 80
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public Func<VisualElement, T> initialValue
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Func<T, T, Single, T> interpolator
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public private override bool isRunning
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public Action onAnimationCompleted
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	private VisualElement owner
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	private bool recycled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public T to
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 15
	}

	public Action<VisualElement, T> valueUpdated
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	private static ValueAnimation`1() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__67_0", ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ValueAnimation`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void CheckNotRecycled() { }

	[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValues), typeof(int)}, ReturnType = typeof(UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues>))]
	[CalledBy(Type = typeof(VisualElement), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues>), typeof(StyleValues), typeof(int)}, ReturnType = typeof(UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, Single, T> interpolator) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_autoRecycle() { }

	[CallerCount(Count = 42)]
	[DeduplicatedMethod]
	public override int get_durationMs() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<Single, Single> get_easingCurve() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T get_from() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<VisualElement, T> get_initialValue() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Func<T, T, Single, T> get_interpolator() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override bool get_isRunning() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Action get_onAnimationCompleted() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private VisualElement get_owner() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool get_recycled() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public T get_to() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Action<VisualElement, T> get_valueUpdated() { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ValueAnimation<T> KeepAlive() { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public override void Recycle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void Register() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_autoRecycle(bool value) { }

	[CalledBy(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override void set_durationMs(int value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_easingCurve(Func<Single, Single> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_from(T value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_initialValue(Func<VisualElement, T> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_interpolator(Func<T, T, Single, T> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_isRunning(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_onAnimationCompleted(Action value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_owner(VisualElement value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_recycled(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_to(T value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_valueUpdated(Action<VisualElement, T> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private void SetDefaultValues() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetOwner(VisualElement e) { }

	[CalledBy(Type = typeof(VisualElement), Member = "StartAnimation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Experimental.ValueAnimation`1<T>", "System.Func`2<VisualElement, T>", "T", typeof(int), "System.Action`2<VisualElement, T>"}, ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(VisualElement), Member = "RegisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Start() { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Recycle", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public override void Stop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "UnregisterAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueAnimationUpdate)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void Unregister() { }

}

