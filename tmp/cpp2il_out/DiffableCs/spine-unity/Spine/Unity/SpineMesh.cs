namespace Spine.Unity;

public static class SpineMesh
{
	internal const HideFlags MeshHideflags = 20; //Field offset: 0x0

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "EnsureMeshesCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "MarkDynamic", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static Mesh NewSkeletonMesh() { }

}

