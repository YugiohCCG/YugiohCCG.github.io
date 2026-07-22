namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Renderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public class Renderer : Component
{

	internal bool allowGPUDrivenRendering
	{
		[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "AllowGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "AllowGPUDrivenRenderingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal set { } //Length: 134
	}

	public bool enabled
	{
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnPreRenderObject", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "LateUpdateMesh", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnPreRenderObject", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "add_GenerateMeshOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRenderer+InstructionDelegate"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "remove_GenerateMeshOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRenderer+InstructionDelegate"}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public LightProbeUsage lightProbeUsage
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public Bounds localBounds
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateRenderer", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("SetLocalAABB")]
		 set { } //Length: 133
	}

	public Material material
	{
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 144
	}

	public Material[] materials
	{
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 196
	}

	public MotionVectorGenerationMode motionVectorGenerationMode
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public Transform probeAnchor
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 144
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 177
	}

	public bool receiveShadows
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public ReflectionProbeUsage reflectionProbeUsage
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public ShadowCastingMode shadowCastingMode
	{
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public Material sharedMaterial
	{
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 144
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 177
	}

	public Material[] sharedMaterials
	{
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 118
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 196
	}

	internal bool smallMeshCulling
	{
		[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "AllowSmallMeshCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "AllowSmallMeshCullingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal set { } //Length: 134
	}

	internal int sortingGroupID
	{
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 118
	}

	internal int sortingGroupOrder
	{
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 118
	}

	public int sortingLayerID
	{
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "get_sortingLayerID", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSubMeshSortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddToSkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRenderer", typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = "Spine.Unity.SkeletonRenderSeparator")]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public int sortingOrder
	{
		[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "get_sortingOrder", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EdgeGlow+<Awake>d__35", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EdgeGlow", Member = "set_SortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSubMeshSortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "NewPartsRendererGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(string), typeof(int)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddToSkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRenderer", typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = "Spine.Unity.SkeletonRenderSeparator")]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Renderer() { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "LateUpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_enabled() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public LightProbeUsage get_lightProbeUsage() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static LightProbeUsage get_lightProbeUsage_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Material get_material() { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static MotionVectorGenerationMode get_motionVectorGenerationMode_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public Transform get_probeAnchor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_probeAnchor_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_receiveShadows() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_receiveShadows_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ReflectionProbeUsage get_reflectionProbeUsage_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public ShadowCastingMode get_shadowCastingMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ShadowCastingMode get_shadowCastingMode_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Material get_sharedMaterial() { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Material[] get_sharedMaterials() { }

	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal int get_sortingGroupID() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_sortingGroupID_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal int get_sortingGroupOrder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_sortingGroupOrder_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_sortingLayerID() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "get_sortingOrder", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_sortingOrder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	private Material GetMaterial() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	private Material GetSharedMaterial() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeName("GetMaterialArray")]
	private Material[] GetSharedMaterialArray() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Material[] GetSharedMaterialArray_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "SetMaterialSettingsToFixDrawOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "RendererScripting::HasPropertyBlock", HasExplicitThis = True)]
	public bool HasPropertyBlock() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasPropertyBlock_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_GetPropertyBlock_Injected(IntPtr _unity_self, IntPtr dest) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::GetPropertyBlockMaterialIndex", HasExplicitThis = True)]
	internal void Internal_GetPropertyBlockMaterialIndex(MaterialPropertyBlock dest, int materialIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_GetPropertyBlockMaterialIndex_Injected(IntPtr _unity_self, IntPtr dest, int materialIndex) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetPropertyBlock_Injected(IntPtr _unity_self, IntPtr properties) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::SetPropertyBlockMaterialIndex", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetPropertyBlockMaterialIndex_Injected(IntPtr _unity_self, IntPtr properties, int materialIndex) { }

	[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "AllowGPUDrivenRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "AllowGPUDrivenRenderingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void set_allowGPUDrivenRendering(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_allowGPUDrivenRendering_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "add_GenerateMeshOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRenderer+InstructionDelegate"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "remove_GenerateMeshOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRenderer+InstructionDelegate"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_enabled(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_lightProbeUsage(LightProbeUsage value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_lightProbeUsage_Injected(IntPtr _unity_self, LightProbeUsage value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetLocalAABB")]
	public void set_localBounds(Bounds value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_materials(Material[] value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_motionVectorGenerationMode_Injected(IntPtr _unity_self, MotionVectorGenerationMode value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_probeAnchor(Transform value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_probeAnchor_Injected(IntPtr _unity_self, IntPtr value) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_receiveShadows(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_reflectionProbeUsage_Injected(IntPtr _unity_self, ReflectionProbeUsage value) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void set_sharedMaterial(Material value) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_sharedMaterials(Material[] value) { }

	[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "AllowSmallMeshCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "AllowSmallMeshCullingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void set_smallMeshCulling(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_smallMeshCulling_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSubMeshSortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddToSkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRenderer", typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = "Spine.Unity.SkeletonRenderSeparator")]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_sortingLayerID(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	[CalledBy(Type = "Game.CardAnimationPlayer", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EdgeGlow+<Awake>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EdgeGlow", Member = "set_SortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSubMeshSortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "NewPartsRendererGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(string), typeof(int)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddToSkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRenderer", typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = "Spine.Unity.SkeletonRenderSeparator")]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderSeparator", Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_sortingOrder(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	private void SetMaterial(Material m) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void SetMaterialArray(Material[] m) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	private void SetMaterialArray(Material[] m, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetMaterialArray_Injected(IntPtr _unity_self, Material[] m, int length) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

