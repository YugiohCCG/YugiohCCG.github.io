namespace DG.Tweening.Core;

public static class Debugger
{
	public static class Sequence
	{

		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Prepend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "ValidateAddToSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
		public static void LogAddAlreadySequencedTween(Tween t) { }

		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Prepend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "ValidateAddToSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
		public static void LogAddInactiveTween(Tween t) { }

		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Prepend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "ValidateAddToSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
		public static void LogAddNullTween() { }

		[CalledBy(Type = typeof(DOVirtual), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TweenCallback), typeof(bool)}, ReturnType = typeof(Tween))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Prepend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "AppendInterval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "PrependInterval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "AppendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "PrependCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "InsertCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "ValidateAddToSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
		public static void LogAddToInactiveSequence() { }

		[CalledBy(Type = typeof(DOVirtual), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TweenCallback), typeof(bool)}, ReturnType = typeof(Tween))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Prepend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "AppendInterval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "PrependInterval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "AppendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "PrependCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "InsertCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "ValidateAddToSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
		public static void LogAddToLockedSequence() { }

		[CalledBy(Type = typeof(DOVirtual), Member = "DelayedCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TweenCallback), typeof(bool)}, ReturnType = typeof(Tween))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOLocalJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Prepend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(Tween)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "AppendInterval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "PrependInterval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "AppendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "PrependCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "InsertCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(float), typeof(TweenCallback)}, ReturnType = typeof(Sequence))]
		[CalledBy(Type = typeof(TweenSettingsExtensions), Member = "ValidateAddToSequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sequence), typeof(Tween), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
		public static void LogAddToNullSequence() { }

	}

	private static int _logPriority; //Field offset: 0x0
	private const string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>"; //Field offset: 0x0

	public static int logPriority
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 53
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static void AddDebugDataToMessage(ref string message, Tween t) { }

	[CallerCount(Count = 0)]
	public static int get_logPriority() { }

	[CalledBy(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Debugger), Member = "LogSafeModeCapturedError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static string GetDebugDataMessage(Tween t) { }

	[CalledBy(Type = typeof(DOTween), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DOTweenSettings), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<System.Boolean>), typeof(System.Nullable`1<DG.Tweening.LogBehaviour>)}, ReturnType = typeof(IDOTweenInit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Log(object message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	public static void LogAddActiveTweenError(string errorInfo, Tween t) { }

	[CalledBy(Type = typeof(DOTween), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(Vector3[]), typeof(Single[])}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>))]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", "T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float)}, ReturnType = typeof(Tweener))]
	[CalledBy(Type = typeof(PluginsManager), Member = "GetDefaultPlugin", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, ReturnType = "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(Tweener), Member = "Setup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ChangeEndValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "GetDebugDataMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void LogError(object message, Tween t = null) { }

	[CallerCount(Count = 52)]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	public static void LogInvalidTween(Tween t) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector2, Vector2, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOTiling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector2, Vector2, VectorOptions>")]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector4), typeof(int), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(int), typeof(float)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	public static void LogMissingMaterialProperty(int propertyId) { }

	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector2), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOTiling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector2), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector4), typeof(string), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>))]
	[CalledBy(Type = typeof(ShortcutExtensions), Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = typeof(Tweener))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	public static void LogMissingMaterialProperty(string propertyName) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathGetDrawPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int)}, ReturnType = typeof(Vector3[]))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathGetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "GotoWaypoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "TogglePause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PlayForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Play", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Pause", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenExtensions), Member = "ManualUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Kill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Flip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	public static void LogNestedTween(Tween t) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "GotoWaypoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathGetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathGetDrawPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int)}, ReturnType = typeof(Vector3[]))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	public static void LogNonPathTween(Tween t) { }

	[CalledBy(Type = typeof(TweenExtensions), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathGetDrawPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int)}, ReturnType = typeof(Vector3[]))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PathGetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "GotoWaypoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "TogglePause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "SmoothRewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Rewind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Restart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PlayForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Play", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Pause", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(TweenExtensions), Member = "ManualUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Kill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "DoGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "ForceInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Flip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TweenExtensions), Member = "PlayBackwards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	public static void LogNullTween(Tween t) { }

	[CalledBy(Type = typeof(TweenManager), Member = "RemoveActiveTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	public static void LogRemoveActiveTweenError(string errorInfo, Tween t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void LogReport(object message) { }

	[CalledBy(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tween), Member = "OnTweenCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.TweenCallback`1<T>", typeof(Tween), "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tweener), Member = "DoStartup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ApplyTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(bool), typeof(UpdateMode), typeof(UpdateNotice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "GetDebugDataMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void LogSafeModeCapturedError(object message, Tween t = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void LogSafeModeReport(object message) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debugger), Member = "GetDebugDataMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tween)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void LogWarning(object message, Tween t = null) { }

	[CalledBy(Type = typeof(DOTween), Member = "set_logBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogBehaviour)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DOTween), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public static void SetLogPriority(LogBehaviour logBehaviour) { }

	[CalledBy(Type = typeof(Tween), Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TweenCallback), typeof(Tween)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tween), Member = "OnTweenCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.TweenCallback`1<T>", typeof(Tween), "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tweener), Member = "DoStartup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Tweener), Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = typeof(TweenerCore`3), Member = "ApplyTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(bool), typeof(UpdateMode), typeof(UpdateNotice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool ShouldLogSafeModeCapturedError() { }

}

