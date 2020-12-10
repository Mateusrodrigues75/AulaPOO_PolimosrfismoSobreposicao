using System;

namespace AulaPOO_PolimosrfismoSobreposicao.classes
{
    public class Professor : Taxa
    {
        public string turma;

        public override void ValeRefeicao(){
            Console.WriteLine($"A taxa do professor é 10%");
        }
    }
}