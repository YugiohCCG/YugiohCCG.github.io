namespace UnityEngine.UIElements;

[UxmlObject]
public abstract class Binding
{
	internal const string k_UpdateTriggerTooltip = "This informs the binding system of whether the binding object should be updated on every frame, when a change occurs in the source or on every frame if change detection is impossible, and when explicitly marked as dirty."; //Field offset: 0x0
	private bool m_Dirty; //Field offset: 0x10
	private BindingUpdateTrigger m_UpdateTrigger; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <property>k__BackingField; //Field offset: 0x18

	public bool isDirty
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CreateProperty]
	public BindingUpdateTrigger updateTrigger
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Binding() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	internal void ClearDirty() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isDirty() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public BindingUpdateTrigger get_updateTrigger() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void MarkDirty() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected private override void OnActivated(in BindingActivationContext context) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected private override void OnDataSourceChanged(in DataSourceContextChanged context) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected private override void OnDeactivated(in BindingActivationContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetPanelLogLevel(IPanel panel) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_updateTrigger(BindingUpdateTrigger value) { }

	[CallerCount(Count = 0)]
	public static void SetGlobalLogLevel(BindingLogLevel logLevel) { }

	[CalledBy(Type = typeof(PanelSettings), Member = "set_bindingLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingLogLevel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetPanelLogLevel(IPanel panel, BindingLogLevel logLevel) { }

}

