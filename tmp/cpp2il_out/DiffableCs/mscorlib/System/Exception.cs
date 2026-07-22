namespace System;

[ComVisible(True)]
public class Exception : ISerializable
{
	public enum ExceptionMessageKind
	{
		ThreadAbort = 1,
		ThreadInterrupted = 2,
		OutOfMemory = 3,
	}

	[OptionalField]
	private static object s_EDILock; //Field offset: 0x0
	private const int _COMPlusExceptionCode = -532462766; //Field offset: 0x0
	private string _className; //Field offset: 0x10
	internal string _message; //Field offset: 0x18
	private IDictionary _data; //Field offset: 0x20
	private Exception _innerException; //Field offset: 0x28
	private string _helpURL; //Field offset: 0x30
	private object _stackTrace; //Field offset: 0x38
	private string _stackTraceString; //Field offset: 0x40
	private string _remoteStackTraceString; //Field offset: 0x48
	private int _remoteStackIndex; //Field offset: 0x50
	private object _dynamicMethods; //Field offset: 0x58
	internal int _HResult; //Field offset: 0x60
	private string _source; //Field offset: 0x68
	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager; //Field offset: 0x70
	internal StackTrace[] captured_traces; //Field offset: 0x78
	private IntPtr[] native_trace_ips; //Field offset: 0x80
	private int caught_in_unmanaged; //Field offset: 0x88

	public override IDictionary Data
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 105
	}

	public int HResult
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override Exception InnerException
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string Message
	{
		[CalledBy(Type = typeof(AggregateException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.Assertions.AssertionException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Net.Sockets.SocketException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.Schema.XmlSchemaException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XmlException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XPath.XPathException", Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MissingFieldException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ObjectDisposedException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ArgumentOutOfRangeException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(ArgumentException), Member = "get_Message", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MissingMemberException), Member = "get_Message", ReturnType = typeof(string))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 277
	}

	public override string Source
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 309
	}

	public override string StackTrace
	{
		[CalledBy(Type = "UnityEngine.AndroidJavaException", Member = "get_StackTrace", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 63
	}

	public override MethodBase TargetSite
	{
		[CalledBy(Type = "DG.Tweening.Tween", Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.TweenCallback", "DG.Tweening.Tween"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "DG.Tweening.Tween", Member = "OnTweenCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.TweenCallback`1<T>", "DG.Tweening.Tween", "T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "DG.Tweening.Tweener", Member = "DoStartup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "DG.Tweening.Tweener", Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
		[CalledBy(Type = "DG.Tweening.Core.TweenerCore`3", Member = "ApplyTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(bool), "DG.Tweening.Core.Enums.UpdateMode", "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 176
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Exception() { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Exception), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public Exception() { }

	[CallerCount(Count = 236)]
	[Calls(Type = typeof(Exception), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Exception(string message) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(Exception), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Exception(string message, Exception innerException) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	protected Exception(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal Exception FixRemotingException() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override IDictionary get_Data() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_HResult() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public override Exception get_InnerException() { }

	[CalledBy(Type = typeof(AggregateException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MissingMemberException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ArgumentException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ArgumentOutOfRangeException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MissingFieldException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XPath.XPathException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ObjectDisposedException), Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Sockets.SocketException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Assertions.AssertionException", Member = "get_Message", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override string get_Message() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public override string get_Source() { }

	[CalledBy(Type = "UnityEngine.AndroidJavaException", Member = "get_StackTrace", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public override string get_StackTrace() { }

	[CalledBy(Type = "DG.Tweening.Tween", Member = "OnTweenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.TweenCallback", "DG.Tweening.Tween"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.Tween", Member = "OnTweenCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.TweenCallback`1<T>", "DG.Tweening.Tween", "T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.Tweener", Member = "DoStartup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.Tweener", Member = "DoChangeEndValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "T2", typeof(float), typeof(bool)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>")]
	[CalledBy(Type = "DG.Tweening.Core.TweenerCore`3", Member = "ApplyTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(bool), "DG.Tweening.Core.Enums.UpdateMode", "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override MethodBase get_TargetSite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private string GetClassName() { }

	[CalledBy(Type = typeof(ThreadAbortException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadInterruptedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeSerializationManager), Member = "CompleteSerialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private string GetStackTrace(bool needFileInfo) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	public override Type GetType() { }

	[CalledBy(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeSerializationManager), Member = "CompleteDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	[CalledBy(Type = typeof(OSSpecificSynchronizationContext), Member = "InvocationEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static void ReportUnhandledException(Exception exception) { }

	[CalledBy(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	protected void set_HResult(int value) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal void SetErrorCode(int hr) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	[CalledBy(Type = typeof(AggregateException), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SecurityException), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReflectionTypeLoadException), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(Exception), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Exception), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "GetStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private string ToString(bool needFileLineInfo, bool needMessage) { }

}

