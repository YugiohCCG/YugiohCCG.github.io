namespace UnityEngine.UIElements;

[IsReadOnly]
public struct BindingContext
{
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	private readonly BindingId m_BindingId; //Field offset: 0x8
	private readonly PropertyPath m_DataSourcePath; //Field offset: 0xA0
	private readonly object m_DataSource; //Field offset: 0x130

	public BindingId bindingId
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 97
	}

	public object dataSource
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public PropertyPath dataSourcePath
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 105
	}

	public VisualElement targetElement
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal BindingContext(VisualElement targetElement, in BindingId bindingId, in PropertyPath resolvedDataSourcePath, object resolvedDataSource) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BindingId get_bindingId() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public object get_dataSource() { }

	[CallerCount(Count = 0)]
	public PropertyPath get_dataSourcePath() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public VisualElement get_targetElement() { }

}

