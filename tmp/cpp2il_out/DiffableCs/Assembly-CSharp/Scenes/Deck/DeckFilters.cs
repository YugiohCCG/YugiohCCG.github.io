namespace Scenes.Deck;

public static class DeckFilters
{
	public static readonly List<Func`2<Card, Boolean>> Filters; //Field offset: 0x0
	public static Func<IEnumerable`1<Card>, IEnumerable`1<Card>> Sort; //Field offset: 0x8
	public static short atkmin; //Field offset: 0x10
	public static short atkmax; //Field offset: 0x12
	public static short defmin; //Field offset: 0x14
	public static short defmax; //Field offset: 0x16
	public static sbyte lrmin; //Field offset: 0x18
	public static sbyte lrmax; //Field offset: 0x19
	public static sbyte scalemin; //Field offset: 0x1A
	public static sbyte scalemax; //Field offset: 0x1B
	public static sbyte linkmin; //Field offset: 0x1C
	public static sbyte linkmax; //Field offset: 0x1D
	public static Card supportfor; //Field offset: 0x20
	public static Regex regex; //Field offset: 0x28
	public static bool regexDescOnly; //Field offset: 0x30
	public static DeckEdit i; //Field offset: 0x38
	public static DateTime dtf; //Field offset: 0x40
	public static DateTime dtt; //Field offset: 0x48
	public static float budget; //Field offset: 0x50
	public static short genmin; //Field offset: 0x54
	public static short genmax; //Field offset: 0x56

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static DeckFilters() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool AttackFilter(Card c) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static int AttackSortRule(Card c) { }

	[CallerCount(Count = 0)]
	private static int AttackSortRule(ClientCard c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "HasAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool AttributeFilter(Card c) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool BudgetFilter(Card c) { }

	[CalledBy(Type = "Game.DuelManager+<OnSelectCard>d__164", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 5)]
	public static IEnumerable<ClientCard> CardListSorting(IEnumerable<ClientCard> cards) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(Banlist), Member = "get_IsTCG", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "GetReleaseDateFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	private static long DateSortRule(Card c) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool DefenseFilter(Card c) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static int DefenseSortRule(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<Card.Card, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Card.Card>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static object DoFilter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(Banlist), Member = "GetGenesysCost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool GenesysFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasGenre", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Genre)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "IsHandTrap", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool GenreFilterExclusive(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasGenre", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Genre)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "IsHandTrap", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool GenreFilterInclusive(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "get_CardTypeSortOrder", ReturnType = typeof(int))]
	public static int GetCardTypeSortOrder(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_CardTypeSortOrder", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int GetCardTypeSortOrder(ClientCard c) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnSortTypeButton", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	public static Func<IEnumerable`1<Card>, IEnumerable`1<Card>> GetCurrentSortMethod(SortTypes type) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool inRange(int min, int max, int value) { }

	[CalledBy(Type = typeof(DeckFilters), Member = "OCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckFilters), Member = "TCGReleaseDateFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	public static bool IsMinMaxDate(in DateTime date) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static int LevelSortRule(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(Banlist), Member = "GetMaxQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte&)}, ReturnType = typeof(BanScope))]
	[Calls(Type = typeof(Card), Member = "get_IsIllegal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsRushCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "get_IsRushBanlist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "get_IsDLBanlist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "get_IsSPDBanlist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsRushLegend", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsBeta", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool LimitationFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(Card), Member = "HasLinkMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLinkMarker)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool LinkFilter(Card c) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool LRFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	private static string NameSortRule(ClientCard c) { }

	[CallerCount(Count = 0)]
	private static string NameSortRule(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DeckFilters), Member = "IsMinMaxDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool OCGReleaseDateFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "get_IsScriptless", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsCommon", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "IsCardFavorite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "CardIsInChangelog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsRushCard", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static bool PoolFilter(Card c) { }

	[CallerCount(Count = 0)]
	private static int PriceSortRule(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "HasRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool RaceFilter(Card c) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool ScaleFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static int ScaleSortRule(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool SelectedFilters(Card c) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int SortByController(ClientCard card) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<Card> SortingByAttack(IEnumerable<Card> ids) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<Card> SortingByAvgPrice(IEnumerable<Card> ids) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static int SortingByCardID(Card c) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static int SortingByCardID(ClientCard c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ThenByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<Card> SortingByCardType(IEnumerable<Card> ids) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<Card> SortingByDefense(IEnumerable<Card> ids) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<Card> SortingByLevel(IEnumerable<Card> ids) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<Card> SortingByName(IEnumerable<Card> ids) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int64>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int64>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<Card> SortingByReleaseDate(IEnumerable<Card> ids) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<Card> SortingByScale(IEnumerable<Card> ids) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasOneType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_ContainsCategory", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "IsTrapMonster", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool SubTypeFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "IsSupportFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool SupportFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "get_TCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_OCGReleaseDate", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DeckFilters), Member = "IsMinMaxDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TCGReleaseDateFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool TextFilter(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TextFilterDescOnly(Card c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TypeFilter(Card c) { }

}

