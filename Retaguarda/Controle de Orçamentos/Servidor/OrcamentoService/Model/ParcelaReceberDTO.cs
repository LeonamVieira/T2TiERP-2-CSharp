﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace OrcamentoService.Model
{
    [DataContract]
    public class ParcelaReceberDTO
    {
        [DataMember]
        public int? id { get; set; }

        [DataMember]
        public int? idStatusParcelaReceber { get; set; }

        [DataMember]
        public LancamentoReceberDTO lancamentoReceber { get; set; }

        [DataMember]
        public System.Nullable<System.DateTime> dataEmissao { get; set; }
        [DataMember]
        public System.Nullable<System.DateTime> dataVencimento { get; set; }
        [DataMember]
        public System.Nullable<System.DateTime> descontoAte { get; set; }
        [DataMember]
        public System.Nullable<decimal> valor { get; set; }
        [DataMember]
        public System.Nullable<decimal> taxaJuro { get; set; }
        [DataMember]
        public System.Nullable<decimal> taxaMulta { get; set; }
        [DataMember]
        public System.Nullable<decimal> taxaDesconto { get; set; }
        [DataMember]
        public System.Nullable<decimal> valorJuro { get; set; }
        [DataMember]
        public System.Nullable<decimal> valorMulta { get; set; }
        [DataMember]
        public System.Nullable<decimal> valorDesconto { get; set; }
        [DataMember]
        public int? numeroParcela{ get; set; }
    }
}