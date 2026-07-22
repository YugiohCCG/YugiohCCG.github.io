namespace Mono.Globalization.Unicode;

internal class NormalizationTableUtil
{
	public static readonly CodePointIndexer Prop; //Field offset: 0x0
	public static readonly CodePointIndexer Map; //Field offset: 0x8
	public static readonly CodePointIndexer Combining; //Field offset: 0x10
	public static readonly CodePointIndexer Composite; //Field offset: 0x18
	public static readonly CodePointIndexer Helper; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CodePointIndexer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static NormalizationTableUtil() { }

	[CalledBy(Type = typeof(Normalization), Member = "CharMapIdx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Normalization), Member = "GetCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int MapIdx(int cp) { }

	[CalledBy(Type = typeof(Normalization), Member = "PropValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int PropIdx(int cp) { }

}

