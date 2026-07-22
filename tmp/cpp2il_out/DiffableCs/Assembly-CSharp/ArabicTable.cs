//Type is in global namespace

internal class ArabicTable
{
	private static List<ArabicMapping> mapList; //Field offset: 0x0
	private static ArabicTable arabicMapper; //Field offset: 0x8

	internal static ArabicTable ArabicMapper
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArabicTable), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 148
	}

	[CalledBy(Type = typeof(ArabicTable), Member = "get_ArabicMapper", ReturnType = typeof(ArabicTable))]
	[CalledBy(Type = typeof(ArabicFixerTool), Member = "FixLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 44)]
	[CallsUnknownMethods(Count = 45)]
	private ArabicTable() { }

	[CalledBy(Type = typeof(ArabicFixerTool), Member = "FixLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal int Convert(int toBeConverted) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArabicTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static ArabicTable get_ArabicMapper() { }

}

