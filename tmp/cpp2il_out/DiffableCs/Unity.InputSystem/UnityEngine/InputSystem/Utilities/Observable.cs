namespace UnityEngine.InputSystem.Utilities;

[Extension]
public static class Observable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public IDisposable subscription; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0`1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <CallOnce>b__0() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static IDisposable Call(IObservable<TValue> source, Action<TValue> action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	[Extension]
	public static IDisposable CallOnce(IObservable<TValue> source, Action<TValue> action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	public static IObservable<InputEventPtr> ForDevice(IObservable<InputEventPtr> source, InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ForDeviceEventObservable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.IObservable`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>), typeof(Type), typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static IObservable<InputEventPtr> ForDevice(IObservable<InputEventPtr> source) { }

	[CalledBy(Type = typeof(InputSystem), Member = "get_onAnyButtonPress", ReturnType = typeof(System.IObservable`1<UnityEngine.InputSystem.InputControl>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Extension]
	public static IObservable<TResult> Select(IObservable<TSource> source, Func<TSource, TResult> filter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Extension]
	public static IObservable<TResult> SelectMany(IObservable<TSource> source, Func<TSource, IEnumerable`1<TResult>> filter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Extension]
	public static IObservable<TValue> Take(IObservable<TValue> source, int count) { }

	[CalledBy(Type = typeof(InputSystem), Member = "get_onAnyButtonPress", ReturnType = typeof(System.IObservable`1<UnityEngine.InputSystem.InputControl>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Extension]
	public static IObservable<TValue> Where(IObservable<TValue> source, Func<TValue, Boolean> predicate) { }

}

