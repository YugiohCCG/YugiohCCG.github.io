namespace System.ComponentModel.Design;

public abstract class DesignerOptionService
{
	[DefaultMember("Item")]
	[Editor(null, "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[TypeConverter(typeof(DesignerOptionConverter))]
	internal sealed class DesignerOptionCollection : ICollection
	{
		private sealed class WrappedPropertyDescriptor : PropertyDescriptor
		{
			private object target; //Field offset: 0x88
			private PropertyDescriptor property; //Field offset: 0x90

			public virtual AttributeCollection Attributes
			{
				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				 get { } //Length: 42
			}

			public virtual Type ComponentType
			{
				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				 get { } //Length: 42
			}

			public virtual bool IsReadOnly
			{
				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[CallsUnknownMethods(Count = 1)]
				 get { } //Length: 42
			}

			public virtual Type PropertyType
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
				[Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
				[Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", ReturnType = typeof(void))]
				[Calls(Type = typeof(FtpWebRequest), Member = "FinishRequestStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FtpWebRequest+RequestStage"}, ReturnType = "System.Net.FtpWebRequest+RequestStage")]
				[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(FormattableString))]
				[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
				[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
				[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
				[CallsDeduplicatedMethods(Count = 16)]
				[CallsUnknownMethods(Count = 27)]
				[ContainsInvalidInstructions]
				 get { } //Length: 3042
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 3)]
			internal WrappedPropertyDescriptor(PropertyDescriptor property, object target) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual bool CanResetValue(object component) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual AttributeCollection get_Attributes() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual Type get_ComponentType() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual bool get_IsReadOnly() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
			[Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(LazyAsyncResult), Member = "get_InternalPeekCompleted", ReturnType = typeof(bool))]
			[Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", ReturnType = typeof(void))]
			[Calls(Type = typeof(FtpWebRequest), Member = "FinishRequestStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FtpWebRequest+RequestStage"}, ReturnType = "System.Net.FtpWebRequest+RequestStage")]
			[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(FormattableString))]
			[Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FormattableString), typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
			[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
			[CallsDeduplicatedMethods(Count = 16)]
			[CallsUnknownMethods(Count = 27)]
			[ContainsInvalidInstructions]
			public virtual Type get_PropertyType() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual object GetValue(object component) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual void ResetValue(object component) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual void SetValue(object component, object value) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			public virtual bool ShouldSerializeValue(object component) { }

		}

		private DesignerOptionService _service; //Field offset: 0x10
		private string _name; //Field offset: 0x18
		private object _value; //Field offset: 0x20
		private ArrayList _children; //Field offset: 0x28
		private PropertyDescriptorCollection _properties; //Field offset: 0x30

		public override int Count
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DesignerOptionCollection), Member = "EnsurePopulated", ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 52
		}

		public string Name
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public PropertyDescriptorCollection Properties
		{
			[CalledBy(Type = typeof(DesignerOptionCollection), Member = "get_Properties", ReturnType = typeof(PropertyDescriptorCollection))]
			[CalledBy(Type = typeof(DesignerOptionConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
			[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(DesignerOptionCollection), Member = "EnsurePopulated", ReturnType = typeof(void))]
			[Calls(Type = typeof(DesignerOptionCollection), Member = "get_Properties", ReturnType = typeof(PropertyDescriptorCollection))]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 10)]
			[CallsUnknownMethods(Count = 28)]
			 get { } //Length: 1732
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(Count = 2063)]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DesignerOptionCollection), Member = "EnsurePopulated", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override void CopyTo(Array array, int index) { }

		[CalledBy(Type = typeof(DesignerOptionCollection), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DesignerOptionCollection), Member = "get_Properties", ReturnType = typeof(PropertyDescriptorCollection))]
		[CalledBy(Type = typeof(DesignerOptionCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DesignerOptionCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(DesignerOptionConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private void EnsurePopulated() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DesignerOptionCollection), Member = "EnsurePopulated", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override int get_Count() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public string get_Name() { }

		[CalledBy(Type = typeof(DesignerOptionCollection), Member = "get_Properties", ReturnType = typeof(PropertyDescriptorCollection))]
		[CalledBy(Type = typeof(DesignerOptionConverter), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(object), typeof(Attribute[])}, ReturnType = typeof(PropertyDescriptorCollection))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Attribute[]), typeof(bool), typeof(bool)}, ReturnType = typeof(PropertyDescriptorCollection))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DesignerOptionCollection), Member = "EnsurePopulated", ReturnType = typeof(void))]
		[Calls(Type = typeof(DesignerOptionCollection), Member = "get_Properties", ReturnType = typeof(PropertyDescriptorCollection))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 28)]
		public PropertyDescriptorCollection get_Properties() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DesignerOptionCollection), Member = "EnsurePopulated", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override IEnumerator GetEnumerator() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		private override object System.Collections.ICollection.get_SyncRoot() { }

	}

	public sealed class DesignerOptionConverter : TypeConverter
	{
		private class OptionPropertyDescriptor : PropertyDescriptor
		{
			private DesignerOptionCollection _option; //Field offset: 0x88

			public virtual Type ComponentType
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[CallsUnknownMethods(Count = 1)]
				[DeduplicatedMethod]
				 get { } //Length: 32
			}

			public virtual bool IsReadOnly
			{
				[CallerCount(Count = 23)]
				[DeduplicatedMethod]
				 get { } //Length: 3
			}

			public virtual Type PropertyType
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
				[CallsUnknownMethods(Count = 1)]
				[DeduplicatedMethod]
				 get { } //Length: 32
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			internal OptionPropertyDescriptor(DesignerOptionCollection option) { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			public virtual bool CanResetValue(object component) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public virtual Type get_ComponentType() { }

			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			public virtual bool get_IsReadOnly() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public virtual Type get_PropertyType() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public virtual object GetValue(object component) { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			public virtual void ResetValue(object component) { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			public virtual void SetValue(object component, object value) { }

			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			public virtual bool ShouldSerializeValue(object component) { }

		}


		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DesignerOptionConverter() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		public virtual object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DesignerOptionCollection), Member = "EnsurePopulated", ReturnType = typeof(void))]
		[Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DesignerOptionCollection), Member = "get_Properties", ReturnType = typeof(PropertyDescriptorCollection))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 23)]
		public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	}


	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void PopulateOptionCollection(DesignerOptionCollection options) { }

}

