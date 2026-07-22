namespace UnityEngine.InputSystem.XR;

public class XRControllerWithRumble : XRController
{

	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XRControllerWithRumble() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendHapticImpulseCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendHapticImpulseCommand&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SendImpulse(float amplitude, float duration) { }

}

