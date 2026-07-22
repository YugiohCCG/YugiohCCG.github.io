namespace System.Net;

public class CredentialCache
{

	public static ICredentials DefaultCredentials
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public static NetworkCredential DefaultNetworkCredentials
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	public static ICredentials get_DefaultCredentials() { }

	[CallerCount(Count = 0)]
	public static NetworkCredential get_DefaultNetworkCredentials() { }

}

