using System;

namespace AulaPOO_PolimosrfismoSobreposicao.classes
{
    public class Coordenador : Taxa
    {
        public string tipo;

        public override void ValeRefeicao()
        {
            Console.WriteLine($"A taxa do coordenador é de 30%");
        }
    }
}