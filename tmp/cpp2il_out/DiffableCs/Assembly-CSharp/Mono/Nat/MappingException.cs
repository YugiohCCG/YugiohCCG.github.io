namespace Mono.Nat;

public class MappingException : Exception
{
	[CompilerGenerated]
	private ErrorCode <ErrorCode>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private string <ErrorText>k__BackingField; //Field offset: 0x98

	public private ErrorCode ErrorCode
	{
		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	public private string ErrorText
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	public MappingException() { }

	[CalledBy(Type = typeof(ResponseMessage), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(MappingResponseMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public MappingException(string message) { }

	[CalledBy(Type = typeof(ResponseMessage), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpnpNatDevice), typeof(string)}, ReturnType = typeof(ResponseMessage))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<CreatePortMapAsync>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<DeletePortMapAsync>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<GetExternalIPAsync>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<GetSpecificMappingAsync>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResponseMessage), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(MappingResponseMessage))]
	[CalledBy(Type = typeof(PmpNatDevice), Member = "GetAllMappingsAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<Mapping[]>))]
	[CalledBy(Type = typeof(PmpNatDevice), Member = "GetSpecificMappingAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Protocol), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Mono.Nat.Mapping>))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public MappingException(ErrorCode errorCode, string errorText) { }

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<SendMessageAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public MappingException(string message, Exception innerException) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	protected MappingException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 33)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ErrorCode get_ErrorCode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_ErrorText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ErrorCode(ErrorCode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ErrorText(string value) { }

}

