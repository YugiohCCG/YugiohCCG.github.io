namespace UnityEngine.Pool;

public struct PooledObject : IDisposable
{
	private readonly T m_ToReturn; //Field offset: 0x0
	private readonly IObjectPool<T> m_Pool; //Field offset: 0x0

	[CallerCount(Count = 68)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public PooledObject`1(T value, IObjectPool<T> pool) { }

	[CallerCount(Count = 65)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override void System.IDisposable.Dispose() { }

}

