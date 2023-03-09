float[,] mat = { { 3, 2, 0 }, { 4, 5, 0 }, { 9, 8, 0}, { 4, 5, 0 }, { 9, 8, 0 } };

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
    



