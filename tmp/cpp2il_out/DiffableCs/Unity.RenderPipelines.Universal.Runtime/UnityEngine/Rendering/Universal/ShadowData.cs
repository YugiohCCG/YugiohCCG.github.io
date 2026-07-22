namespace UnityEngine.Rendering.Universal;

public struct ShadowData
{
	private ContextContainer frameData; //Field offset: 0x0

	internal bool additionalLightShadowsEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	public int additionalLightsShadowmapHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public int additionalLightsShadowmapWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public List<Vector4>& bias
	{
		[CalledBy(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(ShadowData&), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	internal bool isKeywordAdditionalLightShadowsEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	internal bool isKeywordSoftShadowsEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	internal int mainLightRenderTargetHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	internal int mainLightRenderTargetWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	public float mainLightShadowCascadeBorder
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public int mainLightShadowCascadesCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public Vector3 mainLightShadowCascadesSplit
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public int mainLightShadowmapHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public int mainLightShadowmapWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	internal int mainLightShadowResolution
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	internal bool mainLightShadowsEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	public List<Int32>& resolution
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	internal AdditionalLightsShadowAtlasLayout shadowAtlasLayout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	public int shadowmapDepthBufferBits
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public bool supportsAdditionalLightShadows
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public bool supportsMainLightShadows
	{
		[CalledBy(Type = typeof(ScreenSpaceShadows), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	public bool supportsSoftShadows
	{
		[CalledBy(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(ShadowData&), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 77
	}

	internal UniversalShadowData universalShadowData
	{
		[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), typeof(ShadowSliceData&), typeof(Matrix4x4&), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), typeof(ShadowSliceData&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractSpotLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractPointLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(CubemapFace), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 67
	}

	internal NativeArray<URPLightShadowCullingInfos>& visibleLightsShadowCullingInfos
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 77
	}

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ShadowData(ContextContainer frameData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_additionalLightShadowsEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public int get_additionalLightsShadowmapHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public int get_additionalLightsShadowmapWidth() { }

	[CalledBy(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(ShadowData&), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public List<Vector4>& get_bias() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_isKeywordAdditionalLightShadowsEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_isKeywordSoftShadowsEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal int get_mainLightRenderTargetHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal int get_mainLightRenderTargetWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public float get_mainLightShadowCascadeBorder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public int get_mainLightShadowCascadesCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public Vector3 get_mainLightShadowCascadesSplit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public int get_mainLightShadowmapHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public int get_mainLightShadowmapWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal int get_mainLightShadowResolution() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_mainLightShadowsEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public List<Int32>& get_resolution() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal AdditionalLightsShadowAtlasLayout get_shadowAtlasLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public int get_shadowmapDepthBufferBits() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public bool get_supportsAdditionalLightShadows() { }

	[CalledBy(Type = typeof(ScreenSpaceShadows), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public bool get_supportsMainLightShadows() { }

	[CalledBy(Type = typeof(ShadowUtils), Member = "GetShadowBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisibleLight&), typeof(int), typeof(ShadowData&), typeof(Matrix4x4), typeof(float)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public bool get_supportsSoftShadows() { }

	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), typeof(ShadowSliceData&), typeof(Matrix4x4&), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractDirectionalLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(Vector4&), typeof(ShadowSliceData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractSpotLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ExtractPointLightMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(ShadowData&), typeof(int), typeof(CubemapFace), typeof(float), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(ShadowSplitData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal UniversalShadowData get_universalShadowData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal NativeArray<URPLightShadowCullingInfos>& get_visibleLightsShadowCullingInfos() { }

}

