namespace exemplo__dado__em__aula.Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.23f;

        public static float RealParaDolar(float valorRS){
            return valorRS/ CotacaoDolar;
        }

        public static float DolarParaReal(float valorUS){
            return valorUS * CotacaoDolar;
        }
    }
}