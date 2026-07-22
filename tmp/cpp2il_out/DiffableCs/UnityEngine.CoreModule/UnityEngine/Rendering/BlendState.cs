namespace UnityEngine.Rendering;

public struct BlendState : IEquatable<BlendState>
{
	private RenderTargetBlendState m_BlendState0; //Field offset: 0x0
	private RenderTargetBlendState m_BlendState1; //Field offset: 0x8
	private RenderTargetBlendState m_BlendState2; //Field offset: 0x10
	private RenderTargetBlendState m_BlendState3; //Field offset: 0x18
	private RenderTargetBlendState m_BlendState4; //Field offset: 0x20
	private RenderTargetBlendState m_BlendState5; //Field offset: 0x28
	private RenderTargetBlendState m_BlendState6; //Field offset: 0x30
	private RenderTargetBlendState m_BlendState7; //Field offset: 0x38
	private byte m_SeparateMRTBlendStates; //Field offset: 0x40
	private byte m_AlphaToMask; //Field offset: 0x41
	private short m_Padding; //Field offset: 0x42

	public RenderTargetBlendState blendState0
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public static BlendState defaultValue
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		 get { } //Length: 125
	}

	[CalledBy(Type = typeof(BlendState), Member = "get_defaultValue", ReturnType = typeof(BlendState))]
	[CalledBy(Type = typeof(RenderStateBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateMask)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public BlendState(bool separateMRTBlend = false, bool alphaToMask = false) { }

	[CalledBy(Type = typeof(BlendState), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderStateBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderStateBlock)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetBlendState), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetBlendState)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(BlendState other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlendState), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlendState)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlendState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public static BlendState get_defaultValue() { }

	[CalledBy(Type = typeof(RenderStateBlock), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTargetBlendState), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 44)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public void set_blendState0(RenderTargetBlendState value) { }

}

