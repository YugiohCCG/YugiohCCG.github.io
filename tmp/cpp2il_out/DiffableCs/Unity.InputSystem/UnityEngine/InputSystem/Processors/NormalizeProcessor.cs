namespace UnityEngine.InputSystem.Processors;

public class NormalizeProcessor : InputProcessor<Single>
{
	public float min; //Field offset: 0x10
	public float max; //Field offset: 0x14
	public float zero; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public NormalizeProcessor() { }

	[CalledBy(Type = typeof(AxisControl), Member = "Unpreprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AxisControl), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static float Denormalize(float value, float min, float max, float zero) { }

	[CalledBy(Type = typeof(AxisControl), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AxisControl), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AxisControl), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AxisComposite), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	public static float Normalize(float value, float min, float max, float zero) { }

	[CallerCount(Count = 0)]
	public virtual float Process(float value, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

