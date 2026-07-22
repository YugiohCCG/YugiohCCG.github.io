namespace UnityEngine.Rendering;

public class DebugDisplaySettingsVolume : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Volume", order = 2147483647)]
	public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsVolume>
	{
		private Table m_VolumeTable; //Field offset: 0x28

		[CalledBy(Type = typeof(DebugDisplaySettingsVolume), Member = "CreatePanel", ReturnType = typeof(IDebugDisplaySettingsPanelDisposable))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DebugDisplaySettingsPanel`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateCameraSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel), typeof(System.Action`2<UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Object>, UnityEngine.Object>)}, ReturnType = typeof(ObjectPopupField))]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SettingsPanel), typeof(System.Action`2<UnityEngine.Rendering.DebugUI+Field`1<System.Int32>, System.Int32>)}, ReturnType = typeof(EnumField))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateVolumeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(Table))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 17)]
		public SettingsPanel(DebugDisplaySettingsVolume data) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SettingsPanel), Member = "Refresh", ReturnType = typeof(void))]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void <.ctor>b__0_0(Field<Object> _, object __) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SettingsPanel), Member = "Refresh", ReturnType = typeof(void))]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void <.ctor>b__0_1(Field<Int32> _, int __) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = "<.ctor>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.DebugUI+Field`1<UnityEngine.Object>), typeof(Object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SettingsPanel), Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.DebugUI+Field`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
		[Calls(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
		[Calls(Type = typeof(ObservableList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateVolumeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(Table))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		private void Refresh() { }

	}

	private static class Strings
	{
		public static readonly string none; //Field offset: 0x0
		public static readonly string camera; //Field offset: 0x8
		public static readonly string parameter; //Field offset: 0x10
		public static readonly string component; //Field offset: 0x18
		public static readonly string debugViewNotSupported; //Field offset: 0x20
		public static readonly string parameterNotOverrided; //Field offset: 0x28
		public static readonly string volumeInfo; //Field offset: 0x30
		public static readonly string gameObject; //Field offset: 0x38
		public static readonly string resultValue; //Field offset: 0x40
		public static readonly string resultValueTooltip; //Field offset: 0x48
		public static readonly string globalDefaultValue; //Field offset: 0x50
		public static readonly string globalDefaultValueTooltip; //Field offset: 0x58
		public static readonly string qualityLevelValue; //Field offset: 0x60
		public static readonly string qualityLevelValueTooltip; //Field offset: 0x68
		public static readonly string global; //Field offset: 0x70
		public static readonly string local; //Field offset: 0x78
		public static readonly string volumeProfile; //Field offset: 0x80

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 17)]
		private static Strings() { }

	}

	private static class Styles
	{
		public static readonly GUIContent none; //Field offset: 0x0
		public static readonly GUIContent editorCamera; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private static Styles() { }

	}

	public static class WidgetFactory
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<Object> <>9__9_2; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal object <.cctor>b__11_0() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal object <GenerateTableColumns>b__9_2() { }

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
			[CallsUnknownMethods(Count = 2)]
			internal int <CreateComponentSelector>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			internal void <CreateComponentSelector>b__1(int value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal int <CreateComponentSelector>b__2() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			internal void <CreateComponentSelector>b__3(int value) { }

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
			[CallsUnknownMethods(Count = 2)]
			internal object <CreateCameraSelector>b__0() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
			[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 3)]
			internal void <CreateCameraSelector>b__1(object value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			internal IEnumerable<Object> <CreateCameraSelector>b__2() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public DebugDisplaySettingsVolume data; //Field offset: 0x10
			public float timer; //Field offset: 0x18
			public float refreshRate; //Field offset: 0x1C
			public Table table; //Field offset: 0x20
			public Volume[] volumes; //Field offset: 0x28

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass7_0() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
			[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(WidgetFactory), Member = "SetTableColumnVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume), typeof(Table)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
			[Calls(Type = typeof(DebugManager), Member = "get_displayRuntimeUI", ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			internal bool <CreateVolumeTable>b__0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			internal bool <CreateVolumeTable>b__1() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public DebugDisplaySettingsVolume data; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass9_0() { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_1
		{
			public VolumeParameterChain chain; //Field offset: 0x10
			public <>c__DisplayClass9_0 CS$<>8__locals1; //Field offset: 0x38

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass9_1() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			internal object <GenerateTableColumns>b__0() { }

			[CallerCount(Count = 62)]
			[DeduplicatedMethod]
			internal object <GenerateTableColumns>b__1() { }

			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			internal object <GenerateTableColumns>b__3() { }

		}

		private struct VolumeParameterChain
		{
			public NameAndTooltip nameAndTooltip; //Field offset: 0x0
			public VolumeProfile volumeProfile; //Field offset: 0x10
			public VolumeComponent volumeComponent; //Field offset: 0x18
			public Volume volume; //Field offset: 0x20

		}

		private static Value s_EmptyDebugUIValue; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		private static WidgetFactory() { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		public static ObjectPopupField CreateCameraSelector(SettingsPanel panel, Action<Field`1<Object>, Object> refresh) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
		[Calls(Type = typeof(GraphicsSettings), Member = "get_currentRenderPipelineAssetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(VolumeManager), Member = "GetVolumeComponentsForDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.String, System.Type>>))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GUIContent), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIContent), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EnumField`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(EnumField`1), Member = "set_enumValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 18)]
		public static EnumField CreateComponentSelector(SettingsPanel panel, Action<Field`1<Int32>, Int32> refresh) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "GenerateTableColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(DebugDisplaySettingsVolume), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static Widget CreateVolumeParameterWidget(string name, bool isResultParameter, VolumeParameter param, Func<Boolean> isHiddenCallback = null) { }

		[CalledBy(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SettingsPanel), Member = "Refresh", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "GetResolutionChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>))]
		[Calls(Type = typeof(WidgetFactory), Member = "GenerateTableRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "GenerateTableColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(DebugDisplaySettingsVolume), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		public static Table CreateVolumeTable(DebugDisplaySettingsVolume data) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateVolumeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(Table))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Value), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObjectField), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(WidgetFactory), Member = "CreateVolumeParameterWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(VolumeParameter), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Widget))]
		[CallsDeduplicatedMethods(Count = 14)]
		[CallsUnknownMethods(Count = 22)]
		[ContainsUnimplementedInstructions]
		private static void GenerateTableColumns(Table table, DebugDisplaySettingsVolume data, List<VolumeParameterChain> resolutionChain) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateVolumeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(Table))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 11)]
		private static void GenerateTableRows(Table table, List<VolumeParameterChain> resolutionChain) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "CreateVolumeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(Table))]
		[CalledBy(Type = typeof(WidgetFactory), Member = "SetTableColumnVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume), typeof(Table)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
		[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(VolumeComponent))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Volume), Member = "HasInstantiatedProfile", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Volume), Member = "get_profile", ReturnType = typeof(VolumeProfile))]
		[Calls(Type = typeof(WidgetFactory), Member = "GetSelectedVolumeComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeProfile), typeof(Type)}, ReturnType = typeof(VolumeComponent))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 43)]
		private static List<VolumeParameterChain> GetResolutionChain(DebugDisplaySettingsVolume data) { }

		[CalledBy(Type = typeof(WidgetFactory), Member = "GetResolutionChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private static VolumeComponent GetSelectedVolumeComponent(VolumeProfile profile, Type selectedType) { }

		[CalledBy(Type = typeof(<>c__DisplayClass7_0), Member = "<CreateVolumeTable>b__0", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(WidgetFactory), Member = "GetResolutionChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory+VolumeParameterChain>))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Table), Member = "SetColumnVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		private static void SetTableColumnVisibility(DebugDisplaySettingsVolume data, Table table) { }

	}

	private const string k_PanelTitle = "Volume"; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IVolumeDebugSettings <volumeDebugSettings>k__BackingField; //Field offset: 0x10
	internal int volumeComponentEnumIndex; //Field offset: 0x18
	internal Dictionary<String, VolumeComponent> debugState; //Field offset: 0x20

	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public IVolumeDebugSettings volumeDebugSettings
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DebugDisplaySettingsVolume(IVolumeDebugSettings volumeDebugSettings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsVolume)}, ReturnType = typeof(void))]
	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_AreAnySettingsActive() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IVolumeDebugSettings get_volumeDebugSettings() { }

}

