namespace Mono.Security.Protocol.Ntlm;

public static class NtlmSettings
{
	private static NtlmAuthLevel defaultAuthLevel; //Field offset: 0x0

	public static NtlmAuthLevel DefaultAuthLevel
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 77
	}

	[CallerCount(Count = 0)]
	private static NtlmSettings() { }

	[CallerCount(Count = 0)]
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

}

