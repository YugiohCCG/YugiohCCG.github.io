namespace UnityEngine.InputSystem.Processors;

public class ScaleVector2Processor : InputProcessor<Vector2>
{
	[Tooltip("Scale factor to multiply the incoming Vector2's X component by.")]
	public float x; //Field offset: 0x10
	[Tooltip("Scale factor to multiply the incoming Vector2's Y component by.")]
	public float y; //Field offset: 0x14

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ScaleVector2Processor() { }

	[CallerCount(Count = 0)]
	public virtual Vector2 Process(Vector2 value, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

