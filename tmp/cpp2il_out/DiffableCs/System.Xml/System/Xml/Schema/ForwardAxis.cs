namespace System.Xml.Schema;

internal class ForwardAxis
{
	private DoubleLinkAxis _topNode; //Field offset: 0x10
	private DoubleLinkAxis _rootNode; //Field offset: 0x18
	private bool _isAttribute; //Field offset: 0x20
	private bool _isDss; //Field offset: 0x21
	private bool _isSelfAxis; //Field offset: 0x22

	internal bool IsAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool IsDss
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool IsSelfAxis
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal DoubleLinkAxis RootNode
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal DoubleLinkAxis TopNode
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(Asttree), Member = "CompileXPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public ForwardAxis(DoubleLinkAxis axis, bool isdesorself) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsDss() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsSelfAxis() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal DoubleLinkAxis get_RootNode() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal DoubleLinkAxis get_TopNode() { }

}

