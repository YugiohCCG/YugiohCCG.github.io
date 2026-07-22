namespace System.Xml.Schema;

[DefaultMember("Item")]
public class XmlSchemaObjectTable
{
	public enum EnumeratorType
	{
		Keys = 0,
		Values = 1,
		DictionaryEntry = 2,
	}

	public class ValuesCollection : ICollection, IEnumerable
	{
		private List<XmlSchemaObjectEntry> entries; //Field offset: 0x10
		private int size; //Field offset: 0x18

		public override int Count
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public override bool IsSynchronized
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 73
		}

		public override object SyncRoot
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 73
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ValuesCollection(List<XmlSchemaObjectEntry> entries, int size) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public override void CopyTo(Array array, int arrayIndex) { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public override int get_Count() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override bool get_IsSynchronized() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override object get_SyncRoot() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override IEnumerator GetEnumerator() { }

	}

	public struct XmlSchemaObjectEntry
	{
		internal XmlQualifiedName qname; //Field offset: 0x0
		internal XmlSchemaObject xso; //Field offset: 0x8

		[CallerCount(Count = 68)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public XmlSchemaObjectEntry(XmlQualifiedName name, XmlSchemaObject value) { }

	}

	public class XSODictionaryEnumerator : XSOEnumerator, IDictionaryEnumerator, IEnumerator
	{

		public override DictionaryEntry Entry
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 16)]
			 get { } //Length: 399
		}

		public override object Key
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 16)]
			 get { } //Length: 372
		}

		public override object Value
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 16)]
			 get { } //Length: 372
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal XSODictionaryEnumerator(List<XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 16)]
		public override DictionaryEntry get_Entry() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 16)]
		public override object get_Key() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 16)]
		public override object get_Value() { }

	}

	public class XSOEnumerator : IEnumerator
	{
		private List<XmlSchemaObjectEntry> entries; //Field offset: 0x10
		private EnumeratorType enumType; //Field offset: 0x18
		protected int currentIndex; //Field offset: 0x1C
		protected int size; //Field offset: 0x20
		protected XmlQualifiedName currentKey; //Field offset: 0x28
		protected XmlSchemaObject currentValue; //Field offset: 0x30

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 16)]
			 get { } //Length: 521
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal XSOEnumerator(List<XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 16)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 5)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override void Reset() { }

	}

	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; //Field offset: 0x10
	private List<XmlSchemaObjectEntry> entries; //Field offset: 0x18

	public int Count
	{
		[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseProcessor), Member = "IsValidAttributeGroupRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(XmlSchemaObject), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
		[CalledBy(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentExtension), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Compiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 68
	}

	public XmlSchemaObject Item
	{
		[CallerCount(Count = 88)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 114
	}

	public ICollection Values
	{
		[CallerCount(Count = 85)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 154
	}

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlSchemaObjectTable() { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaObjectTable), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileParticleElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "ProcessSubstitutionGroups", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileParticleElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaParticle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileLocalAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaAnyAttribute), typeof(XmlSchemaDerivationMethod)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Prepare", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "CleanupRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaExternal)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Preprocessor), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema), typeof(string), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "Cleanup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CleanupComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "ClearTables", ReturnType = typeof(void))]
	[CallerCount(Count = 56)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Clear() { }

	[CalledBy(Type = typeof(Datatype_NOTATION), Member = "VerifySchemaValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool Contains(XmlQualifiedName name) { }

	[CalledBy(Type = typeof(XmlSchemaObjectTable), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaObjectTable), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaObjectTable), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private int FindIndexByValue(XmlSchemaObject xso) { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "IsValidAttributeGroupRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(XmlSchemaObject), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "MoveAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaSimpleContentExtension), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileAttributeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttributeGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int get_Count() { }

	[CallerCount(Count = 88)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ICollection get_Values() { }

	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaRedefine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IDictionaryEnumerator GetEnumerator() { }

	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "IsValidAttributeGroupRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(XmlSchemaObject), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "IsValidGroupRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(XmlSchemaObject), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "IsValidTypeRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject), typeof(XmlSchemaObject), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedefineEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessRedefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaRedefine)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "Compile", ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "FindIndexByValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "Compile", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "CopyFromCompiledSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "RemoveSchemaFromGlobalTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "FindIndexByValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Remove(XmlQualifiedName name) { }

	[CalledBy(Type = typeof(Compiler), Member = "UpdateSForSSimpleTypes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "Compile", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaObjectTable), Member = "FindIndexByValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

}

