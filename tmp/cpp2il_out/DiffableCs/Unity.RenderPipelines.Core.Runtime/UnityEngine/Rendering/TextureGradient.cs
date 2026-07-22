namespace UnityEngine.Rendering;

public class TextureGradient : IDisposable
{
	[CompilerGenerated]
	[HideInInspector]
	[SerializeField]
	private int <textureSize>k__BackingField; //Field offset: 0x10
	[SerializeField]
	private Gradient m_Gradient; //Field offset: 0x18
	private Texture2D m_Texture; //Field offset: 0x20
	private int m_RequestedTextureSize; //Field offset: 0x28
	private bool m_IsTextureDirty; //Field offset: 0x2C
	private bool m_Precise; //Field offset: 0x2D
	[HideInInspector]
	[SerializeField]
	public GradientMode mode; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	public ColorSpace colorSpace; //Field offset: 0x34

	[HideInInspector]
	public GradientAlphaKey[] alphaKeys
	{
		[CalledBy(Type = typeof(LensFlareDataElementSRP), Member = "Clone", ReturnType = typeof(LensFlareDataElementSRP))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Gradient), Member = "get_alphaKeys", ReturnType = typeof(GradientAlphaKey[]))]
		 get { } //Length: 19
	}

	[HideInInspector]
	public GradientColorKey[] colorKeys
	{
		[CalledBy(Type = typeof(LensFlareDataElementSRP), Member = "Clone", ReturnType = typeof(LensFlareDataElementSRP))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Gradient), Member = "get_colorKeys", ReturnType = typeof(GradientColorKey[]))]
		 get { } //Length: 19
	}

	public private int textureSize
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gradient), Member = "get_colorKeys", ReturnType = typeof(GradientColorKey[]))]
	[Calls(Type = typeof(Gradient), Member = "get_alphaKeys", ReturnType = typeof(GradientAlphaKey[]))]
	[Calls(Type = typeof(TextureGradient), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[]), typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "get_mode", ReturnType = typeof(GradientMode))]
	[Calls(Type = typeof(Gradient), Member = "get_colorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(Gradient), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "set_colorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TextureGradient(Gradient baseCurve) { }

	[CalledBy(Type = typeof(LensFlareDataElementSRP), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LensFlareDataElementSRP), Member = "Clone", ReturnType = typeof(LensFlareDataElementSRP))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextureGradient), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[]), typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public TextureGradient(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode = 2, ColorSpace colorSpace = -1, int requestedTextureSize = -1, bool precise = false) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gradient), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Color))]
	[CallsUnknownMethods(Count = 1)]
	public Color Evaluate(float time) { }

	[CalledBy(Type = typeof(LensFlareDataElementSRP), Member = "Clone", ReturnType = typeof(LensFlareDataElementSRP))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Gradient), Member = "get_alphaKeys", ReturnType = typeof(GradientAlphaKey[]))]
	public GradientAlphaKey[] get_alphaKeys() { }

	[CalledBy(Type = typeof(LensFlareDataElementSRP), Member = "Clone", ReturnType = typeof(LensFlareDataElementSRP))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Gradient), Member = "get_colorKeys", ReturnType = typeof(GradientColorKey[]))]
	public GradientColorKey[] get_colorKeys() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_textureSize() { }

	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LensFlareDataElementSRP), typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture), Member = "IncrementUpdateCount", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Texture2D GetTexture() { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	private static GraphicsFormat GetTextureFormat() { }

	[CalledBy(Type = typeof(TextureGradient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureGradient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[]), typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureGradient), Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[]), typeof(GradientMode), typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Gradient), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "set_colorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void Rebuild(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode, ColorSpace colorSpace, int requestedTextureSize, bool precise) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Release() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_textureSize(int value) { }

	[CallerCount(Count = 0)]
	public void SetDirty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gradient), Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gradient), Member = "set_colorSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureGradient), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GradientColorKey[]), typeof(GradientAlphaKey[]), typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode, ColorSpace colorSpace) { }

}

