namespace UnityEngine.Assertions;

[DebuggerStepThrough]
public static class Assert
{
	[Obsolete("Future versions of Unity are expected to always throw exceptions and not have this field.")]
	public static bool raiseExceptions; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static Assert() { }

	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem", Member = "CancelAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(string)}, ReturnType = typeof(void))]
	[Conditional("UNITY_ASSERTIONS")]
	public static void AreEqual(int expected, int actual) { }

	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetEqualityMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("UNITY_ASSERTIONS")]
	[DeduplicatedMethod]
	public static void AreEqual(T expected, T actual, string message, IEqualityComparer<T> comparer) { }

	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(string), "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("UNITY_ASSERTIONS")]
	[DeduplicatedMethod]
	public static void AreEqual(T expected, T actual, string message) { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.StylePropertyId", "UnityEngine.UIElements.Length&", "UnityEngine.UIElements.Length&", typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("UNITY_ASSERTIONS")]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	public static void AreEqual(T expected, T actual) { }

	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(string), "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetEqualityMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Conditional("UNITY_ASSERTIONS")]
	public static void AreEqual(object expected, object actual, string message) { }

	[CalledBy(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(string), "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(AssertionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogAssertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void Fail(string message, string userMessage) { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.Binding"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Conditional("UNITY_ASSERTIONS")]
	[ContainsUnimplementedInstructions]
	public static void IsFalse(bool condition) { }

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = "RegisterBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.BindingId&", "UnityEngine.UIElements.Binding"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "ProcessBindingRequests", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CreateBindingRequests", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "CloneSetupRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElementAsset", "System.Collections.Generic.Dictionary`2<Int32, List`1<VisualElementAsset>>", "UnityEngine.UIElements.CreationContext"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Conditional("UNITY_ASSERTIONS")]
	[ContainsUnimplementedInstructions]
	public static void IsFalse(bool condition, string message) { }

	[CalledBy(Type = "UnityEngine.UIElements.DragEventsProcessor", Member = "get_isEditorContext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.CreationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "NullFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assert), Member = "IsNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("UNITY_ASSERTIONS")]
	[DeduplicatedMethod]
	public static void IsNotNull(T value) { }

	[CalledBy(Type = "UnityEngine.UIElements.CollectionViewController", Member = "SetView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVerticalCollectionView"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "NullFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assert), Member = "IsNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("UNITY_ASSERTIONS")]
	[DeduplicatedMethod]
	public static void IsNotNull(T value, string message) { }

	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "NullFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Conditional("UNITY_ASSERTIONS")]
	public static void IsNotNull(object value, string message) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator+AreaNode", Member = "AddAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIRAtlasAllocator+AreaNode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "NullFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assert), Member = "IsNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("UNITY_ASSERTIONS")]
	[DeduplicatedMethod]
	public static void IsNull(T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "NullFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Assert), Member = "IsNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Conditional("UNITY_ASSERTIONS")]
	[DeduplicatedMethod]
	public static void IsNull(T value, string message) { }

	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "NullFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Conditional("UNITY_ASSERTIONS")]
	public static void IsNull(object value, string message) { }

	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Layout.ComponentType[]", typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShaderKeywordSet), Member = "CheckKeywordCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeyword)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShaderKeywordSet), Member = "IsEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderKeyword)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Conditional("UNITY_ASSERTIONS")]
	[ContainsUnimplementedInstructions]
	public static void IsTrue(bool condition, string message) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIRAtlasAllocator", Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutNode", Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutDataStore", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutList`1", Member = "ResizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", typeof(long), typeof(long), typeof(long), typeof(int), typeof(Allocator)}, ReturnType = "System.Void*")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assert), Member = "Fail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Conditional("UNITY_ASSERTIONS")]
	[ContainsUnimplementedInstructions]
	public static void IsTrue(bool condition) { }

}

