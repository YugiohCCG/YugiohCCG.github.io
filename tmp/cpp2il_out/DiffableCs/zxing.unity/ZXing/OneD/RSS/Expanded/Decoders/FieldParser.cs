namespace ZXing.OneD.RSS.Expanded.Decoders;

internal static class FieldParser
{
	private static readonly object VARIABLE_LENGTH; //Field offset: 0x0
	private static readonly IDictionary<String, Object[]> TWO_DIGIT_DATA_LENGTH; //Field offset: 0x8
	private static readonly IDictionary<String, Object[]> THREE_DIGIT_DATA_LENGTH; //Field offset: 0x10
	private static readonly IDictionary<String, Object[]> THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH; //Field offset: 0x18
	private static readonly IDictionary<String, Object[]> FOUR_DIGIT_DATA_LENGTH; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 665)]
	private static FieldParser() { }

	[CalledBy(Type = typeof(AI01AndOtherAIs), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AnyAIDecoder), Member = "parseInformation", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(FieldParser), Member = "processFixedAI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(FieldParser), Member = "processVariableAI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GeneralAppIdDecoder), Member = "decodeAllCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	[ContainsInvalidInstructions]
	internal static string parseFieldsInGeneralPurpose(string rawInformation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FieldParser), Member = "parseFieldsInGeneralPurpose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 19)]
	private static string processFixedAI(int aiSize, int fieldSize, string rawInformation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FieldParser), Member = "parseFieldsInGeneralPurpose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 19)]
	private static string processVariableAI(int aiSize, int variableFieldSize, string rawInformation) { }

}

