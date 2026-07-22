namespace DG.Tweening;

[Extension]
public static class TweenSettingsExtensions
{

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOJumpAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(string), typeof(float)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Sequence), Member = "LogAddAlreadySequencedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "DoInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(float)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Sequence), Member = "LogAddInactiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddNullTween", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[Extension]
	public static Sequence Append(Sequence s, Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "DoInsertCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback), typeof(float)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[Extension]
	public static Sequence AppendCallback(Sequence s, TweenCallback callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[Extension]
	public static Sequence AppendInterval(Sequence s, float interval) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>), Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[Extension]
	public static TweenerCore<Vector2, Vector2, CircleOptions> From(TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately = true, bool isRelative = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>), Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[Extension]
	public static TweenerCore<Vector3, Vector3, VectorOptions> From(TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true, bool isRelative = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenerCore`3), Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", typeof(bool), typeof(bool)}, ReturnType = typeof(Tweener))]
	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> From(TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true, bool isRelative = false) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static TweenerCore<T1, T2, TPlugOptions> From(TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true, bool isRelative = false) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T From(T t, bool setImmediately, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T From(T t, bool isRelative) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T From(T t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "LogAddAlreadySequencedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "DoInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(float)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Sequence), Member = "LogAddInactiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddNullTween", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[Extension]
	public static Sequence Insert(Sequence s, float atPosition, Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "DoInsertCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback), typeof(float)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[Extension]
	public static Sequence InsertCallback(Sequence s, float atPosition, TweenCallback callback) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOJumpAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Sequence), Member = "LogAddAlreadySequencedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "DoInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(float)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Sequence), Member = "LogAddInactiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddNullTween", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[Extension]
	public static Sequence Join(Sequence s, Tween t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnComplete(T t, TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnKill(T t, TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnPause(T t, TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnPlay(T t, TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnRewind(T t, TweenCallback action) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOJumpAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnStart(T t, TweenCallback action) { }

	[CalledBy(Type = typeof(DOVirtual), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TweenCallback), typeof(bool)}, ReturnType = typeof(Tween))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnStepComplete(T t, TweenCallback action) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOJumpAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(DOVirtual), Member = "Float", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(DG.Tweening.TweenCallback`1<System.Single>)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(DOVirtual), Member = "Int", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float), typeof(DG.Tweening.TweenCallback`1<System.Int32>)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(DOVirtual), Member = "Vector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(DG.Tweening.TweenCallback`1<UnityEngine.Vector3>)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(DOVirtual), Member = "Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(float), typeof(DG.Tweening.TweenCallback`1<UnityEngine.Color>)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnUpdate(T t, TweenCallback action) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T OnWaypointChange(T t, TweenCallback<Int32> action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "LogAddAlreadySequencedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "DoInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(float)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Sequence), Member = "LogAddInactiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddNullTween", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Sequence Prepend(Sequence s, Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "DoInsertCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback), typeof(float)}, ReturnType = typeof(Sequence))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[Extension]
	public static Sequence PrependCallback(Sequence s, TweenCallback callback) { }

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetDelay", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(float)}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetDelay", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(float), typeof(bool)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Sequence PrependInterval(Sequence s, float interval) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "SetUpdateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(UpdateType), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T SetAs(T t, TweenParams tweenParams) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "SetUpdateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(UpdateType), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T SetAs(T t, Tween asTween) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetAutoKill(T t) { }

	[CalledBy(Type = typeof(DOVirtual), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TweenCallback), typeof(bool)}, ReturnType = typeof(Tween))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetAutoKill(T t, bool autoKillOnCompletion) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "PrependInterval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float)}, ReturnType = typeof(Sequence))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T SetDelay(T t, float delay, bool asPrependedIntervalIfSequence) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "PrependInterval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float)}, ReturnType = typeof(Sequence))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T SetDelay(T t, float delay) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetEase(T t, EaseFunction customEase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetEase(T t, AnimationCurve animCurve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "IsFlashEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T SetEase(T t, Ease ease, float amplitude, float period) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EaseManager), Member = "IsFlashEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T SetEase(T t, Ease ease, float overshoot) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "Extensions.DragClone", Member = "PlaceCloneBackAnimation", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DraggableFrame", Member = "CheckForRearrange", ReturnType = typeof(bool))]
	[CalledBy(Type = "Extensions.General", Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "Extensions.General", Member = "MoveLocalAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOJumpAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(string), typeof(float)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(EaseManager), Member = "IsFlashEase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ease)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static T SetEase(T t, Ease ease) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetId(T t, string stringId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetId(T t, object objectId) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetId(T t, int intId) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetInverted(T t, bool inverted) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetInverted(T t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenLink), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LinkBehaviour)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "AddTweenLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(TweenLink)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static T SetLink(T t, GameObject gameObject, LinkBehaviour behaviour) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TweenLink), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(LinkBehaviour)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TweenManager), Member = "AddTweenLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(TweenLink)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static T SetLink(T t, GameObject gameObject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetPathForwardDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetPathForwardDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Extension]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetPathForwardDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null, bool stableZRotation = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetPathForwardDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Extension]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetPathForwardDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Extension]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetPathForwardDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Extension]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetPathForwardDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOJumpAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetLoops(T t, int loops, LoopType loopType) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetLoops(T t, int loops) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Rect, Rect, RectOptions> t, bool snapping) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOMoveX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOMoveY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOMoveZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOAnchorPos3DX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOAnchorPos3DY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOAnchorPos3DZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CallerCount(Count = 9)]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOAnchorPos3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3, VectorOptions>")]
	[CallerCount(Count = 2)]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOShapeCircle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector2, Vector2, CircleOptions>")]
	[CallerCount(Count = 1)]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter = true, bool snapping = false) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOHorizontalNormalizedPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.ScrollRect", typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOVerticalNormalizedPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.ScrollRect", typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Slider", typeof(float), typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Single, Single, FloatOptions>")]
	[CallerCount(Count = 3)]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Single, Single, FloatOptions> t, bool snapping) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static TweenerCore<Vector3, Path, PathOptions> SetOptions(TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = 0) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text", typeof(string), typeof(float), typeof(bool), typeof(ScrambleMode), typeof(string)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<String, String, StringOptions>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(StringPluginExtensions), Member = "ScrambleChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Tweener SetOptions(TweenerCore<String, String, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = 0, string scrambleChars = null) { }

	[CallerCount(Count = 0)]
	[Extension]
	public static TweenerCore<Vector3, Path, PathOptions> SetOptions(TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = 0, AxisConstraint lockRotation = 0) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Extension]
	public static Tweener SetOptions(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping) { }

	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(Vector3), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(Vector3), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(Transform), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(Transform), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(float), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>), typeof(OrientType), typeof(Vector3), typeof(Transform), typeof(float), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(System.Nullable`1<UnityEngine.Vector3>), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[ContainsUnimplementedInstructions]
	[Extension]
	private static void SetPathForwardDirection(TweenerCore<Vector3, Path, PathOptions> t, Nullable<Vector3> forwardDirection = null, Nullable<Vector3> up = null) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetRecyclable(T t) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetRecyclable(T t, bool recyclable) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI", Member = "DOJumpAnchorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetRelative(T t) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetRelative(T t, bool isRelative) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetSpeedBased(T t) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetSpeedBased(T t, bool isSpeedBased) { }

	[CallerCount(Count = 152)]
	[Calls(Type = typeof(DOTween), Member = "get_debugStoreTargetId", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static T SetTarget(T t, object target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenManager), Member = "SetUpdateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(UpdateType), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static T SetUpdate(T t, bool isIndependentUpdate) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), "UnityEngine.Vector3[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics", Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), "UnityEngine.Vector3[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), "UnityEngine.Vector2[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModulePhysics2D", Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody2D), "UnityEngine.Vector2[]", typeof(float), typeof(PathType), typeof(PathMode), typeof(int), "System.Nullable`1<Color>"}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TweenManager), Member = "SetUpdateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(UpdateType), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static T SetUpdate(T t, UpdateType updateType) { }

	[CalledBy(Type = typeof(DOVirtual), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TweenCallback), typeof(bool)}, ReturnType = typeof(Tween))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenManager), Member = "SetUpdateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(UpdateType), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Extension]
	public static T SetUpdate(T t, UpdateType updateType, bool isIndependentUpdate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequence), Member = "LogAddAlreadySequencedTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddInactiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddNullTween", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToLockedSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToInactiveSequence", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sequence), Member = "LogAddToNullSequence", ReturnType = typeof(void))]
	private static bool ValidateAddToSequence(Sequence s, Tween t, bool ignoreTween = false) { }

}

