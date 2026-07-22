namespace UnityEngine.UIElements;

public abstract class MouseCaptureEventBase : PointerCaptureEventBase<T>
{

	[CalledBy(Type = "UnityEngine.UIElements.MouseCaptureOutEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(MouseCaptureOutEvent))]
	[CalledBy(Type = typeof(MouseCaptureOutEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MouseCaptureEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(MouseCaptureEvent))]
	[CalledBy(Type = typeof(MouseCaptureEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PointerCaptureEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected MouseCaptureEventBase`1() { }

}

