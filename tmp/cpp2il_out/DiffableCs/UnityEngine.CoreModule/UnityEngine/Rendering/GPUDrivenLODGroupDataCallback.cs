namespace UnityEngine.Rendering;

internal sealed class GPUDrivenLODGroupDataCallback : MulticastDelegate
{

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public GPUDrivenLODGroupDataCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(in GPUDrivenLODGroupData lodGroupData) { }

}

