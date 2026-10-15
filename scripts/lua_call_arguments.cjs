// luaparse stores normal, table-sugar and string-sugar call arguments differently.
module.exports = function callArguments(node) {
  if (Array.isArray(node.arguments)) return node.arguments;
  if (node.arguments) return [node.arguments];
  return node.argument ? [node.argument] : [];
};
