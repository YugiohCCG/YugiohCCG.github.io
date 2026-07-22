namespace ProfanityFilter.Interfaces;

public interface IAllowList
{

	public int Count
	{
		 get { } //Length: 0
	}

	public ReadOnlyCollection<String> ToList
	{
		 get { } //Length: 0
	}

	public void Add(string wordToAllowlist) { }

	public void Clear() { }

	public bool Contains(string wordToCheck) { }

	public int get_Count() { }

	public ReadOnlyCollection<String> get_ToList() { }

	public bool Remove(string wordToRemove) { }

}

