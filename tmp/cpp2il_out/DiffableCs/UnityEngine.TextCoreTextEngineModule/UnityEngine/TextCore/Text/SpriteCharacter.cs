namespace UnityEngine.TextCore.Text;

public class SpriteCharacter : TextElement
{
	[SerializeField]
	private string m_Name; //Field offset: 0x30

	public string name
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SpriteCharacter() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public string get_name() { }

}

