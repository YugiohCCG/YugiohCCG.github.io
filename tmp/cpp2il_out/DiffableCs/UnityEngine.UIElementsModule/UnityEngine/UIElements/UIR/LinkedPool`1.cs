namespace UnityEngine.UIElements.UIR;

internal class LinkedPool
{
	private readonly Func<T> m_CreateFunc; //Field offset: 0x0
	private readonly Action<T> m_ResetAction; //Field offset: 0x0
	private readonly int m_Limit; //Field offset: 0x0
	private T m_PoolFirst; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <Count>k__BackingField; //Field offset: 0x0

	public private int Count
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(TextureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Row), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasicNodePool`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel), typeof(UIRenderDevice), typeof(AtlasBase), typeof(VectorImageManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorImageRenderInfoPool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientRemapPool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorImageManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public LinkedPool`1(Func<T> createFunc, Action<T> resetAction, int limit = 10000) { }

	[CalledBy(Type = typeof(VectorImageManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = typeof(DynamicAtlas), Member = "TryGetAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Texture2D), typeof(TextureId&), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Alloc))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = "SplitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BestFitAllocator+Block", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "AllocCommand", ReturnType = typeof(RenderChainCommand))]
	[CalledBy(Type = typeof(RenderChain), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(ExtraRenderChainVEData))]
	[CalledBy(Type = typeof(RenderChain), Member = "InsertExtraMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "InsertTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Texture), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VectorImageManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(VectorImageRenderInfo))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T Get() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CalledBy(Type = typeof(DynamicAtlas), Member = "ReturnAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Texture2D), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BestFitAllocator), Member = "CoalesceBlockWithPrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BestFitAllocator+Block"}, ReturnType = "UnityEngine.UIElements.UIR.BestFitAllocator+Block")]
	[CalledBy(Type = typeof(RenderChain), Member = "FreeCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "FreeExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "FreeExtraMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Return(T item) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Count(int value) { }

}

