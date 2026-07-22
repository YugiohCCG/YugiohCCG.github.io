namespace UnityEngine.Rendering;

[NativeHeader("Editor/Src/Graphics/ShaderCompilerData.h")]
[UsedByNativeCode]
public struct ShaderKeywordSet
{
	private IntPtr m_KeywordState; //Field offset: 0x0
	private IntPtr m_Shader; //Field offset: 0x8
	private IntPtr m_ComputeShader; //Field offset: 0x10
	private ulong m_StateIndex; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	private void CheckKeywordCompatible(ShaderKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("keywords::GetEnabledKeywords")]
	private static ShaderKeyword[] GetEnabledKeywords(ShaderKeywordSet state) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ShaderKeyword[] GetEnabledKeywords_Injected(in ShaderKeywordSet state) { }

	[CalledBy(Type = "UnityEngine.Rendering.HDROutputUtils", Member = "IsShaderVariantValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeywordSet), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderKeywordSet), Member = "IsKeywordNameEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeywordSet), typeof(string)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public bool IsEnabled(ShaderKeyword keyword) { }

	[CalledBy(Type = typeof(ShaderKeywordSet), Member = "IsEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeyword)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("keywords::IsKeywordEnabled")]
	private static bool IsKeywordNameEnabled(ShaderKeywordSet state, string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsKeywordNameEnabled_Injected(in ShaderKeywordSet state, ref ManagedSpanWrapper name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static int ShaderKeywordComparer(ShaderKeyword kw1, ShaderKeyword kw2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeyword)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeyword[]), typeof(System.Comparison`1<UnityEngine.Rendering.ShaderKeyword>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeyword)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Rendering.ShaderKeyword>)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

