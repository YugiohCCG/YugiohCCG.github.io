namespace Mono.Nat.Pmp;

internal static class PmpConstants
{
	public const byte Version = 0; //Field offset: 0x0
	public const byte OperationCode = 0; //Field offset: 0x0
	public const byte OperationCodeUdp = 1; //Field offset: 0x0
	public const byte OperationCodeTcp = 2; //Field offset: 0x0
	public const byte ServerNoop = 128; //Field offset: 0x0
	public const int ServerPort = 5351; //Field offset: 0x0
	public static readonly TimeSpan RetryDelay; //Field offset: 0x0
	public const int RetryAttempts = 8; //Field offset: 0x0
	public static readonly TimeSpan RecommendedLeaseTime; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "FromHours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	private static PmpConstants() { }

}

