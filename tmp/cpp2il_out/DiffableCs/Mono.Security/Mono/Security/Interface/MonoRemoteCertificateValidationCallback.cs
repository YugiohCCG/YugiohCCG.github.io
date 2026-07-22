namespace Mono.Security.Interface;

public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate
{

	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(NetworkStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.Private.CallbackHelpers", Member = "PublicToMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(MonoRemoteCertificateValidationCallback))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public MonoRemoteCertificateValidationCallback(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}

