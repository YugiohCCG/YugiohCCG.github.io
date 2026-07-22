namespace Mono.Globalization.Unicode;

internal class Contraction
{
	public int Index; //Field offset: 0x10
	public readonly Char[] Source; //Field offset: 0x18
	public readonly string Replacement; //Field offset: 0x20
	public readonly Byte[] SortKey; //Field offset: 0x28

	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(TailoringInfo), typeof(Contraction[]&), typeof(Level2Map[]&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Contraction(int index, Char[] source, string replacement, Byte[] sortkey) { }

}

