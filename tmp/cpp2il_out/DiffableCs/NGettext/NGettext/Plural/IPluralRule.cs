namespace NGettext.Plural;

public interface IPluralRule
{

	public int NumPlurals
	{
		 get { } //Length: 0
	}

	public int Evaluate(long number) { }

	public int get_NumPlurals() { }

}

