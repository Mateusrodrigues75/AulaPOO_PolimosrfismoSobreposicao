using System;

namespace AulaPOO_PolimosrfismoSobreposicao.classes
{
    public class Taxa
    {
        private float valor;
        

        public virtual void ValeRefeicao(){
            Console.WriteLine("A taxa base a ser paga é de 5%");
        }
    }
}