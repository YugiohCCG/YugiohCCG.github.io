namespace UnityEngine.UIElements;

public struct Length : IEquatable<Length>
{
	public class PropertyBag : ContainerPropertyBag<Length>
	{
		private class UnitProperty : Property<Length, LengthUnit>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			public virtual bool IsReadOnly
			{
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			public virtual string Name
			{
				[CallerCount(Count = 31)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public UnitProperty() { }

			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual bool get_IsReadOnly() { }

			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual string get_Name() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual LengthUnit GetValue(ref Length container) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual void SetValue(ref Length container, LengthUnit value) { }

		}

		private class ValueProperty : Property<Length, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			public virtual bool IsReadOnly
			{
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			public virtual string Name
			{
				[CallerCount(Count = 31)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public ValueProperty() { }

			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual bool get_IsReadOnly() { }

			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			public virtual string get_Name() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual float GetValue(ref Length container) { }

			[CallerCount(Count = 0)]
			public virtual void SetValue(ref Length container, float value) { }

		}


		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public PropertyBag() { }

	}

	private enum Unit
	{
		Pixel = 0,
		Percent = 1,
		Auto = 2,
		None = 3,
	}

	internal const float k_MaxValue = 8388608; //Field offset: 0x0
	[SerializeField]
	private float m_Value; //Field offset: 0x0
	[SerializeField]
	private Unit m_Unit; //Field offset: 0x4

	public LengthUnit unit
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 39
	}

	[CalledBy(Type = typeof(BackgroundPosition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPositionKeyword)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BackgroundPosition), Member = "Initial", ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundPosition))]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ResolveUnityBackgroundScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(BackgroundRepeat), typeof(BackgroundSize), typeof(Boolean&)}, ReturnType = typeof(ScaleMode))]
	[CalledBy(Type = "UnityEngine.UIElements.BackgroundSize+PropertyBag+SizeTypeProperty", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSizeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BackgroundSize), Member = "set_sizeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSizeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BackgroundSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSizeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "FinalizeApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	public Length(float value) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public Length(float value, LengthUnit unit) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	private Length(float value, Unit unit) { }

	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileFlexShorthand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Single&), typeof(Single&), typeof(Length&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(BackgroundSize))]
	[CallerCount(Count = 8)]
	public static Length Auto() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Length other) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public LengthUnit get_unit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_value() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveLengthValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(bool)}, ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[ContainsUnimplementedInstructions]
	public bool IsAuto() { }

	[CalledBy(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveLengthValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(bool)}, ReturnType = typeof(StyleFloat))]
	[CalledBy(Type = typeof(VisualElement), Member = "ResolveTransformOrigin", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(TextElement), Member = "UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[ContainsUnimplementedInstructions]
	public bool IsNone() { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Length))]
	[CallerCount(Count = 4)]
	public static Length None() { }

	[CallerCount(Count = 36)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Length lhs, Length rhs) { }

	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Column), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UnityEngine.UIElements.ITransform.set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InitialStyle), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyBorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyMargin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBorderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBoxArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Length&), typeof(Length&), typeof(Length&), typeof(Length&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBoxArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Single&), typeof(Single&), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTranslate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(Translate))]
	[CallerCount(Count = 58)]
	public static Length op_Implicit(float value) { }

	[CallerCount(Count = 57)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(Length lhs, Length rhs) { }

	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ConvertScaleModeToBackgroundSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleMode)}, ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(BackgroundPropertyHelper), Member = "ResolveUnityBackgroundScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(BackgroundRepeat), typeof(BackgroundSize), typeof(Boolean&)}, ReturnType = typeof(ScaleMode))]
	[CalledBy(Type = typeof(BackgroundSize), Member = "Initial", ReturnType = typeof(BackgroundSize))]
	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileFlexShorthand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(Single&), typeof(Single&), typeof(Length&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TransformOrigin))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTransformOriginEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(Length))]
	[CallerCount(Count = 14)]
	public static Length Percent(float value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_unit(LengthUnit value) { }

	[CallerCount(Count = 0)]
	public void set_value(float value) { }

	[CalledBy(Type = typeof(TransformOrigin), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Translate), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

