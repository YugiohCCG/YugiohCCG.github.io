namespace ZXing.OneD.RSS.Expanded.Decoders;

public abstract class AbstractExpandedDecoder
{
	private readonly BitArray information; //Field offset: 0x10
	private readonly GeneralAppIdDecoder generalDecoder; //Field offset: 0x18

	[CalledBy(Type = typeof(AbstractExpandedDecoder), Member = "createDecoder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(AbstractExpandedDecoder))]
	[CalledBy(Type = typeof(AI013103decoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI01320xDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI01392xDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI01393xDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI013x0x1xDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI013x0xDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI01AndOtherAIs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI01decoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AI01weightDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnyAIDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal AbstractExpandedDecoder(BitArray information) { }

	[CalledBy(Type = typeof(RSSExpandedReader), Member = "constructResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<ZXing.OneD.RSS.Expanded.ExpandedPair>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AbstractExpandedDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AI013x0x1xDecoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static AbstractExpandedDecoder createDecoder(BitArray information) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal GeneralAppIdDecoder getGeneralDecoder() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected BitArray getInformation() { }

	public abstract string parseInformation() { }

}

