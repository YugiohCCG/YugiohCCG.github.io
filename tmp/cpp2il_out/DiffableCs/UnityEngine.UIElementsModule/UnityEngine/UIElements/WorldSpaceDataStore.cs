namespace UnityEngine.UIElements;

internal static class WorldSpaceDataStore
{
	private static Dictionary<UInt32, WorldSpaceData> m_WorldSpaceData; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static WorldSpaceDataStore() { }

	[CalledBy(Type = typeof(VisualElement), Member = "get_localBounds3D", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	public static WorldSpaceData GetWorldSpaceData(VisualElement ve) { }

	[CalledBy(Type = typeof(VisualElement), Member = "UpdateLocalBoundsAndPickingBounds3D", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.UIElements.WorldSpaceData>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(WorldSpaceData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetWorldSpaceData(VisualElement ve, WorldSpaceData data) { }

}

