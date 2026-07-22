namespace UnityEngine.Rendering.Universal;

[AddComponentMenu("Rendering/URP Decal Projector")]
[ExecuteAlways]
public class DecalProjector : MonoBehaviour
{
	public sealed class DecalProjectorAction : MulticastDelegate
	{

		[CallerCount(Count = 412)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public DecalProjectorAction(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(DecalProjector decalProjector, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(DecalProjector decalProjector) { }

	}

	[CompilerGenerated]
	private static DecalProjectorAction onDecalAdd; //Field offset: 0x0
	[CompilerGenerated]
	private static DecalProjectorAction onDecalRemove; //Field offset: 0x8
	[CompilerGenerated]
	private static DecalProjectorAction onDecalPropertyChange; //Field offset: 0x10
	[CompilerGenerated]
	private static Action onAllDecalPropertyChange; //Field offset: 0x18
	[CompilerGenerated]
	private static DecalProjectorAction onDecalMaterialChange; //Field offset: 0x20
	[CompilerGenerated]
	private static Material <defaultMaterial>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DecalEntity <decalEntity>k__BackingField; //Field offset: 0x20
	[SerializeField]
	private Material m_Material; //Field offset: 0x28
	[SerializeField]
	private float m_DrawDistance; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	private float m_FadeScale; //Field offset: 0x34
	[Range(0, 180)]
	[SerializeField]
	private float m_StartAngleFade; //Field offset: 0x38
	[Range(0, 180)]
	[SerializeField]
	private float m_EndAngleFade; //Field offset: 0x3C
	[SerializeField]
	private Vector2 m_UVScale; //Field offset: 0x40
	[SerializeField]
	private Vector2 m_UVBias; //Field offset: 0x48
	[SerializeField]
	private uint m_DecalLayerMask; //Field offset: 0x50
	[SerializeField]
	private DecalScaleMode m_ScaleMode; //Field offset: 0x54
	[SerializeField]
	internal Vector3 m_Offset; //Field offset: 0x58
	[SerializeField]
	internal Vector3 m_Size; //Field offset: 0x64
	[Range(0, 1)]
	[SerializeField]
	private float m_FadeFactor; //Field offset: 0x70
	private Material m_OldMaterial; //Field offset: 0x78
	private float m_OldDrawDistance; //Field offset: 0x80
	private float m_OldFadeScale; //Field offset: 0x84
	private float m_OldStartAngleFade; //Field offset: 0x88
	private float m_OldEndAngleFade; //Field offset: 0x8C
	private Vector2 m_OldUVScale; //Field offset: 0x90
	private Vector2 m_OldUVBias; //Field offset: 0x98
	private DecalScaleMode m_OldScaleMode; //Field offset: 0xA0
	private Vector3 m_OldOffset; //Field offset: 0xA4
	private Vector3 m_OldSize; //Field offset: 0xB0
	private float m_OldFadeFactor; //Field offset: 0xBC

	internal static event Action onAllDecalPropertyChange
	{
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 184
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 184
	}

	internal static event DecalProjectorAction onDecalAdd
	{
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 180
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 180
	}

	internal static event DecalProjectorAction onDecalMaterialChange
	{
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 184
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 184
	}

	internal static event DecalProjectorAction onDecalPropertyChange
	{
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 184
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 184
	}

	internal static event DecalProjectorAction onDecalRemove
	{
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 184
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 184
	}

	internal DecalEntity decalEntity
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 5
	}

	internal Vector3 decalOffset
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 32
	}

	internal Vector3 decalSize
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 21
	}

	internal static Material defaultMaterial
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 55
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal set { } //Length: 86
	}

	public float drawDistance
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 21
	}

	internal Vector3 effectiveScale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 143
	}

	public float endAngleFade
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 38
	}

	public float fadeFactor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 51
	}

	public float fadeScale
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 51
	}

	internal static bool isSupported
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 58
	}

	public Material material
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 37
	}

	public Vector3 pivot
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 22
	}

	public uint renderingLayerMask
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DecalScaleMode scaleMode
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 10
	}

	public Vector3 size
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 22
	}

	public float startAngleFade
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 36
	}

	public Vector2 uvBias
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 11
	}

	public Vector2 uvScale
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
		 set { } //Length: 11
	}

	internal Vector4 uvScaleBias
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 27
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DecalProjector() { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onAllDecalPropertyChange(Action value) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onDecalAdd(DecalProjectorAction value) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onDecalMaterialChange(DecalProjectorAction value) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onDecalPropertyChange(DecalProjectorAction value) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Get", ReturnType = typeof(DecalEntityManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onDecalRemove(DecalProjectorAction value) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal DecalEntity get_decalEntity() { }

	[CallerCount(Count = 0)]
	internal Vector3 get_decalOffset() { }

	[CallerCount(Count = 0)]
	internal Vector3 get_decalSize() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static Material get_defaultMaterial() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_drawDistance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	internal Vector3 get_effectiveScale() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_endAngleFade() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_fadeFactor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_fadeScale() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool get_isSupported() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public Material get_material() { }

	[CallerCount(Count = 0)]
	public Vector3 get_pivot() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public uint get_renderingLayerMask() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public DecalScaleMode get_scaleMode() { }

	[CallerCount(Count = 0)]
	public Vector3 get_size() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_startAngleFade() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector2 get_uvBias() { }

	[CallerCount(Count = 0)]
	public Vector2 get_uvScale() { }

	[CallerCount(Count = 0)]
	internal Vector4 get_uvScaleBias() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	private void InitMaterial() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "FindPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void OnDidApplyAnimationProperties() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable() { }

	[CalledBy(Type = typeof(DecalProjector), Member = "set_material", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_fadeFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_scaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalScaleMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_uvBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_endAngleFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_startAngleFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_fadeScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_drawDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProjector), Member = "set_uvScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void OnValidate() { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onAllDecalPropertyChange(Action value) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onDecalAdd(DecalProjectorAction value) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onDecalMaterialChange(DecalProjectorAction value) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onDecalPropertyChange(DecalProjectorAction value) { }

	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecalEntityManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SharedDecalEntityManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onDecalRemove(DecalProjectorAction value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_decalEntity(DecalEntity value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void set_defaultMaterial(Material value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_drawDistance(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_endAngleFade(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_fadeFactor(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_fadeScale(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_material(Material value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_pivot(Vector3 value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_renderingLayerMask(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_scaleMode(DecalScaleMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_size(Vector3 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_startAngleFade(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_uvBias(Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecalProjector), Member = "OnValidate", ReturnType = typeof(void))]
	public void set_uvScale(Vector2 value) { }

	[CalledBy(Type = typeof(UniversalRenderPipelineGlobalSettings), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static void UpdateAllDecalProperties() { }

}

