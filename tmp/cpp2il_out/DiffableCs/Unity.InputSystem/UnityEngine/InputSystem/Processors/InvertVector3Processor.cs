namespace UnityEngine.InputSystem.Processors;

public class InvertVector3Processor : InputProcessor<Vector3>
{
	public bool invertX; //Field offset: 0x10
	public bool invertY; //Field offset: 0x11
	public bool invertZ; //Field offset: 0x12

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InvertVector3Processor() { }

	[CallerCount(Count = 0)]
	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

