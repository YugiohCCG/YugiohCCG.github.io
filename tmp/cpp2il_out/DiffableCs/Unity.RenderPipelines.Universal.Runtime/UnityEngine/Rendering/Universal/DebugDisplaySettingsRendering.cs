namespace UnityEngine.Rendering.Universal;

public class DebugDisplaySettingsRendering : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Rendering", order = 1)]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsRendering>
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass0_0
		{
			public DebugDisplaySettingsRendering data; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass0_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <.ctor>b__0() { }

		}


		[CalledBy(Type = typeof(DebugDisplaySettingsRendering), Member = "UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel", ReturnType = typeof(IDebugDisplaySettingsPanelDisposable))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DebugDisplaySettingsHDROutput), Member = "CreateHDROuputDisplayTable", ReturnType = typeof(Table))]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreatePixelValidationChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreatePixelValidationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMipMapDebugWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMaxOverdrawCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateOverdrawMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateAdditionalWireframeShaderViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreatePostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateTaaDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMapOverlaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateStpDebugViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMapOverlays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = "AddWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RuntimeDebugShadersMessageBox), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugDisplaySettingsPanel`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 20)]
		[CallsUnknownMethods(Count = 22)]
		public SettingsPanel(DebugDisplaySettingsRendering data) { }

	}

	private static class Strings
	{
		public const string RangeValidationSettingsContainerName = "Pixel Range Settings"; //Field offset: 0x0
		public static readonly NameAndTooltip MapOverlays; //Field offset: 0x0
		public static readonly NameAndTooltip StpDebugViews; //Field offset: 0x10
		public static readonly NameAndTooltip MapSize; //Field offset: 0x20
		public static readonly NameAndTooltip AdditionalWireframeModes; //Field offset: 0x30
		public static readonly NameAndTooltip WireframeNotSupportedWarning; //Field offset: 0x40
		public static readonly NameAndTooltip OverdrawMode; //Field offset: 0x50
		public static readonly NameAndTooltip MaxOverdrawCount; //Field offset: 0x60
		public static readonly NameAndTooltip MipMapDisableMipCaching; //Field offset: 0x70
		public static readonly NameAndTooltip MipMapDebugView; //Field offset: 0x80
		public static readonly NameAndTooltip MipMapDebugOpacity; //Field offset: 0x90
		public static readonly NameAndTooltip MipMapMaterialTextureSlot; //Field offset: 0xA0
		public static readonly NameAndTooltip MipMapTerrainTexture; //Field offset: 0xB0
		public static readonly NameAndTooltip MipMapDisplayStatusCodes; //Field offset: 0xC0
		public static readonly NameAndTooltip MipMapActivityTimespan; //Field offset: 0xD0
		public static readonly NameAndTooltip MipMapCombinePerMaterial; //Field offset: 0xE0
		public static readonly NameAndTooltip PostProcessing; //Field offset: 0xF0
		public static readonly NameAndTooltip MSAA; //Field offset: 0x100
		public static readonly NameAndTooltip HDR; //Field offset: 0x110
		public static readonly NameAndTooltip TaaDebugMode; //Field offset: 0x120
		public static readonly NameAndTooltip PixelValidationMode; //Field offset: 0x130
		public static readonly NameAndTooltip Channels; //Field offset: 0x140
		public static readonly NameAndTooltip ValueRangeMin; //Field offset: 0x150
		public static readonly NameAndTooltip ValueRangeMax; //Field offset: 0x160

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 69)]
		private static Strings() { }

	}

	internal enum TaaDebugMode
	{
		None = 0,
		ShowRawFrame = 1,
		ShowRawFrameNoJitter = 2,
		ShowClampedHistory = 3,
	}

	public static class WidgetFactory
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Int32> <>9__2_2; //Field offset: 0x8
			public static Func<Int32> <>9__2_3; //Field offset: 0x10
			public static Action<Field`1<Int32>, Int32> <>9__3_4; //Field offset: 0x18
			public static Func<Int32> <>9__6_3; //Field offset: 0x20
			public static Func<Int32> <>9__6_4; //Field offset: 0x28
			public static Func<Boolean> <>9__7_0; //Field offset: 0x30
			public static Action<Boolean> <>9__7_1; //Field offset: 0x38
			public static Func<Single> <>9__9_4; //Field offset: 0x40
			public static Func<Single> <>9__9_5; //Field offset: 0x48
			public static Func<Boolean> <>9__9_10; //Field offset: 0x50
			public static Func<Single> <>9__11_3; //Field offset: 0x58
			public static Func<Single> <>9__11_4; //Field offset: 0x60
			public static Action<Field`1<Int32>, Int32> <>9__16_4; //Field offset: 0x68
			public static Action<Field`1<Int32>, Int32> <>9__17_4; //Field offset: 0x70

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
			internal void <CreateAdditionalWireframeShaderViews>b__3_4(Field<Int32> _, int _) { }

			[CallerCount(Count = 182)]
			[DeduplicatedMethod]
			internal int <CreateMapOverlaySize>b__2_2() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal int <CreateMapOverlaySize>b__2_3() { }

			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			internal int <CreateMaxOverdrawCount>b__6_3() { }

			[CallerCount(Count = 0)]
			internal int <CreateMaxOverdrawCount>b__6_4() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal float <CreateMipMapDebugCooldownSlider>b__11_3() { }

			[CallerCount(Count = 0)]
			internal float <CreateMipMapDebugCooldownSlider>b__11_4() { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			internal bool <CreateMipMapDebugSettings>b__9_10() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal float <CreateMipMapDebugSettings>b__9_4() { }

			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			internal float <CreateMipMapDebugSettings>b__9_5() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Texture), Member = "get_streamingTextureDiscardUnusedMips", ReturnType = typeof(bool))]
			internal bool <CreateMipMapDebugWidget>b__7_0() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Texture), Member = "set_streamingTextureDiscardUnusedMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			internal void <CreateMipMapDebugWidget>b__7_1(bool value) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
			[Calls(Type = typeof(DebugManager), Member = "ReDrawOnScreenDebug", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePixelValidationMode>b__17_4(Field<Int32> _, int _) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
			[Calls(Type = typeof(DebugManager), Member = "ReDrawOnScreenDebug", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateTaaDebugMode>b__16_4(Field<Int32> _, int _) { }

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
			internal int <CreateMapOverlays>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMapOverlays>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateMapOverlays>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMapOverlays>b__3(int value) { }

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
			[ContainsUnimplementedInstructions]
			internal bool <CreateStpDebugViews>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateStpDebugViews>b__1() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateStpDebugViews>b__2(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateStpDebugViews>b__3() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateStpDebugViews>b__4(int value) { }

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
			internal int <CreateMipMapDebugSlotSelector>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapDebugSlotSelector>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateMipMapDebugSlotSelector>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapDebugSlotSelector>b__3(int value) { }

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
			[ContainsUnimplementedInstructions]
			internal bool <CreateMipMapDebugCooldownSlider>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreateMipMapDebugCooldownSlider>b__1() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapDebugCooldownSlider>b__2(float value) { }

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
			[ContainsUnimplementedInstructions]
			internal bool <CreateMipMapShowStatusCodeToggle>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <CreateMipMapShowStatusCodeToggle>b__1() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapShowStatusCodeToggle>b__2(bool value) { }

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
			internal int <CreatePostProcessing>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePostProcessing>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreatePostProcessing>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePostProcessing>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass14_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <CreateMSAA>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMSAA>b__1(bool value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass15_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <CreateHDR>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateHDR>b__1(bool value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass16_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateTaaDebugMode>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateTaaDebugMode>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateTaaDebugMode>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateTaaDebugMode>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass17_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass17_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreatePixelValidationMode>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePixelValidationMode>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreatePixelValidationMode>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePixelValidationMode>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass18_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass18_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreatePixelValidationChannels>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePixelValidationChannels>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreatePixelValidationChannels>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePixelValidationChannels>b__3(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass19_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass19_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreatePixelValueRangeMin>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePixelValueRangeMin>b__1(float value) { }

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
			internal int <CreateMapOverlaySize>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMapOverlaySize>b__1(int value) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			public SettingsPanel panel; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass20_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreatePixelValueRangeMax>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreatePixelValueRangeMax>b__1(float value) { }

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
			internal int <CreateAdditionalWireframeShaderViews>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal void <CreateAdditionalWireframeShaderViews>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateAdditionalWireframeShaderViews>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal void <CreateAdditionalWireframeShaderViews>b__3(int value) { }

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
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <CreateWireframeNotSupportedWarning>b__0() { }

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
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateOverdrawMode>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal void <CreateOverdrawMode>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateOverdrawMode>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal void <CreateOverdrawMode>b__3(int value) { }

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
			[ContainsUnimplementedInstructions]
			internal bool <CreateMaxOverdrawCount>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateMaxOverdrawCount>b__1() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMaxOverdrawCount>b__2(int value) { }

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
			internal int <CreateMipMapMode>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapMode>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateMipMapMode>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapMode>b__3(int value) { }

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
			[ContainsUnimplementedInstructions]
			internal bool <CreateMipMapDebugSettings>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <CreateMipMapDebugSettings>b__1() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateMipMapDebugSettings>b__11() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapDebugSettings>b__12(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateMipMapDebugSettings>b__13() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapDebugSettings>b__14(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal float <CreateMipMapDebugSettings>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapDebugSettings>b__3(float value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <CreateMipMapDebugSettings>b__6() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <CreateMipMapDebugSettings>b__7() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateMipMapDebugSettings>b__8(bool value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal bool <CreateMipMapDebugSettings>b__9() { }

		}


		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		internal static Widget CreateAdditionalWireframeShaderViews(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreateHDR(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreateMapOverlays(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(IntField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 8)]
		internal static Widget CreateMapOverlaySize(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(IntField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 9)]
		internal static Widget CreateMaxOverdrawCount(SettingsPanel panel) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateMipMapDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 9)]
		internal static Widget CreateMipMapDebugCooldownSlider(SettingsPanel panel) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateMipMapDebugWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMipMapDebugSlotSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel), typeof(System.Func`1<System.Boolean>), typeof(GUIContent[]), typeof(Int32[])}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMipMapDebugCooldownSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[CallsDeduplicatedMethods(Count = 23)]
		[CallsUnknownMethods(Count = 28)]
		internal static Widget CreateMipMapDebugSettings(SettingsPanel panel) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateMipMapDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EnumField`1), Member = "set_enumValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		internal static Widget CreateMipMapDebugSlotSelector(SettingsPanel panel, Func<Boolean> hiddenCB, GUIContent[] texSlotStrings, Int32[] texSlotValues) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMipMapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateMipMapDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreateMipMapDebugWidget(SettingsPanel panel) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateMipMapDebugWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel)}, ReturnType = typeof(Widget))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreateMipMapMode(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		internal static Widget CreateMipMapShowStatusCodeToggle(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreateMSAA(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreateOverdrawMode(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreatePixelValidationChannels(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		internal static Widget CreatePixelValidationMode(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreatePixelValueRangeMax(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FloatField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		internal static Widget CreatePixelValueRangeMin(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		internal static Widget CreatePostProcessing(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EnumField`1), Member = "set_enumValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 8)]
		internal static Widget CreateStpDebugViews(SettingsPanel panel) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		internal static Widget CreateTaaDebugMode(SettingsPanel panel) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		internal static Widget CreateWireframeNotSupportedWarning(SettingsPanel panel) { }

	}

	private DebugWireframeMode m_WireframeMode; //Field offset: 0x10
	private bool m_Overdraw; //Field offset: 0x14
	private DebugOverdrawMode m_OverdrawMode; //Field offset: 0x18
	[CompilerGenerated]
	private int <maxOverdrawCount>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private DebugFullScreenMode <fullScreenDebugMode>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <stpDebugViewIndex>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <fullScreenDebugModeOutputSizeScreenPercent>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DebugSceneOverrideMode <sceneOverrideMode>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private DebugMipInfoMode <mipInfoMode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <mipDebugStatusShowCode>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private DebugMipMapStatusMode <mipDebugStatusMode>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <mipDebugOpacity>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <mipDebugRecentUpdateCooldown>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <mipDebugMaterialTextureSlot>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <showInfoForAllSlots>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private DebugMipMapModeTerrainTexture <mipDebugTerrainTexture>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private DebugPostProcessingMode <postProcessingDebugMode>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <enableMsaa>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <enableHDR>k__BackingField; //Field offset: 0x55
	[CompilerGenerated]
	private TaaDebugMode <taaDebugMode>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private DebugValidationMode <validationMode>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private PixelValidationChannels <validationChannels>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private float <validationRangeMin>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private float <validationRangeMax>k__BackingField; //Field offset: 0x68

	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 53
	}

	internal bool canAggregateData
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 17
	}

	public bool enableHDR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool enableMsaa
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DebugFullScreenMode fullScreenDebugMode
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int fullScreenDebugModeOutputSizeScreenPercent
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool IsLightingActive
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	public override bool IsPostProcessingAllowed
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public int maxOverdrawCount
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int mipDebugMaterialTextureSlot
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float mipDebugOpacity
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

	public float mipDebugRecentUpdateCooldown
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

	public DebugMipMapStatusMode mipDebugStatusMode
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool mipDebugStatusShowCode
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DebugMipMapModeTerrainTexture mipDebugTerrainTexture
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DebugMipInfoMode mipInfoMode
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Obsolete("overdraw has been deprecated. Use overdrawMode instead.", True)]
	public bool overdraw
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 57
	}

	public DebugOverdrawMode overdrawMode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 60
	}

	public DebugPostProcessingMode postProcessingDebugMode
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal DebugSceneOverrideMode sceneOverrideMode
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public bool showInfoForAllSlots
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal int stpDebugViewIndex
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public TaaDebugMode taaDebugMode
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

	public PixelValidationChannels validationChannels
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

	public DebugValidationMode validationMode
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

	public float validationRangeMax
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

	public float validationRangeMin
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

	public DebugWireframeMode wireframeMode
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 54
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DebugDisplaySettingsRendering() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_AreAnySettingsActive() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_canAggregateData() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_enableHDR() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_enableMsaa() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugFullScreenMode get_fullScreenDebugMode() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_fullScreenDebugModeOutputSizeScreenPercent() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsLightingActive() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsPostProcessingAllowed() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_maxOverdrawCount() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_mipDebugMaterialTextureSlot() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_mipDebugOpacity() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_mipDebugRecentUpdateCooldown() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugMipMapStatusMode get_mipDebugStatusMode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_mipDebugStatusShowCode() { }

	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugMipMapModeTerrainTexture get_mipDebugTerrainTexture() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugMipInfoMode get_mipInfoMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_overdraw() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public DebugOverdrawMode get_overdrawMode() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugPostProcessingMode get_postProcessingDebugMode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal DebugSceneOverrideMode get_sceneOverrideMode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_showInfoForAllSlots() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_stpDebugViewIndex() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TaaDebugMode get_taaDebugMode() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public PixelValidationChannels get_validationChannels() { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugValidationMode get_validationMode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_validationRangeMax() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_validationRangeMin() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public DebugWireframeMode get_wireframeMode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_enableHDR(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_enableMsaa(bool value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_fullScreenDebugMode(DebugFullScreenMode value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_fullScreenDebugModeOutputSizeScreenPercent(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_maxOverdrawCount(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_mipDebugMaterialTextureSlot(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_mipDebugOpacity(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_mipDebugRecentUpdateCooldown(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_mipDebugStatusMode(DebugMipMapStatusMode value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_mipDebugStatusShowCode(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_mipDebugTerrainTexture(DebugMipMapModeTerrainTexture value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_mipInfoMode(DebugMipInfoMode value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_overdraw(bool value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_overdrawMode(DebugOverdrawMode value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_postProcessingDebugMode(DebugPostProcessingMode value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_sceneOverrideMode(DebugSceneOverrideMode value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_showInfoForAllSlots(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_stpDebugViewIndex(int value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_taaDebugMode(TaaDebugMode value) { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_validationChannels(PixelValidationChannels value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_validationMode(DebugValidationMode value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_validationRangeMax(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_validationRangeMin(float value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_wireframeMode(DebugWireframeMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override bool TryGetScreenClearColor(ref Color color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRendering)}, ReturnType = typeof(void))]
	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private void UpdateDebugSceneOverrideMode() { }

}

