namespace System.Net.NetworkInformation;

public class NetworkInformationException : Win32Exception
{

	[CalledBy(Type = typeof(Win32NetworkInterfaceAPI), Member = "GetAdaptersAddresses", ReturnType = typeof(Win32_IP_ADAPTER_ADDRESSES[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public NetworkInformationException() { }

	[CallerCount(Count = 53)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public NetworkInformationException(int errorCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

