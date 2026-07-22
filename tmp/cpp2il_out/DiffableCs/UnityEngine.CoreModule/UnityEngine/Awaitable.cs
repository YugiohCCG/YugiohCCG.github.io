namespace UnityEngine;

[AsyncMethodBuilder(typeof(AwaitableAsyncMethodBuilder))]
[NativeHeader("Runtime/Mono/DelayedCallAwaitable.h")]
[NativeHeader("Runtime/Mono/AsyncOperationAwaitable.h")]
[NativeHeader("Runtime/Mono/Awaitable.h")]
public class Awaitable : IEnumerator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Object> <>9__26_0; //Field offset: 0x8
		public static Func<Awaitable> <>9__76_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal ObjectPool<Awaitable> <.cctor>b__76_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal Awaitable <.cctor>b__76_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Awaitable), Member = "Cancel", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <WireupCancellation>b__26_0(object coroutine) { }

	}

	private struct AwaitableAndFrameIndex
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly Awaitable <Awaitable>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private readonly int <FrameIndex>k__BackingField; //Field offset: 0x8

		public Awaitable Awaitable
		{
			[CallerCount(Count = 138)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public int FrameIndex
		{
			[CallerCount(Count = 28)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
		}

		[CallerCount(Count = 138)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Awaitable get_Awaitable() { }

		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_FrameIndex() { }

	}

	[ExcludeFromDocs]
	internal struct AwaitableAsyncMethodBuilder
	{
		private interface IStateMachineBox : IDisposable
		{

		}

		private IStateMachineBox _stateMachineBox; //Field offset: 0x0
		private Awaitable _resultingCoroutine; //Field offset: 0x8

	}

	[IsReadOnly]
	private struct AwaitableHandle
	{
		public static AwaitableHandle ManagedHandle; //Field offset: 0x0
		public static AwaitableHandle NullHandle; //Field offset: 0x8
		private readonly IntPtr _handle; //Field offset: 0x0

		public bool IsManaged
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 90
		}

		public bool IsNull
		{
			[CallerCount(Count = 13)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private static AwaitableHandle() { }

		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		public AwaitableHandle(IntPtr handle) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_IsManaged() { }

		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_IsNull() { }

		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		public static IntPtr op_Implicit(AwaitableHandle handle) { }

		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		public static AwaitableHandle op_Implicit(IntPtr handle) { }

	}

	[ExcludeFromDocs]
	internal struct Awaiter : INotifyCompletion
	{
		private readonly Awaitable _awaited; //Field offset: 0x0

		public bool IsCompleted
		{
			[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Manager.Updater+<LoadManifest>d__34", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Extensions.AsyncExtensions+<Await>d__3", Member = "MoveNext", ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(Awaitable), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 28
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Awaiter(Awaitable awaited) { }

		[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater+<LoadManifest>d__34", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.AsyncExtensions+<Await>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Awaitable), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool get_IsCompleted() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Awaitable), Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void GetResult() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Awaitable), Member = "SetContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void OnCompleted(Action continuation) { }

	}

	public enum AwaiterCompletionThreadAffinity
	{
		None = 0,
		MainThread = 1,
		BackgroundThread = 2,
	}

	private class DoubleBufferedAwaitableList
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public Awaitable item; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass4_0() { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal bool <Remove>b__0(AwaitableAndFrameIndex x) { }

		}

		private List<AwaitableAndFrameIndex> _awaitables; //Field offset: 0x10
		private List<AwaitableAndFrameIndex> _scratch; //Field offset: 0x18

		[CalledBy(Type = typeof(Awaitable), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public DoubleBufferedAwaitableList() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public void Remove(Awaitable item) { }

		[CalledBy(Type = typeof(Awaitable), Member = "OnUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Awaitable), Member = "OnEndOfFrame", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Awaitable), Member = "get_IsDettachedOrCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		public void SwapAndComplete() { }

	}

	private static readonly ThreadLocal<ObjectPool`1<Awaitable>> _pool; //Field offset: 0x0
	private static bool _nextFrameAndEndOfFrameWiredUp; //Field offset: 0x8
	private static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration; //Field offset: 0x10
	private static readonly DoubleBufferedAwaitableList _nextFrameAwaitables; //Field offset: 0x28
	private static readonly DoubleBufferedAwaitableList _endOfFrameAwaitables; //Field offset: 0x30
	private static SynchronizationContext _synchronizationContext; //Field offset: 0x38
	private static int _mainThreadId; //Field offset: 0x40
	private SpinLock _spinLock; //Field offset: 0x10
	private AwaitableHandle _handle; //Field offset: 0x18
	private ExceptionDispatchInfo _exceptionToRethrow; //Field offset: 0x20
	private bool _managedAwaitableDone; //Field offset: 0x28
	private AwaiterCompletionThreadAffinity _completionThreadAffinity; //Field offset: 0x2C
	private Action _continuation; //Field offset: 0x30
	private Nullable<CancellationTokenRegistration> _cancelTokenRegistration; //Field offset: 0x38
	private DoubleBufferedAwaitableList _managedCompletionQueue; //Field offset: 0x58

	public bool IsCompleted
	{
		[CalledBy(Type = typeof(Awaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Awaitable), Member = "System.Collections.IEnumerator.MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 483
	}

	private bool IsCompletedNoLock
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 317
	}

	internal bool IsDettachedOrCompleted
	{
		[CalledBy(Type = typeof(DoubleBufferedAwaitableList), Member = "SwapAndComplete", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 497
	}

	private bool IsLogicallyCompletedNoLock
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 269
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadLocal`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBufferedAwaitableList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Awaitable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Awaitable() { }

	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Scripting::Awaitables::AttachManagedWrapper", IsThreadSafe = True)]
	private static void AttachManagedGCHandleToNativeAwaitable(IntPtr nativeAwaitable, UIntPtr gcHandle) { }

	[CalledBy(Type = typeof(<>c), Member = "<WireupCancellation>b__26_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Cancel() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Scripting::Awaitables::Cancel", IsThreadSafe = True)]
	private static void CancelNativeAwaitable(IntPtr nativeAwaitable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private AwaitableHandle CheckPointerValidity() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void DoRunContinuationOnSynchonizationContext(object continuation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static Awaitable FromAsyncOperation(AsyncOperation op, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<LoadManifest>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.AsyncExtensions+<Await>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Scripting::Awaitables::FromAsyncOperation", ThrowsException = True)]
	private static IntPtr FromAsyncOperationInternal(IntPtr asyncOperation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static Awaitable FromNativeAwaitableHandle(IntPtr nativeHandle, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(Awaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Awaitable), Member = "System.Collections.IEnumerator.MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public bool get_IsCompleted() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private bool get_IsCompletedNoLock() { }

	[CalledBy(Type = typeof(DoubleBufferedAwaitableList), Member = "SwapAndComplete", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsDettachedOrCompleted() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool get_IsLogicallyCompletedNoLock() { }

	[CallerCount(Count = 778)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public Awaiter GetAwaiter() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Scripting::Awaitables::IsCompleted", IsThreadSafe = True)]
	private static int IsNativeAwaitableCompleted(IntPtr nativeAwaitable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool MatchCompletionThreadAffinity(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void OnDelayedCallManagerCleared() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBufferedAwaitableList), Member = "SwapAndComplete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void OnEndOfFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleBufferedAwaitableList), Member = "SwapAndComplete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void OnUpdate() { }

	[CalledBy(Type = "Manager.ImageHandler+<UpdateFile>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<LoadManifest>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.AsyncExtensions+<Await>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Awaiter), Member = "GetResult", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Awaitable), Member = "System.Collections.IEnumerator.MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	internal void PropagateExceptionAndRelease() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Awaitable), Member = "RunOrScheduleContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AwaiterCompletionThreadAffinity), typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void RaiseManagedCompletion() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(Awaitable), Member = "RunOrScheduleContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AwaiterCompletionThreadAffinity), typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void RaiseManagedCompletion(Exception exception) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Scripting::Awaitables::Release", IsThreadSafe = True)]
	private static void ReleaseNativeAwaitable(IntPtr nativeAwaitable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[RequiredByNativeCode(GenerateProxy = True)]
	private void RunContinuation() { }

	[CalledBy(Type = typeof(UnityLogWriter), Member = "get_Encoding", ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Awaitable), Member = "RaiseManagedCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Awaitable), Member = "RaiseManagedCompletion", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Awaitable), Member = "SetContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RunOrScheduleContinuation(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, Action continuation) { }

	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Awaiter), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Awaitable), Member = "RunOrScheduleContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AwaiterCompletionThreadAffinity), typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal void SetContinuation(Action continuation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CallsUnknownMethods(Count = 4)]
	[RequiredByNativeCode(GenerateProxy = True)]
	private void SetExceptionFromNative(Exception ex) { }

	[CalledBy(Type = typeof(UnitySynchronizationContext), Member = "InitializeSynchronizationContext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void SetSynchronizationContext(UnitySynchronizationContext synchronizationContext) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.Collections.IEnumerator.get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Awaitable), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Awaitable), Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.Collections.IEnumerator.Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContext), Member = "SuppressFlow", ReturnType = typeof(AsyncFlowControl))]
	[Calls(Type = typeof(CancellationToken), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncFlowControl), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private static void WireupCancellation(Awaitable awaitable, CancellationToken cancellationToken) { }

}

