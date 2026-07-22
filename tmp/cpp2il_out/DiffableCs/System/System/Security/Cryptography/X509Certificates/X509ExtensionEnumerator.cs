namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ExtensionEnumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x10

	public X509Extension Current
	{
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal X509ExtensionEnumerator(ArrayList list) { }

	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public X509Extension get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override bool MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void Reset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override object System.Collections.IEnumerator.get_Current() { }

}

