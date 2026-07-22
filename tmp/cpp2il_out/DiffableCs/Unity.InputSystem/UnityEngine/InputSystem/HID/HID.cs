namespace UnityEngine.InputSystem.HID;

public class HID : InputDevice
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public HIDLayoutBuilder layout; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass13_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallsUnknownMethods(Count = 1)]
		internal InputControlLayout <OnFindLayoutForDevice>b__0() { }

	}

	internal enum Button
	{
		Undefined = 0,
		Primary = 1,
		Secondary = 2,
		Tertiary = 3,
	}

	internal enum GenericDesktop
	{
		Undefined = 0,
		Pointer = 1,
		Mouse = 2,
		Joystick = 4,
		Gamepad = 5,
		Keyboard = 6,
		Keypad = 7,
		MultiAxisController = 8,
		TabletPCControls = 9,
		AssistiveControl = 10,
		X = 48,
		Y = 49,
		Z = 50,
		Rx = 51,
		Ry = 52,
		Rz = 53,
		Slider = 54,
		Dial = 55,
		Wheel = 56,
		HatSwitch = 57,
		CountedBuffer = 58,
		ByteCount = 59,
		MotionWakeup = 60,
		Start = 61,
		Select = 62,
		Vx = 64,
		Vy = 65,
		Vz = 66,
		Vbrx = 67,
		Vbry = 68,
		Vbrz = 69,
		Vno = 70,
		FeatureNotification = 71,
		ResolutionMultiplier = 72,
		SystemControl = 128,
		SystemPowerDown = 129,
		SystemSleep = 130,
		SystemWakeUp = 131,
		SystemContextMenu = 132,
		SystemMainMenu = 133,
		SystemAppMenu = 134,
		SystemMenuHelp = 135,
		SystemMenuExit = 136,
		SystemMenuSelect = 137,
		SystemMenuRight = 138,
		SystemMenuLeft = 139,
		SystemMenuUp = 140,
		SystemMenuDown = 141,
		SystemColdRestart = 142,
		SystemWarmRestart = 143,
		DpadUp = 144,
		DpadDown = 145,
		DpadRight = 146,
		DpadLeft = 147,
		SystemDock = 160,
		SystemUndock = 161,
		SystemSetup = 162,
		SystemBreak = 163,
		SystemDebuggerBreak = 164,
		ApplicationBreak = 165,
		ApplicationDebuggerBreak = 166,
		SystemSpeakerMute = 167,
		SystemHibernate = 168,
		SystemDisplayInvert = 176,
		SystemDisplayInternal = 177,
		SystemDisplayExternal = 178,
		SystemDisplayBoth = 179,
		SystemDisplayDual = 180,
		SystemDisplayToggleIntExt = 181,
		SystemDisplaySwapPrimarySecondary = 182,
		SystemDisplayLCDAutoScale = 183,
	}

	internal struct HIDCollectionDescriptor
	{
		public HIDCollectionType type; //Field offset: 0x0
		public int usage; //Field offset: 0x4
		public UsagePage usagePage; //Field offset: 0x8
		public int parent; //Field offset: 0xC
		public int childCount; //Field offset: 0x10
		public int firstChild; //Field offset: 0x14

	}

	internal enum HIDCollectionType
	{
		Physical = 0,
		Application = 1,
		Logical = 2,
		Report = 3,
		NamedArray = 4,
		UsageSwitch = 5,
		UsageModifier = 6,
	}

	internal struct HIDDeviceDescriptor
	{
		public int vendorId; //Field offset: 0x0
		public int productId; //Field offset: 0x4
		public int usage; //Field offset: 0x8
		public UsagePage usagePage; //Field offset: 0xC
		public int inputReportSize; //Field offset: 0x10
		public int outputReportSize; //Field offset: 0x14
		public int featureReportSize; //Field offset: 0x18
		public HIDElementDescriptor[] elements; //Field offset: 0x20
		public HIDCollectionDescriptor[] collections; //Field offset: 0x28

		[CalledBy(Type = typeof(HID), Member = "ReadHIDDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(HIDDeviceDescriptor))]
		[CalledBy(Type = typeof(DualShockGamepad), Member = "FinishSetup", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDDeviceDescriptor)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
		[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.HID.HID+HIDElementDescriptor>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PredictiveParser), Member = "AcceptInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PredictiveParser), Member = "ExpectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
		[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(PredictiveParser), Member = "AcceptSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PredictiveParser), Member = "ExpectInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(PredictiveParser), Member = "AcceptString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(ReadOnlySpan`1<Char>&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PredictiveParser), Member = "ExpectSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public static HIDDeviceDescriptor FromJson(string json) { }

		[CalledBy(Type = typeof(HID), Member = "ReadHIDDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(HIDDeviceDescriptor))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
		public string ToJson() { }

	}

	internal struct HIDDeviceDescriptorBuilder
	{
		public UsagePage usagePage; //Field offset: 0x0
		public int usage; //Field offset: 0x4
		private int m_CurrentReportId; //Field offset: 0x8
		private HIDReportType m_CurrentReportType; //Field offset: 0xC
		private int m_CurrentReportOffsetInBits; //Field offset: 0x10
		private List<HIDElementDescriptor> m_Elements; //Field offset: 0x18
		private List<HIDCollectionDescriptor> m_Collections; //Field offset: 0x20
		private int m_InputReportSize; //Field offset: 0x28
		private int m_OutputReportSize; //Field offset: 0x2C
		private int m_FeatureReportSize; //Field offset: 0x30

		[CallerCount(Count = 0)]
		public HIDDeviceDescriptorBuilder(UsagePage usagePage, int usage) { }

		[CallerCount(Count = 0)]
		public HIDDeviceDescriptorBuilder(GenericDesktop usage) { }

		[CalledBy(Type = typeof(HIDDeviceDescriptorBuilder), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenericDesktop), typeof(int)}, ReturnType = typeof(HIDDeviceDescriptorBuilder))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.InputSystem.HID.HID+HIDElementDescriptor>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HIDDeviceDescriptorBuilder), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsagePage), typeof(int), typeof(int)}, ReturnType = typeof(HIDDeviceDescriptorBuilder))]
		public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[CallsUnknownMethods(Count = 2)]
		public HIDDeviceDescriptor Finish() { }

		[CallerCount(Count = 0)]
		public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId = 1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.HID.HID+HIDElementDescriptor>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HIDElementDescriptor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.HID.HID+HIDElementDescriptor>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HIDElementDescriptor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max) { }

	}

	internal struct HIDElementDescriptor
	{
		public int usage; //Field offset: 0x0
		public UsagePage usagePage; //Field offset: 0x4
		public int unit; //Field offset: 0x8
		public int unitExponent; //Field offset: 0xC
		public int logicalMin; //Field offset: 0x10
		public int logicalMax; //Field offset: 0x14
		public int physicalMin; //Field offset: 0x18
		public int physicalMax; //Field offset: 0x1C
		public HIDReportType reportType; //Field offset: 0x20
		public int collectionIndex; //Field offset: 0x24
		public int reportId; //Field offset: 0x28
		public int reportSizeInBits; //Field offset: 0x2C
		public int reportOffsetInBits; //Field offset: 0x30
		public HIDElementFlags flags; //Field offset: 0x34
		public Nullable<Int32> usageMin; //Field offset: 0x38
		public Nullable<Int32> usageMax; //Field offset: 0x40

		public bool hasNullState
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		public bool hasPreferredState
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 11
		}

		public bool isArray
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 10
		}

		public bool isConstant
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 7
		}

		public bool isNonLinear
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		public bool isRelative
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		internal bool isSigned
		{
			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			internal get { } //Length: 7
		}

		public bool isWrapping
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
		}

		internal float maxFloatValue
		{
			[CalledBy(Type = typeof(HIDElementDescriptor), Member = "DetermineAxisNormalizationParameters", ReturnType = typeof(string))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 211
		}

		internal float minFloatValue
		{
			[CalledBy(Type = typeof(HIDElementDescriptor), Member = "DetermineAxisNormalizationParameters", ReturnType = typeof(string))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 211
		}

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineDefaultState", ReturnType = typeof(PrimitiveValue))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Builder), Member = "AddControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(PrimitiveValue), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithBitOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithSizeInBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 18)]
		internal void AddChildControls(ref HIDElementDescriptor element, string controlName, ref Builder builder) { }

		[CalledBy(Type = typeof(HIDElementDescriptor), Member = "DetermineParameters", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "get_minFloatValue", ReturnType = typeof(float))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "get_maxFloatValue", ReturnType = typeof(float))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		private string DetermineAxisNormalizationParameters() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal PrimitiveValue DetermineDefaultState() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		internal string DetermineDisplayName() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 3)]
		internal FourCC DetermineFormat() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(HIDElementDescriptor), Member = "IsUsableElement", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal string DetermineLayout() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal string DetermineName() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineAxisNormalizationParameters", ReturnType = typeof(string))]
		[Calls(Type = typeof(StringHelpers), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValue[]"}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 5)]
		internal string DetermineParameters() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 3)]
		internal string DetermineProcessors() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		internal InternedString[] DetermineUsages() { }

		[CallerCount(Count = 0)]
		public bool get_hasNullState() { }

		[CallerCount(Count = 0)]
		public bool get_hasPreferredState() { }

		[CallerCount(Count = 0)]
		public bool get_isArray() { }

		[CallerCount(Count = 0)]
		public bool get_isConstant() { }

		[CallerCount(Count = 0)]
		public bool get_isNonLinear() { }

		[CallerCount(Count = 0)]
		public bool get_isRelative() { }

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		internal bool get_isSigned() { }

		[CallerCount(Count = 0)]
		public bool get_isWrapping() { }

		[CalledBy(Type = typeof(HIDElementDescriptor), Member = "DetermineAxisNormalizationParameters", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal float get_maxFloatValue() { }

		[CalledBy(Type = typeof(HIDElementDescriptor), Member = "DetermineAxisNormalizationParameters", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal float get_minFloatValue() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		public bool Is(UsagePage usagePage, int usage) { }

		[CalledBy(Type = typeof(HID), Member = "OnFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(string), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineLayout", ReturnType = typeof(string))]
		[ContainsUnimplementedInstructions]
		internal bool IsUsableElement() { }

	}

	[Flags]
	internal enum HIDElementFlags
	{
		Constant = 1,
		Variable = 2,
		Relative = 4,
		Wrap = 8,
		NonLinear = 16,
		NoPreferred = 32,
		NullState = 64,
		Volatile = 128,
		BufferedBytes = 256,
	}

	private class HIDLayoutBuilder
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Predicate<HIDElementDescriptor> <>9__4_0; //Field offset: 0x8
			public static Predicate<HIDElementDescriptor> <>9__4_1; //Field offset: 0x10
			public static Func<ControlItem, String> <>9__4_2; //Field offset: 0x18

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal bool <Build>b__4_0(HIDElementDescriptor element) { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal bool <Build>b__4_1(HIDElementDescriptor element) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			internal string <Build>b__4_2(ControlItem x) { }

		}

		public string displayName; //Field offset: 0x10
		public HIDDeviceDescriptor hidDescriptor; //Field offset: 0x18
		public string parentLayout; //Field offset: 0x48
		public Type deviceType; //Field offset: 0x50

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public HIDLayoutBuilder() { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+<>c__DisplayClass13_0", Member = "<OnFindLayoutForDevice>b__0", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineDefaultState", ReturnType = typeof(PrimitiveValue))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineUsages", ReturnType = typeof(InternedString[]))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineDisplayName", ReturnType = typeof(string))]
		[Calls(Type = typeof(StringHelpers), Member = "MakeUniqueName", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(System.Func`2<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem, System.String>)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Func`2<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Builder), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineName", ReturnType = typeof(string))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineLayout", ReturnType = typeof(string))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "Is", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsagePage), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StringHelpers), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValue[]"}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithProcessors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineProcessors", ReturnType = typeof(string))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithDefaultState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrimitiveValue)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineFormat", ReturnType = typeof(FourCC))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "DetermineParameters", ReturnType = typeof(string))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString[])}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithSizeInBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithByteOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithBitOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(ControlBuilder), Member = "WithDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(Builder), Member = "AddControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
		[Calls(Type = typeof(Array), Member = "Find", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor[]), typeof(System.Predicate`1<UnityEngine.InputSystem.HID.HID+HIDElementDescriptor>)}, ReturnType = typeof(HIDElementDescriptor))]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Builder), Member = "set_extendsLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Builder), Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 18)]
		[ContainsUnimplementedInstructions]
		public InputControlLayout Build() { }

	}

	internal enum HIDReportType
	{
		Unknown = 0,
		Input = 1,
		Output = 2,
		Feature = 3,
	}

	internal enum Simulation
	{
		Undefined = 0,
		FlightSimulationDevice = 1,
		AutomobileSimulationDevice = 2,
		TankSimulationDevice = 3,
		SpaceshipSimulationDevice = 4,
		SubmarineSimulationDevice = 5,
		SailingSimulationDevice = 6,
		MotorcycleSimulationDevice = 7,
		SportsSimulationDevice = 8,
		AirplaneSimulationDevice = 9,
		HelicopterSimulationDevice = 10,
		MagicCarpetSimulationDevice = 11,
		BicylcleSimulationDevice = 12,
		FlightControlStick = 32,
		FlightStick = 33,
		CyclicControl = 34,
		CyclicTrim = 35,
		FlightYoke = 36,
		TrackControl = 37,
		Aileron = 176,
		AileronTrim = 177,
		AntiTorqueControl = 178,
		AutopilotEnable = 179,
		ChaffRelease = 180,
		CollectiveControl = 181,
		DiveBreak = 182,
		ElectronicCountermeasures = 183,
		Elevator = 184,
		ElevatorTrim = 185,
		Rudder = 186,
		Throttle = 187,
		FlightCommunications = 188,
		FlareRelease = 189,
		LandingGear = 190,
		ToeBreak = 191,
		Trigger = 192,
		WeaponsArm = 193,
		WeaponsSelect = 194,
		WingFlaps = 195,
		Accelerator = 196,
		Brake = 197,
		Clutch = 198,
		Shifter = 199,
		Steering = 200,
		TurretDirection = 201,
		BarrelElevation = 202,
		DivePlane = 203,
		Ballast = 204,
		BicycleCrank = 205,
		HandleBars = 206,
		FrontBrake = 207,
		RearBrake = 208,
	}

	internal enum UsagePage
	{
		Undefined = 0,
		GenericDesktop = 1,
		Simulation = 2,
		VRControls = 3,
		SportControls = 4,
		GameControls = 5,
		GenericDeviceControls = 6,
		Keyboard = 7,
		LEDs = 8,
		Button = 9,
		Ordinal = 10,
		Telephony = 11,
		Consumer = 12,
		Digitizer = 13,
		PID = 15,
		Unicode = 16,
		AlphanumericDisplay = 20,
		MedicalInstruments = 64,
		Monitor = 128,
		Power = 132,
		BarCodeScanner = 140,
		MagneticStripeReader = 142,
		Camera = 144,
		Arcade = 145,
		VendorDefined = 65280,
	}

	internal const string kHIDInterface = "HID"; //Field offset: 0x0
	internal const string kHIDNamespace = "HID"; //Field offset: 0x0
	private static readonly ProfilerMarker k_HIDParseDescriptorFallback; //Field offset: 0x0
	private bool m_HaveParsedHIDDescriptor; //Field offset: 0x190
	private HIDDeviceDescriptor m_HIDDescriptor; //Field offset: 0x198

	public HIDDeviceDescriptor hidDescriptor
	{
		[CalledBy(Type = typeof(HIDSupport), Member = "set_supportedHIDUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDDeviceDescriptor)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public static FourCC QueryHIDReportDescriptorDeviceCommandType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static HID() { }

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public HID() { }

	[CalledBy(Type = typeof(HIDSupport), Member = "set_supportedHIDUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDDeviceDescriptor)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallsUnknownMethods(Count = 1)]
	public HIDDeviceDescriptor get_hidDescriptor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_QueryHIDReportDescriptorDeviceCommandType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "RegisterLayoutBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>), typeof(string), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "WithCapability", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValue"}, ReturnType = typeof(InputDeviceMatcher))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "FromDeviceDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InputDeviceMatcher))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(HIDElementDescriptor), Member = "IsUsableElement", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDPageUsage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>), typeof(HIDPageUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HIDSupport), Member = "get_supportedHIDUsages", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>))]
	[Calls(Type = typeof(HID), Member = "ReadHIDDeviceDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 31)]
	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	[CalledBy(Type = typeof(HID), Member = "OnFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(string), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HIDDeviceDescriptor), Member = "ToJson", ReturnType = typeof(string))]
	[Calls(Type = typeof(HIDParser), Member = "ParseReportDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(HIDDeviceDescriptor&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceCommand), Member = "get_payloadPtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputDeviceCommand), Member = "AllocateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HIDDeviceDescriptor), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 19)]
	internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	public static string UsagePageToString(UsagePage usagePage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	public static string UsageToString(UsagePage usagePage, int usage) { }

}

