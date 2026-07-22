namespace System.Threading;

[DefaultMember("Item")]
internal class SparselyPopulatedArrayFragment
{
	internal readonly T[] _elements; //Field offset: 0x0
	internal int _freeCount; //Field offset: 0x0
	internal SparselyPopulatedArrayFragment<T> _next; //Field offset: 0x0
	internal SparselyPopulatedArrayFragment<T> _prev; //Field offset: 0x0

	internal T Item
	{
		[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 53
	}

	internal int Length
	{
		[CallerCount(Count = 36)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 26
	}

	internal SparselyPopulatedArrayFragment<T> Prev
	{
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 24
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SparselyPopulatedArrayFragment`1(int size) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal SparselyPopulatedArrayFragment`1(int size, SparselyPopulatedArrayFragment<T> prev) { }

	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal T get_Item(int index) { }

	[CallerCount(Count = 36)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal int get_Length() { }

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }

	[CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Unregister", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(SynchronizationContext), typeof(ExecutionContext)}, ReturnType = typeof(CancellationTokenRegistration))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "CancellationCallbackCoreWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackCoreWorkArguments)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal T SafeAtomicRemove(int index, T expectedElement) { }

}

