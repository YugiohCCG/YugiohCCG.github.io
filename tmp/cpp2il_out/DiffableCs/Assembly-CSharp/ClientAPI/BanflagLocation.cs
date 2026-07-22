namespace ClientAPI;

[Flags]
public enum BanflagLocation
{
	All = 0,
	Main = 1,
	Extra = 2,
	Side = 4,
	MainOrExtra = 3,
	MainOrSide = 5,
	ExtraOrSide = 6,
	MainOrExtraOrSide = 7,
}

