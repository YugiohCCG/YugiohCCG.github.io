namespace Spine.Unity;

[AddComponentMenu("Spine/SkeletonGraphic (Unity UI Canvas)")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonGraphic-Component")]
[RequireComponent(typeof(CanvasRenderer), typeof(RectTransform))]
public class SkeletonGraphic : MaskableGraphic, ISkeletonComponent, ISpineComponent, IAnimationStateComponent, ISkeletonAnimation, IHasSkeletonDataAsset
{
	internal sealed class SkeletonRendererDelegate : MulticastDelegate
	{

		[CallerCount(Count = 412)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public SkeletonRendererDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(SkeletonGraphic skeletonGraphic, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(SkeletonGraphic skeletonGraphic) { }

	}

	public const string SeparatorPartGameObjectName = "Part"; //Field offset: 0x0
	public SkeletonDataAsset skeletonDataAsset; //Field offset: 0xE0
	public Material additiveMaterial; //Field offset: 0xE8
	public Material multiplyMaterial; //Field offset: 0xF0
	public Material screenMaterial; //Field offset: 0xF8
	[SpineSkin(null, "skeletonDataAsset", True, False, True)]
	public string initialSkinName; //Field offset: 0x100
	public bool initialFlipX; //Field offset: 0x108
	public bool initialFlipY; //Field offset: 0x109
	[SpineAnimation(null, "skeletonDataAsset", True, False)]
	public string startingAnimation; //Field offset: 0x110
	public bool startingLoop; //Field offset: 0x118
	public float timeScale; //Field offset: 0x11C
	public bool freeze; //Field offset: 0x120
	protected UpdateMode updateMode; //Field offset: 0x124
	public UpdateMode updateWhenInvisible; //Field offset: 0x128
	public bool unscaledTime; //Field offset: 0x12C
	public bool allowMultipleCanvasRenderers; //Field offset: 0x12D
	public List<CanvasRenderer> canvasRenderers; //Field offset: 0x130
	protected List<SkeletonSubmeshGraphic> submeshGraphics; //Field offset: 0x138
	protected int usedRenderersCount; //Field offset: 0x140
	[SerializeField]
	[SpineSlot(null, null, False, True, False)]
	protected String[] separatorSlotNames; //Field offset: 0x148
	public readonly List<Slot> separatorSlots; //Field offset: 0x150
	public bool enableSeparatorSlots; //Field offset: 0x158
	[SerializeField]
	protected List<Transform> separatorParts; //Field offset: 0x160
	public bool updateSeparatorPartLocation; //Field offset: 0x168
	private bool wasUpdatedAfterInit; //Field offset: 0x169
	private Texture baseTexture; //Field offset: 0x170
	private readonly Dictionary<Texture, Texture> customTextureOverride; //Field offset: 0x178
	private readonly Dictionary<Texture, Material> customMaterialOverride; //Field offset: 0x180
	private Texture overrideTexture; //Field offset: 0x188
	protected Skeleton skeleton; //Field offset: 0x190
	[CompilerGenerated]
	private SkeletonRendererDelegate OnRebuild; //Field offset: 0x198
	[CompilerGenerated]
	private SkeletonRendererDelegate OnMeshAndMaterialsUpdated; //Field offset: 0x1A0
	protected AnimationState state; //Field offset: 0x1A8
	[SerializeField]
	protected MeshGenerator meshGenerator; //Field offset: 0x1B0
	private DoubleBuffered<SmartMesh> meshBuffers; //Field offset: 0x1B8
	private SkeletonRendererInstruction currentInstructions; //Field offset: 0x1C0
	private readonly ExposedList<Mesh> meshes; //Field offset: 0x1C8
	[CompilerGenerated]
	private UpdateBonesDelegate BeforeApply; //Field offset: 0x1D0
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateLocal; //Field offset: 0x1D8
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateWorld; //Field offset: 0x1E0
	[CompilerGenerated]
	private UpdateBonesDelegate UpdateComplete; //Field offset: 0x1E8
	[CompilerGenerated]
	private MeshGeneratorDelegate OnPostProcessVertices; //Field offset: 0x1F0

	public event UpdateBonesDelegate BeforeApply
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
		[CalledBy(Type = typeof(SkeletonUtility), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonUtility), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SkeletonUtility), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public override event UpdateBonesDelegate UpdateComplete
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

	public override event UpdateBonesDelegate UpdateLocal
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

	public override event UpdateBonesDelegate UpdateWorld
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

	public override AnimationState AnimationState
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		 get { } //Length: 32
	}

	public Dictionary<Texture, Material> CustomMaterialOverride
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Dictionary<Texture, Texture> CustomTextureOverride
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool IsValid
	{
		[CalledBy(Type = typeof(SkeletonUtility), Member = "get_IsValid", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 12
	}

	public virtual Texture mainTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 122
	}

	public MeshGenerator MeshGenerator
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Texture OverrideTexture
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[Calls(Type = typeof(CanvasRenderer), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 99
	}

	public List<Transform> SeparatorParts
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override Skeleton Skeleton
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		 get { } //Length: 32
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public SkeletonData SkeletonData
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
	}

	public override SkeletonDataAsset SkeletonDataAsset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public UpdateMode UpdateMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public SkeletonGraphic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_BeforeApply(UpdateBonesDelegate value) { }

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

	[CalledBy(Type = typeof(SkeletonUtility), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_OnRebuild(SkeletonRendererDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void add_UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void add_UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void add_UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static SkeletonGraphic AddSkeletonGraphicComponent(GameObject gameObject, SkeletonDataAsset skeletonDataAsset, Material material) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected void ApplyAnimation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "SyncSubmeshGraphicsWithCanvasRenderers", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Awake() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "DestroyMeshes", ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(SmartMesh), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Clear() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected void DestroyMeshes() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void DisableUnusedCanvasRenderers(int usedCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(SmartMesh), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void DisposeMeshBuffers() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "set_maskable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	protected void EnsureCanvasRendererCount(int targetCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpineMesh), Member = "NewSkeletonMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void EnsureMeshesCount(int targetCount) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	protected void EnsureSeparatorPartCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public override AnimationState get_AnimationState() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Dictionary<Texture, Material> get_CustomMaterialOverride() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Dictionary<Texture, Texture> get_CustomTextureOverride() { }

	[CalledBy(Type = typeof(SkeletonUtility), Member = "get_IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkeletonUtilityBone), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public virtual Texture get_mainTexture() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MeshGenerator get_MeshGenerator() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Texture get_OverrideTexture() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<Transform> get_SeparatorParts() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public override Skeleton get_Skeleton() { }

	[CallerCount(Count = 0)]
	public SkeletonData get_SkeletonData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override SkeletonDataAsset get_SkeletonDataAsset() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UpdateMode get_UpdateMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetCurrent", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public Mesh GetLastMesh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerator), Member = "RequiresMultipleSubmeshesByDrawOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	public bool HasMultipleSubmeshInstructions() { }

	[CalledBy(Type = typeof(BoneFollowerGraphic), Member = "SetBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "get_AnimationState", ReturnType = typeof(AnimationState))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "get_Skeleton", ReturnType = typeof(Skeleton))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "AddSkeletonGraphicComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SkeletonDataAsset), typeof(Material)}, ReturnType = typeof(SkeletonGraphic))]
	[CalledBy(Type = typeof(SkeletonGraphicCustomMaterials), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoneFollowerGraphic), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoneFollowerGraphic), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "NewSkeletonGraphicGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonDataAsset), typeof(Transform), typeof(Material)}, ReturnType = typeof(SkeletonGraphic))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[Calls(Type = typeof(SkeletonData), Member = "FindAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Animation))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Slot))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(SmartMesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(Skeleton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationStateData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void Initialize(bool overwrite) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBuffered`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(SmartMesh), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected void InitMeshBuffers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonGraphic), Member = "UpdateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LateUpdate() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "SetRectTransformBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected bool MatchRectTransformMultipleRenderers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetCurrent", ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "SetRectTransformBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected bool MatchRectTransformSingleRenderer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonGraphic), Member = "UpdateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "MatchRectTransformMultipleRenderers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetCurrent", ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "SetRectTransformBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool MatchRectTransformWithBounds() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static SkeletonGraphic NewSkeletonGraphicGameObject(SkeletonDataAsset skeletonDataAsset, Transform parent, Material material) { }

	[CallerCount(Count = 0)]
	public void OnBecameInvisible() { }

	[CallerCount(Count = 0)]
	public void OnBecameVisible() { }

	[CallerCount(Count = 0)]
	protected void OnCullStateChanged(bool culled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonGraphic), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "OnDestroy", ReturnType = typeof(void))]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skeleton), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Slot))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "UpdateSeparatorPartParents", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ReapplySeparatorSlotNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "UpdateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Rebuild(CanvasUpdate update) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_BeforeApply(UpdateBonesDelegate value) { }

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

	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxFollowerGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonUtility), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_OnRebuild(SkeletonRendererDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void remove_UpdateComplete(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void remove_UpdateLocal(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void remove_UpdateWorld(UpdateBonesDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void set_OverrideTexture(Texture value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Skeleton(Skeleton value) { }

	[CallerCount(Count = 0)]
	public void set_UpdateMode(UpdateMode value) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "MatchRectTransformSingleRenderer", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "MatchRectTransformMultipleRenderers", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void SetRectTransformBounds(Bounds combinedBounds) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "TrimRenderers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(MaskableGraphic), Member = "set_maskable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	protected void SyncSubmeshGraphicsWithCanvasRenderers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "SyncSubmeshGraphicsWithCanvasRenderers", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void TrimRenderers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Update() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "ApplyEventTimelinesOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "UpdateWorldTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public override void Update(float deltaTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationState), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateAnimationStatus(float deltaTime) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SkeletonExtensions), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void UpdateMesh(bool keepRendererCount = false) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshGenerator), Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubmeshInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillLateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_materialCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BlendModeMaterials), Member = "BlendModeForMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(BlendMode))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "get_Buffers", ReturnType = typeof(MeshGeneratorBuffers))]
	[Calls(Type = typeof(MeshGenerator), Member = "ScaleVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "Begin", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_cullTransparentMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateSkeletonRendererInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(Skeleton), typeof(System.Collections.Generic.Dictionary`2<Spine.Slot, UnityEngine.Material>), typeof(System.Collections.Generic.List`1<Spine.Slot>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "EnsureCanvasRendererCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpineMesh), Member = "NewSkeletonMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "EnsureSeparatorPartCount", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cullTransparentMesh", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonGraphic), Member = "DisableUnusedCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected void UpdateMeshMultipleCanvasRenderers(SkeletonRendererInstruction currentInstructions, bool keepRendererCount) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillLateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "get_Buffers", ReturnType = typeof(MeshGeneratorBuffers))]
	[Calls(Type = typeof(MeshGenerator), Member = "ScaleVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(MeshGenerator), Member = "BuildMeshWithArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubmeshInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "Begin", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "GeometryNotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(SkeletonRendererInstruction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateSingleSubmeshInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(Skeleton), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(SkeletonGraphic), Member = "DisableUnusedCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected void UpdateMeshSingleCanvasRenderer() { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "ReapplySeparatorSlotNames", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected void UpdateSeparatorPartParents() { }

}

