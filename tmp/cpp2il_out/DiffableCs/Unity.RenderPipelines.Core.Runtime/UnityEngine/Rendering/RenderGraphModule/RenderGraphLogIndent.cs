namespace UnityEngine.Rendering.RenderGraphModule;

internal struct RenderGraphLogIndent : IDisposable
{
	private int m_Indentation; //Field offset: 0x0
	private RenderGraphLogger m_Logger; //Field offset: 0x8
	private bool m_Disposed; //Field offset: 0x10

	[CalledBy(Type = typeof(RenderGraph), Member = "ExecuteCompiledPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "LogRenderPassBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "LogCulledPasses", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public RenderGraphLogIndent(RenderGraphLogger logger, int indentation = 1) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ExecuteCompiledPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "LogRenderPassBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "LogCulledPasses", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	private void Dispose(bool disposing) { }

}

