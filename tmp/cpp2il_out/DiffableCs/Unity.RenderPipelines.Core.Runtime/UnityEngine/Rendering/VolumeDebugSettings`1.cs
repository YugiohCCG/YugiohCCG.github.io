namespace UnityEngine.Rendering;

public abstract class VolumeDebugSettings : IVolumeDebugSettings
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<Volume, Boolean> <>9__34_0; //Field offset: 0x0
		public static Func<FieldInfo, Boolean> <>9__36_0; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__43_0; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__43_1; //Field offset: 0x0
		public static Func<Type, String> <>9__43_2; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <get_componentTypes>b__43_0(Type t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <get_componentTypes>b__43_1(Type t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeDebugSettings`1), Member = "ComponentDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <get_componentTypes>b__43_2(Type t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetStates>b__36_0(FieldInfo t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Volume), Member = "get_profileRef", ReturnType = typeof(VolumeProfile))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetVolumes>b__34_0(Volume v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Type value; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass22_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <set_selectedComponentType>b__0(ValueTuple<String, Type> t) { }

	}

	private static List<Type> s_ComponentTypes; //Field offset: 0x0
	[CompilerGenerated]
	private static List<T> <additionalCameraDatas>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <selectedComponent>k__BackingField; //Field offset: 0x0
	protected int m_SelectedCameraIndex; //Field offset: 0x0
	private Camera[] m_CamerasArray; //Field offset: 0x0
	private List<Camera> m_Cameras; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Type <targetRenderPipeline>k__BackingField; //Field offset: 0x0
	private Single[] weights; //Field offset: 0x0
	private Volume[] volumes; //Field offset: 0x0
	private VolumeParameter[2] savedStates; //Field offset: 0x0

	[Obsolete("Cameras are auto registered/unregistered, use property cameras", False)]
	protected private static List<T> additionalCameraDatas
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 161
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 229
	}

	public override IEnumerable<Camera> cameras
	{
		[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCamera", ReturnType = typeof(Camera))]
		[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCameraIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "set_selectedCameraIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Camera), Member = "GetAllCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera[])}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
		[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 546
	}

	[Obsolete("Please use volumeComponentsPathAndType instead, and get the second element of the tuple", False)]
	public static List<Type> componentTypes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 58)]
		[DeduplicatedMethod]
		 get { } //Length: 2143
	}

	public override Camera selectedCamera
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineVolumeDebugSettings", Member = "get_selectedCameraVolumeStack", ReturnType = typeof(VolumeStack))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineVolumeDebugSettings", Member = "get_selectedCameraLayerMask", ReturnType = typeof(LayerMask))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineVolumeDebugSettings", Member = "get_selectedCameraPosition", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_cameras", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Camera>))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 170
	}

	public override int selectedCameraIndex
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_cameras", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Camera>))]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 166
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_cameras", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Camera>))]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 159
	}

	public abstract LayerMask selectedCameraLayerMask
	{
		 get { } //Length: 0
	}

	public abstract Vector3 selectedCameraPosition
	{
		 get { } //Length: 0
	}

	public abstract VolumeStack selectedCameraVolumeStack
	{
		 get { } //Length: 0
	}

	public override int selectedComponent
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override Type selectedComponentType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 139
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 276
	}

	[Obsolete("This property is obsolete and kept only for not breaking user code. VolumeDebugSettings will use current pipeline when it needs to gather volume component types and paths. #from(23.2)", False)]
	public override Type targetRenderPipeline
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public List<ValueTuple`2<String, Type>> volumeComponentsPathAndType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
		[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipelineAssetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(VolumeManager), Member = "GetVolumeComponentsForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Type>>))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 134
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private static VolumeDebugSettings`1() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineVolumeDebugSettings", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected VolumeDebugSettings`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool ChangedStates(VolumeParameter[2] newStates) { }

	[CalledBy(Type = typeof(<>c), Member = "<get_componentTypes>b__43_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete("Please use componentPathAndType instead, and get the first element of the tuple", False)]
	public static string ComponentDisplayName(Type component) { }

	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "RefreshVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "GetVolumeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "VolumeHasInfluence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Volume), Member = "HasInstantiatedProfile", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Volume), Member = "get_profile", ReturnType = typeof(VolumeProfile))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeProfile), Member = "TryGet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Collider), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Collider), Member = "ClosestPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private float ComputeWeight(Volume volume, Vector3 triggerPos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected static List<T> get_additionalCameraDatas() { }

	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCamera", ReturnType = typeof(Camera))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCameraIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "set_selectedCameraIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "GetAllCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override IEnumerable<Camera> get_cameras() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 58)]
	[DeduplicatedMethod]
	public static List<Type> get_componentTypes() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineVolumeDebugSettings", Member = "get_selectedCameraVolumeStack", ReturnType = typeof(VolumeStack))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineVolumeDebugSettings", Member = "get_selectedCameraLayerMask", ReturnType = typeof(LayerMask))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineVolumeDebugSettings", Member = "get_selectedCameraPosition", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_cameras", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Camera>))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override Camera get_selectedCamera() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_cameras", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Camera>))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int get_selectedCameraIndex() { }

	public abstract LayerMask get_selectedCameraLayerMask() { }

	public abstract Vector3 get_selectedCameraPosition() { }

	public abstract VolumeStack get_selectedCameraVolumeStack() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override int get_selectedComponent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override Type get_selectedComponentType() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override Type get_targetRenderPipeline() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipelineAssetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(VolumeManager), Member = "GetVolumeComponentsForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Type>>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public List<ValueTuple`2<String, Type>> get_volumeComponentsPathAndType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(VolumeComponent))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal VolumeParameter GetParameter(FieldInfo field) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal VolumeParameter GetParameter(VolumeComponent component, FieldInfo field) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Volume), Member = "HasInstantiatedProfile", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Volume), Member = "get_profile", ReturnType = typeof(VolumeProfile))]
	[Calls(Type = typeof(VolumeProfile), Member = "TryGet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "T&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal VolumeParameter GetParameter(Volume volume, FieldInfo field) { }

	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "RefreshVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Volume), Member = "HasInstantiatedProfile", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Volume), Member = "get_profile", ReturnType = typeof(VolumeProfile))]
	[Calls(Type = typeof(VolumeProfile), Member = "TryGet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "T&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	private VolumeParameter[2] GetStates() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeManager), Member = "GetVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(Volume[]))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public override Volume[] GetVolumes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(Vector3)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override float GetVolumeWeight(Volume volume) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "GetStates", ReturnType = typeof(VolumeParameter[2]))]
	[Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(Vector3)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool RefreshVolumes(Volume[] newVolumes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	[Obsolete("Cameras are auto registered/unregistered", False)]
	public static void RegisterCamera(T additionalCamera) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private static void set_additionalCameraDatas(List<T> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_cameras", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Camera>))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_selectedCameraIndex(int value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_selectedComponent(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override void set_selectedComponentType(Type value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[Obsolete("Cameras are auto registered/unregistered", False)]
	public static void UnRegisterCamera(T additionalCamera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(Vector3)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool VolumeHasInfluence(Volume volume) { }

}

