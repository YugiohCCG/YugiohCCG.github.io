namespace UnityEngine.Rendering;

internal struct OccluderDerivedData
{
	public Matrix4x4 viewProjMatrix; //Field offset: 0x0
	public Vector4 viewOriginWorldSpace; //Field offset: 0x40
	public Vector4 radialDirWorldSpace; //Field offset: 0x50
	public Vector4 facingDirWorldSpace; //Field offset: 0x60

	[CalledBy(Type = typeof(OccluderContext), Member = "SetupFarDepthPyramidConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.OccluderSubviewUpdate>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>)}, ReturnType = typeof(OccluderDepthPyramidConstants))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	public static OccluderDerivedData FromParameters(in OccluderSubviewUpdate occluderSubviewUpdate) { }

}

