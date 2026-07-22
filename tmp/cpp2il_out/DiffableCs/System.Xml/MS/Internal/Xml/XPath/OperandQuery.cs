namespace MS.Internal.Xml.XPath;

internal sealed class OperandQuery : ValueQuery
{
	internal object val; //Field offset: 0x18

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Query), Member = "GetXPathType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(XPathResultType))]
		 get { } //Length: 12
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public OperandQuery(object val) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "GetXPathType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(XPathResultType))]
	public virtual XPathResultType get_StaticType() { }

}

