namespace UnityEngine.Rendering;

internal struct GPUInstanceDataBufferBuilder : IDisposable
{
	private NativeList<GPUInstanceComponentDesc> m_Components; //Field offset: 0x0

	[CalledBy(Type = typeof(RenderersParameters), Member = "CreateInstanceDataBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(InstanceNumInfo&)}, ReturnType = typeof(GPUInstanceDataBuffer))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GPUInstanceDataBufferBuilder), Member = "AddComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(int), typeof(bool), typeof(InstanceType), typeof(InstanceComponentGroup)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AddComponent(int propertyID, bool isOverriden, bool isPerInstance, InstanceType instanceType, InstanceComponentGroup componentGroup = 1) { }

	[CalledBy(Type = typeof(GPUInstanceDataBufferBuilder), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(InstanceType), typeof(InstanceComponentGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUInstanceDataBufferGrower), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer), typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AddComponent(int propertyID, bool isOverriden, int byteSize, bool isPerInstance, InstanceType instanceType, InstanceComponentGroup componentGroup) { }

	[CalledBy(Type = typeof(GPUInstanceDataBufferGrower), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUInstanceDataBuffer), typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderersParameters), Member = "CreateInstanceDataBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(InstanceNumInfo&)}, ReturnType = typeof(GPUInstanceDataBuffer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceNumInfo), Member = "GetInstanceNumIncludingChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, System.Int32>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector4>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector2Int>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	public GPUInstanceDataBuffer Build(in InstanceNumInfo instanceNumInfo) { }

	[CallerCount(Count = 0)]
	private MetadataValue CreateMetadataValue(int nameID, int gpuAddress, bool isOverridden) { }

	[CalledBy(Type = typeof(RenderersParameters), Member = "CreateInstanceDataBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(InstanceNumInfo&)}, ReturnType = typeof(GPUInstanceDataBuffer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.GPUInstanceComponentDesc>), Member = "Dispose", ReturnType = typeof(void))]
	public override void Dispose() { }

}

