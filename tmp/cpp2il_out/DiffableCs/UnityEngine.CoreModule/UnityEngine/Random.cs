namespace UnityEngine;

[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random
{
	internal struct State
	{
		[SerializeField]
		private int s0; //Field offset: 0x0
		[SerializeField]
		private int s1; //Field offset: 0x4
		[SerializeField]
		private int s2; //Field offset: 0x8
		[SerializeField]
		private int s3; //Field offset: 0xC

	}


	[StaticAccessor("GetScriptingRand()", StaticAccessorType::Dot (0))]
	public static State state
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 51
	}

	public static float value
	{
		[CalledBy(Type = "RandomParticleRotation", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Deck+<>c", Member = "<Shuffle>b__101_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "Card.Deck+<>c", Member = "<Shuffle>b__101_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "Card.Deck+<>c", Member = "<Shuffle>b__101_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction]
		 get { } //Length: 42
	}

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static State get_state() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_state_Injected(out State ret) { }

	[CalledBy(Type = "RandomParticleRotation", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Deck+<>c", Member = "<Shuffle>b__101_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "Card.Deck+<>c", Member = "<Shuffle>b__101_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "Card.Deck+<>c", Member = "<Shuffle>b__101_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction]
	public static float get_value() { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("SetSeed")]
	[StaticAccessor("GetScriptingRand()", StaticAccessorType::Dot (0))]
	public static void InitState(int seed) { }

	[CallerCount(Count = 42)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction]
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[CalledBy(Type = "Game.DuelManager+<OnSelectChain>d__166", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "<ProcessLensFlareSRPElementsSingle>g__RandomRange|74_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "DG.Tweening.DOTween", Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<Vector3>", "DG.Tweening.Core.DOSetter`1<Vector3>", typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3[], Vector3ArrayOptions>")]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction]
	public static float Range(float minInclusive, float maxInclusive) { }

	[CallerCount(Count = 42)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int Range(int minInclusive, int maxExclusive) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void set_state(State value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_state_Injected(in State value) { }

}

