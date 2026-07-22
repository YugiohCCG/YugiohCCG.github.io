namespace UnityEngine.InputSystem.Composites;

[DisplayName("Positive/Negative Binding")]
[DisplayStringFormat("{negative}/{positive}")]
public class AxisComposite : InputBindingComposite<Single>
{
	internal enum WhichSideWins
	{
		Neither = 0,
		Positive = 1,
		Negative = 2,
	}

	[InputControl(layout = "Axis")]
	public int negative; //Field offset: 0x10
	[InputControl(layout = "Axis")]
	public int positive; //Field offset: 0x14
	[Tooltip("Value to return when the negative side is fully actuated.")]
	public float minValue; //Field offset: 0x18
	[Tooltip("Value to return when the positive side is fully actuated.")]
	public float maxValue; //Field offset: 0x1C
	[Tooltip("If both the positive and negative side are actuated, decides what value to return. 'Neither' (default) means that the resulting value is the midpoint between min and max. 'Positive' means that max will be returned. 'Negative' means that min will be returned.")]
	public WhichSideWins whichSideWins; //Field offset: 0x20

	public float midPoint
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AxisComposite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NormalizeProcessor), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	public float get_midPoint() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[ContainsUnimplementedInstructions]
	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

