namespace System.Xml.Schema;

internal class LocatedActiveAxis : ActiveAxis
{
	private int column; //Field offset: 0x28
	internal bool isMatched; //Field offset: 0x2C
	internal KeySequence Ks; //Field offset: 0x30

	internal int Column
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveAxis), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asttree)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal LocatedActiveAxis(Asttree astfield, KeySequence ks, int column) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int get_Column() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void Reactivate(KeySequence ks) { }

}

