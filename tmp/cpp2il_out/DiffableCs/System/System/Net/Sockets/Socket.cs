namespace System.Net.Sockets;

public class Socket : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CachedEventArgs> <>9__14_0; //Field offset: 0x8
		public static Func<AwaitableSocketAsyncEventArgs> <>9__14_1; //Field offset: 0x10
		public static AsyncCallback <>9__15_0; //Field offset: 0x18
		public static AsyncCallback <>9__15_1; //Field offset: 0x20
		public static Func<CachedEventArgs> <>9__22_0; //Field offset: 0x28
		public static Func<AwaitableSocketAsyncEventArgs> <>9__22_1; //Field offset: 0x30
		public static AsyncCallback <>9__23_0; //Field offset: 0x38
		public static AsyncCallback <>9__23_1; //Field offset: 0x40
		public static IOAsyncCallback <>9__295_0; //Field offset: 0x48
		public static IOAsyncCallback <>9__297_0; //Field offset: 0x50
		public static IOAsyncCallback <>9__310_0; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1<Object>", Member = "GetCompletionResponsibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>))]
		[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "CompleteSendReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), "System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs", typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 19)]
		internal void <.cctor>b__367_10(IAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Memory`1), Member = "Pin", ReturnType = typeof(MemoryHandle))]
		[Calls(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		internal void <.cctor>b__367_11(IOAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.ArraySegment`1<System.Byte>>), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		internal void <.cctor>b__367_12(IOAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 26)]
		internal void <.cctor>b__367_13(IAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "ReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint&), typeof(SocketError&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal void <.cctor>b__367_14(IOAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 19)]
		internal void <.cctor>b__367_15(IAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.ArraySegment`1<System.Byte>>), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		internal void <.cctor>b__367_16(IOAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 19)]
		internal void <.cctor>b__367_17(IAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "CompleteSendReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), "System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs", typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 19)]
		internal void <.cctor>b__367_3(IAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal void <.cctor>b__367_4(IOAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
		[Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		internal void <.cctor>b__367_5(IOAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 19)]
		internal void <.cctor>b__367_6(IAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 15)]
		internal void <.cctor>b__367_7(IOAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
		[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 21)]
		internal void <.cctor>b__367_8(IAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "Disconnect_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		internal void <.cctor>b__367_9(IOAsyncResult ares) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <BeginSend>b__297_0(IOAsyncResult s) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "BeginSendToCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <BeginSendTo>b__310_0(IOAsyncResult s) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal CachedEventArgs <ReceiveAsync>b__14_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		internal AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 8)]
		internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(ReadOnlyMemory`1), Member = "get_Span", ReturnType = "System.ReadOnlySpan`1<T>")]
		[Calls(Type = typeof(Memory`1), Member = "get_Span", ReturnType = "System.Span`1<T>")]
		[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 21)]
		internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <SendAsync>b__295_0(IOAsyncResult s) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 8)]
		internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 16)]
		internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		internal AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass240_0
	{
		public SocketAsyncResult sockares; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass240_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_IsFaulted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "get_IsCanceled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
		[Calls(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "get_Exception", ReturnType = typeof(AggregateException))]
		[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal void <BeginConnect>b__0(Task<IPAddress[]> t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass298_0
	{
		public int sent_so_far; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass298_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass311_0
	{
		public int sent_so_far; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass311_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "BeginSendToCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <BeginSendToCallback>b__0(IOAsyncResult s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass355_0
	{
		public Socket <>4__this; //Field offset: 0x10
		public IOSelectorJob job; //Field offset: 0x18
		public IntPtr handle; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass355_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(IOSelectorJob), Member = "MarkDisposed", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <QueueIOSelectorJob>b__0(Task t) { }

	}

	public sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<Int32>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static ContextCallback <>9__14_0; //Field offset: 0x8
			public static SendOrPostCallback <>9__20_0; //Field offset: 0x10

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			internal void <.cctor>b__27_0(object state) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			internal void <.cctor>b__27_1(object state) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			internal void <InvokeContinuation>b__20_0(object s) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "InvokeContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			internal void <OnCompleted>b__14_0(object runState) { }

		}

		internal static readonly AwaitableSocketAsyncEventArgs Reserved; //Field offset: 0x0
		private static readonly Action<Object> s_completedSentinel; //Field offset: 0x8
		private static readonly Action<Object> s_availableSentinel; //Field offset: 0x10
		private Action<Object> _continuation; //Field offset: 0xB8
		private ExecutionContext _executionContext; //Field offset: 0xC0
		private object _scheduler; //Field offset: 0xC8
		private short _token; //Field offset: 0xD0
		[CompilerGenerated]
		private bool <WrapExceptionsInIOExceptions>k__BackingField; //Field offset: 0xD2

		public bool WrapExceptionsInIOExceptions
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 set { } //Length: 7
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private static AwaitableSocketAsyncEventArgs() { }

		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<ReceiveAsync>b__14_1", ReturnType = typeof(AwaitableSocketAsyncEventArgs))]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<SendAsyncForNetworkStream>b__22_1", ReturnType = typeof(AwaitableSocketAsyncEventArgs))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public AwaitableSocketAsyncEventArgs() { }

		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(ValueTask))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ThrowException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private Exception CreateException(SocketError error) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public bool get_WrapExceptionsInIOExceptions() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ThrowIncorrectTokenException", ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ThrowException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(void))]
		public override int GetResult(short token) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ThrowIncorrectTokenException", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		public override ValueTaskSourceStatus GetStatus(short token) { }

		[CalledBy(Type = typeof(<>c), Member = "<OnCompleted>b__14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<TState>", "TState", typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(System.Tuple`2<System.Object, System.Object>))]
		[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		private void InvokeContinuation(Action<Object> continuation, object state, bool forceAsync) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(System.Tuple`3<System.Object, System.Object, System.Object>))]
		[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "InvokeContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		protected virtual void OnCompleted(SocketAsyncEventArgs _) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "InvokeContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ThrowIncorrectTokenException", ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ThrowMultipleContinuationsException", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public override void OnCompleted(Action<Object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public ValueTask<Int32> ReceiveAsync(Socket socket) { }

		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(ValueTask))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "System.Threading.Tasks.Sources.IValueTaskSource.GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		private void Release() { }

		[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
		[CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool Reserve() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public ValueTask SendAsyncForNetworkStream(Socket socket) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public void set_WrapExceptionsInIOExceptions(bool value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ThrowException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ThrowIncorrectTokenException", ReturnType = typeof(void))]
		private override void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token) { }

		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "System.Threading.Tasks.Sources.IValueTaskSource.GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		private void ThrowException(SocketError error) { }

		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "GetStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(ValueTaskSourceStatus))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "System.Threading.Tasks.Sources.IValueTaskSource.GetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private void ThrowIncorrectTokenException() { }

		[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private void ThrowMultipleContinuationsException() { }

	}

	private sealed class CachedEventArgs
	{
		public TaskSocketAsyncEventArgs<Socket> TaskAccept; //Field offset: 0x10
		public Int32TaskSocketAsyncEventArgs TaskReceive; //Field offset: 0x18
		public Int32TaskSocketAsyncEventArgs TaskSend; //Field offset: 0x20
		public AwaitableSocketAsyncEventArgs ValueTaskReceive; //Field offset: 0x28
		public AwaitableSocketAsyncEventArgs ValueTaskSend; //Field offset: 0x30

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CachedEventArgs() { }

	}

	private sealed class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs<Int32>
	{
		internal bool _wrapExceptionsInIOExceptions; //Field offset: 0xD8

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1", Member = ".ctor", ReturnType = typeof(void))]
		public Int32TaskSocketAsyncEventArgs() { }

	}

	private class TaskSocketAsyncEventArgs : SocketAsyncEventArgs
	{
		internal AsyncTaskMethodBuilder<TResult> _builder; //Field offset: 0x0
		internal bool _accessed; //Field offset: 0x0

		[CalledBy(Type = "System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SocketAsyncEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal TaskSocketAsyncEventArgs`1() { }

		[CalledBy(Type = typeof(Socket), Member = "CompleteSendReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), "System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool) { }

	}

	private struct WSABUF
	{
		public int len; //Field offset: 0x0
		public IntPtr buf; //Field offset: 0x8

	}

	private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler; //Field offset: 0x0
	private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond"; //Field offset: 0x0
	private const int SOCKET_CLOSED_CODE = 10004; //Field offset: 0x0
	internal const int DefaultCloseTimeout = -1; //Field offset: 0x0
	private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler; //Field offset: 0x8
	private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler; //Field offset: 0x10
	private static readonly TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel; //Field offset: 0x18
	private static readonly Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; //Field offset: 0x20
	private static readonly Task<Int32> s_zeroTask; //Field offset: 0x28
	private static object s_InternalSyncObject; //Field offset: 0x30
	internal static bool s_SupportsIPv4; //Field offset: 0x38
	internal static bool s_SupportsIPv6; //Field offset: 0x39
	internal static bool s_OSSupportsIPv6; //Field offset: 0x3A
	internal static bool s_Initialized; //Field offset: 0x3B
	private static bool s_LoggingEnabled; //Field offset: 0x3C
	internal static bool s_PerfCountersEnabled; //Field offset: 0x3D
	private static AsyncCallback AcceptAsyncCallback; //Field offset: 0x40
	private static IOAsyncCallback BeginAcceptCallback; //Field offset: 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; //Field offset: 0x50
	private static AsyncCallback ConnectAsyncCallback; //Field offset: 0x58
	private static IOAsyncCallback BeginConnectCallback; //Field offset: 0x60
	private static AsyncCallback DisconnectAsyncCallback; //Field offset: 0x68
	private static IOAsyncCallback BeginDisconnectCallback; //Field offset: 0x70
	private static AsyncCallback ReceiveAsyncCallback; //Field offset: 0x78
	private static IOAsyncCallback BeginReceiveCallback; //Field offset: 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; //Field offset: 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; //Field offset: 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; //Field offset: 0x98
	private static AsyncCallback SendAsyncCallback; //Field offset: 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; //Field offset: 0xA8
	private static AsyncCallback SendToAsyncCallback; //Field offset: 0xB0
	private CachedEventArgs _cachedTaskEventArgs; //Field offset: 0x10
	private bool is_closed; //Field offset: 0x18
	private bool is_listening; //Field offset: 0x19
	private bool useOverlappedIO; //Field offset: 0x1A
	private int linger_timeout; //Field offset: 0x1C
	private AddressFamily addressFamily; //Field offset: 0x20
	private SocketType socketType; //Field offset: 0x24
	private ProtocolType protocolType; //Field offset: 0x28
	internal SafeSocketHandle m_Handle; //Field offset: 0x30
	internal EndPoint seed_endpoint; //Field offset: 0x38
	internal SemaphoreSlim ReadSem; //Field offset: 0x40
	internal SemaphoreSlim WriteSem; //Field offset: 0x48
	internal bool is_blocking; //Field offset: 0x50
	internal bool is_bound; //Field offset: 0x51
	internal bool is_connected; //Field offset: 0x52
	private int m_IntCleanedUp; //Field offset: 0x54
	internal bool connect_in_progress; //Field offset: 0x58
	internal readonly int ID; //Field offset: 0x5C

	public AddressFamily AddressFamily
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool Blocking
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
		[CalledBy(Type = typeof(Socket), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "Blocking_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 199
	}

	internal bool CleanedUp
	{
		[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	public bool Connected
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool DontFragment
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 146
	}

	public bool DualMode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 196
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 152
	}

	public bool ExclusiveAddressUse
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 149
	}

	internal static int FamilyHint
	{
		[CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IPHostEntry))]
		[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
		[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(IPHostEntry))]
		[CalledBy(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 303
	}

	public IntPtr Handle
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	private static object InternalSyncObject
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 234
	}

	public bool IsBound
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private bool IsDualMode
	{
		[CalledBy(Type = typeof(Socket), Member = "CanTryAddressFamily", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 94
	}

	public EndPoint LocalEndPoint
	{
		[CalledBy(Type = "Mono.Nat.Searcher+<ListenOneAsync>d__30", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpConnection), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
		[CalledBy(Type = typeof(HttpListenerRequest), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "LocalEndPoint_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(int), typeof(Int32&)}, ReturnType = typeof(SocketAddress))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 244
	}

	public bool NoDelay
	{
		[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	public static bool OSSupportsIPv4
	{
		[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
		[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 94
	}

	public static bool OSSupportsIPv6
	{
		[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
		[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 94
	}

	public ProtocolType ProtocolType
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public EndPoint RemoteEndPoint
	{
		[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
		[CalledBy(Type = typeof(NetworkStreamWrapper), Member = "get_ServerAddress", ReturnType = typeof(IPAddress))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
		[Calls(Type = typeof(Socket), Member = "RemoteEndPoint_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(int), typeof(Int32&)}, ReturnType = typeof(SocketAddress))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 250
	}

	public SocketType SocketType
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskSocketAsyncEventArgs`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 21)]
	private static Socket() { }

	[CalledBy(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "float2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.float2", "Unity.Mathematics.float2", "Unity.Mathematics.float2"}, ReturnType = "Unity.Mathematics.float2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "int2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.int2", "Unity.Mathematics.int2", "Unity.Mathematics.int2"}, ReturnType = "Unity.Mathematics.int2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "uint2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.uint2", "Unity.Mathematics.uint2", "Unity.Mathematics.uint2"}, ReturnType = "Unity.Mathematics.uint2x3")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(UdpClient), Member = "createClientSocket", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = "initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpDataSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest), typeof(Socket)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "SocketDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Int32&), typeof(bool)}, ReturnType = typeof(SafeSocketHandle))]
	[Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void Accept(Socket acceptSocket) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Accept_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Int32&), typeof(bool)}, ReturnType = typeof(SafeSocketHandle))]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType), typeof(SafeSocketHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Socket Accept() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	[CalledBy(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(SocketAsyncEventArgs), typeof(Socket&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs), typeof(AsyncCallback), typeof(object), typeof(SocketOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public bool AcceptAsync(SocketAsyncEventArgs e) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(TcpClient), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dns), Member = "GetHostAddressesAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<IPAddress[]>))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task`1<System.Object>>), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(TcpClient), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(Socket), Member = "get_IsDualMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 28)]
	public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = "System.Net.WebConnection+<>c", Member = "<Connect>b__16_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass240_0), Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<IPAddress[]>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "get_IsDualMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	[CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(UdpClient), Member = "BeginReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(UdpClient), Member = "<ReceiveAsync>b__65_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public IAsyncResult BeginReceiveFrom(Byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(IPEndPoint))]
	[Calls(Type = typeof(Socket), Member = "get_IsDualMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Connect_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketAddress), typeof(Int32&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "SendAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(UdpClient), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IPEndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(<>c), Member = "<SendAsync>b__295_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<BeginSend>b__297_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass298_0), Member = "<BeginSendCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Memory`1), Member = "Pin", ReturnType = typeof(MemoryHandle))]
	[Calls(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	[CalledBy(Type = typeof(UdpClient), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IPEndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public IAsyncResult BeginSendTo(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	[CalledBy(Type = typeof(<>c), Member = "<BeginSendTo>b__310_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass311_0), Member = "<BeginSendToCallback>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "SendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePoint), Member = "CallEndPointDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(IPEndPoint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TcpListener), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AddressFamily)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(IPEndPoint))]
	[Calls(Type = typeof(Socket), Member = "Bind_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketAddress), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void Bind(EndPoint localEP) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void Blocking_icall(IntPtr socket, bool block, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "get_IsDualMode", ReturnType = typeof(bool))]
	internal bool CanTryAddressFamily(AddressFamily family) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Close(int timeout) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "AbortConnect", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "uint2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.uint2", "Unity.Mathematics.uint2", "Unity.Mathematics.uint2"}, ReturnType = "Unity.Mathematics.uint2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "int2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.int2", "Unity.Mathematics.int2", "Unity.Mathematics.int2"}, ReturnType = "Unity.Mathematics.int2x3")]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "float2x3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.float2", "Unity.Mathematics.float2", "Unity.Mathematics.float2"}, ReturnType = "Unity.Mathematics.float2x3")]
	[CalledBy(Type = typeof(UdpClient), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "FreeResources", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(SocketAsyncEventArgs), typeof(Socket&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Close() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void Close_icall(IntPtr socket, out int error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1<System.Object>), Member = "GetCompletionResponsibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void CompleteAccept(Socket s, TaskSocketAsyncEventArgs<Socket> saea) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TaskSocketAsyncEventArgs`1), Member = "GetCompletionResponsibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
	[Calls(Type = typeof(Socket), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError), typeof(bool)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(IPEndPoint))]
	[Calls(Type = typeof(Socket), Member = "Connect_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketAddress), typeof(Int32&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	public void Connect(EndPoint remoteEP) { }

	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	public void Connect(IPAddress address, int port) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Disconnect_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Disconnect(bool reuseSocket) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void Disconnect_icall(IntPtr sock, bool reuse, out int error) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Disconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	[CalledBy(Type = typeof(WebConnection), Member = "CloseSocket", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpListener), Member = "EndAcceptTcpClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(TcpClient))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Memory`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Socket EndAccept(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Memory`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Socket EndAccept(out Byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "ConnectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection+<>c", Member = "<Connect>b__16_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EndConnect(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EndDisconnect(IAsyncResult asyncResult) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(<>c), Member = "<ReceiveAsyncApm>b__15_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "get_ErrorCode", ReturnType = typeof(SocketError))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public int EndReceive(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "get_ErrorCode", ReturnType = typeof(SocketError))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<SendAsyncApm>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<SendAsyncApm>b__23_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "get_ErrorCode", ReturnType = typeof(SocketError))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public int EndSend(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "get_ErrorCode", ReturnType = typeof(SocketError))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_17", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ValidateEndIAsyncResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(string), typeof(string)}, ReturnType = typeof(SocketAsyncResult))]
	[Calls(Type = typeof(IOAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(SocketAsyncResult), Member = "CheckIfThrowDelayedException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int EndSendTo(IAsyncResult asyncResult) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AddressFamily get_AddressFamily() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public bool get_Blocking() { }

	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool get_CleanedUp() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Connected() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool get_DualMode() { }

	[CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int get_FamilyHint() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public IntPtr get_Handle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object get_InternalSyncObject() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsBound() { }

	[CalledBy(Type = typeof(Socket), Member = "CanTryAddressFamily", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool get_IsDualMode() { }

	[CalledBy(Type = "Mono.Nat.Searcher+<ListenOneAsync>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpConnection), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
	[CalledBy(Type = typeof(HttpListenerRequest), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "LocalEndPoint_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(int), typeof(Int32&)}, ReturnType = typeof(SocketAddress))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public EndPoint get_LocalEndPoint() { }

	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_OSSupportsIPv4() { }

	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "InitializeSockets", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static bool get_OSSupportsIPv6() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ProtocolType get_ProtocolType() { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(NetworkStreamWrapper), Member = "get_ServerAddress", ReturnType = typeof(IPAddress))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "RemoteEndPoint_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(int), typeof(Int32&)}, ReturnType = typeof(SocketAddress))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public EndPoint get_RemoteEndPoint() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public SocketType get_SocketType() { }

	[CalledBy(Type = typeof(Socket), Member = "CompleteSendReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(Int32TaskSocketAsyncEventArgs), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "get_ReadTimeout", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NetworkStream), Member = "get_WriteTimeout", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "get_DualMode", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "get_IsDualMode", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "Poll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SelectMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(IPEndPoint))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "GetSocketOption_obj_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "get_OSSupportsIPv4", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "get_OSSupportsIPv6", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType), typeof(SafeSocketHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "get_FamilyHint", ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal static void InitializeSockets() { }

	[CalledBy(Type = typeof(Socket), Member = "AcceptAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IOAsyncResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "FreeResources", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = "Shutdown_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketShutdown), typeof(Int32&)}, ReturnType = typeof(void))]
	internal void InternalShutdown(SocketShutdown how) { }

	[CalledBy(Type = typeof(ServicePoint), Member = "KeepAliveSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "IOControl_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(int), typeof(Byte[]), typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public int IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "IOControl_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(int), typeof(Byte[]), typeof(Byte[]), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public int IOControl(int ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int IOControl_icall(IntPtr sock, int ioctl_code, Byte[] input, Byte[] output, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "IOControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOControlCode), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "IOControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Byte[] input, Byte[] output, out int error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void Linger(IntPtr handle) { }

	[CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpListener), typeof(IPAddress), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Listen_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Listen(int backlog) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void Listen_icall(IntPtr sock, int backlog, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpListener), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	[CalledBy(Type = typeof(WebConnection), Member = "CanReuse", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebConnection), Member = "CheckReusable", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Poll_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SelectMode), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public bool Poll(int microSeconds, SelectMode mode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "Poll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SelectMode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "AcceptAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TcpListener), Member = "BeginAcceptTcpClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "BeginAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "WaitAsync", ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(IOSelector), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOSelectorJob), Member = "MarkDisposed", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.ArraySegment`1<System.Byte>>), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int Receive(IList<ArraySegment`1<Byte>> buffers, SocketFlags socketFlags) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Memory`1), Member = "Pin", ReturnType = typeof(MemoryHandle))]
	[Calls(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private int Receive(Memory<Byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public int Receive(Span<Byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.ArraySegment`1<System.Byte>>), typeof(SocketFlags)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(WSABUF*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	[CLSCompliant(False)]
	public int Receive(IList<ArraySegment`1<Byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NetworkStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Receive_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int Receive_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.ArraySegment`1<System.Byte>>), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static int Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs), typeof(AsyncCallback), typeof(object), typeof(SocketOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOAsyncResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(NetworkStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "Reserve", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "ReceiveAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketAsyncEventArgs), Member = "SetBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal ValueTask<Int32> ReceiveAsync(Memory<Byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(SocketFlags), typeof(bool), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = "System.Tuple`3<T1, T2, T3>")]
	[Calls(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private Task<Int32> ReceiveAsyncApm(Memory<Byte> buffer, SocketFlags socketFlags) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_14", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Memory`1), Member = "Pin", ReturnType = typeof(MemoryHandle))]
	[Calls(Type = typeof(Socket), Member = "ReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(SocketAddress&), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private int ReceiveFrom(Memory<Byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int ReceiveFrom_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "ReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint&), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "GetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(IPAddress), Member = "MapToIPv6", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs<Socket> saea) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int Send(ReadOnlySpan<Byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.ArraySegment`1<System.Byte>>), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int Send(IList<ArraySegment`1<Byte>> buffers, SocketFlags socketFlags) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.ArraySegment`1<System.Byte>>), typeof(SocketFlags)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(WSABUF*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	[CLSCompliant(False)]
	public int Send(IList<ArraySegment`1<Byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfBufferOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Send_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int Send_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static int Send_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.ArraySegment`1<System.Byte>>), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	[CalledBy(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs), typeof(AsyncCallback), typeof(object), typeof(SocketOperation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IOAsyncResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Socket), Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), typeof(IOSelectorJob)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	public bool SendAsync(SocketAsyncEventArgs e) { }

	[CalledBy(Type = typeof(Socket), Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyMemory`1), Member = "get_Span", ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.TaskCompletionSource`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(System.Tuple`2<System.Object, System.Object>))]
	[Calls(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private Task<Int32> SendAsyncApm(ReadOnlyMemory<Byte> buffer, SocketFlags socketFlags) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(NetworkStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "Reserve", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "SendAsyncApm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(SocketFlags)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ExceptionArgument"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SocketAsyncEventArgs), Member = "SetBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(AwaitableSocketAsyncEventArgs), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketError)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<Byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	[CalledBy(Type = typeof(Socket), Member = "BeginSendToCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Memory`1), Member = "Pin", ReturnType = typeof(MemoryHandle))]
	[Calls(Type = typeof(Socket), Member = "SendTo_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(Byte*), typeof(int), typeof(SocketFlags), typeof(SocketAddress), typeof(Int32&), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MemoryHandle), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private int SendTo(Memory<Byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int SendTo_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "SendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeSocketHandle), Member = "RegisterForBlockingSyscall", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSocketHandle), Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static int SendTo_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	[CalledBy(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "Accept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Blocking_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void set_Blocking(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_DontFragment(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_DualMode(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void set_ExclusiveAddressUse(bool value) { }

	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void set_NoDelay(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(object), typeof(Byte[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue) { }

	[CalledBy(Type = "Manager.P2PManager+<StartListener>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	[CalledBy(Type = typeof(NetworkStream), Member = "SetSocketTimeoutOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(object), typeof(Byte[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher", Member = "Create", ReturnType = "Mono.Nat.Upnp.UpnpSearcher")]
	[CalledBy(Type = typeof(UdpClient), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IPEndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(UdpClient), Member = "CheckForBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "set_NoDelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "SocketDefaults", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "set_DualMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "set_DontFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "set_ExclusiveAddressUse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "SetIPProtectionLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPProtectionLevel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(object), typeof(Byte[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, out int error) { }

	[CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Shutdown_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeSocketHandle), typeof(SocketShutdown), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Shutdown(SocketShutdown how) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = "InternalShutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "Shutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	[CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "ThrowIfDisposedAndClosed", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SocketDefaults() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void ThrowIfBufferNull(Byte[] buffer) { }

	[CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "BeginReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(SocketError&), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(Socket), Member = "BeginSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(SocketFlags), typeof(EndPoint), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	private void ThrowIfBufferOutOfRange(Byte[] buffer, int offset, int size) { }

	[CallerCount(Count = 51)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void ThrowIfDisposedAndClosed() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ThrowIfUdp() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__367_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(IPEndPoint&)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(EndPoint&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&), typeof(Int32&), typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

}

