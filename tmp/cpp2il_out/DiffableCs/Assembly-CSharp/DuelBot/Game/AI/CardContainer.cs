namespace DuelBot.Game.AI;

[Extension]
public static class CardContainer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BotClientCard, Int32> <>9__3_1; //Field offset: 0x8
		public static Func<BotClientCard, Int32> <>9__4_1; //Field offset: 0x10
		public static Func<BotClientCard, Int32> <>9__5_1; //Field offset: 0x18
		public static Func<BotClientCard, Int32> <>9__6_1; //Field offset: 0x20
		public static Func<BotClientCard, Boolean> <>9__7_0; //Field offset: 0x28
		public static Func<BotClientCard, Boolean> <>9__8_0; //Field offset: 0x30
		public static Func<BotClientCard, Boolean> <>9__9_0; //Field offset: 0x38
		public static Func<BotClientCard, Boolean> <>9__10_0; //Field offset: 0x40
		public static Func<BotClientCard, Boolean> <>9__11_0; //Field offset: 0x48
		public static Func<BotClientCard, Boolean> <>9__12_0; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <ContainsCardWithId>b__9_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <ContainsMonsterWithLevel>b__7_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <ContainsMonsterWithRank>b__8_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <GetCardCount>b__10_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		internal bool <GetFaceupPendulumMonsters>b__12_0(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <GetHighestAttackMonster>b__3_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <GetHighestDefenseMonster>b__4_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <GetLowestAttackMonster>b__5_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int <GetLowestDefenseMonster>b__6_1(BotClientCard card) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		internal bool <GetMonsters>b__11_0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public int id; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass10_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetCardCount>b__1(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public bool canBeTarget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass13_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardExtension), Member = "IsMonsterInvincible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		internal bool <GetInvincibleMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public bool canBeTarget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass14_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardExtension), Member = "IsMonsterDangerous", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		internal bool <GetDangerousMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public bool canBeTarget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass15_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		internal bool <GetFloodgate>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Func<BotClientCard, Boolean> filter; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass16_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetFirstMatchingCard>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public Func<BotClientCard, Boolean> filter; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass17_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <GetFirstMatchingFaceupCard>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Func<BotClientCard, Boolean> filter; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass18_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetMatchingCards>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Func<BotClientCard, Boolean> filter; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass19_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <GetMatchingCardsCount>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public bool canBeTarget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass21_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		internal bool <GetShouldBeDisabledBeforeItUseEffectMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public IEnumerable<T> elements; //Field offset: 0x0
		public int k; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass22_0`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Skip", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[Calls(Type = typeof(CardContainer), Member = "GetCombinations", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<IEnumerable`1<T>>")]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal IEnumerable<IEnumerable`1<T>> <GetCombinations>b__0(T e, int i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public T e; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass22_1`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Concat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal IEnumerable<T> <GetCombinations>b__1(IEnumerable<T> c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public bool canBeTarget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetHighestAttackMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public bool canBeTarget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass4_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetHighestDefenseMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public bool canBeTarget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass5_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetLowestAttackMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public bool canBeTarget; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BotClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardExtension), Member = "IsShouldNotBeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <GetLowestDefenseMonster>b__0(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public int level; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass7_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <ContainsMonsterWithLevel>b__1(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public int rank; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass8_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <ContainsMonsterWithRank>b__1(BotClientCard card) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public int id; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass9_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BotClientCard), Member = "IsCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <ContainsCardWithId>b__1(BotClientCard card) { }

	}


	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int CompareCardAttack(BotClientCard cardA, BotClientCard cardB) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static int CompareCardLevel(BotClientCard cardA, BotClientCard cardB) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BotClientCard), Member = "GetDefensePower", ReturnType = typeof(int))]
	public static int CompareDefensePower(BotClientCard cardA, BotClientCard cardB) { }

	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "FalcoToGY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "FoolishBurial_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Phoneix_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Unicorn_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Snake_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static bool ContainsCardWithId(IEnumerable<BotClientCard> cards, int id) { }

	[CalledBy(Type = typeof(Rank5Executor), Member = "NeedLV5", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static bool ContainsMonsterWithLevel(IEnumerable<BotClientCard> cards, int level) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static bool ContainsMonsterWithRank(IEnumerable<BotClientCard> cards, int rank) { }

	[CalledBy(Type = typeof(BurnExecutor), Member = "SwordsOfRevealingLight", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static int GetCardCount(IEnumerable<BotClientCard> cards, int id) { }

	[CalledBy(Type = typeof(GameAI), Member = "OnSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>))]
	[CalledBy(Type = typeof(<>c__DisplayClass22_0`1), Member = "<GetCombinations>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<IEnumerable`1<T>>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<IEnumerable`1<T>> GetCombinations(IEnumerable<T> elements, int k) { }

	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultKaijuSpsummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "UltimateConductorTytannoeff", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static BotClientCard GetDangerousMonster(IEnumerable<BotClientCard> cards, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(QliphortExecutor), Member = "ScaleActivate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "ScoutEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "ShouldPendulum", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static List<BotClientCard> GetFaceupPendulumMonsters(IEnumerable<BotClientCard> cards) { }

	[CalledBy(Type = typeof(Level8Executor), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "LightStageEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "KnightmarePhoenixEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "GetFogBladeTarget", ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "SheorcustDingirsuEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "BorrelswordDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "EagleBoosterEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static BotClientCard GetFirstMatchingCard(IEnumerable<BotClientCard> cards, Func<BotClientCard, Boolean> filter) { }

	[CalledBy(Type = typeof(OrcustExecutor), Member = "NeedlefiberSummonSecond", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "GalateaSummonSecond", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static BotClientCard GetFirstMatchingFaceupCard(IEnumerable<BotClientCard> cards, Func<BotClientCard, Boolean> filter) { }

	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemySpell", ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetBestEnemySpell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultMysticalSpaceTyphoon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultKaijuSpsummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "RebornEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "GalaxyEyesFullArmorPhotonDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "KnightmarePhoenixEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static BotClientCard GetFloodgate(IEnumerable<BotClientCard> cards, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(TrickstarExecutor), Member = "White_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RushExecutor), Member = "blockAttackEff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MokeyMokeyKingExecutor), Member = "火星心少女Effect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MokeyMokeyKingExecutor), Member = "死供Effect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MokeyMokeyKingExecutor), Member = "七星道法师Effect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MokeyMokeyExecutor), Member = "七星道法师Effect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MokeyMokeyExecutor), Member = "死供Effect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MokeyMokeyExecutor), Member = "火星心少女Effect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CyberDragonExecutor), Member = "EvolutionBurstEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CyberDragonExecutor), Member = "ArmoredCybernEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NekrozExecutor), Member = "GungnirEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GravekeeperExecutor), Member = "GravekeepersDescendantEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlackwingExecutor), Member = "AttackUpEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlackwingExecutor), Member = "GaleTheWhirlwindEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlackwingExecutor), Member = "ShuraTheBlueFlameSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetBestEnemyCard_random", ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultBookOfMoon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetBestEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(ResonatorExecutor), Member = "novaEff", ReturnType = typeof(bool))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static BotClientCard GetHighestAttackMonster(IEnumerable<BotClientCard> cards, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(TrickstarExecutor), Member = "White_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualWorldExecutor), Member = "VWGate_XuanwuReposEff", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static BotClientCard GetHighestDefenseMonster(IEnumerable<BotClientCard> cards, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetProblematicEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static BotClientCard GetInvincibleMonster(IEnumerable<BotClientCard> cards, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(GrenMajuThunderBoarderExecutor), Member = "BorreloadDragoneff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Red_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Borrel_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static BotClientCard GetLowestAttackMonster(IEnumerable<BotClientCard> cards, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Red_ss", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static BotClientCard GetLowestDefenseMonster(IEnumerable<BotClientCard> cards, bool canBeTarget = false) { }

	[CalledBy(Type = typeof(DragunityExecutor), Member = "MonsterReborn", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HorusExecutor), Member = "MonsterReborn", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "PSYFramelordOmegaEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "NeedlefiberSummonSecond", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "GalateaSummonFirst", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "RustyBardicheSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "GalateaSummonSecond", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "BorrelswordDragonSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "BabelEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static IList<BotClientCard> GetMatchingCards(IEnumerable<BotClientCard> cards, Func<BotClientCard, Boolean> filter) { }

	[CalledBy(Type = typeof(Level8Executor), Member = "CrystronNeedlefiberSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "RescueRabbitSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "KnightmarePhoenixEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "KnightmarePhoenixSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "NeedlefiberSummonFirst", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "ShootingRiserDragonSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "MaskedChameleonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "MekkKnightCrusadiaAstramSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "JetSynchronEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "FoolishBurialEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "MagicalizedFusionEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "PredaplantVerteAnacondaSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "SummonForMaterial", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "NeedMonster", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "ImdukTheWorldChaliceDragonSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "SalamangreatAlmirajSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DragunExecutor), Member = "CrystronNeedlefiberSummon", ReturnType = typeof(bool))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static int GetMatchingCardsCount(IEnumerable<BotClientCard> cards, Func<BotClientCard, Boolean> filter) { }

	[CalledBy(Type = typeof(QliphortExecutor), Member = "ScaleActivate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZexalWeaponsExecutor), Member = "GoblindberghFirst", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(YosenjuExecutor), Member = "HaveAnotherYosenjuWithSameNameInHand", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "ToadallyAwesomeEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "ShouldPendulum", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QliphortExecutor), Member = "ScoutEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetWorstEnemyMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(LightswornExecutor), Member = "GoblindberghSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetWorstBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetBestBotMonster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AIUtil), Member = "IsAllEnemyBetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AIUtil), Member = "IsAllEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AIUtil), Member = "IsOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientField), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AIUtil), Member = "GetOneEnemyBetterThanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static List<BotClientCard> GetMonsters(IEnumerable<BotClientCard> cards) { }

	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Called_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static BotClientCard GetShouldBeDisabledBeforeItUseEffectMonster(IEnumerable<BotClientCard> cards, bool canBeTarget = true) { }

	[CalledBy(Type = typeof(Level8Executor), Member = "CrystronNeedlefiberEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "ShootingRiserDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "CarobeinSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "EngageEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "ShootingRiserDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "RustyBardicheEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "BorrelswordDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "RescueRabbitSummon", ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsExistingMatchingCard(IEnumerable<BotClientCard> cards, Func<BotClientCard, Boolean> filter, int count = 1) { }

}

