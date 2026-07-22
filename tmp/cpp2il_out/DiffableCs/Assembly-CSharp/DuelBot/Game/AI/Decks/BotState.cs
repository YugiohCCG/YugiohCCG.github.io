namespace DuelBot.Game.AI.Decks;

public enum BotState
{
	None = 0,
	SelectBattleCmd = 1,
	SelectCard = 2,
	SelectUnselectCard = 3,
	SelectChain = 4,
	SelectCounter = 5,
	SelectDisfield = 6,
	SelectEffectYn = 7,
	SelectIdleCmd = 8,
	SelectOption = 9,
	SelectPlace = 10,
	SelectPosition = 11,
	SelectSum = 12,
	SelectTribute = 13,
	AnnounceAttribute = 14,
	AnnounceCard = 15,
	AnnounceNumber = 16,
	AnnounceRace = 17,
	AnnounceCardFilter = 18,
	WaitingForDeck = 19,
	SelectYesNo = 20,
	RockPaperScissors = 21,
	SortCard = 22,
}

