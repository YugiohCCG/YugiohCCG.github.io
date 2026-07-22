namespace System.Reflection;

public abstract class ConstructorInfo : MethodBase
{
	public static readonly string ConstructorName; //Field offset: 0x0
	public static readonly string TypeConstructorName; //Field offset: 0x8

	public virtual MemberTypes MemberType
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ConstructorInfo() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ConstructorInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual MemberTypes get_MemberType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = "Invoke", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.Events.PersistentCall", Member = "GetObjectCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Object", typeof(MethodInfo), "UnityEngine.Events.ArgumentCache"}, ReturnType = "UnityEngine.Events.BaseInvokableCall")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass3_0", Member = "<CreateParameterizedConstructor>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Object[]"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass4_0`1", Member = "<CreateMethodCall>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "System.Object[]"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass5_0`1", Member = "<CreateDefaultConstructor>b__1", ReturnType = "T")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NewInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.ByRefNewInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public object Invoke(Object[] parameters) { }

	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[CallerCount(Count = 264)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	[CallerCount(Count = 34)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

}

