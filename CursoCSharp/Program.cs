using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMétodos;
namespace CursoCSharp
{
    class Program

    {
        public static object MetodoComRetorno { get; private set; }

        static void Main(string[] args)

        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>(){

                //Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar },

                { "Comentários - Fundamentos", Comentários.Executar },

                { "Variáveis e Constantes - Fundamentos", Var_e_Consts.Executar },

                { "Inferência - Fundamentos", Inferencia.Executar }, 
                
                { "Interpolação - Fundamentos", Interpolação.Executar },
                
                { "Notacão Ponto - Fundamentos", NotacaoPonto.Executar },
                
                { "Lendo Dados - Fundamentos", LendoDados.Executar },
                
                { "Formatando Números - Fundamentos", FormatandoNumero.Executar },
                
                { "Conversões  - Fundamentos", Conversao.Executar },
                
                { "Operadores aritméticos  - Fundamentos", OperadoresAritmeticos.Executar }, 
                
                { "Operadores relacionais  - Fundamentos", Operadoresrelacionais.Executar },
                
                { "Operadores lógicos  - Fundamentos", Operadoreslogicos.Executar },
                
                { "Operadores de atribuição  - Fundamentos", Operadoresatribuição.Executar },
                
                { "Operadores unários  - Fundamentos", OperadoresUnarios.Executar },
                
                //Estruturas de Controle

                { "Operadores ternários  - Fundamentos", Operadoresternarios.Executar },
                
                { "Estruturas IF  - Estruturas de controle", EstruturasIF.Executar }, 
                
                { "Estruturas IF/ELSE  - Estruturas de controle", EstruturasIfElse.Executar },
                
                { "Estruturas IF/ELSE/IF  - Estruturas de controle", EstruturasIfElseIf.Executar },
                
                { "Estruturas Switch  - Estruturas de controle", EstruturasSwitch.Executar },
                
                { "Estruturas While  - Estruturas de controle", EstruturasWhile.Executar },
                
                { "Estruturas Do While  - Estruturas de controle", EstruturasDoWhile.Executar },

                { "Estruturas For  - Estruturas de controle", EstruturasFor.Executar },
               
                { "Estruturas For Each  - Estruturas de controle", EstruturasForEach.Executar },

                { "Usando Break  - Estruturas de controle", UsandoBreak.Executar },

                //{ "Usando Continue - Estruturas de controle", UsandoContinue.Executar },

                //Classes e métodos

                { " Membros - Classes e Métodos", Membros.Executar },  
                
                { " Construtores - Classes e Métodos", Construtrores.Executar },
                
                { " Métodos com retorno - Classes e Métodos" , MetodoComRetorno.Executar },
                
          



            });

            central.SelecionarEExecutar();
        }
    }
}