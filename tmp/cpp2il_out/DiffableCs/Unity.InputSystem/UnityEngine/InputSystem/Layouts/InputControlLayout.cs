namespace UnityEngine.InputSystem.Layouts;

[DefaultMember("Item")]
public class InputControlLayout
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, InternedString> <>9__52_0; //Field offset: 0x8
		public static Func<String, InternedString> <>9__75_0; //Field offset: 0x10
		public static Func<String, InternedString> <>9__75_1; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal InternedString <CreateControlItemFromMember>b__75_0(string x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal InternedString <CreateControlItemFromMember>b__75_1(string x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal InternedString <FromType>b__52_0(string x) { }

	}

	internal class Builder
	{
		internal struct ControlBuilder
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x0
				public static Func<String, InternedString> <>9__14_0; //Field offset: 0x8

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				private static <>c() { }

				[CallerCount(Count = 2180)]
				[CallsDeduplicatedMethods(Count = 1)]
				[DeduplicatedMethod]
				public <>c() { }

				[CallerCount(Count = 0)]
				[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[DeduplicatedMethod]
				internal InternedString <WithUsages>b__14_0(string x) { }

			}

			internal Builder builder; //Field offset: 0x0
			internal int index; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder AsArrayOfControlsWithSize(int arraySize) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder DontReset(bool value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder IsNoisy(bool value) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder IsSynthetic(bool value) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 3)]
			public ControlBuilder UsingStateFrom(string path) { }

			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 8)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder WithBitOffset(uint bit) { }

			[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CallerCount(Count = 13)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder WithByteOffset(uint offset) { }

			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder WithDefaultState(PrimitiveValue value) { }

			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 3)]
			public ControlBuilder WithDisplayName(string displayName) { }

			[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 13)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder WithFormat(FourCC format) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder WithFormat(string format) { }

			[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 17)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 8)]
			public ControlBuilder WithLayout(string layout) { }

			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 11)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(NamedValue), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NamedValue[]))]
			[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			public ControlBuilder WithParameters(string parameters) { }

			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(NameAndParameters), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>))]
			[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndParameters)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>)}, ReturnType = typeof(NameAndParameters[]))]
			[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			public ControlBuilder WithProcessors(string processors) { }

			[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder WithRange(float minValue, float maxValue) { }

			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 8)]
			[CallsUnknownMethods(Count = 2)]
			public ControlBuilder WithSizeInBits(uint sizeInBits) { }

			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = typeof(ControlBuilder), Member = "WithUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(ControlBuilder))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
			[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 14)]
			public ControlBuilder WithUsages(InternedString[] usages) { }

			[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = typeof(ControlBuilder), Member = "WithUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(ControlBuilder))]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
			[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(InternedString[]))]
			[Calls(Type = typeof(ControlBuilder), Member = "WithUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString[])}, ReturnType = typeof(ControlBuilder))]
			[CallsUnknownMethods(Count = 1)]
			public ControlBuilder WithUsages(IEnumerable<String> usages) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ControlBuilder), Member = "WithUsages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(ControlBuilder))]
			public ControlBuilder WithUsages(String[] usages) { }

		}

		[CompilerGenerated]
		private string <name>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <displayName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private Type <type>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private FourCC <stateFormat>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private int <stateSizeInBytes>k__BackingField; //Field offset: 0x2C
		private string m_ExtendsLayout; //Field offset: 0x30
		[CompilerGenerated]
		private Nullable<Boolean> <updateBeforeRender>k__BackingField; //Field offset: 0x38
		private int m_ControlCount; //Field offset: 0x3C
		private ControlItem[] m_Controls; //Field offset: 0x40

		public ReadOnlyArray<ControlItem> controls
		{
			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 95
		}

		public string displayName
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

		public string extendsLayout
		{
			[CallerCount(Count = 62)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			 set { } //Length: 57
		}

		public string name
		{
			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public FourCC stateFormat
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

		public int stateSizeInBytes
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public Type type
		{
			[CallerCount(Count = 12)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 10)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public Nullable<Boolean> updateBeforeRender
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 set { } //Length: 5
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Builder() { }

		[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArrayHelpers), Member = "AppendWithCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem[]&), typeof(Int32&), typeof(ControlItem), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public ControlBuilder AddControl(string name) { }

		[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(InlinedArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		public InputControlLayout Build() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public Builder Extend(string baseLayoutName) { }

		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ReadOnlyArray<ControlItem> get_controls() { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_displayName() { }

		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		public string get_extendsLayout() { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_name() { }

		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public FourCC get_stateFormat() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_stateSizeInBytes() { }

		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Type get_type() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public Nullable<Boolean> get_updateBeforeRender() { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_displayName(string value) { }

		[CalledBy(Type = typeof(XRLayoutBuilder), Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDLayoutBuilder", Member = "Build", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public void set_extendsLayout(string value) { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_name(string value) { }

		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_stateFormat(FourCC value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_stateSizeInBytes(int value) { }

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_type(Type value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public void set_updateBeforeRender(Nullable<Boolean> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Builder WithDisplayName(string displayName) { }

		[CallerCount(Count = 0)]
		public Builder WithFormat(FourCC format) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		public Builder WithFormat(string format) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Builder WithName(string name) { }

		[CallerCount(Count = 0)]
		public Builder WithSizeInBytes(int sizeInBytes) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public Builder WithType() { }

	}

	public struct Cache
	{
		public Dictionary<InternedString, InputControlLayout> table; //Field offset: 0x0

		[CallerCount(Count = 66)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Clear() { }

		[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Collection), Member = "FindLayoutThatIntroducesControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Cache)}, ReturnType = typeof(InternedString))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InputDeviceDescription)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Intern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
		[Calls(Type = typeof(LayoutNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true) { }

	}

	public struct CacheRefInstance : IDisposable
	{
		public bool valid; //Field offset: 0x0

		[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(RefInstance), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		public override void Dispose() { }

	}

	public struct Collection
	{
		[CompilerGenerated]
		private sealed class <GetBaseLayouts>d__24 : IEnumerable<InternedString>, IEnumerable, IEnumerator<InternedString>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private InternedString <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x28
			private bool includeSelf; //Field offset: 0x2C
			public bool <>3__includeSelf; //Field offset: 0x2D
			private InternedString layout; //Field offset: 0x30
			public InternedString <>3__layout; //Field offset: 0x40
			public Collection <>4__this; //Field offset: 0x50
			public Collection <>3__<>4__this; //Field offset: 0x90

			private override InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.Current
			{
				[CallerCount(Count = 0)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[DebuggerHidden]
				private get { } //Length: 69
			}

			[CallerCount(Count = 5)]
			[CallsDeduplicatedMethods(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			public <GetBaseLayouts>d__24(int <>1__state) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 3)]
			private override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 3)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override IEnumerator<InternedString> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator() { }

			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 3)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[CallerCount(Count = 13327)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void System.IDisposable.Dispose() { }

		}

		internal struct LayoutMatcher
		{
			public InternedString layoutName; //Field offset: 0x0
			public InputDeviceMatcher deviceMatcher; //Field offset: 0x10

		}

		internal struct PrecompiledLayout
		{
			public Func<InputDevice> factoryMethod; //Field offset: 0x0
			public string metadata; //Field offset: 0x8

		}

		public const float kBaseScoreForNonGeneratedLayouts = 1; //Field offset: 0x0
		public Dictionary<InternedString, Type> layoutTypes; //Field offset: 0x0
		public Dictionary<InternedString, String> layoutStrings; //Field offset: 0x8
		public Dictionary<InternedString, Func`1<InputControlLayout>> layoutBuilders; //Field offset: 0x10
		public Dictionary<InternedString, InternedString> baseLayoutTable; //Field offset: 0x18
		public Dictionary<InternedString, InternedString[]> layoutOverrides; //Field offset: 0x20
		public HashSet<InternedString> layoutOverrideNames; //Field offset: 0x28
		public Dictionary<InternedString, PrecompiledLayout> precompiledLayouts; //Field offset: 0x30
		public List<LayoutMatcher> layoutMatchers; //Field offset: 0x38

		[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(InputDeviceMatcher), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher), typeof(InputDeviceMatcher)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public void AddMatcher(InternedString layout, InputDeviceMatcher matcher) { }

		[CalledBy(Type = typeof(InputManager), Member = "InitializeData", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<UnityEngine.InputSystem.Utilities.InternedString>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		public void Allocate() { }

		[CalledBy(Type = typeof(InputControlScheme), Member = "PickDevicesFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDevices", typeof(InputDevice)}, ReturnType = typeof(MatchResult))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InternedString), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance) { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "GeneratePathForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Cache), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputControlLayout))]
		[Calls(Type = typeof(InputControlLayout), Member = "FindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public InternedString FindLayoutThatIntroducesControl(InputControl control, Cache cache) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public InternedString GetBaseLayoutName(InternedString layoutName) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[IteratorStateMachine(typeof(<GetBaseLayouts>d__24))]
		public IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true) { }

		[CalledBy(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
		[CalledBy(Type = typeof(Collection), Member = "ValueTypeIsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Type)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public Type GetControlTypeForLayout(InternedString layoutName) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public InternedString GetRootLayoutName(InternedString layoutName) { }

		[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayoutBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReplayController), Member = "ApplyDeviceMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputControlLayout), Member = "InferLayoutFromValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool HasLayout(InternedString name) { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystem), Member = "IsFirstLayoutBasedOnSecond", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager+<ListControlLayouts>d__100", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputManager), Member = "IsDeviceLayoutMarkedAsSupportedInSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool IsBasedOn(InternedString parentLayout, InternedString childLayout) { }

		[CalledBy(Type = typeof(InputRemoting), Member = "SendLayoutChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputControlLayoutChange)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public bool IsGeneratedLayout(InternedString layout) { }

		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "DeviceTypeToControlPath", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputDevice), Member = "Build", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(InputDeviceDescription), typeof(bool)}, ReturnType = "TDevice")]
		[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayoutMatcher", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "TryLoadControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(InputManager), Member = "FindOrRegisterDeviceLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
		[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(InputDevice))]
		[CalledBy(Type = typeof(InputManager), Member = "TryGetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputDevice))]
		[CalledBy(Type = typeof(InputControlLayout), Member = "InferLayoutFromValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		public InternedString TryFindLayoutForType(Type layoutType) { }

		[CalledBy(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(InputDeviceMatcher), Member = "MatchPercentage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewLayoutMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputRemoting+Message>))]
		[CalledBy(Type = typeof(InputManager), Member = "TryLoadControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(InputManager), Member = "TryLoadControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(Cache), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlinedArray`1), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(InlinedArray`1), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputControlLayout), Member = "MergeLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<UnityEngine.InputSystem.Utilities.InternedString>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LayoutNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Collection), Member = "TryLoadLayoutInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(InputControlLayout))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
		[CallsUnknownMethods(Count = 11)]
		public InputControlLayout TryLoadLayout(InternedString name, Dictionary<InternedString, InputControlLayout> table = null) { }

		[CalledBy(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputControlLayout), Member = "FromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(InputControlLayout))]
		[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson", Member = "ToLayout", ReturnType = typeof(InputControlLayout))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private InputControlLayout TryLoadLayoutInternal(InternedString name) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Collection), Member = "GetControlTypeForLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeHelpers), Member = "GetGenericTypeArgumentFromHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(int)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public bool ValueTypeIsAssignableFrom(InternedString layoutName, Type valueType) { }

	}

	internal struct ControlItem
	{
		[Flags]
		private enum Flags
		{
			isModifyingExistingControl = 1,
			IsNoisy = 2,
			IsSynthetic = 4,
			IsFirstDefinedInThisLayout = 8,
			DontReset = 16,
		}

		[CompilerGenerated]
		private InternedString <name>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private InternedString <layout>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private InternedString <variants>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private string <useStateFrom>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private string <displayName>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private string <shortDisplayName>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private ReadOnlyArray<InternedString> <usages>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private ReadOnlyArray<InternedString> <aliases>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private ReadOnlyArray<NamedValue> <parameters>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private ReadOnlyArray<NameAndParameters> <processors>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private uint <offset>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		private uint <bit>k__BackingField; //Field offset: 0x8C
		[CompilerGenerated]
		private uint <sizeInBits>k__BackingField; //Field offset: 0x90
		[CompilerGenerated]
		private FourCC <format>k__BackingField; //Field offset: 0x94
		[CompilerGenerated]
		private Flags <flags>k__BackingField; //Field offset: 0x98
		[CompilerGenerated]
		private int <arraySize>k__BackingField; //Field offset: 0x9C
		[CompilerGenerated]
		private PrimitiveValue <defaultState>k__BackingField; //Field offset: 0xA0
		[CompilerGenerated]
		private PrimitiveValue <minValue>k__BackingField; //Field offset: 0xB0
		[CompilerGenerated]
		private PrimitiveValue <maxValue>k__BackingField; //Field offset: 0xC0

		public internal ReadOnlyArray<InternedString> aliases
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			internal set { } //Length: 18
		}

		public internal int arraySize
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			internal set { } //Length: 7
		}

		public internal uint bit
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 7
		}

		public internal PrimitiveValue defaultState
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 14
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			internal set { } //Length: 11
		}

		public internal string displayName
		{
			[CallerCount(Count = 38)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 5
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 13
		}

		public internal bool dontReset
		{
			[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
			[CallerCount(Count = 1)]
			 get { } //Length: 12
			[CallerCount(Count = 0)]
			internal set { } //Length: 31
		}

		private Flags flags
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			private get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 7
		}

		public internal FourCC format
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 7
		}

		public bool isArray
		{
			[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 11
		}

		public internal bool isFirstDefinedInThisLayout
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			internal set { } //Length: 31
		}

		public internal bool isModifyingExistingControl
		{
			[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			 get { } //Length: 10
			[CallerCount(Count = 0)]
			internal set { } //Length: 31
		}

		public internal bool isNoisy
		{
			[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
			[CallerCount(Count = 1)]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			internal set { } //Length: 31
		}

		public internal bool isSynthetic
		{
			[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
			[CallerCount(Count = 1)]
			 get { } //Length: 12
			[CallerCount(Count = 0)]
			internal set { } //Length: 31
		}

		public internal InternedString layout
		{
			[CallerCount(Count = 17)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 18
		}

		public internal PrimitiveValue maxValue
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 14
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			internal set { } //Length: 11
		}

		public internal PrimitiveValue minValue
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 14
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			internal set { } //Length: 11
		}

		public internal InternedString name
		{
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 10
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 13
		}

		public internal uint offset
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 7
		}

		public internal ReadOnlyArray<NamedValue> parameters
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			internal set { } //Length: 18
		}

		public internal ReadOnlyArray<NameAndParameters> processors
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			internal set { } //Length: 18
		}

		public internal string shortDisplayName
		{
			[CallerCount(Count = 12)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 13
		}

		public internal uint sizeInBits
		{
			[CallerCount(Count = 33)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 7
		}

		public internal ReadOnlyArray<InternedString> usages
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			internal set { } //Length: 18
		}

		public internal string useStateFrom
		{
			[CallerCount(Count = 62)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 13
		}

		public internal InternedString variants
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			internal set { } //Length: 18
		}

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public ReadOnlyArray<InternedString> get_aliases() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_arraySize() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public uint get_bit() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[IsReadOnly]
		public PrimitiveValue get_defaultState() { }

		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public string get_displayName() { }

		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 1)]
		public bool get_dontReset() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		private Flags get_flags() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public FourCC get_format() { }

		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		public bool get_isArray() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_isFirstDefinedInThisLayout() { }

		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		public bool get_isModifyingExistingControl() { }

		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 1)]
		public bool get_isNoisy() { }

		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 1)]
		public bool get_isSynthetic() { }

		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public InternedString get_layout() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[IsReadOnly]
		public PrimitiveValue get_maxValue() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[IsReadOnly]
		public PrimitiveValue get_minValue() { }

		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public InternedString get_name() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public uint get_offset() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public ReadOnlyArray<NamedValue> get_parameters() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public ReadOnlyArray<NameAndParameters> get_processors() { }

		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public string get_shortDisplayName() { }

		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public uint get_sizeInBits() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public ReadOnlyArray<InternedString> get_usages() { }

		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public string get_useStateFrom() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public InternedString get_variants() { }

		[CalledBy(Type = typeof(InputControlLayout), Member = "MergeLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InsertChildControlOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 12)]
		public ControlItem Merge(ControlItem other) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal void set_aliases(ReadOnlyArray<InternedString> value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal void set_arraySize(int value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_bit(uint value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal void set_defaultState(PrimitiveValue value) { }

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_displayName(string value) { }

		[CallerCount(Count = 0)]
		internal void set_dontReset(bool value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_flags(Flags value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_format(FourCC value) { }

		[CallerCount(Count = 0)]
		internal void set_isFirstDefinedInThisLayout(bool value) { }

		[CallerCount(Count = 0)]
		internal void set_isModifyingExistingControl(bool value) { }

		[CallerCount(Count = 0)]
		internal void set_isNoisy(bool value) { }

		[CallerCount(Count = 0)]
		internal void set_isSynthetic(bool value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_layout(InternedString value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal void set_maxValue(PrimitiveValue value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal void set_minValue(PrimitiveValue value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_name(InternedString value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_offset(uint value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal void set_parameters(ReadOnlyArray<NamedValue> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal void set_processors(ReadOnlyArray<NameAndParameters> value) { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_shortDisplayName(string value) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_sizeInBits(uint value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal void set_usages(ReadOnlyArray<InternedString> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_useStateFrom(string value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		internal void set_variants(InternedString value) { }

	}

	private class ControlItemJson
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<String, InternedString> <>9__24_0; //Field offset: 0x8
			public static Func<String, InternedString> <>9__24_1; //Field offset: 0x10
			public static Func<NamedValue, String> <>9__25_0; //Field offset: 0x18
			public static Func<NameAndParameters, String> <>9__25_1; //Field offset: 0x20
			public static Func<InternedString, String> <>9__25_2; //Field offset: 0x28
			public static Func<InternedString, String> <>9__25_3; //Field offset: 0x30

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NamedValue), Member = "ToString", ReturnType = typeof(string))]
			[DeduplicatedMethod]
			internal string <FromControlItems>b__25_0(NamedValue x) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NameAndParameters), Member = "ToString", ReturnType = typeof(string))]
			[DeduplicatedMethod]
			internal string <FromControlItems>b__25_1(NameAndParameters x) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal string <FromControlItems>b__25_2(InternedString x) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal string <FromControlItems>b__25_3(InternedString x) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			internal InternedString <ToLayout>b__24_0(string x) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			internal InternedString <ToLayout>b__24_1(string x) { }

		}

		public string name; //Field offset: 0x10
		public string layout; //Field offset: 0x18
		public string variants; //Field offset: 0x20
		public string usage; //Field offset: 0x28
		public string alias; //Field offset: 0x30
		public string useStateFrom; //Field offset: 0x38
		public uint offset; //Field offset: 0x40
		public uint bit; //Field offset: 0x44
		public uint sizeInBits; //Field offset: 0x48
		public string format; //Field offset: 0x50
		public int arraySize; //Field offset: 0x58
		public String[] usages; //Field offset: 0x60
		public String[] aliases; //Field offset: 0x68
		public string parameters; //Field offset: 0x70
		public string processors; //Field offset: 0x78
		public string displayName; //Field offset: 0x80
		public string shortDisplayName; //Field offset: 0x88
		public bool noisy; //Field offset: 0x90
		public bool dontReset; //Field offset: 0x91
		public bool synthetic; //Field offset: 0x92
		public string defaultState; //Field offset: 0x98
		public string minValue; //Field offset: 0xA0
		public string maxValue; //Field offset: 0xA8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ControlItemJson() { }

		[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson", Member = "FromLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FourCC), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(PrimitiveValue), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 25)]
		[ContainsUnimplementedInstructions]
		public static ControlItemJson[] FromControlItems(ControlItem[] items) { }

		[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson", Member = "ToLayout", ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PrimitiveValue), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PrimitiveValue))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndParameters)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>)}, ReturnType = typeof(NameAndParameters[]))]
		[Calls(Type = typeof(NameAndParameters), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>))]
		[Calls(Type = typeof(NamedValue), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NamedValue[]))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(InternedString[]))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 18)]
		public ControlItem ToLayout() { }

	}

	[Flags]
	private enum Flags
	{
		IsGenericTypeOfDevice = 1,
		HideInUI = 2,
		IsOverride = 4,
		CanRunInBackground = 8,
		CanRunInBackgroundIsSet = 16,
		IsNoisy = 32,
	}

	private struct LayoutJson
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<String, InternedString> <>9__14_0; //Field offset: 0x8
			public static Func<InternedString, String> <>9__15_0; //Field offset: 0x10
			public static Func<InternedString, String> <>9__15_1; //Field offset: 0x18

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal string <FromLayout>b__15_0(InternedString x) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal string <FromLayout>b__15_1(InternedString x) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[DeduplicatedMethod]
			internal InternedString <ToLayout>b__14_0(string x) { }

		}

		public string name; //Field offset: 0x0
		public string extend; //Field offset: 0x8
		public String[] extendMultiple; //Field offset: 0x10
		public string format; //Field offset: 0x18
		public string beforeRender; //Field offset: 0x20
		public string runInBackground; //Field offset: 0x28
		public String[] commonUsages; //Field offset: 0x30
		public string displayName; //Field offset: 0x38
		public string description; //Field offset: 0x40
		public string type; //Field offset: 0x48
		public string variant; //Field offset: 0x50
		public bool isGenericTypeOfDevice; //Field offset: 0x58
		public bool hideInUI; //Field offset: 0x59
		public ControlItemJson[] controls; //Field offset: 0x60

		[CalledBy(Type = typeof(InputControlLayout), Member = "ToJson", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InlinedArray`1), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOther"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TValue, TOther>"}, ReturnType = "TOther[]")]
		[Calls(Type = typeof(FourCC), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(ArrayHelpers), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOld", "TNew"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TOld[]", "System.Func`2<TOld, TNew>"}, ReturnType = "TNew[]")]
		[Calls(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson", Member = "FromControlItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem[])}, ReturnType = typeof(ControlItemJson[]))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 14)]
		[ContainsUnimplementedInstructions]
		public static LayoutJson FromLayout(InputControlLayout layout) { }

		[CalledBy(Type = typeof(Collection), Member = "TryLoadLayoutInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(InputControlLayout), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson", Member = "ToLayout", ReturnType = typeof(ControlItem))]
		[Calls(Type = typeof(InputControlLayout), Member = "set_canRunInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[Calls(Type = typeof(InlinedArray`1), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayHelpers), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InternedString)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Func`2<System.Object, UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(InternedString[]))]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 50)]
		public InputControlLayout ToLayout() { }

	}

	public struct LayoutJsonNameAndDescriptorOnly
	{
		public string name; //Field offset: 0x0
		public string extend; //Field offset: 0x8
		public String[] extendMultiple; //Field offset: 0x10
		public MatcherJson device; //Field offset: 0x18

	}

	internal class LayoutNotFoundException : Exception
	{
		[CompilerGenerated]
		private readonly string <layout>k__BackingField; //Field offset: 0x90

		public string layout
		{
			[CallerCount(Count = 57)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		public LayoutNotFoundException() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public LayoutNotFoundException(string name, string message) { }

		[CalledBy(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(Cache), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public LayoutNotFoundException(string name) { }

		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		public LayoutNotFoundException(string message, Exception innerException) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		protected LayoutNotFoundException(SerializationInfo info, StreamingContext context) { }

		[CallerCount(Count = 57)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public string get_layout() { }

	}

	private static InternedString s_DefaultVariant; //Field offset: 0x0
	public const string VariantSeparator = ";"; //Field offset: 0x0
	internal static Collection s_Layouts; //Field offset: 0x10
	internal static Cache s_CacheInstance; //Field offset: 0x50
	internal static int s_CacheInstanceRef; //Field offset: 0x58
	private InternedString m_Name; //Field offset: 0x10
	private Type m_Type; //Field offset: 0x20
	private InternedString m_Variants; //Field offset: 0x28
	private FourCC m_StateFormat; //Field offset: 0x38
	internal int m_StateSizeInBytes; //Field offset: 0x3C
	internal Nullable<Boolean> m_UpdateBeforeRender; //Field offset: 0x40
	internal InlinedArray<InternedString> m_BaseLayouts; //Field offset: 0x48
	private InlinedArray<InternedString> m_AppliedOverrides; //Field offset: 0x68
	private InternedString[] m_CommonUsages; //Field offset: 0x88
	internal ControlItem[] m_Controls; //Field offset: 0x90
	internal string m_DisplayName; //Field offset: 0x98
	private string m_Description; //Field offset: 0xA0
	private Flags m_Flags; //Field offset: 0xA8

	public IEnumerable<InternedString> appliedOverrides
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public IEnumerable<InternedString> baseLayouts
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	internal static Cache cache
	{
		[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InputDeviceDescription)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 6)]
		internal get { } //Length: 79
	}

	public internal Nullable<Boolean> canRunInBackground
	{
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 91
		[CalledBy(Type = typeof(LayoutJson), Member = "ToLayout", ReturnType = typeof(InputControlLayout))]
		[CalledBy(Type = typeof(InputControlLayout), Member = "FromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(InputControlLayout))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		internal set { } //Length: 149
	}

	public ReadOnlyArray<InternedString> commonUsages
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 86
	}

	public ReadOnlyArray<ControlItem> controls
	{
		[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControlLayout)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XRLayoutBuilder), Member = "ConvertPotentialAliasToName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 86
	}

	public static InternedString DefaultVariant
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 90
	}

	public string displayName
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 42
	}

	public internal bool hideInUI
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		internal set { } //Length: 31
	}

	public bool isControlLayout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 129
	}

	public bool isDeviceLayout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 123
	}

	public internal bool isGenericTypeOfDevice
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		internal set { } //Length: 31
	}

	public internal bool isNoisy
	{
		[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		internal set { } //Length: 31
	}

	public internal bool isOverride
	{
		[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewLayoutMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputRemoting+Message>))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		internal set { } //Length: 31
	}

	public ControlItem Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InternedString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		 get { } //Length: 413
	}

	public InternedString name
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public FourCC stateFormat
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int stateSizeInBytes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Type type
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool updateBeforeRender
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 57
	}

	public InternedString variants
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static InputControlLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private InputControlLayout(string name, Type type) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[ContainsInvalidInstructions]
	private bool <MergeLayout>b__77_0(ControlItem x) { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "FromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(InputControlLayout))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "AddControlItemsFromMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo[]), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControlLayout), Member = "AddControlItemsFromMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo[]), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void AddControlItems(Type type, List<ControlItem> controlLayouts, string layoutName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlLayout), Member = "AddControlItemsFromMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo[]), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void AddControlItemsFromFields(Type type, List<ControlItem> controlLayouts, string layoutName) { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "AddControlItemsFromMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo[]), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControlLayout), Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute)}, ReturnType = typeof(ControlItem))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<ControlItem> controlItems) { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "AddControlItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "AddControlItemsFromFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "AddControlItemsFromProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeHelpers), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlLayout), Member = "AddControlItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "OffsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ControlItem))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(InputControlLayout), Member = "AddControlItemsFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute[]), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void AddControlItemsFromMembers(MemberInfo[] members, List<ControlItem> controlItems, string layoutName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControlLayout), Member = "AddControlItemsFromMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo[]), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void AddControlItemsFromProperties(Type type, List<ControlItem> controlLayouts, string layoutName) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InputDeviceDescription)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal static CacheRefInstance CacheRef() { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "AddControlItemsFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute[]), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PrimitiveValue), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PrimitiveValue))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndParameters)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>)}, ReturnType = typeof(NameAndParameters[]))]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>))]
	[Calls(Type = typeof(NamedValue), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NamedValue[]))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(InternedString[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(InputStateBlock), Member = "GetPrimitiveFormatFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "OffsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(InputControlLayout), Member = "InferLayoutFromValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeHelpers), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "MergeLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private static Dictionary<String, ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, List<String> variants = null) { }

	[CalledBy(Type = typeof(Collection), Member = "FindLayoutThatIntroducesControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Cache)}, ReturnType = typeof(InternedString))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public Nullable<ControlItem> FindControl(InternedString path) { }

	[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InternedString), Member = "get_length", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public Nullable<ControlItem> FindControlIncludingArrayElements(string path, out int arrayIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(LayoutJson), Member = "ToLayout", ReturnType = typeof(InputControlLayout))]
	public static InputControlLayout FromJson(string json) { }

	[CalledBy(Type = typeof(Collection), Member = "TryLoadLayoutInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(InputControlLayout))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(InputControlLayout), Member = "AddControlItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(InputControlLayout), Member = "set_canRunInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InternedString)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Func`2<System.Object, UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(InternedString[]))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public static InputControlLayout FromType(string name, Type type) { }

	[CallerCount(Count = 0)]
	public IEnumerable<InternedString> get_appliedOverrides() { }

	[CallerCount(Count = 0)]
	public IEnumerable<InternedString> get_baseLayouts() { }

	[CalledBy(Type = typeof(ParsedPathComponent), Member = "ToHumanReadableString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&), typeof(String&), typeof(HumanReadableStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InputDeviceDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "FindOrLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputControlLayout))]
	[CallerCount(Count = 6)]
	internal static Cache get_cache() { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public Nullable<Boolean> get_canRunInBackground() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<InternedString> get_commonUsages() { }

	[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControlLayout)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XRLayoutBuilder), Member = "ConvertPotentialAliasToName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<ControlItem> get_controls() { }

	[CallerCount(Count = 0)]
	public static InternedString get_DefaultVariant() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string get_displayName() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_hideInUI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isControlLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_isDeviceLayout() { }

	[CallerCount(Count = 0)]
	public bool get_isGenericTypeOfDevice() { }

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "InstantiateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InternedString), typeof(InputControl)}, ReturnType = typeof(InputControl))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isNoisy() { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewLayoutMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputRemoting+Message>))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isOverride() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public ControlItem get_Item(string path) { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public InternedString get_name() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public FourCC get_stateFormat() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_stateSizeInBytes() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Type get_type() { }

	[CallerCount(Count = 0)]
	public bool get_updateBeforeRender() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InternedString get_variants() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeHelpers), Member = "GetGenericTypeArgumentFromHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(int)}, ReturnType = typeof(Type))]
	public Type GetValueType() { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute)}, ReturnType = typeof(ControlItem))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collection), Member = "TryFindLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection), Member = "HasLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private static string InferLayoutFromValueType(Type type) { }

	[CalledBy(Type = typeof(Collection), Member = "TryLoadLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, UnityEngine.InputSystem.Layouts.InputControlLayout>)}, ReturnType = typeof(InputControlLayout))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ControlItem), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, ReturnType = typeof(ControlItem))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ControlItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ControlItem))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(System.Func`2<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlLayout), Member = "VariantsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ControlItem&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
	[Calls(Type = typeof(InputControlLayout), Member = "CreateLookupTableForControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem[]), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString>), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Merge", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", "TValue[]"}, ReturnType = "TValue[]")]
	[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	public void MergeLayout(InputControlLayout other) { }

	[CalledBy(Type = typeof(InputManager), Member = "RegisterControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutJsonNameAndDescriptorOnly)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LayoutJsonNameAndDescriptorOnly))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlinedArray`1), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(MatcherJson), Member = "ToMatcher", ReturnType = typeof(InputDeviceMatcher))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString>& baseLayouts, out InputDeviceMatcher deviceMatcher) { }

	[CalledBy(Type = typeof(LayoutJson), Member = "ToLayout", ReturnType = typeof(InputControlLayout))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "FromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(InputControlLayout))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	internal void set_canRunInBackground(Nullable<Boolean> value) { }

	[CallerCount(Count = 0)]
	internal void set_hideInUI(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_isGenericTypeOfDevice(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_isNoisy(bool value) { }

	[CallerCount(Count = 0)]
	internal void set_isOverride(bool value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+NewLayoutMsg", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputRemoting+Message>))]
	[CalledBy(Type = typeof(InputEventTrace), Member = "OnInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutJson), Member = "FromLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = typeof(LayoutJson))]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	public string ToJson() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	internal static bool VariantsMatch(InternedString expected, InternedString actual) { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "MergeLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringHelpers), Member = "CharacterSeparatedListsHaveAtLeastOneCommonElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool VariantsMatch(string expected, string actual) { }

}

