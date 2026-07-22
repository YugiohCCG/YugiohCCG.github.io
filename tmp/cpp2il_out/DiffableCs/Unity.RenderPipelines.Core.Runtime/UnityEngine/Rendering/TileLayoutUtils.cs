namespace UnityEngine.Rendering;

public static class TileLayoutUtils
{

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight) { }

}

