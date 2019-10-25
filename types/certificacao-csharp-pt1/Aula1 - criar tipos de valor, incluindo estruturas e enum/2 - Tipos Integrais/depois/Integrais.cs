using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposIntegrais : IAulaItem
    {
        public void Executar()
        {
            int idade = 24;                 //System.Int32

            char resposta = 'S';            //System.Char

            byte nivelDeAzul = 0xFF;        //de 0 ate 255 em decimal

            short passageirosVoo = 230;     //System.Int16

            sbyte nivelDeBrilho = -127;     //byte que vai de -128 ate 127

            ushort passageirosNavio = 230;  //um short que nao permite negativo


            //prefixo 'u' (unsigned), também é encontrado em uint e ulong
            //e segue o mesmo padrao de não permitir numeros negativos e aumentar o range dos numeros positivos
        }
    }
}
