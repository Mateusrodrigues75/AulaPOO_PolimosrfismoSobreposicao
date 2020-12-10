using System;
using AulaPOO_PolimosrfismoSobreposicao.classes;

namespace AulaPOO_PolimosrfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Professor professor = new Professor();
            professor.ValeRefeicao();

            Coordenador coordenador = new Coordenador();
            coordenador.ValeRefeicao();
        }
    }
}
