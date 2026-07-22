namespace Mono.Globalization.Unicode;

internal class CodePointIndexer
{
	public struct TableRange
	{
		public readonly int Start; //Field offset: 0x0
		public readonly int End; //Field offset: 0x4
		public readonly int Count; //Field offset: 0x8
		public readonly int IndexStart; //Field offset: 0xC
		public readonly int IndexEnd; //Field offset: 0x10

		[CallerCount(Count = 0)]
		public TableRange(int start, int end, int indexStart) { }

	}

	private readonly TableRange[] ranges; //Field offset: 0x10
	public readonly int TotalCount; //Field offset: 0x18
	private int defaultIndex; //Field offset: 0x1C
	private int defaultCP; //Field offset: 0x20

	[CalledBy(Type = typeof(MSCompatUnicodeTableUtil), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NormalizationTableUtil), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public CodePointIndexer(Int32[] starts, Int32[] ends, int defaultIndex, int defaultCP) { }

	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NormalizationTableUtil), Member = "PropIdx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NormalizationTableUtil), Member = "MapIdx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType"}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Normalization), Member = "GetCombiningClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Normalization), Member = "GetPrimaryCompositeFromMapIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "GetPrimaryCompositeHelperIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "TryComposeWithPreviousStarter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	public int ToIndex(int cp) { }

}

