namespace System.Buffers;

[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
internal sealed class ArrayPoolEventSource : EventSource
{
	public enum BufferAllocatedReason
	{
		Pooled = 0,
		OverMaximumSize = 1,
		PoolExhausted = 2,
	}

	internal static readonly ArrayPoolEventSource Log; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(short), typeof(short), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static ArrayPoolEventSource() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(short), typeof(short), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private ArrayPoolEventSource() { }

	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Rent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Event(2, Level = EventLevel::Informational (4))]
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, BufferAllocatedReason reason) { }

	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Rent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Event(1, Level = EventLevel::Verbose (5))]
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Event(3, Level = EventLevel::Verbose (5))]
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Event(4, Level = EventLevel::Informational (4))]
	internal void BufferTrimmed(int bufferId, int bufferSize, int poolId) { }

	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[Event(5, Level = EventLevel::Informational (4))]
	internal void BufferTrimPoll(int milliseconds, int pressure) { }

}

