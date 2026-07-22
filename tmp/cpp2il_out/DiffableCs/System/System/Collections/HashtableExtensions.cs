namespace System.Collections;

[Extension]
internal static class HashtableExtensions
{

	[CalledBy(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Group))]
	[CalledBy(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[CalledBy(Type = typeof(GroupCollection), Member = "GetGroupImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[CalledBy(Type = typeof(Regex), Member = "GroupNameFromNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "GroupNumberFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static bool TryGetValue(Hashtable table, object key, out T value) { }

}

