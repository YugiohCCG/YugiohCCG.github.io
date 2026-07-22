namespace System.Runtime.ExceptionServices;

public sealed class ExceptionDispatchInfo
{
	private Exception m_Exception; //Field offset: 0x10
	private object m_stackTrace; //Field offset: 0x18

	internal object BinaryStackTraceArray
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public Exception SourceException
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private ExceptionDispatchInfo(Exception exception) { }

	[CallerCount(Count = 111)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static ExceptionDispatchInfo Capture(Exception source) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal object get_BinaryStackTraceArray() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Exception get_SourceException() { }

	[CallerCount(Count = 123)]
	[Calls(Type = typeof(Exception), Member = "RestoreExceptionDispatchInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionDispatchInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[StackTraceHidden]
	public void Throw() { }

	[CalledBy(Type = "System.ComponentModel.Design.DesignerOptionService+DesignerOptionCollection+WrappedPropertyDescriptor", Member = "get_PropertyType", ReturnType = typeof(Type))]
	[CalledBy(Type = "System.Net.FtpDataStream", Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "EndGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "EndGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "CheckError", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "DataStreamClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CloseExState"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ExceptionHelpers", Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[StackTraceHidden]
	public static void Throw(Exception source) { }

}

