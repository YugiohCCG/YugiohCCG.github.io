namespace System.Security;

[ComVisible(True)]
public static class SecurityManager
{

	[Obsolete("The security manager cannot be turned off on MS runtime")]
	public static bool SecurityEnabled
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal static void EnsureElevatedPermissions() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public static bool get_SecurityEnabled() { }

}

