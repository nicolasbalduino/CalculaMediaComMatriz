float[,] mat = new float[5, 3];

Random sorteio = new Random();

for (int linha = 0; linha < mat.GetLength(0); linha++)
    for (int coluna = 0; coluna < (mat.GetLength(1) - 1); coluna++)
        mat[linha, coluna] = (float) sorteio.Next(100) / 10;

void CalculaMedia(float[,] mat)
{
    for (int linha = 0; linha < mat.GetLength(0); linha++)
    {
        for (int coluna = 0; coluna < (mat.GetLength(1) - 1); coluna++)
            mat[linha, (mat.GetLength(1) - 1)] += mat[linha, coluna];

        mat[linha, (mat.GetLength(1) - 1)] /= (mat.GetLength(1) - 1);
    }
}


CalculaMedia(mat);

for (int linha = 0; linha < mat.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
        Console.Write("[" + mat[linha, coluna] + "] ");

    Console.Write("\n");
}
