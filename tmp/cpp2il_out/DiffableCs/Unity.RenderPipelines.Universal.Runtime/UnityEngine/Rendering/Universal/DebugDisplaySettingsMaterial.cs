namespace UnityEngine.Rendering.Universal;

public class DebugDisplaySettingsMaterial : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	internal enum AlbedoDebugValidationPreset
	{
		DefaultLuminance = 0,
		BlackAcrylicPaint = 1,
		DarkSoil = 2,
		WornAsphalt = 3,
		DryClaySoil = 4,
		GreenGrass = 5,
		OldConcrete = 6,
		RedClayTile = 7,
		DrySand = 8,
		NewConcrete = 9,
		WhiteAcrylicPaint = 10,
		FreshSnow = 11,
		BlueSky = 12,
		Foliage = 13,
		Custom = 14,
	}

	private struct AlbedoDebugValidationPresetData
	{
		public string name; //Field offset: 0x0
		public Color color; //Field offset: 0x8
		public float minLuminance; //Field offset: 0x18
		public float maxLuminance; //Field offset: 0x1C

	}

	[DisplayInfo(name = "Material", order = 2)]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsMaterial>
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public DebugDisplaySettingsMaterial data; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass0_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <.ctor>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <.ctor>b__1() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <.ctor>b__2() { }

		}


		[CalledBy(Type = typeof(DebugDisplaySettingsMaterial), Member = "UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel", ReturnType = typeof(IDebugDisplaySettingsPanelDisposable))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ColorField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateAlbedoPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMaterialValidationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateFilterRenderingLayerMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(RenderingLayerField))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMaterialOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = "AddWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RuntimeDebugShadersMessageBox), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugDisplaySettingsPanel`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 37)]
		[CallsUnknownMethods(Count = 41)]
		public SettingsPanel(DebugDisplaySettingsMaterial data) { }

	}

	private static class Strings
	{
		public const string AlbedoSettingsContainerName = "Albedo Settings"; //Field offset: 0x0
		public const string MetallicSettingsContainerName = "Metallic Settings"; //Field offset: 0x0
		public const string RenderingLayerMasksSettingsContainerName = "Rendering Layer Masks Settings"; //Field offset: 0x0
		public static readonly NameAndTooltip MaterialOverride; //Field offset: 0x0
		public static readonly NameAndTooltip VertexAttribute; //Field offset: 0x10
		public static readonly NameAndTooltip MaterialValidationMode; //Field offset: 0x20
		public static readonly NameAndTooltip RenderingLayersSelectedLight; //Field offset: 0x30
		public static readonly NameAndTooltip SelectedLightShadowLayerMask; //Field offset: 0x40
		public static readonly NameAndTooltip FilterRenderingLayerMask; //Field offset: 0x50
		public static readonly NameAndTooltip ValidationPreset; //Field offset: 0x60
		public static readonly NameAndTooltip AlbedoCustomColor; //Field offset: 0x70
		public static readonly NameAndTooltip AlbedoMinLuminance; //Field offset: 0x80
		public static readonly NameAndTooltip AlbedoMaxLuminance; //Field offset: 0x90
		public static readonly NameAndTooltip AlbedoHueTolerance; //Field offset: 0xA0
		public static readonly NameAndTooltip AlbedoSaturationTolerance; //Field offset: 0xB0
		public static readonly NameAndTooltip MetallicMinValue; //Field offset: 0xC0
		public static readonly NameAndTooltip MetallicMaxValue; //Field offset: 0xD0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 42)]
		private static Strings() { }

	}

	public static class WidgetFactory
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action<Field`1<Int32>, Int32> <>9__2_4; //Field offset: 0x8
			public static Action<Field`1<Int32>, Int32> <>9__6_4; //Field offset: 0x10

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
			[Calls(Type = typeof(DebugManager), Member = "ReDrawOnScreenDebug", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateAlbedoPreset>b__6_4(Field<Int32> _, int _) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
			[Calls(Type = typeof(DebugManager), Member = "ReDrawOnScreenDebug", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMaterialValidationMode>b__2_4(Field<Int32> _, int _) { }

		}

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
			internal int <CreateMaterialOverride>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMaterialOverride>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateMaterialOverride>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMaterialOverride>b__3(int value) { }

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
			internal int <CreateVertexAttribute>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateVertexAttribute>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateVertexAttribute>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateVertexAttribute>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass10_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreateAlbedoHueTolerance>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateAlbedoHueTolerance>b__1(float value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <CreateAlbedoHueTolerance>b__2() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass11_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass11_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreateAlbedoSaturationTolerance>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateAlbedoSaturationTolerance>b__1(float value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <CreateAlbedoSaturationTolerance>b__2() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass12_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreateMetallicMinValue>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMetallicMinValue>b__1(float value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass13_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreateMetallicMaxValue>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMetallicMaxValue>b__1(float value) { }

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
			internal int <CreateMaterialValidationMode>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMaterialValidationMode>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateMaterialValidationMode>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMaterialValidationMode>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass3_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <CreateRenderingLayersSelectedLight>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateRenderingLayersSelectedLight>b__1(bool value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass4_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <CreateSelectedLightShadowLayerMask>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateSelectedLightShadowLayerMask>b__1(bool value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <CreateSelectedLightShadowLayerMask>b__2() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass5_0() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			internal RenderingLayerMask <CreateFilterRenderingLayerMasks>b__0() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateFilterRenderingLayerMasks>b__1(RenderingLayerMask value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			internal Vector4 <CreateFilterRenderingLayerMasks>b__2(int index) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			internal void <CreateFilterRenderingLayerMasks>b__3(Vector4 value, int index) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <CreateFilterRenderingLayerMasks>b__4() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass6_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateAlbedoPreset>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			internal void <CreateAlbedoPreset>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateAlbedoPreset>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			internal void <CreateAlbedoPreset>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass7_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal Color <CreateAlbedoCustomColor>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateAlbedoCustomColor>b__1(Color value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <CreateAlbedoCustomColor>b__2() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass8_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreateAlbedoMinLuminance>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateAlbedoMinLuminance>b__1(float value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass9_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreateAlbedoMaxLuminance>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateAlbedoMaxLuminance>b__1(float value) { }

		}


		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ColorField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		internal static Widget CreateAlbedoCustomColor(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		internal static Widget CreateAlbedoHueTolerance(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreateAlbedoMaxLuminance(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreateAlbedoMinLuminance(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsMaterial)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		internal static Widget CreateAlbedoPreset(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		internal static Widget CreateAlbedoSaturationTolerance(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsMaterial)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RenderingLayerField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Action`2<UnityEngine.Vector4, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		internal static RenderingLayerField CreateFilterRenderingLayerMasks(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsMaterial)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreateMaterialOverride(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsMaterial)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		internal static Widget CreateMaterialValidationMode(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreateMetallicMaxValue(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreateMetallicMinValue(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreateRenderingLayersSelectedLight(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		internal static Widget CreateSelectedLightShadowLayerMask(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsMaterial)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreateVertexAttribute(SettingsPanel panel) { }

	}

	private AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData; //Field offset: 0x10
	private AlbedoDebugValidationPreset m_AlbedoValidationPreset; //Field offset: 0x18
	[CompilerGenerated]
	private float <albedoMinLuminance>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private float <albedoMaxLuminance>k__BackingField; //Field offset: 0x20
	private float m_AlbedoHueTolerance; //Field offset: 0x24
	private float m_AlbedoSaturationTolerance; //Field offset: 0x28
	[CompilerGenerated]
	private Color <albedoCompareColor>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <metallicMinValue>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <metallicMaxValue>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <renderingLayersSelectedLight>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <selectedLightShadowLayerMask>k__BackingField; //Field offset: 0x45
	[CompilerGenerated]
	private uint <renderingLayerMask>k__BackingField; //Field offset: 0x48
	public Vector4[] debugRenderingLayersColors; //Field offset: 0x50
	[CompilerGenerated]
	private DebugMaterialValidationMode <materialValidationMode>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private DebugMaterialMode <materialDebugMode>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private DebugVertexAttributeMode <vertexAttributeDebugMode>k__BackingField; //Field offset: 0x60

	public Color albedoCompareColor
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float albedoHueTolerance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float albedoMaxLuminance
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float albedoMinLuminance
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float albedoSaturationTolerance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public AlbedoDebugValidationPreset albedoValidationPreset
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 96
	}

	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public override bool IsLightingActive
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 24
	}

	public override bool IsPostProcessingAllowed
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 24
	}

	public DebugMaterialMode materialDebugMode
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DebugMaterialValidationMode materialValidationMode
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float metallicMaxValue
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float metallicMinValue
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public uint renderingLayerMask
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool renderingLayersSelectedLight
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool selectedLightShadowLayerMask
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DebugVertexAttributeMode vertexAttributeDebugMode
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(UniversalRenderPipelineDebugDisplaySettings), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 34)]
	public DebugDisplaySettingsMaterial() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Color get_albedoCompareColor() { }

	[CallerCount(Count = 0)]
	public float get_albedoHueTolerance() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_albedoMaxLuminance() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_albedoMinLuminance() { }

	[CallerCount(Count = 0)]
	public float get_albedoSaturationTolerance() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public AlbedoDebugValidationPreset get_albedoValidationPreset() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_AreAnySettingsActive() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsLightingActive() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_IsPostProcessingAllowed() { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugMaterialMode get_materialDebugMode() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugMaterialValidationMode get_materialValidationMode() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_metallicMaxValue() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_metallicMinValue() { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public uint get_renderingLayerMask() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_renderingLayersSelectedLight() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_selectedLightShadowLayerMask() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugVertexAttributeMode get_vertexAttributeDebugMode() { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public uint GetDebugLightLayersMask() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_albedoCompareColor(Color value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_albedoHueTolerance(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_albedoMaxLuminance(float value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_albedoMinLuminance(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_albedoSaturationTolerance(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void set_albedoValidationPreset(AlbedoDebugValidationPreset value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_materialDebugMode(DebugMaterialMode value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_materialValidationMode(DebugMaterialValidationMode value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_metallicMaxValue(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_metallicMinValue(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_renderingLayerMask(uint value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_renderingLayersSelectedLight(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_selectedLightShadowLayerMask(bool value) { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_vertexAttributeDebugMode(DebugVertexAttributeMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsMaterial)}, ReturnType = typeof(void))]
	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

}

