namespace UnityEngine.Rendering;

internal struct AABB
{
	public float3 center; //Field offset: 0x0
	public float3 extents; //Field offset: 0xC

	public float3 max
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 47
	}

	public float3 min
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 47
	}

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public float3 get_max() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public float3 get_min() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static float3 RotateExtents(float3 extents, float3 m0, float3 m1, float3 m2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+TransformUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static AABB Transform(float4x4 transform, AABB localBounds) { }

}

