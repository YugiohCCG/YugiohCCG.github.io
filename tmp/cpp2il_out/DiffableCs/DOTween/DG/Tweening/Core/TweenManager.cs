namespace DG.Tweening.Core;

internal static class TweenManager
{
	public enum CapacityIncreaseMode
	{
		TweenersAndSequences = 0,
		TweenersOnly = 1,
		SequencesOnly = 2,
	}

	private const int _DefaultMaxTweeners = 200; //Field offset: 0x0
	private const int _DefaultMaxSequences = 50; //Field offset: 0x0
	private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup"; //Field offset: 0x0
	private const float _EpsilonVsTimeCheck = 1E-06; //Field offset: 0x0
	internal static bool isUnityEditor; //Field offset: 0x0
	internal static bool isDebugBuild; //Field offset: 0x1
	internal static int maxActive; //Field offset: 0x4
	internal static int maxTweeners; //Field offset: 0x8
	internal static int maxSequences; //Field offset: 0xC
	internal static bool hasActiveTweens; //Field offset: 0x10
	internal static bool hasActiveDefaultTweens; //Field offset: 0x11
	internal static bool hasActiveLateTweens; //Field offset: 0x12
	internal static bool hasActiveFixedTweens; //Field offset: 0x13
	internal static bool hasActiveManualTweens; //Field offset: 0x14
	internal static int totActiveTweens; //Field offset: 0x18
	internal static int totActiveDefaultTweens; //Field offset: 0x1C
	internal static int totActiveLateTweens; //Field offset: 0x20
	internal static int totActiveFixedTweens; //Field offset: 0x24
	internal static int totActiveManualTweens; //Field offset: 0x28
	internal static int totActiveTweeners; //Field offset: 0x2C
	internal static int totActiveSequences; //Field offset: 0x30
	internal static int totPooledTweeners; //Field offset: 0x34
	internal static int totPooledSequences; //Field offset: 0x38
	internal static int totTweeners; //Field offset: 0x3C
	internal static int totSequences; //Field offset: 0x40
	internal static bool isUpdateLoop; //Field offset: 0x44
	internal static Tween[] _activeTweens; //Field offset: 0x48
	private static Tween[] _pooledTweeners; //Field offset: 0x50
	private static readonly Stack<Tween> _PooledSequences; //Field offset: 0x58
	private static readonly List<Tween> _KillList; //Field offset: 0x60
	private static readonly Dictionary<Tween, TweenLink> _TweenLinks; //Field offset: 0x68
	private static int _totTweenLinks; //Field offset: 0x70
	private static int _maxActiveLookupId; //Field offset: 0x74
	private static bool _requiresActiveReorganization; //Field offset: 0x78
	private static int _reorganizeFromId; //Field offset: 0x7C
	private static int _minPooledTweenerId; //Field offset: 0x80
	private static int _maxPooledTweenerId; //Field offset: 0x84
	private static bool _despawnAllCalledFromUpdateLoopCallback; //Field offset: 0x88

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static TweenManager() { }

