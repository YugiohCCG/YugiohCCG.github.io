namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
public abstract class TileBase : ScriptableObject
{

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected TileBase() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", "Unity.Collections.NativeArray`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[RequiredByNativeCode]
	public override void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) { }

}

