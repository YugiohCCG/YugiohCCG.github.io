namespace Card;

[IsReadOnly]
public struct CardArchetype
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UInt16, UInt16> <>9__18_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		internal ushort <get_MainArchetypes>b__18_0(ushort a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public CardArchetype other; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass28_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(ushort)}, ReturnType = typeof(bool))]
		internal bool <GetUniqueArchetypes>b__0(ushort archetype) { }

	}

	public static readonly CardArchetype EMPTY; //Field offset: 0x0
	private const byte SET_CODE_SIZE = 2; //Field offset: 0x0
	private static readonly UInt16[] DARK_ARCHETYPES; //Field offset: 0x8
	private readonly Byte[] SetCodes; //Field offset: 0x0

	public UInt16[] Archetypes
	{
		[CalledBy(Type = typeof(Banlist), Member = "FilterBySetcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Card), Member = "IsSupportFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Card), Member = "GetSetCodesData", ReturnType = typeof(String[]))]
		[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<>c__DisplayClass28_0), Member = "<GetUniqueArchetypes>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(UInt16[]))]
		[CalledBy(Type = typeof(CardArchetype), Member = "get_MainArchetypes", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(CardArchetype), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CardArchetype), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[])}, ReturnType = typeof(Boolean[]))]
		[CalledBy(Type = typeof(CardArchetype), Member = "GetUniqueArchetypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(CardArchetype))]
		[CalledBy(Type = typeof(Deck), Member = "<GetSetcodesAmount>g__parseDeck|62_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(float), typeof(<>c__DisplayClass62_0&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 298
	}

	public Boolean[] HasDarkArchetypes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardArchetype), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[])}, ReturnType = typeof(Boolean[]))]
		 get { } //Length: 95
	}

	public bool HasData
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 20
	}

	public bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardArchetype), Member = "get_MainArchetypes", ReturnType = typeof(long))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 124
	}

	public long MainArchetypes
	{
		[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(CardArchetype), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ClientCard), Member = "HasSetcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
		[Calls(Type = typeof(System.Func`2<System.UInt16, System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(System.Func`2<System.UInt16, System.UInt16>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.UInt16>))]
		[Calls(Type = typeof(Enumerable), Member = "Take", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>)}, ReturnType = typeof(UInt16[]))]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BitConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(long))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 568
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static CardArchetype() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 2)]
	public CardArchetype(Nullable<Int64> setcode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public CardArchetype(UInt16[] archetypes) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public CardArchetype(Byte[] setCodes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.UInt16>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(UInt16&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public CardArchetype(Dictionary<String, UInt16> setcodes, String[] setnames) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(ushort)}, ReturnType = typeof(bool))]
	public bool Contains(ushort archetype) { }

	[CalledBy(Type = typeof(CardArchetype), Member = "get_HasDarkArchetypes", ReturnType = typeof(Boolean[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(ushort)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public Boolean[] Contains(UInt16[] archetypes) { }

	[CalledBy(Type = typeof(Banlist), Member = "FilterBySetcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "IsSupportFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Card), Member = "GetSetCodesData", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass28_0), Member = "<GetUniqueArchetypes>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(UInt16[]))]
	[CalledBy(Type = typeof(CardArchetype), Member = "get_MainArchetypes", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(CardArchetype), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CardArchetype), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[])}, ReturnType = typeof(Boolean[]))]
	[CalledBy(Type = typeof(CardArchetype), Member = "GetUniqueArchetypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(CardArchetype))]
	[CalledBy(Type = typeof(Deck), Member = "<GetSetcodesAmount>g__parseDeck|62_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(float), typeof(<>c__DisplayClass62_0&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public UInt16[] get_Archetypes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardArchetype), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[])}, ReturnType = typeof(Boolean[]))]
	public Boolean[] get_HasDarkArchetypes() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_HasData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardArchetype), Member = "get_MainArchetypes", ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public bool get_IsEmpty() { }

	[CalledBy(Type = typeof(Card), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cards), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(CardArchetype), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientCard), Member = "HasSetcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(System.Func`2<System.UInt16, System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(System.Func`2<System.UInt16, System.UInt16>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.UInt16>))]
	[Calls(Type = typeof(Enumerable), Member = "Take", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>)}, ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public long get_MainArchetypes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>)}, ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public CardArchetype GetUniqueArchetypes(CardArchetype other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	public static UInt16[] op_Implicit(CardArchetype cardArchetype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 2)]
	public static CardArchetype op_Implicit(Nullable<Int64> setcode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 1)]
	public static CardArchetype op_Implicit(ulong setcode) { }

	[CalledBy(Type = typeof(Localization), Member = "GetTypeLineString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BotClientCard), Member = "HasSetcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "GetAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(ValueTuple`2<SByte, SByte>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "GetForCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(BanflagType), typeof(ValueTuple`2<SByte, SByte>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DBCardInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CardArchetype), Member = "get_MainArchetypes", ReturnType = typeof(long))]
	public static long op_Implicit(CardArchetype cardArchetype) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public static CardArchetype op_Implicit(Byte[] setCodes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static CardArchetype op_Implicit(UInt16[] archetypes) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public static Byte[] op_Implicit(CardArchetype cardArchetype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void WriteArchetypeCodes(UInt16[] archetypes) { }

}

