namespace System;

internal abstract class IOAsyncResult : IAsyncResult
{
	private AsyncCallback async_callback; //Field offset: 0x10
	private object async_state; //Field offset: 0x18
	private ManualResetEvent wait_handle; //Field offset: 0x20
	private bool completed_synchronously; //Field offset: 0x28
	private bool completed; //Field offset: 0x29

	public AsyncCallback AsyncCallback
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override object AsyncState
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override WaitHandle AsyncWaitHandle
	{
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(IPEndPoint&)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(EndPoint&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&), typeof(Int32&), typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
		[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
		[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 235
	}

	public override bool CompletedSynchronously
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool IsCompleted
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 160
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IOAsyncResult() { }

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected IOAsyncResult(AsyncCallback async_callback, object async_state) { }

	internal abstract void CompleteDisposed() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public AsyncCallback get_AsyncCallback() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override object get_AsyncState() { }

	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_13", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]&), typeof(Int32&), typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(EndPoint&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndReceiveFrom_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult), typeof(SocketAsyncEventArgs)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(SocketError&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Socket), Member = "EndSendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult), typeof(IPEndPoint&)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(Socket), Member = "EndDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override WaitHandle get_AsyncWaitHandle() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_CompletedSynchronously() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_IsCompleted() { }

	[CalledBy(Type = typeof(Socket), Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "InitSocketAsyncEventArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncEventArgs), typeof(AsyncCallback), typeof(object), typeof(SocketOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(AsyncCallback), typeof(object), typeof(SocketOperation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	protected void Init(AsyncCallback async_callback, object async_state) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected void set_CompletedSynchronously(bool value) { }

	[CalledBy(Type = typeof(SocketAsyncResult), Member = "Complete", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void set_IsCompleted(bool value) { }

}

