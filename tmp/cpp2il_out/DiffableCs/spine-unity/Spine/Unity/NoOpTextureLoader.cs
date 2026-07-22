namespace Spine.Unity;

public class NoOpTextureLoader : TextureLoader
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NoOpTextureLoader() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Load(AtlasPage page, string path) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Unload(object texture) { }

}

