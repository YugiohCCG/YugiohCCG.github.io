namespace UnityEngine.UIElements.UIR;

internal class TextureSlotManager
{
	internal static readonly int k_SlotCount; //Field offset: 0x0
	internal static readonly int k_SlotSize; //Field offset: 0x4
	internal static readonly Int32[] slotIds; //Field offset: 0x8
	internal static readonly int textureTableId; //Field offset: 0x10
	private TextureId[] m_Textures; //Field offset: 0x10
	private Int32[] m_Tickets; //Field offset: 0x18
	private int m_CurrentTicket; //Field offset: 0x20
	private int m_FirstUsedTicket; //Field offset: 0x24
	private Vector4[] m_GpuTextures; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <FreeSlots>k__BackingField; //Field offset: 0x30
	internal TextureRegistry textureRegistry; //Field offset: 0x38

	public private int FreeSlots
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static TextureSlotManager() { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextureSlotManager), Member = "SetGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureId), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public TextureSlotManager() { }

	[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyDrawCommandState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(int), typeof(Material), typeof(bool), typeof(EvaluationState&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextureRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(TextureSlotManager), Member = "SetGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureId), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandList), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Texture), typeof(int), typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Bind(TextureId id, float sdfScale, float sharpness, int slot, MaterialPropertyBlock mat, CommandList commandList = null) { }

	[CalledBy(Type = typeof(VisualTreeAsset), Member = "get_templateDependencies", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.VisualTreeAsset>))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyDrawCommandState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(int), typeof(Material), typeof(bool), typeof(EvaluationState&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public int FindOldestSlot() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_FreeSlots() { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextureId), Member = "get_index", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public int IndexOf(TextureId id) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void MarkUsed(int slotIndex) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextureSlotManager), Member = "SetGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureId), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Reset() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_FreeSlots(int value) { }

	[CalledBy(Type = typeof(TextureSlotManager), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(float), typeof(float), typeof(int), typeof(MaterialPropertyBlock), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextureId), Member = "ConvertToGpu", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale, float sharpness) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void StartNewBatch() { }

}

