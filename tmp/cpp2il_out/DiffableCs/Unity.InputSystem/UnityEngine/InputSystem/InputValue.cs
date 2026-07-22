namespace UnityEngine.InputSystem;

[DebuggerDisplay("Value = {Get()}")]
public class InputValue
{
	internal Nullable<CallbackContext> m_Context; //Field offset: 0x10

	public bool isPressed
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputValue), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 90
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InputValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValueAsObject", ReturnType = typeof(object))]
	public object Get() { }

	[CalledBy(Type = typeof(InputValue), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public TValue Get() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputValue), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[ContainsUnimplementedInstructions]
	public bool get_isPressed() { }

}

