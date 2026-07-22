namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
internal abstract class RenderGraphPass
{
	internal struct RandomWriteResourceInfo
	{
		public ResourceHandle h; //Field offset: 0x0
		public bool preserveCounterValue; //Field offset: 0xC

	}

	[CompilerGenerated]
	private string <name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <index>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private RenderGraphPassType <type>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private ProfilingSampler <customSampler>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <enableAsyncCompute>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <allowPassCulling>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	private bool <allowGlobalState>k__BackingField; //Field offset: 0x2A
	[CompilerGenerated]
	private bool <enableFoveatedRasterization>k__BackingField; //Field offset: 0x2B
	[CompilerGenerated]
	private TextureAccess <depthAccess>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private TextureAccess[] <colorBufferAccess>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <colorBufferMaxIndex>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private TextureAccess[] <fragmentInputAccess>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <fragmentInputMaxIndex>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private RandomWriteResourceInfo[] <randomAccessResource>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private int <randomAccessResourceMaxIndex>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <generateDebugData>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private bool <allowRendererListCulling>k__BackingField; //Field offset: 0x75
	public List<ResourceHandle>[] resourceReadLists; //Field offset: 0x78
	public List<ResourceHandle>[] resourceWriteLists; //Field offset: 0x80
	public List<ResourceHandle>[] transientResourceList; //Field offset: 0x88
	public List<RendererListHandle> usedRendererListList; //Field offset: 0x90
	public List<ValueTuple`2<TextureHandle, Int32>> setGlobalsList; //Field offset: 0x98
	public bool useAllGlobalTextures; //Field offset: 0xA0
	public List<ResourceHandle> implicitReadsList; //Field offset: 0xA8

	public bool allowGlobalState
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

	public bool allowPassCulling
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

	public bool allowRendererListCulling
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

	public TextureAccess[] colorBufferAccess
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

	public int colorBufferMaxIndex
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public ProfilingSampler customSampler
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

	public TextureAccess depthAccess
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public bool enableAsyncCompute
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

	public bool enableFoveatedRasterization
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public TextureAccess[] fragmentInputAccess
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

	public int fragmentInputMaxIndex
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool generateDebugData
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

	public int index
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public string name
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public RandomWriteResourceInfo[] randomAccessResource
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int randomAccessResourceMaxIndex
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public internal RenderGraphPassType type
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CalledBy(Type = typeof(BaseRenderGraphPass`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 23)]
	public RenderGraphPass() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AddResourceRead(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AddResourceWrite(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AddTransientResource(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void AllowGlobalState(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void AllowPassCulling(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void AllowRendererListCulling(bool value) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CalledBy(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[CalledBy(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CalledBy(Type = typeof(RenderGraph), Member = "AddRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(RenderGraphBuilder))]
	[CalledBy(Type = typeof(BaseRenderGraphPass`2), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "PassData", typeof(string), typeof(RenderGraphPassType), typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void Clear() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ComputeGraphHash", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void ComputeHash(ref HashFNV1A32 generator, RenderGraphResourceRegistry resources) { }

	[CallerCount(Count = 0)]
	private static void ComputeHashForTextureAccess(ref HashFNV1A32 generator, in ResourceHandle handle, in TextureAccess textureAccess) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceImported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(HashFNV1A32), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "get_antiAliasing", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ComputeTextureHash(ref HashFNV1A32 generator, in ResourceHandle handle, RenderGraphResourceRegistry resources) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void EnableAsyncCompute(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void EnableFoveatedRasterization(bool value) { }

	public abstract void Execute(InternalRenderGraphContext renderGraphContext) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void GenerateDebugData(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_allowGlobalState() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_allowPassCulling() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_allowRendererListCulling() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureAccess[] get_colorBufferAccess() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_colorBufferMaxIndex() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ProfilingSampler get_customSampler() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public TextureAccess get_depthAccess() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_enableAsyncCompute() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_enableFoveatedRasterization() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureAccess[] get_fragmentInputAccess() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_fragmentInputMaxIndex() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_generateDebugData() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_index() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RandomWriteResourceInfo[] get_randomAccessResource() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_randomAccessResourceMaxIndex() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RenderGraphPassType get_type() { }

	public abstract int GetRenderFuncHash() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool HasRenderAttachments() { }

	public abstract bool HasRenderFunc() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsAttachment(in TextureHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.ResourceHandle>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public bool IsRead(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsTransient(in ResourceHandle res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsWritten(in ResourceHandle res) { }

	public abstract void Release(RenderGraphObjectPool pool) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_allowGlobalState(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_allowPassCulling(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_allowRendererListCulling(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_colorBufferAccess(TextureAccess[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_colorBufferMaxIndex(int value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_customSampler(ProfilingSampler value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	protected void set_depthAccess(TextureAccess value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_enableAsyncCompute(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_enableFoveatedRasterization(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_fragmentInputAccess(TextureAccess[] value) { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_fragmentInputMaxIndex(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_generateDebugData(bool value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_index(int value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_randomAccessResource(RandomWriteResourceInfo[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_randomAccessResourceMaxIndex(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_type(RenderGraphPassType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public void SetColorBuffer(in TextureHandle resource, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public void SetColorBufferRaw(in TextureHandle resource, int index, AccessFlags accessFlags, int mipLevel, int depthSlice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetDepthBuffer(in TextureHandle resource, DepthAccess flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetDepthBufferRaw(in TextureHandle resource, AccessFlags accessFlags, int mipLevel, int depthSlice) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public void SetFragmentInputRaw(in TextureHandle resource, int index, AccessFlags accessFlags, int mipLevel, int depthSlice) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void SetRandomWriteResourceRaw(in ResourceHandle resource, int index, bool preserveCounterValue, AccessFlags accessFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void UseRendererList(in RendererListHandle rendererList) { }

}

