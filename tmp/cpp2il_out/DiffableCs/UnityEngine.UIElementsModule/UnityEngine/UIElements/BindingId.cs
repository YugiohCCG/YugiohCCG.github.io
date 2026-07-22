namespace UnityEngine.UIElements;

[IsReadOnly]
public struct BindingId : IEquatable<BindingId>
{
	public static readonly BindingId Invalid; //Field offset: 0x0
	private readonly PropertyPath m_PropertyPath; //Field offset: 0x0
	private readonly string m_Path; //Field offset: 0x90

	[CallerCount(Count = 0)]
	private static BindingId() { }

	[CalledBy(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public BindingId(string path) { }

	[CalledBy(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(BindingId))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public BindingId(in PropertyPath path) { }

	[CalledBy(Type = typeof(BindingId), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	public override bool Equals(BindingId other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BindingId), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyPath), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker", Member = "OnPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyChangedEvent), typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.DataBindingManager+BindingDataCollection>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+IgnoreUIChangesData", Member = "ShouldIgnoreChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Binding), typeof(BindingId)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "CreateBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	public static bool op_Equality(in BindingId lhs, in BindingId rhs) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public static PropertyPath op_Implicit(in BindingId vep) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static string op_Implicit(in BindingId vep) { }

	[CallerCount(Count = 210)]
	[Calls(Type = typeof(BindingId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static BindingId op_Implicit(string name) { }

	[CalledBy(Type = typeof(DataBinding), Member = "UpdateSource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), "TValue&"}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BindingInfo), Member = "FromRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(PropertyPath&), typeof(Binding)}, ReturnType = typeof(BindingInfo))]
	[CalledBy(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BindingId), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath&)}, ReturnType = typeof(void))]
	public static BindingId op_Implicit(in PropertyPath path) { }

	[CalledBy(Type = typeof(DataBindingManager), Member = "TryGetBindingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(Binding&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataBindingUtility), Member = "TryGetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(BindingId&), typeof(BindingInfo&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyPath), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath), typeof(PropertyPath)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in BindingId lhs, in BindingId rhs) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

