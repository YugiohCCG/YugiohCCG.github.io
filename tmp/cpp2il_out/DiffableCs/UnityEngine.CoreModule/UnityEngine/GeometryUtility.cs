namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GeometryUtilityScripting", StaticAccessorType::DoubleColon (2))]
public sealed class GeometryUtility
{

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GeometryUtility), Member = "Internal_ExtractPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane[]), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GeometryUtility), Member = "Internal_ExtractPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane[]), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	[CalledBy(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Plane[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Plane[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[NativeName("ExtractPlanes")]
	private static void Internal_ExtractPlanes(out Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_ExtractPlanes_Injected(out BlittableArrayWrapper planes, in Matrix4x4 worldToProjectionMatrix) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "ShouldCullCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Transform), "UnityEngine.Plane[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TestPlanesAABB_Injected(ref ManagedSpanWrapper planes, in Bounds bounds) { }

}

