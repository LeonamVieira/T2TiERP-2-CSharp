using System;
using System.Text;
using System.Collections.Generic;


namespace ContasPagarService.Model {
    
    public class ViewFinLancamentoPagarDTO {
        public ViewFinLancamentoPagarDTO() { }
        public System.Nullable<long> Id { get; set; }
        public int IdLancamentoPagar { get; set; }
        public System.Nullable<int> QuantidadeParcela { get; set; }
        public System.Nullable<decimal> ValorLancamento { get; set; }
        public System.Nullable<System.DateTime> DataLancamento { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdParcelaPagar { get; set; }
        public System.Nullable<int> NumeroParcela { get; set; }
        public System.Nullable<System.DateTime> DataVencimento { get; set; }
        public System.Nullable<decimal> ValorParcela { get; set; }
        public System.Nullable<decimal> TaxaJuro { get; set; }
        public System.Nullable<decimal> ValorJuro { get; set; }
        public System.Nullable<decimal> TaxaMulta { get; set; }
        public System.Nullable<decimal> ValorMulta { get; set; }
        public System.Nullable<decimal> TaxaDesconto { get; set; }
        public System.Nullable<decimal> ValorDesconto { get; set; }
        public string SiglaDocumento { get; set; }
        public string NomeFornecedor { get; set; }
        public Int64 IdStatusParcela { get; set; }
        public string SituacaoParcela { get; set; }
        public string DescricaoSituacaoParcela { get; set; }
        public int IdContaCaixa { get; set; }
        public string NomeContaCaixa { get; set; }

        public IList<FinParcelaPagamentoDTO> ListaFinParcelaPagamento { get; set; }

    }
}
