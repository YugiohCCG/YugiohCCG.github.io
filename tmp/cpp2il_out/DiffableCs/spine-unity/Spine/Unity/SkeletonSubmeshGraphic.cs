namespace Spine.Unity;

[RequireComponent(typeof(CanvasRenderer))]
public class SkeletonSubmeshGraphic : MaskableGraphic
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SkeletonSubmeshGraphic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetMaterialDirty() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetVerticesDirty() { }

}

