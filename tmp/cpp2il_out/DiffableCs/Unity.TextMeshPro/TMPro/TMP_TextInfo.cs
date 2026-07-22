namespace TMPro;

public class TMP_TextInfo
{
	internal static Vector2 k_InfinityVectorPositive; //Field offset: 0x0
	internal static Vector2 k_InfinityVectorNegative; //Field offset: 0x8
	public TMP_Text textComponent; //Field offset: 0x10
	public int characterCount; //Field offset: 0x18
	public int spriteCount; //Field offset: 0x1C
	public int spaceCount; //Field offset: 0x20
	public int wordCount; //Field offset: 0x24
	public int linkCount; //Field offset: 0x28
	public int lineCount; //Field offset: 0x2C
	public int pageCount; //Field offset: 0x30
	public int materialCount; //Field offset: 0x34
	public TMP_CharacterInfo[] characterInfo; //Field offset: 0x38
	public TMP_WordInfo[] wordInfo; //Field offset: 0x40
	public TMP_LinkInfo[] linkInfo; //Field offset: 0x48
	public TMP_LineInfo[] lineInfo; //Field offset: 0x50
	public TMP_PageInfo[] pageInfo; //Field offset: 0x58
	public TMP_MeshInfo[] meshInfo; //Field offset: 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; //Field offset: 0x68

	[CallerCount(Count = 0)]
	private static TMP_TextInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public TMP_TextInfo() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal TMP_TextInfo(int characterCount) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public TMP_TextInfo(TMP_Text textComponent) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	internal void ClearAllData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ClearAllMeshInfo() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void ClearLineInfo() { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "ClearMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ClearMeshInfo(bool updateMesh) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void ClearPageInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "set_isVolumetricText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ResetVertexLayout(bool isVolumetric) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void Resize(ref T[] array, int size) { }

	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void Resize(ref T[] array, int size, bool isBlockAllocated) { }

}

