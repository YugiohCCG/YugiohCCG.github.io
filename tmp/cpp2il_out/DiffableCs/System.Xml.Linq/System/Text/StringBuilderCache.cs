namespace System.Text;

internal static class StringBuilderCache
{
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; //Field offset: 0x80000000

	[CalledBy(Type = typeof(XDeclaration), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XElement), Member = "get_Value", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Capacity", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static StringBuilder Acquire(int capacity = 16) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Capacity", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static string GetStringAndRelease(StringBuilder sb) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "get_Capacity", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	public static void Release(StringBuilder sb) { }

}

