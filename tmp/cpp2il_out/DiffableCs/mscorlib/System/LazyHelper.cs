namespace System;

internal class LazyHelper
{
	internal static readonly LazyHelper NoneViaConstructor; //Field offset: 0x0
	internal static readonly LazyHelper NoneViaFactory; //Field offset: 0x8
	internal static readonly LazyHelper PublicationOnlyViaConstructor; //Field offset: 0x10
	internal static readonly LazyHelper PublicationOnlyViaFactory; //Field offset: 0x18
	internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish; //Field offset: 0x20
	[CompilerGenerated]
	private readonly LazyState <State>k__BackingField; //Field offset: 0x10
	private readonly ExceptionDispatchInfo _exceptionDispatch; //Field offset: 0x18

	internal LazyState State
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private static LazyHelper() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal LazyHelper(LazyState state) { }

	[CalledBy(Type = typeof(Lazy`1), Member = "ViaFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal LazyHelper(LazyThreadSafetyMode mode, Exception exception) { }

	[CalledBy(Type = typeof(Lazy`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lazy`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lazy`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lazy`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	[CalledBy(Type = typeof(Lazy`1), Member = "CreateViaDefaultConstructor", ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MissingMemberException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static object CreateViaDefaultConstructor(Type type) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal LazyState get_State() { }

	[CalledBy(Type = typeof(Lazy`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static LazyThreadSafetyMode GetModeFromIsThreadSafe(bool isThreadSafe) { }

	[CalledBy(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ThrowException() { }

}

