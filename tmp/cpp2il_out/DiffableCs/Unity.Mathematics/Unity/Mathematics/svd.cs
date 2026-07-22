namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public static class svd
{
	public const float k_EpsilonDeterminant = 1E-06; //Field offset: 0x0
	public const float k_EpsilonRCP = 1E-09; //Field offset: 0x0
	public const float k_EpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	public const float k_EpsilonNormal = 1E-30; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static quaternion approxGivensQuat(float3 pq, float4 mask) { }

	[CallerCount(Count = 0)]
	private static void condNegSwap(bool c, ref float3 x, ref float3 y) { }

	[CallerCount(Count = 0)]
	private static quaternion condNegSwapQuat(bool c, quaternion q, float4 mask) { }

	[CallerCount(Count = 0)]
	private static void condSwap(bool c, ref float x, ref float y) { }

	[CalledBy(Type = typeof(svd), Member = "qrGivensQuat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float4)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(svd), Member = "singularValuesDecomposition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(quaternion&), typeof(quaternion&)}, ReturnType = typeof(float3))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(svd), Member = "qrGivensQuat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float4)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(math), Member = "mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3)}, ReturnType = typeof(float3x3))]
	private static quaternion givensQRFactorization(float3x3 b, out float3x3 r) { }

	[CalledBy(Type = typeof(svd), Member = "qrGivensQuat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float4)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(svd), Member = "singularValuesDecomposition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(quaternion&), typeof(quaternion&)}, ReturnType = typeof(float3))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(math), Member = "mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3)}, ReturnType = typeof(float3x3))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static quaternion jacobiIteration(ref float3x3 s, int iterations = 5) { }

	[CalledBy(Type = typeof(svd), Member = "givensQRFactorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3&)}, ReturnType = typeof(quaternion))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(svd), Member = "jacobiIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3&), typeof(int)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(svd), Member = "sortSingularValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3&), typeof(quaternion&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(svd), Member = "givensQRFactorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3&)}, ReturnType = typeof(quaternion))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static quaternion qrGivensQuat(float2 pq, float4 mask) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static float3 rcpsafe(float3 x, float epsilon = 1E-09) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3)}, ReturnType = typeof(float3x3))]
	[Calls(Type = typeof(svd), Member = "jacobiIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3&), typeof(int)}, ReturnType = typeof(quaternion))]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(svd), Member = "sortSingularValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3&), typeof(quaternion&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(svd), Member = "givensQRFactorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3&)}, ReturnType = typeof(quaternion))]
	private static float3 singularValuesDecomposition(float3x3 a, out quaternion u, out quaternion v) { }

	[CalledBy(Type = typeof(svd), Member = "qrGivensQuat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float4)}, ReturnType = typeof(quaternion))]
	[CalledBy(Type = typeof(svd), Member = "singularValuesDecomposition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(quaternion&), typeof(quaternion&)}, ReturnType = typeof(float3))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void sortSingularValues(ref float3x3 b, ref quaternion v) { }

	[CalledBy(Type = typeof(math), Member = "pseudoinverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(float3x3))]
	[CalledBy(Type = typeof(math), Member = "nlerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion), typeof(quaternion), typeof(float)}, ReturnType = typeof(quaternion))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float3x3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(math), Member = "mul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3), typeof(float3x3)}, ReturnType = typeof(float3x3))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float3x3 svdInverse(float3x3 a) { }

	[CalledBy(Type = typeof(math), Member = "rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3x3)}, ReturnType = typeof(quaternion))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static quaternion svdRotation(float3x3 a) { }

}

