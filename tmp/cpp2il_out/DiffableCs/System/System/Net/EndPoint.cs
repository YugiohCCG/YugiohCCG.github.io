namespace System.Net;

public abstract class EndPoint
{

	public override AddressFamily AddressFamily
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EndPoint() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 2)]
	public override EndPoint Create(SocketAddress socketAddress) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 2)]
	public override AddressFamily get_AddressFamily() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[CallsUnknownMethods(Count = 2)]
	public override SocketAddress Serialize() { }

}

