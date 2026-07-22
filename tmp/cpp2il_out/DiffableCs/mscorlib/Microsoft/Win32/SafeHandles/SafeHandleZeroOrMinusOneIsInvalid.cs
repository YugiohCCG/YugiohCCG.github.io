namespace Microsoft.Win32.SafeHandles;

public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
{

	public virtual bool IsInvalid
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 77
	}

	[CalledBy(Type = "Microsoft.Win32.NativeMethods", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HandleRef), typeof(HandleRef), typeof(HandleRef), "Microsoft.Win32.SafeHandles.SafeProcessHandle&", typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeProcessHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeProcessHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Microsoft.Win32.SafeHandles.SafeProcessHandle", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsInvalid() { }

}

