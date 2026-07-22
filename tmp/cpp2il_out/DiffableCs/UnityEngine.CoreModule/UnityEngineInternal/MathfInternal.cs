namespace UnityEngineInternal;

[Il2CppEagerStaticClassConstruction]
public struct MathfInternal
{
	public static float FloatMinNormal; //Field offset: 0x0
	public static float FloatMinDenormal; //Field offset: 0x4
	public static bool IsFlushToZeroEnabled; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static MathfInternal() { }

}

