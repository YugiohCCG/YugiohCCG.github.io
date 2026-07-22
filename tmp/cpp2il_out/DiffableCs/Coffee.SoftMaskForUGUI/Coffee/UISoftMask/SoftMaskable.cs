namespace Coffee.UISoftMask;

[ExecuteAlways]
[RequireComponent(typeof(Graphic))]
public class SoftMaskable : MonoBehaviour, IMaterialModifier, ICanvasRaycastFilter
{
	private const int kVisibleInside = 85; //Field offset: 0x0
	private const int kVisibleOutside = 170; //Field offset: 0x0
	private static readonly Hash128 k_InvalidHash; //Field offset: 0x0
	private static int s_SoftMaskTexId; //Field offset: 0x10
	private static int s_StencilCompId; //Field offset: 0x14
	private static int s_MaskInteractionId; //Field offset: 0x18
	private static int s_GameVPId; //Field offset: 0x1C
	private static int s_GameTVPId; //Field offset: 0x20
	private static List<SoftMaskable> s_ActiveSoftMaskables; //Field offset: 0x28
	private static Int32[] s_Interactions; //Field offset: 0x30
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private bool m_Inverse; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	[Tooltip("The interaction for each masks.")]
	private int m_MaskInteraction; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Use stencil to mask.")]
	private bool m_UseStencil; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Use soft-masked raycast target.\n\nNote: This option is expensive.")]
	private bool m_RaycastFilter; //Field offset: 0x29
	private Graphic _graphic; //Field offset: 0x30
	private SoftMask _softMask; //Field offset: 0x38
	private Hash128 _effectMaterialHash; //Field offset: 0x40
	[CompilerGenerated]
	private Material <modifiedMaterial>k__BackingField; //Field offset: 0x50

	public Graphic graphic
	{
		[CalledBy(Type = typeof(SoftMaskable), Member = "set_inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "set_useStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "SetMaskInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteMaskInteraction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "SetMaskInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteMaskInteraction), typeof(SpriteMaskInteraction), typeof(SpriteMaskInteraction), typeof(SpriteMaskInteraction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 155
	}

	public bool inverse
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetMaterialDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
		 set { } //Length: 55
	}

	public private Material modifiedMaterial
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public bool raycastFilter
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public SoftMask softMask
	{
		[CalledBy(Type = typeof(SoftMaskable), Member = "UnityEngine.UI.IMaterialModifier.GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GraphicConnectorExtension), Member = "GetComponentInParentEx", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 157
	}

	public bool useStencil
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetMaterialDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
		 set { } //Length: 38
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static SoftMaskable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SoftMaskable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = "set_shader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMaskable), Member = "get_softMask", ReturnType = typeof(SoftMask))]
	[Calls(Type = typeof(SoftMask), Member = "get_softMaskBuffer", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private void <UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0(Material mat) { }

	[CalledBy(Type = typeof(SoftMaskable), Member = "set_inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "set_useStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "SetMaskInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteMaskInteraction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "SetMaskInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteMaskInteraction), typeof(SpriteMaskInteraction), typeof(SpriteMaskInteraction), typeof(SpriteMaskInteraction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public Graphic get_graphic() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_inverse() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Material get_modifiedMaterial() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_raycastFilter() { }

	[CalledBy(Type = typeof(SoftMaskable), Member = "UnityEngine.UI.IMaterialModifier.GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicConnectorExtension), Member = "GetComponentInParentEx", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(bool)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public SoftMask get_softMask() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_useStencil() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnector), Member = "FindConnector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(GraphicConnector))]
	[Calls(Type = typeof(MaterialCache), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnector), Member = "FindConnector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(GraphicConnector))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetMaterialDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	public void set_inverse(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_modifiedMaterial(Material value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_raycastFilter(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetMaterialDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	public void set_useStencil(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnector), Member = "FindConnector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(GraphicConnector))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMaskInteraction(SpriteMaskInteraction intr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnector), Member = "FindConnector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(GraphicConnector))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMaskInteraction(SpriteMaskInteraction layer0, SpriteMaskInteraction layer1, SpriteMaskInteraction layer2, SpriteMaskInteraction layer3) { }

	[CallerCount(Count = 0)]
	private override bool UnityEngine.ICanvasRaycastFilter.IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMaskable), Member = "get_softMask", ReturnType = typeof(SoftMask))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Hash128), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash128), Member = "get_isValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.Hash128, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialCache), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private override Material UnityEngine.UI.IMaterialModifier.GetModifiedMaterial(Material baseMaterial) { }

}

