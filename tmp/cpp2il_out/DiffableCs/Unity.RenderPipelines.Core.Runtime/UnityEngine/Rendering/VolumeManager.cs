namespace UnityEngine.Rendering;

public sealed class VolumeManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ValueTuple`2<String, Type>, String> <>9__16_0; //Field offset: 0x8
		public static Predicate<VolumeProfile> <>9__50_0; //Field offset: 0x10
		public static Predicate<Volume> <>9__73_0; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeManager), Member = ".ctor", ReturnType = typeof(void))]
		internal VolumeManager <.cctor>b__76_0() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal string <BuildVolumeComponentDisplayList>b__16_0(ValueTuple<String, Type> i) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <GetVolumes>b__73_0(Volume v) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <SetCustomDefaultProfiles>b__50_0(VolumeProfile x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass60_0
	{
		public List<VolumeComponent> componentsDefaultStateList; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_1
	{
		public VolumeComponent profileComponent; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass60_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <EvaluateVolumeDefaultState>b__1(VolumeComponent x) { }

	}

	private static readonly ProfilerMarker k_ProfilerMarkerUpdate; //Field offset: 0x0
	private static readonly ProfilerMarker k_ProfilerMarkerReplaceData; //Field offset: 0x8
	private static readonly ProfilerMarker k_ProfilerMarkerEvaluateVolumeDefaultState; //Field offset: 0x10
	private static readonly Lazy<VolumeManager> s_Instance; //Field offset: 0x18
	private static readonly Dictionary<Type, List`1<ValueTuple`2<String, Type>>> s_SupportedVolumeComponentsForRenderPipeline; //Field offset: 0x20
	[CompilerGenerated]
	private VolumeStack <stack>k__BackingField; //Field offset: 0x10
	private Type[] m_BaseComponentTypeArray; //Field offset: 0x18
	[CompilerGenerated]
	private VolumeProfile <globalDefaultProfile>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private VolumeProfile <qualityDefaultProfile>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ReadOnlyCollection<VolumeProfile> <customDefaultProfiles>k__BackingField; //Field offset: 0x30
	private readonly VolumeCollection m_VolumeCollection; //Field offset: 0x38
	private VolumeComponent[] m_ComponentsDefaultState; //Field offset: 0x40
	internal VolumeParameter[] m_ParametersDefaultState; //Field offset: 0x48
	private readonly List<Collider> m_TempColliders; //Field offset: 0x50
	private VolumeStack m_DefaultStack; //Field offset: 0x58
	private readonly List<VolumeStack> m_CreatedVolumeStacks; //Field offset: 0x60
	[CompilerGenerated]
	private bool <isInitialized>k__BackingField; //Field offset: 0x68

	public internal Type[] baseComponentTypeArray
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 101
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[Obsolete("Please use baseComponentTypeArray instead.")]
	public IEnumerable<Type> baseComponentTypes
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 101
	}

	public private ReadOnlyCollection<VolumeProfile> customDefaultProfiles
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private VolumeProfile globalDefaultProfile
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public static VolumeManager instance
	{
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 112
	}

	public private bool isInitialized
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private VolumeProfile qualityDefaultProfile
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public VolumeStack stack
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static VolumeManager() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__76_0", ReturnType = typeof(VolumeManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VolumeCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal VolumeManager() { }

	[CalledBy(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void <EvaluateVolumeDefaultState>g__ApplyDefaultProfile|60_0(VolumeProfile profile, ref <>c__DisplayClass60_0 unnamed_param_1) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "GetVolumeComponentsForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Type>>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Object>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.ValueTuple`2<System.Object, System.Object>>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Object>>))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private List<ValueTuple`2<String, Type>> BuildVolumeComponentDisplayList(Type[] types) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("UNITY_EDITOR")]
	public void CheckDefaultVolumeState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeStack), Member = "Reload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[Conditional("UNITY_EDITOR")]
	public void CheckStack(VolumeStack stack) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeCollection), Member = "get_count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckUpdateRequired(VolumeStack stack) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = "GetOrCreateVolumeStack", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VolumeManager), Member = "CreateStackInternal", ReturnType = typeof(VolumeStack))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public VolumeStack CreateStack() { }

	[CalledBy(Type = typeof(VolumeManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile), typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "InitializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile), typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "CreateStack", ReturnType = typeof(VolumeStack))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VolumeStack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeStack), Member = "Reload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private VolumeStack CreateStackInternal() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeStack), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void Deinitialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeStack), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DestroyStack(VolumeStack stack) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile), typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "InitializeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile), typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "SetGlobalDefaultProfile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "SetQualityDefaultProfile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "SetCustomDefaultProfiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.VolumeProfile>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "OnVolumeProfileChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "OnVolumeComponentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeComponent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "CheckDefaultVolumeState", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeComponent), Member = "get_parameters", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Rendering.VolumeParameter>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ScriptableObject))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(VolumeManager), Member = "<EvaluateVolumeDefaultState>g__ApplyDefaultProfile|60_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile), typeof(<>c__DisplayClass60_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 27)]
	private void EvaluateVolumeDefaultState() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Type[] get_baseComponentTypeArray() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public IEnumerable<Type> get_baseComponentTypes() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ReadOnlyCollection<VolumeProfile> get_customDefaultProfiles() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public VolumeProfile get_globalDefaultProfile() { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public static VolumeManager get_instance() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_isInitialized() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public VolumeProfile get_qualityDefaultProfile() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public VolumeStack get_stack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public VolumeComponent GetVolumeComponentDefaultState(Type volumeComponentType) { }

	[CalledBy(Type = typeof(WidgetFactory), Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel), typeof(System.Action`2<UnityEngine.Rendering.DebugUI+Field`1<System.Int32>, System.Int32>)}, ReturnType = typeof(EnumField))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "get_volumeComponentsPathAndType", ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Type>>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeManager), Member = "LoadBaseTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "BuildVolumeComponentDisplayList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Type>>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	internal List<ValueTuple`2<String, Type>> GetVolumeComponentsForDisplay(Type currentPipelineAssetType) { }

	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "GetVolumes", ReturnType = typeof(Volume[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VolumeCollection), Member = "GrabVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Volume>))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 2)]
	public Volume[] GetVolumes(LayerMask layerMask) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeCollection), Member = "GrabVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Volume>))]
	[CallsUnknownMethods(Count = 1)]
	private List<Volume> GrabVolumes(LayerMask mask) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipelineAssetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(VolumeManager), Member = "LoadBaseTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "CreateStackInternal", ReturnType = typeof(VolumeStack))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Initialize(VolumeProfile globalDefaultVolumeProfile = null, VolumeProfile qualityDefaultVolumeProfile = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "CreateStackInternal", ReturnType = typeof(VolumeStack))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void InitializeInternal(VolumeProfile globalDefaultVolumeProfile = null, VolumeProfile qualityDefaultVolumeProfile = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void InitializeVolumeComponents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeCollection), Member = "IsComponentActiveInMask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool IsComponentActiveInMask(LayerMask layerMask) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "LoadBaseTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	private bool IsSupportedByObsoleteVolumeComponentMenuForRenderPipeline(Type t, Type pipelineAssetType) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "GetVolumeComponentsForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Type>>))]
	[CalledBy(Type = typeof(VolumeManager), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile), typeof(VolumeProfile)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CoreUtils), Member = "GetAllTypesDerivedFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SupportedOnRenderPipelineAttribute), Member = "IsTypeSupportedOnRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeManager), Member = "IsSupportedByObsoleteVolumeComponentMenuForRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(PooledObject), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	internal void LoadBaseTypes(Type pipelineAssetType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void OnVolumeComponentChanged(VolumeComponent component) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	public void OnVolumeProfileChanged(VolumeProfile profile) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(VolumeComponent))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeCollection), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 19)]
	[Obsolete("Please use the Register without a given layer index #from(6000.0)", False)]
	public void Register(Volume volume, int layer) { }

	[CalledBy(Type = typeof(Volume), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(VolumeCollection), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void Register(Volume volume) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal void ReplaceData(VolumeStack stack) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ResetMainStack() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_baseComponentTypeArray(Type[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_customDefaultProfiles(ReadOnlyCollection<VolumeProfile> value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_globalDefaultProfile(VolumeProfile value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_isInitialized(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_qualityDefaultProfile(VolumeProfile value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_stack(VolumeStack value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetCustomDefaultProfiles(List<VolumeProfile> profiles) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetGlobalDefaultProfile(VolumeProfile profile) { }

	[CalledBy(Type = typeof(Volume), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Volume), Member = "UpdatePriority", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumeCollection), Member = "SetLayerIndexDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SetLayerDirty(int layer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeManager), Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetQualityDefaultProfile(VolumeProfile profile) { }

	[CalledBy(Type = typeof(Volume), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(VolumeCollection), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void Unregister(Volume volume) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeCollection), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 19)]
	[Obsolete("Please use the Register without a given layer index #from(6000.0)", False)]
	public void Unregister(Volume volume, int layer) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	public void Update(Transform trigger, LayerMask layerMask) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.CameraExtensions", Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumeManager), Member = "OverrideData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.VolumeComponent>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collider), Member = "ClosestPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Collider), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Volume), Member = "get_profileRef", ReturnType = typeof(VolumeProfile))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeCollection), Member = "GrabVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Volume>))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeManager), Member = "ReplaceData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeCollection), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask) { }

	[CalledBy(Type = typeof(Volume), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Volume), Member = "UpdateLayer", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumeCollection), Member = "ChangeLayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer) { }

}

