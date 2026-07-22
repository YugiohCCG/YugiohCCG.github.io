namespace System.Xml.Schema;

internal class DoubleLinkAxis : Axis
{
	internal Axis next; //Field offset: 0x40

	internal Axis Next
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Axis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisType), typeof(AstNode), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal DoubleLinkAxis(Axis axis, DoubleLinkAxis inputaxis) { }

	[CalledBy(Type = typeof(DoubleLinkAxis), Member = "ConvertTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis)}, ReturnType = typeof(DoubleLinkAxis))]
	[CalledBy(Type = typeof(Asttree), Member = "CompileXPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DoubleLinkAxis), Member = "ConvertTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis)}, ReturnType = typeof(DoubleLinkAxis))]
	[Calls(Type = typeof(Axis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisType), typeof(AstNode), typeof(string), typeof(string), typeof(XPathNodeType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Axis get_Next() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Next(Axis value) { }

}

