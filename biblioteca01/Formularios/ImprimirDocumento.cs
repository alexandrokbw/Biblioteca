using System.Drawing.Printing;

namespace biblioteca01.Formularios
{
    public class ImprimirDocumento : PrintDocument
    {
        private string[] texto;
        private string[] nome;
        private int numeroPagina;
        private int offset;

        public string[] Pessoa
        {
            get { return nome; }
            set { nome = value; }
        }


        public string[] Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        public int NumeroPagina
        {
            get { return numeroPagina; }
            set { numeroPagina = value; }
        }

        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        public ImprimirDocumento(string[] _texto)
        {
            this.Texto = _texto;
        }
    }
}
