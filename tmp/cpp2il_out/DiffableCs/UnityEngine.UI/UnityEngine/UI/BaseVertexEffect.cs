namespace UnityEngine.UI;

[Obsolete("Use BaseMeshEffect instead", True)]
public abstract class BaseVertexEffect
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected BaseVertexEffect() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
	public abstract void ModifyVertices(List<UIVertex> vertices) { }

}

