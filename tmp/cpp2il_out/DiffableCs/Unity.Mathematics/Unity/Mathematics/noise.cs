namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public static class noise
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(noise), Member = "mod289", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float2 cellular(float2 P) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "mod7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(math), Member = "min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(math), Member = "sqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[ContainsUnimplementedInstructions]
	public static float2 cellular(float3 P) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(noise), Member = "mod289", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float2 cellular2x2(float2 P) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float2 cellular2x2x2(float3 P) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[ContainsUnimplementedInstructions]
	public static float cnoise(float3 P) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "taylorInvSqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float3)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float2)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float), typeof(float)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float2), typeof(float)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "fade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4), typeof(float4), typeof(float)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2), typeof(float)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(math), Member = "lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 64)]
	[ContainsUnimplementedInstructions]
	public static float cnoise(float4 P) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[ContainsUnimplementedInstructions]
	public static float cnoise(float2 P) { }

	[CalledBy(Type = typeof(noise), Member = "cnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "pnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4), typeof(float4)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	private static float4 fade(float4 t) { }

	[CallerCount(Count = 0)]
	private static float3 fade(float3 t) { }

	[CallerCount(Count = 0)]
	private static float2 fade(float2 t) { }

	[CalledBy(Type = typeof(noise), Member = "snoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[ContainsUnimplementedInstructions]
	private static float4 grad4(float j, float4 ip) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static float mod289(float x) { }

	[CalledBy(Type = typeof(noise), Member = "cellular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[CalledBy(Type = typeof(noise), Member = "cellular2x2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[CalledBy(Type = typeof(noise), Member = "snoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	private static float2 mod289(float2 x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	private static float3 mod289(float3 x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[ContainsUnimplementedInstructions]
	private static float4 mod289(float4 x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[ContainsUnimplementedInstructions]
	private static float4 mod7(float4 x) { }

	[CalledBy(Type = typeof(noise), Member = "cellular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	private static float3 mod7(float3 x) { }

	[CalledBy(Type = typeof(noise), Member = "cellular2x2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[CalledBy(Type = typeof(noise), Member = "cellular2x2x2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[CalledBy(Type = typeof(noise), Member = "cnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "pnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "cnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "pnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "cnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "pnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4), typeof(float4)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "snoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "snoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3), typeof(float3&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "snoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float))]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	private static float4 permute(float4 x) { }

	[CalledBy(Type = typeof(noise), Member = "rgrad2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float)}, ReturnType = typeof(float2))]
	[CalledBy(Type = typeof(noise), Member = "snoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static float permute(float x) { }

	[CalledBy(Type = typeof(noise), Member = "cellular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[CalledBy(Type = typeof(noise), Member = "cellular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float2))]
	[CalledBy(Type = typeof(noise), Member = "snoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	private static float3 permute(float3 x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "taylorInvSqrt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float3)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float2)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float), typeof(float)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "float4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float2), typeof(float)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "fade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4), typeof(float4), typeof(float)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2), typeof(float)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(math), Member = "lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 67)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static float pnoise(float4 P, float4 rep) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static float pnoise(float3 P, float3 rep) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public static float pnoise(float2 P, float2 rep) { }

	[CalledBy(Type = typeof(noise), Member = "psrdnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2)}, ReturnType = typeof(float3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(noise), Member = "rgrad2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float)}, ReturnType = typeof(float2))]
	[CallsUnknownMethods(Count = 6)]
	public static float3 psrdnoise(float2 pos, float2 per, float rot) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(noise), Member = "psrdnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2), typeof(float)}, ReturnType = typeof(float3))]
	public static float3 psrdnoise(float2 pos, float2 per) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(noise), Member = "rgrad2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float)}, ReturnType = typeof(float2))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static float psrnoise(float2 pos, float2 per, float rot) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public static float psrnoise(float2 pos, float2 per) { }

	[CalledBy(Type = typeof(noise), Member = "psrdnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2), typeof(float)}, ReturnType = typeof(float3))]
	[CalledBy(Type = typeof(noise), Member = "psrnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float2), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "srdnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float)}, ReturnType = typeof(float3))]
	[CalledBy(Type = typeof(noise), Member = "srnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static float2 rgrad2(float2 p, float rot) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[ContainsUnimplementedInstructions]
	public static float snoise(float3 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(noise), Member = "mod289", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[ContainsUnimplementedInstructions]
	public static float snoise(float2 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[ContainsUnimplementedInstructions]
	public static float snoise(float3 v, out float3 gradient) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(noise), Member = "permute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float4))]
	[Calls(Type = typeof(noise), Member = "grad4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float4)}, ReturnType = typeof(float4))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static float snoise(float4 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(noise), Member = "srdnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float)}, ReturnType = typeof(float3))]
	public static float3 srdnoise(float2 pos) { }

	[CalledBy(Type = typeof(noise), Member = "srdnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "rgrad2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float)}, ReturnType = typeof(float2))]
	public static float3 srdnoise(float2 pos, float rot) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(float2))]
	[Calls(Type = typeof(math), Member = "floor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float3))]
	[Calls(Type = typeof(noise), Member = "rgrad2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2), typeof(float)}, ReturnType = typeof(float2))]
	[ContainsUnimplementedInstructions]
	public static float srnoise(float2 pos, float rot) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public static float srnoise(float2 pos) { }

	[CalledBy(Type = typeof(noise), Member = "cnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(noise), Member = "pnoise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4), typeof(float4)}, ReturnType = typeof(float))]
	[CallerCount(Count = 8)]
	private static float4 taylorInvSqrt(float4 r) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 332)]
	private static float taylorInvSqrt(float r) { }

}

