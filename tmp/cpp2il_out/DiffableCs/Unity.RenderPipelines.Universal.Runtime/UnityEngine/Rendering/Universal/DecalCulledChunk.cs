namespace UnityEngine.Rendering.Universal;

internal class DecalCulledChunk : DecalChunk
{
	public Vector3 cameraPosition; //Field offset: 0x28
	public ulong sceneCullingMask; //Field offset: 0x38
	public int cullingMask; //Field offset: 0x40
	public CullingGroup cullingGroups; //Field offset: 0x48
	public Int32[] visibleDecalIndexArray; //Field offset: 0x50
	public NativeArray<Int32> visibleDecalIndices; //Field offset: 0x58
	public int visibleDecalCount; //Field offset: 0x68

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DecalCulledChunk() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public virtual void RemoveAtSwapBack(int entityIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CullingGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void SetCapacity(int newCapacity) { }

}

