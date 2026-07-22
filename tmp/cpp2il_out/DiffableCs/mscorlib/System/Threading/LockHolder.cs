namespace System.Threading;

[ReflectionBlocked]
public struct LockHolder : IDisposable
{
	private Lock _lock; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static LockHolder Hold(Lock l) { }

}

