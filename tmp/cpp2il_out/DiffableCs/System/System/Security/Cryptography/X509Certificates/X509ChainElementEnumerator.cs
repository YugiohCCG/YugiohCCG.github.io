namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainElementEnumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x10

	public X509ChainElement Current
	{
		[CallerCount(Count = 0)]
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
	internal X509ChainElementEnumerator(IEnumerable enumerable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public X509ChainElement get_Current() { }

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

