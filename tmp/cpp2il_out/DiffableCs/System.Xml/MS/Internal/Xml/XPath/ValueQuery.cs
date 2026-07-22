namespace MS.Internal.Xml.XPath;

internal abstract class ValueQuery : Query
{

	public virtual int Count
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 54
	}

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 54
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 54
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ValueQuery() { }

	[CallerCount(Count = 35)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ValueQuery(ValueQuery other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNavigator Advance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XPathException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XPathException))]
	[CallsUnknownMethods(Count = 3)]
	public virtual int get_CurrentPosition() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

}

