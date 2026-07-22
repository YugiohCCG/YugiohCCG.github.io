namespace UnityEngine.Rendering;

public struct AttachmentDescriptor : IEquatable<AttachmentDescriptor>
{
	private RenderBufferLoadAction m_LoadAction; //Field offset: 0x0
	private RenderBufferStoreAction m_StoreAction; //Field offset: 0x4
	private GraphicsFormat m_Format; //Field offset: 0x8
	private RenderTargetIdentifier m_LoadStoreTarget; //Field offset: 0x10
	private RenderTargetIdentifier m_ResolveTarget; //Field offset: 0x38
	private Color m_ClearColor; //Field offset: 0x60
	private float m_ClearDepth; //Field offset: 0x70
	private uint m_ClearStencil; //Field offset: 0x74

	public Color clearColor
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public float clearDepth
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public uint clearStencil
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public GraphicsFormat graphicsFormat
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public RenderBufferLoadAction loadAction
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public RenderTargetIdentifier loadStoreTarget
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "FindAttachmentDescriptorIndexInList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AttachmentDescriptor), "UnityEngine.Rendering.AttachmentDescriptor[]"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "FindAttachmentDescriptorIndexInList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), "UnityEngine.Rendering.AttachmentDescriptor[]"}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		 get { } //Length: 29
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetupTransientInputAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 set { } //Length: 26
	}

	public RenderTargetIdentifier resolveTarget
	{
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 26
	}

	public RenderBufferStoreAction storeAction
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(void))]
	public AttachmentDescriptor(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public void ConfigureClear(Color clearColor, float clearDepth = 1, uint clearStencil = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void ConfigureResolveTarget(RenderTargetIdentifier target) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void ConfigureTarget(RenderTargetIdentifier target, bool loadExistingContents, bool storeResults) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentDescriptor)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(AttachmentDescriptor), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AttachmentDescriptor), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentDescriptor), typeof(AttachmentDescriptor)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(AttachmentDescriptor other) { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public GraphicsFormat get_graphicsFormat() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "FindAttachmentDescriptorIndexInList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AttachmentDescriptor), "UnityEngine.Rendering.AttachmentDescriptor[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "FindAttachmentDescriptorIndexInList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), "UnityEngine.Rendering.AttachmentDescriptor[]"}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	public RenderTargetIdentifier get_loadStoreTarget() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "GetValidColorAttachmentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.AttachmentDescriptor[]"}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AttachmentDescriptor), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentDescriptor)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(AttachmentDescriptor left, AttachmentDescriptor right) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_clearColor(Color value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_clearDepth(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_clearStencil(uint value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_loadAction(RenderBufferLoadAction value) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetNativeRenderPassMRTAttachmentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetupTransientInputAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void set_loadStoreTarget(RenderTargetIdentifier value) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_resolveTarget(RenderTargetIdentifier value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_storeAction(RenderBufferStoreAction value) { }

}

