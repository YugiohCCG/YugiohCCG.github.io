namespace System.Security.Claims;

public class Claim
{
	private string m_issuer; //Field offset: 0x10
	private string m_originalIssuer; //Field offset: 0x18
	private string m_type; //Field offset: 0x20
	private string m_value; //Field offset: 0x28
	private string m_valueType; //Field offset: 0x30
	private Byte[] m_userSerializationData; //Field offset: 0x38
	private Dictionary<String, String> m_properties; //Field offset: 0x40
	private object m_propertyLock; //Field offset: 0x48
	private ClaimsIdentity m_subject; //Field offset: 0x50

	public IDictionary<String, String> Properties
	{
		[CalledBy(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ClaimsIdentity), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 259
	}

	public internal ClaimsIdentity Subject
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	public string Type
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Value
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(GenericIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericIdentity), Member = "AddNameClaim", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ClaimsIdentity), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	[CalledBy(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>), typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Claim), Member = "get_Properties", ReturnType = typeof(System.Collections.Generic.IDictionary`2<System.String, System.String>))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	internal Claim(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	[CalledBy(Type = typeof(Claim), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClaimsIdentity)}, ReturnType = typeof(Claim))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 19)]
	protected Claim(Claim other, ClaimsIdentity subject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Claim), typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	public override Claim Clone(ClaimsIdentity identity) { }

	[CalledBy(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(ClaimsIdentity), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public IDictionary<String, String> get_Properties() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public ClaimsIdentity get_Subject() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_Type() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Subject(ClaimsIdentity value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

