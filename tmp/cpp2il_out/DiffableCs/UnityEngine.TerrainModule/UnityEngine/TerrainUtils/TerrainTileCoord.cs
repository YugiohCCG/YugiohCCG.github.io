namespace UnityEngine.TerrainUtils;

[IsReadOnly]
public struct TerrainTileCoord
{
	public readonly int tileX; //Field offset: 0x0
	public readonly int tileZ; //Field offset: 0x4

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public TerrainTileCoord(int tileX, int tileZ) { }

}

