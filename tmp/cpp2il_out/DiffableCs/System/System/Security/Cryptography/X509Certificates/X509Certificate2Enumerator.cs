namespace System.Security.Cryptography.X509Certificates;

public sealed class X509Certificate2Enumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x10

	public X509Certificate2 Current
	{
		[CalledBy(Type = typeof(X509ChainImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 149
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 73
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal X509Certificate2Enumerator(X509Certificate2Collection collection) { }

	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public X509Certificate2 get_Current() { }

	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override object System.Collections.IEnumerator.get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Collections.IEnumerator.Reset() { }

}

