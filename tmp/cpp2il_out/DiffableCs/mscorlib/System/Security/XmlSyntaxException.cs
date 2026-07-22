namespace System.Security;

public sealed class XmlSyntaxException : SystemException
{

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlSyntaxException() { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlSyntaxException(int lineNumber) { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlSyntaxException(int lineNumber, string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private XmlSyntaxException(SerializationInfo info, StreamingContext context) { }

}

