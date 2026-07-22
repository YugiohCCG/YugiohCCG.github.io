namespace UnityEngine.UIElements.Layout;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class InvokeBaselineFunctionDelegate : MulticastDelegate
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public InvokeBaselineFunctionDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override float Invoke(ref LayoutNode node, float width, float height) { }

}

