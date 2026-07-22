namespace Spine;

public static class Json
{

	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonDecoder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonDecoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static object Deserialize(TextReader text) { }

}

