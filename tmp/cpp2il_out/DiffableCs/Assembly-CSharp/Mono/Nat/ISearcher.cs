namespace Mono.Nat;

internal interface ISearcher : IDisposable
{

	public event EventHandler<DeviceEventArgs> DeviceFound
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler<DeviceEventUnknownArgs> UnknownDeviceFound
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool Listening
	{
		 get { } //Length: 0
	}

	public NatProtocol Protocol
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_DeviceFound(EventHandler<DeviceEventArgs> value) { }

	[CompilerGenerated]
	public void add_UnknownDeviceFound(EventHandler<DeviceEventUnknownArgs> value) { }

	public void BeginSearching() { }

	public void BeginSearching(IPAddress gatewayAddress) { }

	public bool get_Listening() { }

	public NatProtocol get_Protocol() { }

	public Task HandleMessageReceived(IPAddress localAddress, Byte[] response, IPEndPoint endpoint, CancellationToken token) { }

	[CompilerGenerated]
	public void remove_DeviceFound(EventHandler<DeviceEventArgs> value) { }

	[CompilerGenerated]
	public void remove_UnknownDeviceFound(EventHandler<DeviceEventUnknownArgs> value) { }

}

