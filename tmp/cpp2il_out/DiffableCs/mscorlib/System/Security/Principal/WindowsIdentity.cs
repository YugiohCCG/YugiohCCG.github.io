namespace System.Security.Principal;

[ComVisible(True)]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
{
	private static IntPtr invalidWindows; //Field offset: 0x0
	private IntPtr _token; //Field offset: 0x78
	private string _type; //Field offset: 0x80
	private WindowsAccountType _account; //Field offset: 0x88
	private bool _authenticated; //Field offset: 0x8C
	private string _name; //Field offset: 0x90
	private SerializationInfo _info; //Field offset: 0x98

	public virtual string AuthenticationType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 125
	}

	[CallerCount(Count = 0)]
	private static WindowsIdentity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WindowsIdentity), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public WindowsIdentity(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(ClaimsPrincipal), Member = "DeserializeIdentities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WindowsIdentity), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal WindowsIdentity(ClaimsIdentity claimsIdentity, IntPtr userToken) { }

	[CalledBy(Type = typeof(ClaimsPrincipal), Member = "SerializeIdentities", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClaimsIdentity), Member = "Clone", ReturnType = typeof(ClaimsIdentity))]
	internal ClaimsIdentity CloneAsBase() { }

	[CallerCount(Count = 0)]
	[ComVisible(False)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string get_AuthenticationType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string get_Name() { }

	[CalledBy(Type = "System.Net.WebRequest", Member = "GetRequestStreamAsync", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
	[CalledBy(Type = "System.Net.WebRequest", Member = "GetResponseAsync", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
	[CalledBy(Type = "System.Net.WebRequest", Member = "SafeCaptureIdenity", ReturnType = typeof(WindowsIdentity))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ClaimsIdentity), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WindowsIdentity), Member = "SetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static WindowsIdentity GetCurrent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static IntPtr GetCurrentToken() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal IntPtr GetTokenInternal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetTokenName(IntPtr token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override WindowsImpersonationContext Impersonate() { }

	[CalledBy(Type = typeof(WindowsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(WindowsAccountType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClaimsIdentity), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Environment), Member = "get_IsUnix", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void SetToken(IntPtr token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

