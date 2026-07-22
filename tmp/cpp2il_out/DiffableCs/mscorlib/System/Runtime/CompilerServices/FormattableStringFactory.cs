namespace System.Runtime.CompilerServices;

public static class FormattableStringFactory
{
	private sealed class ConcreteFormattableString : FormattableString
	{
		private readonly string _format; //Field offset: 0x10
		private readonly Object[] _arguments; //Field offset: 0x18

		public virtual int ArgumentCount
		{
			[CallerCount(Count = 11)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 26
		}

		public virtual string Format
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal ConcreteFormattableString(string format, Object[] arguments) { }

		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual int get_ArgumentCount() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public virtual string get_Format() { }

		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual object GetArgument(int index) { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public virtual Object[] GetArguments() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		public virtual string ToString(IFormatProvider formatProvider) { }

	}


	[CalledBy(Type = "System.ComponentModel.Design.DesignerOptionService+DesignerOptionCollection+WrappedPropertyDescriptor", Member = "get_PropertyType", ReturnType = typeof(Type))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "EnsureFtpWebResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "FinishRequestStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FtpWebRequest+RequestStage"}, ReturnType = "System.Net.FtpWebRequest+RequestStage")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "AsyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SyncRequestCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "AttemptedRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "GetResponse", ReturnType = "System.Net.WebResponse")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "CheckValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ResponseDescription", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CommandStream+PipelineEntry", "System.Net.ResponseDescription", typeof(bool), typeof(Stream&)}, ReturnType = "System.Net.CommandStream+PipelineInstruction")]
	[CalledBy(Type = "System.Net.CommandStream", Member = "ReceiveCommandResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ReceiveState", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.CommandStream", Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Net.ContextAwareResult", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ContextAwareResult", Member = "CaptureOrComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.FtpDataStream", Member = "System.Net.ICloseEx.CloseEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CloseExState"}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static FormattableString Create(string format, Object[] arguments) { }

}

