namespace UnityEngine.Rendering;

public class SphericalHarmonicsL2Utils
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SphericalHarmonicsL2Utils() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R) { }

}

