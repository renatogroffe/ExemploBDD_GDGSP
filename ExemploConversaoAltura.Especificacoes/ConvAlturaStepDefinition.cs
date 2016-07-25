using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExemploConversaoAltura.Especificacoes
{
    [Binding]
    public sealed class ConvAlturaStepDefinition
    {
        private double _pes;
        private double _metros;

        [Given("que foi informada uma altura de (.*) pé\\(s\\)")]
        public void PreencherAlturaPes(double pes)
        {
            _pes = pes;
        }

        [When("for solicitada a conversão deste valor")]
        public void ProcessarConversaoAltura()
        {
            _metros = ConversorAltura.PesParaMetros(_pes);
        }

        [Then("o valor equivalente será de (.*) metro\\(s\\)")]
        public void VerificarCalculoMetros(double metros)
        {
            Assert.AreEqual(metros, _metros);
        }
    }
}