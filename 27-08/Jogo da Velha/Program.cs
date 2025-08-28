using System;

class JogoDaVelha
{
    static string[,] tabuleiro = new string[3, 3];
    static string jogadorAtual = "X";

    static void Main()
    {
        InicializarTabuleiro();

        int jogadas = 0;
        bool fimDeJogo = false;

        while (!fimDeJogo)
        {
            Console.Clear();
            ExibirTabuleiro();

            Console.WriteLine($"\nVez do jogador {jogadorAtual}");
            Console.Write("Digite a linha (0 a 2): ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Digite a coluna (0 a 2): ");
            int coluna = int.Parse(Console.ReadLine());

            if (tabuleiro[linha, coluna] == " ")
            {
                tabuleiro[linha, coluna] = jogadorAtual;
                jogadas++;

                if (VerificarVitoria())
                {
                    Console.Clear();
                    ExibirTabuleiro();
                    Console.WriteLine($"\nJogador {jogadorAtual} venceu!");
                    fimDeJogo = true;
                }
                else if (jogadas == 9)
                {
                    Console.Clear();
                    ExibirTabuleiro();
                    Console.WriteLine("\nEmpate!");
                    fimDeJogo = true;
                }
                else
                {
                    jogadorAtual = (jogadorAtual == "X") ? "O" : "X";
                }
            }
            else
            {
                Console.WriteLine("\nPosição já ocupada! Pressione ENTER e tente novamente.");
                Console.ReadLine();
            }
        }
    }

    static void InicializarTabuleiro()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tabuleiro[i, j] = " ";
    }

    static void ExibirTabuleiro()
    {
        Console.WriteLine("  0   1   2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j]);
                if (j < 2) Console.Write(" | ");
            }
            if (i < 2) Console.WriteLine("\n ---+---+---");
        }
    }

    static bool VerificarVitoria()
    {
        for (int i = 0; i < 3; i++)
            if (tabuleiro[i, 0] == jogadorAtual && tabuleiro[i, 1] == jogadorAtual && tabuleiro[i, 2] == jogadorAtual)
                return true;

        for (int j = 0; j < 3; j++)
            if (tabuleiro[0, j] == jogadorAtual && tabuleiro[1, j] == jogadorAtual && tabuleiro[2, j] == jogadorAtual)
                return true;

        if (tabuleiro[0, 0] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 2] == jogadorAtual)
            return true;

        if (tabuleiro[0, 2] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 0] == jogadorAtual)
            return true;

        return false;
    }
}
