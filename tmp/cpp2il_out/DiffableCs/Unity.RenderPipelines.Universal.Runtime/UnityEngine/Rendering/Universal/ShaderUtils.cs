namespace UnityEngine.Rendering.Universal;

public static class ShaderUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string path; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass2_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool <GetEnumFromPath>b__0(string m) { }

	}

	private static readonly String[] s_ShaderPaths; //Field offset: 0x0

	internal static float PersistentDeltaTime
	{
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetShaderTimeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseCommandBuffer), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		internal get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 15)]
	private static ShaderUtils() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "SetShaderTimeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseCommandBuffer), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	internal static float get_PersistentDeltaTime() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "FindIndex", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static ShaderPathID GetEnumFromPath(string path) { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "get_defaultShader", ReturnType = typeof(Shader))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static string GetShaderPath(ShaderPathID id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsLWShader(Shader shader) { }

}

