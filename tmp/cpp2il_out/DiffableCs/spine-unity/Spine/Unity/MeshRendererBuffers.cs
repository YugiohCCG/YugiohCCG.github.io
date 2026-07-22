namespace Spine.Unity;

public class MeshRendererBuffers : IDisposable
{
	internal class SmartMesh : IDisposable
	{
		public Mesh mesh; //Field offset: 0x10
		public SkeletonRendererInstruction instructionUsed; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "MarkDynamic", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SkeletonRendererInstruction), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public SmartMesh() { }

		[CalledBy(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonGraphic), Member = "InitMeshBuffers", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Clear() { }

		[CalledBy(Type = typeof(SkeletonGraphic), Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonGraphic), Member = "DisposeMeshBuffers", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonRenderer), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MeshRendererBuffers), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

	}

	private DoubleBuffered<SmartMesh> doubleBufferedMesh; //Field offset: 0x10
	internal readonly ExposedList<Material> submeshMaterials; //Field offset: 0x18
	internal Material[] sharedMaterials; //Field offset: 0x20

	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public MeshRendererBuffers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(SmartMesh), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public SmartMesh GetNextMesh() { }

	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExposedList`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Material[] GetUpdatedSharedMaterialsArray() { }

	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DoubleBuffered`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize() { }

	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool MaterialsChangedInLastUpdate() { }

	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateSharedMaterials(ExposedList<SubmeshInstruction> instructions) { }

}

