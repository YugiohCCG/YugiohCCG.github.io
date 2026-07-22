namespace Spine.Unity;

[CreateAssetMenu(fileName = "New Spine SpriteAtlas Asset", menuName = "Spine/Spine SpriteAtlas Asset")]
public class SpineSpriteAtlasAsset : AtlasAssetBase
{
	internal class SavedRegionInfo
	{
		public float x; //Field offset: 0x10
		public float y; //Field offset: 0x14
		public float width; //Field offset: 0x18
		public float height; //Field offset: 0x1C
		public SpritePackingRotation packingRotation; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SavedRegionInfo() { }

	}

	public SpriteAtlas spriteAtlasFile; //Field offset: 0x18
	public Material[] materials; //Field offset: 0x20
	protected Atlas atlas; //Field offset: 0x28
	public bool updateRegionsInPlayMode; //Field offset: 0x30
	[SerializeField]
	protected SavedRegionInfo[] savedRegions; //Field offset: 0x38

	public virtual bool IsLoaded
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public virtual int MaterialCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 18
	}

	public virtual IEnumerable<Material> Materials
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Material PrimaryMaterial
	{
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SpineSpriteAtlasAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteAtlas), Member = "get_spriteCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Sprite[] AccessPackedSprites(SpriteAtlas spriteAtlas) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[CallsUnknownMethods(Count = 2)]
	public static Texture2D AccessPackedTexture(Sprite[] sprites) { }

	[CalledBy(Type = typeof(SpineSpriteAtlasAsset), Member = "LoadAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = typeof(Atlas))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Atlas), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<Spine.AtlasRegion>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	protected void AssignRegionsFromSavedRegions(Sprite[] sprites, Atlas usedAtlas) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static SpineSpriteAtlasAsset CreateRuntimeInstance(SpriteAtlas spriteAtlasFile, Material[] materials, bool initialize) { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool get_IsLoaded() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_MaterialCount() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual IEnumerable<Material> get_Materials() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual Material get_PrimaryMaterial() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SpineSpriteAtlasAsset), Member = "LoadAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = typeof(Atlas))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public virtual Atlas GetAtlas(bool onlyMetaData = false) { }

	[CalledBy(Type = typeof(SpineSpriteAtlasAsset), Member = "GetAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Atlas))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpriteAtlas), Member = "get_spriteCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasPage), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Atlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.AtlasPage>), typeof(System.Collections.Generic.List`1<Spine.AtlasRegion>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpineSpriteAtlasAsset), Member = "AssignRegionsFromSavedRegions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite[]), typeof(Atlas)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private Atlas LoadAtlas(SpriteAtlas spriteAtlas) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private void Reset() { }

}

