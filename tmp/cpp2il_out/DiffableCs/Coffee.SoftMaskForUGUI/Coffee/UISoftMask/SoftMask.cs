namespace Coffee.UISoftMask;

public class SoftMask : Mask, IMeshModifier
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<SoftMask> <>9__81_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <SetParent>b__81_0(SoftMask x) { }

	}

	internal enum DownSamplingRate
	{
		None = 0,
		x1 = 1,
		x2 = 2,
		x4 = 4,
		x8 = 8,
	}

	private static readonly List<SoftMask>[] s_TmpSoftMasks; //Field offset: 0x0
	private static readonly Color[] s_ClearColors; //Field offset: 0x8
	private static bool s_UVStartsAtTop; //Field offset: 0x10
	private static bool s_IsMetal; //Field offset: 0x11
	private static Shader s_SoftMaskShader; //Field offset: 0x18
	private static Texture2D s_ReadTexture; //Field offset: 0x20
	private static readonly List<SoftMask> s_ActiveSoftMasks; //Field offset: 0x28
	private static readonly List<SoftMask> s_TempRelatables; //Field offset: 0x30
	private static readonly Dictionary<Int32, Matrix4x4> s_PreviousViewProjectionMatrices; //Field offset: 0x38
	private static readonly Dictionary<Int32, Matrix4x4> s_NowViewProjectionMatrices; //Field offset: 0x40
	private static int s_StencilCompId; //Field offset: 0x48
	private static int s_ColorMaskId; //Field offset: 0x4C
	private static int s_MainTexId; //Field offset: 0x50
	private static int s_SoftnessId; //Field offset: 0x54
	private static int s_Alpha; //Field offset: 0x58
	private static int s_PreviousWidth; //Field offset: 0x5C
	private static int s_PreviousHeight; //Field offset: 0x60
	private MaterialPropertyBlock _mpb; //Field offset: 0x48
	private CommandBuffer _cb; //Field offset: 0x50
	private Material _material; //Field offset: 0x58
	private RenderTexture _softMaskBuffer; //Field offset: 0x60
	private int _stencilDepth; //Field offset: 0x68
	private Mesh _mesh; //Field offset: 0x70
	private SoftMask _parent; //Field offset: 0x78
	internal readonly List<SoftMask> _children; //Field offset: 0x80
	private bool _hasChanged; //Field offset: 0x88
	private bool _hasStencilStateChanged; //Field offset: 0x89
	[FormerlySerializedAs("m_DesamplingRate")]
	[SerializeField]
	[Tooltip("The down sampling rate for soft mask buffer.")]
	private DownSamplingRate m_DownSamplingRate; //Field offset: 0x8C
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("The value used by the soft mask to select the area of influence defined over the soft mask's graphic.")]
	private float m_Softness; //Field offset: 0x90
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("The transparency of the whole masked graphic.")]
	private float m_Alpha; //Field offset: 0x94
	[Header("Advanced Options")]
	[SerializeField]
	[Tooltip("Should the soft mask ignore parent soft masks?")]
	private bool m_IgnoreParent; //Field offset: 0x98
	[SerializeField]
	[Tooltip("Is the soft mask a part of parent soft mask?")]
	private bool m_PartOfParent; //Field offset: 0x99
	[SerializeField]
	[Tooltip("Self graphic will not be drawn to soft mask buffer.")]
	private bool m_IgnoreSelfGraphic; //Field offset: 0x9A
	[SerializeField]
	[Tooltip("Self graphic will not be written to stencil buffer.")]
	private bool m_IgnoreSelfStencil; //Field offset: 0x9B

	public float alpha
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 101
	}

	public DownSamplingRate downSamplingRate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		 set { } //Length: 25
	}

	public private bool hasChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 129
		[CalledBy(Type = typeof(SoftMask), Member = "set_softness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTextures", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "UnityEngine.UI.IMeshModifier.ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(SoftMask), Member = "UnityEngine.UI.IMeshModifier.ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreSelfGraphic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "get_softMaskBuffer", ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = typeof(SoftMask), Member = "set_partOfParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreSelfStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private set { } //Length: 137
	}

	public bool ignoreParent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 64
	}

	public bool ignoreSelfGraphic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetVerticesDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
		 set { } //Length: 64
	}

	public bool ignoreSelfStencil
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetVerticesDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetMaterialDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
		 set { } //Length: 84
	}

	private Material material
	{
		[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 449
	}

	private Mesh mesh
	{
		[CalledBy(Type = typeof(SoftMask), Member = "UnityEngine.UI.IMeshModifier.ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 188
	}

	public SoftMask parent
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool partOfParent
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 64
	}

	public RenderTexture softMaskBuffer
	{
		[CalledBy(Type = typeof(SoftMask), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(Graphic), typeof(Int32[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "GetPixelValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SoftMask), Member = "GetDownSamplingSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownSamplingRate), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SoftMask), Member = "ReleaseRt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless)}, ReturnType = typeof(RenderTexture))]
		[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 506
	}

	public float softness
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 101
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 24)]
	private static SoftMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mask), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SoftMask() { }

	[CallerCount(Count = 0)]
	public float get_alpha() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DownSamplingRate get_downSamplingRate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_hasChanged() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_ignoreParent() { }

	[CallerCount(Count = 0)]
	public bool get_ignoreSelfGraphic() { }

	[CallerCount(Count = 0)]
	public bool get_ignoreSelfStencil() { }

	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Material get_material() { }

	[CalledBy(Type = typeof(SoftMask), Member = "UnityEngine.UI.IMeshModifier.ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Mesh get_mesh() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public SoftMask get_parent() { }

	[CallerCount(Count = 0)]
	public bool get_partOfParent() { }

	[CalledBy(Type = typeof(SoftMask), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(Graphic), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "GetPixelValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "GetDownSamplingSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownSamplingRate), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "ReleaseRt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(RenderTextureMemoryless)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public RenderTexture get_softMaskBuffer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_softness() { }

	[CalledBy(Type = typeof(SoftMask), Member = "get_softMaskBuffer", ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "get_fullScreenMode", ReturnType = typeof(FullScreenMode))]
	[Calls(Type = typeof(Screen), Member = "get_currentResolution", ReturnType = typeof(Resolution))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void GetDownSamplingSize(DownSamplingRate rate, out int w, out int h) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mask), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	[CalledBy(Type = typeof(SoftMask), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(Graphic), typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "get_softMaskBuffer", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "GetRawTextureData", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private float GetPixelValue(int x, int y, Int32[] interactions) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "get_softMaskBuffer", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(SoftMask), Member = "GetPixelValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[])}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera, Graphic g, Int32[] interactions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "remove_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mask), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnector), Member = "FindConnector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(GraphicConnector))]
	[Calls(Type = typeof(Mask), Member = "OnEnable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	protected virtual void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(SoftMask), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnTransformParentChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	private static void ReleaseObject(object obj) { }

	[CalledBy(Type = typeof(SoftMask), Member = "get_softMaskBuffer", ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void ReleaseRt(ref RenderTexture tmpRT) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_alpha(float value) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public void set_downSamplingRate(DownSamplingRate value) { }

	[CalledBy(Type = typeof(SoftMask), Member = "set_softness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreSelfStencil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_partOfParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "get_softMaskBuffer", ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_ignoreSelfGraphic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(SoftMask), Member = "UnityEngine.UI.IMeshModifier.ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTextures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "UnityEngine.UI.IMeshModifier.ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void set_hasChanged(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_ignoreParent(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetVerticesDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	public void set_ignoreSelfGraphic(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetVerticesDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicConnectorExtension), Member = "SetMaterialDirtyEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	public void set_ignoreSelfStencil(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_partOfParent(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_softness(float value) { }

	[CalledBy(Type = typeof(SoftMask), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	private void SetParent(SoftMask newParent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UI.IMeshModifier.ModifyMesh(Mesh mesh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void UnityEngine.UI.IMeshModifier.ModifyMesh(VertexHelper verts) { }

	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskTextures", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphics), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(SoftMask), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "get_material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(SoftMask), Member = "get_softMaskBuffer", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MaskUtilities), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateMaskTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Matrix4x4>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, UnityEngine.Matrix4x4>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Matrix4x4>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, UnityEngine.Matrix4x4>))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskUtilities), Member = "NotifyStencilStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_hasChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mask), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(SoftMask), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Matrix4x4>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Canvas), Member = "get_worldCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Mask), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Matrix4x4>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private static void UpdateMaskTextures() { }

}

