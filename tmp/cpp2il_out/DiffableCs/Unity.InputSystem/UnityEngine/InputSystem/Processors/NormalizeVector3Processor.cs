namespace UnityEngine.InputSystem.Processors;

public class NormalizeVector3Processor : InputProcessor<Vector3>
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public NormalizeVector3Processor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	[CallerCount(Count = 0)]
	public virtual string ToString() { }

}

