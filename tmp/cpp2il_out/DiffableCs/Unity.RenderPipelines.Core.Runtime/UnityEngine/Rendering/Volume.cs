namespace UnityEngine.Rendering;

[AddComponentMenu("Miscellaneous/Volume")]
[ExecuteAlways]
public class Volume : MonoBehaviour, IVolume
{
	[FormerlySerializedAs("isGlobal")]
	[SerializeField]
	private bool m_IsGlobal; //Field offset: 0x20
	[Delayed]
	public float priority; //Field offset: 0x24
	public float blendDistance; //Field offset: 0x28
	[Range(0, 1)]
	public float weight; //Field offset: 0x2C
	public VolumeProfile sharedProfile; //Field offset: 0x30
	internal List<Collider> m_Colliders; //Field offset: 0x38
	private int m_PreviousLayer; //Field offset: 0x40
	private float m_PreviousPriority; //Field offset: 0x44
	private VolumeProfile m_InternalProfile; //Field offset: 0x48

	public override List<Collider> colliders
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override bool isGlobal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public VolumeProfile profile
	{
		[CalledBy(Type = typeof(WidgetFactory), Member = "GetResolutionChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>))]
		[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "GetParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(FieldInfo)}, ReturnType = typeof(VolumeParameter))]
		[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(Vector3)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "GetStates", ReturnType = typeof(VolumeParameter[2]))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 700
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	internal VolumeProfile profileRef
	{
		[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1+<>c", Member = "<GetVolumes>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VolumeCollection), Member = "IsComponentActiveInMask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal get { } //Length: 113
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Volume() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public override List<Collider> get_colliders() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_isGlobal() { }

	[CalledBy(Type = typeof(WidgetFactory), Member = "GetResolutionChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "GetParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(FieldInfo)}, ReturnType = typeof(VolumeParameter))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "GetStates", ReturnType = typeof(VolumeParameter[2]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public VolumeProfile get_profile() { }

	[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1+<>c", Member = "<GetVolumes>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeCollection), Member = "IsComponentActiveInMask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	internal VolumeProfile get_profileRef() { }

	[CalledBy(Type = typeof(WidgetFactory), Member = "GetResolutionChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "GetParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(FieldInfo)}, ReturnType = typeof(VolumeParameter))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VolumeDebugSettings`1), Member = "GetStates", ReturnType = typeof(VolumeParameter[2]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool HasInstantiatedProfile() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeManager), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	private void OnValidate() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public override void set_isGlobal(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_profile(VolumeProfile value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeManager), Member = "UpdateVolumeLayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "SetLayerDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Update() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeManager), Member = "UpdateVolumeLayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateLayer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(VolumeManager), Member = "SetLayerDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdatePriority() { }

}

