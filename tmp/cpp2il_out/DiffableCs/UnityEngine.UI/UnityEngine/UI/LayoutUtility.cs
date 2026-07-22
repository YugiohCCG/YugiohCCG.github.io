namespace UnityEngine.UI;

public static class LayoutUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ILayoutElement, Single> <>9__3_0; //Field offset: 0x8
		public static Func<ILayoutElement, Single> <>9__4_0; //Field offset: 0x10
		public static Func<ILayoutElement, Single> <>9__4_1; //Field offset: 0x18
		public static Func<ILayoutElement, Single> <>9__5_0; //Field offset: 0x20
		public static Func<ILayoutElement, Single> <>9__6_0; //Field offset: 0x28
		public static Func<ILayoutElement, Single> <>9__7_0; //Field offset: 0x30
		public static Func<ILayoutElement, Single> <>9__7_1; //Field offset: 0x38
		public static Func<ILayoutElement, Single> <>9__8_0; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFlexibleHeight(RectTransform rect) { }

	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool), typeof(Single&), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFlexibleWidth(RectTransform rect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, Single> property, float defaultValue) { }

	[CalledBy(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetMinHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetFlexibleWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetFlexibleHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetMinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LayoutUtility), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(float))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, Single> property, float defaultValue, out ILayoutElement source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float GetMinHeight(RectTransform rect) { }

	[CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool), typeof(Single&), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float GetMinSize(RectTransform rect, int axis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public static float GetMinWidth(RectTransform rect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	public static float GetPreferredHeight(RectTransform rect) { }

	[CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentSizeFitter), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool), typeof(Single&), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(System.Func`2<UnityEngine.UI.ILayoutElement, System.Single>), typeof(float), typeof(ILayoutElement&)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	public static float GetPreferredWidth(RectTransform rect) { }

}

