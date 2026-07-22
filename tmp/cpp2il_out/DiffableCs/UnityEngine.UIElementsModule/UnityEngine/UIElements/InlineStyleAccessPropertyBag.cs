namespace UnityEngine.UIElements;

internal class InlineStyleAccessPropertyBag : PropertyBag<InlineStyleAccess>, INamedProperties<InlineStyleAccess>
{
	private class AlignContentProperty : InlineStyleEnumProperty<Align>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public AlignContentProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	private class AlignItemsProperty : InlineStyleEnumProperty<Align>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public AlignItemsProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	private class AlignSelfProperty : InlineStyleEnumProperty<Align>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public AlignSelfProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	private class BackgroundColorProperty : InlineStyleColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundColorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	private class BackgroundImageProperty : InlineStyleBackgroundProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty", Member = ".ctor", ReturnType = typeof(void))]
		public BackgroundImageProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleBackground GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackground value) { }

	}

	private class BackgroundPositionXProperty : InlineStyleBackgroundPositionProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundPosition, BackgroundPosition>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundPositionXProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleBackgroundPosition GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value) { }

	}

	private class BackgroundPositionYProperty : InlineStyleBackgroundPositionProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundPosition, BackgroundPosition>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundPositionYProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleBackgroundPosition GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value) { }

	}

	private class BackgroundRepeatProperty : InlineStyleBackgroundRepeatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundRepeat, BackgroundRepeat>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundRepeatProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleBackgroundRepeat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundRepeat value) { }

	}

	private class BackgroundSizeProperty : InlineStyleBackgroundSizeProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundSize, BackgroundSize>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundSizeProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleBackgroundSize GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundSize value) { }

	}

	private class BorderBottomColorProperty : InlineStyleColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderBottomColorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	private class BorderBottomLeftRadiusProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderBottomLeftRadiusProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class BorderBottomRightRadiusProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderBottomRightRadiusProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class BorderBottomWidthProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderBottomWidthProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class BorderLeftColorProperty : InlineStyleColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderLeftColorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	private class BorderLeftWidthProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderLeftWidthProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class BorderRightColorProperty : InlineStyleColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderRightColorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	private class BorderRightWidthProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderRightWidthProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class BorderTopColorProperty : InlineStyleColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderTopColorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	private class BorderTopLeftRadiusProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderTopLeftRadiusProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class BorderTopRightRadiusProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderTopRightRadiusProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class BorderTopWidthProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderTopWidthProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class BottomProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BottomProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class ColorProperty : InlineStyleColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public ColorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	private class CursorProperty : InlineStyleCursorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleCursor, Cursor>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public CursorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleCursor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleCursor value) { }

	}

	private class DisplayProperty : InlineStyleEnumProperty<DisplayStyle>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public DisplayProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<DisplayStyle> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<DisplayStyle> value) { }

	}

	private class FlexBasisProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public FlexBasisProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class FlexDirectionProperty : InlineStyleEnumProperty<FlexDirection>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public FlexDirectionProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<FlexDirection> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<FlexDirection> value) { }

	}

	private class FlexGrowProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public FlexGrowProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class FlexShrinkProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public FlexShrinkProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class FlexWrapProperty : InlineStyleEnumProperty<Wrap>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public FlexWrapProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<Wrap> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Wrap> value) { }

	}

	private class FontSizeProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public FontSizeProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class HeightProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public HeightProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private abstract class InlineStyleBackgroundPositionProperty : InlineStyleProperty<StyleBackgroundPosition, BackgroundPosition>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundPosition, BackgroundPosition>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleBackgroundPositionProperty() { }

	}

	private abstract class InlineStyleBackgroundProperty : InlineStyleProperty<StyleBackground, Background>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static TypeConverter<Texture2D, StyleBackground> <>9__0_0; //Field offset: 0x8
			public static TypeConverter<Sprite, StyleBackground> <>9__0_1; //Field offset: 0x10
			public static TypeConverter<VectorImage, StyleBackground> <>9__0_2; //Field offset: 0x18
			public static TypeConverter<RenderTexture, StyleBackground> <>9__0_3; //Field offset: 0x20
			public static TypeConverter<StyleBackground, Texture2D> <>9__0_4; //Field offset: 0x28
			public static TypeConverter<StyleBackground, Sprite> <>9__0_5; //Field offset: 0x30
			public static TypeConverter<StyleBackground, RenderTexture> <>9__0_6; //Field offset: 0x38
			public static TypeConverter<StyleBackground, VectorImage> <>9__0_7; //Field offset: 0x40

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
			internal StyleBackground <.ctor>b__0_0(ref Texture2D v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
			internal StyleBackground <.ctor>b__0_1(ref Sprite v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(void))]
			internal StyleBackground <.ctor>b__0_2(ref VectorImage v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Background), Member = "FromRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(Background))]
			[Calls(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background)}, ReturnType = typeof(void))]
			internal StyleBackground <.ctor>b__0_3(ref RenderTexture v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal Texture2D <.ctor>b__0_4(ref StyleBackground sv) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal Sprite <.ctor>b__0_5(ref StyleBackground sv) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal RenderTexture <.ctor>b__0_6(ref StyleBackground sv) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal VectorImage <.ctor>b__0_7(ref StyleBackground sv) { }

		}


		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BackgroundImageProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackground, Background>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Properties.TypeConverter`2<System.Object, UnityEngine.UIElements.StyleBackground>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		protected InlineStyleBackgroundProperty() { }

	}

	private abstract class InlineStyleBackgroundRepeatProperty : InlineStyleProperty<StyleBackgroundRepeat, BackgroundRepeat>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundRepeat, BackgroundRepeat>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleBackgroundRepeatProperty() { }

	}

	private abstract class InlineStyleBackgroundSizeProperty : InlineStyleProperty<StyleBackgroundSize, BackgroundSize>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundSize, BackgroundSize>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleBackgroundSizeProperty() { }

	}

	private abstract class InlineStyleColorProperty : InlineStyleProperty<StyleColor, Color>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static TypeConverter<Color32, StyleColor> <>9__0_0; //Field offset: 0x8
			public static TypeConverter<StyleColor, Color32> <>9__0_1; //Field offset: 0x10

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			internal StyleColor <.ctor>b__0_0(ref Color32 v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleColor), Member = "get_value", ReturnType = typeof(Color))]
			[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
			internal Color32 <.ctor>b__0_1(ref StyleColor sv) { }

		}


		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BackgroundColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderBottomColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderLeftColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderRightColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderTopColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+ColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityBackgroundImageTintColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityTextOutlineColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleColor, Color>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(TypeConverter`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		protected InlineStyleColorProperty() { }

	}

	private abstract class InlineStyleCursorProperty : InlineStyleProperty<StyleCursor, Cursor>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleCursor, Cursor>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleCursorProperty() { }

	}

	private abstract class InlineStyleEnumProperty : InlineStyleProperty<StyleEnum`1<TValue>, TValue>
	{

		[CallerCount(Count = 38)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleEnumProperty`1() { }

	}

	private abstract class InlineStyleFloatProperty : InlineStyleProperty<StyleFloat, Single>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static TypeConverter<Int32, StyleFloat> <>9__0_0; //Field offset: 0x8
			public static TypeConverter<StyleFloat, Int32> <>9__0_1; //Field offset: 0x10

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			internal StyleFloat <.ctor>b__0_0(ref int v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
			[ContainsUnimplementedInstructions]
			internal int <.ctor>b__0_1(ref StyleFloat sv) { }

		}


		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderBottomWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderLeftWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderRightWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderTopWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+FlexGrowProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+FlexShrinkProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+OpacityProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnitySliceScaleProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityTextOutlineWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleFloat, Single>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		protected InlineStyleFloatProperty() { }

	}

	private abstract class InlineStyleFontDefinitionProperty : InlineStyleProperty<StyleFontDefinition, FontDefinition>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static TypeConverter<Font, StyleFontDefinition> <>9__0_0; //Field offset: 0x8
			public static TypeConverter<FontAsset, StyleFontDefinition> <>9__0_1; //Field offset: 0x10
			public static TypeConverter<StyleFontDefinition, Font> <>9__0_2; //Field offset: 0x18
			public static TypeConverter<StyleFontDefinition, FontAsset> <>9__0_3; //Field offset: 0x20

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
			internal StyleFontDefinition <.ctor>b__0_0(ref Font v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
			internal StyleFontDefinition <.ctor>b__0_1(ref FontAsset v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFontDefinition), Member = "get_value", ReturnType = typeof(FontDefinition))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal Font <.ctor>b__0_2(ref StyleFontDefinition sv) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFontDefinition), Member = "get_value", ReturnType = typeof(FontDefinition))]
			[CallsDeduplicatedMethods(Count = 1)]
			internal FontAsset <.ctor>b__0_3(ref StyleFontDefinition sv) { }

		}


		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityFontDefinitionProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleFontDefinition, FontDefinition>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Properties.TypeConverter`2<System.Object, UnityEngine.UIElements.StyleFontDefinition>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		protected InlineStyleFontDefinitionProperty() { }

	}

	private abstract class InlineStyleFontProperty : InlineStyleProperty<StyleFont, Font>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleFont, Object>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleFontProperty() { }

	}

	private abstract class InlineStyleIntProperty : InlineStyleProperty<StyleInt, Int32>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleInt, Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleIntProperty() { }

	}

	private abstract class InlineStyleLengthProperty : InlineStyleProperty<StyleLength, Length>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static TypeConverter<Single, StyleLength> <>9__0_0; //Field offset: 0x8
			public static TypeConverter<Int32, StyleLength> <>9__0_1; //Field offset: 0x10
			public static TypeConverter<StyleLength, Single> <>9__0_2; //Field offset: 0x18
			public static TypeConverter<StyleLength, Int32> <>9__0_3; //Field offset: 0x20

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleLength), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			internal StyleLength <.ctor>b__0_0(ref float v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleLength), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			internal StyleLength <.ctor>b__0_1(ref int v) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleLength), Member = "get_value", ReturnType = typeof(Length))]
			internal float <.ctor>b__0_2(ref StyleLength sv) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleLength), Member = "get_value", ReturnType = typeof(Length))]
			[ContainsUnimplementedInstructions]
			internal int <.ctor>b__0_3(ref StyleLength sv) { }

		}


		[CallerCount(Count = 54)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleLength, Length>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(TypeConverter`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		protected InlineStyleLengthProperty() { }

	}

	private abstract class InlineStyleListProperty : InlineStyleProperty<StyleList`1<T>, List`1<T>>
	{

		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+TransitionTimingFunctionProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleList`1<EasingFunction>, Object>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleListProperty`1() { }

	}

	private abstract class InlineStyleProperty : Property<InlineStyleAccess, TStyleValue>
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c<TStyleValue, TValue> <>9; //Field offset: 0x0
			public static TypeConverter<TStyleValue, TValue> <>9__0_0; //Field offset: 0x0
			public static TypeConverter<TValue, TStyleValue> <>9__0_1; //Field offset: 0x0
			public static TypeConverter<TStyleValue, StyleKeyword> <>9__0_2; //Field offset: 0x0
			public static TypeConverter<StyleKeyword, TStyleValue> <>9__0_3; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 8)]
			[DeduplicatedMethod]
			private static <>c() { }

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal TValue <.ctor>b__0_0(ref TStyleValue sv) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal TStyleValue <.ctor>b__0_1(ref TValue v) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal StyleKeyword <.ctor>b__0_2(ref TStyleValue sv) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			internal TStyleValue <.ctor>b__0_3(ref StyleKeyword kw) { }

		}


		public abstract string ussName
		{
			 get { } //Length: 0
		}

		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 32)]
		[DeduplicatedMethod]
		protected InlineStyleProperty`2() { }

		public abstract string get_ussName() { }

	}

	private abstract class InlineStyleRotateProperty : InlineStyleProperty<StyleRotate, Rotate>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleRotate, Rotate>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleRotateProperty() { }

	}

	private abstract class InlineStyleScaleProperty : InlineStyleProperty<StyleScale, Scale>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleScale, Scale>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleScaleProperty() { }

	}

	private abstract class InlineStyleTextShadowProperty : InlineStyleProperty<StyleTextShadow, TextShadow>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTextShadow, TextShadow>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleTextShadowProperty() { }

	}

	private abstract class InlineStyleTransformOriginProperty : InlineStyleProperty<StyleTransformOrigin, TransformOrigin>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTransformOrigin, TransformOrigin>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleTransformOriginProperty() { }

	}

	private abstract class InlineStyleTranslateProperty : InlineStyleProperty<StyleTranslate, Translate>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTranslate, Translate>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected InlineStyleTranslateProperty() { }

	}

	private class JustifyContentProperty : InlineStyleEnumProperty<Justify>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public JustifyContentProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<Justify> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Justify> value) { }

	}

	private class LeftProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public LeftProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class LetterSpacingProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public LetterSpacingProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class MarginBottomProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MarginBottomProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class MarginLeftProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MarginLeftProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class MarginRightProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MarginRightProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class MarginTopProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MarginTopProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class MaxHeightProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MaxHeightProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class MaxWidthProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MaxWidthProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class MinHeightProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MinHeightProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class MinWidthProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MinWidthProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class OpacityProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public OpacityProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class OverflowProperty : InlineStyleEnumProperty<Overflow>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public OverflowProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<Overflow> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Overflow> value) { }

	}

	private class PaddingBottomProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public PaddingBottomProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class PaddingLeftProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public PaddingLeftProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class PaddingRightProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public PaddingRightProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class PaddingTopProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public PaddingTopProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class PositionProperty : InlineStyleEnumProperty<Position>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public PositionProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<Position> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Position> value) { }

	}

	private class RightProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public RightProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class RotateProperty : InlineStyleRotateProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleRotate, Rotate>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public RotateProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleRotate GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleRotate value) { }

	}

	private class ScaleProperty : InlineStyleScaleProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleScale, Scale>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public ScaleProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleScale GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleScale value) { }

	}

	private class TextOverflowProperty : InlineStyleEnumProperty<TextOverflow>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public TextOverflowProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<TextOverflow> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflow> value) { }

	}

	private class TextShadowProperty : InlineStyleTextShadowProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTextShadow, TextShadow>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public TextShadowProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleTextShadow GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTextShadow value) { }

	}

	private class TopProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public TopProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class TransformOriginProperty : InlineStyleTransformOriginProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTransformOrigin, TransformOrigin>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public TransformOriginProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleTransformOrigin GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTransformOrigin value) { }

	}

	private class TransitionDelayProperty : InlineStyleListProperty<TimeValue>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<TimeValue>", Member = ".ctor", ReturnType = typeof(void))]
		public TransitionDelayProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleList<TimeValue> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value) { }

	}

	private class TransitionDurationProperty : InlineStyleListProperty<TimeValue>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<TimeValue>", Member = ".ctor", ReturnType = typeof(void))]
		public TransitionDurationProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleList<TimeValue> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value) { }

	}

	private class TransitionPropertyProperty : InlineStyleListProperty<StylePropertyName>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<StylePropertyName>", Member = ".ctor", ReturnType = typeof(void))]
		public TransitionPropertyProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleList<StylePropertyName> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<StylePropertyName> value) { }

	}

	private class TransitionTimingFunctionProperty : InlineStyleListProperty<EasingFunction>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public TransitionTimingFunctionProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleList<EasingFunction> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<EasingFunction> value) { }

	}

	private class TranslateProperty : InlineStyleTranslateProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTranslate, Translate>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public TranslateProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleTranslate GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTranslate value) { }

	}

	private class UnityBackgroundImageTintColorProperty : InlineStyleColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityBackgroundImageTintColorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	private class UnityEditorTextRenderingModeProperty : InlineStyleEnumProperty<EditorTextRenderingMode>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public UnityEditorTextRenderingModeProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<EditorTextRenderingMode> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<EditorTextRenderingMode> value) { }

	}

	private class UnityFontDefinitionProperty : InlineStyleFontDefinitionProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty", Member = ".ctor", ReturnType = typeof(void))]
		public UnityFontDefinitionProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFontDefinition GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFontDefinition value) { }

	}

	private class UnityFontProperty : InlineStyleFontProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleFont, Object>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityFontProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFont GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFont value) { }

	}

	private class UnityFontStyleAndWeightProperty : InlineStyleEnumProperty<FontStyle>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public UnityFontStyleAndWeightProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<FontStyle> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<FontStyle> value) { }

	}

	private class UnityOverflowClipBoxProperty : InlineStyleEnumProperty<OverflowClipBox>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public UnityOverflowClipBoxProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<OverflowClipBox> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<OverflowClipBox> value) { }

	}

	private class UnityParagraphSpacingProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityParagraphSpacingProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class UnitySliceBottomProperty : InlineStyleIntProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleInt, Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceBottomProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	private class UnitySliceLeftProperty : InlineStyleIntProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleInt, Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceLeftProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	private class UnitySliceRightProperty : InlineStyleIntProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleInt, Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceRightProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	private class UnitySliceScaleProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceScaleProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class UnitySliceTopProperty : InlineStyleIntProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleInt, Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceTopProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	private class UnitySliceTypeProperty : InlineStyleEnumProperty<SliceType>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public UnitySliceTypeProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<SliceType> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<SliceType> value) { }

	}

	private class UnityTextAlignProperty : InlineStyleEnumProperty<TextAnchor>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public UnityTextAlignProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<TextAnchor> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextAnchor> value) { }

	}

	private class UnityTextGeneratorProperty : InlineStyleEnumProperty<TextGeneratorType>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public UnityTextGeneratorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<TextGeneratorType> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextGeneratorType> value) { }

	}

	private class UnityTextOutlineColorProperty : InlineStyleColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityTextOutlineColorProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	private class UnityTextOutlineWidthProperty : InlineStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityTextOutlineWidthProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	private class UnityTextOverflowPositionProperty : InlineStyleEnumProperty<TextOverflowPosition>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public UnityTextOverflowPositionProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<TextOverflowPosition> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflowPosition> value) { }

	}

	private class VisibilityProperty : InlineStyleEnumProperty<Visibility>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public VisibilityProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<Visibility> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Visibility> value) { }

	}

	private class WhiteSpaceProperty : InlineStyleEnumProperty<WhiteSpace>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		public WhiteSpaceProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleEnum<WhiteSpace> GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<WhiteSpace> value) { }

	}

	private class WidthProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public WidthProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private class WordSpacingProperty : InlineStyleLengthProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		public virtual string ussName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public WordSpacingProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	private readonly List<IProperty`1<InlineStyleAccess>> m_PropertiesList; //Field offset: 0x18
	private readonly Dictionary<String, IProperty`1<InlineStyleAccess>> m_PropertiesHash; //Field offset: 0x20

	[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleScale, UnityEngine.UIElements.Scale>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale), typeof(Scale)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleScale, UnityEngine.UIElements.Scale>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTextShadow, UnityEngine.UIElements.TextShadow>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow), typeof(TextShadow)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTextShadow, UnityEngine.UIElements.TextShadow>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTransformOrigin, UnityEngine.UIElements.TransformOrigin>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin), typeof(TransformOrigin)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTransformOrigin, UnityEngine.UIElements.TransformOrigin>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<UnityEngine.UIElements.TimeValue>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<UnityEngine.UIElements.StylePropertyName>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleListProperty`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTranslate, UnityEngine.UIElements.Translate>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate), typeof(Translate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTranslate, UnityEngine.UIElements.Translate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleFont, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFont), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleFont, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleFontDefinitionProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition), typeof(FontDefinition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleFontDefinition, UnityEngine.UIElements.FontDefinition>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleInt, System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate), typeof(Rotate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleRotate, UnityEngine.UIElements.Rotate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleRotate, UnityEngine.UIElements.Rotate>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor), typeof(Cursor)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleCursor, UnityEngine.UIElements.Cursor>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleCursor, UnityEngine.UIElements.Cursor>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleEnumProperty`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStyleValue", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<TStyleValue, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleColorProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor), typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleColor, UnityEngine.Color>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleBackgroundProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground), typeof(Background)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackground, UnityEngine.UIElements.Background>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundPosition, UnityEngine.UIElements.BackgroundPosition>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundPosition), typeof(BackgroundPosition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundPosition, UnityEngine.UIElements.BackgroundPosition>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundRepeat), typeof(BackgroundRepeat)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundSize, UnityEngine.UIElements.BackgroundSize>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize), typeof(BackgroundSize)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundSize, UnityEngine.UIElements.BackgroundSize>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleLengthProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength), typeof(Length)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleLength, UnityEngine.UIElements.Length>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleFloatProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat), typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleFloat, System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleInt, System.Int32>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public InlineStyleAccessPropertyBag() { }

	[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void AddProperty(InlineStyleProperty<TStyleValue, TValue> property) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	public virtual PropertyCollection<InlineStyleAccess> GetProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	public virtual PropertyCollection<InlineStyleAccess> GetProperties(ref InlineStyleAccess container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool TryGetProperty(ref InlineStyleAccess container, string name, out IProperty<InlineStyleAccess>& property) { }

}

