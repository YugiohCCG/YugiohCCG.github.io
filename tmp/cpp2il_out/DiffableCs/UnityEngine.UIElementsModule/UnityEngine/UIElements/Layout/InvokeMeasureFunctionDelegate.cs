namespace UnityEngine.UIElements.Layout;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
internal sealed class InvokeMeasureFunctionDelegate : MulticastDelegate
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public InvokeMeasureFunctionDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Invoke(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result) { }

}

