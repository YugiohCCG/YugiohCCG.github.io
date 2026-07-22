namespace UnityEngine.UIElements;

internal class ResolvedStyleAccessPropertyBag : PropertyBag<ResolvedStyleAccess>, INamedProperties<ResolvedStyleAccess>
{
	private class AlignContentProperty : ResolvedEnumProperty<Align>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public AlignContentProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	private class AlignItemsProperty : ResolvedEnumProperty<Align>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public AlignItemsProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	private class AlignSelfProperty : ResolvedEnumProperty<Align>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public AlignSelfProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	private class BackgroundColorProperty : ResolvedColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundColorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	private class BackgroundImageProperty : ResolvedBackgroundProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundImageProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Background GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Background value) { }

	}

	private class BackgroundPositionXProperty : ResolvedBackgroundPositionProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundPositionXProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual BackgroundPosition GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundPosition value) { }

	}

	private class BackgroundPositionYProperty : ResolvedBackgroundPositionProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundPositionYProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual BackgroundPosition GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundPosition value) { }

	}

	private class BackgroundRepeatProperty : ResolvedBackgroundRepeatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundRepeatProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual BackgroundRepeat GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundRepeat value) { }

	}

	private class BackgroundSizeProperty : ResolvedBackgroundSizeProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BackgroundSizeProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual BackgroundSize GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundSize value) { }

	}

	private class BorderBottomColorProperty : ResolvedColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderBottomColorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	private class BorderBottomLeftRadiusProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderBottomLeftRadiusProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class BorderBottomRightRadiusProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderBottomRightRadiusProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class BorderBottomWidthProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderBottomWidthProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class BorderLeftColorProperty : ResolvedColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderLeftColorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	private class BorderLeftWidthProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderLeftWidthProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class BorderRightColorProperty : ResolvedColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderRightColorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	private class BorderRightWidthProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderRightWidthProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class BorderTopColorProperty : ResolvedColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderTopColorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	private class BorderTopLeftRadiusProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderTopLeftRadiusProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class BorderTopRightRadiusProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderTopRightRadiusProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class BorderTopWidthProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BorderTopWidthProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class BottomProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BottomProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class ColorProperty : ResolvedColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public ColorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	private class DisplayProperty : ResolvedEnumProperty<DisplayStyle>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public DisplayProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual DisplayStyle GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, DisplayStyle value) { }

	}

	private class FlexBasisProperty : ResolvedStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public FlexBasisProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	private class FlexDirectionProperty : ResolvedEnumProperty<FlexDirection>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public FlexDirectionProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual FlexDirection GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, FlexDirection value) { }

	}

	private class FlexGrowProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public FlexGrowProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class FlexShrinkProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public FlexShrinkProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class FlexWrapProperty : ResolvedEnumProperty<Wrap>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public FlexWrapProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Wrap GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Wrap value) { }

	}

	private class FontSizeProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public FontSizeProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class HeightProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public HeightProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class JustifyContentProperty : ResolvedEnumProperty<Justify>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public JustifyContentProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Justify GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Justify value) { }

	}

	private class LeftProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public LeftProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class LetterSpacingProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public LetterSpacingProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class MarginBottomProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MarginBottomProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class MarginLeftProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MarginLeftProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class MarginRightProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MarginRightProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class MarginTopProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MarginTopProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class MaxHeightProperty : ResolvedStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MaxHeightProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	private class MaxWidthProperty : ResolvedStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MaxWidthProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	private class MinHeightProperty : ResolvedStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MinHeightProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	private class MinWidthProperty : ResolvedStyleFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public MinWidthProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	private class OpacityProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public OpacityProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class PaddingBottomProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public PaddingBottomProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class PaddingLeftProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public PaddingLeftProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class PaddingRightProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public PaddingRightProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class PaddingTopProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public PaddingTopProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class PositionProperty : ResolvedEnumProperty<Position>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public PositionProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Position GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Position value) { }

	}

	private abstract class ResolvedBackgroundPositionProperty : ResolvedStyleProperty<BackgroundPosition>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedBackgroundPositionProperty() { }

	}

	private abstract class ResolvedBackgroundProperty : ResolvedStyleProperty<Background>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedBackgroundProperty() { }

	}

	private abstract class ResolvedBackgroundRepeatProperty : ResolvedStyleProperty<BackgroundRepeat>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedBackgroundRepeatProperty() { }

	}

	private abstract class ResolvedBackgroundSizeProperty : ResolvedStyleProperty<BackgroundSize>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedBackgroundSizeProperty() { }

	}

	private abstract class ResolvedColorProperty : ResolvedStyleProperty<Color>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedColorProperty() { }

	}

	private abstract class ResolvedEnumProperty : ResolvedStyleProperty<TValue>
	{

		[CallerCount(Count = 42)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected ResolvedEnumProperty`1() { }

	}

	private abstract class ResolvedFloatProperty : ResolvedStyleProperty<Single>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedFloatProperty() { }

	}

	private abstract class ResolvedFontDefinitionProperty : ResolvedStyleProperty<FontDefinition>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedFontDefinitionProperty() { }

	}

	private abstract class ResolvedFontProperty : ResolvedStyleProperty<Font>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedFontProperty() { }

	}

	private abstract class ResolvedIntProperty : ResolvedStyleProperty<Int32>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedIntProperty() { }

	}

	private abstract class ResolvedListProperty : ResolvedStyleProperty<IEnumerable`1<T>>
	{

		[CallerCount(Count = 42)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected ResolvedListProperty`1() { }

	}

	private abstract class ResolvedRotateProperty : ResolvedStyleProperty<Rotate>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedRotateProperty() { }

	}

	private abstract class ResolvedScaleProperty : ResolvedStyleProperty<Scale>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedScaleProperty() { }

	}

	private abstract class ResolvedStyleFloatProperty : ResolvedStyleProperty<StyleFloat>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedStyleFloatProperty() { }

	}

	private abstract class ResolvedStyleProperty : Property<ResolvedStyleAccess, TValue>
	{

		public abstract string ussName
		{
			 get { } //Length: 0
		}

		[CallerCount(Count = 131)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		protected ResolvedStyleProperty`1() { }

		public abstract string get_ussName() { }

	}

	private abstract class ResolvedVector3Property : ResolvedStyleProperty<Vector3>
	{

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		protected ResolvedVector3Property() { }

	}

	private class RightProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public RightProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class RotateProperty : ResolvedRotateProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public RotateProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Rotate GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Rotate value) { }

	}

	private class ScaleProperty : ResolvedScaleProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public ScaleProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Scale GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Scale value) { }

	}

	private class TextOverflowProperty : ResolvedEnumProperty<TextOverflow>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public TextOverflowProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual TextOverflow GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextOverflow value) { }

	}

	private class TopProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public TopProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class TransformOriginProperty : ResolvedVector3Property
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public TransformOriginProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Vector3 GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Vector3 value) { }

	}

	private class TransitionDelayProperty : ResolvedListProperty<TimeValue>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public TransitionDelayProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual IEnumerable<TimeValue> GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<TimeValue> value) { }

	}

	private class TransitionDurationProperty : ResolvedListProperty<TimeValue>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public TransitionDurationProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual IEnumerable<TimeValue> GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<TimeValue> value) { }

	}

	private class TransitionPropertyProperty : ResolvedListProperty<StylePropertyName>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public TransitionPropertyProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual IEnumerable<StylePropertyName> GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<StylePropertyName> value) { }

	}

	private class TransitionTimingFunctionProperty : ResolvedListProperty<EasingFunction>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public TransitionTimingFunctionProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual IEnumerable<EasingFunction> GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<EasingFunction> value) { }

	}

	private class TranslateProperty : ResolvedVector3Property
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public TranslateProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Vector3 GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Vector3 value) { }

	}

	private class UnityBackgroundImageTintColorProperty : ResolvedColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityBackgroundImageTintColorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	private class UnityEditorTextRenderingModeProperty : ResolvedEnumProperty<EditorTextRenderingMode>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public UnityEditorTextRenderingModeProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual EditorTextRenderingMode GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, EditorTextRenderingMode value) { }

	}

	private class UnityFontDefinitionProperty : ResolvedFontDefinitionProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityFontDefinitionProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual FontDefinition GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, FontDefinition value) { }

	}

	private class UnityFontProperty : ResolvedFontProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityFontProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Font GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Font value) { }

	}

	private class UnityFontStyleAndWeightProperty : ResolvedEnumProperty<FontStyle>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public UnityFontStyleAndWeightProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual FontStyle GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, FontStyle value) { }

	}

	private class UnityParagraphSpacingProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityParagraphSpacingProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class UnitySliceBottomProperty : ResolvedIntProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceBottomProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	private class UnitySliceLeftProperty : ResolvedIntProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceLeftProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	private class UnitySliceRightProperty : ResolvedIntProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceRightProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	private class UnitySliceScaleProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceScaleProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class UnitySliceTopProperty : ResolvedIntProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnitySliceTopProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	private class UnitySliceTypeProperty : ResolvedEnumProperty<SliceType>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public UnitySliceTypeProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual SliceType GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, SliceType value) { }

	}

	private class UnityTextAlignProperty : ResolvedEnumProperty<TextAnchor>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public UnityTextAlignProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual TextAnchor GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextAnchor value) { }

	}

	private class UnityTextGeneratorProperty : ResolvedEnumProperty<TextGeneratorType>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public UnityTextGeneratorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual TextGeneratorType GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextGeneratorType value) { }

	}

	private class UnityTextOutlineColorProperty : ResolvedColorProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityTextOutlineColorProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	private class UnityTextOutlineWidthProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public UnityTextOutlineWidthProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class UnityTextOverflowPositionProperty : ResolvedEnumProperty<TextOverflowPosition>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public UnityTextOverflowPositionProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual TextOverflowPosition GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextOverflowPosition value) { }

	}

	private class VisibilityProperty : ResolvedEnumProperty<Visibility>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public VisibilityProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual Visibility GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, Visibility value) { }

	}

	private class WhiteSpaceProperty : ResolvedEnumProperty<WhiteSpace>
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public WhiteSpaceProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual WhiteSpace GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, WhiteSpace value) { }

	}

	private class WidthProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public WidthProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private class WordSpacingProperty : ResolvedFloatProperty
	{

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
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
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public WordSpacingProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		public virtual string get_ussName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	private readonly List<IProperty`1<ResolvedStyleAccess>> m_PropertiesList; //Field offset: 0x18
	private readonly Dictionary<String, IProperty`1<ResolvedStyleAccess>> m_PropertiesHash; //Field offset: 0x20

	[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.FontDefinition>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.Scale>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.Rotate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.StyleFloat>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.BackgroundSize>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.BackgroundRepeat>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.BackgroundPosition>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.Color>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleProperty`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<System.Int32Enum>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 2)]
	public ResolvedStyleAccessPropertyBag() { }

	[CalledBy(Type = typeof(ResolvedStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void AddProperty(ResolvedStyleProperty<TValue> property) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	public virtual PropertyCollection<ResolvedStyleAccess> GetProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	public virtual PropertyCollection<ResolvedStyleAccess> GetProperties(ref ResolvedStyleAccess container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool TryGetProperty(ref ResolvedStyleAccess container, string name, out IProperty<ResolvedStyleAccess>& property) { }

}

