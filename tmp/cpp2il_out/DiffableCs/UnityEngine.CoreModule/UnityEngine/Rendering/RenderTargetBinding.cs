namespace UnityEngine.Rendering;

public struct RenderTargetBinding
{
	private RenderTargetIdentifier[] m_ColorRenderTargets; //Field offset: 0x0
	private RenderTargetIdentifier m_DepthRenderTarget; //Field offset: 0x8
	private RenderBufferLoadAction[] m_ColorLoadActions; //Field offset: 0x30
	private RenderBufferStoreAction[] m_ColorStoreActions; //Field offset: 0x38
	private RenderBufferLoadAction m_DepthLoadAction; //Field offset: 0x40
	private RenderBufferStoreAction m_DepthStoreAction; //Field offset: 0x44
	private RenderTargetFlags m_Flags; //Field offset: 0x48

	public RenderBufferLoadAction[] colorLoadActions
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public RenderTargetIdentifier[] colorRenderTargets
	{
		[CallerCount(Count = 223)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public RenderBufferStoreAction[] colorStoreActions
	{
		[CallerCount(Count = 35)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public RenderBufferLoadAction depthLoadAction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public RenderTargetIdentifier depthRenderTarget
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 29
	}

	public RenderBufferStoreAction depthStoreAction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	public RenderTargetFlags flags
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public RenderBufferLoadAction[] get_colorLoadActions() { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public RenderTargetIdentifier[] get_colorRenderTargets() { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public RenderBufferStoreAction[] get_colorStoreActions() { }

	[CallerCount(Count = 0)]
	public RenderBufferLoadAction get_depthLoadAction() { }

	[CallerCount(Count = 0)]
	public RenderTargetIdentifier get_depthRenderTarget() { }

	[CallerCount(Count = 0)]
	public RenderBufferStoreAction get_depthStoreAction() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RenderTargetFlags get_flags() { }

}

