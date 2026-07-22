namespace UnityEngine.InputSystem.Processors;

public class ScaleVector3Processor : InputProcessor<Vector3>
{
	[Tooltip("Scale factor to multiply the incoming Vector3's X component by.")]
	public float x; //Field offset: 0x10
	[Tooltip("Scale factor to multiply the incoming Vector3's Y component by.")]
	public float y; //Field offset: 0x14
	[Tooltip("Scale factor to multiply the incoming Vector3's Z component by.")]
	public float z; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ScaleVector3Processor() { }

	[CallerCount(Count = 0)]
	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

