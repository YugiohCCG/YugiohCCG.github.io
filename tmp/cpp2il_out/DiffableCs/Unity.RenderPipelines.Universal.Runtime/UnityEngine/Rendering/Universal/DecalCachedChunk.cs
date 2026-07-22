namespace UnityEngine.Rendering.Universal;

internal class DecalCachedChunk : DecalChunk
{
	public MaterialPropertyBlock propertyBlock; //Field offset: 0x28
	public int passIndexDBuffer; //Field offset: 0x30
	public int passIndexEmissive; //Field offset: 0x34
	public int passIndexScreenSpace; //Field offset: 0x38
	public int passIndexGBuffer; //Field offset: 0x3C
	public int drawOrder; //Field offset: 0x40
	public bool isCreated; //Field offset: 0x44
	public NativeArray<float4x4> decalToWorlds; //Field offset: 0x48
	public NativeArray<float4x4> normalToWorlds; //Field offset: 0x58
	public NativeArray<float4x4> sizeOffsets; //Field offset: 0x68
	public NativeArray<float2> drawDistances; //Field offset: 0x78
	public NativeArray<float2> angleFades; //Field offset: 0x88
	public NativeArray<float4> uvScaleBias; //Field offset: 0x98
	public NativeArray<Int32> layerMasks; //Field offset: 0xA8
	public NativeArray<UInt64> sceneLayerMasks; //Field offset: 0xB8
	public NativeArray<Single> fadeFactors; //Field offset: 0xC8
	public NativeArray<BoundingSphere> boundingSpheres; //Field offset: 0xD8
	public NativeArray<DecalScaleMode> scaleModes; //Field offset: 0xE8
	public NativeArray<UInt32> renderingLayerMasks; //Field offset: 0xF8
	public NativeArray<float3> positions; //Field offset: 0x108
	public NativeArray<quaternion> rotation; //Field offset: 0x118
	public NativeArray<float3> scales; //Field offset: 0x128
	public NativeArray<Boolean> dirty; //Field offset: 0x138
	public BoundingSphere[] boundingSphereArray; //Field offset: 0x148

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DecalCachedChunk() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	public virtual void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<float4x4>&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<float2>&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<float3>&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public virtual void RemoveAtSwapBack(int entityIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<float4x4>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<UInt64>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<float3>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Boolean>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	public virtual void SetCapacity(int newCapacity) { }

}

