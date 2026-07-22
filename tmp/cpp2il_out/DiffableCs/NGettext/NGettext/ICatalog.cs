namespace NGettext;

public interface ICatalog
{

	public string GetParticularPluralString(string context, string text, string pluralText, long n) { }

	public string GetParticularPluralString(string context, string text, string pluralText, long n, Object[] args) { }

	public string GetParticularString(string context, string text) { }

	public string GetParticularString(string context, string text, Object[] args) { }

	public string GetPluralString(string text, string pluralText, long n) { }

	public string GetPluralString(string text, string pluralText, long n, Object[] args) { }

	public string GetString(string text) { }

	public string GetString(string text, Object[] args) { }

}

