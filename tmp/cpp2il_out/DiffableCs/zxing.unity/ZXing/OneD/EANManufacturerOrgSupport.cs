namespace ZXing.OneD;

internal sealed class EANManufacturerOrgSupport
{
	private List<Int32[]> ranges; //Field offset: 0x10
	private List<String> countryIdentifiers; //Field offset: 0x18

	[CalledBy(Type = typeof(UPCEANReader), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public EANManufacturerOrgSupport() { }

	[CalledBy(Type = typeof(EANManufacturerOrgSupport), Member = "initIfNeeded", ReturnType = typeof(void))]
	[CallerCount(Count = 106)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void add(Int32[] range, string id) { }

	[CalledBy(Type = typeof(EANManufacturerOrgSupport), Member = "lookupCountryIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EANManufacturerOrgSupport), Member = "add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void initIfNeeded() { }

	[CalledBy(Type = typeof(UPCEANReader), Member = "decodeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray), typeof(Int32[]), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EANManufacturerOrgSupport), Member = "initIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal string lookupCountryIdentifier(string productCode) { }

}

