namespace MS.Internal.Xml.XPath;

internal abstract class BaseAxisQuery : Query
{
	internal Query qyInput; //Field offset: 0x18
	private bool _nameTest; //Field offset: 0x20
	private string _name; //Field offset: 0x28
	private string _prefix; //Field offset: 0x30
	private string _nsUri; //Field offset: 0x38
	private XPathNodeType _typeTest; //Field offset: 0x40
	protected XPathNavigator currentNode; //Field offset: 0x48
	protected int position; //Field offset: 0x50

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	protected string Name
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected string Namespace
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected bool NameTest
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XPathResultType StaticType
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	protected XPathNodeType TypeTest
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(FilterQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query), typeof(Query), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GroupQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected BaseAxisQuery(Query qyInput) { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected BaseAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Query), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Query)}, ReturnType = typeof(Query))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	protected BaseAxisQuery(BaseAxisQuery other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual object Evaluate(XPathNodeIterator nodeIterator) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	protected string get_Name() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	protected string get_Namespace() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected bool get_NameTest() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual XPathResultType get_StaticType() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	protected XPathNodeType get_TypeTest() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool matches(XPathNavigator e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void SetXsltContext(XsltContext context) { }

}

