namespace DG.Tweening;

[Extension]
public static class DOTweenModuleUnityVersion
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Material target; //Field offset: 0x10
		public int propertyID; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass8_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "GetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
		[CallsUnknownMethods(Count = 1)]
		internal Vector2 <DOOffset>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "SetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <DOOffset>b__1(Vector2 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Material target; //Field offset: 0x10
		public int propertyID; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass9_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "GetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
		[CallsUnknownMethods(Count = 1)]
		internal Vector2 <DOTiling>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "SetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <DOTiling>b__1(Vector2 x) { }

	}

	[CompilerGenerated]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Tween t; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "IsComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Tween t; //Field offset: 0x20
		public int elapsedLoops; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x2C

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Tween t; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Tween t; //Field offset: 0x20
		public float position; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x2C

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Tween t; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenExtensions), Member = "CompletedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Tween t; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForCompletion>d__10)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForCompletion>d__10&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Task AsyncWaitForCompletion(Tween t) { }

	[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForElapsedLoops>d__13)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForElapsedLoops>d__13&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Task AsyncWaitForElapsedLoops(Tween t, int elapsedLoops) { }

	[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForKill>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForKill>d__12&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Task AsyncWaitForKill(Tween t) { }

	[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForPosition>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForPosition>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Task AsyncWaitForPosition(Tween t, float position) { }

	[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForRewind>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForRewind>d__11&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Task AsyncWaitForRewind(Tween t) { }

	[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForStart>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AsyncWaitForStart>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Task AsyncWaitForStart(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Sequence", ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Gradient), Member = "get_colorKeys", ReturnType = typeof(GradientColorKey[]))]
	[Calls(Type = typeof(Material), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenExtensions), Member = "Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetEase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Ease)}, ReturnType = "T")]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Sequence DOGradientColor(Material target, Gradient gradient, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTween), Member = "Sequence", ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Gradient), Member = "get_colorKeys", ReturnType = typeof(GradientColorKey[]))]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenExtensions), Member = "Duration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetEase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Ease)}, ReturnType = "T")]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Sequence DOGradientColor(Material target, Gradient gradient, string property, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector2>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector2>), typeof(Vector2), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(Debugger), Member = "LogMissingMaterialProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(Material target, Vector2 endValue, int propertyID, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DOTween), Member = "To", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector2>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector2>), typeof(Vector2), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>))]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(Debugger), Member = "LogMissingMaterialProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(Material target, Vector2 endValue, int propertyID, float duration) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static CustomYieldInstruction WaitForCompletion(Tween t, bool returnCustomYieldInstruction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static CustomYieldInstruction WaitForElapsedLoops(Tween t, int elapsedLoops, bool returnCustomYieldInstruction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static CustomYieldInstruction WaitForKill(Tween t, bool returnCustomYieldInstruction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static CustomYieldInstruction WaitForPosition(Tween t, float position, bool returnCustomYieldInstruction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static CustomYieldInstruction WaitForRewind(Tween t, bool returnCustomYieldInstruction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static CustomYieldInstruction WaitForStart(Tween t, bool returnCustomYieldInstruction) { }

}

