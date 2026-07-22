namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[UsedByNativeCode]
public struct Quaternion : IEquatable<Quaternion>, IFormattable
{
	private static readonly Quaternion identityQuaternion; //Field offset: 0x0
	public const float kEpsilon = 1E-06; //Field offset: 0x0
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8
	public float w; //Field offset: 0xC

	public Vector3 eulerAngles
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 222
	}

	public static Quaternion identity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 66
	}

	[CallerCount(Count = 0)]
	private static Quaternion() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Quaternion(float x, float y, float z, float w) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Rotate", Member = "ToQuaternion", ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTween", Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<Vector3>", "DG.Tweening.Core.DOSetter`1<Vector3>", typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3[], Vector3ArrayOptions>")]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void AngleAxis_Injected(float angle, in Vector3 axis, out Quaternion ret) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float Dot(Quaternion a, Quaternion b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool Equals(Quaternion other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Quaternion Euler(float x, float y, float z) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Quaternion Euler(Vector3 euler) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public Vector3 get_eulerAngles() { }

	[CallerCount(Count = 0)]
	public static Quaternion get_identity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 34)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_FromEulerRad_Injected(in Vector3 euler, out Quaternion ret) { }

	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "get_IsCardInverted", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.CustomPlugins.PureQuaternionPlugin", Member = "GetSpeedBasedDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", typeof(float), typeof(Quaternion)}, ReturnType = typeof(float))]
	[CalledBy(Type = "DG.Tweening.Plugins.Core.SpecialPluginsUtils", Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.QuaternionOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<Quaternion>", "DG.Tweening.Core.DOSetter`1<Quaternion>", typeof(float), typeof(Vector3), typeof(Vector3), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "ConvertToStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>", typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>", typeof(Vector3), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<AttackCardMoveAnimation>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	[CalledBy(Type = "UnityEngine.UIElements.Rotate", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("QuaternionScripting::ToAxisAngle", IsThreadSafe = True)]
	private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_ToAxisAngleRad_Injected(in Quaternion q, out Vector3 axis, out float angle) { }

	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "ConvertToStartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>", typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.CustomPlugins.PureQuaternionPlugin", Member = "GetSpeedBasedDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", typeof(float), typeof(Quaternion)}, ReturnType = typeof(float))]
	[CalledBy(Type = "DG.Tweening.Plugins.Core.SpecialPluginsUtils", Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.QuaternionOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<Quaternion>", "DG.Tweening.Core.DOSetter`1<Quaternion>", typeof(float), typeof(Vector3), typeof(Vector3), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.FollowLocationRigidbody2D", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>", typeof(Vector3), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<AttackCardMoveAnimation>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "get_IsCardInverted", ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = True)]
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_ToEulerRad_Injected(in Quaternion rotation, out Vector3 ret) { }

	[CalledBy(Type = typeof(Transform), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Space)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = "UnityEngine.UI.Selectable")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass74_0", Member = "<DOBlendableRotateBy>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass75_0", Member = "<DOBlendableLocalRotateBy>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass76_0", Member = "<DOBlendablePunchRotation>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "SetFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.QuaternionOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<Quaternion>", "DG.Tweening.Core.DOSetter`1<Quaternion>", typeof(float), typeof(Vector3), typeof(Vector3), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static Quaternion Inverse(Quaternion rotation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Inverse_Injected(in Quaternion rotation, out Quaternion ret) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsEqualUsingDot(float dot) { }

	[CalledBy(Type = "Game.DuelManager+<AttackCardMoveAnimation>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "CreateInstancedProbes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+Cell"}, ReturnType = "UnityEngine.Rendering.ProbeReferenceVolume+CellInstancedDebugProbes")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromDocs]
	public static Quaternion LookRotation(Vector3 forward) { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.TweenSettingsExtensions", Member = "SetPathForwardDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>", "System.Nullable`1<Vector3>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", "DG.Tweening.Plugins.Core.PathCore.Path", typeof(float), typeof(Vector3), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.QuaternionPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.QuaternionOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<Quaternion>", "DG.Tweening.Core.DOSetter`1<Quaternion>", typeof(float), typeof(Vector3), typeof(Vector3), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.Core.SpecialPluginsUtils", Member = "SetLookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Quaternion, Vector3, QuaternionOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void LookRotation_Injected(in Vector3 forward, in Vector3 upwards, out Quaternion ret) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.InputSystem.Utilities.NumberHelpers", Member = "RemapUIntBitsToNormalizeFloatToUIntBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenUtils", Member = "RotateAroundPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.Plugins.Core.SpecialPluginsUtils", Member = "SetCameraShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Vector3, Vector3[], Vector3ArrayOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.DOTween", Member = "Shake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.DOGetter`1<Vector3>", "DG.Tweening.Core.DOSetter`1<Vector3>", typeof(float), typeof(Vector3), typeof(int), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector3, Vector3[], Vector3ArrayOptions>")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnDown", ReturnType = "UnityEngine.UI.Selectable")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnUp", ReturnType = "UnityEngine.UI.Selectable")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnRight", ReturnType = "UnityEngine.UI.Selectable")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnLeft", ReturnType = "UnityEngine.UI.Selectable")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = "UnityEngine.UI.Selectable")]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_TextUtilities", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector2), typeof(Camera), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Processors.CompensateDirectionProcessor", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.InputSystem.InputControl"}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 26)]
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	[CallerCount(Count = 0)]
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	[CalledBy(Type = "DG.Tweening.CustomPlugins.PureQuaternionPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<Quaternion>", "DG.Tweening.Core.DOSetter`1<Quaternion>", typeof(float), typeof(Quaternion), typeof(Quaternion), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = True)]
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Slerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void ToAngleAxis(out float angle, out Vector3 axis) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

