namespace UnityEngine.Rendering;

public struct RenderTargetBlendState : IEquatable<RenderTargetBlendState>
{
	private byte m_WriteMask; //Field offset: 0x0
	private byte m_SourceColorBlendMode; //Field offset: 0x1
	private byte m_DestinationColorBlendMode; //Field offset: 0x2
	private byte m_SourceAlphaBlendMode; //Field offset: 0x3
	private byte m_DestinationAlphaBlendMode; //Field offset: 0x4
	private byte m_ColorBlendOperation; //Field offset: 0x5
	private byte m_AlphaBlendOperation; //Field offset: 0x6
	private byte m_Padding; //Field offset: 0x7

	public static RenderTargetBlendState defaultValue
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 15
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 1)]
	public RenderTargetBlendState(ColorWriteMask writeMask = 15, BlendMode sourceColorBlendMode = 1, BlendMode destinationColorBlendMode = 0, BlendMode sourceAlphaBlendMode = 1, BlendMode destinationAlphaBlendMode = 0, BlendOp colorBlendOperation = 0, BlendOp alphaBlendOperation = 0) { }

	[CalledBy(Type = typeof(BlendState), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlendState)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(RenderTargetBlendState other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	public static RenderTargetBlendState get_defaultValue() { }

	[CalledBy(Type = typeof(BlendState), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	public virtual int GetHashCode() { }

}

