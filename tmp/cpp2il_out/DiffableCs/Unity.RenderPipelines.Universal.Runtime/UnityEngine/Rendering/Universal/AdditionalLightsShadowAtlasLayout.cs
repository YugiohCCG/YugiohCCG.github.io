namespace UnityEngine.Rendering.Universal;

internal struct AdditionalLightsShadowAtlasLayout
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ShadowResolutionRequest, ShadowResolutionRequest, Int32> <>9__24_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal int <CreateCompareShadowResolutionRequesPredicate>b__24_0(ShadowResolutionRequest curr, ShadowResolutionRequest other) { }

	}

	public struct ShadowResolutionRequest
	{
		[Flags]
		private enum SettingsOptions
		{
			None = 0,
			SoftShadow = 1,
			PointLightShadow = 2,
			All = 65535,
		}

		public ushort visibleLightIndex; //Field offset: 0x0
		public ushort perLightShadowSliceIndex; //Field offset: 0x2
		public ushort requestedResolution; //Field offset: 0x4
		public ushort offsetX; //Field offset: 0x6
		public ushort offsetY; //Field offset: 0x8
		public ushort allocatedResolution; //Field offset: 0xA
		private SettingsOptions m_ShadowProperties; //Field offset: 0xC

		public bool pointLightShadow
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
			[CallerCount(Count = 0)]
			 set { } //Length: 36
		}

		public bool softShadow
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			 set { } //Length: 36
		}

		[CallerCount(Count = 0)]
		public bool get_pointLightShadow() { }

		[CallerCount(Count = 0)]
		public bool get_softShadow() { }

		[CallerCount(Count = 0)]
		public void set_pointLightShadow(bool value) { }

		[CallerCount(Count = 0)]
		public void set_softShadow(bool value) { }

	}

	private static List<RectInt> s_UnusedAtlasSquareAreas; //Field offset: 0x0
	private static List<ShadowResolutionRequest> s_ShadowResolutionRequests; //Field offset: 0x8
	private static Single[] s_VisibleLightIndexToCameraSquareDistance; //Field offset: 0x10
	private static Func<ShadowResolutionRequest, ShadowResolutionRequest, Int32> s_CompareShadowResolutionRequest; //Field offset: 0x18
	private static ShadowResolutionRequest[] s_SortedShadowResolutionRequests; //Field offset: 0x20
	private NativeArray<ShadowResolutionRequest> m_SortedShadowResolutionRequests; //Field offset: 0x0
	private NativeArray<Int32> m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex; //Field offset: 0x10
	private int m_TotalShadowSlicesCount; //Field offset: 0x20
	private int m_TotalShadowResolutionRequestCount; //Field offset: 0x24
	private bool m_TooManyShadowMaps; //Field offset: 0x28
	private int m_ShadowSlicesScaleFactor; //Field offset: 0x2C
	private int m_AtlasSize; //Field offset: 0x30

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "BuildAdditionalLightsShadowAtlasLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(UniversalShadowData), typeof(UniversalCameraData)}, ReturnType = typeof(AdditionalLightsShadowAtlasLayout))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout+ShadowResolutionRequest>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ShadowResolutionRequest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArrayExtensions), Member = "UnsafeElementAtMutable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowResolutionRequest)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout+ShadowResolutionRequest>), typeof(int)}, ReturnType = typeof(ShadowResolutionRequest&))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShadowUtils), Member = "MinimalPunctualLightShadowResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout+ShadowResolutionRequest>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowResolutionRequest[]), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sorting), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowResolutionRequest)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowResolutionRequest[]), typeof(int), typeof(int), typeof(System.Func`3<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout+ShadowResolutionRequest, UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout+ShadowResolutionRequest, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout+ShadowResolutionRequest>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ShadowResolutionRequest))]
	[Calls(Type = typeof(ShadowUtils), Member = "GetPunctualLightShadowSlicesCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ShadowUtils), Member = "IsValidShadowCastingLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalLightData), typeof(int), typeof(LightType), typeof(LightShadows), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_shadowStrength", ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "get_shadows", ReturnType = typeof(LightShadows))]
	[Calls(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Universal.AdditionalLightsShadowAtlasLayout+ShadowResolutionRequest>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowResolutionRequest)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public AdditionalLightsShadowAtlasLayout(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void ClearStaticCaches() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Func<ShadowResolutionRequest, ShadowResolutionRequest, Int32> CreateCompareShadowResolutionRequesPredicate() { }

	[CallerCount(Count = 0)]
	private static int EstimateScaleFactorNeededToFitAllShadowsInAtlas(in NativeArray<ShadowResolutionRequest>& shadowResolutionRequests, int endIndex, int atlasSize) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int GetAtlasSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetShadowSlicesScaleFactor() { }

	[CalledBy(Type = typeof(ShadowCulling), Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), typeof(NativeArray`1<URPLightShadowCullingInfos>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	public ShadowResolutionRequest GetSliceShadowResolutionRequest(int originalVisibleLightIndex, int sliceIndex) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	public ShadowResolutionRequest GetSortedShadowResolutionRequest(int sortedShadowResolutionRequestIndex) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int GetTotalShadowResolutionRequestCount() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int GetTotalShadowSlicesCount() { }

	[CalledBy(Type = typeof(ShadowCulling), Member = "ComputeShadowCasterCullingInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalShadowData), typeof(AdditionalLightsShadowAtlasLayout&), typeof(CullingResults&), typeof(ShadowCastersCullingInfos&), typeof(NativeArray`1<URPLightShadowCullingInfos>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool HasSpaceForLight(int originalVisibleLightIndex) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasTooManyShadowMaps() { }

}

