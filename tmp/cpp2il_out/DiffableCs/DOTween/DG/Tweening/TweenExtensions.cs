namespace DG.Tweening;

[Extension]
public static class TweenExtensions
{

	[CalledBy(Type = "Scenes.Battle.FieldSlot+<>c__DisplayClass106_0", Member = "<AddCard>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "EvaluateTweenLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenManager), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void Complete(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void Complete(Tween t, bool withCallbacks) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion+<AsyncWaitForElapsedLoops>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion+<AsyncWaitForPosition>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion+<AsyncWaitForRewind>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenCYInstruction+WaitForRewind", Member = "get_keepWaiting", ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.DOTweenCYInstruction+WaitForElapsedLoops", Member = "get_keepWaiting", ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.DOTweenCYInstruction+WaitForPosition", Member = "get_keepWaiting", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static int CompletedLoops(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static float Delay(Tween t) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "GotoWithCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tween), Member = "set_fullPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenManager), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	private static void DoGoto(Tween t, float to, bool andPlay, bool withCallbacks) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(string), typeof(float)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static float Duration(Tween t, bool includeLoops = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static float Elapsed(Tween t, bool includeLoops = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static float ElapsedDelay(Tween t) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass29_0", Member = "<DOJumpAnchorPos>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static float ElapsedDirectionalPercentage(Tween t) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics+<>c__DisplayClass6_0", Member = "<DOJump>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D+<>c__DisplayClass4_0", Member = "<DOJump>b__5", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static float ElapsedPercentage(Tween t, bool includeLoops = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Flip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void Flip(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void ForceInit(Tween t) { }

	[CalledBy(Type = typeof(TweenManager), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenExtensions), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Extension]
	public static void Goto(Tween t, float to, bool andPlay = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNonPathTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void GotoWaypoint(Tween t, int waypointIndex, bool andPlay = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenExtensions), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Extension]
	public static void GotoWithCallbacks(Tween t, float to, bool andPlay = false) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static bool IsActive(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsBackwards(Tween t) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion+<AsyncWaitForCompletion>d__10", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenCYInstruction+WaitForCompletion", Member = "get_keepWaiting", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsComplete(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsInitialized(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsPlaying(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void Kill(Tween t, bool complete = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static int Loops(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void ManualUpdate(Tween t, float deltaTime, float unscaledDeltaTime) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "GetDrawPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Path), typeof(int)}, ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNonPathTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static Vector3[] PathGetDrawPoints(Tween t, int subdivisionsXSegment = 10) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNonPathTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static Vector3 PathGetPoint(Tween t, float pathPercentage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNonPathTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static float PathLength(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Pause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static T Pause(T t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static T Play(T t) { }

	[CalledBy(Type = typeof(TweenManager), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "PlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void PlayBackwards(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "PlayForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void PlayForward(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1) { }

	[CalledBy(Type = typeof(TweenManager), Member = "EvaluateTweenLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenManager), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void Rewind(Tween t, bool includeDelay = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void SmoothRewind(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "TogglePause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogNestedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debugger), Member = "LogNullTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Extension]
	public static void TogglePause(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTweenComponent), Member = "WaitForCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static YieldInstruction WaitForCompletion(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTweenComponent), Member = "WaitForElapsedLoops", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static YieldInstruction WaitForElapsedLoops(Tween t, int elapsedLoops) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTweenComponent), Member = "WaitForKill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static YieldInstruction WaitForKill(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTweenComponent), Member = "WaitForPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static YieldInstruction WaitForPosition(Tween t, float position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTweenComponent), Member = "WaitForRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static YieldInstruction WaitForRewind(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DOTweenComponent), Member = "WaitForStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(Debugger), Member = "LogInvalidTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Coroutine WaitForStart(Tween t) { }

}

