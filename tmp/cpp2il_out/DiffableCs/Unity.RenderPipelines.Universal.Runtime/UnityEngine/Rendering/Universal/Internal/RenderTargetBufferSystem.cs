namespace UnityEngine.Rendering.Universal.Internal;

internal sealed class RenderTargetBufferSystem
{
	private struct SwapBuffer
	{
		public RTHandle rtMSAA; //Field offset: 0x0
		public RTHandle rtResolve; //Field offset: 0x8
		public string name; //Field offset: 0x10
		public int msaa; //Field offset: 0x18

	}

	private static bool m_AisBackBuffer; //Field offset: 0x0
	private static RenderTextureDescriptor m_Desc; //Field offset: 0x4
	private SwapBuffer m_A; //Field offset: 0x10
	private SwapBuffer m_B; //Field offset: 0x30
	private FilterMode m_FilterMode; //Field offset: 0x50
	private bool m_AllowMSAA; //Field offset: 0x54

	private SwapBuffer backBuffer
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 96
	}

	private SwapBuffer frontBuffer
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 96
	}

	[CallerCount(Count = 0)]
	private static RenderTargetBufferSystem() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public RenderTargetBufferSystem(string name) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "FinishRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Clear() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "ReleaseRenderTargets", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	public void Dispose() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "EnableSwapBufferMSAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void EnableMSAA(bool enable) { }

	[CallerCount(Count = 0)]
	private SwapBuffer get_backBuffer() { }

	[CallerCount(Count = 0)]
	private SwapBuffer get_frontBuffer() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateCameraRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderTextureDescriptor&), typeof(CommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SwapColorBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "GetCameraColorBackBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(RTHandle))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "ReAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	public RTHandle GetBackBuffer(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	public RTHandle GetBufferA() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "GetCameraColorFrontBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(RTHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetBufferSystem), Member = "ReAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	public RTHandle GetFrontBuffer(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateCameraRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderTextureDescriptor&), typeof(CommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public RTHandle PeekBackBuffer() { }

	[CalledBy(Type = typeof(RenderTargetBufferSystem), Member = "GetBackBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(RenderTargetBufferSystem), Member = "GetFrontBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(RTHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ReAllocate(CommandBuffer cmd) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void SetCameraSettings(RenderTextureDescriptor desc, FilterMode filterMode) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SwapColorBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Swap() { }

}

