//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\dev\cql\src\Grammar/fhirpath.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="fhirpathParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IfhirpathListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>indexerExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexerExpression([NotNull] fhirpathParser.IndexerExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>indexerExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexerExpression([NotNull] fhirpathParser.IndexerExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>polarityExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPolarityExpression([NotNull] fhirpathParser.PolarityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>polarityExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPolarityExpression([NotNull] fhirpathParser.PolarityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] fhirpathParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] fhirpathParser.AdditiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] fhirpathParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] fhirpathParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>unionExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnionExpression([NotNull] fhirpathParser.UnionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unionExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnionExpression([NotNull] fhirpathParser.UnionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>orExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrExpression([NotNull] fhirpathParser.OrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>orExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrExpression([NotNull] fhirpathParser.OrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>andExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpression([NotNull] fhirpathParser.AndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>andExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpression([NotNull] fhirpathParser.AndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>membershipExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMembershipExpression([NotNull] fhirpathParser.MembershipExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>membershipExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMembershipExpression([NotNull] fhirpathParser.MembershipExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>inequalityExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInequalityExpression([NotNull] fhirpathParser.InequalityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>inequalityExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInequalityExpression([NotNull] fhirpathParser.InequalityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>invocationExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvocationExpression([NotNull] fhirpathParser.InvocationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>invocationExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvocationExpression([NotNull] fhirpathParser.InvocationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>equalityExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpression([NotNull] fhirpathParser.EqualityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>equalityExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpression([NotNull] fhirpathParser.EqualityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>impliesExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImpliesExpression([NotNull] fhirpathParser.ImpliesExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>impliesExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImpliesExpression([NotNull] fhirpathParser.ImpliesExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>termExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermExpression([NotNull] fhirpathParser.TermExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>termExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermExpression([NotNull] fhirpathParser.TermExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>typeExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeExpression([NotNull] fhirpathParser.TypeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>typeExpression</c>
	/// labeled alternative in <see cref="fhirpathParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeExpression([NotNull] fhirpathParser.TypeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>invocationTerm</c>
	/// labeled alternative in <see cref="fhirpathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvocationTerm([NotNull] fhirpathParser.InvocationTermContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>invocationTerm</c>
	/// labeled alternative in <see cref="fhirpathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvocationTerm([NotNull] fhirpathParser.InvocationTermContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>literalTerm</c>
	/// labeled alternative in <see cref="fhirpathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralTerm([NotNull] fhirpathParser.LiteralTermContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>literalTerm</c>
	/// labeled alternative in <see cref="fhirpathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralTerm([NotNull] fhirpathParser.LiteralTermContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>externalConstantTerm</c>
	/// labeled alternative in <see cref="fhirpathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExternalConstantTerm([NotNull] fhirpathParser.ExternalConstantTermContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>externalConstantTerm</c>
	/// labeled alternative in <see cref="fhirpathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExternalConstantTerm([NotNull] fhirpathParser.ExternalConstantTermContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedTerm</c>
	/// labeled alternative in <see cref="fhirpathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedTerm([NotNull] fhirpathParser.ParenthesizedTermContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedTerm</c>
	/// labeled alternative in <see cref="fhirpathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedTerm([NotNull] fhirpathParser.ParenthesizedTermContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>nullLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullLiteral([NotNull] fhirpathParser.NullLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nullLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullLiteral([NotNull] fhirpathParser.NullLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>booleanLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanLiteral([NotNull] fhirpathParser.BooleanLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanLiteral([NotNull] fhirpathParser.BooleanLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stringLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringLiteral([NotNull] fhirpathParser.StringLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stringLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringLiteral([NotNull] fhirpathParser.StringLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>numberLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberLiteral([NotNull] fhirpathParser.NumberLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numberLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberLiteral([NotNull] fhirpathParser.NumberLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>dateTimeLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDateTimeLiteral([NotNull] fhirpathParser.DateTimeLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>dateTimeLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDateTimeLiteral([NotNull] fhirpathParser.DateTimeLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>timeLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTimeLiteral([NotNull] fhirpathParser.TimeLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>timeLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTimeLiteral([NotNull] fhirpathParser.TimeLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>quantityLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuantityLiteral([NotNull] fhirpathParser.QuantityLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>quantityLiteral</c>
	/// labeled alternative in <see cref="fhirpathParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuantityLiteral([NotNull] fhirpathParser.QuantityLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.externalConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExternalConstant([NotNull] fhirpathParser.ExternalConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.externalConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExternalConstant([NotNull] fhirpathParser.ExternalConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>memberInvocation</c>
	/// labeled alternative in <see cref="fhirpathParser.invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberInvocation([NotNull] fhirpathParser.MemberInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>memberInvocation</c>
	/// labeled alternative in <see cref="fhirpathParser.invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberInvocation([NotNull] fhirpathParser.MemberInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>functionInvocation</c>
	/// labeled alternative in <see cref="fhirpathParser.invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionInvocation([NotNull] fhirpathParser.FunctionInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionInvocation</c>
	/// labeled alternative in <see cref="fhirpathParser.invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionInvocation([NotNull] fhirpathParser.FunctionInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>thisInvocation</c>
	/// labeled alternative in <see cref="fhirpathParser.invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThisInvocation([NotNull] fhirpathParser.ThisInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>thisInvocation</c>
	/// labeled alternative in <see cref="fhirpathParser.invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThisInvocation([NotNull] fhirpathParser.ThisInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] fhirpathParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] fhirpathParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.paramList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParamList([NotNull] fhirpathParser.ParamListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.paramList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParamList([NotNull] fhirpathParser.ParamListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuantity([NotNull] fhirpathParser.QuantityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuantity([NotNull] fhirpathParser.QuantityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnit([NotNull] fhirpathParser.UnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnit([NotNull] fhirpathParser.UnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.dateTimePrecision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDateTimePrecision([NotNull] fhirpathParser.DateTimePrecisionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.dateTimePrecision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDateTimePrecision([NotNull] fhirpathParser.DateTimePrecisionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.pluralDateTimePrecision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPluralDateTimePrecision([NotNull] fhirpathParser.PluralDateTimePrecisionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.pluralDateTimePrecision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPluralDateTimePrecision([NotNull] fhirpathParser.PluralDateTimePrecisionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.typeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeSpecifier([NotNull] fhirpathParser.TypeSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.typeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeSpecifier([NotNull] fhirpathParser.TypeSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.qualifiedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedIdentifier([NotNull] fhirpathParser.QualifiedIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.qualifiedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedIdentifier([NotNull] fhirpathParser.QualifiedIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="fhirpathParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] fhirpathParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="fhirpathParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] fhirpathParser.IdentifierContext context);
}
