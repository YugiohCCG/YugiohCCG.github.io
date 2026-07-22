namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public struct GlobalKeyword
{
	internal readonly string m_Name; //Field offset: 0x0
	internal readonly uint m_Index; //Field offset: 0x8

	[CalledBy(Type = typeof(GlobalKeyword), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GlobalKeyword))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GlobalKeyword), Member = "GetGlobalKeywordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public GlobalKeyword(string name) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<XRPassCreateInfo, XRPass>", typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShaderGlobalKeywords", Member = "InitializeShaderGlobalKeywords", ReturnType = typeof(void))]
	[CallerCount(Count = 79)]
	[Calls(Type = typeof(GlobalKeyword), Member = "CreateGlobalKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlobalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static GlobalKeyword Create(string name) { }

	[CalledBy(Type = typeof(GlobalKeyword), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GlobalKeyword))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
	private static void CreateGlobalKeyword(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateGlobalKeyword_Injected(ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
	private static uint GetGlobalKeywordCount() { }

	[CalledBy(Type = typeof(GlobalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
	private static uint GetGlobalKeywordIndex(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint GetGlobalKeywordIndex_Injected(ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

