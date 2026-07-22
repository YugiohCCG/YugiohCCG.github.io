namespace UnityEngine.TerrainUtils;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainUtility
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public bool onlyAutoConnectedTerrains; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass2_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public Terrain t; //Field offset: 0x10
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass2_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		internal bool <CollectTerrains>b__0(Terrain x) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TerrainUtility), Member = "ValidTerrainsExist", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Terrain), Member = "SetNeighbors_Injected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TerrainMap), Member = "GetTerrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Terrain))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	[RequiredByNativeCode]
	public static void AutoConnect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Terrain), Member = "SetNeighbors_Injected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	internal static void ClearConnectivity() { }

	[CalledBy(Type = typeof(TerrainUtility), Member = "AutoConnect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TerrainUtility), Member = "ValidTerrainsExist", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Terrain), Member = "get_allowAutoConnect", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Terrain), Member = "get_groupingID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TerrainMap), Member = "CreateFromPlacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Terrain), typeof(System.Predicate`1<UnityEngine.Terrain>), typeof(bool)}, ReturnType = typeof(TerrainMap))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal static Dictionary<Int32, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true) { }

	[CalledBy(Type = typeof(TerrainUtility), Member = "CollectTerrains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.TerrainUtils.TerrainMap>))]
	[CalledBy(Type = typeof(TerrainUtility), Member = "AutoConnect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal static bool ValidTerrainsExist() { }

}

