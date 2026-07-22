namespace UnityEngine;

[NativeHeader("Runtime/NameFormatter/NameFormatter.h")]
[VisibleToOtherModules]
internal sealed class NameFormatter
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction]
	public static string FormatVariableName(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void FormatVariableName_Injected(ref ManagedSpanWrapper name, out ManagedSpanWrapper ret) { }

}

