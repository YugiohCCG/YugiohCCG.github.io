namespace Mono.Nat.Logging;

public class Logger
{
	[CompilerGenerated]
	private static Func<String, ILogger> <Factory>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ILogger <Writer>k__BackingField; //Field offset: 0x10

	public static Func<String, ILogger> Factory
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 81
	}

	private ILogger Writer
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Logger(ILogger writer) { }

	[CalledBy(Type = typeof(AsyncExtensions), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Searcher), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResponseMessage), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UpnpSearcher), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UpnpNatDevice), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PmpSearcher), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static Logger Create(string callingClassName) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<GetServicesList>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UpnpSearcher), Member = "Create", ReturnType = typeof(UpnpSearcher))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void Error(string message) { }

	[CalledBy(Type = typeof(ResponseMessage), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpnpNatDevice), typeof(string)}, ReturnType = typeof(ResponseMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void ErrorFormatted(string format, object p1) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void ErrorFormatted(string format, object p1, object p2) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<SearchAsync>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void Exception(Exception ex, string message) { }

	[CalledBy(Type = "Mono.Nat.Searcher+<ListenAsync>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<HandleMessageReceived>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void ExceptionFormated(Exception ex, string formatString, object p1) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Func<String, ILogger> get_Factory() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private ILogger get_Writer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void Info(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void InfoFormatted(string format, int p1, int p2) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<HandleMessageReceived>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void InfoFormatted(string format, object p1) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpSearcher+<ServicesReceived>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<SendMessageAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void InfoFormatted(string format, object p1, object p2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void InfoFormatted(string format, object p1, int p2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public static void set_Factory(Func<String, ILogger> value) { }

}

