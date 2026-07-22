namespace UnityEngine.Rendering;

[Obsolete("BatchRendererGroupGlobals and associated cbuffer are now set automatically by Unity. Setting it manually is no longer necessary or supported.")]
public struct BatchRendererGroupGlobals : IEquatable<BatchRendererGroupGlobals>
{
	public const string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues"; //Field offset: 0x0
	public static readonly int kGlobalsPropertyId; //Field offset: 0x0
	public Vector4 ProbesOcclusion; //Field offset: 0x0
	public Vector4 SpecCube0_HDR; //Field offset: 0x10
	public Vector4 SpecCube1_HDR; //Field offset: 0x20
	public SHCoefficients SHCoefficients; //Field offset: 0x30

	public static BatchRendererGroupGlobals Default
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionProbe), Member = "get_defaultTextureHDRDecodeValues", ReturnType = typeof(Vector4))]
		[Calls(Type = typeof(RenderSettings), Member = "get_ambientProbe", ReturnType = typeof(SphericalHarmonicsL2))]
		[Calls(Type = typeof(SHCoefficients), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 446
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static BatchRendererGroupGlobals() { }

	[CalledBy(Type = typeof(BatchRendererGroupGlobals), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BatchRendererGroupGlobals), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroupGlobals), typeof(BatchRendererGroupGlobals)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BatchRendererGroupGlobals), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroupGlobals), typeof(BatchRendererGroupGlobals)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SHCoefficients), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SHCoefficients)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(BatchRendererGroupGlobals other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BatchRendererGroupGlobals), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroupGlobals)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionProbe), Member = "get_defaultTextureHDRDecodeValues", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientProbe", ReturnType = typeof(SphericalHarmonicsL2))]
	[Calls(Type = typeof(SHCoefficients), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static BatchRendererGroupGlobals get_Default() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(SHCoefficients)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(SHCoefficients)}, ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BatchRendererGroupGlobals), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroupGlobals)}, ReturnType = typeof(bool))]
	public static bool op_Equality(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BatchRendererGroupGlobals), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchRendererGroupGlobals)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right) { }

}

