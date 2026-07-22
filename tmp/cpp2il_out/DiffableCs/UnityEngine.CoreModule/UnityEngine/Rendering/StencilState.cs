namespace UnityEngine.Rendering;

public struct StencilState : IEquatable<StencilState>
{
	private byte m_Enabled; //Field offset: 0x0
	private byte m_ReadMask; //Field offset: 0x1
	private byte m_WriteMask; //Field offset: 0x2
	private byte m_Padding; //Field offset: 0x3
	private byte m_CompareFunctionFront; //Field offset: 0x4
	private byte m_PassOperationFront; //Field offset: 0x5
	private byte m_FailOperationFront; //Field offset: 0x6
	private byte m_ZFailOperationFront; //Field offset: 0x7
	private byte m_CompareFunctionBack; //Field offset: 0x8
	private byte m_PassOperationBack; //Field offset: 0x9
	private byte m_FailOperationBack; //Field offset: 0xA
	private byte m_ZFailOperationBack; //Field offset: 0xB

	public CompareFunction compareFunctionBack
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 4)]
		 get { } //Length: 7
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public CompareFunction compareFunctionFront
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 4)]
		 get { } //Length: 7
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public static StencilState defaultValue
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 109
	}

	public bool enabled
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.ShaderTagId[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 76
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 88
	}

	public StencilOp failOperationBack
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public StencilOp failOperationFront
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 4
	}

	public StencilOp passOperationBack
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public StencilOp passOperationFront
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 4
	}

	public byte readMask
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public byte writeMask
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public StencilOp zFailOperationBack
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 4
	}

	public StencilOp zFailOperationFront
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
		[CallerCount(Count = 2)]
		 get { } //Length: 7
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StencilState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(byte), typeof(byte), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	public StencilState(bool enabled = true, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = 8, StencilOp passOperation = 0, StencilOp failOperation = 0, StencilOp zFailOperation = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CalledBy(Type = typeof(StencilState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(byte), typeof(byte), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(StencilState other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 4)]
	public CompareFunction get_compareFunctionBack() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 4)]
	public CompareFunction get_compareFunctionFront() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static StencilState get_defaultValue() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DrawObjectsPass", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "UnityEngine.Rendering.Universal.RenderPassEvent", typeof(RenderQueueRange), typeof(LayerMask), typeof(StencilState), typeof(int), "UnityEngine.Rendering.ShaderTagId[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool get_enabled() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public StencilOp get_failOperationBack() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public StencilOp get_failOperationFront() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public StencilOp get_passOperationBack() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public StencilOp get_passOperationFront() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public byte get_readMask() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public byte get_writeMask() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public StencilOp get_zFailOperationBack() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState), typeof(int)}, ReturnType = typeof(StencilState))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "OverwriteStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock), typeof(int), typeof(int)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 2)]
	public StencilOp get_zFailOperationFront() { }

	[CalledBy(Type = typeof(RenderStateBlock), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_compareFunctionBack(CompareFunction value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_compareFunctionFront(CompareFunction value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_enabled(bool value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_failOperationBack(StencilOp value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_failOperationFront(StencilOp value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_passOperationBack(StencilOp value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_passOperationFront(StencilOp value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_readMask(byte value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_writeMask(byte value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_zFailOperationBack(StencilOp value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "CompleteCreation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_zFailOperationFront(StencilOp value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void SetCompareFunction(CompareFunction value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void SetFailOperation(StencilOp value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void SetPassOperation(StencilOp value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "SetStencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareFunction), typeof(StencilOp), typeof(StencilOp), typeof(StencilOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjects", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void SetZFailOperation(StencilOp value) { }

}

