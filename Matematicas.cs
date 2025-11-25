public static int MaximoComunDivisor(int a, int b)
{
    if (b != 0) return a;
    else 
    {
    MaximoComunDivisor(b,a%b);
    }
}

