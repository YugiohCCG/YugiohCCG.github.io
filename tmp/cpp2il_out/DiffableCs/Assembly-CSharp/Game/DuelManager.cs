namespace Game;

public class DuelManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__93_0; //Field offset: 0x8
		public static Func<Boolean> <>9__93_1; //Field offset: 0x10
		public static Func<Boolean> <>9__93_2; //Field offset: 0x18
		public static Func<Boolean> <>9__94_0; //Field offset: 0x20
		public static Func<Boolean> <>9__94_1; //Field offset: 0x28
		public static Func<Boolean> <>9__94_2; //Field offset: 0x30
		public static Func<ClientCard, Boolean> <>9__105_0; //Field offset: 0x38
		public static Func<ClientCard, Boolean> <>9__105_1; //Field offset: 0x40
		public static Action <>9__166_3; //Field offset: 0x48
		public static Action<Boolean> <>9__166_0; //Field offset: 0x50
		public static Action<Boolean> <>9__171_0; //Field offset: 0x58
		public static Action<CardPosition> <>9__181_0; //Field offset: 0x60
		public static Action<Boolean> <>9__184_0; //Field offset: 0x68
		public static Func<Card, String> <>9__188_2; //Field offset: 0x70
		public static Func<IGrouping`2<String, Card>, String> <>9__188_3; //Field offset: 0x78
		public static Func<IGrouping`2<String, Card>, Int32> <>9__188_4; //Field offset: 0x80
		public static Func<Boolean> <>9__193_0; //Field offset: 0x88

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <DiceTosser>b__94_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <DiceTosser>b__94_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <DiceTosser>b__94_2() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal string <OnAnnounceCard>b__188_2(Card c) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal string <OnAnnounceCard>b__188_3(IGrouping<String, Card> c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal int <OnAnnounceCard>b__188_4(IGrouping<String, Card> c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnConfirmCards>b__105_0(ClientCard c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnConfirmCards>b__105_1(ClientCard c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <OnHandResult>b__193_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnSelectChain>b__166_0(bool r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnSelectChain>b__166_3() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		internal void <OnSelectEffectYn>b__171_0(bool r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnSelectPosition>b__181_0(CardPosition selected) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnSelectYesNo>b__184_0(bool r) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <OnTossCoin>b__93_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <OnTossCoin>b__93_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		internal bool <OnTossCoin>b__93_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass105_0
	{
		private struct <<OnConfirmCards>b__2>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass105_0 <>4__this; //Field offset: 0x28

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 15)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public IEnumerable<ClientCard> hand; //Field offset: 0x10
		public DuelManager <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass105_0() { }

		[AsyncStateMachine(typeof(<<OnConfirmCards>b__2>d))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.DuelManager+<>c__DisplayClass105_0+<<OnConfirmCards>b__2>d"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<OnConfirmCards>b__2>d&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnConfirmCards>b__2() { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass133_0
	{
		public ClientCard card; //Field offset: 0x0
		public CardLocation cLoc; //Field offset: 0x8
		public sbyte prevPosition; //Field offset: 0xC

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass143_0
	{
		public List<ClientCard> selected; //Field offset: 0x10
		public List<ClientCard> cards; //Field offset: 0x18
		public int count; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		public Func<ClientCard, Boolean> <>9__3; //Field offset: 0x30

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass143_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(<>c__DisplayClass143_0), Member = "<OnCardSorting>g__sendSortResult|1", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		internal void <OnCardSorting>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnCardSorting>b__3(ClientCard c) { }

		[CalledBy(Type = typeof(<>c__DisplayClass143_0), Member = "<OnCardSorting>b__0", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnCardSorting>g__sendSortResult|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass143_1
	{
		public ClientCard cc; //Field offset: 0x10
		public <>c__DisplayClass143_0 CS$<>8__locals1; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass143_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "GetCustomEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Template), Member = "UpdateLastChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		internal void <OnCardSorting>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass164_0
	{
		public List<ClientCard> selected; //Field offset: 0x10
		public bool isTribute; //Field offset: 0x18
		public byte scount; //Field offset: 0x19
		public int max; //Field offset: 0x1C
		public List<ClientCard> unselect; //Field offset: 0x20
		public bool cancelable; //Field offset: 0x28
		public int min; //Field offset: 0x2C
		public DuelManager <>4__this; //Field offset: 0x30
		public List<ClientCard> cards; //Field offset: 0x38
		public int count; //Field offset: 0x40
		public int count2; //Field offset: 0x44

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass164_0() { }

		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass164_1", Member = "<OnSelectCard>b__1", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "PostInternalOnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Card.ClientCard>), typeof(System.Collections.Generic.List`1<Card.ClientCard>), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		internal void <OnSelectCard>g__finishClick|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass164_1
	{
		public ClientCard cc; //Field offset: 0x10
		public <>c__DisplayClass164_0 CS$<>8__locals1; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass164_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "GetCustomEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Template), Member = "UpdateLastChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass164_0", Member = "<OnSelectCard>g__finishClick|0", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 9)]
		internal void <OnSelectCard>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass166_0
	{
		public Dictionary<ClientCard, List`1<ValueTuple`2<Int32, Int32>>> cards; //Field offset: 0x10
		public DuelManager <>4__this; //Field offset: 0x18
		public bool accessible; //Field offset: 0x20
		public string actionString; //Field offset: 0x28
		public bool trigger; //Field offset: 0x30
		public bool isOnlyOneCard; //Field offset: 0x31
		public bool forced; //Field offset: 0x32

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass166_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.ClientCard, System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>>), typeof(bool), typeof(bool), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnSelectChain>b__4() { }

		[CalledBy(Type = "Game.DuelManager+<OnSelectChain>d__166", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(<>c__DisplayClass166_0), Member = "<OnSelectChain>g__setGlow|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 7)]
		internal void <OnSelectChain>g__onSelect|2(bool r) { }

		[CalledBy(Type = typeof(<>c__DisplayClass166_0), Member = "<OnSelectChain>g__onSelect|2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectChain>d__166", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnSelectChain>g__setGlow|1(bool active) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass166_1
	{
		public ClientCard c; //Field offset: 0x10
		public <>c__DisplayClass166_0 CS$<>8__locals1; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass166_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.ClientCard, System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>>), typeof(bool), typeof(bool), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <OnSelectChain>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass168_0
	{
		public int res; //Field offset: 0x10
		public Dictionary<String, Int32> options; //Field offset: 0x18
		public DuelManager <>4__this; //Field offset: 0x20
		public Dictionary<ClientCard, List`1<ValueTuple`2<Int32, Int32>>> cards; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass168_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(<>c__DisplayClass168_0), Member = "<PostSelectChain>g__finalResponse|2", ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <PostSelectChain>g__askEffect|0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(<>c__DisplayClass168_0), Member = "<PostSelectChain>g__finalResponse|2", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <PostSelectChain>g__askEffectYn|1(bool Yn) { }

		[CalledBy(Type = typeof(<>c__DisplayClass168_0), Member = "<PostSelectChain>g__askEffect|0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<>c__DisplayClass168_0), Member = "<PostSelectChain>g__askEffectYn|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "PostSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.ClientCard, System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>>), typeof(bool), typeof(bool), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		internal void <PostSelectChain>g__finalResponse|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass169_0
	{
		public Int32[] used; //Field offset: 0x10
		public short quantity; //Field offset: 0x18
		public IList<Int32> counters; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		public IList<ClientCard> cards; //Field offset: 0x30

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass169_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass169_1
	{
		public int idx; //Field offset: 0x10
		public ClientCard cc; //Field offset: 0x18
		public <>c__DisplayClass169_0 CS$<>8__locals1; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass169_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Int32>), typeof(System.Collections.Generic.IList`1<Card.ClientCard>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal void <OnSelectCounter>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass173_0
	{
		public List<String> options; //Field offset: 0x10
		public int resultIndex; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass173_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		internal void <OnSelectOption>g__onConfirm|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass176_0
	{
		public Dictionary<FieldSlot, Int32> fsl; //Field offset: 0x10
		public List<Int32> selected; //Field offset: 0x18
		public List<Byte> playerResponse; //Field offset: 0x20
		public Byte[] player; //Field offset: 0x28
		public List<Int32> filterResponse; //Field offset: 0x30
		public Int32[] filter; //Field offset: 0x38
		public List<CardLocation> locationResponse; //Field offset: 0x40
		public CardLocation[] location; //Field offset: 0x48
		public DuelManager <>4__this; //Field offset: 0x50
		public byte count; //Field offset: 0x58
		public List<KeyValuePair`2<FieldSlot, Int32>> clearUpList; //Field offset: 0x60
		public bool cancelable; //Field offset: 0x68

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass176_0() { }

		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass176_1", Member = "<OnSelectPlace>b__4", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Int32[]), typeof(Int32[]), typeof(CardLocation[]), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		internal void <OnSelectPlace>g__answer|3() { }

		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass176_1", Member = "<OnSelectPlace>b__4", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DuelManager), Member = "<OnSelectPlace>g__setEdge|176_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnSelectPlace>g__onSelect|1(FieldSlot fs, int ptx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "<OnSelectPlace>g__setEdge|176_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Byte>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnSelectPlace>g__onUnselect|2(FieldSlot fs, int ptx) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass176_1
	{
		public FieldSlot fso; //Field offset: 0x10
		public int ptx; //Field offset: 0x18
		public <>c__DisplayClass176_0 CS$<>8__locals1; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass176_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "<OnSelectPlace>g__setEdge|176_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Byte>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass176_0", Member = "<OnSelectPlace>g__onSelect|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass176_0", Member = "<OnSelectPlace>g__answer|3", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void <OnSelectPlace>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass179_0
	{
		public Dictionary<FieldSlot, Action> actionsBackup; //Field offset: 0x10
		public DuelManager <>4__this; //Field offset: 0x18
		public FinishIcon oldLabel; //Field offset: 0x20
		public Action onDone; //Field offset: 0x28
		public bool target; //Field offset: 0x30
		public ClientCard card; //Field offset: 0x38
		public Func<FieldSlot, Boolean> <>9__6; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass179_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(<>c__DisplayClass179_0), Member = "<ManualSelectPlace>g__clear|0", ReturnType = typeof(void))]
		[Calls(Type = typeof(<>c__DisplayClass179_0), Member = "<ManualSelectPlace>g__end|1", ReturnType = typeof(void))]
		internal void <ManualSelectPlace>b__2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "ManualMoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "ManualTargetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(<>c__DisplayClass179_0), Member = "<ManualSelectPlace>g__clear|0", ReturnType = typeof(void))]
		[Calls(Type = typeof(<>c__DisplayClass179_0), Member = "<ManualSelectPlace>g__end|1", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <ManualSelectPlace>b__3(bool isOpp) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <ManualSelectPlace>b__4() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <ManualSelectPlace>b__5() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <ManualSelectPlace>b__6(FieldSlot f) { }

		[CalledBy(Type = typeof(<>c__DisplayClass179_0), Member = "<ManualSelectPlace>b__2", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<>c__DisplayClass179_0), Member = "<ManualSelectPlace>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__7", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DuelZone), Member = "get_AllFieldZones", ReturnType = typeof(System.Collections.Generic.List`1<Scenes.Battle.FieldSlot>))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HandCards), Member = "ToggleHandAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		internal void <ManualSelectPlace>g__clear|0() { }

		[CalledBy(Type = typeof(<>c__DisplayClass179_0), Member = "<ManualSelectPlace>b__2", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<>c__DisplayClass179_0), Member = "<ManualSelectPlace>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__7", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__8", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_1", Member = "<ManualSelectPlace>b__9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<>c__DisplayClass179_2", Member = "<ManualSelectPlace>b__10", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SelectCardPosition), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		internal void <ManualSelectPlace>g__end|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass179_1
	{
		public FieldSlot fs; //Field offset: 0x10
		public <>c__DisplayClass179_0 CS$<>8__locals1; //Field offset: 0x18
		public Action <>9__8; //Field offset: 0x20
		public Action<CardPosition> <>9__9; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass179_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "ManualTargetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SelectCardPosition), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardPosition>), typeof(System.Action`1<Enumerator.CardPosition>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__end|1", ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__clear|0", ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "ManualMoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
		[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 17)]
		internal void <ManualSelectPlace>b__7() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(ClientCard), Member = "ManualMoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__end|1", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void <ManualSelectPlace>b__8() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
		[Calls(Type = typeof(ClientCard), Member = "ManualMoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__end|1", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		internal void <ManualSelectPlace>b__9(CardPosition selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass179_2
	{
		public CardPosition selected; //Field offset: 0x10
		public <>c__DisplayClass179_1 CS$<>8__locals2; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass179_2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
		[Calls(Type = typeof(ClientCard), Member = "ManualMoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass179_0", Member = "<ManualSelectPlace>g__end|1", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <ManualSelectPlace>b__10() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass182_0
	{
		public List<ClientCard> selected; //Field offset: 0x10
		public int summincount; //Field offset: 0x18
		public int summaxcount; //Field offset: 0x1C
		public int mandatoryCount; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		public int max; //Field offset: 0x30
		public bool isArbitrary; //Field offset: 0x34
		public string sumstring; //Field offset: 0x38
		public string defsumstring; //Field offset: 0x40
		public string lvhalf; //Field offset: 0x48
		public string lvon; //Field offset: 0x50
		public string lvoff; //Field offset: 0x58
		public int mandatoryMaxVal; //Field offset: 0x60
		public int mandatoryMinVal; //Field offset: 0x64
		public string hint; //Field offset: 0x68
		public List<ClientCard> cards; //Field offset: 0x70
		public List<ClientCard> mandatoryCards; //Field offset: 0x78
		public int min; //Field offset: 0x80
		public int sumval; //Field offset: 0x84
		public bool mode; //Field offset: 0x88

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass182_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "get_IsPickingSynchro", ReturnType = typeof(bool))]
		[Calls(Type = typeof(<>c__DisplayClass182_0), Member = "<OnSelectSum>g__clear|1", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "<OnSelectSum>g__cancel|182_2", ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectSum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Card.ClientCard>), typeof(System.Collections.Generic.IList`1<Card.ClientCard>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 37)]
		[CallsUnknownMethods(Count = 38)]
		internal void <OnSelectSum>b__3() { }

		[CalledBy(Type = typeof(<>c__DisplayClass182_0), Member = "<OnSelectSum>b__3", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardListDisplay), Member = "OnClose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		internal void <OnSelectSum>g__clear|1() { }

		[CalledBy(Type = "Game.DuelManager+<OnSelectSum>d__182", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void <OnSelectSum>g__finishName|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass182_1
	{
		public ClientCard cc; //Field offset: 0x10
		public <>c__DisplayClass182_0 CS$<>8__locals1; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass182_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "ReplaceFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "UpdateLastChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_SelectHint", ReturnType = typeof(int))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "GetCustomEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = "T")]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 12)]
		[ContainsUnimplementedInstructions]
		internal void <OnSelectSum>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass185_0
	{
		public byte count; //Field offset: 0x10
		public DuelManager <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass185_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AttributeSelection), Member = "GetSelection", ReturnType = typeof(System.Collections.Generic.List`1<Enumerator.CardAttribute>))]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectAttrib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Enumerator.CardAttribute>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AttributeSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal void <OnAnnounceAttrib>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass188_0
	{
		public int resultIndex; //Field offset: 0x10
		public Int32[] filters; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass188_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
		[Calls(Type = typeof(DuelManager), Member = "IsDeclarable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(Int32[])}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool <OnAnnounceCard>b__1(Card c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = typeof(DuelManager), Member = "IsDeclarable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(Int32[])}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		internal void <OnAnnounceCard>g__onConfirm|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass189_0
	{
		public List<String> numbers; //Field offset: 0x10
		public int resultIndex; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass189_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GeneralSelection), Member = "GetSelectionIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		internal void <OnAnnounceNumber>g__onConfirm|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass190_0
	{
		public byte count; //Field offset: 0x10
		public DuelManager <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass190_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RaceSelection), Member = "GetSelection", ReturnType = typeof(System.Collections.Generic.List`1<Enumerator.CardRace>))]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Enumerator.CardRace>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RaceSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		internal void <OnAnnounceRace>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		private struct <<OnSwapGraveDeck>g__doSwap|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public FieldSlot deck; //Field offset: 0x20
			public FieldSlot grave; //Field offset: 0x28
			public <>c__DisplayClass79_0 <>4__this; //Field offset: 0x30
			public FieldSlot extra; //Field offset: 0x38
			private List<Template> <cards>5__2; //Field offset: 0x40
			private Enumerator<Template> <>7__wrap2; //Field offset: 0x48
			private TaskAwaiter <>u__1; //Field offset: 0x60

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
			[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
			[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Duel), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(ClientCard), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(ClientCard), Member = "IsExtraCard", ReturnType = typeof(bool))]
			[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
			[Calls(Type = typeof(Duel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(ClientCard), typeof(byte), typeof(byte), typeof(byte), typeof(int)}, ReturnType = typeof(Task))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 18)]
			[CallsUnknownMethods(Count = 53)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public DuelManager <>4__this; //Field offset: 0x10
		public byte player; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass79_0() { }

		[AsyncStateMachine(typeof(<<OnSwapGraveDeck>g__doSwap|0>d))]
		[CalledBy(Type = "Game.DuelManager+<OnSwapGraveDeck>d__79", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.DuelManager+<>c__DisplayClass79_0+<<OnSwapGraveDeck>g__doSwap|0>d"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<<OnSwapGraveDeck>g__doSwap|0>d&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal Task <OnSwapGraveDeck>g__doSwap|0(FieldSlot deck, FieldSlot grave, FieldSlot extra) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public ClientCard cc; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass88_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool <AnimateDeckTop>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass98_0
	{
		public float timing; //Field offset: 0x10
		public String[] atk; //Field offset: 0x18
		public Transform st; //Field offset: 0x20
		public ClientCard attackcard; //Field offset: 0x28
		public Transform tgt; //Field offset: 0x30
		public float sizeMult; //Field offset: 0x38
		public bool isDirectAttack; //Field offset: 0x3C
		public Vector3 orgRot; //Field offset: 0x40
		public Vector3 orgPos; //Field offset: 0x4C
		public FieldSlot zone; //Field offset: 0x58
		public TweenCallback <>9__2; //Field offset: 0x60
		public TweenCallback <>9__1; //Field offset: 0x68

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass98_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FPSData), Member = "get_IsLowFPS", ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(EffectColor), Member = "GetColorForAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		internal void <AttackCardMoveAnimation>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FPSData), Member = "get_IsLowFPS", ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(ShortcutExtensions), Member = "DOShakePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float), typeof(float), typeof(int), typeof(float), typeof(bool)}, ReturnType = typeof(Tweener))]
		[Calls(Type = typeof(ShortcutExtensions), Member = "DORotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(RotateMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>))]
		[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		internal void <AttackCardMoveAnimation>b__1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal void <AttackCardMoveAnimation>b__2() { }

	}

	[CompilerGenerated]
	private struct <AnimateDeckTop>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public IList<ClientCard> cards; //Field offset: 0x28
		private <>c__DisplayClass88_0 <>8__1; //Field offset: 0x30
		private bool <sr>5__2; //Field offset: 0x38
		private int <sort>5__3; //Field offset: 0x3C
		private IEnumerator<ClientCard> <>7__wrap3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hologram), Member = "SetHologram", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(Canvas), Member = "set_overrideSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "UpdatePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInUnplayableZone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "IsInDefense", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CardListDisplay), Member = "IsListed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitWhile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 81)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AttackCardMoveAnimation>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientCard attackcard; //Field offset: 0x20
		public ClientCard defendcard; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ShortcutExtensions), Member = "DOLocalRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(RotateMode)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>))]
		[Calls(Type = typeof(General), Member = "MoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(float), typeof(bool)}, ReturnType = typeof(DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>))]
		[Calls(Type = typeof(FieldSlot), Member = "get_IsCenterOppCard", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(EffectsManager), Member = "GetAttackElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 37)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CardHinted>d__109 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Int32[] ids; //Field offset: 0x28
		private byte <b>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArtDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DiceTosser>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte player; //Field offset: 0x20
		public Int32[] rolls; //Field offset: 0x28
		public float timer; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitWhile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(LogManager), Member = "GetPlayerColoredName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dice), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LogManager), Member = "OnDiceRoll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Int32[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAddCounter>d__89 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(ClientCard), Member = "AddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(ushort))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnAddCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CounterTypes), typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAnnounceAttrib>d__185 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectAttrib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Enumerator.CardAttribute>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_SelectHint", ReturnType = typeof(int))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AttributeSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Enumerator.CardAttribute>), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAnnounceCard>d__188 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Int32>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Object>), typeof(System.Func`2<System.Object, System.Int32>)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Manager), Member = "GetAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<Card.Card, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Card.Card>))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelManager), Member = "get_SelectHint", ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "GroupBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Object>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Linq.IGrouping`2<System.Object, System.Object>>))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAnnounceNumber>d__189 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_SelectHint", ReturnType = typeof(int))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAnnounceRace>d__190 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
		[Calls(Type = typeof(DuelManager), Member = "PostSelectRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Enumerator.CardRace>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RaceSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Enumerator.CardRace>), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_SelectHint", ReturnType = typeof(int))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAttack>d__135 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private ClientCard <attackcard>5__2; //Field offset: 0x30
		private ClientCard <defendcard>5__3; //Field offset: 0x38
		private TaskAwaiter<LineArc> <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(LineArc), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Scenes.Battle.LineArc>))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(LineArc), Member = "ClearBattleLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 58)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAttackDisabled>d__137 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LineArc), Member = "ClearBattleLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardAttackDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnBattle>d__136 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private ClientCard <ac>5__2; //Field offset: 0x30
		private bool <abd>5__3; //Field offset: 0x38
		private ClientCard <dc>5__4; //Field offset: 0x40
		private bool <dbd>5__5; //Field offset: 0x48
		private TaskAwaiter<LineArc> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "<OnBattle>g__addCrack|136_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "AttackCardMoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(LineArc), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Scenes.Battle.LineArc>))]
		[Calls(Type = typeof(LineArc), Member = "ClearBattleLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnAttackTargetChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsDefendingMonster", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "SetPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsAttackingMonster", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 56)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnBecomeTarget>d__146 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "AnimateDeckTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Card.ClientCard>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LogManager), Member = "OnBecameTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInHand", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 37)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCancelTarget>d__196 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCardHint>d__92 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LogManager), Member = "OnCardHintNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardHintAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(string), typeof(CardAttribute)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(LogManager), Member = "OnCardHintRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(string), typeof(CardRace)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetRaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(General), Member = "GetUniqueFlags", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(ArtDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardHintTurn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(LogManager), Member = "OnCardHintCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 36)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCardSorting>d__143 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 23)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCardTarget>d__195 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private ClientCard <ownerCard>5__2; //Field offset: 0x30
		private ClientCard <tgtCard>5__3; //Field offset: 0x38
		private FieldSlot <fs>5__4; //Field offset: 0x40
		private Transform <tgt>5__5; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter<LineArc> <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "AttackCardMoveAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Duel), Member = "get_IsBattlePhase", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LineArc), Member = "ClearToLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(LineArc), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Scenes.Battle.LineArc>))]
		[Calls(Type = typeof(Localization), Member = "GetLocationName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(sbyte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Template), Member = "get_IsInvalid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Duel), Member = "GetFieldSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(byte), typeof(byte)}, ReturnType = typeof(FieldSlot))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(LogManager), Member = "OnCardTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 44)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChainDisabled>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnChainNegated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChained>d__103 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChainEnd>d__142 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[Calls(Type = typeof(DuelManager), Member = "ClearTargeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "ClearAllTargeting", ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 48)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChaining>d__140 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "OnChainEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(LogManager), Member = "GetChainingEventString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArtDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "PlayActivateFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "ClearAllTargeting", ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(LogManager), Member = "OnChaining", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 28)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChainNegated>d__81 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnChainNegated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChainNegated>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		public bool disabled; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArtDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "set_Negating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "set_Negator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		[Calls(Type = typeof(LogManager), Member = "OnChainNegated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChainSolved>d__104 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "SetFieldBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "IsInFieldSpellZone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "set_Negator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "set_Negating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 25)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnChainSolving>d__102 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnConfirmCards>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitWhile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(LogManager), Member = "OnCardRevealed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(DuelManager), Member = "AnimateDeckTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Card.ClientCard>)}, ReturnType = typeof(Task))]
		[CallsDeduplicatedMethods(Count = 21)]
		[CallsUnknownMethods(Count = 38)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnConfirmExtraTop>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnConfirmTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnConfirmTop>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnConfirmTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnConfirmTop>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		public bool isExtra; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(FieldSlot), Member = "get_AmountOfCards", ReturnType = typeof(byte))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(LogManager), Member = "OnConfirmTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "AnimateDeckTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Card.ClientCard>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDamage>d__128 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnDamage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDamage>d__130 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		public bool wasCost; //Field offset: 0x30
		private int <dmg>5__2; //Field offset: 0x34
		private Transform <to>5__3; //Field offset: 0x38
		private ClientCard <caster>5__4; //Field offset: 0x40
		private Transform <from>5__5; //Field offset: 0x48
		private TaskAwaiter<LineArc> <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "GetAttackElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LineArc), Member = "ClearFromLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "AttackProjectileAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Transform), typeof(float), typeof(Vector3[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LineArc), Member = "get_GetArcPath", ReturnType = typeof(Vector3[]))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LogManager), Member = "OnLPDamage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientField), Member = "set_LifePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientField), Member = "get_LifePoints", ReturnType = typeof(int))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(LineArc), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Scenes.Battle.LineArc>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 42)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDamageStepEnd>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDamageStepStart>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LineArc), Member = "ClearBattleLine", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "GetBattleCards", ReturnType = typeof(System.ValueTuple`2<Card.ClientCard, Card.ClientCard>))]
		[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDeckTop>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Canvas), Member = "get_sortingOrder", ReturnType = typeof(int))]
		[Calls(Type = typeof(Canvas), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDraw>d__114 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		private byte <count>5__2; //Field offset: 0x30
		private UInt32[] <cardIds>5__3; //Field offset: 0x38
		private ObservableCollection<ClientCard> <hand>5__4; //Field offset: 0x40
		private ObservableCollection<ClientCard> <deck>5__5; //Field offset: 0x48
		private ClientCard[] <ccs>5__6; //Field offset: 0x50
		private byte <i>5__7; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientCard), Member = "set_Location", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(Enumerable), Member = "Take", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(LogManager), Member = "OnCardDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(bool), typeof(UInt32[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 49)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnEquip>d__194 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "set_EquipTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardEquipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFieldDisabled>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFlipSummoned>d__201 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSummoned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFlipSummoning>d__198 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSummoning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnHandResult>d__193 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		private byte <h0>5__2; //Field offset: 0x28
		private byte <h1>5__3; //Field offset: 0x29
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Packet), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Janken), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Janken), Member = "ShowResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Janken), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnJankenResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnHint>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnDeclareCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnDeclareNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(LogManager), Member = "OnDeclareCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "CardHinted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnDeclareAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardAttribute)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetAttributeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetRaceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardRace), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(LogManager), Member = "OnOpSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "set_SelectHint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(LogManager), Member = "OnDeclareRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardRace)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnLpUpdate>d__132 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(ClientField), Member = "get_LifePoints", ReturnType = typeof(int))]
		[Calls(Type = typeof(ClientField), Member = "set_LifePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnLPUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnMissedEffect>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(LogManager), Member = "OnMissedTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnMove>d__133 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		private <>c__DisplayClass133_0 <>8__1; //Field offset: 0x30
		private int <cardId>5__2; //Field offset: 0x40
		private byte <previousControler>5__3; //Field offset: 0x44
		private byte <previousLocation>5__4; //Field offset: 0x45
		private sbyte <previousSequence>5__5; //Field offset: 0x46
		private byte <currentControler>5__6; //Field offset: 0x47
		private byte <currentLocation>5__7; //Field offset: 0x48
		private sbyte <currentSequence>5__8; //Field offset: 0x49
		private sbyte <currentPosition>5__9; //Field offset: 0x4A
		private Reason <reason>5__10; //Field offset: 0x4C
		private ClientCard <orgCard>5__11; //Field offset: 0x50
		private int <oldId>5__12; //Field offset: 0x58
		private bool <wasOverlay>5__13; //Field offset: 0x5C
		private bool <gotOverlay>5__14; //Field offset: 0x5D
		private CardLocation <pLoc>5__15; //Field offset: 0x60
		private int <cId>5__16; //Field offset: 0x64
		private string <msg>5__17; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70
		private TaskAwaiter<ClientCard> <>u__2; //Field offset: 0x78
		private byte <count>5__18; //Field offset: 0x80
		private Enumerator<ClientCard> <>7__wrap18; //Field offset: 0x88
		private ClientCard <cc>5__20; //Field offset: 0xA0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(LineArc), Member = "ClearFromToLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "set_EquipTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Localization), Member = "GetLocationName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(sbyte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetPositionString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(LogManager), Member = "GetPlayerColoredName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(LogManager), Member = "OnCardMoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(Reason), typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(byte), typeof(CardLocation), typeof(byte), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "UpdateLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__isOnField|133_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__isFaceUp|133_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInMZone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__isDef|133_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardPosition)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__playSetFX|133_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "PlayActivateFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__playSpecialSummonFX|133_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__playNormalSummonFX|133_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "DetachCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Duel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(ClientCard), Member = "RemoveManualTarget", ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__playMaterialFX|133_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__playDestroyFX|133_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "IsInOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Duel), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(ClientCard), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(ClientCard), typeof(byte), typeof(byte), typeof(byte), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "IsUnplayableZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Duel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(int), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(ClientCard)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.ClientCard>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>), typeof(<OnMove>d__133)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Object>&), typeof(<OnMove>d__133&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "<OnMove>g__playOverlayFX|133_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(<>c__DisplayClass133_0&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "OverlayCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<OnMove>d__133)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<OnMove>d__133&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 24)]
		[CallsUnknownMethods(Count = 187)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnNewPhase>d__127 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(LogManager), Member = "OnNewPhase", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(ClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(BattlePhase), Member = "ClearData", ReturnType = typeof(void))]
		[Calls(Type = typeof(MainPhase), Member = "ClearData", ReturnType = typeof(void))]
		[Calls(Type = typeof(LineArc), Member = "ClearAllLines", ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldCenter), Member = "UpdatePhase", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 49)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnNewTurn>d__126 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(ChainMethod)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "get_IsHoldingChain", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(LifePoints), Member = "OnStartTurn", ReturnType = typeof(void))]
		[Calls(Type = typeof(LifePoints), Member = "OnEndTurn", ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "get_LocalPlayer", ReturnType = typeof(byte))]
		[Calls(Type = typeof(FieldCenter), Member = "UpdateTurn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnNewTurn", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 22)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnPacket>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameMessage msg; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		public BinaryReader packet; //Field offset: 0x30
		private bool <isRecordable>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "EndEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientReplay), Member = "ShouldRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage), typeof(BinaryReader)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientReplay), Member = "ShouldStopFFRW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "OnPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage), typeof(BinaryReader)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 39)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnPayLpCost>d__129 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnDamage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnPlayerHint>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnPosChange>d__138 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsInMZone", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "IsInDefense", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardPositionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CardPosition), typeof(CardPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRandomSelected>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(LogManager), Member = "OnRandomSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRecover>d__131 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(ClientField), Member = "get_LifePoints", ReturnType = typeof(int))]
		[Calls(Type = typeof(ClientField), Member = "set_LifePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnLPRecover", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnReloadField>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "SetEOMP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "ReadDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool), typeof(bool)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "GetChainingEventString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Duel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(int), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(ClientCard)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.ClientCard>))]
		[Calls(Type = typeof(ClientField), Member = "set_LifePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Manager), Member = "GetDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Deck))]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(LogManager), Member = "OnChaining", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard), typeof(int), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 23)]
		[CallsUnknownMethods(Count = 72)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRemoveCounter>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(ClientCard), Member = "RemoveCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(ushort))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnRemoveCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(CounterTypes), typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnReverseDeck>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(General), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRockPaperScissors>d__192 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Janken), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectBattleCmd>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BattlePhase), Member = "ParseData", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(ClientField), Member = "GetMonsters", ReturnType = typeof(System.Collections.Generic.List`1<Card.ClientCard>))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(MainPhase), Member = "ClearData", ReturnType = typeof(void))]
		[Calls(Type = typeof(BattlePhase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BattlePhase), Member = "ClearData", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(LineArc), Member = "ClearAllLines", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 48)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectCard>d__149 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectCard>d__164 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public byte mode; //Field offset: 0x28
		public BinaryReader packet; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldSlot), Member = "get_CurrentCard", ReturnType = typeof(Template))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelManager), Member = "get_SelectHint", ReturnType = typeof(int))]
		[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(DeckFilters), Member = "CardListSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>))]
		[Calls(Type = typeof(DuelManager), Member = "get_IsPickingAttackTarget", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsAccessibleLocation", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 20)]
		[CallsUnknownMethods(Count = 54)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectChain>d__166 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass166_0", Member = "<OnSelectChain>g__onSelect|2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass166_0", Member = "<OnSelectChain>g__setGlow|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetPhaseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Random), Member = "Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Duel), Member = "get_IsMyTurn", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsAccessibleLocation", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 16)]
		[CallsUnknownMethods(Count = 40)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectCounter>d__169 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Localization), Member = "GetCounterName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CounterTypes), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 34)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectDisfield>d__175 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectEffectYn>d__171 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Localization), Member = "GetFieldZoneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectIdleCmd>d__172 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LineArc), Member = "ClearAllLines", ReturnType = typeof(void))]
		[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MainPhase), Member = "ClearData", ReturnType = typeof(void))]
		[Calls(Type = typeof(BattlePhase), Member = "ClearData", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MainPhase), Member = "ParseData", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 16)]
		[CallsUnknownMethods(Count = 60)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectOption>d__173 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectPlace>d__174 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectPlace>d__176 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		public bool isDisfield; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldSlot), Member = "get_ZoneScale", ReturnType = typeof(float))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass176_0", Member = "<OnSelectPlace>g__answer|3", ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass176_0", Member = "<OnSelectPlace>g__onSelect|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Duel), Member = "GetFieldSlots", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(byte), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<Scenes.Battle.FieldSlot>))]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_SelectHint", ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 28)]
		[CallsUnknownMethods(Count = 157)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectPosition>d__181 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SelectCardPosition), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IList`1<Enumerator.CardPosition>), typeof(System.Action`1<Enumerator.CardPosition>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectSum>d__182 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass182_0", Member = "<OnSelectSum>g__finishName|0", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "GetTMProSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelManager), Member = "get_SelectHint", ReturnType = typeof(int))]
		[Calls(Type = typeof(CardListDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Card.ClientCard>), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_IsPickingSynchro", ReturnType = typeof(bool))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_IsAccessibleLocation", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Duel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 31)]
		[CallsUnknownMethods(Count = 70)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectTribute>d__151 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectUnselectCard>d__150 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSelectYesNo>d__184 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSet>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnShuffleDeck>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(FieldSlot), Member = "OnShuffle", ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[Calls(Type = typeof(ClientCard), Member = "RemoveManualTarget", ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnShuffleDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 26)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnShuffleExtra>d__117 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(FieldSlot), Member = "OnShuffle", ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "RemoveManualTarget", ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "IsFaceup", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnShuffleExtraDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 26)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnShuffleHand>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private byte <player>5__2; //Field offset: 0x30
		private byte <size>5__3; //Field offset: 0x31
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnShuffleHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HandCards), Member = "OnShuffle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Template), Member = "SetChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "UpdateTemplateLevelInHand", ReturnType = typeof(void))]
		[Calls(Type = typeof(Template), Member = "DefineCover", ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClientCard), Member = "RemoveManualTarget", ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 24)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnShuffleSetCard>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(LogManager), Member = "OnCardShuffled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSpSummoned>d__204 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(EffectsManager), Member = "DefineFinite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_ShouldKnow", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LogManager), Member = "OnCardSpSummoned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "set_CardStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Status)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 45)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSpSummoning>d__203 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private ClientCard <card>5__2; //Field offset: 0x30
		private bool <known>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(ArtDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientCard), Member = "get_ShouldKnow", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnStart>d__110 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		private int <lp1>5__2; //Field offset: 0x30
		private int <lp2>5__3; //Field offset: 0x34
		private byte <deck>5__4; //Field offset: 0x38
		private byte <p1>5__5; //Field offset: 0x39
		private byte <p2>5__6; //Field offset: 0x3A
		private ClientField[] <>7__wrap6; //Field offset: 0x40
		private int <>7__wrap7; //Field offset: 0x48
		private TaskAwaiter<ClientField> <>u__1; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldSide), Member = "set_Controller", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(LifePoints), Member = "SetTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClientField), Member = "set_LifePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LifePoints), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "GetFirstIndexOfTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(bool)}, ReturnType = typeof(sbyte))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(ClientField), Member = "CreateField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Player), typeof(int)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Game.ClientField>))]
		[Calls(Type = typeof(RoomData), Member = "GetFirstPlayerOfTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(bool)}, ReturnType = typeof(Player))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(DuelZone), Member = "AllowChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RoomData), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ChatWindow), Member = "ClearLog", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Janken), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 127)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSummoned>d__200 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSummoned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSummoned>d__202 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public bool flip; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(EffectsManager), Member = "DefineFinite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CardAnimationPlayer), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardSummoned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldSlot), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 32)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSummoning>d__197 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "OnSummoning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSummoning>d__199 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		public bool flip; //Field offset: 0x30
		private ClientCard <card>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArtDisplay), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
		[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSwap>d__134 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private ClientCard <card1>5__2; //Field offset: 0x30
		private ClientCard <card2>5__3; //Field offset: 0x38
		private byte <cont>5__4; //Field offset: 0x40
		private byte <seq>5__5; //Field offset: 0x41
		private byte <pos2>5__6; //Field offset: 0x42
		private CardLocation <loc>5__7; //Field offset: 0x44
		private TaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(Duel), Member = "RemoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(ClientCard), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Duel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation), typeof(ClientCard), typeof(byte), typeof(byte), typeof(byte), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Duel), Member = "GetFieldSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(FieldSlot))]
		[Calls(Type = typeof(Hologram), Member = "SetHologram", ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnCardSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 31)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSwapGraveDeck>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private <>c__DisplayClass79_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = "Game.DuelManager+<>c__DisplayClass79_0", Member = "<OnSwapGraveDeck>g__doSwap|0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(FieldSlot), typeof(FieldSlot)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "OnSwapDeckGY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 34)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnTagSwap>d__125 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		private byte <player>5__2; //Field offset: 0x30
		private byte <mcount>5__3; //Field offset: 0x31
		private byte <ecount>5__4; //Field offset: 0x32
		private byte <hcount>5__5; //Field offset: 0x33
		private int <topcode>5__6; //Field offset: 0x34
		private Player <newOwner>5__7; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private int <i>5__8; //Field offset: 0x48
		private ObservableCollection<ClientCard> <>7__wrap8; //Field offset: 0x50
		private TaskAwaiter<ClientCard> <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitForSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "get_WaitThreshold", ReturnType = typeof(float))]
		[Calls(Type = typeof(LogManager), Member = "OnTeamSwap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HandCards), Member = "DestroyHand", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(DuelZone), Member = "SetPlaymats", ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(FieldSlot), Member = "DestroySlotCards", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(DuelManager), Member = "SwapTeamPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CardPool), Member = "RequestNewCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardLocation), typeof(int), typeof(int), typeof(Player), typeof(ClientCard)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Card.ClientCard>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 28)]
		[CallsUnknownMethods(Count = 115)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnTossCoin>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		private byte <player>5__2; //Field offset: 0x30
		private Boolean[] <faces>5__3; //Field offset: 0x38
		private float <timer>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitWhile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LogManager), Member = "GetPlayerColoredName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Coin), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LogManager), Member = "OnCoinToss", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Boolean[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 25)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnTossDice>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader packet; //Field offset: 0x20
		public DuelManager <>4__this; //Field offset: 0x28
		private float <timer>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(DuelManager), Member = "DiceTosser", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Int32[]), typeof(float)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(General), Member = "CanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnUpdateCard>d__144 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "ParseCardInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(ClientCard))]
		[Calls(Type = typeof(ClientCard), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnUpdateData>d__145 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Duel), Member = "GetLocalPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(Duel), Member = "GetCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(System.Collections.Generic.IList`1<Card.ClientCard>))]
		[Calls(Type = typeof(ClientCard), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnWaiting>d__106 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelManager), Member = "UpdateWaiting", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnWin>d__113 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DuelManager <>4__this; //Field offset: 0x20
		public BinaryReader packet; //Field offset: 0x28
		private byte <reason>5__2; //Field offset: 0x30
		private byte <win>5__3; //Field offset: 0x31
		private bool <rank>5__4; //Field offset: 0x32
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private Player[] <>7__wrap4; //Field offset: 0x40
		private int <>7__wrap5; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ClientReplay), Member = "BuildReplaySharing", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(P2PManager), Member = "SendNetworkPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(long), typeof(C2CMode)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelManager), Member = "CalculateWinner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(RoomData), Member = "get_IsMatch", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DuelZone), Member = "CloseDuelForEnd", ReturnType = typeof(void))]
		[Calls(Type = typeof(Helper), Member = "ChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneType)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitWhile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(DuelEnd), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 16)]
		[CallsUnknownMethods(Count = 39)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const byte MAX_TEAM_SIZE = 3; //Field offset: 0x0
	private static readonly Queue<BinaryReader> GamePacketBuffer; //Field offset: 0x0
	public static bool RandomDelay; //Field offset: 0x8
	private static float _gs; //Field offset: 0xC
	public static bool AlwaysShowCardList; //Field offset: 0x10
	public static ChainMethod ChainReset; //Field offset: 0x14
	public static float TimeLimit; //Field offset: 0x18
	public static DateTime TimeLimitReceived; //Field offset: 0x20
	private static readonly Byte[] TEAM_ONE; //Field offset: 0x28
	private static readonly Byte[] TEAM_TWO; //Field offset: 0x30
	public static bool AlwaysShowPrompt; //Field offset: 0x38
	private readonly Dictionary<GameMessage, Func`2<BinaryReader, Task>> PacketHandlers; //Field offset: 0x10
	public readonly Duel Match; //Field offset: 0x18
	public byte DuelRule; //Field offset: 0x20
	private int _hint; //Field offset: 0x24
	public string EventHint; //Field offset: 0x28
	public FieldSlot ReferencedZoneAction; //Field offset: 0x30
	private sbyte _pausedBy; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HasReconnected>k__BackingField; //Field offset: 0x39
	private int _lastHint; //Field offset: 0x3C
	public BinaryReader LastPacket; //Field offset: 0x40
	[CompilerGenerated]
	private ChainMethod <ChainMethod>k__BackingField; //Field offset: 0x48
	public byte WaitingPlayer; //Field offset: 0x4C
	[CompilerGenerated]
	private DuelEndState <DuelOverState>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsReplay>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <IsWaitingForResponse>k__BackingField; //Field offset: 0x55
	[CompilerGenerated]
	private ulong <ReadingSteinerStep>k__BackingField; //Field offset: 0x58
	public bool IsPaused; //Field offset: 0x60
	public bool FastForward; //Field offset: 0x61
	public ulong ReplaySteps; //Field offset: 0x68
	public ulong StartStep; //Field offset: 0x70
	[CompilerGenerated]
	private ClientReplay <Replay>k__BackingField; //Field offset: 0x78
	public bool IsConfirmingCards; //Field offset: 0x80
	public bool WaitingToPickTarget; //Field offset: 0x81
	public bool WaitingToPickChain; //Field offset: 0x82
	public bool IsManualSelectingPlace; //Field offset: 0x83
	public Action<Boolean> ManualSelectHand; //Field offset: 0x88

	public ChainMethod ChainMethod
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DuelEndState DuelOverState
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public static float GameSpeed
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		 get { } //Length: 166
		[CalledBy(Type = typeof(SettingsMenu), Member = "ApplyGameplay", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 set { } //Length: 132
	}

	public static bool HasGamePackets
	{
		[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelZone), Member = "get_CanReadingSteiner", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DuelZone), Member = "ShouldParseReplay", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		 get { } //Length: 98
	}

	public private bool HasReconnected
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool IsPickingAttackTarget
	{
		[CalledBy(Type = typeof(<OnSelectCard>d__164), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientCard), Member = "get_CanAttack", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsPickingSummon
	{
		[CalledBy(Type = typeof(HandCards), Member = "EndDraggingClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragClone), typeof(Template)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public bool IsPickingSynchro
	{
		[CalledBy(Type = typeof(<>c__DisplayClass182_0), Member = "<OnSelectSum>b__3", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnSelectSum>d__182), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsReadingSteiner
	{
		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public private bool IsReplay
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private bool IsWaitingForResponse
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public sbyte PausedBy
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(Network), Member = "OnPause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 176
	}

	public ulong ReadingSteinerStep
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public private ClientReplay Replay
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public int SelectHint
	{
		[CalledBy(Type = typeof(<>c__DisplayClass182_1), Member = "<OnSelectSum>b__4", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnAnnounceAttrib>d__185), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnAnnounceCard>d__188), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnAnnounceNumber>d__189), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnAnnounceRace>d__190), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnSelectCard>d__164), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnSelectPlace>d__176), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnSelectSum>d__182), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		 get { } //Length: 14
		[CalledBy(Type = "Manager.Network+<Send>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnHint>d__108), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 248
	}

	public static float SettingsGameSpeed
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 80
	}

	public bool WaitingToPickAtkTgt
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public bool WaitingToPickCard
	{
		[CalledBy(Type = typeof(CardListDisplay), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 19
	}

	public static float WaitThreshold
	{
		[CalledBy(Type = typeof(<AnimateDeckTop>d__88), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<AttackCardMoveAnimation>d__98), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnCardHint>d__92), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnChainNegated>d__83), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnChaining>d__140), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnDraw>d__114), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnNewPhase>d__127), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnNewTurn>d__126), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnShuffleDeck>d__115), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnShuffleExtra>d__117), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnShuffleHand>d__116), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnSpSummoning>d__203), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnSummoning>d__199), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<OnTagSwap>d__125), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
		 get { } //Length: 348
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static DuelManager() { }

	[CalledBy(Type = typeof(DuelZone), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObservableCollection`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelManager), Member = "RegisterPackets", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public DuelManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private void <InitializeReplay>b__71_0() { }

	[CalledBy(Type = typeof(<OnBattle>d__136), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_ZoneScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void <OnBattle>g__addCrack|136_0(ClientCard c) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private bool <OnConfirmCards>b__105_3() { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static bool <OnMove>g__isDef|133_6(CardPosition p) { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static bool <OnMove>g__isFaceUp|133_5(CardPosition p) { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static bool <OnMove>g__isOnField|133_7(CardLocation l) { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_ZoneScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(float), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void <OnMove>g__playDestroyFX|133_2(ref <>c__DisplayClass133_0 unnamed_param_0) { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	internal static void <OnMove>g__playMaterialFX|133_3(bool extra, ref <>c__DisplayClass133_0 unnamed_param_1) { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	internal static void <OnMove>g__playNormalSummonFX|133_0(ref <>c__DisplayClass133_0 unnamed_param_0) { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	internal static void <OnMove>g__playOverlayFX|133_4(bool detach, ref <>c__DisplayClass133_0 unnamed_param_1) { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	internal static void <OnMove>g__playSetFX|133_1(ref <>c__DisplayClass133_0 unnamed_param_0) { }

	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), "System.Action`2<T, Object>", typeof(object), typeof(string), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[CompilerGenerated]
	internal static void <OnMove>g__playSpecialSummonFX|133_8(ref <>c__DisplayClass133_0 unnamed_param_0) { }

	[CalledBy(Type = typeof(<>c__DisplayClass176_0), Member = "<OnSelectPlace>g__onSelect|1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass176_0), Member = "<OnSelectPlace>g__onUnselect|2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldSlot), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass176_1), Member = "<OnSelectPlace>b__4", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EffectsManager), Member = "GetCustomEffect", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void <OnSelectPlace>g__setEdge|176_0(FieldSlot fs, bool active) { }

	[CalledBy(Type = typeof(<>c__DisplayClass182_0), Member = "<OnSelectSum>b__3", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void <OnSelectSum>g__cancel|182_2() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private bool <OnWin>b__113_0() { }

	[AsyncStateMachine(typeof(<AnimateDeckTop>d__88))]
	[CalledBy(Type = typeof(<OnBecomeTarget>d__146), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnConfirmCards>d__105), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnConfirmTop>d__87), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AnimateDeckTop>d__88)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AnimateDeckTop>d__88&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task AnimateDeckTop(IList<ClientCard> cards) { }

	[AsyncStateMachine(typeof(<AttackCardMoveAnimation>d__98))]
	[CalledBy(Type = typeof(<OnBattle>d__136), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnCardTarget>d__195), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AttackCardMoveAnimation>d__98)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AttackCardMoveAnimation>d__98&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task AttackCardMoveAnimation(ClientCard attackcard, ClientCard defendcard) { }

	[CalledBy(Type = typeof(<OnDamage>d__130), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(EffectsManager), Member = "GetAttackElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardAttribute)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FPSData), Member = "get_IsLowFPS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(EffectsManager), Member = "AddMovingEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Transform), typeof(Transform), typeof(Vector3[]), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void AttackProjectileAnimation(ClientCard attackcard, Transform defendcard, float size, Vector3[] path) { }

	[CalledBy(Type = typeof(<OnWin>d__113), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RoomData), Member = "GetMyIndex", ReturnType = typeof(byte))]
	[Calls(Type = typeof(RoomData), Member = "get_IsTeam", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private byte CalculateWinner(byte winner, byte reason) { }

	[AsyncStateMachine(typeof(<CardHinted>d__109))]
	[CalledBy(Type = typeof(<OnHint>d__108), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CardHinted>d__109)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CardHinted>d__109&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void CardHinted(Int32[] ids) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<CloseAllDuelWindows>d__79", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnDuelStart>d__71", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "get_Current", ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<System.Object>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void ClearPacketQueue() { }

	[CalledBy(Type = typeof(<OnChainEnd>d__142), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Collection`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "set_Negator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "set_Negating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "ClearAllChainOrders", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ClearTargeting(ClientCard cc) { }

	[AsyncStateMachine(typeof(<DiceTosser>d__94))]
	[CalledBy(Type = typeof(<OnTossDice>d__95), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DiceTosser>d__94)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DiceTosser>d__94&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task DiceTosser(byte player, Int32[] rolls, float timer) { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ChainMethod get_ChainMethod() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DuelEndState get_DuelOverState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	public static float get_GameSpeed() { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<FixedUpdate>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelZone), Member = "get_CanReadingSteiner", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DuelZone), Member = "ShouldParseReplay", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	public static bool get_HasGamePackets() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_HasReconnected() { }

	[CalledBy(Type = typeof(<OnSelectCard>d__164), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "get_CanAttack", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool get_IsPickingAttackTarget() { }

	[CalledBy(Type = typeof(HandCards), Member = "EndDraggingClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragClone), typeof(Template)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsPickingSummon() { }

	[CalledBy(Type = typeof(<>c__DisplayClass182_0), Member = "<OnSelectSum>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSelectSum>d__182), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_IsPickingSynchro() { }

	[CallerCount(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsReadingSteiner() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsReplay() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsWaitingForResponse() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public sbyte get_PausedBy() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ulong get_ReadingSteinerStep() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ClientReplay get_Replay() { }

	[CalledBy(Type = typeof(<>c__DisplayClass182_1), Member = "<OnSelectSum>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnAnnounceAttrib>d__185), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnAnnounceCard>d__188), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnAnnounceNumber>d__189), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnAnnounceRace>d__190), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSelectCard>d__164), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSelectPlace>d__176), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSelectSum>d__182), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	public int get_SelectHint() { }

	[CallerCount(Count = 0)]
	public static float get_SettingsGameSpeed() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_WaitingToPickAtkTgt() { }

	[CalledBy(Type = typeof(CardListDisplay), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public bool get_WaitingToPickCard() { }

	[CalledBy(Type = typeof(<AnimateDeckTop>d__88), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<AttackCardMoveAnimation>d__98), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnCardHint>d__92), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnChainNegated>d__83), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnChaining>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnDraw>d__114), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnNewPhase>d__127), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnNewTurn>d__126), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnShuffleDeck>d__115), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnShuffleExtra>d__117), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnShuffleHand>d__116), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSpSummoning>d__203), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSummoning>d__199), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnTagSwap>d__125), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	public static float get_WaitThreshold() { }

	[CalledBy(Type = typeof(<OnDamageStepStart>d__96), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private ValueTuple<ClientCard, ClientCard> GetBattleCards() { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<DoParse>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetQueuedPacket(out BinaryReader msg) { }

	[CalledBy(Type = typeof(Player), Member = "RedefineData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RoomData), Member = "GetFirstIndexOfTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(bool)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(RoomData), Member = "GetTeamOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(RoomData), Member = "GetFirstPlayerOfTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(bool)}, ReturnType = typeof(Player))]
	[CallerCount(Count = 6)]
	public static Byte[] GetTeamByIndex(sbyte team) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<PrepareDuel>d__77", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientReplay), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RoomData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void InitializeReplay(ClientReplay rp, bool isReplay) { }

	[CalledBy(Type = typeof(<>c__DisplayClass188_0), Member = "<OnAnnounceCard>g__onConfirm|0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass188_0), Member = "<OnAnnounceCard>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ClientAPI.WebServer+DBCardList+<>c__DisplayClass2_0", Member = "<.ctor>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public static bool IsDeclarable(Card card, Int32[] filters) { }

	[CalledBy(Type = typeof(RoomData), Member = "IsTAGAlly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RoomData), Member = "IsPlayedTAGAlly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource"}, ReturnType = typeof(bool))]
	public static bool IsSameTeam(byte p1, byte p2) { }

	[CalledBy(Type = typeof(HandCards), Member = "EndDraggingClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragClone), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnMove", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardOptionList), Member = "OnAttack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientCard), Member = "SendAttack", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HandCards), Member = "ToggleHandAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(DuelZone), Member = "get_AllFieldZones", ReturnType = typeof(System.Collections.Generic.List`1<Scenes.Battle.FieldSlot>))]
	[Calls(Type = typeof(DuelZone), Member = "set_OnClickFinishAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 29)]
	public void ManualSelectPlace(ClientCard card, bool target, Action onDone = null) { }

	[AsyncStateMachine(typeof(<OnAddCounter>d__89))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAddCounter>d__89)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAddCounter>d__89&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnAddCounter(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnAnnounceAttrib>d__185))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceAttrib>d__185)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceAttrib>d__185&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnAnnounceAttrib(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnAnnounceCard>d__188))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceCard>d__188)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceCard>d__188&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnAnnounceCard(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnAnnounceNumber>d__189))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceNumber>d__189)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceNumber>d__189&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnAnnounceNumber(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnAnnounceRace>d__190))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceRace>d__190)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceRace>d__190&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnAnnounceRace(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnAttack>d__135))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAttack>d__135)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAttack>d__135&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnAttack(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnAttackDisabled>d__137))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAttackDisabled>d__137)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAttackDisabled>d__137&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnAttackDisabled(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnBattle>d__136))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBattle>d__136)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBattle>d__136&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnBattle(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnBecomeTarget>d__146))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBecomeTarget>d__146)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnBecomeTarget>d__146&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnBecomeTarget(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnCancelTarget>d__196))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCancelTarget>d__196)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCancelTarget>d__196&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnCancelTarget(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnCardHint>d__92))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardHint>d__92)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardHint>d__92&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnCardHint(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnCardSorting>d__143))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardSorting>d__143)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardSorting>d__143&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnCardSorting(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnCardTarget>d__195))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardTarget>d__195)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnCardTarget>d__195&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnCardTarget(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnChainDisabled>d__82))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainDisabled>d__82)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainDisabled>d__82&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnChainDisabled(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnChained>d__103))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChained>d__103)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChained>d__103&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnChained(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnChainEnd>d__142))]
	[CalledBy(Type = typeof(<OnChaining>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainEnd>d__142)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainEnd>d__142&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnChainEnd(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnChaining>d__140))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChaining>d__140)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChaining>d__140&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnChaining(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnChainNegated>d__83))]
	[CalledBy(Type = typeof(<OnChainDisabled>d__82), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnChainNegated>d__81), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainNegated>d__83)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainNegated>d__83&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnChainNegated(BinaryReader packet, bool disabled) { }

	[AsyncStateMachine(typeof(<OnChainNegated>d__81))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainNegated>d__81)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainNegated>d__81&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnChainNegated(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnChainSolved>d__104))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainSolved>d__104)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainSolved>d__104&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnChainSolved(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnChainSolving>d__102))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainSolving>d__102)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChainSolving>d__102&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnChainSolving(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnConfirmCards>d__105))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnConfirmCards>d__105)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnConfirmCards>d__105&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnConfirmCards(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnConfirmExtraTop>d__86))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnConfirmExtraTop>d__86)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnConfirmExtraTop>d__86&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnConfirmExtraTop(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnConfirmTop>d__85))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnConfirmTop>d__85)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnConfirmTop>d__85&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnConfirmTop(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnConfirmTop>d__87))]
	[CalledBy(Type = typeof(<OnConfirmExtraTop>d__86), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnConfirmTop>d__85), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnConfirmTop>d__87)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnConfirmTop>d__87&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnConfirmTop(BinaryReader packet, bool isExtra) { }

	[AsyncStateMachine(typeof(<OnDamage>d__130))]
	[CalledBy(Type = typeof(<OnDamage>d__128), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnPayLpCost>d__129), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDamage>d__130)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDamage>d__130&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnDamage(BinaryReader packet, bool wasCost) { }

	[AsyncStateMachine(typeof(<OnDamage>d__128))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDamage>d__128)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDamage>d__128&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnDamage(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnDamageStepEnd>d__100))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDamageStepEnd>d__100)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDamageStepEnd>d__100&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task OnDamageStepEnd(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnDamageStepStart>d__96))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDamageStepStart>d__96)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDamageStepStart>d__96&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task OnDamageStepStart(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnDeckTop>d__77))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDeckTop>d__77)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDeckTop>d__77&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnDeckTop(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnDraw>d__114))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDraw>d__114)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDraw>d__114&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnDraw(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnEquip>d__194))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnEquip>d__194)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnEquip>d__194&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnEquip(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnFieldDisabled>d__80))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldDisabled>d__80)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldDisabled>d__80&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnFieldDisabled(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnFlipSummoned>d__201))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFlipSummoned>d__201)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFlipSummoned>d__201&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnFlipSummoned(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnFlipSummoning>d__198))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFlipSummoning>d__198)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFlipSummoning>d__198&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnFlipSummoning(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnHandResult>d__193))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHandResult>d__193)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHandResult>d__193&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnHandResult(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnHint>d__108))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHint>d__108)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHint>d__108&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnHint(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnLpUpdate>d__132))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnLpUpdate>d__132)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnLpUpdate>d__132&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnLpUpdate(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnMissedEffect>d__91))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnMissedEffect>d__91)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnMissedEffect>d__91&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnMissedEffect(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnMove>d__133))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnMove>d__133)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnMove>d__133&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task OnMove(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnNewPhase>d__127))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewPhase>d__127)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewPhase>d__127&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnNewPhase(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnNewTurn>d__126))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewTurn>d__126)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewTurn>d__126&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnNewTurn(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnPacket>d__72))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<DoParse>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnPacket>d__72), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnPacket>d__72)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnPacket>d__72&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnPacket(GameMessage msg, BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnPause() { }

	[AsyncStateMachine(typeof(<OnPayLpCost>d__129))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnPayLpCost>d__129)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnPayLpCost>d__129&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnPayLpCost(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnPlayerHint>d__78))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnPlayerHint>d__78)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnPlayerHint>d__78&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnPlayerHint(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnPosChange>d__138))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnPosChange>d__138)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnPosChange>d__138&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnPosChange(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnRandomSelected>d__74))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRandomSelected>d__74)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRandomSelected>d__74&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnRandomSelected(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnRecover>d__131))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRecover>d__131)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRecover>d__131&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnRecover(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnReloadField>d__76))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnReloadField>d__76)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnReloadField>d__76&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnReloadField(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnRemoveCounter>d__90))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRemoveCounter>d__90)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRemoveCounter>d__90&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnRemoveCounter(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnReverseDeck>d__75))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnReverseDeck>d__75)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnReverseDeck>d__75&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task OnReverseDeck(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnRockPaperScissors>d__192))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRockPaperScissors>d__192)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRockPaperScissors>d__192&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnRockPaperScissors(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectBattleCmd>d__147))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectBattleCmd>d__147)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectBattleCmd>d__147&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectBattleCmd(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectCard>d__149))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectCard>d__149)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectCard>d__149&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectCard(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectCard>d__164))]
	[CalledBy(Type = typeof(<OnSelectCard>d__149), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSelectTribute>d__151), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSelectUnselectCard>d__150), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectCard>d__164)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectCard>d__164&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectCard(BinaryReader packet, byte mode) { }

	[AsyncStateMachine(typeof(<OnSelectChain>d__166))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectChain>d__166)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectChain>d__166&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectChain(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectCounter>d__169))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectCounter>d__169)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectCounter>d__169&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectCounter(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectDisfield>d__175))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectDisfield>d__175)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectDisfield>d__175&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectDisfield(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectEffectYn>d__171))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectEffectYn>d__171)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectEffectYn>d__171&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectEffectYn(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectIdleCmd>d__172))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectIdleCmd>d__172)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectIdleCmd>d__172&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectIdleCmd(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectOption>d__173))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectOption>d__173)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectOption>d__173&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnSelectOption(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectPlace>d__174))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectPlace>d__174)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectPlace>d__174&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectPlace(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectPlace>d__176))]
	[CalledBy(Type = typeof(<OnSelectDisfield>d__175), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSelectPlace>d__174), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectPlace>d__176)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectPlace>d__176&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectPlace(BinaryReader packet, bool isDisfield) { }

	[AsyncStateMachine(typeof(<OnSelectPosition>d__181))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectPosition>d__181)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectPosition>d__181&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnSelectPosition(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectSum>d__182))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectSum>d__182)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectSum>d__182&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectSum(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectTribute>d__151))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectTribute>d__151)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectTribute>d__151&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectTribute(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectUnselectCard>d__150))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectUnselectCard>d__150)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectUnselectCard>d__150&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSelectUnselectCard(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSelectYesNo>d__184))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectYesNo>d__184)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSelectYesNo>d__184&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnSelectYesNo(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSet>d__101))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSet>d__101)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSet>d__101&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSet(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnShuffleDeck>d__115))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffleDeck>d__115)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffleDeck>d__115&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnShuffleDeck(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnShuffleExtra>d__117))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffleExtra>d__117)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffleExtra>d__117&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnShuffleExtra(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnShuffleHand>d__116))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffleHand>d__116)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffleHand>d__116&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnShuffleHand(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnShuffleSetCard>d__118))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffleSetCard>d__118)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffleSetCard>d__118&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnShuffleSetCard(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSpSummoned>d__204))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoned>d__204)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoned>d__204&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnSpSummoned(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSpSummoning>d__203))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoning>d__203)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoning>d__203&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSpSummoning(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnStart>d__110))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnStart>d__110)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnStart>d__110&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnStart(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSummoned>d__202))]
	[CalledBy(Type = typeof(<OnFlipSummoned>d__201), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSummoned>d__200), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSummoned>d__202)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSummoned>d__202&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnSummoned(BinaryReader packet, bool flip) { }

	[AsyncStateMachine(typeof(<OnSummoned>d__200))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSummoned>d__200)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSummoned>d__200&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSummoned(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSummoning>d__197))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSummoning>d__197)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSummoning>d__197&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSummoning(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSummoning>d__199))]
	[CalledBy(Type = typeof(<OnFlipSummoning>d__198), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSummoning>d__197), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSummoning>d__199)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSummoning>d__199&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSummoning(BinaryReader packet, bool flip) { }

	[AsyncStateMachine(typeof(<OnSwap>d__134))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSwap>d__134)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSwap>d__134&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSwap(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnSwapGraveDeck>d__79))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSwapGraveDeck>d__79)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSwapGraveDeck>d__79&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnSwapGraveDeck(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnTagSwap>d__125))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTagSwap>d__125)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTagSwap>d__125&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnTagSwap(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnTossCoin>d__93))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossCoin>d__93)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossCoin>d__93&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnTossCoin(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnTossDice>d__95))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossDice>d__95)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossDice>d__95&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnTossDice(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnUpdateCard>d__144))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUpdateCard>d__144)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUpdateCard>d__144&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnUpdateCard(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnUpdateData>d__145))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUpdateData>d__145)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUpdateData>d__145&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnUpdateData(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnWaiting>d__106))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnWaiting>d__106)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnWaiting>d__106&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnWaiting(BinaryReader packet) { }

	[AsyncStateMachine(typeof(<OnWin>d__113))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnWin>d__113)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnWin>d__113&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnWin(BinaryReader packet) { }

	[CallerCount(Count = 45)]
	[Calls(Type = typeof(Duel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(ClientCard))]
	[Calls(Type = typeof(ClientCard), Member = "SetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(ClientCard)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ClientCard), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public ClientCard ParseCardInfo(BinaryReader packet, int id = -1, bool readPosition = true, bool reverseId = false, bool clearOnZero = true, bool noOverlay = false) { }

	[CalledBy(Type = typeof(<OnChaining>d__140), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnMove>d__133), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldSlot), Member = "get_ZoneScale", ReturnType = typeof(float))]
	[Calls(Type = typeof(EffectsManager), Member = "AddEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour), typeof(float), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sound), Member = "PlaySound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoundTypes), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void PlayActivateFX(ClientCard card) { }

	[CalledBy(Type = typeof(<>c__DisplayClass164_0), Member = "<OnSelectCard>g__finishClick|0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Helper), Member = "set_Pointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void PostInternalOnSelectCard(List<ClientCard> cards, List<ClientCard> selected, bool cancelable, int count) { }

	[CalledBy(Type = typeof(<>c__DisplayClass185_0), Member = "<OnAnnounceAttrib>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnAnnounceAttrib>d__185), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void PostSelectAttrib(List<CardAttribute> attributes, int count) { }

	[CalledBy(Type = typeof(<>c__DisplayClass166_0), Member = "<OnSelectChain>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass166_1), Member = "<OnSelectChain>b__5", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
	[Calls(Type = typeof(OptionBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(string), typeof(Template)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetFieldZoneName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocation)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GeneralSelection), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Int32>), typeof(string), typeof(bool), typeof(Action), typeof(Action), typeof(int), typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Int32, System.Int32>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.ValueTuple`2<System.Int32, System.Int32>>)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Int32>))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(<>c__DisplayClass168_0), Member = "<PostSelectChain>g__finalResponse|2", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	private void PostSelectChain(Dictionary<ClientCard, List`1<ValueTuple`2<Int32, Int32>>> cards, bool isOnlyOneCard, bool forced, ClientCard selection = null, bool isAccessible = false) { }

	[CalledBy(Type = typeof(<>c__DisplayClass169_1), Member = "<OnSelectCounter>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EffectsManager), Member = "RemoveEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	private void PostSelectCounter(IList<Int32> used, IList<ClientCard> cards) { }

	[CalledBy(Type = typeof(<>c__DisplayClass176_0), Member = "<OnSelectPlace>g__answer|3", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "set_HintText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void PostSelectPlace(Byte[] player, Int32[] filter, Int32[] selected, CardLocation[] location, byte count) { }

	[CalledBy(Type = typeof(<>c__DisplayClass190_0), Member = "<OnAnnounceRace>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnAnnounceRace>d__190), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void PostSelectRace(List<CardRace> races, int count) { }

	[CalledBy(Type = typeof(<>c__DisplayClass182_0), Member = "<OnSelectSum>b__3", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Packet), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CtosMessage)}, ReturnType = typeof(BinaryWriter))]
	[Calls(Type = typeof(Network), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void PostSelectSum(IList<ClientCard> mandatoryCards, IList<ClientCard> selected) { }

	[CalledBy(Type = "Manager.Network+<HandlePacket>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnChangeSide>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnWaitingSide>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<ParseLocalStoc>d__45", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	public static void ReceiveTimeLimit(byte seconds) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<PrepareDuel>d__77", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<OnGameMessage>d__64", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterPacket(Byte[] pkt) { }

	[CalledBy(Type = typeof(DuelManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 82)]
	[CallsUnknownMethods(Count = 1)]
	private void RegisterPackets() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ChainMethod(ChainMethod value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DuelOverState(DuelEndState value) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ApplyGameplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public static void set_GameSpeed(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_HasReconnected(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsReplay(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsWaitingForResponse(bool value) { }

	[CalledBy(Type = typeof(Network), Member = "OnPause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DuelZone), Member = "DefineFinishIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinishIcon)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_PausedBy(sbyte value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ReadingSteinerStep(ulong value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Replay(ClientReplay value) { }

	[CalledBy(Type = "Manager.Network+<Send>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnHint>d__108), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CardOptionList), Member = "get_ObjectInstance", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_SelectHint(int value) { }

	[CalledBy(Type = typeof(<OnTagSwap>d__125), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LifePoints), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SwapTeamPlayer(sbyte team) { }

	[CalledBy(Type = typeof(<OnWaiting>d__106), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(LifePoints), Member = "SetState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateWaiting() { }

}

