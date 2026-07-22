namespace UnityEngine.InputSystem.Composites;

[DesignTimeVisible(False)]
[DisplayStringFormat("{modifier}+{button}")]
public class ButtonWithOneModifier : InputBindingComposite<Single>
{
	internal enum ModifiersOrder
	{
		Default = 0,
		Ordered = 1,
		Unordered = 2,
	}

	[InputControl(layout = "Button")]
	public int modifier; //Field offset: 0x10
	[InputControl(layout = "Button")]
	public int button; //Field offset: 0x14
	[Obsolete("Use ModifiersOrder.Unordered with 'modifiersOrder' instead")]
	[Tooltip("Obsolete please use modifiers Order. If enabled, this will override the Input Consumption setting, allowing the modifier keys to be pressed after the button and the composite will still trigger.")]
	public bool overrideModifiersNeedToBePressedFirst; //Field offset: 0x18
	[Tooltip("By default it follows the Input Consumption setting to determine if the modifers keys need to be pressed first.")]
	public ModifiersOrder modifiersOrder; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ButtonWithOneModifier() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual void FinishSetup(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "GetPressTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	private bool ModifierIsPressed(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "GetPressTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[ContainsUnimplementedInstructions]
	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

