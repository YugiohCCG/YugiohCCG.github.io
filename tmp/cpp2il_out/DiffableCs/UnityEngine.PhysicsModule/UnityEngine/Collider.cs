namespace UnityEngine;

[NativeHeader("Modules/Physics/Collider.h")]
public class Collider : Component
{

	public bool enabled
	{
		[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume", typeof(Vector3)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.VolumeStack", typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Collider() { }

	[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume", typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.VolumeStack", typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 ClosestPoint(Vector3 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ClosestPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume", typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.VolumeStack", typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_enabled() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

}

