namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule", "UnityEditor.TextCoreTextEngineModule"})]
internal struct LigatureSubstitutionRecord : IEquatable<LigatureSubstitutionRecord>
{
	[NativeName("componentGlyphs")]
	[SerializeField]
	private UInt32[] m_ComponentGlyphIDs; //Field offset: 0x0
	[NativeName("ligatureGlyph")]
	[SerializeField]
	private uint m_LigatureGlyphID; //Field offset: 0x8

	public UInt32[] componentGlyphIDs
	{
		[CallerCount(Count = 223)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public uint ligatureGlyphID
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(LigatureSubstitutionRecord other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public UInt32[] get_componentGlyphIDs() { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public uint get_ligatureGlyphID() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_componentGlyphIDs(UInt32[] value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_ligatureGlyphID(uint value) { }

}

