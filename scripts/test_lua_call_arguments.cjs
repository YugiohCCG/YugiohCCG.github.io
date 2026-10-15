const assert = require('node:assert/strict');
const luaparse = require('luaparse');
const callArguments = require('./lua_call_arguments.cjs');
for (const [source, expected] of [
  ['f()', []],
  ['f(1, "x")', ['NumericLiteral', 'StringLiteral']],
  ['f {1}', ['TableConstructorExpression']],
  ['f "x"', ['StringLiteral']],
]) {
  const call = luaparse.parse(source, {ranges:true}).body[0].expression;
  assert.deepEqual(callArguments(call).map(a => a.type), expected, source);
  for (const arg of callArguments(call)) assert.ok(source.slice(...arg.range).length);
}
console.log('Lua call argument regression checks passed (normal, empty, table and string calls).');
