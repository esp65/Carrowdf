namespace Carrowdf
{
    internal class Carro
    {
        private string mar;
        private int modl;
        private string maxvel;
        private string propietario;

        public Carro(string mar, int modl, string maxvel, string propietario)
        {
            this.mar = mar;
            this.modl = modl;
            this.maxvel = maxvel;
            this.propietario = propietario;
        }
    }
}