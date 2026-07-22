namespace ZXing.Client.Result;

internal sealed class ProductResultParser : ResultParser
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ProductResultParser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResultParser), Member = "isStringOfDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UPCEReader), Member = "convertUPCEtoUPCA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ProductParsedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual ParsedResult parse(Result result) { }

}

