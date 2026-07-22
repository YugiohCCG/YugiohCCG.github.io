namespace Unity.Properties;

[DefaultMember("Item")]
[IsReadOnly]
public struct PropertyPath : IEquatable<PropertyPath>
{
	[CompilerGenerated]
	private struct <>c__DisplayClass36_0
	{
		public int index; //Field offset: 0x0
		public int length; //Field offset: 0x4
		public string path; //Field offset: 0x8
		public int state; //Field offset: 0x10

	}

	internal const int k_InlineCount = 4; //Field offset: 0x0
	private readonly PropertyPathPart m_Part0; //Field offset: 0x0
	private readonly PropertyPathPart m_Part1; //Field offset: 0x20
	private readonly PropertyPathPart m_Part2; //Field offset: 0x40
	private readonly PropertyPathPart m_Part3; //Field offset: 0x60
	private readonly PropertyPathPart[] m_AdditionalParts; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <Length>k__BackingField; //Field offset: 0x88

	public bool IsEmpty
	{
		[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
		[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
		[CalledBy(Type = "UnityEngine.UIElements.ConverterGroup", Member = "TrySetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "TValue&"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.DataBindingManager+BindingData"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
		[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.Binding"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue&", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public PropertyPathPart Item
	{
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
		[CalledBy(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
		[CalledBy(Type = typeof(PropertyPath), Member = "GetParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		 get { } //Length: 497
	}

	public int Length
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement+UxmlTraits", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.IUxmlAttributes", "UnityEngine.UIElements.CreationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(string), "TValue&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyPath), Member = "ConstructFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyPath))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public PropertyPath(string path) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseListViewController", Member = "SetBindingContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ReusableCollectionItem", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private PropertyPath(in PropertyPathPart part) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1) { }

	[CalledBy(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2) { }

	[CalledBy(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2, in PropertyPathPart part3) { }

	[CalledBy(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "ConstructFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 8)]
	internal PropertyPath(List<PropertyPathPart> parts) { }

	[CalledBy(Type = typeof(PropertyPath), Member = "ConstructFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[CompilerGenerated]
	internal static void <ConstructFromPath>g__ReadNext|36_1(ref <>c__DisplayClass36_0 unnamed_param_0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void <ConstructFromPath>g__TrimStart|36_0(ref <>c__DisplayClass36_0 unnamed_param_0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CallsUnknownMethods(Count = 2)]
	public static PropertyPath AppendIndex(in PropertyPath path, int index) { }

	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(IProperty)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(PropertyPath), Member = "GetParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPathPart&), typeof(PropertyPathPart&), typeof(PropertyPathPart&), typeof(PropertyPathPart&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPathPart&), typeof(PropertyPathPart&), typeof(PropertyPathPart&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static PropertyPath AppendPart(in PropertyPath path, in PropertyPathPart part) { }

	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(IProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public static PropertyPath AppendProperty(in PropertyPath path, IProperty property) { }

	[CalledBy(Type = typeof(PropertyPath), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(PropertyPathPart), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void AppendToBuilder(in PropertyPathPart part, StringBuilder builder) { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.DataBindingManager+BindingData"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(PropertyPath), Member = "GetParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public static PropertyPath Combine(in PropertyPath path, in PropertyPath pathToAppend) { }

	[CalledBy(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PropertyPath), Member = "<ConstructFromPath>g__ReadNext|36_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass36_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 105)]
	[ContainsUnimplementedInstructions]
	private static PropertyPath ConstructFromPath(string path) { }

	[CalledBy(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PropertyPath), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(PropertyPath other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static PropertyPath FromIndex(int index) { }

	[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.BindingUpdater", Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "UnityEngine.UIElements.DataBinding"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroup", Member = "TrySetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "TValue&"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetResolvedDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.DataBindingManager+BindingData"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = "GetHierarchicalDataSourceContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = "UnityEngine.UIElements.DataSourceContext")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.Binding"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue&", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	public bool get_IsEmpty() { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeDataBindingsUpdater", Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "GetParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public PropertyPathPart get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPathPart), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(PropertyPath), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(PropertyPath), Member = "AppendPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(PropertyPathPart&)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void GetParts(in PropertyPath path, List<PropertyPathPart> parts) { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+BindingData", Member = "set_context", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DataSourceContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "set_dataSourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingId"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.BindingId&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.BindingId&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
	public static bool op_Equality(PropertyPath lhs, PropertyPath rhs) { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.Binding"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "UnregisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyPath), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(PropertyPath lhs, PropertyPath rhs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyPath), Member = "SubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&), typeof(int), typeof(int)}, ReturnType = typeof(PropertyPath))]
	public static PropertyPath Pop(in PropertyPath path) { }

	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyPath), Member = "Pop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(PropertyPath))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(PropertyPath), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PropertyPathPart))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Properties.PropertyPathPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 36)]
	[ContainsUnimplementedInstructions]
	public static PropertyPath SubPath(in PropertyPath path, int startIndex, int length) { }

	[CalledBy(Type = "UnityEngine.UIElements.BindingId", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(PropertyPathPart), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(PropertyPath), Member = "AppendToBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPathPart&), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public virtual string ToString() { }

}

