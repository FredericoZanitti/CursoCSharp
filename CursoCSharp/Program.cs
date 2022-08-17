using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Coleções;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Estrutura IF - EstruturasDeControle", EstruturaIf.Executar},
                {"Estrutura Switch - EstruturasDeControle", EstruturaSwitch.Executar},
                {"Estrutura ForEach - EstruturasDeControle", EstruturaForEach.Executar},
                {"Membros55555 - Classes e Métodos", Membros.Executar},
                {"Calculadora Comum - Classes e Métodos", MetodosComRetorno.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos", DesafioAtributo.Executar},
                {"Parâmetros Variáveis - Classes e Métodos", ParametrosVariaveis.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GettersESetters.Executar},
                {"Ready Only - Classes e Métodos", Readonly.Executar},
                {"Enumerações - Classes e Métodos", ExemploEnum.Executar},
                {"Arrays - Coleções", Arrays.Executar},
                {"Listas - Coleções", Listas.Executar},
                {"Filas - Coleções", Filas.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Dicionários - Coleções", Dicionarios.Executar},
                {"Heranças - Coleção OO", Heranca.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}