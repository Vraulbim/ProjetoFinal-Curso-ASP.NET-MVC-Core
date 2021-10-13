﻿using DevIO.App.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Fornecedor")]
        [Required(ErrorMessage = "O campor {0} é obrigatório")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve conter de {2} a {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} deve conter de {2} a {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [NotMapped]
        [DisplayName("Imagem do Produto")]
        public IFormFile ImagemUpload { get; set; }

        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Moeda]
        public decimal Valor { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo ?")]
        public bool Ativo { get; set; }

        [NotMapped]
        public FornecedorViewModel Fornecedor { get; set; }

        [NotMapped]
        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    }
}
