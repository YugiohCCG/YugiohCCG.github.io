namespace System.Xml.Schema;

internal abstract class FacetsChecker
{
	private struct FacetsCompiler
	{
		private struct Map
		{
			internal char match; //Field offset: 0x0
			internal string replacement; //Field offset: 0x8

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal Map(char m, string r) { }

		}

		private static readonly Map[] c_map; //Field offset: 0x0
		private DatatypeImplementation datatype; //Field offset: 0x0
		private RestrictionFacets derivedRestriction; //Field offset: 0x8
		private RestrictionFlags baseFlags; //Field offset: 0x10
		private RestrictionFlags baseFixedFlags; //Field offset: 0x14
		private RestrictionFlags validRestrictionFlags; //Field offset: 0x18
		private XmlSchemaDatatype nonNegativeInt; //Field offset: 0x20
		private XmlSchemaDatatype builtInType; //Field offset: 0x28
		private XmlTypeCode builtInEnum; //Field offset: 0x30
		private bool firstPattern; //Field offset: 0x34
		private StringBuilder regStr; //Field offset: 0x38
		private XmlSchemaPatternFacet pattern_facet; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 19)]
		private static FacetsCompiler() { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DatatypeImplementation), Member = "GetSimpleTypeFromTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeCode)}, ReturnType = typeof(XmlSchemaSimpleType))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		public FacetsCompiler(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMinLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMaxLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompilePatternFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaPatternFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileEnumerationFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileWhitespaceFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMaxInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMaxExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMinInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMinExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileTotalDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileFractionDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(XmlSchemaDatatype), Member = "get_TypeCodeString", ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMaxInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMaxExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMinInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMinExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 41)]
		private void CheckValue(object value, XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CopyFacetsFromBaseType", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 37)]
		internal void CompileFacetCombinations() { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 14)]
		internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 22)]
		internal void CompileLengthFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 18)]
		internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 18)]
		internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FacetsCompiler), Member = "ParseFacetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaDatatype), typeof(XmlSchemaFacet), typeof(string), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 15)]
		internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FacetsCompiler), Member = "CheckProhibitedFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(RestrictionFlags), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 22)]
		internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileFacetCombinations", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private void CopyFacetsFromBaseType() { }

		[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(FacetsCompiler), Member = "Preprocess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 23)]
		internal void FinishFacetCompile() { }

		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMinLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMaxLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileEnumerationFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMaxInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMaxExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMinInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileMinExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileTotalDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FacetsCompiler), Member = "CompileFractionDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 12)]
		private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

		[CalledBy(Type = typeof(FacetsCompiler), Member = "FinishFacetCompile", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private static string Preprocess(string pattern) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void SetFlag(RestrictionFlags flag) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	}


	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected FacetsChecker() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlComplianceUtil), Member = "CDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	internal override Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlComplianceUtil), Member = "NonCDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlComplianceUtil), Member = "CDataNormalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileFacetCombinations", ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "FinishFacetCompile", ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileFractionDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileTotalDigitsFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileMaxInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileMaxExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileMinInclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileMinExclusiveFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileEnumerationFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet), typeof(IXmlNamespaceResolver), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileWhitespaceFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompilePatternFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaPatternFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileMaxLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileMinLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = "CompileLengthFacet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FacetsCompiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(RestrictionFacets)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	internal override RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	internal static decimal Power(int x, int y) { }

}

