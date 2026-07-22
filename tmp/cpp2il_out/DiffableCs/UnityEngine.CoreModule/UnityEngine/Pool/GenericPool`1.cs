namespace UnityEngine.Pool;

public class GenericPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

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
		internal T <.cctor>b__5_0() { }

	}

	internal static readonly ObjectPool<T> s_Pool; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	private static GenericPool`1() { }

	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.UIElements.EventCallback`1<TEventType>", "UnityEngine.UIElements.InvokePolicy"}, ReturnType = "UnityEngine.UIElements.EventCallbackFunctor`1<TEventType>")]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`2", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.UIElements.EventCallback`2<TEventType, TCallbackArgs>", "TCallbackArgs", "UnityEngine.UIElements.InvokePolicy"}, ReturnType = "UnityEngine.UIElements.EventCallbackFunctor`2<TEventType, TCallbackArgs>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static T Get() { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static PooledObject<T> Get(out T value) { }

	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`1", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`2", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayoutStack", Member = "Release", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static void Release(T toRelease) { }

}

