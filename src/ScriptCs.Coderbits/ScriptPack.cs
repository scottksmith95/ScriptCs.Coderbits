using ScriptCs;
using ScriptCs.Contracts;

namespace ScriptCs.Coderbits
{
    public class CoderbitsScriptPack : IScriptPack
    {
        IScriptPackContext IScriptPack.GetContext()
        {
            return new Coderbits();
        }

        void IScriptPack.Initialize(IScriptPackSession session)
        {
        }

        void IScriptPack.Terminate()
        {
        }
    }
}
