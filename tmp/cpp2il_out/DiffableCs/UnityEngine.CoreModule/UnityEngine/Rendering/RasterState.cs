namespace UnityEngine.Rendering;

public struct RasterState : IEquatable<RasterState>
{
	public static readonly RasterState defaultValue; //Field offset: 0x0
	private CullMode m_CullingMode; //Field offset: 0x0
	private int m_OffsetUnits; //Field offset: 0x4
	private float m_OffsetFactor; //Field offset: 0x8
	private byte m_DepthClip; //Field offset: 0xC
	private byte m_Conservative; //Field offset: 0xD
	private byte m_Padding1; //Field offset: 0xE
	private byte m_Padding2; //Field offset: 0xF

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static RasterState() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "GetRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(RenderStateBlock))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public RasterState(CullMode cullingMode = 2, int offsetUnits = 0, float offsetFactor = 0, bool depthClip = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(RasterState other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual int GetHashCode() { }

}

