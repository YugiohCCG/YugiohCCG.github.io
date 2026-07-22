namespace Mono.Security.X509;

internal class SafeBag
{
	private string _bagOID; //Field offset: 0x10
	private ASN1 _asn1; //Field offset: 0x18

	public ASN1 ASN1
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string BagOID
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public SafeBag(string bagOID, ASN1 asn1) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ASN1 get_ASN1() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_BagOID() { }

}

