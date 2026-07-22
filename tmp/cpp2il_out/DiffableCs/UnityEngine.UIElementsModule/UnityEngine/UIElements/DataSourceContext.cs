namespace UnityEngine.UIElements;

[IsReadOnly]
public struct DataSourceContext
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly object <dataSource>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly PropertyPath <dataSourcePath>k__BackingField; //Field offset: 0x8

	public object dataSource
	{
		[CallerCount(Count = 138)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public PropertyPath dataSourcePath
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 81
	}

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingData)}, ReturnType = typeof(DataSourceContext))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(DataSourceContext))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public DataSourceContext(object dataSource, in PropertyPath dataSourcePath) { }

	[CallerCount(Count = 138)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public object get_dataSource() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public PropertyPath get_dataSourcePath() { }

}

