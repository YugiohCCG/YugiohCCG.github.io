namespace TMPro;

[Extension]
public static class TMPro_ExtensionMethods
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static string ArrayToString(Char[] chars) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool Compare(Color a, Color b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[CalledBy(Type = typeof(HighlightState), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HighlightState), typeof(HighlightState)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HighlightState), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HighlightState), typeof(HighlightState)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_faceColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "set_outlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool Compare(Color32 a, Color32 b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool CompareRGB(Color a, Color b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static int FindInstanceID(List<T> list, T target) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "FillCharacterVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "FillSpriteVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TMPro_ExtensionMethods), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
	[Extension]
	internal static Color32 GammaToLinear(Color32 c) { }

	[CalledBy(Type = typeof(TMPro_ExtensionMethods), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static byte GammaToLinear(byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static string IntToString(Int32[] unicodes, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static string IntToString(Int32[] unicodes) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Extension]
	public static Color MinAlpha(Color c1, Color c2) { }

	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	internal static int TagToInt(string s) { }

	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static Color32 Tint(Color32 c1, float tint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static Int32[] ToIntArray(string text) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	internal static string UintToString(List<UInt32> unicodes) { }

}

