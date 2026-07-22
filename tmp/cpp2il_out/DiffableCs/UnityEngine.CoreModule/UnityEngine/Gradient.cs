namespace UnityEngine;

[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
public class Gradient : IEquatable<Gradient>
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(Gradient graident) { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	private bool m_RequiresNativeCleanup; //Field offset: 0x18

	public GradientAlphaKey[] alphaKeys
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "get_alphaKeys", ReturnType = "UnityEngine.GradientAlphaKey[]")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 get { } //Length: 227
		[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 set { } //Length: 248
	}

	public GradientColorKey[] colorKeys
	{
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "get_colorKeys", ReturnType = "UnityEngine.GradientColorKey[]")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 get { } //Length: 227
		[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 set { } //Length: 248
	}

	[NativeProperty(IsThreadSafe = True)]
	public ColorSpace colorSpace
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 88
	}

	[NativeProperty(IsThreadSafe = True)]
	public GradientMode mode
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
		[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 88
	}

	[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	public Gradient() { }

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal Gradient(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	private void Cleanup() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Cleanup_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override bool Equals(Gradient other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Color))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = True, HasExplicitThis = True)]
	public Color Evaluate(float time) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Evaluate_Injected(IntPtr _unity_self, float time, out Color ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "get_alphaKeys", ReturnType = "UnityEngine.GradientAlphaKey[]")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public GradientAlphaKey[] get_alphaKeys() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_alphaKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "get_colorKeys", ReturnType = "UnityEngine.GradientColorKey[]")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public GradientColorKey[] get_colorKeys() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_colorKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public ColorSpace get_colorSpace() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ColorSpace get_colorSpace_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public GradientMode get_mode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static GradientMode get_mode_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	private static IntPtr Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	private bool Internal_Equals(IntPtr other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public void set_alphaKeys(GradientAlphaKey[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_alphaKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public void set_colorKeys(GradientColorKey[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_colorKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_colorSpace(ColorSpace value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_colorSpace_Injected(IntPtr _unity_self, ColorSpace value) { }

	[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ChangeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gradient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_mode(GradientMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_mode_Injected(IntPtr _unity_self, GradientMode value) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "SetKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GradientColorKey[]", "UnityEngine.GradientAlphaKey[]", typeof(GradientMode), typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "Gradient_Bindings::SetKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colorKeys, ref ManagedSpanWrapper alphaKeys) { }

}

