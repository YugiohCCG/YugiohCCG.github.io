namespace Unity;

internal sealed class ThrowStub : ObjectDisposedException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void ThrowNotSupportedException() { }

}

