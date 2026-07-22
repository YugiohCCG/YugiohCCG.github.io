namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public static class FixedString
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, string arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, float arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, T2 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, int arg2, T1 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, T1 arg1, T2 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, string arg1, T2 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, float arg1, T2 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, int arg1, T2 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1, T1 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, T2 arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, T1 arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, T1 arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, T1 arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, T1 arg1, T2 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, string arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, T1 arg1, T2 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, T2 arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, T1 arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, T1 arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, T1 arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, string arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, float arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, int arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, T2 arg1, T3 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, T2 arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, T1 arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, T1 arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, T1 arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, string arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, float arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, int arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1, int arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, int arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, float arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, float arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, float arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, int arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, int arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, int arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, int arg1, string arg2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, T4 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, T2 arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, T1 arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, T1 arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, string arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, string arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, float arg0, string arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, int arg0, string arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0, float arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, float arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0, T1 arg1, float arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, int arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, int arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, string arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, int arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, string arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, int arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, string arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&"}, ReturnType = typeof(FormatError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, string arg0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, float arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "AppendFormat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U", "T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "U&", "T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(string)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(long)}, ReturnType = typeof(FormatError))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(float), typeof(char)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes), typeof(FixedString32Bytes)})]
	public static FixedString512Bytes Format(FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, float arg3) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FixedString32Bytes)})]
	public static FixedString128Bytes Format(FixedString128Bytes formatString, T1 arg0) { }

}

