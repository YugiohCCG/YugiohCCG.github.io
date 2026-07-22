namespace System.Threading;

public static class LazyInitializer
{

	[CalledBy(Type = typeof(Hashtable), Member = "get_SerializationInfoTable", ReturnType = typeof(System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object, System.Runtime.Serialization.SerializationInfo>))]
	[CalledBy(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hashtable), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitializedCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static T EnsureInitialized(ref T target) { }

	[CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags", typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags", typeof(bool), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.DerSequenceReader+DerTag", typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadT61String", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Stream), Member = "EnsureAsyncActiveSemaphoreInitialized", ReturnType = typeof(SemaphoreSlim))]
	[CalledBy(Type = "System.IO.Stream+SynchronousAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = typeof(Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomMarshaler))]
	[CalledBy(Type = typeof(CryptoStream), Member = "get_AsyncActiveSemaphore", ReturnType = typeof(SemaphoreSlim))]
	[CalledBy(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "System.IAsyncResult.get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = typeof(Task), Member = "EnsureContingentPropertiesInitializedCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContingentProperties))]
	[CalledBy(Type = typeof(Task), Member = "EnsureContingentPropertiesInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContingentProperties))]
	[CalledBy(Type = typeof(Task), Member = "DisregardChild", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AddNewChild", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeParse), Member = "DoStrictParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeStyles), typeof(DateTimeFormatInfo), typeof(DateTimeResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "get_CompletedEvent", ReturnType = typeof(ManualResetEventSlim))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static T EnsureInitialized(ref T target, Func<T> valueFactory) { }

	[CalledBy(Type = "System.LocalAppContext", Member = "GetCachedSwitchValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.LocalAppContext", Member = "get_DisableCaching", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitializedCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Boolean&), typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static T EnsureInitialized(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }

	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "get_ClientCertificates", ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateCollection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitializedCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static T EnsureInitialized(ref T target, ref object syncLock, Func<T> valueFactory) { }

	[CalledBy(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MissingMemberException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static T EnsureInitializedCore(ref T target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static T EnsureInitializedCore(ref T target, Func<T> valueFactory) { }

	[CalledBy(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Boolean&), typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureLockInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static T EnsureInitializedCore(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }

	[CalledBy(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureLockInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private static T EnsureInitializedCore(ref T target, ref object syncLock, Func<T> valueFactory) { }

	[CalledBy(Type = typeof(LazyInitializer), Member = "EnsureInitializedCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Boolean&), typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
	[CalledBy(Type = typeof(LazyInitializer), Member = "EnsureInitializedCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Object&), "System.Func`1<T>"}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object EnsureLockInitialized(ref object syncLock) { }

}

