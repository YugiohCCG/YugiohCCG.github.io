namespace System.Xml;

internal class Ucs4Encoding1234 : Ucs4Encoding
{

	public virtual string EncodingName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Ucs4Encoding1234() { }

	[CallerCount(Count = 0)]
	public virtual string get_EncodingName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual Byte[] GetPreamble() { }

}

