namespace UnityEngine.Rendering;

public class DebugUI
{
	internal class BitField : EnumField<Enum>
	{
		private Type m_EnumType; //Field offset: 0x70

		public Type enumType
		{
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory", Member = "CreateLightingFeatures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting"}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+EnumField`1<System.Object>), Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			 set { } //Length: 88
		}

		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory", Member = "CreateLightingFeatures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(EnumField`1), Member = ".ctor", ReturnType = typeof(void))]
		public BitField() { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		public Type get_enumType() { }

		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory", Member = "CreateLightingFeatures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+EnumField`1<System.Object>), Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void set_enumType(Type value) { }

	}

	internal class BoolField : Field<Boolean>
	{

		[CallerCount(Count = 39)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public BoolField() { }

	}

	internal class Button : Widget
	{
		[CompilerGenerated]
		private Action <action>k__BackingField; //Field offset: 0x48

		public Action action
		{
			[CallerCount(Count = 10)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 254
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Button() { }

		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Action get_action() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_action(Action value) { }

	}

	internal class ColorField : Field<Color>
	{
		public bool hdr; //Field offset: 0x60
		public bool showAlpha; //Field offset: 0x61
		public bool showPicker; //Field offset: 0x62
		public float incStep; //Field offset: 0x64
		public float incStepMult; //Field offset: 0x68
		public int decimals; //Field offset: 0x6C

		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateAlbedoCustomColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ColorField() { }

		[CallerCount(Count = 0)]
		public virtual Color ValidateValue(Color value) { }

	}

	internal class Container : Widget, IContainer
	{
		private const string k_IDToken = "#"; //Field offset: 0x0
		[CompilerGenerated]
		private ObservableList<Widget> <children>k__BackingField; //Field offset: 0x48

		public private override ObservableList<Widget> children
		{
			[CallerCount(Count = 10)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 254
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		internal bool hideDisplayName
		{
			[CalledBy(Type = typeof(DebugUIHandlerGroup), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			internal get { } //Length: 94
		}

		public internal virtual Panel panel
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			internal set { } //Length: 211
		}

		[CalledBy(Type = typeof(RenderGraphDebugParams), Member = "GetWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugUI+Widget>))]
		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateVolumeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(Table))]
		[CalledBy(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HBox), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VBox), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Table), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderingLayerField), Member = "Resize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMapOverlaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMaxOverdrawCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(ObservableList`1), Member = ".ctor", ReturnType = typeof(void))]
		[ContainsInvalidInstructions]
		public Container() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ObservableList`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		public Container(string id) { }

		[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Foldout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>), typeof(String[]), typeof(String[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ObservableList`1), Member = "add_ItemAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ListChangedEventHandler`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "add_ItemRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ListChangedEventHandler`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ListChangedEventArgs`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 3)]
		public Container(string displayName, ObservableList<Widget> children) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Widget), Member = "GenerateQueryPath", ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal virtual void GenerateQueryPath() { }

		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override ObservableList<Widget> get_children() { }

		[CalledBy(Type = typeof(DebugUIHandlerGroup), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal bool get_hideDisplayName() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public virtual Panel get_panel() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel), Member = "SetDirty", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel), Member = "SetDirty", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_children(ObservableList<Widget> value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal virtual void set_panel(Panel value) { }

	}

	internal class EnumField : EnumField<Int32>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<GUIContent, String> <>9__17_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			internal string <InitQuickSeparators>b__17_0(GUIContent x) { }

		}

		internal Int32[] quickSeparators; //Field offset: 0x70
		private Int32[] m_Indexes; //Field offset: 0x78
		[CompilerGenerated]
		private Func<Int32> <getIndex>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		private Action<Int32> <setIndex>k__BackingField; //Field offset: 0x88

