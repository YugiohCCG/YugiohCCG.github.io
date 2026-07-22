namespace System.Runtime.Remoting.Metadata;

[ComVisible(True)]
public class SoapAttribute : Attribute
{
	private bool _useAttribute; //Field offset: 0x10
	protected string ProtXmlNamespace; //Field offset: 0x18
	protected object ReflectInfo; //Field offset: 0x20

	public override bool UseAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string XmlNamespace
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SoapAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_UseAttribute() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override string get_XmlNamespace() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal override void SetReflectionObject(object reflectionObject) { }

}

