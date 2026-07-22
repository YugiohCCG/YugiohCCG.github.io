namespace UnityEngine.Rendering.Universal;

internal struct ReflectionProbeManager : IDisposable
{
	private struct CachedProbe
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <dataIndices>e__FixedBuffer
		{
			public int FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <levels>e__FixedBuffer
		{
			public int FixedElementField; //Field offset: 0x0

		}

		public uint updateCount; //Field offset: 0x0
		public Hash128 imageContentsHash; //Field offset: 0x8
		public int size; //Field offset: 0x18
		public int mipCount; //Field offset: 0x1C
		[FixedBuffer(typeof(int), 7)]
		public <dataIndices>e__FixedBuffer dataIndices; //Field offset: 0x20
		[FixedBuffer(typeof(int), 7)]
		public <levels>e__FixedBuffer levels; //Field offset: 0x3C
		public Texture texture; //Field offset: 0x58
		public int lastUsed; //Field offset: 0x60
		public Vector4 hdrData; //Field offset: 0x64

	}

	private static class ShaderProperties
	{
		public static readonly int BoxMin; //Field offset: 0x0
		public static readonly int BoxMax; //Field offset: 0x4
		public static readonly int ProbePosition; //Field offset: 0x8
		public static readonly int MipScaleOffset; //Field offset: 0xC
		public static readonly int Count; //Field offset: 0x10
		public static readonly int Atlas; //Field offset: 0x14

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderProperties() { }

	}

	private const int k_MaxMipCount = 7; //Field offset: 0x0
	private const string k_ReflectionProbeAtlasName = "URP Reflection Probe Atlas"; //Field offset: 0x0
	private int2 m_Resolution; //Field offset: 0x0
	private RenderTexture m_AtlasTexture0; //Field offset: 0x8
	private RenderTexture m_AtlasTexture1; //Field offset: 0x10
	private RTHandle m_AtlasTexture0Handle; //Field offset: 0x18
	private BuddyAllocator m_AtlasAllocator; //Field offset: 0x20
	private Dictionary<Int32, CachedProbe> m_Cache; //Field offset: 0x48
	private Dictionary<Int32, Int32> m_WarningCache; //Field offset: 0x50
	private List<Int32> m_NeedsUpdate; //Field offset: 0x58
	private List<Int32> m_NeedsRemove; //Field offset: 0x60
	private Vector4[] m_BoxMax; //Field offset: 0x68
	private Vector4[] m_BoxMin; //Field offset: 0x70
	private Vector4[] m_ProbePosition; //Field offset: 0x78
	private Vector4[] m_MipScaleOffset; //Field offset: 0x80

	public RenderTexture atlasRT
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public RTHandle atlasRTHandle
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InitParams)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionProbeManager), Member = "Init", ReturnType = typeof(void))]
	public static ReflectionProbeManager Create() { }

	[CalledBy(Type = typeof(ForwardLights), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(BuddyAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RenderTexture get_atlasRT() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public RTHandle get_atlasRTHandle() { }

	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BuddyAllocator), Member = "get_levelCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(SpaceFillingCurves), Member = "DecodeMorton2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint2))]
	[ContainsUnimplementedInstructions]
	private float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip) { }

	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "Create", ReturnType = typeof(ReflectionProbeManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuddyAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(bool)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleReflectionProbes", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private void Init() { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionProbeManager), Member = "GetScaleOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(Texture), Member = "get_updateCount", ReturnType = typeof(uint))]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_hdrData", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(ReflectionProbe), Member = "get_refreshMode", ReturnType = typeof(ReflectionProbeRefreshMode))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CachedProbe)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphics), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(RenderTexture), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphics), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_blendDistance", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_isBoxProjection", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CachedProbe))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCubeToOctahedral2DQuadWithPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector2), typeof(Vector4), typeof(int), typeof(bool), typeof(int), typeof(System.Nullable`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BuddyAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BuddyAllocation&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingResults), Member = "get_visibleReflectionProbes", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleReflectionProbe>))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleReflectionProbes", ReturnType = typeof(int))]
	[Calls(Type = typeof(Time), Member = "get_renderedFrameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.KeyValuePair`2<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>), Member = "Deconstruct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(CachedProbe&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BuddyAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuddyAllocation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyValuePair`2), Member = "Deconstruct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey&", "TValue&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_texture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_reflectionProbe", ReturnType = typeof(ReflectionProbe))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CachedProbe&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BuddyAllocator), Member = "get_levelCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.Universal.ReflectionProbeManager+CachedProbe>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	public void UpdateGpuData(CommandBuffer cmd, ref CullingResults cullResults) { }

}

