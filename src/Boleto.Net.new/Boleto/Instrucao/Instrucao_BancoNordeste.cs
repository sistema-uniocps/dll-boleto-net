using System;
using System.Collections;
using System.Text;

namespace BoletoNet
{
    #region Enumerado

    public enum EnumInstrucoes_BancoNordeste
    {
        AcatarInstrucoesContidasNoTitulo = 5,
        NaoCobrarEncargosMoratarios = 8,
        NaoReceberAposVencimento = 12,
        AposVencimentoCobrarComissaoPermanenciaDoBNB = 15,
        SemInstrucoes = 00
    }

    #endregion

    public class Instrucao_BancoNordeste : AbstractInstrucao, IInstrucao
    {

        #region Construtores

        public Instrucao_BancoNordeste()
        {
            try
            {
                this.Banco = new Banco(004);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        public Instrucao_BancoNordeste(int codigo)
        {
            this.carregar(codigo, 0);
        }

        public Instrucao_BancoNordeste(int codigo, int nrDias)
        {
            this.carregar(codigo, nrDias);
        }

        public Instrucao_BancoNordeste(int codigo, double valor)
        {
            this.carregar(codigo, valor);
        }
        #endregion

        #region Metodos Privados

        private void carregar(int idInstrucao, double valor)
        {
            try
            {
                this.Banco = new Banco_Nordeste();
                this.Valida();

                switch ((EnumInstrucoes_BancoNordeste)idInstrucao)
                {
                    case EnumInstrucoes_BancoNordeste.AcatarInstrucoesContidasNoTitulo:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.AcatarInstrucoesContidasNoTitulo;
                        this.Descricao = "Acatar instru��es contidas no t�tulo";
                        break;
                    case EnumInstrucoes_BancoNordeste.AposVencimentoCobrarComissaoPermanenciaDoBNB:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.AposVencimentoCobrarComissaoPermanenciaDoBNB;
                        this.Descricao = "Ap�s vencimento, cobrar comiss�o de perman�ncia do BANCO DO NORDESTE";
                        break;
                    case EnumInstrucoes_BancoNordeste.NaoCobrarEncargosMoratarios:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.NaoCobrarEncargosMoratarios;
                        this.Descricao = "N�o cobrar encargos morat�rios";
                        break;
                    case EnumInstrucoes_BancoNordeste.NaoReceberAposVencimento:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.NaoReceberAposVencimento;
                        this.Descricao = "N�o receber ap�s vencimento";
                        break;
                        case EnumInstrucoes_BancoNordeste.SemInstrucoes:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.SemInstrucoes;
                        this.Descricao = "Sem Instru��es � Acata as instru��es da Carteira do Cedente";
                        break;
                    default:
                        this.Codigo = 0;
                        this.Descricao = " (Selecione) ";
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }


        private void carregar(int idInstrucao, int nrDias)
        {
            try
            {
                this.Banco = new Banco_Nordeste();
                this.Valida();

                switch ((EnumInstrucoes_BancoNordeste)idInstrucao)
                {
                    case EnumInstrucoes_BancoNordeste.AcatarInstrucoesContidasNoTitulo:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.AcatarInstrucoesContidasNoTitulo;
                        this.Descricao = "Acatar instru��es contidas no t�tulo";
                        break;
                    case EnumInstrucoes_BancoNordeste.AposVencimentoCobrarComissaoPermanenciaDoBNB:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.AposVencimentoCobrarComissaoPermanenciaDoBNB;
                        this.Descricao = "Ap�s vencimento, cobrar comiss�o de perman�ncia do BANCO DO NORDESTE";
                        break;
                    case EnumInstrucoes_BancoNordeste.NaoCobrarEncargosMoratarios:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.NaoCobrarEncargosMoratarios;
                        this.Descricao = "N�o cobrar encargos morat�rios";
                        break;
                    case EnumInstrucoes_BancoNordeste.NaoReceberAposVencimento:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.NaoReceberAposVencimento;
                        this.Descricao = "N�o receber ap�s vencimento";
                        break;
                    case EnumInstrucoes_BancoNordeste.SemInstrucoes:
                        this.Codigo = (int)EnumInstrucoes_BancoNordeste.SemInstrucoes;
                        this.Descricao = "Sem Instru��es � Acata as instru��es da Carteira do Cedente";
                        break;
                    default:
                        this.Codigo = 0;
                        this.Descricao = " (Selecione) ";
                        break;
                }

                this.QuantidadeDias = nrDias;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        public override void Valida()
        {
            //base.Valida();
        }

        #endregion

    }
}
