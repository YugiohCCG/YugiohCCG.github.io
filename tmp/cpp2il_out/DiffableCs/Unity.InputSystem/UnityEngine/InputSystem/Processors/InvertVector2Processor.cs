namespace UnityEngine.InputSystem.Processors;

public class InvertVector2Processor : InputProcessor<Vector2>
{
	public bool invertX; //Field offset: 0x10
	public bool invertY; //Field offset: 0x11

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public InvertVector2Processor() { }

	[CallerCount(Count = 0)]
	public virtual Vector2 Process(Vector2 value, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

