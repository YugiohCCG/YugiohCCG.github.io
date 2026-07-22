namespace UnityEngine.UIElements;

[IsReadOnly]
public struct DataSourceContextChanged
{
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	private readonly BindingId m_BindingId; //Field offset: 0x8
	private readonly DataSourceContext m_PreviousContext; //Field offset: 0xA0
	private readonly DataSourceContext m_NewContext; //Field offset: 0x138

	[CalledBy(Type = typeof(BindingData), Member = "set_context", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSourceContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal DataSourceContextChanged(VisualElement element, in BindingId bindingId, in DataSourceContext previousContext, in DataSourceContext newContext) { }

}

