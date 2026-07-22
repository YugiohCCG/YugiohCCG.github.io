namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Key = {Key}, Value = {Value}")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
public struct KeyValue
{
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	internal int m_Index; //Field offset: 0x0
	internal int m_Next; //Field offset: 0x0

	public TKey Key
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "UpdateInstanceDataBufferLayoutVersion", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "UpdateOccluderStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 152
	}

	public static KeyValue<TKey, TValue> Null
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public TValue Value
	{
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 78
	}

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "UpdateInstanceDataBufferLayoutVersion", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "UpdateOccluderStats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TKey get_Key() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static KeyValue<TKey, TValue> get_Null() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TValue get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public bool GetKeyValue(out TKey key, out TValue value) { }

}

