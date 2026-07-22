namespace UnityEngine.UIElements;

internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable
{
	private long frameCount; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<BaseVisualElementPanel> panelChanged; //Field offset: 0x18
	private BaseVisualElementPanel m_Panel; //Field offset: 0x20

	public event Action<BaseVisualElementPanel> panelChanged
	{
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRRepaintUpdater), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 160
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 160
	}

	public override BaseVisualElementPanel panel
	{
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 65
	}

	public abstract ProfilerMarker profilerMarker
	{
		 get { } //Length: 0
	}

	private override long UnityEngine.UIElements.IVisualTreeUpdater.FrameCount
	{
		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		private get { } //Length: 7
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	public VisualElement visualTree
	{
		[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected BaseVisualTreeUpdater() { }

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public void add_panelChanged(Action<BaseVisualElementPanel> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	public override BaseVisualElementPanel get_panel() { }

	public abstract ProfilerMarker get_profilerMarker() { }

	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public VisualElement get_visualTree() { }

	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public void remove_panelChanged(Action<BaseVisualElementPanel> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_panel(BaseVisualElementPanel value) { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	private override long UnityEngine.UIElements.IVisualTreeUpdater.get_FrameCount() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private override void UnityEngine.UIElements.IVisualTreeUpdater.set_FrameCount(long value) { }

	public abstract void Update() { }

}

