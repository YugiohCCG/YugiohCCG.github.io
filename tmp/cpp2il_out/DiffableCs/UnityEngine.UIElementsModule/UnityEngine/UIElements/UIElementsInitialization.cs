namespace UnityEngine.UIElements;

internal static class UIElementsInitialization
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
	[RequiredByNativeCode(False)]
	public static void InitializeUIElementsManaged() { }

	[CalledBy(Type = typeof(UIElementsInitialization), Member = "InitializeUIElementsManaged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = "RegisterList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TElement"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleRotate, UnityEngine.UIElements.Rotate>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleScale, UnityEngine.UIElements.Scale>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleTransformOrigin, UnityEngine.UIElements.TransformOrigin>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleTranslate, UnityEngine.UIElements.Translate>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleTextShadow, UnityEngine.UIElements.TextShadow>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleLength, UnityEngine.UIElements.Length>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleInt, System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.PropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValuePropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleBackground, UnityEngine.UIElements.Background>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleBackgroundPosition, UnityEngine.UIElements.BackgroundPosition>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleBackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleBackgroundSize, UnityEngine.UIElements.BackgroundSize>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleColor, UnityEngine.Color>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleCursor, UnityEngine.UIElements.Cursor>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleFloat, System.Single>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleFont, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.StyleValuePropertyBag`2<UnityEngine.UIElements.StyleFontDefinition, UnityEngine.UIElements.FontDefinition>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal static void RegisterBuiltInPropertyBags() { }

}

