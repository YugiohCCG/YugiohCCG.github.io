namespace System.Globalization;

internal static class EncodingTable
{
	internal static InternalEncodingDataItem[] encodingDataPtr; //Field offset: 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; //Field offset: 0x8
	private static int lastEncodingItem; //Field offset: 0x10
	private static Dictionary<String, Int32> hashByName; //Field offset: 0x18
	private static Dictionary<Int32, CodePageDataItem> hashByCodePage; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncodingTable), Member = "ENC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(InternalEncodingDataItem))]
	[Calls(Type = typeof(EncodingTable), Member = "MapCodePageDataItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort), typeof(string), typeof(uint)}, ReturnType = typeof(InternalCodePageDataItem))]
	[Calls(Type = typeof(EncodingTable), Member = "GetNumEncodingItems", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 818)]
	private static EncodingTable() { }

	[CalledBy(Type = typeof(EncodingTable), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 98)]
	[CallsUnknownMethods(Count = 1)]
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Encoding), Member = "GetDataItem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoding), Member = "get_WebName", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CodePageDataItem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }

	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncodingTable), Member = "internalGetCodePageFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	internal static int GetCodePageFromName(string name) { }

	[CalledBy(Type = typeof(EncodingTable), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetNumEncodingItems() { }

	[CalledBy(Type = typeof(EncodingTable), Member = "GetCodePageFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static int internalGetCodePageFromName(string name) { }

	[CalledBy(Type = typeof(EncodingTable), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 98)]
	[CallsUnknownMethods(Count = 1)]
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

}

