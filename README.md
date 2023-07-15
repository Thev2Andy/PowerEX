# PowerEX
PowerEX is a basic expression evaluator that supports both mathematical expressions and basic boolean algebra expressions.

# Features
* Includes both a basic boolean expression evaluator and a mathematical expression evaluator.
```cs
// Mathematical expression.
string MathExpression = "1 + 1 - 1 + 1 * 2 - 2";
float Result = Parser.Parse(MathExpression, new EmptyContext()) as float;

// Boolean expression.
string BooleanExpression = "!((1 & 0) | 1)";
bool BooleanResult = BooleanEvaluator.Evaluate(BooleanExpression);
```
* Supports expression evaluator contexts for mathematical expressions that can support functions and variables.
```cs
string Result = Parser.Parse("pow(pi, 2) + (1 - pi)", new YourOwnCustomContext());
```
* The mathematical expression evaluator includes basic greater-than, less-than and equal checks, and returns either '`1`' or '`0`' if true or false.
* Cross-platform support.
* Dependency-free.
* Full 128-bit precision support using `Decimal` types.
* Documented using XML documentation.
* Blazingly fast. (Around 1-10 ms for any expression, ranging from a simple `1 + 1` to this `(((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((1 + 2) * 3) / 4) - 5) * 6) / 7) - 8) * 9) / 10) - 11) * 12) / 13) - 14) * 15) / 16) - 17) * 18) / 19) - 20) * 21) / 22) - 23) * 24) / 25) - 26) * 27) / 28) - 29) * 30) / 31) - 32) * 33) / 34) - 35) * 36) / 37) - 38) * 39) / 40) - 41) * 42) / 43) - 44) * 45) / 46) - 47) * 48) / 49) - 50) * 51) / 52) - 53) * 54) / 55) - 56) * 57) / 58) - 59) * 60) / 61) - 62) * 63) / 64) - 65) * 66) / 67) - 68) * 69) / 70) - 71) * 72) / 73) - 74) * 75) / 76) - 77) * 78) / 79) - 80) * 81) / 82) - 83) * 84) / 85) - 86) * 87) / 88) - 89) * 90) / 91) - 92) * 93) / 94) - 95) * 96) / 97) - 98) * 99) / 100)))))))))))))))`.)