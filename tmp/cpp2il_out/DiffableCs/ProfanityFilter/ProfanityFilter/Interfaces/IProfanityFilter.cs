namespace ProfanityFilter.Interfaces;

public interface IProfanityFilter
{

	public IAllowList AllowList
	{
		 get { } //Length: 0
	}

	public int Count
	{
		 get { } //Length: 0
	}

	public void AddProfanity(string profanity) { }

	public void AddProfanity(String[] profanityList) { }

	public void AddProfanity(List<String> profanityList) { }

	public string CensorString(string sentence) { }

	public string CensorString(string sentence, char censorCharacter) { }

	public string CensorString(string sentence, char censorCharacter, bool ignoreNumbers) { }

	public void Clear() { }

	public bool ContainsProfanity(string term) { }

	public ReadOnlyCollection<String> DetectAllProfanities(string sentence) { }

	public ReadOnlyCollection<String> DetectAllProfanities(string sentence, bool removePartialMatches) { }

	public IAllowList get_AllowList() { }

	public int get_Count() { }

	public Nullable<ValueTuple`3<Int32, Int32, String>> GetCompleteWord(string toCheck, string profanity) { }

	public bool IsProfanity(string word) { }

	public bool RemoveProfanity(List<String> profanities) { }

	public bool RemoveProfanity(String[] profanities) { }

	public bool RemoveProfanity(string profanity) { }

}

