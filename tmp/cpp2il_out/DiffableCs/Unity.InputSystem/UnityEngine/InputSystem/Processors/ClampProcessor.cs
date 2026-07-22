namespace UnityEngine.InputSystem.Processors;

public class ClampProcessor : InputProcessor<Single>
{
	public float min; //Field offset: 0x10
	public float max; //Field offset: 0x14

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ClampProcessor() { }

	[CallerCount(Count = 0)]
	public virtual float Process(float value, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

