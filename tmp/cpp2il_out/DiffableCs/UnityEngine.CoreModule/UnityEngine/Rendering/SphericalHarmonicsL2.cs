namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[NativeHeader("Runtime/Export/Math/SphericalHarmonicsL2.bindings.h")]
[UsedByNativeCode]
public struct SphericalHarmonicsL2 : IEquatable<SphericalHarmonicsL2>
{
	private float shr0; //Field offset: 0x0
	private float shr1; //Field offset: 0x4
	private float shr2; //Field offset: 0x8
	private float shr3; //Field offset: 0xC
	private float shr4; //Field offset: 0x10
	private float shr5; //Field offset: 0x14
	private float shr6; //Field offset: 0x18
	private float shr7; //Field offset: 0x1C
	private float shr8; //Field offset: 0x20
	private float shg0; //Field offset: 0x24
	private float shg1; //Field offset: 0x28
	private float shg2; //Field offset: 0x2C
	private float shg3; //Field offset: 0x30
	private float shg4; //Field offset: 0x34
	private float shg5; //Field offset: 0x38
	private float shg6; //Field offset: 0x3C
	private float shg7; //Field offset: 0x40
	private float shg8; //Field offset: 0x44
	private float shb0; //Field offset: 0x48
	private float shb1; //Field offset: 0x4C
	private float shb2; //Field offset: 0x50
	private float shb3; //Field offset: 0x54
	private float shb4; //Field offset: 0x58
	private float shb5; //Field offset: 0x5C
	private float shb6; //Field offset: 0x60
	private float shb7; //Field offset: 0x64
	private float shb8; //Field offset: 0x68

	public float Item
	{
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "GetL1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(Vector3&), typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "GetL2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(Vector3&), typeof(Vector3&), typeof(Vector3&), typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "GetCoefficient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = "GetSHA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(int)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = "GetSHB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(int)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = "GetSHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 432
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL1R", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL1G", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL1B", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetCoefficient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(int), typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 432
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(SphericalHarmonicsL2)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(SphericalHarmonicsL2)}, ReturnType = typeof(bool))]
	public override bool Equals(SphericalHarmonicsL2 other) { }

	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "GetL1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(Vector3&), typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "GetL2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(Vector3&), typeof(Vector3&), typeof(Vector3&), typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "GetCoefficient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = "GetSHA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(int)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = "GetSHB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(int)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.SHCoefficients", Member = "GetSHC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public float get_Item(int rgb, int coefficient) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(SphericalHarmonicsL2), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SphericalHarmonicsL2), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SphericalHarmonicsL2), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(SphericalHarmonicsL2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "UpdateAmbientProbeAndGpuBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2), typeof(SphericalHarmonicsL2)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL1R", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL1G", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL1B", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetL1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SphericalHarmonicsL2Utils", Member = "SetCoefficient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2&), typeof(int), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_Item(int rgb, int coefficient, float value) { }

}

