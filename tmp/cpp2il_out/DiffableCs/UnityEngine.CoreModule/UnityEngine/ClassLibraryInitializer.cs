namespace UnityEngine;

internal static class ClassLibraryInitializer
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityLogWriter), Member = "Init", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	private static void Init() { }

}

