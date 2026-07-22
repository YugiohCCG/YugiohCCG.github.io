namespace Card;

public class Booster
{
	private static readonly String[] BATTLE_PACKS; //Field offset: 0x0
	private const string BOOST_DRAFT_SUFFIX = "EN"; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	private static Booster() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Booster() { }

}

