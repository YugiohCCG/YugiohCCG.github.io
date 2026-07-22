namespace UnityEngine.Rendering.Universal;

[Extension]
internal static class CameraTypeUtility
{
	private static String[] s_CameraTypeNames; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[CallsUnknownMethods(Count = 1)]
	private static CameraTypeUtility() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static string GetName(CameraRenderType type) { }

}

