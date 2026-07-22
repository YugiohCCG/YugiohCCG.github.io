namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Grid/Public/Grid.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
[RequireComponent(typeof(Transform))]
public sealed class Tilemap : GridLayout
{
	[RequiredByNativeCode]
	internal struct SyncTile
	{
		internal Vector3Int m_Position; //Field offset: 0x0
		internal TileBase m_Tile; //Field offset: 0x10
		internal TileData m_TileData; //Field offset: 0x18

	}

	public struct SyncTileCallbackSettings
	{
		internal bool hasSyncTileCallback; //Field offset: 0x0
		internal bool hasPositionsChangedCallback; //Field offset: 0x1
		internal bool isBufferSyncTile; //Field offset: 0x2

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Tilemap, SyncTile[]> tilemapTileChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Tilemap, NativeArray`1<Vector3Int>> tilemapPositionsChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Tilemap, NativeArray`1<Vector3Int>> loopEndedForTileAnimation; //Field offset: 0x10
	private bool m_BufferSyncTile; //Field offset: 0x18

	internal bool bufferSyncTile
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Tilemap), Member = "SendLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	private void DoLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Tilemap), Member = "SendTilemapPositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tilemap), Member = "SendTilemapTileChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncTile[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	private void DoSyncTileCallback(SyncTile[] syncTiles) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_bufferSyncTile() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	internal void GetSyncTileCallbackSettings(ref SyncTileCallbackSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Tilemap), Member = "SendLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void HandleLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Tilemap), Member = "SendTilemapPositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3Int>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tilemap), Member = "SendTilemapTileChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncTile[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void HandleSyncTileCallback(SyncTile[] syncTiles) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool HasLoopEndedForTileAnimationCallback() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool HasPositionsChangedCallback() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool HasSyncTileCallback() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "RefreshTileAsset")]
	public void RefreshTile(Vector3Int position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RefreshTile_Injected(IntPtr _unity_self, in Vector3Int position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = True)]
	internal void RefreshTilesNative(Void* positions, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RefreshTilesNative_Injected(IntPtr _unity_self, Void* positions, int count) { }

	[CalledBy(Type = typeof(Tilemap), Member = "HandleLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tilemap), Member = "DoLoopEndedForTileAnimationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SendLoopEndedForTileAnimationCallback(NativeArray<Vector3Int> positions) { }

	[CalledBy(Type = typeof(Tilemap), Member = "HandlePositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tilemap), Member = "DoPositionsChangedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions) { }

	[CalledBy(Type = typeof(Tilemap), Member = "HandleSyncTileCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncTile[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tilemap), Member = "DoSyncTileCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncTile[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SendTilemapTileChangedCallback(SyncTile[] syncTiles) { }

}

