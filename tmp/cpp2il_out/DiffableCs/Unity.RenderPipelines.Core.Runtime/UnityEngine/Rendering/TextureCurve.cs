namespace UnityEngine.Rendering;

[DefaultMember("Item")]
public class TextureCurve : IDisposable
{
	private const int k_Precision = 128; //Field offset: 0x0
	private const float k_Step = 0.0078125; //Field offset: 0x0
	[CompilerGenerated]
	[SerializeField]
	private int <length>k__BackingField; //Field offset: 0x10
	[SerializeField]
	private bool m_Loop; //Field offset: 0x14
	[SerializeField]
	private float m_ZeroValue; //Field offset: 0x18
	[SerializeField]
	private float m_Range; //Field offset: 0x1C
	[SerializeField]
	private AnimationCurve m_Curve; //Field offset: 0x20
	private AnimationCurve m_LoopingCurve; //Field offset: 0x28
	private Texture2D m_Texture; //Field offset: 0x30
	private bool m_IsCurveDirty; //Field offset: 0x38
	private bool m_IsTextureDirty; //Field offset: 0x39

	public Keyframe Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AnimationCurve), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 59
	}

	public private int length
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(LensFlareComponentSRP), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "get_keys", ReturnType = typeof(Keyframe[]))]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ColorCurves", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int AddKey(float time, float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCurve), Member = "Release", ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(TextureCurve), Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
	[Calls(Type = typeof(AnimationCurve), Member = "get_keys", ReturnType = typeof(Keyframe[]))]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public float Evaluate(float time) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
	[CallsUnknownMethods(Count = 1)]
	public Keyframe get_Item(int index) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_length() { }

	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), typeof(System.Func`4<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, System.Single>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+PassData", typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureCurve), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Texture2D GetTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	private static GraphicsFormat GetTextureFormat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "MoveKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Keyframe)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int MoveKey(int index, in Keyframe key) { }

	[CalledBy(Type = typeof(LensFlareComponentSRP), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureCurve), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureCurveParameter), Member = "Release", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Release() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "RemoveKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveKey(int index) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_length(int value) { }

	[CallerCount(Count = 0)]
	public void SetDirty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "SmoothTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SmoothTangents(int index, float weight) { }

}

