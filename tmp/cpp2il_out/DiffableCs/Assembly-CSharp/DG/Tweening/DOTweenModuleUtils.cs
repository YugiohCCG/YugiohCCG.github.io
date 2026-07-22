namespace DG.Tweening;

public static class DOTweenModuleUtils
{
	internal static class Physics
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DOTweenModulePhysics), Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
		[Calls(Type = typeof(DOTweenModulePhysics), Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rigidbody), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(PathPlugin), Member = "Get", ReturnType = typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
		[Calls(Type = typeof(DOTween), Member = "To", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(object), typeof(PathOptions)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3, System.Object, DG.Tweening.Plugins.Options.PathOptions>), typeof(DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3>), typeof(DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3>), typeof(object), typeof(float)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, System.Object, DG.Tweening.Plugins.Options.PathOptions>))]
		[Calls(Type = typeof(TweenSettingsExtensions), Member = "SetTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = "T")]
		[Calls(Type = typeof(ShortcutExtensions), Member = "DOLocalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
		[Calls(Type = typeof(ShortcutExtensions), Member = "DOPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Path), typeof(float), typeof(PathMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 4)]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Preserve]
		public static bool HasRigidbody(Component target) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public static bool HasRigidbody2D(Component target) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Rigidbody), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans) { }

	}

	private static bool _initialized; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Action`4<DG.Tweening.Plugins.Options.PathOptions, System.Object, UnityEngine.Quaternion, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DOTweenExternalCommand), Member = "add_SetOrientationOnPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`4<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform>)}, ReturnType = typeof(void))]
	[Preserve]
	public static void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Preserve]
	private static void Preserver() { }

}

