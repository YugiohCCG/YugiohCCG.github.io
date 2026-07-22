namespace UnityEngine.InputSystem.Processors;

public class NormalizeVector2Processor : InputProcessor<Vector2>
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public NormalizeVector2Processor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Vector2 Process(Vector2 value, InputControl control) { }

	[CallerCount(Count = 0)]
	public virtual string ToString() { }

}

