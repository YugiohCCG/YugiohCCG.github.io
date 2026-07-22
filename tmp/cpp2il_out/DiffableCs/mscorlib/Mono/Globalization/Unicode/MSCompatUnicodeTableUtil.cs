namespace Mono.Globalization.Unicode;

internal class MSCompatUnicodeTableUtil
{
	public static readonly CodePointIndexer Ignorable; //Field offset: 0x0
	public static readonly CodePointIndexer Category; //Field offset: 0x8
	public static readonly CodePointIndexer Level1; //Field offset: 0x10
	public static readonly CodePointIndexer Level2; //Field offset: 0x18
	public static readonly CodePointIndexer Level3; //Field offset: 0x20
	public static readonly CodePointIndexer CjkCHS; //Field offset: 0x28
	public static readonly CodePointIndexer Cjk; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CodePointIndexer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private static MSCompatUnicodeTableUtil() { }

}

