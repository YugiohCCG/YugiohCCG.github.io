namespace UnityEngine.Rendering;

public static class GenericPool
{
	private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T>", "UnityEngine.Events.UnityAction`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private static GenericPool`1() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static T Get() { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "UnityEngine.Rendering.ObjectPool`1<T>+PooledObject<T>")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static PooledObject<T> Get(out T value) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static void Release(T toRelease) { }

}

