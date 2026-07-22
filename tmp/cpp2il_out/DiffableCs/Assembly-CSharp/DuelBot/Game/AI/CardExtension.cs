namespace DuelBot.Game.AI;

[Extension]
public static class CardExtension
{

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetFloodgate_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Anima_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.SalamangreatExecutor+<>c", Member = "<HeatLeo_summon>b__27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "TwinTwistersEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsFloodgate(BotClientCard card) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsFusionSpell(BotClientCard card) { }

	[CalledBy(Type = "DuelBot.Game.AI.CardContainer+<>c__DisplayClass14_0", Member = "<GetDangerousMonster>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Kunquery_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "GalaxyEyesFullArmorPhotonDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "DarkHole_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsMonsterDangerous(BotClientCard card) { }

	[CalledBy(Type = typeof(TrickstarExecutor), Member = "White_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZexalWeaponsExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(YosenjuExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "OnSelectAttackTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(System.Collections.Generic.IList`1<DuelBot.Game.BotClientCard>)}, ReturnType = typeof(BattlePhaseAction))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Unicorn_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ZoodiacExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ToadallyAwesomeExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RainbowExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OrcustExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornShaddoldinosour), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightswornExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Level8Executor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsMonsterHasPreventActivationEffectInBattle(BotClientCard card) { }

	[CalledBy(Type = "DuelBot.Game.AI.CardContainer+<>c__DisplayClass13_0", Member = "<GetInvincibleMonster>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultExecutor), Member = "OnPreBattleBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BotClientCard), typeof(BotClientCard)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BlueEyesExecutor), Member = "GalaxyEyesFullArmorPhotonDragonEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SkyStrikerExecutor), Member = "HerculesBaseEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsMonsterInvincible(BotClientCard card) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsMonsterShouldBeDisabledBeforeItUseEffect(BotClientCard card) { }

	[CalledBy(Type = typeof(DefaultExecutor), Member = "DefaultDimensionalBarrier", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsOneForXyz(BotClientCard card) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "GetProblematicEnemyCard_Alter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(BotClientCard))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Kunquery_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Silquitous_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Anima_ss", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Phoneix_eff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TrickstarExecutor), Member = "Unicorn_eff", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsShouldNotBeMonsterTarget(BotClientCard card) { }

	[CalledBy(Type = typeof(AltergeistExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PureWindsExecutor), Member = "ForbiddenChaliceeff", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Impermanence_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SalamangreatExecutor), Member = "Called_activate", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsShouldNotBeSpellTrapTarget(BotClientCard card) { }

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(BotClientCard), Member = "IsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsShouldNotBeTarget(BotClientCard card) { }

}

