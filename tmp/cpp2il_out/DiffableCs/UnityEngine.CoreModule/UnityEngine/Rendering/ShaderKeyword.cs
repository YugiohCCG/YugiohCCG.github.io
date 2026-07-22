namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[UsedByNativeCode]
public struct ShaderKeyword
{
	internal string m_Name; //Field offset: 0x0
	internal uint m_Index; //Field offset: 0x8
	internal bool m_IsLocal; //Field offset: 0xC
	internal bool m_IsCompute; //Field offset: 0xD
	internal bool m_IsValid; //Field offset: 0xE

	public string name
	{
		[CallerCount(Count = 223)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = "UnityEngine.Rendering.HDROutputUtils+ShaderKeywords", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MaterialQualityUtilities", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ShaderKeyword), Member = "GetGlobalKeywordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ShaderKeyword), Member = "CreateGlobalKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public ShaderKeyword(string keywordName) { }

	[CalledBy(Type = typeof(ShaderKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
	internal static void CreateGlobalKeyword(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateGlobalKeyword_Injected(ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
	internal static uint GetGlobalKeywordCount() { }

	[CalledBy(Type = typeof(ShaderKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
	internal static uint GetGlobalKeywordIndex(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint GetGlobalKeywordIndex_Injected(ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

