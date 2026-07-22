namespace System;

public class OutOfMemoryException : SystemException
{

	[CalledBy(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "JoinCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "ReplaceHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(System.ReadOnlySpan`1<System.Int32>)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Convert), Member = "ToBase64_CalculateAndValidateOutputLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringBuilder), Member = "ExpandByABlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetKeys", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TKey>")]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "GetValues", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<TValue>")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsError", Member = "GetErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "CheckValidationResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Net.Security.ChainValidationHelper", typeof(string), typeof(bool), "System.Security.Cryptography.X509Certificates.X509CertificateCollection", typeof(bool), "System.Security.Cryptography.X509Certificates.X509Chain", "Mono.Btls.MonoBtlsX509StoreCtx", typeof(bool), "System.Net.Security.SslPolicyErrors&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509", Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", "Mono.Btls.MonoBtlsX509Format"}, ReturnType = "Mono.Btls.MonoBtlsX509")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public OutOfMemoryException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public OutOfMemoryException(string message) { }

	[CallerCount(Count = 64)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected OutOfMemoryException(SerializationInfo info, StreamingContext context) { }

}

