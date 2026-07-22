namespace UnityEngine.Rendering;

public static class CommandBufferPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <.cctor>b__4_0(CommandBuffer x) { }

	}

	private static ObjectPool<CommandBuffer> s_BufferPool; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T>", "UnityEngine.Events.UnityAction`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static CommandBufferPool() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static CommandBuffer Get() { }

	[CalledBy(Type = typeof(MeshGizmo), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(MeshTopology), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGizmo), Member = "RenderWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CommandBuffer), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static CommandBuffer Get(string name) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "PostRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Release(CommandBuffer buffer) { }

}

