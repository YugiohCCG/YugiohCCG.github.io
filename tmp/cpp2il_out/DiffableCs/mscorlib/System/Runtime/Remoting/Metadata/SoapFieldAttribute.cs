namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets::Field (256))]
[ComVisible(True)]
public sealed class SoapFieldAttribute : SoapAttribute
{
	private string _elementName; //Field offset: 0x28
	private bool _isElement; //Field offset: 0x30

	public string XmlElementName
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SoapFieldAttribute() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_XmlElementName() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool IsInteropXmlElement() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

