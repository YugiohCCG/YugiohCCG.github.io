namespace System.Net.Sockets;

public class LingerOption
{
	private bool enabled; //Field offset: 0x10
	private int lingerTime; //Field offset: 0x14

	public bool Enabled
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 370
	}

	public int LingerTime
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LingerOption(bool enable, int seconds) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void set_Enabled(bool value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_LingerTime(int value) { }

}

