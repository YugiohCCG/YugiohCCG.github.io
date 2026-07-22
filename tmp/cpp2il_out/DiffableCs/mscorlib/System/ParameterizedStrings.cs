namespace System;

internal static class ParameterizedStrings
{
	internal struct FormatParam
	{
		private readonly int _int32; //Field offset: 0x0
		private readonly string _string; //Field offset: 0x8

		public int Int32
		{
			[CallerCount(Count = 173)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public object Object
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 41
		}

		public string String
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 30
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public FormatParam(int value) { }

		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private FormatParam(int intValue, string stringValue) { }

		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		public int get_Int32() { }

		[CallerCount(Count = 0)]
		public object get_Object() { }

		[CallerCount(Count = 0)]
		public string get_String() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public static FormatParam op_Implicit(int value) { }

	}

	private sealed class LowLevelStack
	{
		private FormatParam[] _arr; //Field offset: 0x10
		private int _count; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public LowLevelStack() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public void Clear() { }

		[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		public FormatParam Pop() { }

		[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void Push(FormatParam item) { }

	}

	[ThreadStatic]
	private static LowLevelStack _cachedStack; //Field offset: 0x80000000

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool AsBool(int i) { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static int AsInt(bool b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	public static string Evaluate(string format, FormatParam[] args) { }

	[CalledBy(Type = typeof(TermInfoDriver), Member = "SetCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParameterizedStrings), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FormatParam[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(LowLevelStack), Member = "Pop", ReturnType = typeof(FormatParam))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ParameterizedStrings), Member = "GetDynamicOrStaticVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(FormatParam[]&), typeof(FormatParam[]&), typeof(Int32&)}, ReturnType = typeof(FormatParam[]))]
	[Calls(Type = typeof(LowLevelStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FormatParam)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsInvalidInstructions]
	private static string EvaluateInternal(string format, ref int pos, FormatParam[] args, LowLevelStack stack, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParameterizedStrings), Member = "snprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParameterizedStrings), Member = "snprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(IntPtr), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static string FormatPrintF(string format, object arg) { }

	[CalledBy(Type = typeof(ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(FormatParam[]), typeof(LowLevelStack), typeof(FormatParam[]&), typeof(FormatParam[]&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static FormatParam[] GetDynamicOrStaticVariables(char c, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars, out int index) { }

	[CalledBy(Type = typeof(ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static int snprintf(Byte* str, IntPtr size, string format, string arg1) { }

	[CalledBy(Type = typeof(ParameterizedStrings), Member = "FormatPrintF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static int snprintf(Byte* str, IntPtr size, string format, int arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private static string StringFromAsciiBytes(Byte[] buffer, int offset, int length) { }

}

