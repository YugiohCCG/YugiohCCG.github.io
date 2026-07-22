namespace UnityEngine;

[NativeHeader("Runtime/Graphics/LOD/LODUtility.h")]
[NativeHeader("Runtime/Graphics/LOD/LODGroupManager.h")]
[NativeHeader("Runtime/Graphics/LOD/LODGroup.h")]
[StaticAccessor("GetLODGroupManager()", StaticAccessorType::Dot (0))]
public class LODGroup : Component
{

	public Vector3 localReferencePoint
	{
		[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "GetWorldReferencePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODGroup)}, ReturnType = typeof(Vector3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 144
	}

	public float size
	{
		[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "GetWorldSpaceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODGroup)}, ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "GetWorldReferencePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODGroup)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 get_localReferencePoint() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_localReferencePoint_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "GetWorldSpaceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODGroup)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_size() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_size_Injected(IntPtr _unity_self) { }

}

