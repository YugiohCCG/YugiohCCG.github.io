namespace System.Buffers;

public struct MemoryHandle : IDisposable
{
	private Void* _pointer; //Field offset: 0x0
	private GCHandle _handle; //Field offset: 0x8
	private IPinnable _pinnable; //Field offset: 0x10

	[CLSCompliant(False)]
	public Void* Pointer
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(Memory`1), Member = "Pin", ReturnType = typeof(MemoryHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public MemoryHandle(Void* pointer, GCHandle handle = null, IPinnable pinnable = null) { }

	[CalledBy(Type = "System.Net.Sockets.Socket+<>c", Member = "<.cctor>b__367_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IOAsyncResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint&", "System.Net.Sockets.SocketError&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSendCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncResult", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", typeof(int), typeof(int), "System.Net.Sockets.SocketFlags", "System.Net.EndPoint"}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Void* get_Pointer() { }

}

