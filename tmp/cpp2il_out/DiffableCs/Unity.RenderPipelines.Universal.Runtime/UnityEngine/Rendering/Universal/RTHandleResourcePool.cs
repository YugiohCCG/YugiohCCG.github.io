namespace UnityEngine.Rendering.Universal;

internal class RTHandleResourcePool
{
	protected static int s_CurrentStaleResourceCount; //Field offset: 0x0
	protected static int s_StaleResourceLifetime; //Field offset: 0x4
	protected static int s_StaleResourceMaxCapacity; //Field offset: 0x8
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"resource", "frameIndex"})]
	protected Dictionary<Int32, SortedList`2<Int32, ValueTuple`2<RTHandle, Int32>>> m_ResourcePool; //Field offset: 0x10
	protected List<Int32> m_RemoveList; //Field offset: 0x18

	internal int staleResourceCapacity
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
		[CalledBy(Type = typeof(RenderingUtils), Member = "SetMaxRTHandlePoolCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RTHandleResourcePool), Member = "Cleanup", ReturnType = typeof(void))]
		internal set { } //Length: 135
	}

	[CallerCount(Count = 0)]
	private static RTHandleResourcePool() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderPipelineAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RTHandleResourcePool() { }

	[CalledBy(Type = typeof(RenderingUtils), Member = "AddStaleResourceToPoolOrRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleResourcePool), Member = "GetHashCodeWithNameHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortedList`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(SortedList`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal bool AddResourceToPool(in TextureDesc texDesc, RTHandle resource, int currentFrameIndex) { }

	[CalledBy(Type = typeof(RTHandleResourcePool), Member = "set_staleResourceCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	internal void Cleanup() { }

	[CalledBy(Type = typeof(ShadowUtils), Member = "ShadowRTReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ScaleFunc), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ScaleFunc), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShadowUtils), Member = "ShadowRTNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useMipMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_autoGenerateMips", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static TextureDesc CreateTextureDesc(RenderTextureDescriptor desc, TextureSizeMode textureSizeMode = 0, int anisoLevel = 1, float mipMapBias = 0, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1, string name = "") { }

	[CallerCount(Count = 0)]
	internal int get_staleResourceCapacity() { }

	[CalledBy(Type = typeof(RTHandleResourcePool), Member = "AddResourceToPool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(RTHandle), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTHandleResourcePool), Member = "TryGetResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(RTHandle&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextureDesc), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetHashCodeWithNameHash(in TextureDesc texDesc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 35)]
	internal void LogDebugInfo() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(System.Collections.Generic.List`1<UnityEngine.Camera>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleResourcePool), Member = "ShouldReleaseResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortedList`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	internal void PurgeUnusedResources(int currentFrameIndex) { }

	[CalledBy(Type = typeof(RenderingUtils), Member = "SetMaxRTHandlePoolCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleResourcePool), Member = "Cleanup", ReturnType = typeof(void))]
	internal void set_staleResourceCapacity(int value) { }

	[CalledBy(Type = typeof(RTHandleResourcePool), Member = "PurgeUnusedResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex) { }

	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ScaleFunc), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ScaleFunc), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RTHandleResourcePool), Member = "GetHashCodeWithNameHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortedList`2), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal bool TryGetResource(in TextureDesc texDesc, out RTHandle resource, bool usepool = true) { }

}

