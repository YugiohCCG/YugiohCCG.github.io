namespace UnityEngine.InputSystem.Processors;

public class InvertProcessor : InputProcessor<Single>
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InvertProcessor() { }

	[CallerCount(Count = 0)]
	public virtual float Process(float value, InputControl control) { }

	[CallerCount(Count = 0)]
	public virtual string ToString() { }

}

