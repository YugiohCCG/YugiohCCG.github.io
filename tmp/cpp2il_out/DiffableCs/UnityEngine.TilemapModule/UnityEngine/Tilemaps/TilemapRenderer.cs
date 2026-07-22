namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[RequireComponent(typeof(Tilemap))]
public sealed class TilemapRenderer : Renderer
{

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void OnSpriteAtlasRegistered_Injected(IntPtr _unity_self, IntPtr atlas) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteAtlasManager), Member = "add_atlasRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.U2D.SpriteAtlas>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal void RegisterSpriteAtlasRegistered() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteAtlasManager), Member = "remove_atlasRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.U2D.SpriteAtlas>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal void UnregisterSpriteAtlasRegistered() { }

}

