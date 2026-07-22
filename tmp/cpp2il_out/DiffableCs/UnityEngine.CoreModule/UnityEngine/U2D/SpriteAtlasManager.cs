namespace UnityEngine.U2D;

[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType::Dot (0))]
public class SpriteAtlasManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<String, Action`1<SpriteAtlas>> atlasRequested; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<SpriteAtlas> atlasRegistered; //Field offset: 0x8

	public static event Action<SpriteAtlas> atlasRegistered
	{
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackSprite", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Tilemaps.TilemapRenderer", Member = "RegisterSpriteAtlasRegistered", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 202
		[CalledBy(Type = "UnityEngine.Tilemaps.TilemapRenderer", Member = "UnregisterSpriteAtlasRegistered", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 202
	}

	public static event Action<String, Action`1<SpriteAtlas>> atlasRequested
	{
		[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 193
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 193
	}

	[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackSprite", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.TilemapRenderer", Member = "RegisterSpriteAtlasRegistered", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_atlasRequested(Action<String, Action`1<SpriteAtlas>> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal static void Register(SpriteAtlas spriteAtlas) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Register_Injected(IntPtr spriteAtlas) { }

	[CalledBy(Type = "UnityEngine.Tilemaps.TilemapRenderer", Member = "UnregisterSpriteAtlasRegistered", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_atlasRequested(Action<String, Action`1<SpriteAtlas>> value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	private static bool RequestAtlas(string tag) { }

}

