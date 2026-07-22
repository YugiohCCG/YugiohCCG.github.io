namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(1052)]
[ComVisible(True)]
public sealed class SoapTypeAttribute : SoapAttribute
{
	private bool _useAttribute; //Field offset: 0x28
	private string _xmlElementName; //Field offset: 0x30
	private string _xmlNamespace; //Field offset: 0x38
	private string _xmlTypeName; //Field offset: 0x40
	private string _xmlTypeNamespace; //Field offset: 0x48
	private bool _isType; //Field offset: 0x50
	private bool _isElement; //Field offset: 0x51

	internal bool IsInteropXmlElement
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool IsInteropXmlType
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual bool UseAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string XmlElementName
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string XmlNamespace
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string XmlTypeName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string XmlTypeNamespace
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SoapTypeAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsInteropXmlElement() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	internal bool get_IsInteropXmlType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool get_UseAttribute() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_XmlElementName() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public virtual string get_XmlNamespace() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_XmlTypeName() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_XmlTypeNamespace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

