namespace UnityEngine.UIElements;

public class PanelTextSettings : TextSettings
{
	private static PanelTextSettings s_DefaultPanelTextSettings; //Field offset: 0x0

	internal static PanelTextSettings defaultPanelTextSettings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelTextSettings), Member = "InitializeDefaultPanelTextSettingsIfNull", ReturnType = typeof(void))]
		internal get { } //Length: 61
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextSettings), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public PanelTextSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelTextSettings), Member = "InitializeDefaultPanelTextSettingsIfNull", ReturnType = typeof(void))]
	internal static PanelTextSettings get_defaultPanelTextSettings() { }

	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelTextSettings), Member = "get_defaultPanelTextSettings", ReturnType = typeof(PanelTextSettings))]
	[CalledBy(Type = typeof(TextUtilities), Member = "GetTextSettingsFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(TextSettings))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "PrepareTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal static void InitializeDefaultPanelTextSettingsIfNull() { }

}

