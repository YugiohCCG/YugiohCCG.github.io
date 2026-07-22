namespace UnityEngine.TextCore.Text;

public class UnicodeLineBreakingRules
{
	[SerializeField]
	private TextAsset m_UnicodeLineBreakingRules; //Field offset: 0x10
	[SerializeField]
	private TextAsset m_LeadingCharacters; //Field offset: 0x18
	[SerializeField]
	private TextAsset m_FollowingCharacters; //Field offset: 0x20
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; //Field offset: 0x28
	private HashSet<UInt32> m_LeadingCharactersLookup; //Field offset: 0x30
	private HashSet<UInt32> m_FollowingCharactersLookup; //Field offset: 0x38

	internal HashSet<UInt32> followingCharactersLookup
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
		internal get { } //Length: 43
	}

	internal HashSet<UInt32> leadingCharactersLookup
	{
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
		internal get { } //Length: 43
	}

	public bool useModernHangulLineBreakingRules
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnicodeLineBreakingRules() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	internal HashSet<UInt32> get_followingCharactersLookup() { }

	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	internal HashSet<UInt32> get_leadingCharactersLookup() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_useModernHangulLineBreakingRules() { }

	[CalledBy(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static HashSet<UInt32> GetCharacters(TextAsset file) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSettings), Member = "get_lineBreakingRules", ReturnType = typeof(UnicodeLineBreakingRules))]
	[CalledBy(Type = typeof(TextSettings), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeLineBreakingRules), Member = "get_leadingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[CalledBy(Type = typeof(UnicodeLineBreakingRules), Member = "get_followingCharactersLookup", ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "GetCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void LoadLineBreakingRules() { }

}

