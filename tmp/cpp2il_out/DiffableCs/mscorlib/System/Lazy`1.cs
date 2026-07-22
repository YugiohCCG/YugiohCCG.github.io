namespace System;

[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
[DebuggerTypeProxy(typeof(LazyDebugView`1))]
public class Lazy
{
	private LazyHelper _state; //Field offset: 0x0
	private Func<T> _factory; //Field offset: 0x0
	private T _value; //Field offset: 0x0

	public bool IsValueCreated
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	public T Value
	{
		[CalledBy(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 96
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LazyHelper), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(LazyHelper))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Lazy`1() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LazyHelper), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(LazyHelper))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public Lazy`1(Func<T> valueFactory) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LazyHelper), Member = "GetModeFromIsThreadSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(LazyThreadSafetyMode))]
	[Calls(Type = typeof(LazyHelper), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(LazyHelper))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public Lazy`1(Func<T> valueFactory, bool isThreadSafe) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LazyHelper), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(LazyHelper))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private Lazy`1(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	[CalledBy(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lazy`1), Member = "ViaFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Lazy`1), Member = "ExecutionAndPublication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyHelper), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LazyHelper), Member = "ThrowException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private T CreateValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(LazyHelper), Member = "CreateViaDefaultConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static T CreateViaDefaultConstructor() { }

	[CalledBy(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Lazy`1), Member = "ViaFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsValueCreated() { }

	[CalledBy(Type = typeof(TimeZoneInfo), Member = "get_HaveRegistry", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void PublicationOnly(LazyHelper publicationOnly, T possibleValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void PublicationOnlyViaConstructor(LazyHelper initializer) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void PublicationOnlyViaFactory(LazyHelper initializer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void PublicationOnlyWaitForOtherThreadToPublish() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void ViaConstructor() { }

	[CalledBy(Type = typeof(Lazy`1), Member = "ExecutionAndPublication", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LazyHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private void ViaFactory(LazyThreadSafetyMode mode) { }

}

