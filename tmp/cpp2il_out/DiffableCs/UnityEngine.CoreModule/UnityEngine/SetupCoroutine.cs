namespace UnityEngine;

[RequiredByNativeCode]
internal class SetupCoroutine
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[RequiredByNativeCode]
	public static object InvokeMember(object behaviour, string name, object variable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[RequiredByNativeCode]
	public static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

}

