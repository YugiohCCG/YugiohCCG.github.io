namespace UnityEngine.InputSystem.Utilities;

public struct FourCC : IEquatable<FourCC>
{
	private int m_Code; //Field offset: 0x0

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public FourCC(int code) { }

	[CallerCount(Count = 172)]
	public FourCC(char a, char b =  , char c =  , char d =  ) { }

	[CalledBy(Type = typeof(ControlBuilder), Member = "WithFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
	[CalledBy(Type = typeof(Builder), Member = "WithFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Builder))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson", Member = "ToLayout", ReturnType = typeof(InputControlLayout))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson", Member = "ToLayout", ReturnType = typeof(ControlItem))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "FromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(InputControlLayout))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute)}, ReturnType = typeof(ControlItem))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public FourCC(string str) { }

	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(FourCC other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static FourCC FromInt32(int i) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(FourCC left, FourCC right) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static int op_Implicit(FourCC fourCC) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static FourCC op_Implicit(int i) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(FourCC left, FourCC right) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static int ToInt32(FourCC fourCC) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson", Member = "FromLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout+LayoutJson")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson", Member = "FromControlItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem[])}, ReturnType = typeof(ControlItemJson[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

}

