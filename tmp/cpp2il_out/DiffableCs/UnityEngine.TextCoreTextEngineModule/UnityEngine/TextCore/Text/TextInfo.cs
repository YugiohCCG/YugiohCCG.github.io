namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextInfo
{
	private static Vector2 s_InfinityVectorPositive; //Field offset: 0x0
	private static Vector2 s_InfinityVectorNegative; //Field offset: 0x8
	public int characterCount; //Field offset: 0x10
	public int spriteCount; //Field offset: 0x14
	public int spaceCount; //Field offset: 0x18
	public int wordCount; //Field offset: 0x1C
	public int linkCount; //Field offset: 0x20
	public int lineCount; //Field offset: 0x24
	public int materialCount; //Field offset: 0x28
	public TextElementInfo[] textElementInfo; //Field offset: 0x30
	public WordInfo[] wordInfo; //Field offset: 0x38
	public LinkInfo[] linkInfo; //Field offset: 0x40
	public LineInfo[] lineInfo; //Field offset: 0x48
	public MeshInfo[] meshInfo; //Field offset: 0x50
	public double lastTimeInCache; //Field offset: 0x58
	public Action removedFromCache; //Field offset: 0x60
	public bool hasMultipleColors; //Field offset: 0x68

	[CallerCount(Count = 0)]
	private static TextInfo() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<InitThreadArrays>b__4_2", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle+<>c", Member = "<get_textInfosCommon>b__13_0", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandleTemporaryCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public TextInfo() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void Clear() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void ClearLineInfo() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateTextMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ClearMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MeshInfo), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void ClearMeshInfo(bool updateMesh) { }

	[CalledBy(Type = typeof(TextInfo), Member = "FindNearestCharacterOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	[CalledBy(Type = typeof(TextHandle), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextInfo), Member = "PointIntersectRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public int FindIntersectingLink(Vector3 position, Rect screenRect, bool inverseYAxis = true) { }

	[CalledBy(Type = typeof(TextInfo), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextInfo), Member = "PointIntersectRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "DistanceToLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public int FindNearestLine(Vector2 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCharacterHeightFromIndex(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetCorrespondingStringIndex(int index) { }

	[CalledBy(Type = typeof(TextHandle), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextInfo), Member = "FindNearestCharacterOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public int GetCursorIndexFromPosition(Vector2 position, Rect screenRect, bool inverseYAxis = true) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, Rect screenRect, float lineHeight, bool inverseYAxis = true) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, Rect screenRect, float lineHeight, bool useXAdvance = false, bool inverseYAxis = true) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetLineHeight(int lineNumber) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetLineHeightFromCharacterIndex(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public int GetLineNumber(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public int IndexOf(char value, int startIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public int LastIndexOf(char value, int startIndex) { }

	[CalledBy(Type = typeof(TextHandle), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public int LineDownCharacterPosition(int originalPos) { }

	[CalledBy(Type = typeof(TextHandle), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public int LineUpCharacterPosition(int originalPos) { }

	[CalledBy(Type = typeof(TextInfo), Member = "FindNearestCharacterOnLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextInfo), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Rect), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveFromCache() { }

	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static void Resize(ref T[] array, int size, bool isBlockAllocated) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static void Resize(ref T[] array, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public string Substring(int startIndex, int length) { }

}

