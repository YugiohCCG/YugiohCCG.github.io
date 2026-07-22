namespace System;

public class NotSupportedException : SystemException
{

	[CallerCount(Count = 242)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public NotSupportedException() { }

	[CallerCount(Count = 513)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public NotSupportedException(string message) { }

	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "InitializeInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "LookupProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public NotSupportedException(string message, Exception innerException) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected NotSupportedException(SerializationInfo info, StreamingContext context) { }

}

