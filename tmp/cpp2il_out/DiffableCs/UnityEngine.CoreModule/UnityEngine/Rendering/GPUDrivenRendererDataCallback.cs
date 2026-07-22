namespace UnityEngine.Rendering;

internal sealed class GPUDrivenRendererDataCallback : MulticastDelegate
{

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public GPUDrivenRendererDataCallback(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials) { }

}

