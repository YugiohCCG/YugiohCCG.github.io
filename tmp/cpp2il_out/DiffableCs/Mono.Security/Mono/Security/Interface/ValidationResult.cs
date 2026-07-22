namespace Mono.Security.Interface;

public class ValidationResult
{
	private bool trusted; //Field offset: 0x10
	private bool user_denied; //Field offset: 0x11
	private int error_code; //Field offset: 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; //Field offset: 0x18

	public bool Trusted
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool UserDenied
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain&), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ValidationResult(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Trusted() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_UserDenied() { }

}

