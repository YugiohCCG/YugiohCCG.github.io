namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("{reason} : {passId}")]
internal struct LoadAudit
{
	public static readonly String[] LoadReasonMessages; //Field offset: 0x0
	public LoadReason reason; //Field offset: 0x0
	public int passId; //Field offset: 0x4

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	private static LoadAudit() { }

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public LoadAudit(LoadReason setReason, int setPassId = -1) { }

}

