namespace Scenes.Battle;

public class DuelFieldTextureOverride
{
	[SerializeField]
	public string Original; //Field offset: 0x10
	[SerializeField]
	public string Override; //Field offset: 0x18

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DuelFieldTextureOverride() { }

}

