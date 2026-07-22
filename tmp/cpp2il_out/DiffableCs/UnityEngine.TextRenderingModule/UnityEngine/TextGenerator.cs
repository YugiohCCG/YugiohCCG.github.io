namespace UnityEngine;

[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(TextGenerator textGenerator) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10
	private string m_LastString; //Field offset: 0x18
	private TextGenerationSettings m_LastSettings; //Field offset: 0x20
	private bool m_HasGenerated; //Field offset: 0x80
	private TextGenerationError m_LastValid; //Field offset: 0x84
	private readonly List<UIVertex> m_Verts; //Field offset: 0x88
	private readonly List<UICharInfo> m_Characters; //Field offset: 0x90
	private readonly List<UILineInfo> m_Lines; //Field offset: 0x98
	private bool m_CachedVerts; //Field offset: 0xA0
	private bool m_CachedCharacters; //Field offset: 0xA1
	private bool m_CachedLines; //Field offset: 0xA2

	public int characterCount
	{
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
	}

	public int characterCountVisible
	{
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 83
	}

	public IList<UICharInfo> characters
	{
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 133
	}

	public int lineCount
	{
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
	}

	public IList<UILineInfo> lines
	{
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineStartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 133
	}

	public Rect rectExtents
	{
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 105
	}

	public IList<UIVertex> verts
	{
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 133
	}

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_cachedInputTextGenerator", ReturnType = typeof(TextGenerator))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TextGenerator() { }

	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TextGenerator(int initialCapacity) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_characterCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_characterCount_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_characterCountVisible() { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public IList<UICharInfo> get_characters() { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_lineCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_lineCount_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DetermineCharacterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineStartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GetLineEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerator), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public IList<UILineInfo> get_lines() { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetDrawRangeToContainCaretPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect get_rectExtents() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_rectExtents_Injected(IntPtr _unity_self, out Rect ret) { }

	[CalledBy(Type = "UnityEngine.UI.Text", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public IList<UIVertex> get_verts() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void GetCharacters(List<UICharInfo> characters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeThrows]
	private void GetCharactersInternal(object characters) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetCharactersInternal_Injected(IntPtr _unity_self, object characters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void GetLines(List<UILineInfo> lines) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeThrows]
	private void GetLinesInternal(object lines) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetLinesInternal_Injected(IntPtr _unity_self, object lines) { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void GetVertices(List<UIVertex> vertices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeThrows]
	private void GetVerticesInternal(object vertices) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetVerticesInternal_Injected(IntPtr _unity_self, object vertices) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	private static IntPtr Internal_Create() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[CalledBy(Type = "UnityEngine.UI.Text", Member = "FontTextureChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public void Invalidate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[ContainsUnimplementedInstructions]
	public bool Populate(string str, TextGenerationSettings settings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateAlways", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CalledBy(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Font), typeof(Color), typeof(int), typeof(float), typeof(float), typeof(FontStyle), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(VerticalWrapMode), typeof(HorizontalWrapMode), typeof(bool), typeof(TextAnchor), typeof(Vector2), typeof(Vector2), typeof(bool), typeof(bool), typeof(TextGenerationError&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Font), typeof(Color), typeof(int), typeof(float), typeof(float), typeof(FontStyle), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TextAnchor), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(UInt32&)}, ReturnType = typeof(bool))]
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool Populate_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper str, IntPtr font, in Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextGenerator), Member = "ValidatedSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Font), typeof(Color), typeof(int), typeof(float), typeof(float), typeof(FontStyle), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TextAnchor), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings), typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "Populate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "ValidatedSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "Populate_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Font), typeof(Color), typeof(int), typeof(float), typeof(float), typeof(FontStyle), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TextAnchor), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.IDisposable.Dispose() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateAlways", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

}

