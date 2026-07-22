namespace UnityEngine.UIElements;

internal class StyleValueCollection
{
	internal List<StyleValue> m_Values; //Field offset: 0x10

	[CalledBy(Type = typeof(InlineStyleAccess), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "set_unityBackgroundImageTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "set_borderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "get_paddingTop", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(StyleValues), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "Values", ReturnType = typeof(StyleValueCollection))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public StyleValueCollection() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_backgroundImage", ReturnType = typeof(StyleBackground))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Background), Member = "FromVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(Background), Member = "FromSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Background))]
	[Calls(Type = typeof(Background), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Background))]
	[CallsUnknownMethods(Count = 4)]
	public StyleBackground GetStyleBackground(StylePropertyId id) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_backgroundPositionX", ReturnType = typeof(StyleBackgroundPosition))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_backgroundPositionY", ReturnType = typeof(StyleBackgroundPosition))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	public StyleBackgroundPosition GetStyleBackgroundPosition(StylePropertyId id) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_backgroundRepeat", ReturnType = typeof(StyleBackgroundRepeat))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	public StyleBackgroundRepeat GetStyleBackgroundRepeat(StylePropertyId id) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_backgroundColor", ReturnType = typeof(StyleColor))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_borderBottomColor", ReturnType = typeof(StyleColor))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_borderLeftColor", ReturnType = typeof(StyleColor))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_borderRightColor", ReturnType = typeof(StyleColor))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_borderTopColor", ReturnType = typeof(StyleColor))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_color", ReturnType = typeof(StyleColor))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_unityBackgroundImageTintColor", ReturnType = typeof(StyleColor))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_unityTextOutlineColor", ReturnType = typeof(StyleColor))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	public StyleColor GetStyleColor(StylePropertyId id) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_borderBottomWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_borderLeftWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_borderRightWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_borderTopWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_flexGrow", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_flexShrink", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_opacity", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_unitySliceScale", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_unityTextOutlineWidth", ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(StyleValues), Member = "get_paddingTop", ReturnType = typeof(float))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	public StyleFloat GetStyleFloat(StylePropertyId id) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_unityFont", ReturnType = typeof(StyleFont))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public StyleFont GetStyleFont(StylePropertyId id) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.get_unityFontDefinition", ReturnType = typeof(StyleFontDefinition))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(FontDefinition), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(FontDefinition))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public StyleFontDefinition GetStyleFontDefinition(StylePropertyId id) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public StyleInt GetStyleInt(StylePropertyId id) { }

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	public StyleLength GetStyleLength(StylePropertyId id) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundRepeat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "set_borderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "set_unityBackgroundImageTintColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleValues), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFont)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleValues), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleInt)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundRepeat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SetStyleValue(StyleValue value) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value) { }

}

