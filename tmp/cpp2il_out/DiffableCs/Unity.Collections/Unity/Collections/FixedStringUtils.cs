namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
internal static class FixedStringUtils
{
	public struct UintFloatUnion
	{
		public uint uintValue; //Field offset: 0x0
		public float floatValue; //Field offset: 0x0

	}


	[CalledBy(Type = typeof(FixedStringMethods), Member = "Parse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(Single&), typeof(char)}, ReturnType = typeof(ParseError))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static ParseError Base10ToBase2(ref float output, ulong mantissa10, int exponent10) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static void Base2ToBase10(ref ulong mantissa10, ref int exponent10, float input) { }

}

