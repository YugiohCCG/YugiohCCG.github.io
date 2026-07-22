namespace MS.Internal.Xml.XPath;

internal sealed class LogicalExpr : ValueQuery
{
	private sealed class cmpXslt : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public cmpXslt(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool Invoke(Op op, object val1, object val2) { }

	}

	private struct NodeSet
	{
		private Query _opnd; //Field offset: 0x0
		private XPathNavigator _current; //Field offset: 0x8

		public string Value
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 39
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public NodeSet(object opnd) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public string get_Value() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Reset() { }

	}

	private static readonly cmpXslt[][] s_CompXsltE; //Field offset: 0x0
	private static readonly cmpXslt[][] s_CompXsltO; //Field offset: 0x8
	private Op _op; //Field offset: 0x18
	private Query _opnd1; //Field offset: 0x20
	private Query _opnd2; //Field offset: 0x28

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 164)]
	private static LogicalExpr() { }

	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Filter), "MS.Internal.Xml.XPath.QueryBuilder+Flags", typeof(Props&)}, ReturnType = typeof(Query))]
	[CalledBy(Type = typeof(QueryBuilder), Member = "ProcessOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Operator), typeof(Props&)}, ReturnType = typeof(Query))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public LogicalExpr(Op op, Query opnd1, Query opnd2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private LogicalExpr(LogicalExpr other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpBoolBoolE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool cmpBoolBoolE(Op op, bool n1, bool n2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpBoolBoolO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpBoolNumberE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpBoolNumberO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpBoolStringE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpBoolStringO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private static bool cmpNumberNumber(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private static bool cmpNumberNumber(Op op, double n1, double n2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool cmpNumberNumberO(Op op, double n1, double n2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool cmpQueryBoolE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool cmpQueryBoolO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private static bool cmpQueryNumber(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private static bool cmpQueryQueryE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private static bool cmpQueryQueryO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool cmpQueryStringE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool cmpQueryStringO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfBoolE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfBoolO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfNumber(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfQueryE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfQueryO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfRtfE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfRtfO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfStringE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool cmpRtfStringO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static bool cmpStringNumber(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool cmpStringStringE(Op op, string n1, string n2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool cmpStringStringE(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToXPathDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool cmpStringStringO(Op op, object val1, object val2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Query), Member = "GetXPathType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(XPathResultType))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static string Rtf(object o) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void SetXsltContext(XsltContext context) { }

}