		public Type autoEnum
		{
			[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreatePixelValidationChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreatePixelValidationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateTaaDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreatePostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateAdditionalWireframeShaderViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateOverdrawMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateAlbedoPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateMaterialValidationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateMaterialOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory", Member = "CreateHDRDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory", Member = "CreateLightingDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMapOverlays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CallerCount(Count = 16)]
			[Calls(Type = typeof(EnumField`1), Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(EnumField), Member = "InitQuickSeparators", ReturnType = typeof(void))]
			 set { } //Length: 82
		}

		public int currentIndex
		{
			[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnDecrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory+<RefreshAfterSanitization>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = "UpdateValueLabel", ReturnType = typeof(void))]
			[CallerCount(Count = 5)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 37
			[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnDecrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory+<RefreshAfterSanitization>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 set { } //Length: 37
		}

		public Func<Int32> getIndex
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 16
		}

		internal Int32[] indexes
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerable), Member = "Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
			[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
			[CallsUnknownMethods(Count = 1)]
			internal get { } //Length: 125
		}

		public Action<Int32> setIndex
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 19
		}

		[CallerCount(Count = 20)]
		[Calls(Type = typeof(EnumField`1), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public EnumField() { }

		[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnDecrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "UpdateValueLabel", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory+<RefreshAfterSanitization>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = "UpdateValueLabel", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public int get_currentIndex() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Func<Int32> get_getIndex() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
		[CallsUnknownMethods(Count = 1)]
		internal Int32[] get_indexes() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Action<Int32> get_setIndex() { }

		[CalledBy(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnDecrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "Distinct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		internal void InitQuickSeparators() { }

		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMapOverlays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory", Member = "CreateLightingDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+WidgetFactory", Member = "CreateHDRDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateMaterialOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateMaterialValidationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateOverdrawMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateAlbedoPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreatePostProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateTaaDebugMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreatePixelValidationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreatePixelValidationChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateAdditionalWireframeShaderViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(EnumField`1), Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EnumField), Member = "InitQuickSeparators", ReturnType = typeof(void))]
		public void set_autoEnum(Type value) { }

		[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerEnumField), Member = "OnDecrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory+<RefreshAfterSanitization>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void set_currentIndex(int value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_getIndex(Func<Int32> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_setIndex(Action<Int32> value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		public virtual void SetValue(int value) { }

	}

	internal abstract class EnumField : Field<T>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c<T> <>9; //Field offset: 0x0
			public static Func<FieldInfo, Boolean> <>9__6_0; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 8)]
			[DeduplicatedMethod]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[Calls(Type = typeof(CustomAttributeExtensions), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			internal bool <AutoFillFromType>b__6_0(FieldInfo fieldInfo) { }

		}

		private static Regex s_NicifyRegEx; //Field offset: 0x0
		private Int32[] m_EnumValues; //Field offset: 0x0
		public GUIContent[] enumNames; //Field offset: 0x0

		public Int32[] enumValues
		{
			[CallerCount(Count = 22)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = typeof(CameraSwitcher), Member = "OnEnable", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(WidgetFactory), Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel), typeof(System.Action`2<UnityEngine.Rendering.DebugUI+Field`1<System.Int32>, System.Int32>)}, ReturnType = typeof(EnumField))]
			[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "<RegisterDebug>g__RefreshScenarioNames|42_75", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateStpDebugViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
			[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugSlotSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel", "System.Func`1<Boolean>", "UnityEngine.GUIContent[]", "System.Int32[]"}, ReturnType = typeof(Widget))]
			[CallerCount(Count = 6)]
			[Calls(Type = typeof(Enumerable), Member = "Distinct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
			[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 set { } //Length: 375
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private static EnumField`1() { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel), typeof(System.Action`2<UnityEngine.Rendering.DebugUI+Field`1<System.Int32>, System.Int32>)}, ReturnType = typeof(EnumField))]
		[CalledBy(Type = typeof(EnumField), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HistoryEnumField), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BitField), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaskField), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected EnumField`1() { }

		[CalledBy(Type = typeof(EnumField), Member = "set_autoEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
		[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(Enumerable), Member = "Distinct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PooledObject), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 37)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		protected void AutoFillFromType(Type enumType) { }

		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		public Int32[] get_enumValues() { }

		[CalledBy(Type = typeof(CameraSwitcher), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel), typeof(System.Action`2<UnityEngine.Rendering.DebugUI+Field`1<System.Int32>, System.Int32>)}, ReturnType = typeof(EnumField))]
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "<RegisterDebug>g__RefreshScenarioNames|42_75", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateStpDebugViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugSlotSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel", "System.Func`1<Boolean>", "UnityEngine.GUIContent[]", "System.Int32[]"}, ReturnType = typeof(Widget))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Enumerable), Member = "Distinct", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public void set_enumValues(Int32[] value) { }

	}

	internal abstract class Field : Widget, IValueField
	{
		[CompilerGenerated]
		private Func<T> <getter>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Action<T> <setter>k__BackingField; //Field offset: 0x0
		public Action<Field`1<T>, T> onValueChanged; //Field offset: 0x0

		public Func<T> getter
		{
			[CallerCount(Count = 10)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 254
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public Action<T> setter
		{
			[CallerCount(Count = 16)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected Field`1() { }

		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Func<T> get_getter() { }

		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Action<T> get_setter() { }

		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "<SetWidget>b__8_6", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "<SetWidget>b__8_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "<SetWidget>b__8_4", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "<SetWidget>b__8_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "<SetWidget>b__8_2", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "<SetWidget>b__8_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "<SetWidget>b__8_0", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DebugUIHandlerVector4), Member = "<SetWidget>b__8_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_4", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_2", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_0", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "UpdateColor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerColor), Member = "<SetWidget>b__9_6", ReturnType = typeof(float))]
		[CallerCount(Count = 23)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public T GetValue() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_getter(Func<T> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_setter(Action<T> value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override void SetValue(object value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override void SetValue(T value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override T ValidateValue(T value) { }

	}

	[Flags]
	internal enum Flags
	{
		None = 0,
		EditorOnly = 2,
		RuntimeOnly = 4,
		EditorForceUpdate = 8,
		FrequentlyUsed = 16,
	}

	internal class FloatField : Field<Single>
	{
		public Func<Single> min; //Field offset: 0x60
		public Func<Single> max; //Field offset: 0x68
		public float incStep; //Field offset: 0x70
		public float incStepMult; //Field offset: 0x74
		public int decimals; //Field offset: 0x78

		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateAlbedoMinLuminance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateAlbedoMaxLuminance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateAlbedoHueTolerance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateAlbedoSaturationTolerance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateMetallicMinValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateMetallicMaxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugCooldownSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreatePixelValueRangeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreatePixelValueRangeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 28)]
		[CallsDeduplicatedMethods(Count = 1)]
		public FloatField() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public virtual float ValidateValue(float value) { }

	}

	internal class Foldout : Container, IValueField
	{
		internal struct ContextMenuItem
		{
			public string displayName; //Field offset: 0x0
			public Action action; //Field offset: 0x8

		}

		public bool opened; //Field offset: 0x50
		public bool isHeader; //Field offset: 0x51
		public List<ContextMenuItem> contextMenuItems; //Field offset: 0x58
		private bool m_Dirty; //Field offset: 0x60
		private String[] m_ColumnLabels; //Field offset: 0x68
		private String[] m_ColumnTooltips; //Field offset: 0x70
		private List<GUIContent> m_RowContents; //Field offset: 0x78

		public String[] columnLabels
		{
			[CallerCount(Count = 22)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 set { } //Length: 32
		}

		public String[] columnTooltips
		{
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 set { } //Length: 32
		}

		public bool isReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		internal List<GUIContent> rowContents
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Array), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 9)]
			internal get { } //Length: 666
		}

		[CalledBy(Type = typeof(WidgetFactory), Member = "GenerateTableRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugFrameTiming), Member = "RegisterDebugUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Row), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplayStats", Member = "RegisterDebugUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Widget>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddInstanceCullingStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddOcclusionContextStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public Foldout() { }

		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "BuildDetailedStatsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<TProfileId>"}, ReturnType = typeof(Widget))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public Foldout(string displayName, ObservableList<Widget> children, String[] columnLabels = null, String[] columnTooltips = null) { }

		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		public String[] get_columnLabels() { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		public String[] get_columnTooltips() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public bool get_isReadOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		internal List<GUIContent> get_rowContents() { }

		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		public bool GetValue() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void set_columnLabels(String[] value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void set_columnTooltips(String[] value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override void SetValue(object value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void SetValue(bool value) { }

		[CallerCount(Count = 0)]
		private override object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override object ValidateValue(object value) { }

	}

	internal class HBox : Container
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public HBox() { }

	}

	internal class HistoryBoolField : BoolField
	{
		[CompilerGenerated]
		private Func<Boolean>[] <historyGetter>k__BackingField; //Field offset: 0x60

		public int historyDepth
		{
			[CalledBy(Type = typeof(DebugUIHandlerToggleHistory), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugUIHandlerToggleHistory), Member = "UpdateValueLabel", ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			 get { } //Length: 14
		}

		public Func<Boolean>[] historyGetter
		{
			[CallerCount(Count = 84)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 39)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public HistoryBoolField() { }

		[CalledBy(Type = typeof(DebugUIHandlerToggleHistory), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerToggleHistory), Member = "UpdateValueLabel", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		public int get_historyDepth() { }

		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Func<Boolean>[] get_historyGetter() { }

		[CalledBy(Type = typeof(DebugUIHandlerToggleHistory), Member = "UpdateValueLabel", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public bool GetHistoryValue(int historyIndex) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_historyGetter(Func<Boolean>[] value) { }

	}

	internal class HistoryEnumField : EnumField
	{
		[CompilerGenerated]
		private Func<Int32>[] <historyIndexGetter>k__BackingField; //Field offset: 0x90

		public int historyDepth
		{
			[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = "UpdateValueLabel", ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			 get { } //Length: 17
		}

		public Func<Int32>[] historyIndexGetter
		{
			[CallerCount(Count = 57)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 19
		}

		[CallerCount(Count = 20)]
		[Calls(Type = typeof(EnumField`1), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public HistoryEnumField() { }

		[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = "UpdateValueLabel", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		public int get_historyDepth() { }

		[CallerCount(Count = 57)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Func<Int32>[] get_historyIndexGetter() { }

		[CalledBy(Type = typeof(DebugUIHandlerEnumHistory), Member = "UpdateValueLabel", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public int GetHistoryValue(int historyIndex) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_historyIndexGetter(Func<Int32>[] value) { }

	}

	internal interface IContainer
	{

		public ObservableList<Widget> children
		{
			 get { } //Length: 0
		}

		public string displayName
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public string queryPath
		{
			 get { } //Length: 0
		}

		public ObservableList<Widget> get_children() { }

		public string get_displayName() { }

		public string get_queryPath() { }

		public void set_displayName(string value) { }

	}

	internal class IntField : Field<Int32>
	{
		public Func<Int32> min; //Field offset: 0x60
		public Func<Int32> max; //Field offset: 0x68
		public int incStep; //Field offset: 0x70
		public int intStepMult; //Field offset: 0x74

		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMapOverlaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMaxOverdrawCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = typeof(Widget))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		public IntField() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual int ValidateValue(int value) { }

	}

	internal interface IValueField
	{

		public object GetValue() { }

		public void SetValue(object value) { }

		public object ValidateValue(object value) { }

	}

	[Obsolete("Mask field is not longer supported. Please use a BitField or implement your own Widget. #from(6000.2)", False)]
	internal class MaskField : EnumField<UInt32>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EnumField`1), Member = ".ctor", ReturnType = typeof(void))]
		public MaskField() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(UnityEngine.Rendering.DebugUI+EnumField`1<System.UInt32>), Member = "set_enumValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PooledObject), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 14)]
		public void Fill(String[] names) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		public virtual void SetValue(uint value) { }

	}

	internal class MessageBox : Widget
	{
		internal enum Style
		{
			Info = 0,
			Warning = 1,
			Error = 2,
		}

		public Style style; //Field offset: 0x48
		public Func<String> messageCallback; //Field offset: 0x50

		public string message
		{
			[CalledBy(Type = typeof(DebugUIHandlerMessageBox), Member = "Update", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 28
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public MessageBox() { }

		[CalledBy(Type = typeof(DebugUIHandlerMessageBox), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public string get_message() { }

	}

	internal class ObjectField : Field<Object>
	{
		public Type type; //Field offset: 0x60

		[CalledBy(Type = typeof(WidgetFactory), Member = "GenerateTableColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(DebugDisplaySettingsVolume), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public ObjectField() { }

	}

	internal class ObjectListField : Field<Object[]>
	{
		public Type type; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public ObjectListField() { }

	}

	internal class ObjectPopupField : Field<Object>
	{
		[CompilerGenerated]
		private Func<IEnumerable`1<Object>> <getObjects>k__BackingField; //Field offset: 0x60

		public Func<IEnumerable`1<Object>> getObjects
		{
			[CallerCount(Count = 84)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ObjectPopupField() { }

		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Func<IEnumerable`1<Object>> get_getObjects() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_getObjects(Func<IEnumerable`1<Object>> value) { }

	}

	internal class Panel : IContainer, IComparable<Panel>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action<Panel> <>9__29_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			internal void <.ctor>b__29_0(Panel <p0>) { }

		}

		[CompilerGenerated]
		private Flags <flags>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <displayName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private int <groupIndex>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private ObservableList<Widget> <children>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Action<Panel> onSetDirty; //Field offset: 0x30

		public event Action<Panel> onSetDirty
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 3)]
			[CompilerGenerated]
			 add { } //Length: 160
			[CalledBy(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
			[CalledBy(Type = typeof(DebugManager), Member = "RemovePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
			[CallsUnknownMethods(Count = 3)]
			[CompilerGenerated]
			 remove { } //Length: 160
		}

		public private override ObservableList<Widget> children
		{
			[CallerCount(Count = 15)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		public override string displayName
		{
			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public bool editorForceUpdate
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
		}

		public Flags flags
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

		public int groupIndex
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

		public bool isEditorOnly
		{
			[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Rebuild", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
		}

		public bool isInactiveInEditor
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
			 get { } //Length: 87
		}

		public bool isRuntimeOnly
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
		}

		public override string queryPath
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CalledBy(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ObservableList`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "add_ItemAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ListChangedEventHandler`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "add_ItemRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ListChangedEventHandler`1<T>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		public Panel() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		public void add_onSetDirty(Action<Panel> value) { }

		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override ObservableList<Widget> get_children() { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override string get_displayName() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_editorForceUpdate() { }

		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Flags get_flags() { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_groupIndex() { }

		[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Rebuild", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool get_isEditorOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		public bool get_isInactiveInEditor() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_isRuntimeOnly() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public override string get_queryPath() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel), Member = "SetDirty", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsInvalidInstructions]
		protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[CalledBy(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
		[CalledBy(Type = typeof(DebugManager), Member = "RemovePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		public void remove_onSetDirty(Action<Panel> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_children(ObservableList<Widget> value) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override void set_displayName(string value) { }

		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_flags(Flags value) { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_groupIndex(int value) { }

		[CalledBy(Type = typeof(Container), Member = "OnItemAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>), typeof(UnityEngine.Rendering.ListChangedEventArgs`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Container), Member = "OnItemRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>), typeof(UnityEngine.Rendering.ListChangedEventArgs`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Table), Member = "OnItemAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>), typeof(UnityEngine.Rendering.ListChangedEventArgs`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Table), Member = "OnItemRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>), typeof(UnityEngine.Rendering.ListChangedEventArgs`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "OnItemAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>), typeof(UnityEngine.Rendering.ListChangedEventArgs`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public void SetDirty() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		private override int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(Panel other) { }

	}

	internal class ProgressBarValue : Value
	{
		public float min; //Field offset: 0x60
		public float max; //Field offset: 0x64

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public ProgressBarValue() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal static float <FormatString>g__Remap01|2_0(float v, float x0, float y0) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		public virtual string FormatString(object value) { }

	}

	internal class RenderingLayerField : Field<RenderingLayerMask>, IContainer
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public int index; //Field offset: 0x10
			public RenderingLayerField <>4__this; //Field offset: 0x18

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass5_0() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			internal Color <Resize>b__0() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			internal void <Resize>b__1(Color value) { }

		}

		private static readonly NameAndTooltip s_RenderingLayerColors; //Field offset: 0x0
		private String[] m_RenderingLayersNames; //Field offset: 0x60
		private int m_DefinedRenderingLayersCount; //Field offset: 0x68
		private ObservableList<Widget> m_RenderingLayersColors; //Field offset: 0x70
		[CompilerGenerated]
		private Func<Int32, Vector4> <getRenderingLayerColor>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private Action<Vector4, Int32> <setRenderingLayerColor>k__BackingField; //Field offset: 0x80

		public override ObservableList<Widget> children
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(RenderingLayerMask), Member = "GetDefinedRenderingLayerCount", ReturnType = typeof(int))]
			[Calls(Type = typeof(RenderingLayerField), Member = "Resize", ReturnType = typeof(void))]
			 get { } //Length: 101
		}

		public Func<Int32, Vector4> getRenderingLayerColor
		{
			[CallerCount(Count = 7)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		private int maxRenderingLayerCount
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(RenderingLayerMask), Member = "GetRenderingLayerCount", ReturnType = typeof(int))]
			private get { } //Length: 64
		}

		public String[] renderingLayersNames
		{
			[CalledBy(Type = typeof(DebugUIHandlerRenderingLayerField), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(RenderingLayerMask), Member = "GetDefinedRenderingLayerCount", ReturnType = typeof(int))]
			[Calls(Type = typeof(RenderingLayerField), Member = "Resize", ReturnType = typeof(void))]
			 get { } //Length: 101
		}

		public Action<Vector4, Int32> setRenderingLayerColor
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 16
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private static RenderingLayerField() { }

		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+WidgetFactory", Member = "CreateFilterRenderingLayerMasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel"}, ReturnType = typeof(RenderingLayerField))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ObservableList`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public RenderingLayerField() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Widget), Member = "GenerateQueryPath", ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderingLayerMask), Member = "GetDefinedRenderingLayerCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(RenderingLayerField), Member = "Resize", ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal virtual void GenerateQueryPath() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderingLayerMask), Member = "GetDefinedRenderingLayerCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(RenderingLayerField), Member = "Resize", ReturnType = typeof(void))]
		public override ObservableList<Widget> get_children() { }

		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Func<Int32, Vector4> get_getRenderingLayerColor() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderingLayerMask), Member = "GetRenderingLayerCount", ReturnType = typeof(int))]
		private int get_maxRenderingLayerCount() { }

		[CalledBy(Type = typeof(DebugUIHandlerRenderingLayerField), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RenderingLayerMask), Member = "GetDefinedRenderingLayerCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(RenderingLayerField), Member = "Resize", ReturnType = typeof(void))]
		public String[] get_renderingLayersNames() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Action<Vector4, Int32> get_setRenderingLayerColor() { }

		[CalledBy(Type = typeof(RenderingLayerField), Member = "get_renderingLayersNames", ReturnType = typeof(String[]))]
		[CalledBy(Type = typeof(RenderingLayerField), Member = "get_children", ReturnType = typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>))]
		[CalledBy(Type = typeof(RenderingLayerField), Member = "GenerateQueryPath", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(RenderingLayerMask), Member = "GetDefinedRenderingLayerCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(RenderingLayerMask), Member = "GetRenderingLayerCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(RenderingLayerMask), Member = "RenderingLayerToName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ObservableList`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 11)]
		private void Resize() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_getRenderingLayerColor(Func<Int32, Vector4> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_setRenderingLayerColor(Action<Vector4, Int32> value) { }

	}

	internal class RuntimeDebugShadersMessageBox : MessageBox
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Boolean> <>9__0_0; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal bool <.ctor>b__0_0() { }

		}


		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon+SettingsPanel", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public RuntimeDebugShadersMessageBox() { }

	}

	internal class Table : Container
	{
		internal class Row : Foldout
		{

			[CalledBy(Type = typeof(DebugDisplaySettingsHDROutput), Member = "CreateHDROuputDisplayTable", ReturnType = typeof(Table))]
			[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", Member = "AddInstanceCullerViewDataRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Row))]
			[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", Member = "AddInstanceOcclusionPassDataRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Row))]
			[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", Member = "AddOcclusionContextDataRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Row))]
			[CallerCount(Count = 13)]
			[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			public Row() { }

		}

		private static GUIStyle columnHeaderStyle; //Field offset: 0x0
		public bool isReadOnly; //Field offset: 0x50
		private Boolean[] m_Header; //Field offset: 0x58

		public Boolean[] VisibleColumns
		{
			[CalledBy(Type = typeof(Table), Member = "SetColumnVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Table), Member = "GetColumnVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
			[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 5)]
			 get { } //Length: 636
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIStyle), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private static Table() { }

		[CalledBy(Type = typeof(DebugDisplaySettingsHDROutput), Member = "CreateHDROuputDisplayTable", ReturnType = typeof(Table))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddInstanceCullingStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddOcclusionContextStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public Table() { }

		[CalledBy(Type = typeof(Table), Member = "SetColumnVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Table), Member = "GetColumnVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ObservableList`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public Boolean[] get_VisibleColumns() { }

		[CalledBy(Type = typeof(DebugUIHandlerRow), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(int), typeof(GameObject)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DebugUIHandlerRow), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Table), Member = "get_VisibleColumns", ReturnType = typeof(Boolean[]))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool GetColumnVisibility(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel), Member = "SetDirty", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel), Member = "SetDirty", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "SetTableColumnVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume), typeof(Table)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Table), Member = "get_VisibleColumns", ReturnType = typeof(Boolean[]))]
		[CallsUnknownMethods(Count = 2)]
		public void SetColumnVisibility(int index, bool visible) { }

	}

	internal class UIntField : Field<UInt32>
	{
		public Func<UInt32> min; //Field offset: 0x60
		public Func<UInt32> max; //Field offset: 0x68
		public uint incStep; //Field offset: 0x70
		public uint intStepMult; //Field offset: 0x74

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public UIntField() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual uint ValidateValue(uint value) { }

	}

	internal class Value : Widget
	{
		[CompilerGenerated]
		private Func<Object> <getter>k__BackingField; //Field offset: 0x48
		public float refreshRate; //Field offset: 0x50
		public string formatString; //Field offset: 0x58

		public Func<Object> getter
		{
			[CallerCount(Count = 10)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 254
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CalledBy(Type = typeof(DebugDisplaySettingsHDROutput), Member = "CreateHDROuputDisplayTable", ReturnType = typeof(Table))]
		[CalledBy(Type = typeof(WidgetFactory), Member = "GenerateTableColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(DebugDisplaySettingsVolume), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "<BuildProfilingSamplerWidgetList>g__CreateWidgetForSampler|19_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TProfileId", typeof(ProfilingSampler), "UnityEngine.Rendering.DebugDisplayStats`1<TProfileId>+DebugProfilingType<TProfileId>"}, ReturnType = typeof(Value))]
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddInstanceCullingStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddOcclusionContextStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", Member = "AddInstanceCullerViewDataRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Row))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", Member = "AddInstanceOcclusionPassDataRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Row))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", Member = "AddOcclusionContextDataRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Row))]
		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public Value() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		public override string FormatString(object value) { }

		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Func<Object> get_getter() { }

		[CallerCount(Count = 23)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override object GetValue() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_getter(Func<Object> value) { }

	}

	internal class ValueTuple : Widget
	{
		public Value[] values; //Field offset: 0x48
		public int pinnedElementIndex; //Field offset: 0x50

		public int numElements
		{
			[CalledBy(Type = typeof(DebugUIHandlerPersistentCanvas), Member = "Toggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTuple), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugUIHandlerValueTuple), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(DebugUIHandlerValueTuple), Member = "UpdateValueLabels", ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 26
		}

		public float refreshRate
		{
			[CalledBy(Type = typeof(DebugUIHandlerValueTuple), Member = "Update", ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
			 get { } //Length: 83
		}

		[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "BuildProfilingSamplerWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TProfileId>"}, ReturnType = typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddInstanceCullingStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer+SettingsPanel", Member = "AddOcclusionContextStatsWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplayGPUResidentDrawer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ValueTuple() { }

		[CalledBy(Type = typeof(DebugUIHandlerPersistentCanvas), Member = "Toggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTuple), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerValueTuple), Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerValueTuple), Member = "UpdateValueLabels", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public int get_numElements() { }

		[CalledBy(Type = typeof(DebugUIHandlerValueTuple), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
		public float get_refreshRate() { }

	}

	internal class VBox : Container
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public VBox() { }

	}

	internal class Vector2Field : Field<Vector2>
	{
		public float incStep; //Field offset: 0x60
		public float incStepMult; //Field offset: 0x64
		public int decimals; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public Vector2Field() { }

	}

	internal class Vector3Field : Field<Vector3>
	{
		public float incStep; //Field offset: 0x60
		public float incStepMult; //Field offset: 0x64
		public int decimals; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public Vector3Field() { }

	}

	internal class Vector4Field : Field<Vector4>
	{
		public float incStep; //Field offset: 0x60
		public float incStepMult; //Field offset: 0x64
		public int decimals; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public Vector4Field() { }

	}

	internal abstract class Widget
	{
		internal struct NameAndTooltip
		{
			public string name; //Field offset: 0x0
			public string tooltip; //Field offset: 0x8

		}

		protected Panel m_Panel; //Field offset: 0x10
		protected IContainer m_Parent; //Field offset: 0x18
		[CompilerGenerated]
		private Flags <flags>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private string <displayName>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private string <tooltip>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private string <queryPath>k__BackingField; //Field offset: 0x38
		public Func<Boolean> isHiddenCallback; //Field offset: 0x40

		public override string displayName
		{
			[CallerCount(Count = 15)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public Flags flags
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

		public bool isEditorOnly
		{
			[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerCanvas+<>c", Member = "<Rebuild>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Traverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IContainer), typeof(Transform), typeof(DebugUIHandlerWidget), typeof(DebugUIHandlerWidget&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			 get { } //Length: 8
		}

		public bool isHidden
		{
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 22
		}

		public bool isInactiveInEditor
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
			 get { } //Length: 87
		}

		public bool isRuntimeOnly
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		public NameAndTooltip nameAndTooltip
		{
			[CallerCount(Count = 72)]
			[Calls(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllCells", ReturnType = typeof(void))]
			[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(ProbeBrickPool), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(ProbeBrickBlendingPool), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(ProbeBrickIndex), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			 set { } //Length: 319
		}

		public internal override Panel panel
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal set { } //Length: 13
		}

		public internal override IContainer parent
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal set { } //Length: 13
		}

		public private override string queryPath
		{
			[CallerCount(Count = 38)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		public string tooltip
		{
			[CallerCount(Count = 62)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected Widget() { }

		[CalledBy(Type = typeof(Container), Member = "GenerateQueryPath", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderingLayerField), Member = "GenerateQueryPath", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 4)]
		internal override void GenerateQueryPath() { }

		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override string get_displayName() { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Flags get_flags() { }

		[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerCanvas+<>c", Member = "<Rebuild>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Traverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IContainer), typeof(Transform), typeof(DebugUIHandlerWidget), typeof(DebugUIHandlerWidget&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		public bool get_isEditorOnly() { }

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public bool get_isHidden() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		public bool get_isInactiveInEditor() { }

		[CallerCount(Count = 0)]
		public bool get_isRuntimeOnly() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public override Panel get_panel() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public override IContainer get_parent() { }

		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override string get_queryPath() { }

		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_tooltip() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override void set_displayName(string value) { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_flags(Flags value) { }

		[CallerCount(Count = 72)]
		[Calls(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllCells", ReturnType = typeof(void))]
		[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(ProbeBrickPool), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(ProbeBrickBlendingPool), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(ProbeBrickIndex), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public void set_nameAndTooltip(NameAndTooltip value) { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal override void set_panel(Panel value) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal override void set_parent(IContainer value) { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_queryPath(string value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_tooltip(string value) { }

	}


	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugUI() { }

}

