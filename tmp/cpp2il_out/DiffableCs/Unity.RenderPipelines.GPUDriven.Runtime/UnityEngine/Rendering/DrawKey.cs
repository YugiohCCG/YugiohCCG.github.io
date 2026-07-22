namespace UnityEngine.Rendering;

internal struct DrawKey : IEquatable<DrawKey>
{
	public BatchMeshID meshID; //Field offset: 0x0
	public int submeshIndex; //Field offset: 0x4
	public BatchMaterialID materialID; //Field offset: 0x8
	public BatchDrawCommandFlags flags; //Field offset: 0xC
	public int transparentInstanceId; //Field offset: 0x10
	public uint overridenComponents; //Field offset: 0x14
	public RangeKey range; //Field offset: 0x18
	public int lightmapIndex; //Field offset: 0x34

	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "TryGetNextValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BatchMeshID), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchMeshID), typeof(BatchMeshID)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BatchMaterialID), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchMaterialID), typeof(BatchMaterialID)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(DrawKey other) { }

	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData", Member = "ReallocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(int), typeof(long), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "TryAddAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "AddAtomicMulti", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase`2", Member = "TryGetFirstValueAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

}

