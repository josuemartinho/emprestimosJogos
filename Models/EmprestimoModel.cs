using System.Data;

namespace emprestimosJogos.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string JogoEmprestado{ get; set;}
        public DateTime DataUltimaAtualizacao{ get; set; } = DateTime.Now;
    }
}
