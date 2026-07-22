namespace System;

public abstract class Delegate : ICloneable, ISerializable
{
	private IntPtr method_ptr; //Field offset: 0x10
	private IntPtr invoke_impl; //Field offset: 0x18
	private object m_target; //Field offset: 0x20
	private IntPtr method; //Field offset: 0x28
	private IntPtr delegate_trampoline; //Field offset: 0x30
	private IntPtr extra_arg; //Field offset: 0x38
	private IntPtr method_code; //Field offset: 0x40
	private IntPtr interp_method; //Field offset: 0x48
	private IntPtr interp_invoke_impl; //Field offset: 0x50
	private MethodInfo method_info; //Field offset: 0x58
	private MethodInfo original_method_info; //Field offset: 0x60
	private DelegateData data; //Field offset: 0x68
	private bool method_is_virtual; //Field offset: 0x70

	public MethodInfo Method
	{
		[CallerCount(Count = 82)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public object Target
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private static bool arg_type_match(Type delArgType, Type argType) { }

	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	[CallerCount(Count = 40)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override object Clone() { }

	[CalledBy(Type = "UnityEngine.Rendering.DelegateUtility", Member = "Cast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[ComVisible(True)]
	public static Delegate Combine(Delegate[] delegates) { }

	[CallerCount(Count = 271)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static Delegate Combine(Delegate a, Delegate b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MulticastNotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected override Delegate CombineImpl(Delegate d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	[CalledBy(Type = "SQLite.FastColumnSetter", Member = "CreateNullableTypedSetterDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", "ColumnMemberType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.TableMapping+Column", "System.Func`3<IntPtr, Int32, ColumnMemberType>"}, ReturnType = "System.Action`3<ObjectType, IntPtr, Int32>")]
	[CalledBy(Type = "SQLite.FastColumnSetter", Member = "CreateTypedSetterDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", "ColumnMemberType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.TableMapping+Column", "System.Func`3<IntPtr, Int32, ColumnMemberType>"}, ReturnType = "System.Action`3<ObjectType, IntPtr, Int32>")]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = "UnityEngine.Rendering.DelegateUtility", Member = "Cast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Type)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = "UnityEngine.Events.InvokableCall", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Events.InvokableCall`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Events.InvokableCall`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Events.InvokableCall`3", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Events.InvokableCall`4", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = "System.DelegateSerializationHolder+DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(int)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "arg_type_match_this", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Delegate), Member = "return_type_match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Delegate), Member = "arg_type_match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TargetParameterCountException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 31)]
	[ContainsUnimplementedInstructions]
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = "System.Xml.SecureStringHasher", Member = "GetHashCodeDelegate", ReturnType = "System.Xml.SecureStringHasher+HashCodeOfStringDelegate")]
	[CalledBy(Type = "System.Xml.XmlQualifiedName", Member = "GetHashCodeDelegate", ReturnType = "System.Xml.XmlQualifiedName+HashCodeOfStringDelegate")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "GetILPPMethodFunctionPointer2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(RuntimeMethodHandle), typeof(RuntimeTypeHandle)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "<GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate&), typeof(GCHandle&), "<>c__DisplayClass17_0&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ReflectionMethodsCache", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.ReflectedMemberProperty`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IMemberInfo", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 82)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MethodInfo get_Method() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public object get_Target() { }

	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(string)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(string), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = "System.DelegateSerializationHolder+DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(int)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Delegate), Member = "return_type_match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 26)]
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public override Delegate[] GetInvocationList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetMethodFromHandleNoGenericCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle)}, ReturnType = typeof(MethodBase))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected override MethodInfo GetMethodImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = "System.DelegateSerializationHolder+DelegateEntry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private MethodInfo GetVirtualMethod_internal() { }

	[CalledBy(Type = "UnityEngine.UIElements.ListView", Member = "set_unbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<VisualElement, Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlas", Member = "set_customFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DynamicAtlasCustomFilter"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "set_makeFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "set_makeNoneElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "set_overridingAddButtonBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<BaseListView, Button>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "set_onAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<BaseListView>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "set_onRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<BaseListView>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ListView", Member = "set_destroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Column", Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Column", Member = "set_makeCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`1", Member = "IsEquivalentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventCallbackFunctor`2", Member = "IsEquivalentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Delegate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement+BaseVisualElementScheduledItem", Member = "Every", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = "UnityEngine.UIElements.IVisualElementScheduledItem")]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider+<>c__DisplayClass6_0", Member = "<Unsubscribe>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventProvider+Registration"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	[CalledBy(Type = "UnityEngine.UIElements.TreeView", Member = "set_destroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "SetAndVerifyValidationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Security.RemoteCertificateValidationCallback"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), "System.Net.Security.RemoteCertificateValidationCallback", "System.Net.Security.LocalCertificateSelectionCallback"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "set_onGUIHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeView", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<VisualElement>", "System.Action`2<VisualElement, Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeView", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Security.SslStream", Member = "SetAndVerifySelectionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Security.LocalCertificateSelectionCallback"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeView", Member = "set_unbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<VisualElement, Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeView", Member = "set_itemTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualTreeAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeView", Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeView+UxmlTraits", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.IUxmlAttributes", "UnityEngine.UIElements.CreationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ListView", Member = "set_bindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<VisualElement, Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ListView", Member = "set_itemTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualTreeAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ListView", Member = "set_makeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<VisualElement>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ListView+UxmlTraits", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.IUxmlAttributes", "UnityEngine.UIElements.CreationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeView", Member = "set_bindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<VisualElement, Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Delegate d1, Delegate d2) { }

	[CallerCount(Count = 228)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static Delegate Remove(Delegate source, Delegate value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override Delegate RemoveImpl(Delegate d) { }

	[CalledBy(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private static bool return_type_match(Type delReturnType, Type returnType) { }

}

