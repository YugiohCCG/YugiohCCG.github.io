namespace System.Xml.Schema;

internal class AxisElement
{
	internal DoubleLinkAxis curNode; //Field offset: 0x10
	internal int rootDepth; //Field offset: 0x18
	internal int curDepth; //Field offset: 0x1C
	internal bool isMatch; //Field offset: 0x20

	internal DoubleLinkAxis CurNode
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal AxisElement(DoubleLinkAxis node, int depth) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal DoubleLinkAxis get_CurNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	[CallerCount(Count = 0)]
	internal void SetDepth(int depth) { }

}

