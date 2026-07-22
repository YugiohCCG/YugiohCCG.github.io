namespace System.Security.Cryptography.X509Certificates;

internal abstract class X509ChainImpl : IDisposable
{

	public abstract X509ChainElementCollection ChainElements
	{
		 get { } //Length: 0
	}

	public abstract X509ChainPolicy ChainPolicy
	{
		 get { } //Length: 0
	}

	public abstract bool IsValid
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected X509ChainImpl() { }

	public abstract void AddStatus(X509ChainStatusFlags errorCode) { }

	public abstract bool Build(X509Certificate2 certificate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	public abstract X509ChainElementCollection get_ChainElements() { }

	public abstract X509ChainPolicy get_ChainPolicy() { }

	public abstract bool get_IsValid() { }

	public abstract void Reset() { }

	[CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_StoreCtx", ReturnType = typeof(MonoBtlsX509StoreCtx))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void ThrowIfContextInvalid() { }

}

