namespace Mono.Nat.Upnp;

internal interface IRequestMessage
{

	public HttpWebRequest Encode(out Byte[] body) { }

}

