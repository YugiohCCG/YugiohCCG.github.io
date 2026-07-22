namespace UnityEngine.InputSystem.Composites;

[DisplayName("Binding With Two Modifiers")]
[DisplayStringFormat("{modifier1}+{modifier2}+{binding}")]
public class TwoModifiersComposite : InputBindingComposite
{
	internal enum ModifiersOrder
	{
		Default = 0,
		Ordered = 1,
		Unordered = 2,
	}

	[InputControl(layout = "Button")]
	public int modifier1; //Field offset: 0x10
	[InputControl(layout = "Button")]
	public int modifier2; //Field offset: 0x14
	[InputControl]
	public int binding; //Field offset: 0x18
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x1C
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ModifiersOrder modifiersOrder; //Field offset: 0x20
	private int m_ValueSizeInBytes; //Field offset: 0x24
	private Type m_ValueType; //Field offset: 0x28
	private bool m_BindingIsButton; //Field offset: 0x30

	public virtual int valueSizeInBytes
	{
		[CallerCount(Count = 9)]
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
	public TwoModifiersComposite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TwoModifiersComposite), Member = "ModifiersArePressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OneModifierComposite), Member = "DetermineValueTypeAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(int), typeof(Type&), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_valueSizeInBytes() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public virtual Type get_valueType() { }

	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "GetPressTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	private bool ModifiersArePressed(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TwoModifiersComposite), Member = "ModifiersArePressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

