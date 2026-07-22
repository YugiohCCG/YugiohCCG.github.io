namespace System.Threading;

[ComVisible(True)]
public sealed class ReaderWriterLock : CriticalFinalizerObject
{
	private int seq_num; //Field offset: 0x10
	private int state; //Field offset: 0x14
	private int readers; //Field offset: 0x18
	private int writer_lock_owner; //Field offset: 0x1C
	private LockQueue writer_queue; //Field offset: 0x20
	private Hashtable reader_locks; //Field offset: 0x28

	[CalledBy(Type = "System.Xml.Schema.XmlSchemaCollection", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlNameTable"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public ReaderWriterLock() { }

	[CalledBy(Type = "System.Xml.Schema.XmlSchemaCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Schema.XmlSchemaCollectionNode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReaderWriterLock), Member = "AcquireWriterLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void AcquireWriterLock(int millisecondsTimeout) { }

	[CalledBy(Type = typeof(ReaderWriterLock), Member = "AcquireWriterLock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThreadId", ReturnType = typeof(int))]
	[Calls(Type = typeof(LockQueue), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LockQueue), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThreadId", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private bool HasWriterLock() { }

	[CalledBy(Type = "System.Xml.Schema.XmlSchemaCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Schema.XmlSchemaCollectionNode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThreadId", ReturnType = typeof(int))]
	[Calls(Type = typeof(LockQueue), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LockQueue), Member = "Pulse", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ApplicationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void ReleaseWriterLock() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LockQueue), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LockQueue), Member = "Pulse", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "PulseAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ReleaseWriterLock(int releaseCount) { }

}

