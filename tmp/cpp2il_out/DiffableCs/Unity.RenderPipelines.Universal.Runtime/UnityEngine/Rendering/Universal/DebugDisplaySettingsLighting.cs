namespace UnityEngine.Rendering.Universal;

public class DebugDisplaySettingsLighting : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Lighting", order = 3)]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsLighting>
	{

		[CalledBy(Type = typeof(DebugDisplaySettingsLighting), Member = "UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel", ReturnType = typeof(IDebugDisplaySettingsPanelDisposable))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DebugDisplaySettingsPanel`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RuntimeDebugShadersMessageBox), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = "AddWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateLightingDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateHDRDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(BitField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(BitField), Member = "set_enumType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		public SettingsPanel(DebugDisplaySettingsLighting data) { }

	}

	public static class Strings
	{
		public static readonly NameAndTooltip LightingDebugMode; //Field offset: 0x0
		public static readonly NameAndTooltip LightingFeatures; //Field offset: 0x10
		public static readonly NameAndTooltip HDRDebugMode; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		private static Strings() { }

	}

	public static class WidgetFactory
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass0_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateLightingDebugMode>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateLightingDebugMode>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateLightingDebugMode>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateLightingDebugMode>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass1_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal Enum <CreateLightingFeatures>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			internal void <CreateLightingFeatures>b__1(Enum value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass2_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateHDRDebugMode>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateHDRDebugMode>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateHDRDebugMode>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateHDRDebugMode>b__3(int value) { }

		}


		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsLighting)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreateHDRDebugMode(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsLighting)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreateLightingDebugMode(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BitField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(BitField), Member = "set_enumType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreateLightingFeatures(SettingsPanel panel) { }

	}

	[CompilerGenerated]
	private DebugLightingMode <lightingDebugMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private DebugLightingFeatureFlags <lightingFeatureFlags>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private HDRDebugMode <hdrDebugMode>k__BackingField; //Field offset: 0x18

	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public HDRDebugMode hdrDebugMode
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool IsLightingActive
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsPostProcessingAllowed
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	public DebugLightingMode lightingDebugMode
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DebugLightingFeatureFlags lightingFeatureFlags
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugDisplaySettingsLighting() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_AreAnySettingsActive() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public HDRDebugMode get_hdrDebugMode() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_IsLightingActive() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsPostProcessingAllowed() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugLightingMode get_lightingDebugMode() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugLightingFeatureFlags get_lightingFeatureFlags() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_hdrDebugMode(HDRDebugMode value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_lightingDebugMode(DebugLightingMode value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_lightingFeatureFlags(DebugLightingFeatureFlags value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsLighting)}, ReturnType = typeof(void))]
	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

}

