namespace UnityEngine.UIElements.UIR;

internal class EntryProcessor
{
	private struct MaskMesh
	{
		public NativeSlice<Vertex> vertices; //Field offset: 0x0
		public NativeSlice<UInt16> indices; //Field offset: 0x10
		public int indexOffset; //Field offset: 0x20

	}

	private static Material s_blitMaterial_LinearToGamma; //Field offset: 0x0
	private static Material s_blitMaterial_GammaToLinear; //Field offset: 0x8
	private static Material s_blitMaterial_NoChange; //Field offset: 0x10
	private static Shader s_blitShader; //Field offset: 0x18
	private EntryPreProcessor m_PreProcessor; //Field offset: 0x10
	private RenderChain m_RenderChain; //Field offset: 0x18
	private VisualElement m_CurrentElement; //Field offset: 0x20
	private int m_MaskDepth; //Field offset: 0x28
	private int m_MaskDepthPopped; //Field offset: 0x2C
	private int m_MaskDepthPushed; //Field offset: 0x30
	private int m_StencilRef; //Field offset: 0x34
	private int m_StencilRefPopped; //Field offset: 0x38
	private int m_StencilRefPushed; //Field offset: 0x3C
	private BMPAlloc m_ClipRectId; //Field offset: 0x40
	private BMPAlloc m_ClipRectIdPopped; //Field offset: 0x48
	private BMPAlloc m_ClipRectIdPushed; //Field offset: 0x50
	private bool m_IsDrawingMask; //Field offset: 0x58
	private Stack<MaskMesh> m_MaskMeshes; //Field offset: 0x60
	private bool m_VertexDataComputed; //Field offset: 0x68
	private Matrix4x4 m_Transform; //Field offset: 0x6C
	private Color32 m_TransformData; //Field offset: 0xAC
	private Color32 m_OpacityData; //Field offset: 0xB0
	private Color32 m_TextCoreSettingsPage; //Field offset: 0xB4
	private MeshHandle m_Mesh; //Field offset: 0xB8
	private NativeSlice<Vertex> m_Verts; //Field offset: 0xC0
	private NativeSlice<UInt16> m_Indices; //Field offset: 0xD0
	private ushort m_IndexOffset; //Field offset: 0xE0
	private int m_AllocVertexCount; //Field offset: 0xE4
	private int m_AllocIndex; //Field offset: 0xE8
	private int m_VertsFilled; //Field offset: 0xEC
	private int m_IndicesFilled; //Field offset: 0xF0
	private VertexFlags m_RenderType; //Field offset: 0xF4
	private bool m_RemapUVs; //Field offset: 0xF8
	private Rect m_AtlasRect; //Field offset: 0xFC
	private int m_GradientSettingIndexOffset; //Field offset: 0x10C
	private bool m_IsTail; //Field offset: 0x110
	private RenderChainCommand m_FirstCommand; //Field offset: 0x118
	private RenderChainCommand m_LastCommand; //Field offset: 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderChainCommand <firstHeadCommand>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderChainCommand <lastHeadCommand>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderChainCommand <firstTailCommand>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderChainCommand <lastTailCommand>k__BackingField; //Field offset: 0x140

	public private RenderChainCommand firstHeadCommand
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public private RenderChainCommand firstTailCommand
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public private RenderChainCommand lastHeadCommand
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public private RenderChainCommand lastTailCommand
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public EntryProcessor() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MeshGenerator), Member = "StampRectangleWithSubRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams), typeof(Rect), typeof(Rect), typeof(Rect), typeof(NativePagedList`1<BackgroundRepeatInstance>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.UIElements.UIR.MeshGenerator+RepeatRectUV>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativePagedList`1), Member = "GetCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.MeshGenerator+RepeatRectUV>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.UIR.MeshGenerator+RepeatRectUV"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AlignmentUtils), Member = "CeilToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 119)]
	[ContainsUnimplementedInstructions]
	private void AppendCommand(RenderChainCommand next) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void ClearReferences() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "GetBlitMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetMode)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_hideFlags", ReturnType = typeof(HideFlags))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Material CreateBlitShader(float colorConversion) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "DrawReverseMask", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderChain), Member = "AllocCommand", ReturnType = typeof(RenderChainCommand))]
	[CallsUnknownMethods(Count = 5)]
	private RenderChainCommand CreateMeshDrawCommand(MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.UIR.EntryProcessor+MaskMesh>), Member = "TryPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskMesh&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "CreateMeshDrawCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(int), typeof(int), typeof(Material), typeof(TextureId)}, ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.CopyMeshJobData>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CopyMeshJobData&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void DrawReverseMask() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RenderChainCommand get_firstHeadCommand() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RenderChainCommand get_firstTailCommand() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RenderChainCommand get_lastHeadCommand() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public RenderChainCommand get_lastTailCommand() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EntryProcessor), Member = "CreateBlitShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Material))]
	[CallsUnknownMethods(Count = 3)]
	private static Material GetBlitMaterial(RenderTargetMode mode) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntryPreProcessor), Member = "PreProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "FreeExtraMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void Init(Entry root, RenderChain renderChain, VisualElement ve) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessHead", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessTail", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "get_statsByRef", ReturnType = typeof(ChainBuilderStats&))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void ProcessFirstAlloc(List<AllocSize> allocList, ref MeshHandle mesh) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void ProcessHead() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ClipRectAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "TransformAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "OpacityAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "TextCoreSettingsToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(TextureId), Member = "ConvertToGpu", ReturnType = typeof(float))]
	[Calls(Type = typeof(NativePagedList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<UnityEngine.UIElements.UIR.EntryProcessor+MaskMesh>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskMesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "CreateMeshDrawCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(int), typeof(int), typeof(Material), typeof(TextureId)}, ReturnType = typeof(RenderChainCommand))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void ProcessMeshEntry(Entry entry, TextureId textureId) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "get_statsByRef", ReturnType = typeof(ChainBuilderStats&))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[Calls(Type = typeof(RenderChain), Member = "InsertExtraMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void ProcessNextAlloc() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessHead", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessTail", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderChain), Member = "AllocCommand", ReturnType = typeof(RenderChainCommand))]
	[Calls(Type = typeof(VisualElement), Member = "get_subRenderTargetMode", ReturnType = typeof(RenderTargetMode))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "DrawReverseMask", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VectorImageManager), Member = "AddUser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage), typeof(VisualElement)}, ReturnType = typeof(GradientRemap))]
	[Calls(Type = typeof(EntryProcessor), Member = "GetBlitMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetMode)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(RenderChain), Member = "InsertTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Texture), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureRegistry), Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(TextureId))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private void ProcessRange(int first, int last) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void ProcessTail() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_firstHeadCommand(RenderChainCommand value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_firstTailCommand(RenderChainCommand value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_lastHeadCommand(RenderChainCommand value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_lastTailCommand(RenderChainCommand value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex>& verts, out NativeSlice<UInt16>& indices, out ushort indexOffset, ref ChainBuilderStats stats) { }

}

