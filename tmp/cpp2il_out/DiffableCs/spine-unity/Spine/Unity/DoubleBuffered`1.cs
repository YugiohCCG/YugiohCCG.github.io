namespace Spine.Unity;

public class DoubleBuffered
{
	private readonly T a; //Field offset: 0x0
	private readonly T b; //Field offset: 0x0
	private bool usingA; //Field offset: 0x0

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "InitMeshBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshRendererBuffers), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public DoubleBuffered`1() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "GetLastMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "MatchRectTransformSingleRenderer", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public T GetCurrent() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "InitMeshBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "DisposeMeshBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshRendererBuffers), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshRendererBuffers), Member = "GetNextMesh", ReturnType = typeof(SmartMesh))]
	[CalledBy(Type = typeof(MeshRendererBuffers), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public T GetNext() { }

}

