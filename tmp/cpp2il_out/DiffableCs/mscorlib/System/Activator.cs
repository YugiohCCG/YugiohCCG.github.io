namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Activator))]
[ComVisible(True)]
public sealed class Activator
{

	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Net.WebRequestPrefixElement", Member = "get_Creator", ReturnType = "System.Net.IWebRequestCreate")]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyNodeTypeHandlerBase", Member = "CreateNodeTypeHandlerFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture) { }

	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes) { }

	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ChannelServices), Member = "CreateProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProviderData)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptionProvider", Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IServiceProvider), typeof(Type), "System.Type[]", "System.Object[]"}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	public static object CreateInstance(Type type, Object[] args) { }

	[CalledBy(Type = typeof(RemoteActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	public static object CreateInstance(Type type, Object[] args, Object[] activationAttributes) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	public static object CreateInstance(Type type) { }

	[CalledBy(Type = typeof(SingletonIdentity), Member = "GetServerObject", ReturnType = typeof(MarshalByRefObject))]
	[CalledBy(Type = "System.Data.Common.SqlUdtStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlReader", "System.Xml.Serialization.XmlRootAttribute"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.SqlUdtStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlReader", "System.Xml.Serialization.XmlRootAttribute"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.DataTable", Member = "CreateInstance", ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.DataSet", Member = "Clone", ReturnType = "System.Data.DataSet")]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "LookupProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializableMapping", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlRootAttribute", typeof(string), typeof(string), "System.Xml.Serialization.TypeData", typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "ReadXmlSerializableElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlTypeMapping", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "InitializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "AddListValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(Object&), typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlTypeMapElementInfo"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationReaderInterpreter", Member = "ReadClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlTypeMapping", typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "AsyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	public static object CreateInstance(Type type, bool nonPublic) { }

	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.Event", Member = "Map", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOutputType", "TMapType"}, ReturnType = "TOutputType")]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "CreateClassInstance", ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DataType[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.FixedAttachmentArray`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<DataType>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUnsafeUtils", Member = "CompareHashes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOldValue", "TOldGetter", "TNewValue", "TNewGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Void*", typeof(int), "System.Void*", "System.Int32*", "System.Int32*", typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlEnumAttributeDescription`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleKeyword&"}, ReturnType = "TStyleValue")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&"}, ReturnType = "TStyleValue")]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUnsafeUtils", Member = "CombineHashes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Void*", "UnityEngine.Hash128*"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_HasElementType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static T CreateInstance() { }

}

