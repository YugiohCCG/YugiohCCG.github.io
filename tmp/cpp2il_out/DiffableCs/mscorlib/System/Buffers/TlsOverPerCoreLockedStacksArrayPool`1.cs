namespace System.Buffers;

internal sealed class TlsOverPerCoreLockedStacksArrayPool : ArrayPool<T>
{
	private sealed class LockedStack
	{
		private readonly T[][] _arrays; //Field offset: 0x0
		private int _count; //Field offset: 0x0
		private uint _firstStackItemMS; //Field offset: 0x0

		[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public LockedStack() { }

		[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>", typeof(Int32[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public void Trim(uint tickCount, int id, MemoryPressure<T> pressure, int bucketSize) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public T[] TryPop() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public bool TryPush(T[] array) { }

	}

	private enum MemoryPressure
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	private sealed class PerCoreLockedStacks
	{
		private readonly LockedStack<T>[] _perCoreStacks; //Field offset: 0x0

		[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "CreatePerCoreLockedStacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+PerCoreLockedStacks<T>")]
		[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Environment), Member = "get_ProcessorCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public PerCoreLockedStacks() { }

		[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>", typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public bool Trim(uint tickCount, int id, MemoryPressure<T> pressure, Int32[] bucketSizes) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public T[] TryPop() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public void TryPush(T[] array) { }

	}

	[ThreadStatic]
	private static T[][] t_tlsBuckets; //Field offset: 0xFFFFFFFF
	private static readonly bool s_trimBuffers; //Field offset: 0x0
	private static readonly ConditionalWeakTable<T[][], Object> s_allTlsBuckets; //Field offset: 0x0
	private readonly Int32[] _bucketArraySizes; //Field offset: 0x0
	private readonly PerCoreLockedStacks<T>[] _buckets; //Field offset: 0x0
	private int _callbackCreated; //Field offset: 0x0

	private int Id
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 35
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	private static TlsOverPerCoreLockedStacksArrayPool`1() { }

	[CalledBy(Type = typeof(ArrayPool`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public TlsOverPerCoreLockedStacksArrayPool`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerCoreLockedStacks), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private PerCoreLockedStacks<T> CreatePerCoreLockedStacks(int bucketIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private static bool Gen2GcCallbackFunc(object target) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private int get_Id() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "GetMemoryInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&), typeof(UInt64&), typeof(UInt32&), typeof(UIntPtr&), typeof(UIntPtr&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static MemoryPressure<T> GetMemoryPressure() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private static bool GetTrimBuffers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utilities), Member = "SelectBucketIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferRented", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferAllocated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(BufferAllocatedReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual T[] Rent(int minimumLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utilities), Member = "SelectBucketIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PerCoreLockedStacks), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferReturned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Gen2GcCallback), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Object, System.Boolean>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	[DeduplicatedMethod]
	public virtual void Return(T[] array, bool clearArray = false) { }

	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Gen2GcCallbackFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GC), Member = "GetMemoryInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&), typeof(UInt64&), typeof(UInt32&), typeof(UIntPtr&), typeof(UIntPtr&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimPoll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PerCoreLockedStacks), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>", typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayPoolEventSource), Member = "BufferTrimmed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 32)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Trim() { }

}

