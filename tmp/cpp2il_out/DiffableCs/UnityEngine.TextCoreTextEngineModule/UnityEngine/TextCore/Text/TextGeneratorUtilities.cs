namespace UnityEngine.TextCore.Text;

[Extension]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal static class TextGeneratorUtilities
{
	public static readonly Vector2 largePositiveVector2; //Field offset: 0x0
	public static readonly Vector2 largeNegativeVector2; //Field offset: 0x8
	private static readonly HashSet<UInt32> k_EmojiLookup; //Field offset: 0x10
	private static readonly HashSet<UInt32> k_EmojiPresentationFormLookup; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static TextGeneratorUtilities() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool Approximately(float a, float b) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	public static float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetAttributeParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Single[]&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float ConvertToFloat(Char[] chars, int startIndex, int length, out int lastIndex) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[CallsUnknownMethods(Count = 2)]
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[CallsUnknownMethods(Count = 2)]
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Color32))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static byte GammaToLinear(byte value) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "FillCharacterVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "FillSpriteVertexBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GammaToLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
	internal static Color32 GammaToLinear(Color32 c) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ConvertToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	public static int GetAttributeParameters(Char[] chars, int startIndex, int length, ref Single[] parameters) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static HorizontalAlignment GetHorizontalAlignment(TextAnchor anchor) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	public static int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextStyleSheet), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextStyle))]
	[CallsUnknownMethods(Count = 1)]
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	public static int GetStyleHashCode(ref UInt32[] text, int index, out int closeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static uint GetUTF16(UInt32[] text, int i) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static uint GetUTF16(TextBackingContainer text, int i) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public static uint GetUTF32(TextBackingContainer text, int i) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public static uint GetUTF32(UInt32[] text, int i) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static VerticalAlignment GetVerticalAlignment(TextAnchor anchor) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 2)]
	public static Color32 HexCharsToColor(Char[] hexChars, int startIndex, int tagCount) { }

	[CallerCount(Count = 49)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static uint HexToInt(char hex) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertOpeningTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingTextStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextStyle), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ResizeInternalArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetUTF16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetUTF32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ReplaceClosingStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, UInt32[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsBaseGlyph(uint c) { }

	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&", "System.Collections.Generic.List`1<Single>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<Material>", "System.Collections.Generic.List`1<GlyphRenderMode>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsCJK(uint c) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsEmoji(uint c) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsEmojiPresentationForm(uint c) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsHangul(uint c) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Extension]
	public static Color MinAlpha(Color c1, Color c2) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ReplaceOpeningStyleTag(ref UInt32[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "ToUpperASCIIFast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(int)}, ReturnType = typeof(TextStyle))]
	[Calls(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "InsertTextStyleInTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]&), typeof(Int32&), typeof(UInt32[]), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void ResizeInternalArray(ref T[] array, int size) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateTextProcessingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void ResizeInternalArray(ref T[] array) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetMarkupTagHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static uint ToUpperASCIIFast(uint c) { }

	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "ReplaceOpeningStyleTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&), typeof(TextProcessingElement[]&), typeof(Int32&), typeof(Int32&), typeof(TextProcessingStack`1<Int32>[]&), typeof(TextGenerationSettings&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGeneratorUtilities), Member = "GetStyleHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextBackingContainer&), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static char ToUpperASCIIFast(char c) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public static char ToUpperFast(char c) { }

}

