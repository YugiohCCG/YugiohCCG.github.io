namespace Mono.Xml;

internal class SmallXmlParserException : SystemException
{
	private int line; //Field offset: 0x90
	private int column; //Field offset: 0x94

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public SmallXmlParserException(string msg, int line, int column) { }

}

