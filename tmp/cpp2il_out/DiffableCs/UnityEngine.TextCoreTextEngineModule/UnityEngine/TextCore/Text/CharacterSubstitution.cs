namespace UnityEngine.TextCore.Text;

internal struct CharacterSubstitution
{
	public int index; //Field offset: 0x0
	public uint unicode; //Field offset: 0x4

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public CharacterSubstitution(int index, uint unicode) { }

}

