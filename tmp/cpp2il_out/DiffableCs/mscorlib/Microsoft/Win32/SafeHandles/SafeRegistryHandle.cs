namespace Microsoft.Win32.SafeHandles;

public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal SafeRegistryHandle() { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Advapi32), Member = "RegCloseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	protected virtual bool ReleaseHandle() { }

}

