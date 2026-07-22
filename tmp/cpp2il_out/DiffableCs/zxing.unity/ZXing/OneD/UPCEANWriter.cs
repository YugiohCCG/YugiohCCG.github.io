namespace ZXing.OneD;

public abstract class UPCEANWriter : OneDimensionalCodeWriter
{

	public virtual int DefaultMargin
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 92
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected UPCEANWriter() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_DefaultMargin() { }

}

