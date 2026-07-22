namespace UnityEngine.Rendering;

internal class VolumeCollection
{
	internal const int k_MaxLayerCount = 32; //Field offset: 0x0
	private readonly Dictionary<Int32, List`1<Volume>> m_SortedVolumes; //Field offset: 0x10
	private readonly List<Volume> m_Volumes; //Field offset: 0x18
	private readonly Dictionary<Int32, Boolean> m_SortNeeded; //Field offset: 0x20

	public int count
	{
		[CalledBy(Type = typeof(VolumeManager), Member = "CheckUpdateRequired", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 60
	}

	[CalledBy(Type = typeof(VolumeManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public VolumeCollection() { }

	[CalledBy(Type = typeof(VolumeManager), Member = "UpdateVolumeLayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeCollection), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeCollection), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public bool ChangeLayer(Volume volume, int previousLayerIndex, int currentLayerIndex) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "CheckUpdateRequired", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public int get_count() { }

	[CalledBy(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "GetVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(Volume[]))]
	[CalledBy(Type = typeof(VolumeManager), Member = "GrabVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.Volume>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Boolean>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public List<Volume> GrabVolumes(LayerMask mask) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "IsComponentActiveInMask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Volume), Member = "get_profileRef", ReturnType = typeof(VolumeProfile))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(VolumeProfile), Member = "TryGet", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "T&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public bool IsComponentActiveInMask(LayerMask layerMask) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeCollection), Member = "ChangeLayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeCollection), Member = "SetLayerIndexDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public bool Register(Volume volume, int layer) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "SetLayerDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeCollection), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VolumeCollection), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Boolean>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void SetLayerIndexDirty(int layerIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static void SortByPriority(List<Volume> volumes) { }

	[CalledBy(Type = typeof(VolumeManager), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeManager), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VolumeCollection), Member = "ChangeLayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Volume), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VolumeCollection), Member = "SetLayerIndexDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public bool Unregister(Volume volume, int layer) { }

}

