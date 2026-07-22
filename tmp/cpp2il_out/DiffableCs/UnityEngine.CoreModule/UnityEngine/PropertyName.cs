namespace UnityEngine;

[UsedByNativeCode]
public struct PropertyName : IEquatable<PropertyName>
{
	internal int id; //Field offset: 0x0

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyNameUtils), Member = "PropertyNameFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	public PropertyName(string name) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public PropertyName(PropertyName other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(PropertyName other) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsNullOrEmpty(PropertyName prop) { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "DestroyHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "UnbindHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "BindHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "set_isContentBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "get_isContentBound", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "set_content", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnController", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseField`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "OnItemsSourceSizeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "OnAfterAddClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "OnAddClicked", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.CollectionViewController", Member = "set_itemsSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeBindingsUpdater", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(PropertyNameUtils), Member = "PropertyNameFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	public static PropertyName op_Implicit(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

