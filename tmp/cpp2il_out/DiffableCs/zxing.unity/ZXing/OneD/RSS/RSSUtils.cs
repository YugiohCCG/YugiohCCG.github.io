namespace ZXing.OneD.RSS;

public static class RSSUtils
{

	[CalledBy(Type = typeof(RSSUtils), Member = "getRSSvalue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static int combins(int n, int r) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CalledBy(Type = typeof(RSS14Reader), Member = "decodeDataCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(FinderPattern), typeof(bool)}, ReturnType = typeof(DataCharacter))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RSSUtils), Member = "combins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static int getRSSvalue(Int32[] widths, int maxWidth, bool noNarrow) { }

}

