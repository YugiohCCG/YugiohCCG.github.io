namespace UnityEngine.UIElements;

[UxmlObject]
public class DataBinding : Binding, IDataSourceProvider
{
	private static MethodInfo s_UpdateUIMethodInfo; //Field offset: 0x0
	private BindingMode m_BindingMode; //Field offset: 0x20
	private ConverterGroup m_SourceToUiConverters; //Field offset: 0x28
	private ConverterGroup m_UiToSourceConverters; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private object <dataSource>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Type <dataSourceType>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PropertyPath <dataSourcePath>k__BackingField; //Field offset: 0x48

	[CreateProperty]
	public BindingMode bindingMode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		 set { } //Length: 13
	}

	[CreateProperty]
	public override object dataSource
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CreateProperty]
	public override PropertyPath dataSourcePath
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 93
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 100
	}

	public Type dataSourceType
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CreateProperty(ReadOnly = True)]
	public ConverterGroup sourceToUiConverters
	{
		[CalledBy(Type = typeof(DataBinding), Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ConverterGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 149
	}

	[CreateProperty(ReadOnly = True)]
	public ConverterGroup uiToSourceConverters
	{
		[CalledBy(Type = typeof(DataBinding), Member = "UpdateSource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ConverterGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 149
	}

	internal static MethodInfo updateUIMethod
	{
		[CalledBy(Type = typeof(BindingUpdater), Member = "TryUpdateUIWithNonContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding), typeof(object)}, ReturnType = typeof(BindingResult))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		internal get { } //Length: 501
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConverterGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeConverterRegistry), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeConverterRegistry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyConverterGroupToSource(ConverterGroup group) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConverterGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeConverterRegistry), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeConverterRegistry)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyConverterGroupToUI(ConverterGroup group) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private static MethodInfo CacheReflectionInfo() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public BindingMode get_bindingMode() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override object get_dataSource() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public override PropertyPath get_dataSourcePath() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_dataSourceType() { }

	[CalledBy(Type = typeof(DataBinding), Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConverterGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ConverterGroup get_sourceToUiConverters() { }

	[CalledBy(Type = typeof(DataBinding), Member = "UpdateSource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConverterGroup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ConverterGroup get_uiToSourceConverters() { }

	[CalledBy(Type = typeof(BindingUpdater), Member = "TryUpdateUIWithNonContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding), typeof(object)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	internal static MethodInfo get_updateUIMethod() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	internal static string GetSetValueErrorString(VisitReturnCode returnCode, object source, in PropertyPath sourcePath, object target, in BindingId targetPath, TValue extractedValueFromSource) { }

	[CallerCount(Count = 0)]
	public void set_bindingMode(BindingMode value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_dataSource(object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public void set_dataSourcePath(PropertyPath value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_dataSourceType(Type value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataBinding), Member = "get_uiToSourceConverters", ReturnType = typeof(ConverterGroup))]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(BindingId))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	protected private override BindingResult UpdateSource(in BindingContext context, ref TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PropertyContainer), Member = "TryGetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), typeof(IProperty&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(string), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ConverterGroup), Member = "TrySetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataBinding), Member = "get_sourceToUiConverters", ReturnType = typeof(ConverterGroup))]
	[Calls(Type = typeof(VisualElement), Member = "ClassListContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(FocusController), Member = "IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 31)]
	[DeduplicatedMethod]
	protected private override BindingResult UpdateUI(in BindingContext context, ref TValue value) { }

}

