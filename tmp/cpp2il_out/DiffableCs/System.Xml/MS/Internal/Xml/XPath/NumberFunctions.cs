namespace MS.Internal.Xml.XPath;

internal sealed class NumberFunctions : ValueQuery
{
	private Query _arg; //Field offset: 0x18
	private FunctionType _ftype; //Field offset: 0x20

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NumberFunctions(FunctionType ftype, Query arg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private NumberFunctions(NumberFunctions other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private double Ceiling(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFunctions), Member = "Number", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlConvert), Member = "XPathRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private double Floor(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	internal static double Number(bool arg) { }

	[CalledBy(Type = typeof(NumberFunctions), Member = "Number", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	internal static double Number(string arg) { }

	[CalledBy(Type = typeof(NumberFunctions), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeIterator)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Query), Member = "GetXPathType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(XPathResultType))]
	[Calls(Type = typeof(NumberFunctions), Member = "Number", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private double Number(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlConvert), Member = "XPathRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private double Round(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetXsltContext(XsltContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private double Sum(XPathNodeIterator nodeIterator) { }

}

