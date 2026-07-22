namespace System.Runtime.InteropServices;

public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
{
	private const int RefCount_Mask = 2147483644; //Field offset: 0x0
	private const int RefCount_One = 4; //Field offset: 0x0
	protected IntPtr handle; //Field offset: 0x10
	private int _state; //Field offset: 0x18
	private bool _ownsHandle; //Field offset: 0x1C
	private bool _fullyInitialized; //Field offset: 0x1D

	public bool IsClosed
	{
		[CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(FileStream), Member = "ReadByte", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FileStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FileStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Mathematics.math", Member = "uint2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.uint2", "Unity.Mathematics.uint2", "Unity.Mathematics.uint2"}, ReturnType = "Unity.Mathematics.uint2x3")]
		[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileStream), Member = "Flush", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileStream), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[CalledBy(Type = "Unity.Mathematics.math", Member = "float2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.float2", "Unity.Mathematics.float2", "Unity.Mathematics.float2"}, ReturnType = "Unity.Mathematics.float2x3")]
		[CalledBy(Type = "Unity.Mathematics.math", Member = "int2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.int2", "Unity.Mathematics.int2", "Unity.Mathematics.int2"}, ReturnType = "Unity.Mathematics.int2x3")]
		[CallerCount(Count = 16)]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 7
	}

	public abstract bool IsInvalid
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 0
	}

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle) { }

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void Close() { }

	[CallerCount(Count = 52)]
	[CallsUnknownMethods(Count = 3)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public void DangerousAddRef(ref bool success) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public IntPtr DangerousGetHandle() { }

	[CallerCount(Count = 80)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void DangerousRelease() { }

	[CalledBy(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "InternalDispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "InternalFinalize", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private void DangerousReleaseInternal(bool dispose) { }

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(SafePasswordHandle), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "int2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.int2", "Unity.Mathematics.int2", "Unity.Mathematics.int2"}, ReturnType = "Unity.Mathematics.int2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "float2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.float2", "Unity.Mathematics.float2", "Unity.Mathematics.float2"}, ReturnType = "Unity.Mathematics.float2x3")]
	[CalledBy(Type = typeof(FileStream), Member = "FlushAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "uint2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.uint2", "Unity.Mathematics.uint2", "Unity.Mathematics.uint2"}, ReturnType = "Unity.Mathematics.uint2x3")]
	[CalledBy(Type = typeof(FileStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
	[CallerCount(Count = 16)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public bool get_IsClosed() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public abstract bool get_IsInvalid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void InternalDispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void InternalFinalize() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected abstract bool ReleaseHandle() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected void SetHandle(IntPtr handle) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EventResetMode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitHandle), Member = "set_Handle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void SetHandleAsInvalid() { }

}

