namespace UnityEngine.InputSystem.Composites;

[DisplayName("Binding With One Modifier")]
[DisplayStringFormat("{modifier}+{binding}")]
public class OneModifierComposite : InputBindingComposite
{
	internal enum ModifiersOrder
	{
		Default = 0,
		Ordered = 1,
		Unordered = 2,
	}

	[InputControl(layout = "Button")]
	public int modifier; //Field offset: 0x10
	[InputControl]
	public int binding; //Field offset: 0x14
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x18
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ModifiersOrder modifiersOrder; //Field offset: 0x1C
	private int m_ValueSizeInBytes; //Field offset: 0x20
	private Type m_ValueType; //Field offset: 0x28
	private bool m_BindingIsButton; //Field offset: 0x30

	public virtual int valueSizeInBytes
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual Type valueType
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public OneModifierComposite() { }

	[CalledBy(Type = typeof(OneModifierComposite), Member = "FinishSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "FinishSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "get_controls", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputBindingCompositeContext+PartBinding>))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControl), Member = "get_isButton", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	internal static void DetermineValueTypeAndSize(ref InputBindingCompositeContext context, int part, out Type valueType, out int valueSizeInBytes, out bool isButton) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "GetPressTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OneModifierComposite), Member = "DetermineValueTypeAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(int), typeof(Type&), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual int get_valueSizeInBytes() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public virtual Type get_valueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "GetPressTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	private bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "GetPressTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

