namespace UnityEngine.UI;

[AddComponentMenu("UI/Effects/Position As UV1", 82)]
public class PositionAsUV1 : BaseMeshEffect
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected PositionAsUV1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "PopulateUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "SetUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ModifyMesh(VertexHelper vh) { }

}

