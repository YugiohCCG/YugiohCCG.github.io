namespace DG.Tweening;

[Extension]
public static class DOTweenModuleSprite
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public SpriteRenderer target; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass0_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SpriteRenderer), Member = "get_color", ReturnType = typeof(Color))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Color <DOColor>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SpriteRenderer), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <DOColor>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public SpriteRenderer target; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass1_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SpriteRenderer), Member = "get_color", ReturnType = typeof(Color))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Color <DOFade>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SpriteRenderer), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <DOFade>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Color to; //Field offset: 0x10
		public SpriteRenderer target; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		internal Color <DOBlendableColor>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SpriteRenderer), Member = "get_color", ReturnType = typeof(Color))]
		[Calls(Type = typeof(SpriteRenderer), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <DOBlendableColor>b__1(Color x) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteRenderer), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Color>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Color>), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[Calls(Type = typeof(Extensions), Member = "Blendable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Tweener DOBlendableColor(SpriteRenderer target, Color endValue, float duration) { }

	[CalledBy(Type = typeof(DOTweenModuleSprite), Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Color>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Color>), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(SpriteRenderer target, Color endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ToAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Color>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Color>), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(SpriteRenderer target, float endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Sequence", ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Gradient), Member = "get_colorKeys", ReturnType = typeof(GradientColorKey[]))]
	[Calls(Type = typeof(SpriteRenderer), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenExtensions), Member = "Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(DOTweenModuleSprite), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetEase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Ease)}, ReturnType = "T")]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Sequence DOGradientColor(SpriteRenderer target, Gradient gradient, float duration) { }

}

