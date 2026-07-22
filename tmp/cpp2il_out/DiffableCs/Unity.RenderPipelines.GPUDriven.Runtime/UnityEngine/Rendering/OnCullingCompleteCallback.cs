namespace UnityEngine.Rendering;

internal sealed class OnCullingCompleteCallback : MulticastDelegate
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public OnCullingCompleteCallback(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IAsyncResult BeginInvoke(JobHandle jobHandle, in BatchCullingContext cullingContext, in BatchCullingOutput cullingOutput, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void EndInvoke(in BatchCullingContext cullingContext, in BatchCullingOutput cullingOutput, IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Invoke(JobHandle jobHandle, in BatchCullingContext cullingContext, in BatchCullingOutput cullingOutput) { }

}

