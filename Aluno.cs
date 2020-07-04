using System.Diagnostics;

namespace Revisao
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public struct Aluno
    {
        public string Nome { get; set; }

        public decimal Nota { get; set; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}