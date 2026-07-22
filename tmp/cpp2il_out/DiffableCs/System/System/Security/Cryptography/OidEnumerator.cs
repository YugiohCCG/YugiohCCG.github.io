namespace System.Security.Cryptography;

public sealed class OidEnumerator : IEnumerator
{
	private readonly OidCollection _oids; //Field offset: 0x10
	private int _current; //Field offset: 0x18

	public Oid Current
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 88
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 88
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal OidEnumerator(OidCollection oids) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Oid get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override bool MoveNext() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void Reset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.Collections.IEnumerator.get_Current() { }

}

