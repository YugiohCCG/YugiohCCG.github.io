namespace System.Xml.XPath;

internal class XPathNavigatorKeyComparer : IEqualityComparer
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XPathNavigatorKeyComparer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathDocumentNavigator), Member = "GetPositionHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 5)]
	private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

}

