namespace UnityEngine;

[NativeHeader("Configuration/UnityConfigure.h")]
[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[NativeHeader("Runtime/Transform/Transform.h")]
[RequiredByNativeCode]
public class Transform : Component, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private Transform outer; //Field offset: 0x10
		private int currentIndex; //Field offset: 0x18

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 165
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Enumerator(Transform outer) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override void Reset() { }

	}


	public int childCount
	{
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetChildrenCount")]
		 get { } //Length: 119
	}

	public Vector3 eulerAngles
	{
		[CalledBy(Type = "Scenes.General.HandCards", Member = "RecalculateHandDisplay", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustPosition", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.CameraController", Member = "GetOffsetFromDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.CameraView"}, ReturnType = "System.ValueTuple`2<Vector3, Vector3>")]
		[CalledBy(Type = "Scenes.Battle.CameraController", Member = "GetCurrentSetup", ReturnType = "System.ValueTuple`2<Vector3, Vector3>")]
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "CalculateCamera", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "SetupCamera", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectRotator", Member = "DefineRotation", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.LinkSummon", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "ClientAPI.WebServer+FullRotation", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "ClientAPI.WebServer+FieldPositionData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Battle.DuelZone"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 275
		[CalledBy(Type = "Scenes.Battle.DuelField", Member = "ConfigureCamera", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Helper", Member = "UpdateCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectRotator", Member = "DefineRotation", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.PendulumSummon", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerFoldout", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 202
	}

	public Vector3 forward
	{
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "get_anchorPosition", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdateCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), "UnityEngine.Rendering.ProbeVolumesOptions"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "GetLensFlareLightAttenuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", "DG.Tweening.Plugins.Core.PathCore.Path", typeof(float), typeof(Vector3), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 280
	}

	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged
	{
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 119
		[CalledBy(Type = "TMPro.TextContainer", Member = "OnContainerChanged", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 135
	}

	public Vector3 localEulerAngles
	{
		[CalledBy(Type = "RandomParticleRotation", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineChainAngle", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass10_0", Member = "<DOShakeRotation>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass11_0", Member = "<DOShakeRotation>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass54_0", Member = "<DOPunchRotation>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass57_0", Member = "<DOShakeRotation>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass58_0", Member = "<DOShakeRotation>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "Spine.Unity.FollowSkeletonUtilityRootRotation", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.FollowSkeletonUtilityRootRotation", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 275
		[CalledBy(Type = "RandomParticleRotation", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "SortOrderDisplayUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "CheckZoneInverter", ReturnType = typeof(void))]
		[CalledBy(Type = "PooledScrollList.Pool`1", Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.LinkSummon", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "ResetState", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "DefineChainAngle", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 202
	}

	public Vector3 localPosition
	{
		[CallerCount(Count = 61)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 145
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public Quaternion localRotation
	{
		[CalledBy(Type = "Extensions.General", Member = "InvertRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(Component)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "InvertRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "InvertRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.XR.TrackedPoseDriver", Member = "UpdateCallback", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass42_0", Member = "<DOLocalRotate>b__0", ReturnType = typeof(Quaternion))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass43_0", Member = "<DOLocalRotateQuaternion>b__0", ReturnType = typeof(Quaternion))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass75_0", Member = "<DOBlendableLocalRotateBy>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.Core.SpecialPluginsUtils", Member = "SetCameraShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Vector3, Vector3[], Vector3ArrayOptions>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 143
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public Vector3 localScale
	{
		[CallerCount(Count = 62)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 145
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public Matrix4x4 localToWorldMatrix
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 155
	}

	public Vector3 lossyScale
	{
		[CalledBy(Type = "Scenes.Battle.CardOptionList", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EdgeGlow", Member = "CalculateSizing", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalProjector", Member = "get_effectiveScale", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "InternalUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "InternalUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCanvasSpaceClippingRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "GetWorldSpaceScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODGroup)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "GetWorldSpaceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODGroup)}, ReturnType = typeof(float))]
		[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetWorldScaleLossy")]
		 get { } //Length: 145
	}

	public Transform parent
	{
		[CallerCount(Count = 148)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 145
		[CalledBy(Type = "UnityEngine.UI.Misc", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.BoundingBoxAttachment", "Spine.Slot", typeof(Transform), typeof(bool)}, ReturnType = "UnityEngine.PolygonCollider2D")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 298
	}

	internal Transform parentInternal
	{
		[CallerCount(Count = 148)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 145
		[CallerCount(Count = 36)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal set { } //Length: 181
	}

	public Vector3 position
	{
		[CallerCount(Count = 217)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 145
		[CallerCount(Count = 49)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public Vector3 right
	{
		[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ShapeAttenuationAreaTubeLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(Camera)}, ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 280
	}

	public Quaternion rotation
	{
		[CallerCount(Count = 65)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 143
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public Vector3 up
	{
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", "DG.Tweening.Plugins.Core.PathCore.Path", typeof(float), typeof(Vector3), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 280
	}

	public Matrix4x4 worldToLocalMatrix
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "GetBounds", ReturnType = typeof(Bounds))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 155
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Transform() { }

	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "UpdateDynamicOriginClickableArea", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "set_dynamicOriginRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerRow", Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Table", typeof(int), typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerRow", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Dropdown"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "FindRelativeTransformWithPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public Transform Find(string n) { }

	[CalledBy(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction(HasExplicitThis = True)]
	private Transform FindRelativeTransformWithPath(string path, bool isActiveOnly) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr FindRelativeTransformWithPath_Injected(IntPtr _unity_self, ref ManagedSpanWrapper path, bool isActiveOnly) { }

	[CallerCount(Count = 52)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetChildrenCount")]
	public int get_childCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_childCount_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Scenes.General.HandCards", Member = "RecalculateHandDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.HandCards", Member = "AdjustPosition", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CameraController", Member = "GetOffsetFromDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.CameraView"}, ReturnType = "System.ValueTuple`2<Vector3, Vector3>")]
	[CalledBy(Type = "Scenes.Battle.CameraController", Member = "GetCurrentSetup", ReturnType = "System.ValueTuple`2<Vector3, Vector3>")]
	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "CalculateCamera", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "SetupCamera", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectRotator", Member = "DefineRotation", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.LinkSummon", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+FullRotation", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+FieldPositionData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Scenes.Battle.DuelZone"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Vector3, Path, PathOptions>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_eulerAngles() { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "get_anchorPosition", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "SynchronizeOnTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdateCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), "UnityEngine.Rendering.ProbeVolumesOptions"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "GetLensFlareLightAttenuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", "DG.Tweening.Plugins.Core.PathCore.Path", typeof(float), typeof(Vector3), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_forward() { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_hasChanged() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_hasChanged_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "RandomParticleRotation", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineChainAngle", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass10_0", Member = "<DOShakeRotation>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass11_0", Member = "<DOShakeRotation>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass54_0", Member = "<DOPunchRotation>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass57_0", Member = "<DOShakeRotation>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass58_0", Member = "<DOShakeRotation>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Spine.Unity.FollowSkeletonUtilityRootRotation", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.FollowSkeletonUtilityRootRotation", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_localEulerAngles() { }

	[CallerCount(Count = 61)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_localPosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_localPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[CalledBy(Type = "Extensions.General", Member = "InvertRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), typeof(Component)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "InvertRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "InvertRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.XR.TrackedPoseDriver", Member = "UpdateCallback", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass42_0", Member = "<DOLocalRotate>b__0", ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass43_0", Member = "<DOLocalRotateQuaternion>b__0", ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass75_0", Member = "<DOBlendableLocalRotateBy>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.Core.SpecialPluginsUtils", Member = "SetCameraShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<Vector3, Vector3[], Vector3ArrayOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Quaternion get_localRotation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_localRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[CallerCount(Count = 62)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_localScale() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_localScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Matrix4x4 get_localToWorldMatrix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[CalledBy(Type = "Scenes.Battle.CardOptionList", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EdgeGlow", Member = "CalculateSizing", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalProjector", Member = "get_effectiveScale", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "InternalUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "InternalUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCanvasSpaceClippingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "GetWorldSpaceScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODGroup)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "GetWorldSpaceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODGroup)}, ReturnType = typeof(float))]
	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetWorldScaleLossy")]
	public Vector3 get_lossyScale() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_lossyScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[CallerCount(Count = 148)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Transform get_parent() { }

	[CallerCount(Count = 148)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal Transform get_parentInternal() { }

	[CallerCount(Count = 217)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_position() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ShapeAttenuationAreaTubeLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(Camera)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_right() { }

	[CallerCount(Count = 65)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Quaternion get_rotation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", "DG.Tweening.Plugins.Core.PathCore.Path", typeof(float), typeof(Vector3), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_up() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "GetBounds", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Matrix4x4 get_worldToLocalMatrix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_worldToLocalMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[CallerCount(Count = 113)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetChild", HasExplicitThis = True)]
	[NativeThrows]
	public Transform GetChild(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetChild_Injected(IntPtr _unity_self, int index) { }

	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerCanvas", Member = "ResetAllHierarchy", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerContainer", Member = "GetActiveChildren", ReturnType = "System.Collections.Generic.List`1<DebugUIHandlerWidget>")]
	[CalledBy(Type = "UnityEngine.Rendering.DisallowGPUDrivenRendering", Member = "AllowGPUDrivenRenderingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DisallowSmallMeshCulling", Member = "AllowSmallMeshCullingRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator GetEnumerator() { }

	[CallerCount(Count = 148)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private Transform GetParent() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetParent_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Scenes.General.MultiPick+<CreateCheckbox>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c__DisplayClass327_0", Member = "<Awake>b__34", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<>c__DisplayClass84_0", Member = "<Awake>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectController", Member = "ReorientElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PooledScrollList.Controller.PooledScrollRectBase+ReorientMethod", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "ReorientElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PooledScrollList.Controller.PooledScrollRectBase+ReorientMethod", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int GetSiblingIndex() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetSiblingIndex_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_LookAt_Injected(IntPtr _unity_self, in Vector3 worldPosition, in Vector3 worldUp) { }

	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InverseTransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ShapeAttenuationAreaTubeLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCanvasSpaceClippingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.RectangularVertexClipper", Member = "GetCanvasRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), "UnityEngine.Canvas"}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", "DG.Tweening.Plugins.Core.PathCore.Path", typeof(float), typeof(Vector3), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtilityBone", Member = "DoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonUtilityBone+UpdatePhase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnMoreOptionsButtonClicked", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 InverseTransformPoint(Vector3 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InverseTransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "AdjustRootMotionToDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool), typeof(bool), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 InverseTransformVector(Vector3 vector) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InverseTransformVector_Injected(IntPtr _unity_self, in Vector3 vector, out Vector3 ret) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "PointerShouldIgnoreTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "IsMoveAllowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	public bool IsChildOf(Transform parent) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsChildOf_Injected(IntPtr _unity_self, IntPtr parent) { }

	[CalledBy(Type = "Scenes.Battle.LineArc", Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void LookAt(Vector3 worldPosition) { }

	[CalledBy(Type = typeof(Transform), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Space)}, ReturnType = typeof(void))]
	public void Rotate(Vector3 eulers) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "ConfigureCamera", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "UpdateCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectRotator", Member = "DefineRotation", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.PendulumSummon", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerFoldout", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_eulerAngles(Vector3 value) { }

	[CalledBy(Type = "TMPro.TextContainer", Member = "OnContainerChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_hasChanged(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_hasChanged_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "RandomParticleRotation", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "SortOrderDisplayUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "CheckZoneInverter", ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Pool`1", Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.LinkSummon", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "DefineChainAngle", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_localEulerAngles(Vector3 value) { }

	[CallerCount(Count = 52)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_localPosition(Vector3 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_localPosition_Injected(IntPtr _unity_self, in Vector3 value) { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_localRotation(Quaternion value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_localRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	[CallerCount(Count = 72)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_localScale(Vector3 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_localScale_Injected(IntPtr _unity_self, in Vector3 value) { }

	[CalledBy(Type = "UnityEngine.UI.Misc", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.BoundingBoxAttachment", "Spine.Slot", typeof(Transform), typeof(bool)}, ReturnType = "UnityEngine.PolygonCollider2D")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_parent(Transform value) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal void set_parentInternal(Transform value) { }

	[CallerCount(Count = 49)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_position(Vector3 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_rotation(Quaternion value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<DateTime>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.OptionBox", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.TextBox", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay+<AddCard>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSide", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectController", Member = "AdjustSpaceElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetAsFirstSibling() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetAsFirstSibling_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UI.Tables.TableRow")]
	[CalledBy(Type = "UI.Tables.TableLayout", Member = "AddRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Tables.TableRow"}, ReturnType = "UI.Tables.TableRow")]
	[CalledBy(Type = "UI.Tables.TableRow", Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = "UI.Tables.TableCell")]
	[CalledBy(Type = "UI.Tables.TableRow", Member = "AddCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Tables.TableCell"}, ReturnType = "UI.Tables.TableCell")]
	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsUsingTemplate>d__7", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSide", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color), typeof(Sprite), "SimpleFileBrowser.FileBrowserRenamedItem+OnRenameCompleted"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetAsLastSibling() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetAsLastSibling_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.InputSystem.XR.TrackedPoseDriver", Member = "SetLocalTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetLocalPositionAndRotation_Injected(IntPtr _unity_self, in Vector3 localPosition, in Quaternion localRotation) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void SetParent(Transform p) { }

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("SetParent", HasExplicitThis = True)]
	public void SetParent(Transform parent, bool worldPositionStays) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetParent_Injected(IntPtr _unity_self, IntPtr parent, bool worldPositionStays) { }

	[CalledBy(Type = "Scenes.General.HandCards", Member = "PostAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "ResetCardState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Template", "Scenes.Battle.CardListDisplay+CardState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "CalculateCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.Coin+<Start>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoneFollowerGraphic", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetPositionAndRotation_Injected(IntPtr _unity_self, in Vector3 position, in Quaternion rotation) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick+<CreateCheckbox>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.MultiPick+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "MoveRepositionedCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector2[]", "Card.Template[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "DefineLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "PooledScrollList.View.PooledElement")]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectController", Member = "ReorientElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PooledScrollList.Controller.PooledScrollRectBase+ReorientMethod", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "AdjustSpaceElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectGridController", Member = "ReorientElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PooledScrollList.Controller.PooledScrollRectBase+ReorientMethod", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Background+<LoadLiveEnv>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetSiblingIndex(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetSiblingIndex_Injected(IntPtr _unity_self, int index) { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "get_anchorPosition", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.Plugins.PathPlugin", Member = "SetOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.PathOptions", "DG.Tweening.Tween", "DG.Tweening.Plugins.Core.PathCore.Path", typeof(float), typeof(Vector3), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 TransformDirection(Vector3 direction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void TransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	[CallerCount(Count = 86)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 TransformPoint(Vector3 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void TransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[CalledBy(Type = "Spine.Unity.SkeletonRootMotionBase", Member = "ApplyRootMotion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 TransformVector(Vector3 vector) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void TransformVector_Injected(IntPtr _unity_self, in Vector3 vector, out Vector3 ret) { }

}

