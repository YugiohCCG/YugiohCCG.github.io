namespace UnityEngine.Rendering;

public class DynamicResolutionHandler
{
	private struct ScalerContainer
	{
		public DynamicResScalePolicyType type; //Field offset: 0x0
		public PerformDynamicRes method; //Field offset: 0x8

	}

	internal enum UpsamplerScheduleType
	{
		BeforePost = 0,
		AfterDepthOfField = 1,
		AfterPost = 2,
	}

	private const int CameraDictionaryMaxcCapacity = 32; //Field offset: 0x0
	private static DynamicResScalerSlot s_ActiveScalerSlot; //Field offset: 0x0
	private static ScalerContainer[] s_ScalerContainers; //Field offset: 0x8
	private static Dictionary<Int32, DynamicResUpscaleFilter> s_CameraUpscaleFilters; //Field offset: 0x10
	private static Dictionary<Int32, DynamicResolutionHandler> s_CameraInstances; //Field offset: 0x18
	private static DynamicResolutionHandler s_DefaultInstance; //Field offset: 0x20
	private static int s_ActiveCameraId; //Field offset: 0x28
	private static DynamicResolutionHandler s_ActiveInstance; //Field offset: 0x30
	private static bool s_ActiveInstanceDirty; //Field offset: 0x38
	private static float s_GlobalHwFraction; //Field offset: 0x3C
	private static bool s_GlobalHwUpresActive; //Field offset: 0x40
	private bool m_Enabled; //Field offset: 0x10
	private bool m_UseMipBias; //Field offset: 0x11
	private float m_MinScreenFraction; //Field offset: 0x14
	private float m_MaxScreenFraction; //Field offset: 0x18
	private float m_CurrentFraction; //Field offset: 0x1C
	private bool m_ForcingRes; //Field offset: 0x20
	private bool m_CurrentCameraRequest; //Field offset: 0x21
	private float m_PrevFraction; //Field offset: 0x24
	private bool m_ForceSoftwareFallback; //Field offset: 0x28
	private bool m_RunUpscalerFilterOnFullResolution; //Field offset: 0x29
	private float m_PrevHWScaleWidth; //Field offset: 0x2C
	private float m_PrevHWScaleHeight; //Field offset: 0x30
	private Vector2Int m_LastScaledSize; //Field offset: 0x34
	private Vector2Int cachedOriginalSize; //Field offset: 0x3C
	[CompilerGenerated]
	private DynamicResUpscaleFilter <filter>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private Vector2Int <finalViewport>k__BackingField; //Field offset: 0x48
	private DynamicResolutionType type; //Field offset: 0x50
	private GlobalDynamicResolutionSettings m_CachedSettings; //Field offset: 0x58
	private WeakReference m_OwnerCameraWeakRef; //Field offset: 0xC8
	private UpsamplerScheduleType m_UpsamplerSchedule; //Field offset: 0xD0

	public private DynamicResUpscaleFilter filter
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public Vector2Int finalViewport
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public bool forcingResolution
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static DynamicResolutionHandler instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public bool runUpscalerFilterOnFullResolution
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public UpsamplerScheduleType upsamplerSchedule
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicResolutionHandler), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	private static DynamicResolutionHandler() { }

	[CalledBy(Type = typeof(DynamicResolutionHandler), Member = "GetOrCreateDrsInstanceHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DynamicResolutionHandler))]
	[CalledBy(Type = typeof(DynamicResolutionHandler), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private DynamicResolutionHandler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_widthScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_heightScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public Vector2Int ApplyScalesOnSize(Vector2Int size) { }

	[CalledBy(Type = typeof(RTHandleSystem), Member = "CalculateRatioAgainstMaxSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int&)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearSelectedCamera() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static float DefaultDynamicResMethod() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool DynamicResolutionEnabled() { }

	[CalledBy(Type = typeof(DynamicResolutionHandler), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalDynamicResolutionSettings), typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScalableBufferManager), Member = "ResizeBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private bool FlushScalableBufferManagerState() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ForceSoftwareFallback() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DynamicResUpscaleFilter get_filter() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2Int get_finalViewport() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_forcingResolution() { }

	[CallerCount(Count = 0)]
	public static DynamicResolutionHandler get_instance() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_runUpscalerFilterOnFullResolution() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UpsamplerScheduleType get_upsamplerSchedule() { }

	[CallerCount(Count = 0)]
	public float GetCurrentScale() { }

	[CallerCount(Count = 0)]
	public Vector2Int GetLastScaledSize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	public float GetLowResMultiplier(float targetLowRes, float minimumThreshold) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	public float GetLowResMultiplier(float targetLowRes) { }

	[CalledBy(Type = typeof(DynamicResolutionHandler), Member = "UpdateAndUseCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Nullable`1<UnityEngine.Rendering.GlobalDynamicResolutionSettings>), typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicResolutionHandler), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_widthScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_heightScaleFactor", ReturnType = typeof(float))]
	public Vector2 GetResolvedScale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_widthScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_heightScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public Vector2Int GetScaledSize(Vector2Int size) { }

	[CalledBy(Type = typeof(RTHandleSystem), Member = "SetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTHandleSystem), Member = "CalculateRatioAgainstMaxSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int&)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool HardwareDynamicResIsEnabled() { }

	[CalledBy(Type = typeof(DynamicResolutionHandler), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalDynamicResolutionSettings), typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ProcessSettings(GlobalDynamicResolutionSettings settings) { }

	[CalledBy(Type = typeof(RTHandleSystem), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool RequestsHardwareDynamicResolution() { }

	[CallerCount(Count = 0)]
	private void Reset() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_filter(DynamicResUpscaleFilter value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_finalViewport(Vector2Int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_runUpscalerFilterOnFullResolution(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_upsamplerSchedule(UpsamplerScheduleType value) { }

	[CallerCount(Count = 0)]
	public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetCurrentCameraRequest(bool cameraRequest) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.ByteEnum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ByteEnum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.ByteEnum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ByteEnum"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool SoftwareDynamicResIsEnabled() { }

	[CalledBy(Type = typeof(DynamicResolutionHandler), Member = "UpdateAndUseCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Nullable`1<UnityEngine.Rendering.GlobalDynamicResolutionSettings>), typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicResolutionHandler), Member = "ProcessSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalDynamicResolutionSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicResolutionHandler), Member = "FlushScalableBufferManagerState", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_widthScaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScalableBufferManager), Member = "get_heightScaleFactor", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicResolutionHandler), Member = "GetOrCreateDrsInstanceHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DynamicResolutionHandler))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Rendering.GlobalDynamicResolutionSettings>), Member = "get_Value", ReturnType = typeof(GlobalDynamicResolutionSettings))]
	[Calls(Type = typeof(DynamicResolutionHandler), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalDynamicResolutionSettings), typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static void UpdateAndUseCamera(Camera camera, Nullable<GlobalDynamicResolutionSettings> settings = null, Action OnResolutionChange = null) { }

}

