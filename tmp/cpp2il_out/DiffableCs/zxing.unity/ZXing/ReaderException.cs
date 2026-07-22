namespace ZXing;

public class ReaderException : Exception
{
	private static readonly ReaderException instance; //Field offset: 0x0

	public static ReaderException Instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ReaderException() { }

	[CalledBy(Type = typeof(FormatException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FormatException), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NotFoundException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NotFoundException), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	protected ReaderException() { }

	[CallerCount(Count = 0)]
	public static ReaderException get_Instance() { }

}

