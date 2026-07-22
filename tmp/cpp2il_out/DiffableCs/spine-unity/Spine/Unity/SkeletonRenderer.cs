namespace Spine.Unity;

[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRenderer-Component")]
[RequireComponent(typeof(MeshRenderer))]
public class SkeletonRenderer : MonoBehaviour, ISkeletonComponent, ISpineComponent, IHasSkeletonDataAsset
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public string startsWith; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass76_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <FindAndApplySeparatorSlots>b__0(string slotName) { }

	}

	internal sealed class InstructionDelegate : MulticastDelegate
	{

		[CallerCount(Count = 60)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public InstructionDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(SkeletonRendererInstruction instruction, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(SkeletonRendererInstruction instruction) { }

	}

	internal sealed class SkeletonRendererDelegate : MulticastDelegate
	{

		[CallerCount(Count = 60)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public SkeletonRendererDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(SkeletonRenderer skeletonRenderer, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(SkeletonRenderer skeletonRenderer) { }

	}

	internal class SpriteMaskInteractionMaterials
	{
		public Material[] materialsMaskDisabled; //Field offset: 0x10
		public Material[] materialsInsideMask; //Field offset: 0x18
		public Material[] materialsOutsideMask; //Field offset: 0x20

		public bool AnyMaterialCreated
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 69
		}

		[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonRenderer), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public SpriteMaskInteractionMaterials() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool get_AnyMaterialCreated() { }

	}

	public const CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_OUTSIDE = 5; //Field offset: 0x0
	public const CompareFunction STENCIL_COMP_MASKINTERACTION_VISIBLE_INSIDE = 4; //Field offset: 0x0
	public const CompareFunction STENCIL_COMP_MASKINTERACTION_NONE = 8; //Field offset: 0x0
	public static readonly int STENCIL_COMP_PARAM_ID; //Field offset: 0x0
	public static readonly int SUBMESH_DUMMY_PARAM_ID; //Field offset: 0x4
	public SkeletonDataAsset skeletonDataAsset; //Field offset: 0x20
	[SpineSkin(null, null, True, False, True)]
	public string initialSkinName; //Field offset: 0x28
	public bool initialFlipX; //Field offset: 0x30
	public bool initialFlipY; //Field offset: 0x31
	protected UpdateMode updateMode; //Field offset: 0x34
	public UpdateMode updateWhenInvisible; //Field offset: 0x38
	[FormerlySerializedAs("submeshSeparators")]
	[SerializeField]
	[SpineSlot(null, null, False, True, False)]
	protected String[] separatorSlotNames; //Field offset: 0x40
	public readonly List<Slot> separatorSlots; //Field offset: 0x48
	[Range(-0.1, 0)]
	public float zSpacing; //Field offset: 0x50
	public bool useClipping; //Field offset: 0x54
	public bool immutableTriangles; //Field offset: 0x55
	public bool pmaVertexColors; //Field offset: 0x56
	public bool clearStateOnDisable; //Field offset: 0x57
	public bool tintBlack; //Field offset: 0x58
	public bool singleSubmesh; //Field offset: 0x59
	public bool fixDrawOrder; //Field offset: 0x5A
	[FormerlySerializedAs("calculateNormals")]
	public bool addNormals; //Field offset: 0x5B
	public bool calculateTangents; //Field offset: 0x5C
	public SpriteMaskInteraction maskInteraction; //Field offset: 0x60
	public SpriteMaskInteractionMaterials maskMaterials; //Field offset: 0x68
	public bool disableRenderingOnOverride; //Field offset: 0x70
	[CompilerGenerated]
	private InstructionDelegate generateMeshOverride; //Field offset: 0x78
	[CompilerGenerated]
	private MeshGeneratorDelegate OnPostProcessVertices; //Field offset: 0x80
	private readonly Dictionary<Material, Material> customMaterialOverride; //Field offset: 0x88
	private readonly Dictionary<Slot, Material> customSlotMaterials; //Field offset: 0x90
	private readonly SkeletonRendererInstruction currentInstructions; //Field offset: 0x98
	private readonly MeshGenerator meshGenerator; //Field offset: 0xA0
	private readonly MeshRendererBuffers rendererBuffers; //Field offset: 0xA8
	private MeshRenderer meshRenderer; //Field offset: 0xB0
	private MeshFilter meshFilter; //Field offset: 0xB8
	public bool valid; //Field offset: 0xC0
	public Skeleton skeleton; //Field offset: 0xC8
	[CompilerGenerated]
	private SkeletonRendererDelegate OnRebuild; //Field offset: 0xD0
	[CompilerGenerated]
	private SkeletonRendererDelegate OnMeshAndMaterialsUpdated; //Field offset: 0xD8
	private MaterialPropertyBlock reusedPropertyBlock; //Field offset: 0xE0

	private event InstructionDelegate generateMeshOverride
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		private add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		private remove { } //Length: 146
	}

	public event InstructionDelegate GenerateMeshOverride
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 add { } //Length: 281
		[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "set_SkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRenderer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 remove { } //Length: 281
	}

	public event SkeletonRendererDelegate OnMeshAndMaterialsUpdated
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public event MeshGeneratorDelegate OnPostProcessVertices
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public event SkeletonRendererDelegate OnRebuild
	{
		[CalledBy(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoundingBoxFollower), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CalledBy(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoneFollower), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoundingBoxFollower), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoundingBoxFollower), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PointFollower), Member = "OnDestroy", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonUtility), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonUtility), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public Dictionary<Material, Material> CustomMaterialOverride
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Dictionary<Slot, Material> CustomSlotMaterials
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override Skeleton Skeleton
	{
		[CalledBy(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 43
	}

	public override SkeletonDataAsset SkeletonDataAsset
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public UpdateMode UpdateMode
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static SkeletonRenderer() { }

	[CalledBy(Type = typeof(SkeletonAnimation), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonMecanim), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpriteMaskInteractionMaterials), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshRendererBuffers), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public SkeletonRenderer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void add_generateMeshOverride(InstructionDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void add_GenerateMeshOverride(InstructionDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_OnMeshAndMaterialsUpdated(SkeletonRendererDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	[CalledBy(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxFollower), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_OnRebuild(SkeletonRendererDelegate value) { }

	[CalledBy(Type = typeof(SkeletonAnimation), Member = "AddToGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SkeletonDataAsset), typeof(bool)}, ReturnType = typeof(SkeletonAnimation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static T AddSpineComponent(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, bool quiet = false) { }

	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "InitSpriteMaskMaterialsForMaskType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareFunction), typeof(Material[]&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void AssignSpriteMaskMaterials() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Awake() { }

	[CalledBy(Type = typeof(SkeletonAnimation), Member = "ClearState", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SetToSetupPose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void ClearState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EnsureMeshGeneratorCapacity(int minimumVertexCount) { }

	[CalledBy(Type = typeof(SkeletonRenderer), Member = "FindAndApplySeparatorSlots", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	public void FindAndApplySeparatorSlots(Func<String, Boolean> slotNamePredicate, bool clearExistingSeparators = true, bool updateStringArray = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "FindAndApplySeparatorSlots", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.String, System.Boolean>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void FindAndApplySeparatorSlots(string startsWith, bool clearExistingSeparators = true, bool updateStringArray = false) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Dictionary<Material, Material> get_CustomMaterialOverride() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public Dictionary<Slot, Material> get_CustomSlotMaterials() { }

	[CalledBy(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Skeleton get_Skeleton() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override SkeletonDataAsset get_SkeletonDataAsset() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public UpdateMode get_UpdateMode() { }

	[CalledBy(Type = typeof(SkeletonAnimation), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonMecanim), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skeleton), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Slot))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshGenerator), Member = "Begin", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshRendererBuffers), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public override void Initialize(bool overwrite, bool quiet = false) { }

	[CalledBy(Type = typeof(SkeletonRenderer), Member = "AssignSpriteMaskMaterials", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "InitSpriteMaskMaterialsInsideMask", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "InitSpriteMaskMaterialsOutsideMask", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool InitSpriteMaskMaterialsForMaskType(CompareFunction maskFunction, ref Material[] materialsToFill) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = "InitSpriteMaskMaterialsForMaskType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareFunction), typeof(Material[]&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool InitSpriteMaskMaterialsInsideMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRenderer), Member = "InitSpriteMaskMaterialsForMaskType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareFunction), typeof(Material[]&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool InitSpriteMaskMaterialsOutsideMask() { }

	[CalledBy(Type = typeof(SkeletonAnimation), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonMecanim), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void LateUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshRendererBuffers), Member = "UpdateSharedMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillLateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpriteMaskInteractionMaterials), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateSingleSubmeshInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(Skeleton), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshRendererBuffers), Member = "GetUpdatedSharedMaterialsArray", ReturnType = typeof(Material[]))]
	[Calls(Type = typeof(MeshRendererBuffers), Member = "MaterialsChangedInLastUpdate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "AssignSpriteMaskMaterials", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "BuildMeshWithArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "Begin", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "GeometryNotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(SkeletonRendererInstruction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshGenerator), Member = "TryReplaceMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Material, UnityEngine.Material>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateSkeletonRendererInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(Skeleton), typeof(System.Collections.Generic.Dictionary`2<Spine.Slot, UnityEngine.Material>), typeof(System.Collections.Generic.List`1<Spine.Slot>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(Renderer), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshGenerator), Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubmeshInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRenderer), Member = "SetMaterialSettingsToFixDrawOrder", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public override void LateUpdateMesh() { }

	[CalledBy(Type = typeof(SkeletonAnimation), Member = "NewSkeletonAnimationGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonDataAsset), typeof(bool)}, ReturnType = typeof(SkeletonAnimation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T NewSpineGameObject(SkeletonDataAsset skeletonDataAsset, bool quiet = false) { }

	[CallerCount(Count = 0)]
	public void OnBecameInvisible() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnBecameVisible() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(SmartMesh), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Slot))]
	[CallsUnknownMethods(Count = 3)]
	public void ReapplySeparatorSlotNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	private void remove_generateMeshOverride(InstructionDelegate value) { }

	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "set_SkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRenderer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void remove_GenerateMeshOverride(InstructionDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_OnMeshAndMaterialsUpdated(SkeletonRendererDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_OnPostProcessVertices(MeshGeneratorDelegate value) { }

	[CalledBy(Type = typeof(BoneFollower), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoneFollower), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxFollower), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxFollower), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointFollower), Member = "UpdateReferences", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointFollower), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_OnRebuild(SkeletonRendererDelegate value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_UpdateMode(UpdateMode value) { }

	[CalledBy(Type = typeof(SkeletonRenderer), Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Renderer), Member = "HasPropertyBlock", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "set_enableInstancing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private void SetMaterialSettingsToFixDrawOrder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMeshSettings(Settings settings) { }

}

