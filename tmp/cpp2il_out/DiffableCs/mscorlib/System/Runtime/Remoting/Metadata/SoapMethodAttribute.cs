namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets::Method (64))]
[ComVisible(True)]
public sealed class SoapMethodAttribute : SoapAttribute
{
	private string _responseElement; //Field offset: 0x28
	private string _responseNamespace; //Field offset: 0x30
	private string _returnElement; //Field offset: 0x38
	private string _soapAction; //Field offset: 0x40
	private bool _useAttribute; //Field offset: 0x48
	private string _namespace; //Field offset: 0x50

	public virtual bool UseAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string XmlNamespace
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SoapMethodAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool get_UseAttribute() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public virtual string get_XmlNamespace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

