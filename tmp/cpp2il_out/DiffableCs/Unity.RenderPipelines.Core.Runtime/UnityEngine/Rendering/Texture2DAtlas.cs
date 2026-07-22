namespace UnityEngine.Rendering;

public class Texture2DAtlas
{
	private enum BlitType
	{
		Default = 0,
		CubeTo2DOctahedral = 1,
		SingleChannel = 2,
		CubeTo2DOctahedralSingleChannel = 3,
	}

	const int kGPUTexInvalid = 0; //Field offset: 0x0
	const int kGPUTexValidMip0 = 1; //Field offset: 0x0
	const int kGPUTexValidMipAll = 2; //Field offset: 0x0
	private static readonly Vector4 fullScaleOffset; //Field offset: 0x0
	private static readonly int s_MaxMipLevelPadding; //Field offset: 0x10
	 RTHandle m_AtlasTexture; //Field offset: 0x10
	 int m_Width; //Field offset: 0x18
	 int m_Height; //Field offset: 0x1C
	 GraphicsFormat m_Format; //Field offset: 0x20
	 bool m_UseMipMaps; //Field offset: 0x24
	private bool m_IsAtlasTextureOwner; //Field offset: 0x25
	private AtlasAllocator m_AtlasAllocator; //Field offset: 0x28
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"scaleOffset", "size"})]
	private Dictionary<Int32, ValueTuple`2<Vector4, Vector2Int>> m_AllocationCache; //Field offset: 0x30
	private Dictionary<Int32, Int32> m_IsGPUTextureUpToDate; //Field offset: 0x38
	private Dictionary<Int32, Int32> m_TextureHashes; //Field offset: 0x40

	public RTHandle AtlasTexture
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static int maxMipLevelPadding
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	private static Texture2DAtlas() { }

	[CalledBy(Type = typeof(PowerOfTwoTextureAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(FilterMode), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "InitAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(int), typeof(FilterMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "GetTextureMipmapCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Texture2DAtlas(int width, int height, GraphicsFormat format, FilterMode filterMode = 0, bool powerOfTwoPadding = false, string name = "", bool useMipMap = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "IsCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "Is2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset) { }

	[CalledBy(Type = typeof(Texture2DAtlas), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "BlitCubeTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2DAtlas), Member = "GetTextureMipmapCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCubeToOctahedral2DQuadSingleChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitQuadSingleChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCubeToOctahedral2DQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2DAtlas), Member = "IsSingleChannelBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "Blit2DTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(BlitType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = true, int overrideInstanceID = -1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2DAtlas), Member = "Is2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "IsSingleChannelBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "Blit2DTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(BlitType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2DAtlas), Member = "GetTextureMipmapCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "get_blackTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Blitter), Member = "BlitQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearTarget(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ValueTuple`2<Vector4, Vector2Int>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AtlasAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public RTHandle get_AtlasTexture() { }

	[CallerCount(Count = 0)]
	public static int get_maxMipLevelPadding() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ValueTuple`2<Vector4, Vector2Int>&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal Vector2Int GetCachedTextureSize(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUtils), Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	 int GetTextureHash(Texture textureA, Texture textureB) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int GetTextureID(Texture textureA, Texture textureB) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int GetTextureID(Texture texture) { }

	[CalledBy(Type = typeof(PowerOfTwoTextureAtlas), Member = "Blit2DTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), "UnityEngine.Rendering.PowerOfTwoTextureAtlas+BlitType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(FilterMode), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "ClearTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "Blit2DTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(BlitType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	 int GetTextureMipmapCount(int width, int height) { }

	[CalledBy(Type = typeof(PowerOfTwoTextureAtlas), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PowerOfTwoTextureAtlas), Member = "BlitTextureMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PowerOfTwoTextureAtlas), Member = "BlitOctahedralTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PowerOfTwoTextureAtlas), Member = "BlitOctahedralTextureMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PowerOfTwoTextureAtlas), Member = "AllocateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4&), typeof(Texture), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "AllocateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4&), typeof(Texture), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "UpdateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Texture), typeof(Vector4&), typeof(Vector4), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	 bool Is2D(Texture texture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "Fetch2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(int)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "FetchCube", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(int)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "IsCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsCached(out Vector4 scaleOffset, Texture texture) { }

	[CalledBy(Type = typeof(Texture2DAtlas), Member = "IsCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Texture)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "AddTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4&), typeof(Texture)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "UpdateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Texture), typeof(Vector4&), typeof(Vector4), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.ValueTuple`2<UnityEngine.Vector4, UnityEngine.Vector2Int>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ValueTuple`2<Vector4, Vector2Int>&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsCached(out Vector4 scaleOffset, int id) { }

	[CalledBy(Type = typeof(Texture2DAtlas), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "BlitCubeTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetComponentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetSwizzleA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(FormatSwizzle))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetSwizzleB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(FormatSwizzle))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetSwizzleG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(FormatSwizzle))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetSwizzleR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(FormatSwizzle))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	 bool IsSingleChannelBlit(Texture source, Texture destination) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	 void MarkGPUTextureInvalid(int instanceId) { }

	[CalledBy(Type = typeof(Texture2DAtlas), Member = "UpdateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Texture), typeof(Vector4&), typeof(Vector4), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	 void MarkGPUTextureValid(int instanceId, bool mipAreValid = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CoreUtils), Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_updateCount", ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool NeedsUpdate(Texture texture, bool needMips = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override bool NeedsUpdate(int id, int updateCount, bool needMips = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CoreUtils), Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_updateCount", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = false) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2DAtlas), Member = "ResetAllocator", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	public void Release() { }

	[CalledBy(Type = typeof(PowerOfTwoTextureAtlas), Member = "RelayoutEntries", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UpdateAdditionalLightsAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "WorkSlice`1<LightCookieMapping>&", "UnityEngine.Vector4[]"}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Rendering.AtlasAllocator+AtlasNode", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectPool`1<AtlasNode>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ResetAllocator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "IsCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "Is2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "MarkGPUTextureValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public override bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = true, bool blitMips = true) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = true, bool blitMips = true) { }

}

