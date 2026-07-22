namespace UnityEngine.TerrainUtils;

public class TerrainMap
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public int groupID; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsInvalidInstructions]
		[ContainsUnimplementedInstructions]
		internal bool <CreateFromPlacement>b__0(Terrain x) { }

	}

	private Vector3 m_patchSize; //Field offset: 0x10
	private TerrainMapStatusCode m_errorCode; //Field offset: 0x1C
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; //Field offset: 0x20

	public Dictionary<TerrainTileCoord, Terrain> terrainTiles
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TerrainMap() { }

	[CalledBy(Type = typeof(TerrainMap), Member = "TryToAddTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData", ReturnType = typeof(TerrainData))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TerrainTileCoord), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	[CalledBy(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData", ReturnType = typeof(TerrainData))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = true) { }

	[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Terrain), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData", ReturnType = typeof(TerrainData))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TerrainMap), Member = "TryToAddTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TerrainMap), Member = "Validate", ReturnType = typeof(TerrainMapStatusCode))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = true) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	[CalledBy(Type = typeof(TerrainMap), Member = "TryToAddTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TerrainMap), Member = "ValidateTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TerrainUtility), Member = "AutoConnect", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.TerrainUtils.TerrainTileCoord, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TerrainTileCoord), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public Terrain GetTerrain(int tileX, int tileZ) { }

	[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TerrainMap), Member = "GetTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Terrain))]
	[Calls(Type = typeof(TerrainMap), Member = "AddTerrainInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Terrain)}, ReturnType = typeof(void))]
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	[CalledBy(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TerrainMap), Member = "ValidateTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private TerrainMapStatusCode Validate() { }

	[CalledBy(Type = typeof(TerrainMap), Member = "Validate", ReturnType = typeof(TerrainMapStatusCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TerrainMap), Member = "GetTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Terrain))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData", ReturnType = typeof(TerrainData))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	private void ValidateTerrain(int tileX, int tileZ) { }

}

