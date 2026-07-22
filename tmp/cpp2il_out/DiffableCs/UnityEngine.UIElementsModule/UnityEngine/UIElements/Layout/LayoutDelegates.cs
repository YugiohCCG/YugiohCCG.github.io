namespace UnityEngine.UIElements.Layout;

internal static class LayoutDelegates
{
	private static readonly ProfilerMarker s_InvokeMeasureFunctionMarker; //Field offset: 0x0
	private static readonly ProfilerMarker s_InvokeBaselineFunctionMarker; //Field offset: 0x8
	private static readonly InvokeMeasureFunctionDelegate s_InvokeMeasureDelegate; //Field offset: 0x10
	private static readonly InvokeBaselineFunctionDelegate s_InvokeBaselineDelegate; //Field offset: 0x18
	internal static readonly IntPtr s_InvokeMeasureFunction; //Field offset: 0x20
	internal static readonly IntPtr s_InvokeBaselineFunction; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 10)]
	private static LayoutDelegates() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Baseline", ReturnType = typeof(LayoutBaselineFunction))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(InvokeBaselineFunctionDelegate))]
	private static float InvokeBaselineFunction(ref LayoutNode node, float width, float height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutNode), Member = "get_Measure", ReturnType = typeof(LayoutMeasureFunction))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutNode), Member = "GetOwner", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(InvokeMeasureFunctionDelegate))]
	private static void InvokeMeasureFunction(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result) { }

}

