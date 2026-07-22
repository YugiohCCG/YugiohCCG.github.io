namespace UnityEngine.UIElements.Layout;

[IsReadOnly]
[RequiredByNativeCode]
internal struct LayoutDataAccess
{
	private readonly int m_Manager; //Field offset: 0x0
	private readonly LayoutDataStore m_Nodes; //Field offset: 0x8
	private readonly LayoutDataStore m_Configs; //Field offset: 0x18

	public bool IsValid
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 18
	}

	[CallerCount(Count = 0)]
	internal LayoutDataAccess(int manager, LayoutDataStore nodes, LayoutDataStore configs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[CallsUnknownMethods(Count = 1)]
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutComputedData GetComputedData(LayoutHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutConfigData GetConfigData(LayoutHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[CallsUnknownMethods(Count = 1)]
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutNodeData GetNodeData(LayoutHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	public VisualElement GetOwner(LayoutHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutStyleData GetStyleData(LayoutHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "GetComponentDataPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private T GetTypedConfigDataRef(LayoutHandle handle, LayoutConfigDataType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.Layout.LayoutDataStore+ComponentDataStore", Member = "GetComponentDataPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte*))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private T GetTypedNodeDataRef(LayoutHandle handle, LayoutNodeDataType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "SetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetOwner(LayoutHandle handle, VisualElement value) { }

}

