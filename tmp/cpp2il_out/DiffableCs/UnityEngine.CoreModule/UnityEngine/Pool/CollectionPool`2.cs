namespace UnityEngine.Pool;

public class CollectionPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TCollection, TItem> <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[DeduplicatedMethod]
		internal TCollection <.cctor>b__5_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal void <.cctor>b__5_1(TCollection l) { }

	}

	internal static readonly ObjectPool<TCollection> s_Pool; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	private static CollectionPool`2() { }

	[CallerCount(Count = 56)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static TCollection Get() { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static PooledObject<TCollection> Get(out TCollection value) { }

	[CallerCount(Count = 59)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static void Release(TCollection toRelease) { }

}

