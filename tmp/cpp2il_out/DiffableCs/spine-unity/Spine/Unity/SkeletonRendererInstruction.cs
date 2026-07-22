namespace Spine.Unity;

public class SkeletonRendererInstruction
{
	public readonly ExposedList<SubmeshInstruction> submeshInstructions; //Field offset: 0x10
	public bool immutableTriangles; //Field offset: 0x18
	public bool hasActiveClipping; //Field offset: 0x19
	public int rawVertexCount; //Field offset: 0x1C
	public readonly ExposedList<Attachment> attachments; //Field offset: 0x20

	[CalledBy(Type = typeof(SkeletonGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmartMesh), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public SkeletonRendererInstruction() { }

	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "ClearState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GenerateSingleSubmeshInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(Skeleton), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GenerateSkeletonRendererInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(Skeleton), typeof(System.Collections.Generic.Dictionary`2<Spine.Slot, UnityEngine.Material>), typeof(System.Collections.Generic.List`1<Spine.Slot>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmartMesh), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshRendererBuffers), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static bool GeometryNotEqual(SkeletonRendererInstruction a, SkeletonRendererInstruction b) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void Set(SkeletonRendererInstruction other) { }

	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void SetWithSubset(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh) { }

}