	[CalledBy(Type = typeof(TweenManager), Member = "GetTweener", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenManager), Member = "GetSequence", ReturnType = typeof(Sequence))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TweenManager), Member = "ReorganizeActiveTweens", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void AddActiveTween(Tween t) { }

	[CalledBy(Type = typeof(Sequence), Member = "DoInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(float)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "RemoveActiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	internal static void AddActiveTweenToSequence(Tween t) { }

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLink", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(GameObject)}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLink", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(GameObject), typeof(LinkBehaviour)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static void AddTweenLink(Tween t, TweenLink tweenLink) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static void ClearTweenArray(Tween[] tweens) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Kill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Tween), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(int), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool Complete(Tween t, bool modifyActiveLists = true, UpdateMode updateMode = 1) { }

	[CalledBy(Type = typeof(DOTween), Member = "To", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>", "DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenManager), Member = "DespawnActiveTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "MarkForKilling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateType), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "Validate", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "DespawnAll", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(Sequence), Member = "ApplyInternalCycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(float), typeof(UpdateMode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Kill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "RemoveActiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	internal static void Despawn(Tween t, bool modifyActiveLists = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void DespawnActiveTweens(List<Tween> tweens) { }

	[CalledBy(Type = typeof(DOTween), Member = "KillAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DOTween), Member = "KillAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static int DespawnAll() { }

	[CalledBy(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenExtensions), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenExtensions), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void EvaluateTweenLink(Tween t) { }

	[CallerCount(Count = 59)]
	[Calls(Type = typeof(TweenManager), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "PlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "RemoveActiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, Object[] optionalArray = null) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Flip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool Flip(Tween t) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "GotoWaypoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sequence), Member = "ApplyInternalCycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(float), typeof(UpdateMode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TweenManager), Member = "RemoveActiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static void ForceInit(Tween t, bool isSequenced = false) { }

	[CalledBy(Type = typeof(DOTween), Member = "PlayingTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	[CalledBy(Type = typeof(DOTween), Member = "PausedTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenManager), Member = "ReorganizeActiveTweens", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static List<Tween> GetActiveTweens(bool playing, List<Tween> fillableList = null) { }

	[CalledBy(Type = typeof(DOTween), Member = "Sequence", ReturnType = typeof(Sequence))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "IncreaseCapacities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CapacityIncreaseMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "AddActiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	internal static Sequence GetSequence() { }

	[CalledBy(Type = typeof(DOTween), Member = "ApplyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "IncreaseCapacities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CapacityIncreaseMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenerCore`3), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "AddActiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	internal static TweenerCore<T1, T2, TPlugOptions> GetTweener() { }

	[CalledBy(Type = typeof(DOTween), Member = "TweensById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "ReorganizeActiveTweens", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static List<Tween> GetTweensById(object id, bool playingOnly, List<Tween> fillableList = null) { }

	[CalledBy(Type = typeof(DOTween), Member = "TweensByTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "ReorganizeActiveTweens", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static List<Tween> GetTweensByTarget(object target, bool playingOnly, List<Tween> fillableList = null) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "GotoWaypoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sequence), Member = "DoStartup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Sequence), Member = "ApplyInternalCycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(float), typeof(UpdateMode), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Tween), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(int), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = 1) { }

	[CalledBy(Type = typeof(TweenManager), Member = "GetTweener", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenManager), Member = "GetSequence", ReturnType = typeof(Sequence))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void IncreaseCapacities(CapacityIncreaseMode increaseMode) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void ManageOnRewindCallbackWhenAlreadyRewinded(Tween t, bool isPlayBackwardsOrSmoothRewind) { }

	[CalledBy(Type = typeof(TweenManager), Member = "Validate", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void MarkForKilling(Tween t, bool isSingleTweenManualUpdate = false) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Pause", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool Pause(Tween t) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Play", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool Play(Tween t) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "PlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool PlayBackwards(Tween t) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "PlayForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool PlayForward(Tween t) { }

	[CalledBy(Type = typeof(DOTween), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "SetCapacities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static void PurgeAll(bool isApplicationQuitting) { }

	[CalledBy(Type = typeof(DOTween), Member = "ClearCachedTweens", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static void PurgePools() { }

	[CalledBy(Type = typeof(TweenManager), Member = "AddActiveTweenToSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debugger), Member = "LogRemoveActiveTweenError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void RemoveActiveTween(Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static void RemoveTweenLink(Tween t) { }

	[CalledBy(Type = typeof(TweenManager), Member = "Validate", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateType), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "TotalPlayingTweens", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "GetActiveTweens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	[CalledBy(Type = typeof(TweenManager), Member = "GetTweensById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	[CalledBy(Type = typeof(TweenManager), Member = "GetTweensByTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>)}, ReturnType = typeof(System.Collections.Generic.List`1<DG.Tweening.Tween>))]
	[CalledBy(Type = typeof(TweenManager), Member = "AddActiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private static void ReorganizeActiveTweens() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "SetCapacities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal static void ResetCapacities() { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "EvaluateTweenLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TweenManager), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TweenManager), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(float)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Tween), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(int), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool Rewind(Tween t, bool includeDelay = true) { }

	[CalledBy(Type = typeof(DOTween), Member = "SetTweensCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTweenComponent), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(IDOTweenInit))]
	[CalledBy(Type = typeof(TweenManager), Member = "PurgeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "ResetCapacities", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity) { }

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetUpdate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetUpdate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(UpdateType)}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetUpdate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(UpdateType), typeof(bool)}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetAs", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Tween)}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetAs", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(TweenParams)}, ReturnType = "T")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "FilteredOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationType), typeof(FilterType), typeof(object), typeof(bool), typeof(float), typeof(object), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenExtensions), Member = "ElapsedDirectionalPercentage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TweenExtensions), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenExtensions), Member = "PlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool SmoothRewind(Tween t) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "TogglePause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool TogglePause(Tween t) { }

	[CalledBy(Type = typeof(DOTween), Member = "TotalPlayingTweens", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "ReorganizeActiveTweens", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int TotalPlayingTweens() { }

	[CallerCount(Count = 0)]
	internal static int TotalPooledTweens() { }

	[CalledBy(Type = typeof(DOTween), Member = "ManualUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTweenComponent), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTweenComponent), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTweenComponent), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TweenManager), Member = "ReorganizeActiveTweens", ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void Update(UpdateType updateType, float deltaTime, float independentTime) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "ManualUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateType), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenManager), Member = "EvaluateTweenLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenManager), Member = "MarkForKilling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tween), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(int), typeof(UpdateMode)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool Update(Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate) { }

	[CalledBy(Type = typeof(DOTween), Member = "Validate", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "ReorganizeActiveTweens", ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "MarkForKilling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "Despawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static int Validate() { }

}

