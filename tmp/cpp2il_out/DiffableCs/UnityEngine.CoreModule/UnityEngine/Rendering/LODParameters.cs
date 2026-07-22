namespace UnityEngine.Rendering;

public struct LODParameters : IEquatable<LODParameters>
{
	private int m_IsOrthographic; //Field offset: 0x0
	private Vector3 m_CameraPosition; //Field offset: 0x4
	private float m_FieldOfView; //Field offset: 0x10
	private float m_OrthoSize; //Field offset: 0x14
	private int m_CameraPixelHeight; //Field offset: 0x18

	public Vector3 cameraPosition
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.BinningConfig&", typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(JobHandle))]
		[CallerCount(Count = 1)]
		 get { } //Length: 19
	}

	public float fieldOfView
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool isOrthographic
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.BinningConfig&", typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(JobHandle))]
		[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "CalculateScreenRelativeMetric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODParameters), typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 74
	}

	public float orthoSize
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(LODParameters other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.BinningConfig&", typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	public Vector3 get_cameraPosition() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public float get_fieldOfView() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), "ReadOnly&", "ReadOnly&", "Unity.Collections.NativeList`1<LODGroupCullingData>", "UnityEngine.Rendering.BinningConfig&", typeof(float), "UnityEngine.Rendering.OcclusionCullingCommon", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupRenderingUtils", Member = "CalculateScreenRelativeMetric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODParameters), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool get_isOrthographic() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public float get_orthoSize() { }

	[CalledBy(Type = typeof(ScriptableCullingParameters), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

}

