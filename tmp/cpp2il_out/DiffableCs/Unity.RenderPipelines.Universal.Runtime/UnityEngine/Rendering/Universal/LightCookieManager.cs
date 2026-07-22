namespace UnityEngine.Rendering.Universal;

internal class LightCookieManager : IDisposable
{
	private struct LightCookieMapping
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Light), Member = "get_cookie", ReturnType = typeof(Texture))]
			[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 1)]
			internal int <.cctor>b__6_0(LightCookieMapping a, LightCookieMapping b) { }

			[CallerCount(Count = 0)]
			internal int <.cctor>b__6_1(LightCookieMapping a, LightCookieMapping b) { }

		}

		public static Func<LightCookieMapping, LightCookieMapping, Int32> s_CompareByCookieSize; //Field offset: 0x0
		public static Func<LightCookieMapping, LightCookieMapping, Int32> s_CompareByBufferIndex; //Field offset: 0x8
		public ushort visibleLightIndex; //Field offset: 0x0
		public ushort lightBufferIndex; //Field offset: 0x2
		public Light light; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private static LightCookieMapping() { }

	}

	private class LightCookieShaderData : IDisposable
	{
		private int m_Size; //Field offset: 0x10
		private bool m_UseStructuredBuffer; //Field offset: 0x14
		private Matrix4x4[] m_WorldToLightCpuData; //Field offset: 0x18
		private Vector4[] m_AtlasUVRectCpuData; //Field offset: 0x20
		private Single[] m_LightTypeCpuData; //Field offset: 0x28
		private ShaderBitArray m_CookieEnableBitsCpuData; //Field offset: 0x30
		private ComputeBuffer m_WorldToLightBuffer; //Field offset: 0x38
		private ComputeBuffer m_AtlasUVRectBuffer; //Field offset: 0x40
		private ComputeBuffer m_LightTypeBuffer; //Field offset: 0x48
		[CompilerGenerated]
		private bool <isUploaded>k__BackingField; //Field offset: 0x50

		public Vector4[] atlasUVRects
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public ShaderBitArray cookieEnableBits
		{
			[CallerCount(Count = 62)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public bool isUploaded
		{
			[CallerCount(Count = 8)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public Single[] lightTypes
		{
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public Matrix4x4[] worldToLights
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LightCookieShaderData), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		public LightCookieShaderData(int size, bool useStructuredBuffer) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ShaderBitArray), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Clear(CommandBuffer cmd) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		public override void Dispose() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public Vector4[] get_atlasUVRects() { }

		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		public ShaderBitArray get_cookieEnableBits() { }

		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public bool get_isUploaded() { }

		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		public Single[] get_lightTypes() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public Matrix4x4[] get_worldToLights() { }

		[CalledBy(Type = typeof(LightCookieShaderData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCookieManager), Member = "InitAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCookieManager), Member = "SetupAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(LightCookieManager), Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData), typeof(WorkSlice`1<LightCookieMapping>&), typeof(WorkSlice`1<Vector4>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ShaderBitArray), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		public void Resize(int size) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_isUploaded(bool value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public void Upload(CommandBuffer cmd) { }

	}

	private enum LightCookieShaderFormat
	{
		None = -1,
		RGB = 0,
		Alpha = 1,
		Red = 2,
	}

	internal struct Settings
	{
		internal struct AtlasSettings
		{
			public Vector2Int resolution; //Field offset: 0x0
			public GraphicsFormat format; //Field offset: 0x8

			public bool isPow2
			{
				[CallerCount(Count = 0)]
				[ContainsUnimplementedInstructions]
				 get { } //Length: 26
			}

			public bool isSquare
			{
				[CallerCount(Count = 0)]
				[ContainsUnimplementedInstructions]
				 get { } //Length: 11
			}

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			public bool get_isPow2() { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			public bool get_isSquare() { }

		}

		public AtlasSettings atlas; //Field offset: 0x0
		public int maxAdditionalLights; //Field offset: 0xC
		public float cubeOctahedralSizeScale; //Field offset: 0x10
		public bool useStructuredBuffer; //Field offset: 0x14

		[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InitParams), Member = "Create", ReturnType = typeof(InitParams))]
		[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		public static Settings Create() { }

	}

	private static class ShaderProperty
	{
		public static readonly int mainLightTexture; //Field offset: 0x0
		public static readonly int mainLightWorldToLight; //Field offset: 0x4
		public static readonly int mainLightCookieTextureFormat; //Field offset: 0x8
		public static readonly int additionalLightsCookieAtlasTexture; //Field offset: 0xC
		public static readonly int additionalLightsCookieAtlasTextureFormat; //Field offset: 0x10
		public static readonly int additionalLightsCookieEnableBits; //Field offset: 0x14
		public static readonly int additionalLightsCookieAtlasUVRectBuffer; //Field offset: 0x18
		public static readonly int additionalLightsCookieAtlasUVRects; //Field offset: 0x1C
		public static readonly int additionalLightsWorldToLightBuffer; //Field offset: 0x20
		public static readonly int additionalLightsLightTypeBuffer; //Field offset: 0x24
		public static readonly int additionalLightsWorldToLights; //Field offset: 0x28
		public static readonly int additionalLightsLightTypes; //Field offset: 0x2C

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderProperty() { }

	}

	private class WorkMemory
	{
		public LightCookieMapping[] lightMappings; //Field offset: 0x10
		public Vector4[] uvRects; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public WorkMemory() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public void Resize(int size) { }

	}

	[DefaultMember("Item")]
	[IsReadOnly]
	private struct WorkSlice
	{
		private readonly T[] m_Data; //Field offset: 0x0
		private readonly int m_Start; //Field offset: 0x0
		private readonly int m_Length; //Field offset: 0x0

		public int capacity
		{
			[CallerCount(Count = 24)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 25
		}

		public T Item
		{
			[CalledBy(Type = typeof(LightCookieManager), Member = "UpdateAdditionalLightsAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[])}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(LightCookieManager), Member = "FetchUVRects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(LightCookieManager), Member = "ComputeCookieRequestPixelCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkSlice`1<LightCookieMapping>&)}, ReturnType = typeof(uint))]
			[CalledBy(Type = typeof(LightCookieManager), Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData), typeof(WorkSlice`1<LightCookieMapping>&), typeof(WorkSlice`1<Vector4>&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 6)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 61
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 set { } //Length: 58
		}

		public int length
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CalledBy(Type = typeof(LightCookieManager), Member = "SetupAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public WorkSlice`1(T[] src, int srcLen = -1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public WorkSlice`1(T[] src, int srcStart, int srcLen = -1) { }

		[CallerCount(Count = 24)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public int get_capacity() { }

		[CalledBy(Type = typeof(LightCookieManager), Member = "UpdateAdditionalLightsAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(LightCookieManager), Member = "FetchUVRects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(LightCookieManager), Member = "ComputeCookieRequestPixelCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkSlice`1<LightCookieMapping>&)}, ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(LightCookieManager), Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData), typeof(WorkSlice`1<LightCookieMapping>&), typeof(WorkSlice`1<Vector4>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public T get_Item(int index) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public int get_length() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public void set_Item(int index, T value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sorting), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Func`3<T, T, Int32>"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Sort(Func<T, T, Int32> compare) { }

	}

	private static readonly Matrix4x4 s_DirLightProj; //Field offset: 0x0
	private const int k_MaxCookieSizeDivisor = 16; //Field offset: 0x0
	private Texture2DAtlas m_AdditionalLightsCookieAtlas; //Field offset: 0x10
	private LightCookieShaderData m_AdditionalLightsCookieShaderData; //Field offset: 0x18
	private readonly Settings m_Settings; //Field offset: 0x20
	private WorkMemory m_WorkMem; //Field offset: 0x38
	private Int32[] m_VisibleLightIndexToShaderDataIndex; //Field offset: 0x40
	private int m_CookieSizeDivisor; //Field offset: 0x48
	private uint m_PrevCookieRequestPixelCount; //Field offset: 0x4C
	private int m_PrevWarnFrame; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsKeywordLightCookieEnabled>k__BackingField; //Field offset: 0x54

	internal RTHandle AdditionalLightsCookieAtlasTexture
	{
		[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		internal get { } //Length: 15
	}

	internal bool IsKeywordLightCookieEnabled
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "Ortho", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Matrix4x4))]
	private static LightCookieManager() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InitParams), Member = "Create", ReturnType = typeof(InitParams))]
	[CalledBy(Type = typeof(ForwardLights), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public LightCookieManager(ref Settings settings) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "Fetch2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(int)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(LightCookieManager), Member = "FetchCube", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(int)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void AdjustUVRect(ref Vector4 uvScaleOffset, Texture cookie, ref Vector2 cookieSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private int ApproximateCookieSizeDivisor(float requestAtlasRatio) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorkSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Light), Member = "get_cookie", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private uint ComputeCookieRequestPixelCount(ref WorkSlice<LightCookieMapping>& validLightMappings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int ComputeOctahedralCookieSize(Texture cookie) { }

	[CalledBy(Type = typeof(ForwardLights), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2DAtlas), Member = "Release", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "FetchUVRects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2DAtlas), Member = "IsCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Texture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LightCookieManager), Member = "AdjustUVRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Texture), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Vector4 Fetch2D(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "FetchUVRects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "IsCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Texture)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LightCookieManager), Member = "AdjustUVRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4&), typeof(Texture), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private Vector4 FetchCube(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "UpdateAdditionalLightsAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WorkSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Light), Member = "get_cookie", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(LightCookieManager), Member = "Fetch2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(LightCookieManager), Member = "FetchCube", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private int FetchUVRects(CommandBuffer cmd, ref WorkSlice<LightCookieMapping>& validLightMappings, Vector4[] textureAtlasUVRects, int cookieSizeDivisor) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "SetupAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Light), Member = "get_cookie", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private int FilterAndValidateAdditionalLights(UniversalLightData lightData, LightCookieMapping[] validLightMappings) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	internal RTHandle get_AdditionalLightsCookieAtlasTexture() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_IsKeywordLightCookieEnabled() { }

	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilDirectionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "SetLightCookiesKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(int), typeof(bool), typeof(bool), typeof(Boolean&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public int GetLightCookieShaderDataIndex(int visibleLightIndex) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightCookieManager), Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData), typeof(WorkSlice`1<LightCookieMapping>&), typeof(WorkSlice`1<Vector4>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	private LightCookieShaderFormat GetLightCookieShaderFormat(GraphicsFormat cookieFormat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(half), Member = "get_MinValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void GetLightUVScaleOffset(ref UniversalAdditionalLightData additionalLightData, ref Matrix4x4 uvTransform) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2DAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(FilterMode), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieShaderData), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void InitAdditionalLights(int size) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool isInitialized() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsKeywordLightCookieEnabled(bool value) { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightCookieManager), Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LightCookieManager), Member = "SetupAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderBitArray), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void Setup(CommandBuffer cmd, UniversalLightData lightData) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LightCookieManager), Member = "FilterAndValidateAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(LightCookieMapping[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture2DAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(FilterMode), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieShaderData), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.Universal.LightCookieManager+WorkSlice`1<UnityEngine.Rendering.Universal.LightCookieManager+LightCookieMapping>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightCookieMapping[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieManager), Member = "UpdateAdditionalLightsAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(WorkSlice`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieManager), Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData), typeof(WorkSlice`1<LightCookieMapping>&), typeof(WorkSlice`1<Vector4>&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private bool SetupAdditionalLights(CommandBuffer cmd, UniversalLightData lightData) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(half), Member = "get_MinValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LightCookieManager), Member = "GetLightCookieShaderFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(LightCookieShaderFormat))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_cookie", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool SetupMainLight(CommandBuffer cmd, ref VisibleLight visibleMainLight) { }

	[CallerCount(Count = 0)]
	private void ShrinkUVRect(ref Vector4 uvScaleOffset, float amountPixels, ref Vector2 cookieSize) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "SetupAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.Universal.LightCookieManager+WorkSlice`1<UnityEngine.Rendering.Universal.LightCookieManager+LightCookieMapping>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<UnityEngine.Rendering.Universal.LightCookieManager+LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager+LightCookieMapping, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WorkSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Light), Member = "get_cookie", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture2DAtlas), Member = "ResetAllocator", ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieManager), Member = "FetchUVRects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(WorkSlice`1<LightCookieMapping>&), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private int UpdateAdditionalLightsAtlas(CommandBuffer cmd, ref WorkSlice<LightCookieMapping>& validLightMappings, Vector4[] textureAtlasUVRects) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "SetupAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShaderBitArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Perspective", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisibleLight), Member = "get_range", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_spotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(half), Member = "get_MinValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(WorkSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ShaderBitArray), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieShaderData), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCookieManager), Member = "GetLightCookieShaderFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(LightCookieShaderFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void UploadAdditionalLights(CommandBuffer cmd, UniversalLightData lightData, ref WorkSlice<LightCookieMapping>& validLightMappings, ref WorkSlice<Vector4>& validUvRects) { }

}

