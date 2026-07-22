namespace TMPro;

public static class TMPro_EventManager
{
	public static readonly FastAction<Object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; //Field offset: 0x0
	public static readonly FastAction<Boolean, Material> MATERIAL_PROPERTY_EVENT; //Field offset: 0x8
	public static readonly FastAction<Boolean, Object> FONT_PROPERTY_EVENT; //Field offset: 0x10
	public static readonly FastAction<Boolean, Object> SPRITE_ASSET_PROPERTY_EVENT; //Field offset: 0x18
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_PROPERTY_EVENT; //Field offset: 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; //Field offset: 0x28
	public static readonly FastAction<Boolean> TEXT_STYLE_PROPERTY_EVENT; //Field offset: 0x30
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; //Field offset: 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; //Field offset: 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; //Field offset: 0x48
	public static readonly FastAction<Boolean, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; //Field offset: 0x50
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FastAction`3), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FastAction`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FastAction), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static TMPro_EventManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMPro.FastAction`1<System.Object>), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMPro.FastAction`2<System.Object, System.Object>), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction`3), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B", "C"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "RebuildFontAssetCache", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction), Member = "Call", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_RESOURCES_LOADED() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMPro.FastAction`1<System.Object>), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_TEXT_CHANGED(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction`1), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastAction), Member = "Call", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ON_TMP_SETTINGS_CHANGED() { }

}

