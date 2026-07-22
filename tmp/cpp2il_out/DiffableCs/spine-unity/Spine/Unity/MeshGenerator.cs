namespace Spine.Unity;

public class MeshGenerator
{
	internal struct Settings
	{
		public bool useClipping; //Field offset: 0x0
		[Range(-0.1, 0)]
		[Space]
		public float zSpacing; //Field offset: 0x4
		[Header("Vertex Data")]
		[Space]
		public bool pmaVertexColors; //Field offset: 0x8
		public bool tintBlack; //Field offset: 0x9
		[Tooltip("Enable when using Additive blend mode at SkeletonGraphic under a CanvasGroup. When enabled, Additive alpha value is stored at uv2.g instead of color.a to capture CanvasGroup modifying color.a.")]
		public bool canvasGroupTintBlack; //Field offset: 0xA
		public bool calculateTangents; //Field offset: 0xB
		public bool addNormals; //Field offset: 0xC
		public bool immutableTriangles; //Field offset: 0xD

		public static Settings Default
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 36
		}

		[CallerCount(Count = 0)]
		public static Settings get_Default() { }

	}

	private const float BoundsMinDefault = ∞; //Field offset: 0x0
	private const float BoundsMaxDefault = -∞; //Field offset: 0x0
	private static List<Vector3> AttachmentVerts; //Field offset: 0x0
	private static List<Vector2> AttachmentUVs; //Field offset: 0x8
	private static List<Color32> AttachmentColors32; //Field offset: 0x10
	private static List<Int32> AttachmentIndices; //Field offset: 0x18
	public Settings settings; //Field offset: 0x10
	protected readonly ExposedList<Vector3> vertexBuffer; //Field offset: 0x20
	protected readonly ExposedList<Vector2> uvBuffer; //Field offset: 0x28
	protected readonly ExposedList<Color32> colorBuffer; //Field offset: 0x30
	protected readonly ExposedList<ExposedList`1<Int32>> submeshes; //Field offset: 0x38
	private Vector2 meshBoundsMin; //Field offset: 0x40
	private Vector2 meshBoundsMax; //Field offset: 0x48
	private float meshBoundsThickness; //Field offset: 0x50
	private int submeshIndex; //Field offset: 0x54
	private SkeletonClipping clipper; //Field offset: 0x58
	private Single[] tempVerts; //Field offset: 0x60
	private Int32[] regionTriangles; //Field offset: 0x68
	private Vector3[] normals; //Field offset: 0x70
	private Vector4[] tangents; //Field offset: 0x78
	private Vector2[] tempTanBuffer; //Field offset: 0x80
	private ExposedList<Vector2> uv2; //Field offset: 0x88
	private ExposedList<Vector2> uv3; //Field offset: 0x90

	public MeshGeneratorBuffers Buffers
	{
		[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 159
	}

	public int VertexCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static MeshGenerator() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonClipping), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public MeshGenerator() { }

	[CalledBy(Type = typeof(MeshGenerator), Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubmeshInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void AddAttachmentTintBlack(float r2, float g2, float b2, float a, int vertexCount) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "BuildMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SkeletonClipping), Member = "ClipStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(ClippingAttachment)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "AddAttachmentTintBlack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonClipping), Member = "ClipTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int), typeof(Int32[]), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonClipping), Member = "get_IsClipping", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonClipping), Member = "ClipEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(int), typeof(int), typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonClipping), Member = "ClipEnd", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void AddSubmesh(SubmeshInstruction instruction, bool updateTriangles = true) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonClipping), Member = "ClipEnd", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Begin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerator), Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubmeshInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void BuildMesh(SkeletonRendererInstruction instruction, bool updateTriangles) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void BuildMeshWithArrays(SkeletonRendererInstruction instruction, bool updateTriangles) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<UnityEngine.Vector2>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<UnityEngine.Vector2>))]
	[CallsUnknownMethods(Count = 5)]
	public void EnsureVertexCapacity(int minimumVertexCount, bool inlcudeTintBlack = false, bool includeTangents = false, bool includeNormals = false) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MeshGenerator), Member = "SolveTangents2DTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[]), typeof(Int32[]), typeof(int), typeof(Vector3[]), typeof(Vector2[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_tangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void FillLateVertexData(Mesh mesh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static void FillMeshLocal(Mesh mesh, RegionAttachment regionAttachment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpineSkeletonExtensions), Member = "IsWeighted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoneMatrix), Member = "CalculateSetupWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoneData)}, ReturnType = typeof(BoneMatrix))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void FillMeshLocal(Mesh mesh, MeshAttachment meshAttachment, SkeletonData skeletonData) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "set_subMeshCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void FillTriangles(Mesh mesh) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_bounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void FillVertexData(Mesh mesh) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>))]
	[CallsUnknownMethods(Count = 14)]
	public static void GenerateSingleSubmeshInstruction(SkeletonRendererInstruction instructionOutput, Skeleton skeleton, Material material) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	public static void GenerateSkeletonRendererInstruction(SkeletonRendererInstruction instructionOutput, Skeleton skeleton, Dictionary<Slot, Material> customSlotMaterials, List<Slot> separatorSlots, bool generateMeshOverride, bool immutableTriangles = false) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public MeshGeneratorBuffers get_Buffers() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_VertexCount() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public Bounds GetMeshBounds() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "HasMultipleSubmeshInstructions", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	public static bool RequiresMultipleSubmeshesByDrawOrder(Skeleton skeleton) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void ScaleVertexData(float scale) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static void SolveTangents2DBuffer(Vector4[] tangents, Vector2[] tempTanBuffer, int vertexCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void SolveTangents2DEnsureSize(ref Vector4[] tangentBuffer, ref Vector2[] tempTanBuffer, int vertexCount, int vertexBufferLength) { }

	[CalledBy(Type = typeof(MeshGenerator), Member = "FillLateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static void SolveTangents2DTriangles(Vector2[] tempTanBuffer, Int32[] triangles, int triangleCount, Vector3[] vertices, Vector2[] uvs, int vertexCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int SubmeshIndexCount(int submeshIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void TrimExcess() { }

	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public static void TryReplaceMaterials(ExposedList<SubmeshInstruction> workingSubmeshInstructions, Dictionary<Material, Material> customMaterialOverride) { }

}

