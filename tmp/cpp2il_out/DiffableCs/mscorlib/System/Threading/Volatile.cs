namespace System.Threading;

public static class Volatile
{
	private struct VolatileBoolean
	{
		public bool Value; //Field offset: 0x0

	}

	private struct VolatileInt32
	{
		public int Value; //Field offset: 0x0

	}

	private struct VolatileObject
	{
		public object Value; //Field offset: 0x0

	}


	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Intrinsic]
	public static bool Read(ref bool location) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Intrinsic]
	public static int Read(ref int location) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Intrinsic]
	public static T Read(ref T location) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Intrinsic]
	public static void Write(ref bool location, bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Intrinsic]
	public static void Write(ref int location, int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Intrinsic]
	public static void Write(ref T location, T value) { }

}

