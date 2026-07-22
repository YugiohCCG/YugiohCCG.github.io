namespace UnityEngine.Rendering.RenderGraphModule;

public sealed class RenderGraphObjectPool
{
	private class SharedObjectPool : SharedObjectPoolBase
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c<T> <>9; //Field offset: 0x0
			public static Func<T> <>9__1_0; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 8)]
			[DeduplicatedMethod]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
			[DeduplicatedMethod]
			internal T <AllocatePool>b__1_0() { }

		}

		private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SharedObjectPool`1), Member = "AllocatePool", ReturnType = "UnityEngine.Pool.ObjectPool`1<T>")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		private static SharedObjectPool`1() { }

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SharedObjectPool`1() { }

		[CalledBy(Type = typeof(SharedObjectPool`1), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 24)]
		[DeduplicatedMethod]
		private static ObjectPool<T> AllocatePool() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObjectPool`1), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual void Clear() { }

		[CalledBy(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
		[CalledBy(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
		[CalledBy(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
		[CalledBy(Type = typeof(RenderGraph), Member = "AddRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(RenderGraphBuilder))]
		[CalledBy(Type = typeof(RenderGraphObjectPool), Member = "GetTempMaterialPropertyBlock", ReturnType = typeof(MaterialPropertyBlock))]
		[CalledBy(Type = typeof(RenderGraphObjectPool), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public static T Get() { }

		[CalledBy(Type = typeof(RenderGraphObjectPool), Member = "ReleaseAllTempAlloc", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraphObjectPool), Member = "Release", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		public static void Release(T toRelease) { }

	}

	private class SharedObjectPoolBase
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SharedObjectPoolBase() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Clear() { }

	}

	private static DynamicArray<SharedObjectPoolBase> s_AllocatedPools; //Field offset: 0x0
	private Dictionary<ValueTuple`2<Type, Int32>, Stack`1<Object>> m_ArrayPool; //Field offset: 0x10
	private List<ValueTuple`2<Object, ValueTuple`2<Type, Int32>>> m_AllocatedArrays; //Field offset: 0x18
	private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static RenderGraphObjectPool() { }

	[CalledBy(Type = typeof(RenderGraph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Int32>, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal RenderGraphObjectPool() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.Rendering.DynamicArray`1<T>+Iterator<T>")]
	[Calls(Type = typeof(Iterator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void Cleanup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SharedObjectPool`1), Member = "Get", ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal T Get() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Int32>, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Int32>), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Int32>, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Int32>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public T[] GetTempArray(int size) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+<>c", Member = "<RenderFragmentationOverlay>b__45_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+RenderFragmentationOverlayPassData", typeof(RenderGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<RenderDebugOccluderOverlay>b__32_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+OccluderOverlayPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SharedObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public MaterialPropertyBlock GetTempMaterialPropertyBlock() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsEmpty() { }

	[CalledBy(Type = typeof(BaseRenderGraphPass`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphObjectPool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphPass`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphObjectPool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputeRenderGraphPass`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphObjectPool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RasterRenderGraphPass`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphObjectPool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeRenderGraphPass`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphObjectPool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SharedObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal void Release(T value) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "PostRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteDestroyResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(PassData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.Object, System.Int32>, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Object, System.Int32>), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SharedObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal void ReleaseAllTempAlloc() { }

}

