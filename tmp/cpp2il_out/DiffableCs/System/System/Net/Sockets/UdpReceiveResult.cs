namespace System.Net.Sockets;

public struct UdpReceiveResult : IEquatable<UdpReceiveResult>
{
	private Byte[] m_buffer; //Field offset: 0x0
	private IPEndPoint m_remoteEndPoint; //Field offset: 0x8

	public Byte[] Buffer
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public IPEndPoint RemoteEndPoint
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public UdpReceiveResult(Byte[] buffer, IPEndPoint remoteEndPoint) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public override bool Equals(UdpReceiveResult other) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Byte[] get_Buffer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public IPEndPoint get_RemoteEndPoint() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

}

