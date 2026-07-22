namespace UnityEngine.Rendering.Universal;

internal class DecalDrawCallChunk : DecalChunk
{
	public NativeArray<float4x4> decalToWorlds; //Field offset: 0x28
	public NativeArray<float4x4> normalToDecals; //Field offset: 0x38
	public NativeArray<Single> renderingLayerMasks; //Field offset: 0x48
	public NativeArray<DecalSubDrawCall> subCalls; //Field offset: 0x58
	public NativeArray<Int32> subCallCounts; //Field offset: 0x68

	public int subCallCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DecalDrawCallChunk() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	public virtual void Dispose() { }

	[CallerCount(Count = 0)]
	public int get_subCallCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<float4x4>&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecalChunk), Member = "RemoveAtSwapBack", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public virtual void RemoveAtSwapBack(int entityIndex) { }

	[CallerCount(Count = 0)]
	public void set_subCallCount(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<float4x4>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	public virtual void SetCapacity(int newCapacity) { }

}

