namespace UnityEngine.U2D;

[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
public class SpriteAtlas : object
{

	public int spriteCount
	{
		[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "LoadAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = "Spine.Atlas")]
		[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "AccessPackedSprites", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = "UnityEngine.Sprite[]")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SpriteAtlas() { }

	[CalledBy(Type = "UnityEngine.UI.Image", Member = "RebuildImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool CanBindTo(Sprite sprite) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite) { }

	[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "LoadAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = "Spine.Atlas")]
	[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "AccessPackedSprites", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = "UnityEngine.Sprite[]")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_spriteCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_spriteCount_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "GetReplacementSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = "Manager.Helper+<PostLoading>d__113", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "GetCounterImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), "UnityEngine.UI.Image&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "GetSpriteFromAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Enumerator.AssetType"}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public Sprite GetSprite(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetSprite_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public int GetSprites(Sprite[] sprites) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private int GetSpritesScripting(Sprite[] sprites) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetSpritesScripting_Injected(IntPtr _unity_self, Sprite[] sprites) { }

}

