namespace System.Runtime.ConstrainedExecution;

public abstract class CriticalFinalizerObject
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected CriticalFinalizerObject() { }

	[CalledBy(Type = typeof(Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Thread), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReaderWriterLock), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InternalThread), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

}

