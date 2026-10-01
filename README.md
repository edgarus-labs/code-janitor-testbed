# Code Janitor testbed

A solution of **deliberately bad C#**: one class per cleanup option of
[Code Janitor for VS Code](https://github.com/edgarus-labs/code-janitor-vscode), named after the option, and a
manifest (`scenarios.json`) that says what the cleanup must do to it.

It exists to prove two things on real files, with the real compiler:

1. every cleanup does what its option promises on code that violates it, and
2. no cleanup breaks the code: the solution still builds, and every scenario still prints the same value.

The code here is bad on purpose. Do not copy it.

## Layout

| Path | What it is |
| --- | --- |
| `src/Scenarios/<Category>/<Option>/<Option>.cs` | The bad code of one option (class `<Option>` with a `Run()` method returning a deterministic value). |
| `src/Scenarios/<Category>/<Option>/.editorconfig` | Only for the `.editorconfig` scenarios: the rules that scenario needs (`root = true`). |
| `src/Scenarios.Razor/Components/<Option>.razor` | The Razor scenarios (Razor SDK project). |
| `src/Scenarios/Program.cs` | Calls every `Run()` and prints `<Option>=<value>`; used to compare behavior before and after a cleanup. |
| `scenarios.json` | Per scenario: the file, the options that are on, and the checks on the cleaned text. |

There is deliberately no `.editorconfig` at the root: it would apply to every scenario.

## How it is used

The extension's CI clones this repository and runs `npm run test:testbed`, which, for every scenario:

1. runs the cleanup with **only that option on** and checks the result against `scenarios.json`;
2. cleans the result again and expects no change (idempotence);
3. builds the whole solution after every cleanup, runs it and compares what it prints with the unfixed solution;
4. repeats step 3 with every option on at once.

A scenario whose option is only reported (never applied) must leave the file unchanged.

## Building the unfixed solution

```sh
dotnet build CodeJanitor.Testbed.slnx
dotnet run --project src/Scenarios --no-build
```

It needs the .NET 10 SDK. Compiler warnings are expected.

## Scenarios (161)

### Code Style rules (`codeJanitor.cleanup.codeStyleRules`) (53)

`CsharpPreferredModifierOrder`, `CsharpPreferStaticLocalFunction`, `CsharpPreferStaticAnonymousFunction`, `CsharpStylePreferReadonlyStruct`, `CsharpStylePreferReadonlyStructMember`, `CsharpPreferBraces`, `CsharpPreferSimpleUsingStatement`, `CsharpStylePreferMethodGroupConversion`, `CsharpStyleExpressionBodiedMethods`, `CsharpStyleExpressionBodiedConstructors`, `CsharpStyleExpressionBodiedOperators`, `CsharpStyleExpressionBodiedProperties`, `CsharpStyleExpressionBodiedIndexers`, `CsharpStyleExpressionBodiedAccessors`, `CsharpStyleExpressionBodiedLocalFunctions`, `CsharpStylePatternMatchingOverIsWithCastCheck`, `CsharpStylePatternMatchingOverAsWithNullCheck`, `CsharpStylePreferPatternMatching`, `CsharpStylePreferNotPattern`, `CsharpStylePreferExtendedPropertyPattern`, `CsharpStylePreferSwitchExpression`, `DotnetStyleCoalesceExpression`, `DotnetStyleNullPropagation`, `CsharpStyleThrowExpression`, `CsharpStyleConditionalDelegateCall`, `CsharpStylePreferPrimaryConstructors`, `CsharpStyleImplicitObjectCreationWhenTypeIsApparent`, `CsharpStylePreferIndexOperator`, `CsharpStylePreferRangeOperator`, `CsharpStylePreferUtf8StringLiterals`, `CsharpStylePreferTupleSwap`, `CsharpStyleDeconstructedVariableDeclaration`, `CsharpStyleUnusedValueAssignmentPreference`, `CsharpPreferSimpleDefaultExpression`, `DotnetStylePreferAutoProperties`, `DotnetStylePreferCompoundAssignment`, `DotnetStylePreferSimplifiedBooleanExpressions`, `DotnetStylePreferSimplifiedInterpolation`, `DotnetStyleObjectInitializer`, `DotnetStyleCollectionInitializer`, `DotnetStyleExplicitTupleNames`, `DotnetStylePreferInferredTupleNames`, `DotnetStylePreferInferredAnonymousTypeMemberNames`, `DotnetStyleQualificationForField`, `DotnetStyleQualificationForProperty`, `DotnetStyleQualificationForMethod`, `DotnetStyleQualificationForEvent`, `DotnetStylePredefinedTypeForLocalsParametersMembers`, `DotnetStylePredefinedTypeForMemberAccess`, `DotnetStyleParenthesesInArithmeticBinaryOperators`, `DotnetStyleParenthesesInRelationalBinaryOperators`, `DotnetStyleParenthesesInOtherBinaryOperators`, `DotnetStyleParenthesesInOtherOperators`

### Cleanup settings (`codeJanitor.cleanup.*`) (70)

`InsertBlankLinePaddingBeforeClasses`, `InsertBlankLinePaddingAfterClasses`, `InsertBlankLinePaddingBeforeDelegates`, `InsertBlankLinePaddingAfterDelegates`, `InsertBlankLinePaddingBeforeEnumerations`, `InsertBlankLinePaddingAfterEnumerations`, `InsertBlankLinePaddingBeforeEvents`, `InsertBlankLinePaddingAfterEvents`, `InsertBlankLinePaddingBeforeFieldsMultiLine`, `InsertBlankLinePaddingAfterFieldsMultiLine`, `InsertBlankLinePaddingBeforeFieldsSingleLine`, `InsertBlankLinePaddingAfterFieldsSingleLine`, `InsertBlankLinePaddingBeforeInterfaces`, `InsertBlankLinePaddingAfterInterfaces`, `InsertBlankLinePaddingBeforeMethods`, `InsertBlankLinePaddingAfterMethods`, `InsertBlankLinePaddingBeforeNamespaces`, `InsertBlankLinePaddingAfterNamespaces`, `InsertBlankLinePaddingBeforePropertiesMultiLine`, `InsertBlankLinePaddingAfterPropertiesMultiLine`, `InsertBlankLinePaddingBeforePropertiesSingleLine`, `InsertBlankLinePaddingAfterPropertiesSingleLine`, `InsertBlankLinePaddingBeforeStructs`, `InsertBlankLinePaddingAfterStructs`, `InsertBlankLinePaddingBeforeRegionTags`, `InsertBlankLinePaddingAfterRegionTags`, `InsertBlankLinePaddingBeforeEndRegionTags`, `InsertBlankLinePaddingAfterEndRegionTags`, `InsertBlankLinePaddingBeforeUsingStatementBlocks`, `InsertBlankLinePaddingAfterUsingStatementBlocks`, `InsertBlankLinePaddingBeforeCaseStatements`, `InsertBlankLinePaddingBeforeSingleLineComments`, `InsertExplicitAccessModifiersOnClasses`, `InsertExplicitAccessModifiersOnDelegates`, `InsertExplicitAccessModifiersOnEnumerations`, `InsertExplicitAccessModifiersOnEvents`, `InsertExplicitAccessModifiersOnFields`, `InsertExplicitAccessModifiersOnInterfaces`, `InsertExplicitAccessModifiersOnMethods`, `InsertExplicitAccessModifiersOnProperties`, `InsertExplicitAccessModifiersOnStructs`, `ConvertToFileScopedNamespace`, `ConvertToVarWhenApparent`, `MakeFieldsReadonlyWhenSafe`, `SealClassesWhenSafe`, `InsertBlankLineBeforeReturnAndThrowStatements`, `ConvertToCollectionExpressions`, `ReuseJsonSerializerOptionsForCA1869`, `SimplifySingleStatementLambdas`, `ConvertToPatternMatchingNullChecks`, `ConvertStringFormatToInterpolation`, `ConvertToStringNameOf`, `InlineOutVariableDeclarations`, `MoveUsingsOutsideNamespace`, `OrganizeUsings`, `UpdateEndRegionDirectives`, `UpdateSingleLineMethods`, `UpdateAccessorsToBothBeSingleLineOrMultiLine`, `FormatComments`, `RemoveRegions`, `RemoveByteOrderMark`, `RemoveEndOfLineWhitespace`, `RemoveBlankLinesAtTop`, `RemoveBlankLinesAtBottom`, `RemoveBlankLinesAfterAttributes`, `RemoveBlankLinesAfterOpeningBrace`, `RemoveBlankLinesBeforeClosingBrace`, `RemoveBlankLinesBetweenChainedStatements`, `RemoveMultipleConsecutiveBlankLines`, `FileHeaderCSharp`

### Reorganize options (`codeJanitor.reorganize.*`) (13)

`ReorganizeRunAtStartOfCleanup`, `ReorganizeAlphabetizeMembersOfTheSameGroup`, `ReorganizeExplicitMembersAtEnd`, `ReorganizeKeepMembersWithinRegions`, `ReorganizePrimaryOrderByAccessLevel`, `ReorganizeReverseOrderByAccessLevel`, `ReorganizeRegionsInsertNewRegions`, `ReorganizeRegionsIncludeAccessLevel`, `ReorganizeRegionsIncludeAccessLevelForMethodsOnly`, `ReorganizeRegionsInsertKeepEvenIfEmpty`, `ReorganizeRegionsRemoveExistingRegions`, `ReorganizePerformWhenPreprocessorConditionals`, `ReorganizeMemberTypes`

### Razor and Blazor formatter (`codeJanitor.razor.*`) (3)

`FormatRazorComponents`, `RazorIndentSize`, `RazorIndentStyle`

### `.editorconfig` rules (19)

`EditorConfigNamingPrivateFields`, `EditorConfigNamingLocalsAndParameters`, `EditorConfigNamingConstants`, `EditorConfigNamingInterfacePrefix`, `EditorConfigIndentStyleSpace`, `EditorConfigTrimTrailingWhitespace`, `EditorConfigInsertFinalNewline`, `EditorConfigCharset`, `EditorConfigNamespaceDeclarations`, `EditorConfigUsingDirectivePlacement`, `EditorConfigVarPreference`, `EditorConfigRequireAccessibilityModifiers`, `EditorConfigReadonlyField`, `EditorConfigCA1822MakeMemberStatic`, `EditorConfigCA1852SealInternalType`, `EditorConfigCA1507UseNameOf`, `EditorConfigIDE0005RemoveDuplicateUsings`, `EditorConfigIDE0051RemoveUnusedPrivateMember`, `EditorConfigNewLineBeforeOpenBrace`

### Commands (remove XML documentation, fix namespace, split top-level types) (3)

`RemoveXmlDocumentation`, `FixNamespace`, `SplitTopLevelTypes`

## Adding a scenario

Add the file, add the entry to `scenarios.json`, make sure the solution still builds and that `Run()` is deterministic.
Class names are the option names (`csharp_prefer_braces` becomes `CsharpPreferBraces`).

## License

MIT, see [LICENSE](LICENSE).
