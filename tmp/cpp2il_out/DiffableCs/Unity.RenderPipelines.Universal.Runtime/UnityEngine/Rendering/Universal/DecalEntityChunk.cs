namespace UnityEngine.Rendering.Universal;

internal class DecalEntityChunk : DecalChunk
{
	public Material material; //Field offset: 0x28
	public NativeArray<DecalEntity> decalEntities; //Field offset: 0x30
	public DecalProjector[] decalProjectors; //Field offset: 0x40
	public TransformAccessArray transformAccessArray; //Field offset: 0x48

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DecalEntityChunk() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformAccessArray), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Dispose() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Push() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformAccessArray), Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void RemoveAtSwapBack(int entityIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformAccessArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformAccessArray), Member = "get_isCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TransformAccessArray), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(TransformAccessArray), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformAccessArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetCapacity(int newCapacity) { }

}

