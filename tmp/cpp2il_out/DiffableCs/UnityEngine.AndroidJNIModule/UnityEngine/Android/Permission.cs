namespace UnityEngine.Android;

public struct Permission
{

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool HasUserAuthorizedPermission(string permission) { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void RequestUserPermission(string permission) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void RequestUserPermissions(String[] permissions, PermissionCallbacks callbacks) { }

}

