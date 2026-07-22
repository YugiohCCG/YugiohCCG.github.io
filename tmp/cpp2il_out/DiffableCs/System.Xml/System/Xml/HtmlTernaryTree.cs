namespace System.Xml;

internal abstract class HtmlTernaryTree
{
	internal static Byte[] htmlElements; //Field offset: 0x0
	internal static Byte[] htmlAttributes; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static HtmlTernaryTree() { }

}

