using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {



                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);
                    Console.Write("Origem:  ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("destino:");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);

                }

                /*
                               PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                               Console.WriteLine(pos);
                               Console.WriteLine(pos.ToPosicao());
                
                Tabuleiro tab = new Tabuleiro(8, 8);
                                           tab.ColocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
                                           tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                                             tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 4));
                                           Tela.ImprimirTabuleiro(tab);
                               */
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
