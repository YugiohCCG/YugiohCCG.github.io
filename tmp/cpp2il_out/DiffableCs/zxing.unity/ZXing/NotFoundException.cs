namespace ZXing;

[Obsolete("Isn't used anymore, will be removed with next version")]
public sealed class NotFoundException : ReaderException
{
	private static readonly NotFoundException instance; //Field offset: 0x0

	public static NotFoundException Instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static NotFoundException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderException), Member = ".ctor", ReturnType = typeof(void))]
	private NotFoundException() { }

	[CallerCount(Count = 0)]
	public static NotFoundException get_Instance() { }

}

