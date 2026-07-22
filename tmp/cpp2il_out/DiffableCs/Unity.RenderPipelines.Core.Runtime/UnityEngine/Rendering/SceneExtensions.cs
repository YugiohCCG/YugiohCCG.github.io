namespace UnityEngine.Rendering;

[Extension]
internal static class SceneExtensions
{
	private static PropertyInfo s_SceneGUID; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
	[CallsUnknownMethods(Count = 2)]
	private static SceneExtensions() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "GetSceneGUID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scene)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "SetActiveScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scene)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "TryGetPerSceneData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ProbeVolumePerSceneData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "<RegisterDebug>b__42_83", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PropertyInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static string GetGUID(Scene scene) { }

}

