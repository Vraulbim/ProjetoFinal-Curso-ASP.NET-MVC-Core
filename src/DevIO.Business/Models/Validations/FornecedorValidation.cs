using DevIO.Business.Models.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(fornecefor => fornecefor.Nome)
                .NotNull().WithMessage("O campo {PropertyName} não pode ser nulo")
                .NotEmpty().WithMessage("O campo {PropertyName} não pode estar em branco")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            When(fornecedor => fornecedor.TipoFornecedor == TipoFornecedor.Fisica, () =>
            {

                RuleFor(fornecedor => fornecedor.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres, porém foram fornecedido {PropertyValue}");

                RuleFor(fornecedor => CpfValidacao.Validar(fornecedor.Documento)).Equal(true)
                    .WithMessage("O Documento fornecido é inválido!");
            });

            When(fornecedor => fornecedor.TipoFornecedor == TipoFornecedor.Juridica, () =>
            {
                RuleFor(fornecedor => fornecedor.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres, porém foram fornecedido {PropertyValue}");

                RuleFor(fornecedor => CnpjValidacao.Validar(fornecedor.Documento)).Equal(true)
                    .WithMessage("O Documento fornecido é inválido!");

            });
        }
    }
}
