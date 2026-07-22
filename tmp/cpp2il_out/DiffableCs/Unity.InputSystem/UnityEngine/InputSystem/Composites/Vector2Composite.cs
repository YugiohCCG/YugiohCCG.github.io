namespace UnityEngine.InputSystem.Composites;

[DisplayName("Up/Down/Left/Right Composite")]
[DisplayStringFormat("{up}/{left}/{down}/{right}")]
public class Vector2Composite : InputBindingComposite<Vector2>
{
	internal enum Mode
	{
		Analog = 2,
		DigitalNormalized = 0,
		Digital = 1,
	}

	[InputControl(layout = "Axis")]
	public int up; //Field offset: 0x10
	[InputControl(layout = "Axis")]
	public int down; //Field offset: 0x14
	[InputControl(layout = "Axis")]
	public int left; //Field offset: 0x18
	[InputControl(layout = "Axis")]
	public int right; //Field offset: 0x1C
	[Obsolete("Use Mode.DigitalNormalized with 'mode' instead")]
	public bool normalize; //Field offset: 0x20
	public Mode mode; //Field offset: 0x24

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Vector2Composite() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DpadControl), Member = "MakeDpadVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(DpadControl), Member = "MakeDpadVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[ContainsUnimplementedInstructions]
	public virtual Vector2 ReadValue(ref InputBindingCompositeContext context) { }

}

