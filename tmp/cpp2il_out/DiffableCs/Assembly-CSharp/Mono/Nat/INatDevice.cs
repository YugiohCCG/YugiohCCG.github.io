namespace Mono.Nat;

public interface INatDevice
{

	public IPEndPoint DeviceEndpoint
	{
		 get { } //Length: 0
	}

	public DateTime LastSeen
	{
		 get { } //Length: 0
	}

	public NatProtocol NatProtocol
	{
		 get { } //Length: 0
	}

	public Task<Mapping> CreatePortMapAsync(Mapping mapping) { }

	public Task<Mapping> DeletePortMapAsync(Mapping mapping) { }

	public IPEndPoint get_DeviceEndpoint() { }

	public DateTime get_LastSeen() { }

	public NatProtocol get_NatProtocol() { }

	public Task<Mapping[]> GetAllMappingsAsync() { }

	public Task<IPAddress> GetExternalIPAsync() { }

	public Task<Mapping> GetSpecificMappingAsync(Protocol protocol, int publicPort) { }

}

