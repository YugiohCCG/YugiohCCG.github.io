namespace System.Dynamic;

internal class ExpandoClass
{
	internal static readonly ExpandoClass Empty; //Field offset: 0x0
	private readonly String[] _keys; //Field offset: 0x10
	private readonly int _hashCode; //Field offset: 0x18
	private Dictionary<Int32, List`1<WeakReference>> _transitions; //Field offset: 0x20

	internal String[] Keys
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static ExpandoClass() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal ExpandoClass() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ExpandoClass(String[] keys, int hashCode) { }

	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetClassEnsureIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject), typeof(ExpandoClass&), typeof(Int32&)}, ReturnType = typeof(ExpandoClass))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	internal ExpandoClass FindNewClass(string newKey) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal String[] get_Keys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private List<WeakReference> GetTransitionList(int hashCode) { }

	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetClassEnsureIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject), typeof(ExpandoClass&), typeof(Int32&)}, ReturnType = typeof(ExpandoClass))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExpandoObject)}, ReturnType = typeof(int))]
	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	[CalledBy(Type = typeof(ExpandoClass), Member = "GetValueIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpandoObject), Member = "IsDeletedMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	[CalledBy(Type = typeof(ExpandoClass), Member = "GetValueIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetClassEnsureIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject), typeof(ExpandoClass&), typeof(Int32&)}, ReturnType = typeof(ExpandoClass))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "ExpandoContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal int GetValueIndexCaseSensitive(string name) { }

}

