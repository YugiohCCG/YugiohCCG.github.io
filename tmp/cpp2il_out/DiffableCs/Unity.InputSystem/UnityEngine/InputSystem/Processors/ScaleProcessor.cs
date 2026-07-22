namespace UnityEngine.InputSystem.Processors;

public class ScaleProcessor : InputProcessor<Single>
{
	[Tooltip("Scale factor to multiply incoming float values by.")]
	public float factor; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ScaleProcessor() { }

	[CallerCount(Count = 0)]
	public virtual float Process(float value, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

