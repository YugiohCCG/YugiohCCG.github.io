namespace DG.Tweening;

[Extension]
public static class DOTweenModuleAudio
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public AudioSource target; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass0_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AudioSource), Member = "get_volume", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		internal float <DOFade>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AudioSource), Member = "set_volume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <DOFade>b__1(float x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public AudioSource target; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass1_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal float <DOPitch>b__0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <DOPitch>b__1(float x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public AudioMixer target; //Field offset: 0x10
		public string floatName; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass2_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AudioMixer), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal float <DOSetFloat>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AudioMixer), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal void <DOSetFloat>b__1(float x) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOComplete(AudioMixer target, bool withCallbacks = false) { }

	[CalledBy(Type = "Manager.Sound+<>c__DisplayClass31_0", Member = "<PlayBGM>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sound), Member = "PlayBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Single>), typeof(DG.Tweening.Core.DOSetter`1<System.Single>), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static TweenerCore<Single, Single, FloatOptions> DOFade(AudioSource target, float endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Flip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOFlip(AudioMixer target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float), typeof(bool)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOGoto(AudioMixer target, float to, bool andPlay = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Kill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOKill(AudioMixer target, bool complete = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Pause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOPause(AudioMixer target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Single>), typeof(DG.Tweening.Core.DOSetter`1<System.Single>), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static TweenerCore<Single, Single, FloatOptions> DOPitch(AudioSource target, float endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOPlay(AudioMixer target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "PlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOPlayBackwards(AudioMixer target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "PlayForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOPlayForward(AudioMixer target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(float)}, ReturnType = typeof(int))]
	[Extension]
	public static int DORestart(AudioMixer target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(int))]
	[Extension]
	public static int DORewind(AudioMixer target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Single>), typeof(DG.Tweening.Core.DOSetter`1<System.Single>), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static TweenerCore<Single, Single, FloatOptions> DOSetFloat(AudioMixer target, string floatName, float endValue, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOSmoothRewind(AudioMixer target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "TogglePause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Extension]
	public static int DOTogglePause(AudioMixer target) { }

}

