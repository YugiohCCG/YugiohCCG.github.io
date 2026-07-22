namespace ZXing;

public sealed class FormatException : ReaderException
{
	private static readonly FormatException instance; //Field offset: 0x0

	public static FormatException Instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static FormatException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReaderException), Member = ".ctor", ReturnType = typeof(void))]
	private FormatException() { }

	[CallerCount(Count = 0)]
	public static FormatException get_Instance() { }

}

