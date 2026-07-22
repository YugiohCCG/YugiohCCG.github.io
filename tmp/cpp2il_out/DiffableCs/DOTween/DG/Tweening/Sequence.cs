namespace DG.Tweening;

public sealed class Sequence : Tween
{
	internal readonly List<Tween> sequencedTweens; //Field offset: 0x120
	private readonly List<ABSSequentiable> _sequencedObjs; //Field offset: 0x128
	internal float lastTweenInsertTime; //Field offset: 0x130

	[CalledBy(Type = typeof(TweenManager), Member = "GetSequence", ReturnType = typeof(Sequence))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal Sequence() { }

	[CalledBy(Type = typeof(Sequence), Member = "DoApplyTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(int), typeof(int), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenManager), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "DoApplyTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(int), typeof(int), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	internal virtual bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static Sequence DoAppendInterval(Sequence inSequence, float interval) { }

	[CalledBy(Type = typeof(Sequence), Member = "ApplyTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(bool), typeof(UpdateMode), typeof(UpdateNotice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EaseManager), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease), typeof(EaseFunction), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Sequence), Member = "ApplyInternalCycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(float), typeof(UpdateMode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) { }

	[CalledBy(Type = typeof(Sequence), Member = "DoPrepend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Prepend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(Tween)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(TweenManager), Member = "AddActiveTweenToSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) { }

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "AppendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "PrependCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "InsertCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SequenceCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TweenCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "DoInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(float)}, ReturnType = typeof(Sequence))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static Sequence DoPrepend(Sequence inSequence, Tween t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static Sequence DoPrependInterval(Sequence inSequence, float interval) { }

	[CalledBy(Type = typeof(Sequence), Member = "Startup", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool DoStartup(Sequence s) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsAnyCallbackSet(Sequence s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	internal virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static void Setup(Sequence s) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static void StableSortSequencedObjs(List<ABSSequentiable> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "DoStartup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence)}, ReturnType = typeof(bool))]
	internal virtual bool Startup() { }

	[CallerCount(Count = 0)]
	internal virtual float UpdateDelay(float elapsed) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool Validate() { }

}

