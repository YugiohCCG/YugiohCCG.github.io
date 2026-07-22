namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[RequiredByNativeCode]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(AnimationCurve animationCurve) { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	private bool m_RequiresNativeCleanup; //Field offset: 0x18

	public Keyframe Item
	{
		[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.Easing.EaseCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 154
	}

	public Keyframe[] keys
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
		[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(float), typeof(bool), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.AnimationCurveParameter", Member = "Clone", ReturnType = typeof(object))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(AnimationCurve), Member = "GetKeys", ReturnType = typeof(Keyframe[]))]
		 get { } //Length: 9
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 248
	}

	public int length
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.Core.Easing.EaseCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 20)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetKeyCount", IsThreadSafe = True)]
		 get { } //Length: 81
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal AnimationCurve(IntPtr ptr, bool ownMemory) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	public AnimationCurve() { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareComponentSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(float), typeof(bool), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Keyframe[]", typeof(float), typeof(bool), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.AnimationCurveParameter", Member = "Clone", ReturnType = typeof(object))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(AnimationCurve), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	public AnimationCurve(Keyframe[] keys) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int AddKey(Keyframe key) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	public int AddKey(float time, float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int AddKey_Injected(IntPtr _unity_self, float time, float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddKey", IsThreadSafe = True)]
	private int AddKey_Internal(Keyframe key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int AddKey_Internal_Injected(IntPtr _unity_self, in Keyframe key) { }

	[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "ResetAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::ClearKeys", HasExplicitThis = True, IsThreadSafe = True)]
	public void ClearKeys() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ClearKeys_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.AnimationCurveParameter", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.VolumeParameter"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void CopyFrom(AnimationCurve other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(AnimationCurve other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "<ProcessLensFlareSRPElementsSingle>g__ComputeLocalSize|74_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(AnimationCurve), "<>c__DisplayClass74_0&"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ThreadSafe]
	public float Evaluate(float time) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float Evaluate_Injected(IntPtr _unity_self, float time) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Keyframe))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Keyframe get_Item(int index) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareDataElementSRP", Member = "Clone", ReturnType = "UnityEngine.Rendering.LensFlareDataElementSRP")]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(float), typeof(bool), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.AnimationCurveParameter", Member = "Clone", ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AnimationCurve), Member = "GetKeys", ReturnType = typeof(Keyframe[]))]
	public Keyframe[] get_keys() { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.KeyframeUtility", Member = "InterpAnimationCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve&), typeof(AnimationCurve), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.Easing.EaseCurve", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetKeyCount", IsThreadSafe = True)]
	public int get_length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_length_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetHashCode_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	private Keyframe GetKey(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetKey_Injected(IntPtr _unity_self, int index, out Keyframe ret) { }

	[CalledBy(Type = typeof(AnimationCurve), Member = "get_keys", ReturnType = typeof(Keyframe[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	private Keyframe[] GetKeys() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::Internal_CopyFrom", HasExplicitThis = True, IsThreadSafe = True)]
	private void Internal_CopyFrom(IntPtr other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_CopyFrom_Injected(IntPtr _unity_self, IntPtr other) { }

	[CalledBy(Type = typeof(AnimationCurve), Member = "Linear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(AnimationCurve))]
	[CalledBy(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	private bool Internal_Equals(IntPtr other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareComponentSRP", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "MoveKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Keyframe&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::MoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	public int MoveKey(int index, Keyframe key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int MoveKey_Injected(IntPtr _unity_self, int index, in Keyframe key) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "RemoveKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::RemoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	public void RemoveKey(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RemoveKey_Injected(IntPtr _unity_self, int index) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_keys(Keyframe[] value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("AnimationCurveBindings::SetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	private void SetKeys(Keyframe[] keys) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keys) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "SmoothTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AnimationCurveBindings::SmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	public void SmoothTangents(int index, float weight) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SmoothTangents_Injected(IntPtr _unity_self, int index, float weight) { }

}

