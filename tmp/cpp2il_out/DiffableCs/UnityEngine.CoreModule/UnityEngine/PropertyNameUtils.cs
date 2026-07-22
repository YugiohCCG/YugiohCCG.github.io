namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PropertyName.h")]
internal class PropertyNameUtils
{

	[CalledBy(Type = typeof(PropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("PropertyNameFromStringICall", IsThreadSafe = True)]
	public static PropertyName PropertyNameFromString(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void PropertyNameFromString_Injected(ref ManagedSpanWrapper name, out PropertyName ret) { }

}

