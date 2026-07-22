namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("{reason} : {breakPass}")]
internal struct PassBreakAudit
{
	public static readonly String[] BreakReasonMessages; //Field offset: 0x0
	public PassBreakReason reason; //Field offset: 0x0
	public int breakPass; //Field offset: 0x4

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 14)]
	private static PassBreakAudit() { }

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public PassBreakAudit(PassBreakReason reason, int breakPass) { }

}

