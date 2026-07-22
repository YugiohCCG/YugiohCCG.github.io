namespace Microsoft.Win32.SafeHandles;

internal static class SafeHandleCache
{
	private static T s_invalidHandle; //Field offset: 0x0

	[CalledBy(Type = typeof(SafePasswordHandle), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static bool IsCachedInvalidHandle(SafeHandle handle) { }

}

