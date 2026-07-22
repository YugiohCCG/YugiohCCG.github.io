namespace DG.Tweening;

public static class DOVirtual
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public float val; //Field offset: 0x10
		public TweenCallback<Single> onVirtualUpdate; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass0_0() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal float <Float>b__0() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <Float>b__1(float x) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Float>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public int val; //Field offset: 0x10
		public TweenCallback<Int32> onVirtualUpdate; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass1_0() { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		internal int <Int>b__0() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal void <Int>b__1(int x) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Int>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Vector3 val; //Field offset: 0x10
		public TweenCallback<Vector3> onVirtualUpdate; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass2_0() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal Vector3 <Vector3>b__0() { }

		[CallerCount(Count = 0)]
		internal void <Vector3>b__1(Vector3 x) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Vector3>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Color val; //Field offset: 0x10
		public TweenCallback<Color> onVirtualUpdate; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		internal Color <Color>b__0() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <Color>b__1(Color x) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <Color>b__2() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "OnUpdate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(TweenCallback)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static Tweener Color(Color from, Color to, float duration, TweenCallback<Color> onVirtualUpdate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Sequence", ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "OnStepComplete", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(TweenCallback)}, ReturnType = "T")]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetUpdate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(UpdateType), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetAutoKill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = "T")]
	public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass29_0", Member = "<DOJumpAnchorPos>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass61_0", Member = "<DOJump>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass62_0", Member = "<DOLocalJump>b__7", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Single>), typeof(DG.Tweening.Core.DOSetter`1<System.Single>), typeof(float), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "OnUpdate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(TweenCallback)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static Tweener Float(float from, float to, float duration, TweenCallback<Single> onVirtualUpdate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NoOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<System.Int32>), typeof(DG.Tweening.Core.DOSetter`1<System.Int32>), typeof(int), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "OnUpdate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(TweenCallback)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static Tweener Int(int from, int to, float duration, TweenCallback<Int32> onVirtualUpdate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(VectorOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3), typeof(float), typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "OnUpdate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(TweenCallback)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static Tweener Vector3(Vector3 from, Vector3 to, float duration, TweenCallback<Vector3> onVirtualUpdate) { }

}

