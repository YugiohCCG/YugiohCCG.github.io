namespace System.Net;

[DefaultMember("Item")]
public class SocketAddress
{
	internal int m_Size; //Field offset: 0x10
	internal Byte[] m_Buffer; //Field offset: 0x18
	private bool m_changed; //Field offset: 0x20
	private int m_hash; //Field offset: 0x24

	public AddressFamily Family
	{
		[CalledBy(Type = typeof(IPEndPoint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAddress)}, ReturnType = typeof(EndPoint))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 54
	}

	public byte Item
	{
		[CalledBy(Type = typeof(SocketAddress), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SocketAddress), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 117
	}

	public int Size
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public SocketAddress(AddressFamily family, int size) { }

	[CalledBy(Type = typeof(IPEndPoint), Member = "Serialize", ReturnType = typeof(SocketAddress))]
	[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "WriteIPv6Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "GetAddressBytes", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal SocketAddress(IPAddress ipAddress) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal SocketAddress(IPAddress ipaddress, int port) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAddress), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual bool Equals(object comparand) { }

	[CalledBy(Type = typeof(IPEndPoint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAddress)}, ReturnType = typeof(EndPoint))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AddressFamily get_Family() { }

	[CalledBy(Type = typeof(SocketAddress), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SocketAddress), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public byte get_Item(int offset) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Size() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(IPEndPoint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAddress)}, ReturnType = typeof(EndPoint))]
	[CalledBy(Type = typeof(SocketAddress), Member = "GetIPEndPoint", ReturnType = typeof(IPEndPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal IPAddress GetIPAddress() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal IPEndPoint GetIPEndPoint() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SocketAddress), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public virtual string ToString() { }

}

