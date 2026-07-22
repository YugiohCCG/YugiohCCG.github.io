namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("{reason} : {passId} / MSAA {msaaReason} : {msaaPassId}")]
internal struct StoreAudit
{
	public static readonly String[] StoreReasonMessages; //Field offset: 0x0
	public StoreReason reason; //Field offset: 0x0
	public int passId; //Field offset: 0x4
	public StoreReason msaaReason; //Field offset: 0x8
	public int msaaPassId; //Field offset: 0xC

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	private static StoreAudit() { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public StoreAudit(StoreReason setReason, int setPassId = -1, StoreReason setMsaaReason = 6, int setMsaaPassId = -1) { }

}

