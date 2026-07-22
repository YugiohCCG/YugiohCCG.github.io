namespace UnityEngine.UIElements.UIR;

internal class ImplicitPool
{
	private readonly int m_StartCapacity; //Field offset: 0x0
	private readonly int m_MaxCapacity; //Field offset: 0x0
	private Func<T> m_CreateAction; //Field offset: 0x0
	private Action<T> m_ResetAction; //Field offset: 0x0
	private List<T> m_List; //Field offset: 0x0
	private int m_UsedCount; //Field offset: 0x0

	[CalledBy(Type = typeof(EntryPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshWriteDataPool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel), typeof(UIRenderDevice), typeof(AtlasBase), typeof(VectorImageManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public ImplicitPool`1(Func<T> createAction, Action<T> resetAction, int startCapacity, int maxCapacity) { }

	[CalledBy(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T Get() { }

	[CalledBy(Type = typeof(EntryPool), Member = "ReturnAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public void ReturnAll() { }

}

