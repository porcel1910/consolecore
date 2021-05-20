namespace GameTOP
{
    
    public class jogoFoda
    {
        private readonly IJogador _Jogador1;
        private readonly IJogador _Jogador2;
        public jogoFoda(IJogador jogador1, IJogador jogador2)
        {
            _Jogador1 = jogador1;
            _Jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            System.Console.Write( _Jogador1.Corre());
            System.Console.Write( _Jogador1.Chuta());
            System.Console.Write( _Jogador1.Passe());

            System.Console.Write("\n Próximo Jogador \n");

            System.Console.Write( _Jogador2.Corre());
            System.Console.Write( _Jogador2.Chuta());
            System.Console.Write( _Jogador2.Passe());
        }
        
    }
}